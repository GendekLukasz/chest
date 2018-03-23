using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace chest
{
    class game
    {
        int numberOfMove = 1;
        chest tablechest;
        bool whoseMove = true; //true-white
        public game()
        {
            tablechest = new chest();
        }
        public bool szachWhite(string[,] tabToCheck)
        {
            Console.WriteLine("sprawdzanie szacha");
            int WhiteKingPositionX = 0;

            int WhiteKingPositionY = 0;
            int BlackKingPositionY = 0;
            int BlackKingPositionX = 0;
            Console.WriteLine(tabToCheck.GetLength(0));
            for (int i = 0; i < tabToCheck.GetLength(0); i++)
            {
                for (int j = 0; j < tabToCheck.GetLength(0); j++)
                {
                    if (tabToCheck[i, j] == "k1")
                    {
                        WhiteKingPositionX = j;
                        WhiteKingPositionY = i;
                    }
                    if (tabToCheck[i, j] == "k2")
                    {
                        BlackKingPositionX = j;
                        BlackKingPositionY = i;
                    }

                }
            }

            Console.WriteLine("KWX = " + WhiteKingPositionX + " KWY = " + WhiteKingPositionY);
            //sprawdzanie po X+
            for (int i = WhiteKingPositionX + 1; i < tabToCheck.GetLength(0); i++)
            {
                if (i <= 7 && i >= 0)
                {
                    Console.WriteLine(tabToCheck[WhiteKingPositionY, i]);
                    if (tabToCheck[WhiteKingPositionY, i] != "oo" && tabToCheck[WhiteKingPositionY, i] != "w2" && tabToCheck[WhiteKingPositionY, i] != "h2" && tabToCheck[WhiteKingPositionY, i] != "k2")
                    {

                        break;

                    }
                    else if (tabToCheck[WhiteKingPositionY, i] == "oo")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Szach");
                        return true;
                    }
                }
                else
                {
                    break;
                }
            }
            //sprawdzanie po X-
            for (int i = WhiteKingPositionX - 1; i >= 0; i--)
            {
                if (i <= 7 && i >= 0)
                {
                    Console.WriteLine(tabToCheck[WhiteKingPositionY, i]);
                    if (tabToCheck[WhiteKingPositionY, i] != "oo" && tabToCheck[WhiteKingPositionY, i] != "w2" && tabToCheck[WhiteKingPositionY, i] != "h2" && tabToCheck[WhiteKingPositionY, i] != "k2")
                    {
                        break;

                    }
                    else if (tabToCheck[WhiteKingPositionY, i] == "oo")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Szach");
                        return true;
                    }
                }
                else
                {
                    break;
                }
            }
            //sprawdzanie po Y+
            for (int i = WhiteKingPositionY + 1; i < tabToCheck.GetLength(0); i++)

            {
                if (i <= 7 && i >= 0)
                {
                    Console.WriteLine(tabToCheck[i, WhiteKingPositionX]);
                    if (tabToCheck[i, WhiteKingPositionX] != "oo" && tabToCheck[i, WhiteKingPositionX] != "w2" && tabToCheck[i, WhiteKingPositionX] != "h2" && tabToCheck[i, WhiteKingPositionX] != "k2")
                    {
                        break;

                    }
                    else if (tabToCheck[i, WhiteKingPositionX] == "oo")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Szach");
                        return true;
                    }
                }
                else
                {
                    break;
                }

            }
            //sprawdzanie po Y-
            for (int i = WhiteKingPositionY - 1; i >= 0; i--)
            {
                if (i <= 7 && i >= 0)
                {
                   
                    if (tabToCheck[i, WhiteKingPositionX] != "oo" && tabToCheck[i, WhiteKingPositionX] != "w2" && tabToCheck[i, WhiteKingPositionX] != "h2" && tabToCheck[i, WhiteKingPositionX] != "k2")
                    {
                        break;

                    }
                    else if (tabToCheck[i, WhiteKingPositionX] == "oo")
                    {
           
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("Szach");
                        return true;
                    }
                }
                else
                {
                    break;
                }
            }
            //sprawdzanie po X+ Y+
            var licznik = true;

            for (int i = WhiteKingPositionY + 1; i < tabToCheck.GetLength(0); i++)
            {

                for (int j = WhiteKingPositionX + 1; j < tabToCheck.GetLength(0); j++)
                {
                    if (i <= 7 && i >= 0 && j <= 7 && j >= 0)
                    {

                        if (i == j)
                        {
                            Console.WriteLine(tabToCheck[i, j] + "x "+ i +" y "+ j);
                            if (licznik)
                            {


                                if (tabToCheck[i, j] != "oo" && tabToCheck[i, j] != "h2" && tabToCheck[i, j] != "p2" && tabToCheck[i, j] != "g2" && tabToCheck[i, j] != "k2")
                                {
                                    break;

                                }
                                else if (tabToCheck[i, j] == "oo")
                                {
                                    Console.WriteLine("hmm");
                                    licznik = false;
                                    continue;
                                }

                                else
                                {
                                    Console.WriteLine("Szach");
                                    return true;
                                }
                            }
                            else
                            {
                                if (tabToCheck[i, j] != "oo" && tabToCheck[i, j] != "h2" && tabToCheck[i, j] != "g2" )
                                {
                                    break;

                                }
                                else if (tabToCheck[i, WhiteKingPositionX] == "oo")
                                {
                                    Console.WriteLine("hmm");
                                    licznik = false;
                                    continue;
                                }

                                else
                                {
                                    Console.WriteLine("Szach");
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }

                    }
                    else
                    {

                        break;
                    }
                }
            }
            return false;

        }
        public bool szachBlack(string[,] tabToCheck)
        {
            Console.WriteLine("sprawdzanie szacha");
            int WhiteKingPositionX = 0;

            int WhiteKingPositionY = 0;
            int BlackKingPositionY = 0;
            int BlackKingPositionX = 0;
            Console.WriteLine(tabToCheck.GetLength(0));
            for (int i = 0; i < tabToCheck.GetLength(0); i++)
            {
                for (int j = 0; j < tabToCheck.GetLength(0); j++)
                {
                    if (tabToCheck[i, j] == "k1")
                    {
                        WhiteKingPositionX = j;
                        WhiteKingPositionY = i;
                    }
                    if (tabToCheck[i, j] == "k2")
                    {
                        BlackKingPositionX = j;
                        BlackKingPositionY = i;
                    }

                }
            }



            //black King
            Console.WriteLine("KBX = " + BlackKingPositionX + " KBY = " + BlackKingPositionY);
            //sprawdzanie po X+
            for (int i = BlackKingPositionX + 1; i < tabToCheck.GetLength(0); i++)
            {
                if (i <= 7 && i >= 0)
                {
                    Console.WriteLine(tabToCheck[BlackKingPositionY, i]);
                    if (tabToCheck[BlackKingPositionY, i] != "oo" && tabToCheck[BlackKingPositionY, i] != "w1" && tabToCheck[BlackKingPositionY, i] != "h1" && tabToCheck[BlackKingPositionY, i] != "k1")
                    {

                        break;

                    }
                    else if (tabToCheck[BlackKingPositionY, i] == "oo")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Szach");
                        return true;
                    }
                }
                else
                {
                    break;
                }
            }
            //sprawdzanie po X-
            for (int i = BlackKingPositionX - 1; i >= 0; i--)
            {
                if (i <= 7 && i >= 0)
                {
                    Console.WriteLine(tabToCheck[BlackKingPositionY, i]);
                    if (tabToCheck[BlackKingPositionY, i] != "oo" && tabToCheck[BlackKingPositionY, i] != "w1" && tabToCheck[BlackKingPositionY, i] != "h1" && tabToCheck[BlackKingPositionY, i] != "k1")
                    {
                        break;

                    }
                    else if (tabToCheck[BlackKingPositionY, i] == "oo")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Szach");
                        return true;
                    }
                }
                else
                {
                    break;
                }
            }
            //sprawdzanie po Y+
            for (int i = BlackKingPositionY + 1; i < tabToCheck.GetLength(0); i++)

            {
                if (i <= 7 && i >= 0)
                {
                    Console.WriteLine(tabToCheck[i, BlackKingPositionX]);
                    if (tabToCheck[i, BlackKingPositionX] != "oo" && tabToCheck[i, BlackKingPositionX] != "w1" && tabToCheck[i, BlackKingPositionX] != "h1" && tabToCheck[i, BlackKingPositionX] != "k1")
                    {
                        break;

                    }
                    else if (tabToCheck[i, BlackKingPositionX] == "oo")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Szach");
                        return true;
                    }
                }
                else
                {
                    break;
                }

            }
            //sprawdzanie po Y-
            for (int i = BlackKingPositionY - 1; i >= 0; i--)
            {
                if (i <= 7 && i >= 0)
                {
                    Console.WriteLine(tabToCheck[i, BlackKingPositionX] + "y1");
                    if (tabToCheck[i, BlackKingPositionX] != "oo" && tabToCheck[i, BlackKingPositionX] != "w1" && tabToCheck[i, BlackKingPositionX] != "h1" && tabToCheck[i, BlackKingPositionX] != "k1")
                    {
                        break;

                    }
                    else if (tabToCheck[i, BlackKingPositionX] == "oo")
                    {
                        Console.WriteLine("hmm");
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("Szach");
                        return true;
                    }
                }
                else
                {
                    break;
                }
            }
            return false;
        }
        public void moveFromTo(int fromI, int fromJ, int toI, int toJ)
        {

            string tmpToMove = tablechest.tab[fromJ - 1, fromI - 1];
            string tmpEndMove = tablechest.tab[toJ - 1, toI - 1];

            if (check(fromI, fromJ, toI, toJ))
            {

                //black move
                if (numberOfMove % 2 == 0)
                {
                    if (tmpToMove != "p2" && tmpToMove != "s2" && tmpToMove != "w2" && tmpToMove != "g2" && tmpToMove != "h2" && tmpToMove != "k2")
                    {
                        Console.WriteLine("Teraz ruch białych");

                    }
                    else if (tmpEndMove == "p2" || tmpEndMove == "s2" || tmpEndMove == "w2" || tmpEndMove == "g2" || tmpEndMove == "h2" || tmpEndMove == "k2")
                    {
                        Console.WriteLine("Error pozycja zajeta przez twojego pionka.");
                    }
                    else
                    {
                        if (tablechest.tab[toJ - 1, toI - 1] != "oo")
                        {
                            for (int i = 0; i < tablechest.playerWhite.Length; i++)
                            {
                                if (tablechest.playerWhite[i] == tablechest.tab[toJ - 1, toI - 1])
                                {
                                    tablechest.playerWhite[i] = "xx";
                                    Console.WriteLine("białe straciły pionka");
                                    break;
                                }
                            }

                        }
                        tablechest.tab[toJ - 1, toI - 1] = tablechest.tab[fromJ - 1, fromI - 1];

                        tablechest.tab[fromJ - 1, fromI - 1] = "oo";
                        Console.WriteLine("czarne wykonały ruch");
                        numberOfMove++;
                    }

                }
                //white move
                if (numberOfMove % 2 != 0)
                {
                    if (tmpToMove != "p1" && tmpToMove != "s1" && tmpToMove != "w1" && tmpToMove != "g1" && tmpToMove != "h1" && tmpToMove != "k1")
                    {
                        Console.WriteLine("Teraz ruch czarnych");

                    }

                    else if (tmpEndMove == "p1" || tmpEndMove == "s1" || tmpEndMove == "w1" || tmpEndMove == "g1" || tmpEndMove == "h1" || tmpEndMove == "k1")
                    {
                        Console.WriteLine("Error pozycja zajeta przez twojego pionka.");
                    }
                    else
                    {
                        if (tablechest.tab[toJ - 1, toI - 1] != "oo")
                        {
                            for (int i = 0; i < tablechest.playerBlack.Length; i++)
                            {
                                if (tablechest.playerBlack[i] == tablechest.tab[toJ - 1, toI - 1])
                                {
                                    tablechest.playerBlack[i] = "xx";
                                    Console.WriteLine("czarne straciły pionka");
                                    break;
                                }
                            }


                        }
                        tablechest.tab[toJ - 1, toI - 1] = tablechest.tab[fromJ - 1, fromI - 1];

                        tablechest.tab[fromJ - 1, fromI - 1] = "oo";
                        Console.WriteLine("białe wykonały ruch");
                        numberOfMove++;
                    }
                }



            }

            else
            {

                Console.WriteLine("EROR-powtórz ruch");
            }
            if (szachBlack(tablechest.tab))
            {
                Console.WriteLine("szach czarne");
            }
            else if (szachWhite(tablechest.tab))
            {
                Console.WriteLine("szach białe");
            }

        }
        public bool check(int fromI, int fromJ, int toI, int toJ)
        {
            string tmpFrom = tablechest.tab[fromJ - 1, fromI - 1];
            string tmpTo = tablechest.tab[toJ - 1, toI - 1];
            int moveX = fromI - toI;

            int moveY = fromJ - toJ;

            //pionek
            if (tmpFrom == "p1" || tmpFrom == "p2")
            {
                if ((moveY < 0 && moveY > -3 && numberOfMove < 3 && moveX == 0) || (moveY > 0 && moveY < 3 && moveX == 0 && numberOfMove < 3))
                {
                    Console.WriteLine("Pierwsze ruchy");
                    return true;

                }
                else
                {

                    if ((moveY < 0 && moveY > -2 && moveX == 0) || (moveY > 0 && moveY < 2 && moveX == 0))
                    {
                        if (tmpTo == "oo")
                        {
                            Console.WriteLine("normal ruch");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("NIEDOZOWLONY 1");
                            return false;

                        }

                    }
                    else if ((moveX > 0 && moveX < 2 && moveY > 0 && moveY < 2 && tmpFrom == "p2") || (moveX < 0 && moveX > -2 && moveY < 0 && moveY > -2 && tmpFrom == "p1") || (moveX > 0 && moveX < 2 && moveY < 0 && moveY > -2 && tmpFrom == "p1") || (moveX < 0 && moveX > -2 && moveY > 0 && moveY < 2 && tmpFrom == "p2"))
                    {
                        if (tmpTo == "oo")
                        {
                            Console.WriteLine("NIEDOZOWLONY 2");
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("BICIE");
                            return true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("NIEDOZOWLONY 3" + tmpFrom + " " + tmpTo + moveX + moveY);
                        return false;
                    }

                }
            }
            //skoczek
            if (tmpFrom == "s1" || tmpFrom == "s2")
            {
                if (moveX == 1 && moveY == 2)
                {
                    return true;
                }
                if (moveX == 1 && moveY == -2)
                {
                    return true;
                }
                if (moveX == -1 && moveY == 2)
                {
                    return true;
                }
                if (moveX == -1 && moveY == -2)
                {
                    return true;
                }
                //
                if (moveX == 2 && moveY == 1)
                {
                    return true;
                }
                if (moveX == 2 && moveY == -1)
                {
                    return true;
                }
                if (moveX == -2 && moveY == 1)
                {
                    return true;
                }
                if (moveX == -2 && moveY == -1)
                {
                    return true;
                }
                else
                {

                    Console.WriteLine("Niedozwolny ruch skoczka");
                    return false;
                }
            }
            //wieza
            if (tmpFrom == "w1" || tmpFrom == "w2")
            {

                if (moveX == 0)
                {
                    if (moveY > 0)
                    {
                        Console.WriteLine("Y+");
                        for (int i = fromJ - 2; i > toJ - 1; i--)
                        {
                            Console.WriteLine("dziala");
                            Console.WriteLine(tablechest.tab[i, fromI - 1]);
                            if (tablechest.tab[i, fromI - 1] != "oo")
                            {
                                Console.WriteLine("cos stoi na przeszkodzie");
                                return false;
                            }


                        }
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Y-");
                        for (int i = fromJ; i < toJ - 1; i++)
                        {
                            if (tablechest.tab[i, fromI - 1] != "oo")
                            {
                                Console.WriteLine("cos stoi na przeszkodzie");
                                return false;
                            }


                        }
                        return true;
                    }


                }
                if (moveY == 0)
                {
                    if (moveX > 0)
                    {
                        Console.WriteLine("X+");
                        for (int i = fromI-2; i > toI - 1; i--)
                        {
                            if (tablechest.tab[fromJ - 1, i] != "oo")
                            {
                                Console.WriteLine("cos stoi na przeszkodzie");
                                return false;
                            }


                        }
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("X-");
                        for (int i = fromI; i < toI - 1; i++)
                        {
                            if (tablechest.tab[fromJ - 1, i] != "oo")
                            {
                                Console.WriteLine("cos stoi na przeszkodzie");
                                return false;
                            }


                        }
                        return true;

                    }


                }
                else
                {
                    Console.WriteLine("bledny ruch wiezy");
                    return false;
                }
            }
            //goniec
            if (tmpFrom == "g1" || tmpFrom == "g2")
            {
                if (moveX == moveY || -moveX == -moveY || -moveX == moveY || moveX == -moveY)
                {
                    if (moveX > 0)
                    {
                        if (moveY > 0)
                        {
                            for (int i = fromI; i > toI - 1; i--)
                            {
                                for (int j = fromJ; j > toJ - 1; j--)
                                {
                                    if (i == j && tablechest.tab[j, i] != "oo")
                                    {
                                        return false;
                                    }
                                }
                            }
                            Console.WriteLine("----" + moveX + " " + moveY + "----");
                            return true;
                        }

                        else if (moveY < 0)
                        {
                            for (int i = fromI; i > toI - 1; i--)
                            {
                                for (int j = fromJ; j < toJ - 1; j++)
                                {
                                    if (i == j && tablechest.tab[j, i] != "oo")
                                    {
                                        return false;
                                    }
                                }
                            }
                            Console.WriteLine("----" + moveX + " " + moveY + "---eee-");
                            return true;
                        }
                        return false;

                    }

                    if (moveX < 0)
                    {
                        if (moveY > 0)
                        {
                            for (int i = fromI; i < toI - 1; i++)
                            {
                                for (int j = fromJ; j > toJ - 1; j--)
                                {
                                    if (i == j && tablechest.tab[j, i] != "oo")
                                    {
                                        return false;
                                    }
                                }
                            }
                            Console.WriteLine("----" + moveX + " " + moveY + "----");
                            return true;
                        }


                        else if (moveY < 0)
                        {
                            for (int i = fromI; i < toI - 1; i++)
                            {
                                for (int j = fromJ; j < toJ - 1; j++)
                                {
                                    if (i == j && tablechest.tab[j, i] != "oo")
                                    {
                                        return false;
                                    }
                                }
                            }
                            Console.WriteLine("----" + moveX + " " + moveY + "----");
                            return true;
                        }
                        return false;

                    }
                    return false;
                }
                else
                {

                    Console.WriteLine("niedozwolony ruch gonca");
                    return false;
                }
            }
            //hetman
            if (tmpFrom == "h1" || tmpFrom == "h2")
            {
                if (moveX == 0)
                {
                    if (moveY > 0)
                    {
                        Console.WriteLine("Y+");
                        for (int i = fromJ - 2; i > toJ - 1; i--)
                        {

                            Console.WriteLine(tablechest.tab[i, fromI - 1]);
                            if (tablechest.tab[i, fromI - 1] != "oo")
                            {
                                Console.WriteLine("cos stoi na przeszkodzie");
                                return false;
                            }


                        }
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Y-");
                        for (int i = fromJ; i < toJ - 1; i++)
                        {
                            if (tablechest.tab[i, fromI - 1] != "oo")
                            {
                                Console.WriteLine("cos stoi na przeszkodzie");
                                return false;
                            }


                        }
                        return true;
                    }


                }
                if (moveY == 0)
                {
                    if (moveX > 0)
                    {
                        Console.WriteLine("X+");
                        for (int i = fromI; i > toI - 1; i--)
                        {
                            if (tablechest.tab[fromJ - 1, i] != "oo")
                            {
                                Console.WriteLine("cos stoi na przeszkodzie");
                                return false;
                            }


                        }
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("X-");
                        for (int i = fromI; i < toI - 1; i++)
                        {
                            if (tablechest.tab[fromJ - 1, i] != "oo")
                            {
                                Console.WriteLine("cos stoi na przeszkodzie");
                                return false;
                            }


                        }
                        return true;

                    }


                }
                if (moveX == moveY || -moveX == -moveY || -moveX == moveY || moveX == -moveY)
                {
                    if (moveX > 0)
                    {
                        if (moveY > 0)
                        {
                            for (int i = fromI; i > toI - 1; i--)
                            {
                                for (int j = fromJ; j > toJ - 1; j--)
                                {
                                    if (i == j && tablechest.tab[j, i] != "oo")
                                    {
                                        return false;
                                    }
                                }
                            }
                            Console.WriteLine("----" + moveX + " " + moveY + "----");
                            return true;
                        }

                        else if (moveY < 0)
                        {
                            for (int i = fromI; i > toI - 1; i--)
                            {
                                for (int j = fromJ; j < toJ - 1; j++)
                                {
                                    if (i == j && tablechest.tab[j, i] != "oo")
                                    {
                                        return false;
                                    }
                                }
                            }
                            Console.WriteLine("----" + moveX + " " + moveY + "---eee-");
                            return true;
                        }
                        return false;

                    }

                    if (moveX < 0)
                    {
                        if (moveY > 0)
                        {
                            for (int i = fromI; i < toI - 1; i++)
                            {
                                for (int j = fromJ; j > toJ - 1; j--)
                                {
                                    if (i == j && tablechest.tab[j, i] != "oo")
                                    {
                                        return false;
                                    }
                                }
                            }
                            Console.WriteLine("----" + moveX + " " + moveY + "----");
                            return true;
                        }


                        else if (moveY < 0)
                        {
                            for (int i = fromI; i < toI - 1; i++)
                            {
                                for (int j = fromJ; j < toJ - 1; j++)
                                {
                                    if (i == j && tablechest.tab[j, i] != "oo")
                                    {
                                        return false;
                                    }
                                }
                            }
                            Console.WriteLine("----" + moveX + " " + moveY + "----");
                            return true;
                        }
                        return false;

                    }
                    return false;
                }
                else
                {
                    Console.WriteLine("Niedozwolony ruch hetmana");
                    return false;
                }
            }
            if (tmpFrom == "k1" || tmpFrom == "k2")
            {
                if (-2 < moveX && moveX < 2 && -2 < moveY && moveY < 2)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine(moveX + " " + moveY);
                    Console.WriteLine("niedozwolony ruch króla");
                    return false;
                }
            }
            else
            {

                Console.WriteLine("NIEDOZOWLONY 4" + tmpFrom + " " + tmpTo);
                return false;
            }
        }
        public void Write()
        {
            tablechest.writeChest(tablechest.tab);
            Console.WriteLine();
            Console.WriteLine(numberOfMove);
            Console.Write("White: ");
            for (int i = 0; i < tablechest.playerWhite.Length; i++)
            {
                Console.Write(tablechest.playerWhite[i].ToUpper() + ", ");
            }
            Console.WriteLine();
            Console.Write("Black: ");
            for (int i = 0; i < tablechest.playerBlack.Length; i++)
            {
                Console.Write(tablechest.playerBlack[i].ToUpper() + ", ");
            }
            Console.WriteLine();
        }
    }
    class chest
    {
        public string[,] tab;
        public string[] playerWhite = { "w1", "s1", "g1", "h1", "k1", "g1", "s1", "w1", "p1", "p1", "p1", "p1", "p1", "p1", "p1", "p1" };
        public string[] playerBlack = { "w2", "s2", "g2", "h2", "k2", "g2", "s2", "w2", "p2", "p2", "p2", "p2", "p2", "p2", "p2", "p2" };
        public chest()
        {
            tab = new string[,] { { "w1", "s1", "g1", "h1", "k1", "g1", "s1", "w1" },
                { "p1", "p1", "p1", "p1", "p1", "p1", "p1", "p1" },
                { "oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo" },
                { "oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo" },
                { "oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo" },
                { "oo", "oo", "oo", "oo", "oo", "oo", "oo", "oo" },
                { "p2", "p2", "p2", "p2", "p2", "p2", "p2", "p2" },
                { "w2", "s2", "g2", "h2", "k2", "g2", "s2", "w2" }};
        }
        public void writeChest(string[,] tabToWrite)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("  " + tabToWrite[i, j].ToUpper() + "  ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            game newGame = new game();
            newGame.Write();
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Podaj poczatek: ");
                int xo = int.Parse(Console.ReadLine());
                int yo = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj koniec: ");
                int xk = int.Parse(Console.ReadLine());
                int yk = int.Parse(Console.ReadLine());
                if (0 < xk && xk < 9 && 0 < xo && xo < 9 && 0 < yo && yo < 9 && 0 < yk && yk < 9)
                {
                    newGame.moveFromTo(xo, yo, xk, yk);
                    newGame.Write();

                }

            }

            Console.ReadKey();
        }
    }
}
