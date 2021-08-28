using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace URI
{
    class Program
    {
        const string YES = "YES";
        const string FIM = "FIM";
        static int maxLengthWord = 0;
        static void Main(string[] args)
        {
            var friends = new HashSet<KeyValuePair<string, string>>();
            Read(friends);
            var newFriends = Order(friends);
            WriteFriends(newFriends);
            Console.WriteLine();
            WriteWinner(friends);
        }

        private static void WriteWinner(IEnumerable<KeyValuePair<string, string>> friends)
        {
            Console.WriteLine("Amigo do Habay:\n{0}", friends.First(x => x.Value == YES && x.Key.Length == maxLengthWord).Key);
        }

        private static void WriteFriends(IEnumerable<KeyValuePair<string, string>> newFriends)
        {
            foreach (var item in newFriends)
            {
                Console.WriteLine(item.Key);
                if (item.Value == YES)
                    maxLengthWord = Math.Max(maxLengthWord, item.Key.Length);
            }
        }

        private static IEnumerable<KeyValuePair<string, string>> Order(IEnumerable<KeyValuePair<string, string>> friends)
        {
            return friends.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
        }

        private static void Read(HashSet<KeyValuePair<string, string>> friends)
        {
            string[] keyValue = { "", "" };
            while (keyValue[0] != FIM)
            {
                keyValue = Console.ReadLine().Split(' ');
                if (keyValue[0] != FIM && !string.IsNullOrEmpty(keyValue[0]))
                    friends.Add(new KeyValuePair<string, string>(keyValue[0], keyValue[1]));
            }
        }
    }
}
