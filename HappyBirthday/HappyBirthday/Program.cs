using System;
using System.Timers;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;

namespace Happy_Birthday
{
    public class Program : System.ComponentModel.Component
    {

        public static void valid_answer(string n)
        {
            string ans = "";
            do
            {
                ans = Console.ReadLine();
                if (ans != n)
                {
                    Console.WriteLine("Nope..!");
                }

            } while (ans != n);

            Console.WriteLine("ET OUIIIIIIIIIIIIIIIIIIIIIIIIIII");


        }
        
        public static void Main(string[] args)
        {

            
            Console.WriteLine("Comme on t'aime");
            Console.WriteLine("Et parce que on est tous un peu Sado (et certains Maso...)");
            Console.WriteLine("Donc voici un QCM qui te rappellera tes meilleurs QCM du S1 en guise de cadeau d'anniversaire !");
            Console.WriteLine("------------- Qestion 1 -------------");
            Console.WriteLine("Comment bien manger ?");
            Console.WriteLine("Se nourrir à la cafet");
            Console.WriteLine("Prendre un Uber Eats");
            Console.WriteLine("Prier que la machine bug encore");
            Console.WriteLine("Une popote");
            valid_answer("Une popote"); //Question 1
            Console.WriteLine("------------- Qestion 2 -------------");
            Console.WriteLine("Combien de Pokemon Aurelia possede t'elle selon Kerian et Benoit");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("6");
            Console.WriteLine("Autant que le nombre de cheveux qu'elle perd par jour");
            valid_answer("6"); //Question 2
            Console.WriteLine("------------- Qestion 3 -------------");
            Console.WriteLine("Durant les vacances de Noel, Kerian avait :");
            Console.WriteLine("Le SIDA");
            Console.WriteLine("La mononucléose");
            Console.WriteLine("La mucoviscidose");
            Console.WriteLine("Rien, franchement il a fait semblant");
            valid_answer("La mononucléose"); //Question 3
            Console.WriteLine("------------- Qestion 4 -------------");
            Console.WriteLine("1/ Quel est le métier de P.A la nuit ? (prend un num");
            Console.WriteLine("2/ Super justicier");
            Console.WriteLine("3/ Bénévole au bois de Boulogne");
            Console.WriteLine("4/ Cultivateur de champignon toujours au bois de boulogne");
            Console.WriteLine("5/ Garde forestier au bois de boulogne");
            Console.WriteLine("6/ Les 3 reponses au dessus en meme temps");
            valid_answer("6"); //Question 4
            Console.WriteLine("------------- Qestion 5 -------------");
            Console.WriteLine("LA QUESTION LA PLUS SIMPLE");
            Console.WriteLine("je marche comme un papi et mes amis me confondent parfois avec le diable. " +
                              "Mon ordi, repute pour ses 32Go de ram, m'a permit d'accumuler plusieurs " +
                              "centaines d'heures de jeu sur les civilisations. qui suis-je?");
            Console.WriteLine("4/ Kerian");
            Console.WriteLine("3/ PA");
            Console.WriteLine("2/ Aurelia");
            Console.WriteLine("1/ Benouat");
            Console.WriteLine("0/ Un dieu vivant, un bg des iles, la perfection incarnee, la reponse à l'univers");
            valid_answer("0"); //Question 5
            Console.WriteLine("------------- Qestion 6 -------------");
            Console.WriteLine("Le bon ordre ? (prend le num)");
            Console.WriteLine("1/ Brachiosaure < Togolais < Bambou");
            Console.WriteLine("2/ Bambou < Togolais <Brachiosaure ");
            Console.WriteLine("3/ Bampou < Brakiauzore < Taugaulè");
            Console.WriteLine("4/ Togolais > Brachiosaure > Bambou");
            valid_answer("4"); //Question 6
            Console.WriteLine("------------- Qestion 7 -------------");
            Console.WriteLine("Le 100ieme chiffre de pi après la virgule ?");
            Console.WriteLine("0");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            valid_answer("9"); //Question 7
            Console.WriteLine("------------- Qestion 8 -------------");
            Console.WriteLine("C'est quoi la meilleure def de la recursivite ? (prend un num)");
            Console.WriteLine("1/ Les méthodes itératives donnent, en théorie, " +
                              "la solution x d'un système linéaire après un nombre infini d’itérations. " +
                              "A chaque pas, elles nécessitent le calcul du résidu du système");
            Console.WriteLine("2/ Celui qui a fait cette question est probablement un counnard");
            Console.WriteLine("4/ 4/ Console.WriteLine(C'est quoi la meilleure def de la recursivite ? (prend un num))");
            Console.WriteLine("3/ Le site wikipedia");
            valid_answer("4"); //Question 8
            Console.WriteLine("------------- Qestion 9 -------------");
            Console.WriteLine("Pour parler des testicules on dit : (elle assez dure gros piege ;) )");
            Console.WriteLine("1/UN testicule");
            Console.WriteLine("2/UNE testicule");
            Console.WriteLine("3/une ENORME paire de baloches");
            Console.WriteLine("4/un punching ball");
            valid_answer("3"); //Question 9
            Console.WriteLine("------------- Qestion 10 -------------");
            Console.WriteLine("Choisi la bonne réponse");
            Console.WriteLine("On t'aime");
            Console.WriteLine("On t'aime");
            Console.WriteLine("On t'aime");
            Console.WriteLine("On t'aime");
            valid_answer("On t'aime");

            Console.WriteLine("Et comme tu es une beurette bien maquillé");
            Console.WriteLine("Voici ton cadeau");
            Console.WriteLine("Voici un email : joyeuxanniversairemelissa55@gmail.com , sur lequel on te conseil d'aller ;)");
            Console.WriteLine("Et ce mdp peut etre utile aussi : E2_4_Ever ");

            Console.ReadLine();
            LaunchHappybirthday();
        }

        public static void PrintString(string str, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(str);
        }

        public static string StringReverse(string str, bool reverse)
        {
            if (reverse)
            {
                int i = str.Length - 1;
                string rev = "";
                while (i >= 0)
                {
                    switch (str[i])
                    {
                        case '\\':
                            rev += '/';
                            break;
                        case ')':
                            rev += '(';
                            break;
                        case '(':
                            rev += ')';
                            break;
                        default:
                            rev += str[i];
                            break;
                    }
                    i -= 1;
                }

                return rev;
            }

            return str;
        }
        public static void Melissa(int x, int y, bool reverse)
        {
            PrintString(StringReverse("                                              YYYY            YY                                ", reverse), x, y);
            PrintString(StringReverse("HHHHH         HHHHH                             YYY          YYYY                               ", reverse), x, y + 1);
            PrintString(StringReverse("HHHHH         HHHHH                  PP PPPPPP   YYY         YYY                                ", reverse), x, y + 2);
            PrintString(StringReverse("  HHH         HHH                     PPP    PP   YYY       YYY                                 ", reverse), x, y + 3);
            PrintString(StringReverse("  HHH         HHH    AAAAA  PP PPPPPP  PP    PP    YYY     YYY                                  ", reverse), x, y + 4);
            PrintString(StringReverse("  HHH         HHH   AAAAAAA  PPP    PP PP    PP     YYY   YYY                                   ", reverse), x, y + 5);
            PrintString(StringReverse("  HHH         HHH  AA     AA  PP    PP PP    PP      YYY YYY                                    ", reverse), x, y + 6);
            PrintString(StringReverse("  HHH         HHH  AA     AA  PP    PP PPPPPPP        YYYYY                                     ", reverse), x, y + 7);
            PrintString(StringReverse("  HHHHHHHHHHHHHHH  AA     AA  PP    PP PP             YYYY                                      ", reverse), x, y + 8);
            PrintString(StringReverse("  HHHHHHHHHHHHHHH  AA     AA  PPPPPPP  PP            YYYY   -------                             ", reverse), x, y + 9);
            PrintString(StringReverse("  HHHHHHHHHHHHHHH  AAAAAAAAA  PP       PP           YYYY    -------                             ", reverse), x, y + 10);
            PrintString(StringReverse("  HHH         HHH  AAAAAAAAA  PP       PP          YYYY     -------                             ", reverse), x, y + 11);
            PrintString(StringReverse("  HHH         HHH  AA     AA  PP       PP         YYYY                                          ", reverse), x, y + 12);
            PrintString(StringReverse("  HHH         HHH  AA     AA  PP       PP        YYYY                                           ", reverse), x, y + 13);
            PrintString(StringReverse("  HHH         HHH  AA     AA  PP       PP      YYYYYY                                           ", reverse), x, y + 14);
            PrintString(StringReverse("  HHH         HHH  AA     AA  PP       PP     YYYYYYY                                           ", reverse), x, y + 15);
            PrintString(StringReverse("  HHH         HHH             PP       PP    YYYYYYY                                            ", reverse), x, y + 16);
            PrintString(StringReverse("HHHHH         HHHHH           PP       PP   YYYYYYY                                             ", reverse), x, y + 17);
            PrintString(StringReverse("HHHHH         HHHHH           PP       PP  YYYYYYY                                              ", reverse), x, y + 18);
            PrintString(StringReverse("                                            YYYYY                                               ", reverse), x, y + 19);
            PrintString(StringReverse("BBBBBBBBBBBBB                                YYY                                                ", reverse), x, y + 20);
            PrintString(StringReverse("BBBBBBBBBBBBBB                                Y                                                 ", reverse), x, y + 21);
            PrintString(StringReverse(" BBBB       BBB    II                                   YYY             YYY                     ", reverse), x, y + 22);
            PrintString(StringReverse("  BB         BB    II               DDDDDDDDDDDDD       YYYY           YYYY                     ", reverse), x, y + 23);
            PrintString(StringReverse("  BB         BB                     DDDDDDDDDDDDDD        YY            YY                      ", reverse), x, y + 24);
            PrintString(StringReverse("  BB         BB   III  RRR RRRR        DDD      DDD      A YY          YY                       ", reverse), x, y + 25);
            PrintString(StringReverse("  BB         BB    II   RRRR  RR       DDD      DDD     AAA YY        YY                        ", reverse), x, y + 26);
            PrintString(StringReverse("  BB        BBB    II    RRR           DDD      DDD    AAAAA YY      YY                         ", reverse), x, y + 27);
            PrintString(StringReverse("  BBB     BBBB     II    RR            DDD      DDD   AAAAAAA YY    YY                          ", reverse), x, y + 28);
            PrintString(StringReverse("  BBBBBBBBBBB      II    RR            DDD      DDD  AA     AA YY  YY                           ", reverse), x, y + 29);
            PrintString(StringReverse("  BBBBBBBBB        II    RR            DDD      DDD  AA     AA  YYYY                            ", reverse), x, y + 30);
            PrintString(StringReverse("  BBBBBBBBBBB      II    RR            DDD      DDD  AAAAAAAAA   YYY                            ", reverse), x, y + 31);
            PrintString(StringReverse("  BBB     BBBB    IIII  RRRR           DDD      DDD  AAAAAAAAA   YYY                            ", reverse), x, y + 32);
            PrintString(StringReverse("  BB        BBB             HHH        DDD      DDD  AA     AA   YYY                            ", reverse), x, y + 33);
            PrintString(StringReverse("  BB         BBB    TT     HHHH        DDD      DDD  AA     AA   YYY                            ", reverse), x, y + 34);
            PrintString(StringReverse("  BB         BBB    TT     HH          DDD      DDD  AA     AA   YYY                            ", reverse), x, y + 35);
            PrintString(StringReverse("  BB          BBB TTTTTT   HH          DDD      DDD  AA     AA   YYY                            ", reverse), x, y + 36);
            PrintString(StringReverse("  BB          BBB   TT     HH          DDD      DDD              YYY                            ", reverse), x, y + 37);
            PrintString(StringReverse("  BB          BBB   TT     HHHHHHHH  DDDDDDDDDDDDD               YYY                            ", reverse), x, y + 38);
            PrintString(StringReverse("  BB         BBB    TT     HH     HH DDDDDDDDDDDD               YYYY                            ", reverse), x, y + 39);
            PrintString(StringReverse(" BBBB       BBBB    TT     HH     HH                           YYYY                             ", reverse), x, y + 40);
            PrintString(StringReverse("BBBBBBBBBBBBBBB     TT  TT HH     HH    YYYYYYYYYYYYYYYYYYYYYYYYYY                              ", reverse), x, y + 41);
            PrintString(StringReverse("BBBBBBBBBBBBBB       TTTT  HH     HH    YYYYYYYYYYYYYYYYYYYYYYYY                                ", reverse), x, y + 42);
            PrintString(StringReverse("                          HHHH   HHHH   YYYYYYYYYYYYYYYYYYYYYY                                  ", reverse), x, y + 43);
            PrintString(StringReverse("Press enter to exit.                                                                            ", reverse), x, y + 44);



        }
        private static Timer aTimer;//met en place un timer utilise dans les fonctions suivantes

        private static void SetTimer()//met en place le timer pour melissa
        {
            aTimer = new Timer(250);//timer de 250 millisecondes pour chaque tete d harry

            aTimer.Elapsed += HappyBirthday;//appel la fonction happybirthday pour chaque timer
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void LaunchHappybirthday()//lance le happy birthday
        {
            SetTimer();
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();
        }
        private static void HappyBirthday(Object source, ElapsedEventArgs e)//Happy birthday!
        {
            Console.Clear();
            Random color = new Random();
            Console.ForegroundColor = (ConsoleColor)color.Next(15);

            Melissa(0, 0, false);
        }
        
    }
}