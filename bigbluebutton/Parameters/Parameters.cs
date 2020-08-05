using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace bigbluebutton
{
    public class CreateMeetingParameters
    {
        public string name { get; set; } = "";//No Space Require in name field
        [Required]
        public string meetingID { get; set; }
        public string attendeePW { get; set; }
        public string moderatorPW { get; set; }
        public string welcome { get; set; }
        public string dialNumber { get; set; }
        public string voiceBridge { get; set; }
        public int maxParticipants { get; set; }
        public string logoutURL { get; set; }
        public bool record { get; set; }
        public int duration { get; set; }
        public bool isBreakout { get; set; }
        public string parentMeetingID { get; set; }
        public int sequence { get; set; }
        public bool freeJoin { get; set; }
        public string meta { get; set; }
        public string moderatorOnlyMessage { get; set; }
        public bool autoStartRecording { get; set; }
        public bool allowStartStopRecording { get; set; }
        public bool webcamsOnlyForModerator { get; set; }
        public string logo { get; set; }
        public string bannerText { get; set; }
        public string bannerColor { get; set; }
        public string copyright { get; set; }
        public bool muteOnStart { get; set; }
        public bool allowModsToUnmuteUsers { get; set; }
        public bool lockSettingsDisableCam { get; set; }
        public bool lockSettingsDisableMic { get; set; }
        public bool lockSettingsDisablePrivateChat { get; set; }
        public bool lockSettingsDisablePublicChat { get; set; }
        public bool lockSettingsDisableNote { get; set; }
        public bool lockSettingsLockedLayout { get; set; }
        public bool lockSettingsLockOnJoin { get; set; }
        public bool lockSettingsLockOnJoinConfigurable { get; set; }
        public string guestPolicy { get; set; }

    }
   //Join Meeting Class
    public class Parameters
    {
        [Required]
        public string fullName { get; set; }
        [Required]
        public string meetingID { get; set; }
        [Required]
        public string password { get; set; }
        public string createTime { get; set; }
        public string userID { get; set; }
        public string webVoiceConf { get; set; }
        public string configToken { get; set; }
        public string defaultLayout { get; set; }
        public string avatarURL { get; set; }
        public string redirect { get; set; }
        public string clientURL { get; set; }
        public string joinViaHtml5 { get; set; }
        public string guest { get; set; }
        public bool ShowInBrowser { get; set; }
    }

    public class IsMeetingRunning
    {
        [Required]
        public string meetingID { get; set; }
    }
    public class GetMeetingInfos
    {
        [Required]
        public string meetingID { get; set; }
    }
    public class EndMeeting
    {
        [Required]
        public string meetingID { get; set; }
        [Required]
        public string password { get; set; }
    }

    public class getRecordingsParameters
    {
        public string meetingID { get; set; }
        public string recordID { get; set; }
        public string state { get; set; }
        public string meta { get; set; }
    }

    public class publishRecordingsParameters
    {
        [Required]
        public string recordID { get; set; }
        [Required]
        public string publish { get; set; }
    }

    public class deleteRecordingsParameters
    {
        [Required]
        public string recordID { get; set; }
    }
    public class updateRecordingsParameters
    {
        [Required]
        public string recordID { get; set; }
        public string meta { get; set; }
    }
    
}
