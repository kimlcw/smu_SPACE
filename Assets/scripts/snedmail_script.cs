using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snedmail_script : MonoBehaviour
{
    public void sendmail()
    {
        string mailto = "202210133@sangmyung.kr"; //받는 메일 주소
        string subject = EscapeURL("[스터디상생플러스] 버그 리포트 / 기타 문의사항"); //보낼 메일의 제목
        string body = EscapeURL // 보낼 메일의 내용
            (
            "스터디상생플러스 <공강의 공간> 팀장&앱 개발자 이채원에게 메일을 전송합니다!\n\n\n"+
             "이 곳에 내용을 작성해주세요.\n\n" +
             "________________\n\n" +
             "Device Model : " + SystemInfo.deviceModel + "\n\n" +
             "Device OS : " + SystemInfo.operatingSystem + "\n\n" +
             "문의 내용 : "+
             "________________\n\n"
            );

        Application.OpenURL("mailto:" + mailto + "?subject=" + subject + "&body=" + body);
    }

    private string EscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }


}
