using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Days
{
    public class Day2
    {
        // private List<string> data = new List<string> { "abcdef", "bababc", "abbcde", "abcccd", "aabcdd", "abcdee", "ababab" };
        //private List<string> data = new List<string> { "abcde", "fghij", "klmno", "pqrst", "fguij", "axcye", "wvxyz" };
        private List<string> data = new List<string> { "ivyhczwokexltwhsfamqprbnuy", "ivjhcjdokexltwwsfamqpabnuy", "ivjhczdokebltwgsfydqprbnuy", "ivjhcadokexftogsfamqprbnuy", "idjhczdokexltwgsfacqprbnuh", "ivjhgzookexltwgsfamqjrbnuy", "uvjhctdokexltwosfamqprbnuy", "ivrhczdokexltwhzfamqprbnuy", "ivjhczuxkexltwgsfamqprbney", "ivjhczdokemltwgsfadnprbnuy", "ifjhczdokexltwgsfamqprbkuf", "ivjhkzdokltltwgsfamqprbnuy", "ivjuczdhkexltwgsfamqprtnuy", "ivjhjzdxkexltwgsfapqprbnuy", "ivlhczdoxexltwgsfamqprgnuy", "ivjhczdoknxltwgssamqsrbnuy", "ivjhczdokexltwgswadqprbruy", "ivjhczdokexthwgsfampprbnuy", "uvjhczrozexltwgsfamqprbnuy", "ivolczdokexltwgsffmqprbnuy", "ivjhczibkexltwgsfamoprbnuy", "ivjhczdokefltmgsfamqprbouy", "ivjhczdobexltngsfamsprbnuy", "ivjhczdokexltwvsfxqqprbnuy", "dvjhczdokexucwgsfamqprbnuy", "kvjhszkokexltwgsfamqprbnuy", "ivjhczdokexrtegsfamqprbnus", "ivjhctdokexltwglgamqprbnuy", "ivjhczdozexutwgsfamqdrbnuy", "ivjhczqokemltwgsfakqprbnuy", "uvjhczdokexlqwgsfadqprbnuy", "ivjhczdohexltwglffmqprbnuy", "izjhczdokexltwgsfamqprbsqy", "iajhczdokwxltwgjfamqprbnuy", "ivjfczdokexllwgslamqprbnuy", "ivjhczdoyexltwgsfamqdrbnxy", "ivjhczdokekwtwssfamqprbnuy", "ivjhcodokexltwgsfamqirxnuy", "ihjhhzdokexltwgsfamqlrbnuy", "ivjdpzdokexltwfsfamqprbnuy", "ivjhcpdokexltwgsfamqqrbruy", "qvjhcziokexltwgsfamqprbnny", "ivohczdomexltwgsfkmqprbnuy", "ivjhczhokhxlywgsfamqprbnuy", "ivjhczdokexltwgmffmqprbruy", "ivjhczdokqxltwgcfamqprbnyy", "ivjhczdokepltwgsfamcprbnay", "ivjhczdokexltwgseamqpmbnua", "ivjzczdokexltwgszamqplbnuy", "ivjhczpokexltwgvfgmqprbnuy", "idjhczdokexltwgsxamqprbndy", "ivjhczdxkexltwgcgamqprbnuy", "ivjhczdckexatpgsfamqprbnuy", "ivjrczdorexltwgsfamqprbnvy", "ivjoczdokexltwgswamqprbtuy", "iylhczdokexltwgsfamqpxbnuy", "imxhczdokkxltwgsfamqprbnuy", "ivvhczdoktxltwgsfamaprbnuy", "ivyhczdokexltwhsfayqprbnuy", "ivjhcrdokexltegsfamqprbnum", "rvjhezdokexltwgsoamqprbnuy", "ivjzczdokexlbwgsfkmqprbnuy", "ivjhczdokelltwgsyamqprbnoy", "ixjhczdorexltwgsfamqprbuuy", "ivjhczpokexdtwglfamqprbnuy", "ivjhczdokexltwgfgamcprbnuy", "ikjhczdokexltwgsfamqirbnux", "ivjhczdopjxltwgsfamqprbnny", "ivchczdokexltwgniamqprbnuy", "ivjhczdooeqltwgsfamqprbniy", "ivjhcldonexltwgbfamqprbnuy", "ixjhczdokehltwgsfamqprbnuf", "ivjhczdckefltwgsfamqppbnuy", "ivjhczdoqrxltwgsfamqprbnun", "ivjhczdokcxltwgmfarqprbnuy", "ivjhcziorexltqgsfamqprbnuy", "ivjhwzdokexltwgnfamqprbcuy", "ivjhczdoqexltwgsfazqprunuy", "iijhczdokexltwgsyamqprbnug", "ivjhczdokexltwgxfamhprbnry", "ivjhczdakexltwgsfaeqlrbnuy", "ivjhqzdokehltwgsfampprbnuy", "ivjhczdokexltwlsfpmyprbnuy", "ivjhfzdoktxltwgsfamzprbnuy", "ivlhvzdokexltwgsvamqprbnuy", "ivjhczdbkexltwgsaamqprfnuy", "ivahcedokexltigsfamqprbnuy", "cvjhczdokexltwgsfamapibnuy", "ivjhczkokbxltwgsfbmqprbnuy", "pvjuczdnkexltwgsfamqprbnuy", "iyjhczdckexotwgsfamqprbnuy", "ivjhzzdokvxltwgsfamqprbnuo", "ivjhczdobexltwgsxamqprbnry", "ivjhczdokexltwgsfaprprbnub", "ivjhczdokexltwgofarqprbkuy", "ivjhczdokexltwgbfymqprbnhy", "ibjhczdokexltwgsfkmqpvbnuy", "ivjhczdzkexlywgsfacqprbnuy", "hvdhczdokexltwglfamqprbnuy", "ivjhczdokexrtwgsfamqprbsuh", "ivjhczhokexltngsfamqpjbnuy", "ivjhcsjokexltwgsfaeqprbnuy", "ivjmczdokexltmgsfamqpbbnuy", "wvjhczdokexltwgsfamkpkbnuy", "icjhpzdoaexltwgsfamqprbnuy", "ivjmczdhkexltwgsfzmqprbnuy", "ivjhczdokexytwgsfamqprbwug", "ikjhczdjkexljwgsfamqprbnuy", "ivjvcdmokexltwgsfamqprbnuy", "ivjhazdorixltwgsfamqprbnuy", "ivchczdokexltwgsfamzprenuy", "ivjcczdokexlttgsfamqpmbnuy", "ibchgzdokexltwgsfamqprbnuy", "ivjhczdokepltwgsfamqpeenuy", "ivjnwzdokexlrwgsfamqprbnuy", "ivjhczdokexitwgsfadqlrbnuy", "icjhcrdokexltwgsfamqkrbnuy", "ivngczdokexltwgsfamqprbyuy", "ivjhuudokexlvwgsfamqprbnuy", "ivjhczdnkexltwgsfhmqpxbnuy", "itjhczdokexltwvsfamgprbnuy", "ivjhcddokexltwgsfakqprbnny", "ivjhuzdojexltwfsfamqprbnuy", "idjhczdokexltwgsfamqukbnuy", "ivjhczdokexlzigsfamqprbngy", "ivjwczdokexltwgufamqprbnuo", "iijhczdokexltwfsfadqprbnuy", "ivjhczdukexdtwgsfamqpsbnuy", "idjhczdokexllwgssamqprbnuy", "zvjhczdokexrtwgsfamqplbnuy", "ivphczdofexltwgefamqprbnuy", "ivhhczdokexlpwgsjamqprbnuy", "ivjhczdovexltwgsfamqprhnuj", "ivjhczdoklxltwgseamqprlnuy", "ivjhcqdokexltngsfamqprdnuy", "ivjhczdoifxltagsfamqprbnuy", "izjhczdokexltwjsramqprbnuy", "psjhczdokexlgwgsfamqprbnuy", "ivjhcadokexltwgsfsmqwrbnuy", "ivjhczdokexltwgsfawqiibnuy", "ivjhczkokexhtwgsfamqprbnuk", "ivjhcmdukexltwgsfamvprbnuy", "ivjlczdokexltwgsfamquibnuy", "ivjhczdokexntwgyfamqprbniy", "ivjhczdokexltwlsfafqprbnuc", "ivjhczdosexltrtsfamqprbnuy", "ivjhcznokexbtwgsfafqprbnuy", "ivwtczdotexltwgsfamqprbnuy", "ivjhvzdokexltigsoamqprbnuy", "ivjhcmdokexltwasfamqirbnuy", "ivthczdokexltwgsfaydprbnuy", "ivjhwzdskexltwgsfamqprbnus", "icjhczdosuxltwgsfamqprbnuy", "ivjhczdokexltwgstamqbrmnuy", "iejhczuoktxltwgsfamqprbnuy", "ivjhczdokeqltwgskamqprbniy", "ivjhlzdokexltugsfamqprbpuy", "iwjqczdckexltwgsfamqprbnuy", "ivjhwzdokexluwgsfxmqprbnuy", "ivjhczdokexltwgwfwmqprbguy", "gvjhczkokexltwgsfgmqprbnuy", "ivjhczdoyexlhwgsfamqprbnoy", "cvjhczdokexltwgsfomqprinuy", "vvmhczdokexltwgsfamqprbnun", "vvjhczdokexltwgsftmfprbnuy", "ivkhckdokhxltwgsfamqprbnuy", "iyjhczdkkexltjgsfamqprbnuy", "ivlhczdokexltwgsfamqyrbhuy", "tvjhmzdokexltwgsfamqorbnuy", "ivjhczdokexltwvsfamqprbnxi", "ivjhczdowexltwgswamqerbnuy", "wvjiczdomexltwgsfamqprbnuy", "ivjpizdokexltwgvfamqprbnuy", "ivjhuzdokexlzwgspamqprbnuy", "ivjhczdokeyltwgkfamqprdnuy", "jvjhczdokexlnwgsfamqirbnuy", "ivjheidokexltwvsfamqprbnuy", "mvjhczdokexltwgsfamqyrsnuy", "ivjhazdykexltwgsramqprbnuy", "ivjkcodokexltwgsxamqprbnuy", "ikjhczdoktxltwgpfamqprbnuy", "ivjhyzdfkexmtwgsfamqprbnuy", "ivohczdokexltugsfamqprynuy", "ivjkczdqkexltwgshamqprbnuy", "ivjhczdokexltwgskamqynbnuy", "icjhczdokexltwgofamrprbnuy", "ivjhlzdokealtwgsfamqsrbnuy", "ivehczdybexltwgsfamqprbnuy", "ovjhczdokexltwgsfamqirbnuo", "ivjoczdokexltwgsfamqurbnty", "ivjmczdokexltwgsfrmqprnnuy", "ivjhczdowpxltwgbfamqprbnuy", "ivjhczdokexltwfsfamqkrgnuy", "ivjhwzdokexltwgsfavqprbnuq", "jvjhczdokexltwgsiamqprbnny", "ivjhlzdouexltwfsfamqprbnuy", "ivjhczdokexltwgsfamqbrbnlv", "iwjhczdokexltwgsfapqprbnqy", "idjhczdokexltwgsaamqrrbnuy", "ivjhjzdopepltwgsfamqprbnuy", "ivjmczdokejltwgsfamqpbbnuy", "ivjhczdokexltwgsuamdprvnuy", "injhczdokexltwgefamqurbnuy", "iujhczdokexltwgsaamqjrbnuy", "ivjhczdokexltwgvfaaqprbnly", "ivehczdokexltwgsfamqppbnui", "ivxhczdodexltwgsfamqplbnuy", "ivjhczfokexltwgsfamqpwbauy", "ivjhcztwkexhtwgsfamqprbnuy", "ivjeczdokexltygsfmmqprbnuy", "ivjhchdokexltwgsmameprbnuy", "ivkhczdoklxltwggfamqprbnuy", "ivjhczdzkexltwhsfamqprjnuy", "ivjhcedokeultngsfamqprbnuy", "ivjhczdokexvtwgseabqprbnuy", "ivjhczdooexltlgsfamqpibnuy", "ivjgczvosexltwgsfamqprbnuy", "ivlhczwokexltwgsfamqmrbnuy", "lvjhczdokexutwgsfamrprbnuy", "ivahczdokexpdwgsfamqprbnuy", "ivjhcznokexltwhsfamqpnbnuy", "ivjhczdpkyxltwgbfamqprbnuy", "ivjhnzdokexltwgsftmqprinuy", "ivihczdokexltnhsfamqprbnuy", "ivjhcbdokevltwgsfamqprbauy", "hgjoczdokexltwgsfamqprbnuy", "dvjhczdckexltwgsfamqpybnuy", "ivjhcadokesltwgsfsmqwrbnuy", "ivjhwzdokexlttgsfamqprbney", "ivjhcidokexltwgofamqfrbnuy", "ivokwzdokexltwgsfamqprbnuy", "ivjiczdokexltwgsfaqqarbnuy", "ivjhczdokexqtwfsfamgprbnuy", "ivjhczdokealtwgsfamqerbnqy", "ivjhczdskexltwgsfamqprznuu", "ivjhwzdokexltwjsfdmqprbnuy", "ivjhczaokexlzwgsfamqprbnus", "ivjhczdokexltwosfamqnrbnux", "ivjhczdokexlqwgsfamwprcnuy", "ivjhczdqkexltwgswamqpcbnuy", "ijjhczdokexnttgsfamqprbnuy", "ivjhcedckexltwgsfamqprbnpy", "ivjhczdokeyltwgsfamqshbnuy", "ivjhczdokexltsgsfamqpmznuy", "ivjlczdtkeiltwgsfamqprbnuy", "ivjhczdokexltwgsfkmtprbnby", "ivjhnzdozexltwgsfamqprbnuc", "xqjxczdokexltwgsfamqprbnuy", "ivjhczdokeyltwgsfamqnrbnuw", "ivjwczgokexltwgsfamvprbnuy" };

        public int Star1()
        {
   
            int CountOfPairs =0;
            int CountOfTrips = 0;
            foreach (var item in data)
            {
                var letterDict = new Dictionary<char, int>();
                foreach (var letter in item)
                {
                    if (letterDict.ContainsKey(letter))
                    {
                        letterDict[letter]++;
                    }
                    else
                    {
                        letterDict.Add(letter, 1);
                    }
                }
                var pairs = letterDict.Where(x => x.Value == 2).Count();
                CountOfPairs += pairs > 0 ? 1 : 0;
                var trips = letterDict.Where(x => x.Value == 3).Count();
                CountOfTrips += trips > 0 ? 1 : 0;
                //Console.WriteLine($"{item}-- pairs: {pairs}. trips: {trips}");
            }
            //Console.WriteLine($"FinalPairs: {CountOfPairs}. FinalTrips: {CountOfTrips}");
            return CountOfPairs * CountOfTrips;
        }

        public string Star2()
        {
            foreach (var item in data)
            {
                foreach (var test in data)
                {
                    var diffLocation = 0;
                    var diffs = 0;
                    for (var i = 0; i < item.Count(); i++)
                    {
                        if (item[i] != test[i])
                        {
                            diffLocation = i;
                            diffs++;
                        }
                    }

                    if (diffs == 1)
                    {
                        return item.Remove(diffLocation,1);
                    }
                }
            }
            throw new Exception("None found");
        }
    }
}
