// ╔════════════════════════════════════════════════════════════════════╗
// ║         🌙  Ramadan Mubarak - Console Celebration App  🌙         ║
// ║         Created with love by: Ahmed Mohamed Gaber                  ║
// ║         Framework: .NET 8 | Language: C#                           ║
// ╚════════════════════════════════════════════════════════════════════╝

using System;
using System.Threading;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace RamadanMubarak
{
    class Program
    {
        
        //   رسائل رمضان
        
        private static readonly string[] RamadanMessages = new[]
        {
            "اللهم بلغنا رمضان",
            "تقبل الله منا ومنكم",
            "رمضان فرصة للتغيير",
            "اللهم اجعلنا من عتقائك من النار",
            "رمضان شهر القرآن",
            "اللهم تقبل صيامنا وقيامنا",
            "رمضان شهر الرحمة والمغفرة",
            "اللهم بلغنا ليلة القدر",
            "صيام مقبول وإفطار شهي",
            "اللهم اجعل رمضان شفيعاً لنا",
            "اللهم أعنا على ذكرك وشكرك وحسن عبادتك",
            "رب اجعلني مقيم الصلاة ومن ذريتي",
            "اللهم إنك عفو تحب العفو فاعف عنا",
            "يا مقلب القلوب ثبت قلبي على دينك",
            "اللهم اجعل القرآن ربيع قلوبنا"
        };

        private static readonly string[] MotivationalMessages = new[]
        {
            "\"إن الله لا يضيع أجر المحسنين\" - سورة التوبة",
            "\"وَمَن يَتَّقِ اللَّهَ يَجْعَل لَّهُ مَخْرَجًا\" - سورة الطلاق",
            "\"فَإِنَّ مَعَ الْعُسْرِ يُسْرًا\" - سورة الشرح",
            "\"وَلَسَوْفَ يُعْطِيكَ رَبُّكَ فَتَرْضَىٰ\" - سورة الضحى",
            "\"ادْعُونِي أَسْتَجِبْ لَكُمْ\" - سورة غافر",
            "\"وَاصْبِرْ فَإِنَّ اللَّهَ لَا يُضِيعُ أَجْرَ الْمُحْسِنِينَ\" - سورة هود",
            "\"إِنَّ اللَّهَ مَعَ الصَّابِرِينَ\" - سورة البقرة",
            "\"وَلَا تَيْأَسُوا مِن رَّوْحِ اللَّهِ\" - سورة يوسف",
            "\"رَبِّ اشْرَحْ لِي صَدْرِي وَيَسِّرْ لِي أَمْرِي\" - سورة طه",
            "\"حَسْبُنَا اللَّهُ وَنِعْمَ الْوَكِيلُ\" - سورة آل عمران"
        };

        private static readonly string[] TasbeehOptions = new[]
        {
            "سبحان الله",
            "الحمد لله",
            "الله أكبر",
            "لا إله إلا الله",
            "أستغفر الله",
            "سبحان الله وبحمده",
            "لا حول ولا قوة إلا بالله"
        };

        //   فوانيس بحالتين: منورة ومطفية
      

        private static readonly string[] LanternLitLeft = new[]
        {
            "      )        ",
            "     ╔╩╗       ",
            "    ╔╝ ╚╗      ",
            "    ║*☪*║      ",
            "    ╠═══╣      ",
            "    ║███║      ",
            "    ╚═══╝      ",
            "      █        ",
        };
        private static readonly string[] LanternLitCenter = new[]
        {
            "          )          ",
            "         ╔╩╗         ",
            "        ╔╝ ╚╗        ",
            "        ║*☪*║        ",
            "        ╠═══╣        ",
            "        ║███║        ",
            "        ╚═══╝        ",
            "          █          ",
        };
        private static readonly string[] LanternLitRight = new[]
        {
            "              )    ",
            "             ╔╩╗   ",
            "            ╔╝ ╚╗  ",
            "            ║*☪*║  ",
            "            ╠═══╣  ",
            "            ║███║  ",
            "            ╚═══╝  ",
            "              █    ",
        };

        private static readonly string[] LanternDimLeft = new[]
        {
            "               ",
            "     ╔╩╗       ",
            "    ╔╝ ╚╗      ",
            "    ║ ☪ ║      ",
            "    ╠═══╣      ",
            "    ║░░░║      ",
            "    ╚═══╝      ",
            "      █        ",
        };
        private static readonly string[] LanternDimCenter = new[]
        {
            "                     ",
            "         ╔╩╗         ",
            "        ╔╝ ╚╗        ",
            "        ║ ☪ ║        ",
            "        ╠═══╣        ",
            "        ║░░░║        ",
            "        ╚═══╝        ",
            "          █          ",
        };
        private static readonly string[] LanternDimRight = new[]
        {
            "                   ",
            "             ╔╩╗   ",
            "            ╔╝ ╚╗  ",
            "            ║ ☪ ║  ",
            "            ╠═══╣  ",
            "            ║░░░║  ",
            "            ╚═══╝  ",
            "              █    ",
        };

        private static readonly string[] BigLanternLit = new[]
        {
            @"                  )                  ",
            @"                 ╔╩╗                 ",
            @"                ╔╝ ╚╗                ",
            @"               ╔╝   ╚╗               ",
            @"              ╔╝     ╚╗              ",
            @"              ║ * ☪ * ║              ",
            @"              ║ *   * ║              ",
            @"              ║ *   * ║              ",
            @"              ╠═══════╣              ",
            @"              ║███████║              ",
            @"              ║███████║              ",
            @"              ║███████║              ",
            @"              ╚╗     ╔╝              ",
            @"               ╚╗   ╔╝               ",
            @"                ╚═══╝                ",
            @"                 ███                 ",
            @"                  █                  ",
        };

        private static readonly string[] BigLanternDim = new[]
        {
            @"                                     ",
            @"                 ╔╩╗                 ",
            @"                ╔╝ ╚╗                ",
            @"               ╔╝   ╚╗               ",
            @"              ╔╝     ╚╗              ",
            @"              ║ . ☪ . ║              ",
            @"              ║ .   . ║              ",
            @"              ║ .   . ║              ",
            @"              ╠═══════╣              ",
            @"              ║░░░░░░░║              ",
            @"              ║░░░░░░░║              ",
            @"              ║░░░░░░░║              ",
            @"              ╚╗     ╔╝              ",
            @"               ╚╗   ╔╝               ",
            @"                ╚═══╝                ",
            @"                 ███                 ",
            @"                  █                  ",
        };

        private static readonly string[] MosqueSilhouette = new[]
        {
            @"                           ☪                            ",
            @"                          ╱ ╲                           ",
            @"                         ╱   ╲                          ",
            @"              ┌─┐       │     │       ┌─┐               ",
            @"              │☪│       │  ☪  │       │☪│               ",
            @"              │ │  ┌────┤     ├────┐  │ │               ",
            @"              │ │  │    │     │    │  │ │               ",
            @"              │ │  │    │ ┌─┐ │    │  │ │               ",
            @"              └─┘  └────┴─┤ ├─┴────┘  └─┘               ",
            @"             ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀              ",
        };

        private static Random _random = new Random();

        //   Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "🌙 Ramadan Mubarak 🌙";
            Console.CursorVisible = false;

            try
            {
                // ضبط حجم النافذة
                try
                {
                    if (Console.WindowWidth < 80) Console.WindowWidth = 80;
                    if (Console.WindowHeight < 30) Console.WindowHeight = 35;
                    Console.BufferWidth = Console.WindowWidth;
                    Console.BufferHeight = Console.WindowHeight;
                } catch { }

                ShowIntroAnimation();
                ShowRamadanBanner();
                ShowAnimatedLantern();
                ShowWelcomeMessage();
                Thread.Sleep(1500);
                RunMainMenu();
                ShowExitMessage();
            }
            finally
            {
                Console.CursorVisible = true;
                Console.ResetColor();
            }
        }

        //   مقدمة متحركة - نجوم + قمر متحرك
        static void ShowIntroAnimation()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            string[] stars = { "✦", "✧", "★", "☆", "·", "•", "◆", "◇" };

            int w = Math.Max(40, Console.WindowWidth - 2);
            int h = Math.Max(10, Console.WindowHeight - 5);

            // سماء نجوم تتلألأ
            for (int i = 0; i < 60; i++)
            {
                try
                {
                    int x = _random.Next(1, w);
                    int y = _random.Next(0, Math.Min(h, 18));
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = (ConsoleColor)_random.Next(9, 15);
                    Console.Write(stars[_random.Next(stars.Length)]);
                }
                catch { }
                Thread.Sleep(25);
            }

            // قمر يتحرك عبر السماء
            string[] moonPhases = { "🌑", "🌒", "🌓", "🌔", "🌕", "🌙" };
            int moonY = 1;
            for (int phase = 0; phase < moonPhases.Length; phase++)
            {
                int startX = phase * (w / 6) + 2;
                int endX = (phase + 1) * (w / 6);
                endX = Math.Min(endX, w - 2);

                for (int x = startX; x < endX; x += 2)
                {
                    try
                    {
                        Console.SetCursorPosition(x, moonY);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(moonPhases[phase]);
                        Thread.Sleep(25);
                        Console.SetCursorPosition(x, moonY);
                        Console.Write("  ");
                    }
                    catch { }
                }
            }

            // القمر يستقر كهلال في المنتصف
            try
            {
                Console.SetCursorPosition(w / 2, moonY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("🌙");
            }
            catch { }
            Thread.Sleep(800);
        }

        //   بانر رمضان الرئيسي
        static void ShowRamadanBanner()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintCentered("  ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("╔════════════════════════════════════════════════════╗");
            PrintCentered("║                                                    ║");
            PrintCentered("║        🌙   R A M A D A N   M U B A R A K   🌙    ║");
            PrintCentered("║                    2 0 2 6                         ║");
            PrintCentered("║                                                    ║");
            PrintCentered("╚════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintCentered("  ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦  ");
        }

        //   فانوس متحرك بينور ويطفي
        static void ShowAnimatedLantern()
        {
            Console.WriteLine();
            int startY = Console.CursorTop;

            // وميض الفانوس - بينور ويطفي
            for (int blink = 0; blink < 6; blink++)
            {
                try { Console.SetCursorPosition(0, startY); } catch { }

                bool isLit = (blink % 2 == 0);
                string[] lantern = isLit ? LanternLitCenter : LanternDimCenter;
                Console.ForegroundColor = isLit ? ConsoleColor.Yellow : ConsoleColor.DarkYellow;

                // هالة نور حوالين الفانوس لما يكون منور
                if (isLit)
                {
                    PrintCentered("        · · · · ·        ");
                    foreach (var line in lantern)
                    {
                        PrintCentered(line);
                    }
                    PrintCentered("        · · · · ·        ");
                }
                else
                {
                    PrintCentered("                         ");
                    foreach (var line in lantern)
                    {
                        PrintCentered(line);
                    }
                    PrintCentered("                         ");
                }
                Thread.Sleep(350);
            }
        }

                //   رسالة الترحيب المتحركة
        static void ShowWelcomeMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeWriterCentered("🌙  R A M A D A N   K A R E E M  🌙", 40);
            Console.ForegroundColor = ConsoleColor.Green;
            TypeWriterCentered("Welcome to Ramadan Celebration App", 30);
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeWriterCentered("Created by: Ahmed Mohamed Gaber", 30);
            Console.ForegroundColor = ConsoleColor.Magenta;
            string msg = RamadanMessages[_random.Next(RamadanMessages.Length)];
            PrintArabicCentered($"✨ {msg} ✨");
        }

        //   القائمة الرئيسية مع فوانيس بتنور وتطفي
        static void RunMainMenu()
        {
            bool running = true;
            bool firstTime = true;

            while (running)
            {
                Console.Clear();

                //  عرض فوانيس بتنور وتطفي قبل القائمة 
                if (firstTime)
                {
                    AnimateThreeLanterns(4); // وميض 4 مرات
                    firstTime = false;
                }
                else
                {
                    // رسم الفوانيس ثابتة منورة
                    DrawThreeLanternsStatic(true);
                }

                Console.WriteLine();

                //   القائمة   
                int boxWidth = 52;
                Console.ForegroundColor = ConsoleColor.Yellow;
                PrintCentered("╔" + new string('═', boxWidth) + "╗");
                PrintCentered("║" + CenterInBox("🌙  Ramadan Celebration Menu  🌙", boxWidth) + "║");
                PrintCentered("╠" + new string('═', boxWidth) + "╣");
                PrintCentered("║" + new string(' ', boxWidth) + "║");

                // خيارات القائمة - كل واحد جوا البوكس
                DrawMenuOptionInBox("1", "Ramadan Greeting", "🌙", ConsoleColor.Yellow, boxWidth);
                DrawMenuOptionInBox("2", "Islamic Motivational Quote", "📖", ConsoleColor.Green, boxWidth);
                DrawMenuOptionInBox("3", "Iftar Countdown Timer", "⏰", ConsoleColor.Cyan, boxWidth);
                DrawMenuOptionInBox("4", "Electronic Tasbeeh", "📿", ConsoleColor.Magenta, boxWidth);
                DrawMenuOptionInBox("5", "Prayer Times Today", "🕌", ConsoleColor.DarkYellow, boxWidth);
                DrawMenuOptionInBox("6", "Big Lantern Show", "🏮", ConsoleColor.Yellow, boxWidth);
                DrawMenuOptionInBox("7", "Full Celebration Show", "🎆", ConsoleColor.Cyan, boxWidth);
                DrawMenuOptionInBox("0", "Exit", "🚪", ConsoleColor.Red, boxWidth);

                Console.ForegroundColor = ConsoleColor.Yellow;
                PrintCentered("║" + new string(' ', boxWidth) + "║");
                PrintCentered("╚" + new string('═', boxWidth) + "╝");

                // فوتر
                Console.WriteLine();
                ShowFooter();

                //  إدخال المستخدم ══
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                PrintCentered("╔══════════════════════════════╗");
                PrintCentered("║   >>> Enter your choice:     ║");
                PrintCentered("╚══════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Yellow;

                // وضع الكيرسور في المكان الصح
                int inputPadding = Math.Max(0, (Console.WindowWidth - 30) / 2);
                Console.SetCursorPosition(inputPadding + 4, Console.CursorTop);
                Console.Write(">>> ");
                Console.CursorVisible = true;
                string choice = Console.ReadLine();
                Console.CursorVisible = false;

                switch (choice?.Trim())
                {
                    case "1": ShowGreeting(); break;
                    case "2": ShowMotivation(); break;
                    case "3": ShowIftarCountdown(); break;
                    case "4": RunTasbeeh(); break;
                    case "5": ShowPrayerTimes(); break;
                    case "6": ShowBigLanternShow(); break;
                    case "7": ShowFullAnimationShow(); break;
                    case "0": running = false; break;
                }

                if (running)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    PrintCentered("✦ Press any key to return to menu... ✦");
                    Console.ReadKey(true);
                }
            }
        }

        //   ثلاث فوانيس بتنور وتطفي (Animation)
        static void AnimateThreeLanterns(int cycles)
        {
            int startY = Console.CursorTop;

            for (int cycle = 0; cycle < cycles * 2; cycle++)
            {
                try { Console.SetCursorPosition(0, startY); } catch { }

                bool isLit = (cycle % 2 == 0);

                // الفانوس الشمال - بيتأخر فريم
                bool leftLit = (cycle % 4 < 2);
                // الفانوس النص - بينور ويطفي طبيعي
                bool centerLit = isLit;
                // الفانوس اليمين - بيتأخر فريم تاني
                bool rightLit = ((cycle + 2) % 4 < 2);

                // رسم الثلاث فوانيس جنب بعض سطر سطر
                for (int line = 0; line < 8; line++)
                {
                    string left = leftLit ? LanternLitLeft[line] : LanternDimLeft[line];
                    string center = centerLit ? LanternLitCenter[line] : LanternDimCenter[line];
                    string right = rightLit ? LanternLitRight[line] : LanternDimRight[line];

                    // تغيير اللون حسب حالة النور
                    string fullLine = left + center + right;
                    // لون مختلف لكل حالة
                    if (leftLit && centerLit && rightLit)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else if (centerLit)
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    else
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                    PrintCentered(fullLine);
                }

                // هالة نور تحت الفوانيس
                if (centerLit)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    PrintCentered("    ·  ·  ·       ·  ·  ·       ·  ·  ·    ");
                }
                else
                {
                    PrintCentered("                                           ");
                }

                Thread.Sleep(300);
            }
        }

        // رسم الفوانيس ثابتة
        static void DrawThreeLanternsStatic(bool lit)
        {
            for (int line = 0; line < 8; line++)
            {
                string left = lit ? LanternLitLeft[line] : LanternDimLeft[line];
                string center = lit ? LanternLitCenter[line] : LanternDimCenter[line];
                string right = lit ? LanternLitRight[line] : LanternDimRight[line];

                Console.ForegroundColor = lit ? ConsoleColor.Yellow : ConsoleColor.DarkGray;
                PrintCentered(left + center + right);
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            PrintCentered("    ·  ·  ·       ·  ·  ·       ·  ·  ·    ");
        }

        
        //  1️⃣ تهنئة رمضان
        static void ShowGreeting()
        {
            Console.Clear();
            int boxW = 52;

            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintCentered("  ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("╔" + new string('═', boxW) + "╗");
            PrintCentered("║" + CenterInBox("🌙  Ramadan Greeting  🌙", boxW) + "║");
            PrintCentered("╚" + new string('═', boxW) + "╝");
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintCentered("  ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★  ");
            Console.WriteLine();

            // فانوس صغير بوميض
            int lanternStart = Console.CursorTop;
            for (int b = 0; b < 4; b++)
            {
                try { Console.SetCursorPosition(0, lanternStart); } catch { }
                bool lit = b % 2 == 0;
                Console.ForegroundColor = lit ? ConsoleColor.Yellow : ConsoleColor.DarkGray;
                string[] lan = lit ? LanternLitCenter : LanternDimCenter;
                foreach (var l in lan) PrintCentered(l);
                Thread.Sleep(350);
            }
            Console.WriteLine();

            // رسائل رمضانية عشوائية بألوان مختلفة
            ConsoleColor[] colors = { ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.White };
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = colors[i];
                string msg = RamadanMessages[_random.Next(RamadanMessages.Length)];
                PrintArabicCentered($"  ✨ {msg} ✨  ");
                Thread.Sleep(400);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintCentered("  ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★  ");
        }

        //  2️⃣ رسالة إسلامية 
        static void ShowMotivation()
        {
            Console.Clear();
            int boxW = 52;
            string message = MotivationalMessages[_random.Next(MotivationalMessages.Length)];

            Console.ForegroundColor = ConsoleColor.Green;
            PrintCentered("╔" + new string('═', boxW) + "╗");
            PrintCentered("║" + CenterInBox("📖  Islamic Motivation  📖", boxW) + "║");
            PrintCentered("╠" + new string('═', boxW) + "╣");
            PrintCentered("║" + new string(' ', boxW) + "║");
            PrintCentered("║" + new string(' ', boxW) + "║");
            PrintCentered("╚" + new string('═', boxW) + "╝");

            Console.WriteLine();
            Console.WriteLine();

            // آية في إطار
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("══════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintArabicCentered(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("══════════════════════════════════════");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            PrintCentered("--- Reflect and contemplate ---");
        }

        //  3️⃣ العد التنازلي للإفطار محسن + فانوس بينور
        static void ShowIftarCountdown()
        {
            int totalSeconds = 15;
            int boxW = 32;

            for (int i = totalSeconds; i > 0; i--)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                PrintCentered("╔" + new string('═', 40) + "╗");
                PrintCentered("║" + CenterInBox("⏰  Iftar Countdown  ⏰", 40) + "║");
                PrintCentered("╚" + new string('═', 40) + "╝");
                Console.WriteLine();

                // فانوس صغير متحرك
                bool lit = i % 2 == 0;
                Console.ForegroundColor = lit ? ConsoleColor.Yellow : ConsoleColor.DarkYellow;
                string[] lan = lit ? LanternLitCenter : LanternDimCenter;
                foreach (var l in lan) PrintCentered(l);
                Console.WriteLine();

                // لون يتغير حسب الوقت
                ConsoleColor timerColor;
                if (i > 10) timerColor = ConsoleColor.Cyan;
                else if (i > 5) timerColor = ConsoleColor.Yellow;
                else timerColor = ConsoleColor.Red;

                Console.ForegroundColor = timerColor;
                int mins = i / 60;
                int secs = i % 60;

                PrintCentered("╔" + new string('═', boxW) + "╗");
                PrintCentered("║" + CenterInBox($"⏰  {mins:D2} : {secs:D2}  ⏰", boxW) + "║");
                PrintCentered("╚" + new string('═', boxW) + "╝");

                // شريط تقدم
                Console.WriteLine();
                int progress = (int)(((double)(totalSeconds - i) / totalSeconds) * 30);
                string bar = new string('█', progress) + new string('░', 30 - progress);
                int percent = (int)(((double)(totalSeconds - i) / totalSeconds) * 100);
                Console.ForegroundColor = timerColor;
                PrintCentered($"  [{bar}] {percent,3}%  ");

                Thread.Sleep(1000);
            }

            //  احتفال الإفطار
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★");
            Console.WriteLine();

            PrintCentered("╔" + new string('═', 44) + "╗");
            PrintCentered("║" + CenterInBox("🎉  ALLAHU AKBAR!  🎉", 44) + "║");
            PrintCentered("║" + CenterInBox("Time for Iftar!", 44) + "║");
            PrintCentered("╚" + new string('═', 44) + "╝");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            PrintArabicCentered("اللهم لك صمت وعلى رزقك أفطرت");
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintArabicCentered("ذهب الظمأ وابتلت العروق وثبت الأجر إن شاء الله");
            Console.WriteLine();

            // ألعاب نارية
            string[] stars = { "✦", "✧", "★", "☆", "◆", "◇", "✶", "✸" };
            for (int j = 0; j < 4; j++)
            {
                Console.ForegroundColor = (ConsoleColor)_random.Next(9, 15);
                string firework = "  ";
                for (int s = 0; s < 25; s++) firework += stars[_random.Next(stars.Length)] + " ";
                PrintCentered(firework);
                Thread.Sleep(300);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★");
        }

        //  4️⃣ المسبحة الإلكترونية محسنة
        static void RunTasbeeh()
        {
            Console.Clear();
            int boxW = 52;

            Console.ForegroundColor = ConsoleColor.Magenta;
            PrintCentered("╔" + new string('═', boxW) + "╗");
            PrintCentered("║" + CenterInBox("📿  Electronic Tasbeeh  📿", boxW) + "║");
            PrintCentered("╠" + new string('═', boxW) + "╣");

            for (int i = 0; i < TasbeehOptions.Length; i++)
            {
                string optText = $"  [{i + 1}]  {FixArabic(TasbeehOptions[i])}";
                Console.ForegroundColor = ConsoleColor.White;
                PrintCentered("║" + PadInBox(optText, boxW) + "║");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            PrintCentered("╚" + new string('═', boxW) + "╝");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintCentered(">>> Choose dhikr (1-7): ");
            Console.CursorVisible = true;
            string input = Console.ReadLine();
            Console.CursorVisible = false;

            int selectedIndex = 0;
            if (int.TryParse(input, out int idx) && idx >= 1 && idx <= TasbeehOptions.Length)
                selectedIndex = idx - 1;

            string selectedDhikr = TasbeehOptions[selectedIndex];
            int count = 0;
            int target = 33;

            while (true)
            {
                Console.Clear();
                int bW = 40;

                Console.ForegroundColor = ConsoleColor.Magenta;
                PrintCentered("╔" + new string('═', bW) + "╗");
                PrintCentered("║" + CenterInBox("📿  Tasbeeh  📿", bW) + "║");
                PrintCentered("╚" + new string('═', bW) + "╝");
                Console.WriteLine();

                // الذكر المختار
                Console.ForegroundColor = ConsoleColor.Yellow;
                PrintArabicCentered($"  ✨  {selectedDhikr}  ✨  ");
                Console.WriteLine();

                // العداد
                Console.ForegroundColor = ConsoleColor.White;
                PrintCentered("╔═══════════════════╗");
                PrintCentered("║" + CenterInBox($"{count,4} / {target}", 19) + "║");
                PrintCentered("╚═══════════════════╝");
                Console.WriteLine();

                // شريط بصري
                int filled = count % target;
                if (count > 0 && filled == 0 && count >= target) filled = target;
                string dots = new string('●', filled) + new string('○', target - filled);
                Console.ForegroundColor = ConsoleColor.Magenta;
                PrintCentered(dots);
                Console.WriteLine();

                // إنجاز
                if (count > 0 && count % target == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintCentered($"  🎉  Completed {count / target} round(s) - MashaAllah!  🎉  ");
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.DarkGray;
                PrintCentered("[Space] Count  |  [R] Reset  |  [Esc] Back");

                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Spacebar) count++;
                else if (key == ConsoleKey.R) count = 0;
                else if (key == ConsoleKey.Escape) break;
            }
        }

        //  5️⃣ مواقيت الصلاة
        static void ShowPrayerTimes()
        {
            Console.Clear();
            int boxW = 52;

            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("╔" + new string('═', boxW) + "╗");
            PrintCentered("║" + CenterInBox("🕌  Prayer Times (Approximate)  🕌", boxW) + "║");
            PrintCentered("╚" + new string('═', boxW) + "╝");
            Console.WriteLine();

            // مسجد
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var line in MosqueSilhouette) PrintCentered(line);
            Console.WriteLine();

            // مواقيت في جدول منسق
            var now = DateTime.Now;
            var prayers = new (string Name, string Time, TimeSpan Ts)[]
            {
                ("Fajr",    "05:12 AM", new TimeSpan(5, 12, 0)),
                ("Sunrise", "06:30 AM", new TimeSpan(6, 30, 0)),
                ("Dhuhr",   "12:08 PM", new TimeSpan(12, 8, 0)),
                ("Asr",     "03:22 PM", new TimeSpan(15, 22, 0)),
                ("Maghrib", "05:45 PM", new TimeSpan(17, 45, 0)),
                ("Isha",    "07:08 PM", new TimeSpan(19, 8, 0))
            };

            int tw = 48;
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintCentered("┌" + new string('─', 14) + "┬" + new string('─', 12) + "┬" + new string('─', 10) + "┐");
            PrintCentered("│   Prayer      │    Time    │  Status  │");
            PrintCentered("├" + new string('─', 14) + "┼" + new string('─', 12) + "┼" + new string('─', 10) + "┤");

            foreach (var (name, time, ts) in prayers)
            {
                bool passed = now.TimeOfDay > ts;
                Console.ForegroundColor = passed ? ConsoleColor.DarkGray : ConsoleColor.Green;
                string icon = passed ? "✅" : "⏳";
                string status = passed ? "  Done  " : "  Next  ";
                PrintCentered($"│ {icon} {name,-10} │  {time}  │{status}  │");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintCentered("└" + new string('─', 14) + "┴" + new string('─', 12) + "┴" + new string('─', 10) + "┘");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            PrintCentered($"  Current: {now:hh:mm:ss tt}  |  Date: {now:yyyy/MM/dd}  ");
            PrintCentered("  * Times are approximate  ");
        }

        //  6️⃣ عرض الفانوس الكبير مع وميض نور
        static void ShowBigLanternShow()
        {
            Console.Clear();
            int boxW = 44;

            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("╔" + new string('═', boxW) + "╗");
            PrintCentered("║" + CenterInBox("🏮  Big Lantern Show  🏮", boxW) + "║");
            PrintCentered("╚" + new string('═', boxW) + "╝");
            Console.WriteLine();

            int startY = Console.CursorTop;

            // فانوس كبير بينور ويطفي
            for (int cycle = 0; cycle < 12; cycle++)
            {
                try { Console.SetCursorPosition(0, startY); } catch { }

                bool isLit = (cycle % 2 == 0);
                string[] lantern = isLit ? BigLanternLit : BigLanternDim;

                // ألوان مختلفة لتأثير النور
                if (isLit)
                {
                    // هالة نور فوق
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    PrintCentered("            · · ·  · · ·            ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    PrintCentered("                                    ");
                }

                foreach (var line in lantern)
                {
                    // لون متدرج حسب الجزء
                    if (isLit)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                    PrintCentered(line);
                }

                // هالة نور تحت
                if (isLit)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    PrintCentered("          · · · · · · · · · ·       ");
                    PrintCentered("            · · · · · · · ·         ");
                }
                else
                {
                    PrintCentered("                                    ");
                    PrintCentered("                                    ");
                }

                Thread.Sleep(400);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("✦ ══════════════════════════════ ✦");
            PrintArabicCentered("فانوس رمضان ينير لياليكم");
            PrintCentered("✦ ══════════════════════════════ ✦");
        }

        
        //  7️⃣ عرض احتفالي كامل
        static void ShowFullAnimationShow()
        {
            int w = Math.Max(40, Console.WindowWidth - 2);
            int h = Math.Max(10, Console.WindowHeight - 5);
            string[] stars = { "✦", "✧", "★", "☆", "·", "•", "◆", "◇" };

            //  Act 1: سماء نجوم 
            Console.Clear();
            for (int i = 0; i < 80; i++)
            {
                try
                {
                    Console.SetCursorPosition(_random.Next(1, w), _random.Next(0, Math.Min(h, 18)));
                    Console.ForegroundColor = (ConsoleColor)_random.Next(9, 15);
                    Console.Write(stars[_random.Next(stars.Length)]);
                }
                catch { }
                Thread.Sleep(15);
            }
            Thread.Sleep(500);

            //  Act 2: قمر يتحرك 
            for (int x = 2; x < Math.Min(w - 4, 60); x += 2)
            {
                try
                {
                    Console.SetCursorPosition(x, 0);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("🌙  ");
                    Thread.Sleep(40);
                    Console.SetCursorPosition(x, 0);
                    Console.Write("    ");
                }
                catch { }
            }
            try
            {
                Console.SetCursorPosition(w / 2, 0);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("🌙");
            }
            catch { }
            Thread.Sleep(500);

            //  Act 3: فوانيس بتنور وتطفي 
            Console.Clear();

            // نجوم في الخلفية
            for (int i = 0; i < 30; i++)
            {
                try
                {
                    Console.SetCursorPosition(_random.Next(1, w), _random.Next(0, 3));
                    Console.ForegroundColor = (ConsoleColor)_random.Next(9, 15);
                    Console.Write(stars[_random.Next(stars.Length)]);
                }
                catch { }
            }

            try { Console.SetCursorPosition(0, 4); } catch { }
            AnimateThreeLanterns(3);

            Thread.Sleep(300);

            //  Act 4: مسجد 
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var line in MosqueSilhouette)
            {
                PrintCentered(line);
                Thread.Sleep(80);
            }
            Thread.Sleep(500);

            //  Act 5: رسائل وألعاب نارية 
            Console.WriteLine();
            ConsoleColor[] msgColors = { ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Magenta };
            string[] messages = {
                "🌙  R A M A D A N   M U B A R A K  🌙",
                "✨  May Allah Bless You  ✨",
                "🎉  Happy Ramadan 2026  🎉",
                "💫  From Ahmed Mohamed Gaber  💫"
            };

            for (int i = 0; i < messages.Length; i++)
            {
                Console.ForegroundColor = msgColors[i];
                TypeWriterCentered(messages[i], 25);
                Thread.Sleep(150);
            }

            // ألعاب نارية كبيرة
            Console.WriteLine();
            for (int burst = 0; burst < 6; burst++)
            {
                Console.ForegroundColor = (ConsoleColor)_random.Next(9, 15);
                string firework = "";
                for (int s = 0; s < 30; s++) firework += stars[_random.Next(stars.Length)] + " ";
                PrintCentered(firework);
                Thread.Sleep(250);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("🌙 ✦ ✧ ★  R A M A D A N   K A R E E M  ★ ✧ ✦ 🌙");
        }

        //   رسالة الخروج
        static void ShowExitMessage()
        {
            Console.Clear();
            int boxW = 52;

            // فانوس وداع
            Console.ForegroundColor = ConsoleColor.Yellow;
            string[] lan = LanternLitCenter;
            foreach (var l in lan) PrintCentered(l);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintCentered("╔" + new string('═', boxW) + "╗");
            PrintCentered("║" + new string(' ', boxW) + "║");
            PrintCentered("║" + CenterInBox("🌙  JazakAllahu Khairan  🌙", boxW) + "║");
            PrintCentered("║" + new string(' ', boxW) + "║");
            PrintCentered("║" + CenterInBox("Thank you for using this app!", boxW) + "║");
            PrintCentered("║" + CenterInBox("Ramadan Kareem 🌙", boxW) + "║");
            PrintCentered("║" + new string(' ', boxW) + "║");
            PrintCentered("╚" + new string('═', boxW) + "╝");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            PrintArabicCentered("  تقبل الله منا ومنكم صالح الأعمال  ");
            PrintArabicCentered("  رمضان كريم  ");

            Console.WriteLine();
            ShowFooter();
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintCentered("  ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★ ✦ ✧ ★  ");
            Thread.Sleep(3000);
        }

        //   حل مشكلة العربي المعكوس في Windows Console
        static bool IsArabicChar(char c)
        {
            return (c >= 0x0600 && c <= 0x06FF) ||
                   (c >= 0x0750 && c <= 0x077F) ||
                   (c >= 0xFB50 && c <= 0xFDFF) ||
                   (c >= 0xFE70 && c <= 0xFEFF) ||
                   (c >= 0x0610 && c <= 0x061A);
        }

        static bool ContainsArabic(string text)
        {
            return text.Any(c => IsArabicChar(c));
        }

        static string FixArabic(string text)
        {
            if (!ContainsArabic(text)) return text;

            var elements = new List<string>();
            var enumerator = StringInfo.GetTextElementEnumerator(text);
            while (enumerator.MoveNext())
            {
                elements.Add(enumerator.GetTextElement());
            }
            elements.Reverse();
            return string.Join("", elements);
        }

        //   Helper Methods - محاذاة مظبوطة

        // طباعة في المنتصف بوردرات وإنجليزي
        static void PrintCentered(string text)
        {
            int padding = Math.Max(0, (Console.WindowWidth - text.Length) / 2);
            Console.WriteLine(new string(' ', padding) + text);
        }

        // طباعة عربي في المنتصف مع FixArabic
        static void PrintArabicCentered(string text)
        {
            string fixedText = FixArabic(text);
            int padding = Math.Max(0, (Console.WindowWidth - text.Length) / 2);
            Console.WriteLine(new string(' ', padding) + fixedText);
        }

        // تأثير الكتابة حرف حرف
        static void TypeWriterCentered(string text, int delay)
        {
            int padding = Math.Max(0, (Console.WindowWidth - text.Length) / 2);
            Console.Write(new string(' ', padding));
            var elements = new List<string>();
            var enumerator = StringInfo.GetTextElementEnumerator(text);
            while (enumerator.MoveNext())
                elements.Add(enumerator.GetTextElement());
            foreach (string element in elements)
            {
                Console.Write(element);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        // محاذاة نص في منتصف بوكس بعرض معين
        static string CenterInBox(string text, int boxWidth)
        {
            int totalPadding = boxWidth - text.Length;
            if (totalPadding <= 0) return text;
            int left = totalPadding / 2;
            int right = totalPadding - left;
            return new string(' ', left) + text + new string(' ', right);
        }

        // محاذاة نص لليسار جوا بوكس
        static string PadInBox(string text, int boxWidth)
        {
            int remaining = boxWidth - text.Length;
            if (remaining <= 0) return text;
            return text + new string(' ', remaining);
        }

        // رسم خيار في القائمة جوا البوكس
        static void DrawMenuOptionInBox(string num, string text, string icon, ConsoleColor color, int boxWidth)
        {
            string content = $"    [{num}]  {icon}  {text}";
            int remaining = boxWidth - content.Length;
            if (remaining < 0) remaining = 0;
            string fullLine = content + new string(' ', remaining);

            int padding = Math.Max(0, (Console.WindowWidth - boxWidth - 2) / 2);
            Console.Write(new string(' ', padding));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("║");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"    [{num}]  ");
            Console.ForegroundColor = color;
            Console.Write($"{icon}  {text}");

            int textPart = ($"    [{num}]  {icon}  {text}").Length;
            int spaces = boxWidth - textPart;
            if (spaces > 0) Console.Write(new string(' ', spaces));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║");
        }

        // فوتر
        static void ShowFooter()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            PrintCentered("─────────────────────────────────────────────────────");
            PrintCentered("  Developed by Ahmed Mohamed Gaber  |  .NET Developer  ");
            PrintCentered("  Ramadan Celebration Console App  |  2026              ");
            PrintCentered("─────────────────────────────────────────────────────");
        }
    }
}
