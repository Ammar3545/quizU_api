using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using QuizUApi.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace QuizUApi.Fixed
{
    public class StaticProperties
    {

        public static readonly List<Question> questions = new List<Question>()
        {
            new Question
            {
                question="Which one is the first search engine in internet",Option1="Google",Option2="Archie",Option3="Altavista",Option4="WAIS",Answer="Archie",
            },
            new Question
            {
                question="Number of bit used by the IPv6 address",Option1="32 bit",Option2="64 bit",Option3="128 bit",Option4="256 bit",Answer="128 bit",
            },
            new Question
            {
                question="First computer virus is known as",Option1="Rabbit",Option2="Creeper Virus",Option3="Elk Cloner",Option4="SCA Virus",Answer="Creeper Virus",
            },
            new Question
            {
                question="Firewall in computer is used for",Option1="Security",Option2="Data Transmission",Option3="Authentication",Option4="Monitoring",Answer="Security",
            },
            new Question
            {
                question="A dual layer Blue-ray Disc can store data upto",Option1="20GB",Option2="35 GB",Option3="12 GB",Option4="50 GB",Answer="50 GB",
            },
            new Question
            {
                question="Which of the following is not an operating system",Option1="DOS",Option2="Mac",Option3="C",Option4="Linux",Answer="C",
            },
             new Question
            {
                question="Which of the following is not a database management software",Option1="MySQL",Option2="Oracle",Option3="Sybase",Option4="COBOL",Answer="COBOL",
            },
             new Question
            {
                question="1024 bit is equal to how many byte",Option1="1 Byte",Option2="128 Byte",Option3="32 Byte",Option4="64 Byte",Answer="128 Byte",
            },
             new Question
            {
                question="Mac Operating System is developed by which company",Option1="IBM",Option2="Apple",Option3="Microsoft",Option4="Samsung",Answer="Apple",
            },
             new Question
            {
                question="Where is the headquter of Microsoft office located",Option1="Texas",Option2="NewYork",Option3="California",Option4="Washington",Answer="Washington",
            },
             new Question
            {
                question=".gif is an extension of",Option1="Image file",Option2="Video file",Option3="Audio file",Option4="Word file",Answer="Image file",
            },
            new Question
            {
                question="Which one is the first fully supported 64-bit operating system",Option1="Windows Vista",Option2="Mac",Option3="Linux",Option4="Windows XP",Answer="Linux",
            },
            new Question
            {
                question="Computer Hard Disk was first introduced in 1956 by",Option1="Dell",Option2="Apple",Option3="Microsoft",Option4="IBM",Answer="IBM",
            },
            new Question
            {
                question="Which of the following is not a web browser",Option1="MOSAIC",Option2="WWW",Option3="Facebook",Option4="Netscape navigator",Answer="Facebook",
            },
            new Question
            {
                question="In computer world, Trojan refer to",Option1="Virus",Option2="Malware",Option3="Worm",Option4="Spyware",Answer="Malware",
            },
            new Question
            {
                question=" Which one of the followings is a programming language",Option1="HTTP ",Option2="HTML",Option3="HPML",Option4="FTP",Answer="HTML",
            },
            new Question
            {
                question="Which protocol is used to received e-mail",Option1="SMTP",Option2="POP3",Option3="HTTP",Option4="FTP",Answer="POP3",
            },
            new Question
            {
                question="Which protocol is used to send e-mail",Option1="HTTP",Option2="POP3",Option3="SMTP",Option4="SSH",Answer="SMTP",
            },
            new Question
            {
                question="Which computer program converts assembly language to machine language",Option1="Interpreter",Option2="Compiler",Option3="Assembler",Option4="Comparator",Answer="Assembler",
            },
            new Question
            {
                question="A folder in windows computer can't be made with the name",Option1="can",Option2="con",Option3="mak",Option4="make",Answer="con",
            },
            new Question
            {
                question="A computer use which type of number system to calculate and to store data",Option1="decimal",Option2="octal",Option3="binary",Option4="hexadecimal",Answer="binary",
            },
            new Question
            {
                question="What is the extension type of the excel 2007 files",Option1=".xls",Option2=".xlsx",Option3=".xsl",Option4="None of the above",Answer=".xlsx",
            },
            new Question
            {
                question="The basic units of a excel spreedsheet where we enter data is called",Option1="Tab",Option2="Box",Option3="Cell",Option4=" None of the above",Answer="Cell",
            },
            new Question
            {
                question="Which one is a 'text editor' for Microsoft Windows",Option1="MS Word",Option2="MS Excel",Option3="WordPad",Option4="Notepad",Answer="Notepad",
            },
            new Question
            {
                question="How many layers in the TCP/IP protocol layers",Option1="7",Option2="5",Option3="4",Option4="11",Answer="4",
            },
            new Question
            {
                question="Which key combination is used to minimize all open windows and displays in the screen",Option1="Alt+M",Option2=" Shift+M",Option3="Windows Key+D",Option4="CTRL+D",Answer="Windows Key+D",
            },
            new Question
            {
                question="Which key combination is used to close a open application in Windows machine",Option1="Alt+F8",Option2="CTRL+X",Option3="Alt+F4",Option4="Shift+P",Answer="Alt+F4",
            },
            new Question
            {
                question="Total number of function keys in a computer keyboard",Option1="10",Option2="12",Option3="14",Option4="8",Answer="12",
            },
            new Question
            {
                question="Which one is the latest release of Windows Client Operating System",Option1="Windows XP",Option2="Windows 7",Option3="Windows 8",Option4="Windows 10",Answer="Windows 10",
            },
            new Question
            {
                question=" Which function key needs to be press during reboot to enter in Safe Mode of a Windows machine",Option1="F8",Option2="F2",Option3="F1",Option4="F9",Answer="F8",
            },
        };
    }
}

