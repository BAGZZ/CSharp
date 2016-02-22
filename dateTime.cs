using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class dateTime
    {
        static void Main(string[] args)
        {
            //year, month, and day.
            Int32 year;
            Int32 month;
            Int32 day;

            Console.Out.WriteLine("Enter birthdate separated by space (year month day). ex:1993 9 28");
            string input = Console.ReadLine();
            string[] args1 = input.Split(' ');

            Int32.TryParse(args1[0], out year);
            Int32.TryParse(args1[1], out month);
            Int32.TryParse(args1[2], out day);

            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(year, month, day);
            int age = today.Year - birthday.Year;
            if(today.Month<birthday.Month)
            {
                age = age - 1;
            }
            else if(today.Month==birthday.Month)
            {
                if (today.Day < birthday.Day)
                {
                    age = age - 1;
                }
                else if(birthdayToday(today, birthday))
                {
                    Console.Out.WriteLine("Happy Birthday!! I'm so glad I could share this moment with you!!");
                }
            }

            //print out age and see if the age is realistic.
            Console.Out.WriteLine("That would make you " + age + " if im not mistaken.");
            if (age < 0)
            {
                Console.Out.WriteLine("That's not possible, because you aren't born yet!");
            }
            else if (age > 115)
            {
                Console.Out.WriteLine("Come on, nobody is that old! Don't lie to me.");
            }

            //prints out signs with strengths attached
            Console.Out.Write("Here are your signs and strengths:" +
            Environment.NewLine + "Western Zodiac = " + findSignWest(month, day, year) +
            Environment.NewLine + "Chinese Zodiac = " + findSignChinese(year) + Environment.NewLine);

            Console.WriteLine(Environment.NewLine + "Press any key to exit.");
            Console.Read();

        }

        //tests whether today is the user's birthday
        public static Boolean birthdayToday(DateTime today, DateTime birthday){
            if (today.Day == birthday.Day && today.Month == birthday.Month)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //calculates western zodiac sign
        public static String findSignWest(int month, int day, int year)
        {
            if (((month == 1) && (day >= 20 && day <= 31)) || ((month == 2) && (day >= 01 && day <= 18)))
            {
                return "AQUARIUS - Strengths: Progressive, original, independent, humanitarian";
            }
            if (((month == 2) && (day >= 19 && day <= 29)) || ((month == 3) && (day >= 01 && day <= 20)))
            {
                return "PISCES - Strengths: Compassionate, artistic, intuitive, gentle, wise, musical";
            }
            if (((month == 3) && (day >= 21 && day <= 31)) || ((month == 4) && (day >= 01 && day <= 19)))
            {
                return "ARIES - Strengths: Courageous, determined, confident, enthusiastic, optimistic, honest, passionate";
            }
            if (((month == 4) && (day >= 20 && day <= 30)) || ((month == 5) && (day >= 01 && day <= 20)))
            {
                return "TAURUS - Strengths: Reliable, patient, practical, devoted, responsible, stable";
            }
            if (((month == 5) && (day >= 21 && day <= 31)) || ((month == 6) && (day >= 01 && day <= 20)))
            {
                return "GEMINI - Strengths: Gentle, affectionate, curious, adaptable, ability to learn quickly and exchange ideas";
            }
            if (((month == 6) && (day >= 21 && day <= 30)) || ((month == 7) && (day >= 01 && day <= 22)))
            {
                return "CANCER - Strengths: Tenacious, highly imaginative, loyal, emotional, sympathetic, persuasive";
            }
            if (((month == 7) && (day >= 23 && day <= 31)) || ((month == 8) && (day >= 01 && day <= 22)))
            {
                return "LEO - Strengths: Creative, passionate, generous, warm-hearted, cheerful, humorous";
            }
            if (((month == 8) && (day >= 23 && day <= 31)) || ((month == 9) && (day >= 01 && day <= 22)))
            {
                return "VIRGO - Strengths: Loyal, analytical, kind, hardworking, practical";
            }
            if (((month == 9) && (day >= 23 && day <= 30)) || ((month == 10) && (day >= 01 && day <= 22)))
            {
                return "LIBRA - Strengths: Cooperative,diplomatic, gracious, fair-minded, social";
            }
            if (((month == 10) && (day >= 23 && day <= 31)) || ((month == 11) && (day >= 01 && day <= 21)))
            {
                return "SCORPIO - Strengths: Resourceful, brave, passionate, stubborn, a true friend";
            }
            if (((month == 11) && (day >= 22 && day <= 30)) || ((month == 12) && (day >= 01 && day <= 21)))
            {
                return "SAGITTARIUS - Strengths: Generous, idealistic, great sense of humor";
            }
            if (((month == 12) && (day >= 22 && day <= 31)) || ((month == 1) && (day >= 01 && day <= 19)))
            {
                return "CAPRICORN - Strengths: Responsible, disciplined, self-control, good managers";
            }
            return "no sign";
        }

        //calculates chinese zodiac sign
        public static String findSignChinese(int year)
        {
            if (year == 1912 || year == 1924 || year == 1936 || year == 1948 || year == 1960 || year == 1972 ||
                year == 1984 || year == 1996 || year == 2008 || year == 2020|| year == 2032)
            {
                return "RAT - Strengths: Adaptable, smart, cautious, acute, alert, positive, flexible, outgoing, cheerful ";
            }
            if (year == 1913 || year == 1925 || year == 1937 || year == 1949 || year == 1961 || year == 1973 ||
                year == 1985 || year == 1997 || year == 2009 || year == 2021 || year == 2033)
            {
                return "OX - Strengths: honest, industrious, patient, cautious, level-headed, strong-willed, persistent";
            }
            if (year == 1914 || year == 1926 || year == 1938 || year == 1950 || year == 1962 || year == 1974 ||
                year == 1986 || year == 1998 || year == 2010 || year == 2022 || year == 2034)
            {
                return "TIGER - Strengths: Tolerant, loyal, valiant, courageous, trustworthy, intelligent, virtuous ";
            }
            if (year == 1915 || year == 1927 || year == 1939 || year == 1951 || year == 1963 || year == 1975 ||
                year == 1987 || year == 1999 || year == 2011 || year == 2023 || year == 2035)
            {
                return "RABBIT - Strengths: Gentle, sensitive, compassionate, amiable, modest, and merciful";
            }
            if (year == 1916 || year == 1928 || year == 1940 || year == 1952 || year == 1964 || year == 1976 ||
                year == 1988 || year == 2000 || year == 2012 || year == 2024 || year == 2036)
            {
                return "DRAGON - Strengths: Decisive, inspiring, magnanimous, sensitive, ambitious, romantic";
            }
            if (year == 1917 || year == 1929 || year == 1941 || year == 1953 || year == 1965 || year == 1977 ||
                year == 1989 || year == 2001 || year == 2013 || year == 2025 || year == 2037)
            {
                return "SNAKE - Strengths: Soft-spoken, humorous, sympathetic, determined, passionate, smart";
            }
            if (year == 1918 || year == 1930 || year == 1942 || year == 1954 || year == 1966 || year == 1978 ||
                year == 1990 || year == 2002 || year == 2014 || year == 2026 || year == 2038)
            {
                return "HORSE - Strengths: Warm-Hearted, easygoing, independence, endurance, positive attitude";
            }
            if (year == 1919 || year == 1931 || year == 1943 || year == 1955 || year == 1967 || year == 1979 ||
                year == 1991 || year == 2003 || year == 2015 || year == 2027 || year == 2039)
            {
                return "SHEEP - Strengths: gentle, softhearted, considerate, attractive, hardworking, persistent, thrift";
            }
            if (year == 1920 || year == 1932 || year == 1944 || year == 1956 || year == 1968 || year == 1980 ||
                year == 1992 || year == 2004 || year == 2016 || year == 2028 || year == 2040)
            {
                return "MONKEY - Strengths: enthusiastic, self-assured, sociable, innovative";
            }
            if (year == 1922 || year == 1934 || year == 1946 || year == 1958 || year == 1970 || year == 1982 ||
                year == 1994 || year == 2006 || year == 2018 || year == 2030 || year == 2042)
            {
                return "DOG - Strengths: Valiant, loyal, responsible, clever, courageous, lively";
            }
            if (year == 1921 || year == 1933 || year == 1945 || year == 1957 || year == 1969 || year == 1981 ||
                year == 1993 || year == 2005 || year == 2017 || year == 2029 || year == 2041)
            {
                return "ROOSTER - Strengths: Independent, capable, warm-hearted, self-respect, quick minded";
            }
            if (year == 1923 || year == 1935 || year == 1947 || year == 1959 || year == 1971 || year == 1983 ||
                year == 1995 || year == 2007 || year == 2019 || year == 2031 || year == 2043)
            {
                return "PIG - Strengths: Warm-hearted, good-tempered, loyal, honest, gentle";
            }
            return "No sign";
        }
    }
}

