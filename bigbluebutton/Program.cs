using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace bigbluebutton
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataTable dt = new DataTable();
            dynamic dt;
            ClsBigBlueButton ObjBigBlueButton = new ClsBigBlueButton();

            #region "CreateMeeting"
            CreateMeetingParameters newcreatemeeting = new CreateMeetingParameters();

            newcreatemeeting.meetingID = System.Guid.NewGuid().ToString().Replace("-", "");
            newcreatemeeting.attendeePW = "mode";
            newcreatemeeting.moderatorPW = "okmode";
            newcreatemeeting.name = "ABC-Meeting";  //Remove space
            newcreatemeeting.record = true;
            newcreatemeeting.autoStartRecording = false;
            newcreatemeeting.allowStartStopRecording = true;
            //newcreatemeeting.logo = "http://yourdomain.com/img/new logo.png";
            //newcreatemeeting.bannerText = "Virtual Classroom by iPalPap";
            newcreatemeeting.muteOnStart = true;

            dt = ObjBigBlueButton.CreateMeeting(newcreatemeeting);//working);
                                                                  //Note : Extract Value from dt 
            Console.WriteLine(dt.response.returncode);
            //End Note
            #endregion

            #region "JoinMeeting"
            Parameters newjoinmeeting = new Parameters();

            newjoinmeeting.fullName = "Moderator";
            newjoinmeeting.meetingID = newcreatemeeting.meetingID;
            newjoinmeeting.password = newcreatemeeting.moderatorPW;
            //newjoinmeeting.userID = "2";
            //newjoinmeeting.redirect = "ok";
            //newjoinmeeting.joinViaHtml5 = "true";
            //newjoinmeeting.guest = "guest";
            //newjoinmeeting.createTime = "time";
            //newjoinmeeting.defaultLayout = "layout";
            //newjoinmeeting.clientURL = "client";
            //newjoinmeeting.avatarURL = "avatar";
            //newjoinmeeting.configToken = "config";

            string moderator = ObjBigBlueButton.JoinMeeting(newjoinmeeting);
            Console.WriteLine(moderator);

            Parameters newjoinmeeting2 = new Parameters();

            newjoinmeeting2.fullName = "Attendee";
            newjoinmeeting2.meetingID = newcreatemeeting.meetingID;
            newjoinmeeting2.password = newcreatemeeting.attendeePW;
            string attendee = ObjBigBlueButton.JoinMeeting(newjoinmeeting2);
            Console.WriteLine(attendee);
            #endregion

            #region "IsMeetingRunning"
            IsMeetingRunning newismeetingrunning = new IsMeetingRunning();
            newismeetingrunning.meetingID = newjoinmeeting.meetingID;
            dt = ObjBigBlueButton.IsMeetingRunning(newismeetingrunning);

            #endregion

            #region "getMeetings"
            //var meetings = ObjBigBlueButton.getMeetings();//working

            #endregion

            #region "GetMeetingInfo"

            //GetMeetingInfos newgetmeetinginfos = new GetMeetingInfos();

            //newgetmeetinginfos.meetingID = "1";

            //dt = ObjBigBlueButton.GetMeetingInfo(newgetmeetinginfos);

            #endregion

            #region "EndMeeting"
            EndMeeting newendmeeting = new EndMeeting();

            newendmeeting.meetingID = newcreatemeeting.meetingID;
            newendmeeting.password = newcreatemeeting.moderatorPW;

            dt = ObjBigBlueButton.EndMeeting(newendmeeting);

            #endregion

            #region "getRecordings"
            getRecordingsParameters getRecordingsParameters = new getRecordingsParameters();
            getRecordingsParameters.meetingID = newcreatemeeting.meetingID;
            dt = ObjBigBlueButton.getRecordings(getRecordingsParameters);
            #endregion

            #region "publishRecordings"
            publishRecordingsParameters publishRecordingsParameters = new publishRecordingsParameters();
            dt = ObjBigBlueButton.publishRecordings(publishRecordingsParameters);
            #endregion

            #region "updateRecordings"
            updateRecordingsParameters updateRecordings = new updateRecordingsParameters();
            dt = ObjBigBlueButton.updateRecordings(updateRecordings);
            #endregion

            #region "deleteRecordings"
            deleteRecordingsParameters deleteRecordingsParameters = new deleteRecordingsParameters();
            dt = ObjBigBlueButton.deleteRecordings(deleteRecordingsParameters);
            #endregion
            Console.ReadLine();

        }
    }
}
