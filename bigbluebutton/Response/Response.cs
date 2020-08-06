//Created by Nitin Sawant<nitin@nitinsawant.com>
//Copyright (c) 2020 zikbee.com

/* 
 https://xmltocsharp.azurewebsites.net/
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace bigbluebutton.Response
{
    [XmlRoot(ElementName = "meeting")]
    public class Meeting
    {
        [XmlElement(ElementName = "meetingName")]
        public string MeetingName { get; set; }
        [XmlElement(ElementName = "meetingID")]
        public string MeetingID { get; set; }
        [XmlElement(ElementName = "internalMeetingID")]
        public string InternalMeetingID { get; set; }
        [XmlElement(ElementName = "createTime")]
        public string CreateTime { get; set; }
        [XmlElement(ElementName = "createDate")]
        public string CreateDate { get; set; }
        [XmlElement(ElementName = "voiceBridge")]
        public string VoiceBridge { get; set; }
        [XmlElement(ElementName = "dialNumber")]
        public string DialNumber { get; set; }
        [XmlElement(ElementName = "attendeePW")]
        public string AttendeePW { get; set; }
        [XmlElement(ElementName = "moderatorPW")]
        public string ModeratorPW { get; set; }
        [XmlElement(ElementName = "running")]
        public string Running { get; set; }
        [XmlElement(ElementName = "duration")]
        public string Duration { get; set; }
        [XmlElement(ElementName = "hasUserJoined")]
        public string HasUserJoined { get; set; }
        [XmlElement(ElementName = "recording")]
        public string Recording { get; set; }
        [XmlElement(ElementName = "hasBeenForciblyEnded")]
        public string HasBeenForciblyEnded { get; set; }
        [XmlElement(ElementName = "startTime")]
        public string StartTime { get; set; }
        [XmlElement(ElementName = "endTime")]
        public string EndTime { get; set; }
        [XmlElement(ElementName = "participantCount")]
        public string ParticipantCount { get; set; }
        [XmlElement(ElementName = "listenerCount")]
        public string ListenerCount { get; set; }
        [XmlElement(ElementName = "voiceParticipantCount")]
        public string VoiceParticipantCount { get; set; }
        [XmlElement(ElementName = "videoCount")]
        public string VideoCount { get; set; }
        [XmlElement(ElementName = "maxUsers")]
        public string MaxUsers { get; set; }
        [XmlElement(ElementName = "moderatorCount")]
        public string ModeratorCount { get; set; }
        [XmlElement(ElementName = "attendees")]
        public string Attendees { get; set; }
        [XmlElement(ElementName = "metadata")]
        public string Metadata { get; set; }
        [XmlElement(ElementName = "isBreakout")]
        public string IsBreakout { get; set; }
    }

    [XmlRoot(ElementName = "meetings")]
    public class Meetings
    {
        [XmlElement(ElementName = "meeting")]
        public List<Meeting> Meeting { get; set; }
    }

    [XmlRoot(ElementName = "response")]
    public class GetMeetingResponse
    {
        [XmlElement(ElementName = "returncode")]
        public string Returncode { get; set; }
        [XmlElement(ElementName = "meetings")]
        public Meetings Meetings { get; set; }
    }

}
