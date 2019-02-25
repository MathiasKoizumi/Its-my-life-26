using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class BolleHeaven
	{
		private List<Jingo> john;

		private Bongo jiggy;

		private Form1 form1;

		public BolleHeaven(Form1 form)
		{
			form1 = form;
			form1.explodeMe(1200, 1000);
			if (!form1.timer1IsRunning)
			{
				form1.SpellOut(form1.junkie.Next(3, 6));
				form1.timer1.Start();
				form1.timer1IsRunning = true;
			}
		}

		public BolleHeaven(List<Jingo> john)
		{
			this.john = john;
		}

		public int bolledej(int x, int y)
		{
			return 400300 + x - y;
		}

		public string vowel(int joy, Random jiggo)
		{
			string[] array = callShuffle(new string[14]
			{
				"a",
				"e",
				"ol",
				"i",
				"y",
				"iv",
				"af",
				" ",
				"up",
				"ed",
				"an",
				"ka",
				"ti",
				"mu"
			});
			return array[jiggo.Next(14)];
		}

		public string constantIteration(int numberJoy, Random joy)
		{
			string[] array = callShuffle(new string[16]
			{
				"j",
				"k",
				"t",
				"s",
				"r",
				"v",
				" ",
				"n",
				"m",
				"p",
				"-",
				"\u00b4",
				"|",
				"3",
				"-4",
				"uo"
			});
			return array[joy.Next(16)];
		}

		private string[] callShuffle(string[] bonnysFornøjelse)
		{
			return bonnysFornøjelse;
		}

		public string gEn2Name(int lenght, Random pig)
		{
			switch (pig.Next(15))
			{
			case 0:
				return constantIteration(133, pig) + vowel(12, pig) + constantIteration(150, pig) + vowel(1400, pig) + constantIteration(132, pig);
			case 1:
				return vowel(21, pig) + constantIteration(951, pig) + constantIteration(391, pig) + vowel(5861, pig) + constantIteration(4851, pig);
			case 2:
				return constantIteration(124, pig) + constantIteration(135, pig) + vowel(146, pig) + vowel(61, pig) + constantIteration(13, pig);
			case 3:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig);
			case 4:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig) + vowel(153, pig) + constantIteration(561, pig);
			case 5:
				return vowel(153, pig) + constantIteration(186, pig) + constantIteration(55, pig) + constantIteration(186, pig) + vowel(153, pig) + vowel(153, pig) + constantIteration(561, pig) + constantIteration(561, pig);
			case 6:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig) + vowel(351, pig);
			case 7:
				return constantIteration(951, pig) + vowel(21, pig) + constantIteration(391, pig) + constantIteration(4851, pig) + vowel(234, pig);
			case 8:
				return constantIteration(951, pig) + vowel(21, pig) + constantIteration(391, pig) + constantIteration(4851, pig) + vowel(5861, pig) + constantIteration(4851, pig);
			case 9:
				return constantIteration(951, pig) + vowel(21, pig) + constantIteration(391, pig) + constantIteration(4851, pig) + vowel(5861, pig);
			case 10:
				return constantIteration(951, pig) + vowel(21, pig) + vowel(5861, pig);
			default:
				return constantIteration(364, pig) + vowel(136, pig) + constantIteration(153, pig);
			}
		}

		internal static Jongo bongo(int p, Afmagt afmagt)
		{
			throw new NotImplementedException();
		}

		public string[] gEn2NameArray(int lenght, Random pig)
		{
			List<string> list = new List<string>();
			switch (pig.Next(15))
			{
			case 0:
				list.Add(constantIteration(133, pig));
				list.Add(vowel(12, pig));
				list.Add(constantIteration(150, pig));
				list.Add(vowel(1400, pig));
				list.Add(constantIteration(132, pig));
				return list.ToArray();
			case 1:
				list.Add(vowel(21, pig));
				list.Add(constantIteration(951, pig));
				list.Add(constantIteration(391, pig));
				list.Add(vowel(5861, pig));
				list.Add(constantIteration(4851, pig));
				return list.ToArray();
			case 2:
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(135, pig));
				list.Add(vowel(146, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(13, pig));
				return list.ToArray();
			case 3:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			case 4:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				return list.ToArray();
			case 5:
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				return list.ToArray();
			case 6:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			case 7:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			case 8:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				return list.ToArray();
			case 9:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			case 10:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			default:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			}
		}

		public string[] getSentenceVolaHovski(int lines, int words)
		{
			string[] array = new string[400];
			array[0] = "Der";
			array[1] = "var";
			array[2] = "engang";
			array[3] = "en";
			array[4] = "gammel";
			array[5] = "mand";
			array[6] = "han";
			array[7] = "hed";
			array[8] = "OlleBolle";
			array[9] = "fire";
			array[10] = "måneder";
			array[11] = "senere";
			array[12] = "gik";
			array[13] = "han";
			array[14] = "i";
			array[15] = "skole";
			array[16] = "maden";
			array[17] = "var";
			array[18] = "tam";
			array[19] = "men";
			array[20] = "nem";
			array[21] = "at";
			array[22] = "få";
			array[23] = "ned";
			array[24] = "to";
			array[25] = "sætninger";
			array[26] = "blev";
			array[27] = "til";
			array[28] = "i";
			array[29] = "hans";
			array[30] = "skolegård";
			array[31] = "fire";
			array[32] = "mennesker";
			array[33] = "så";
			array[34] = "til";
			array[35] = "mens";
			array[36] = "han";
			array[37] = "spiste";
			array[38] = "leverpostej";
			array[39] = "det";
			array[40] = "var";
			array[41] = "en";
			array[42] = "dejlig";
			array[43] = "dag";
			array[44] = "hunden";
			array[45] = "gik";
			array[46] = "tur";
			array[47] = "med";
			array[48] = "sig";
			array[49] = "selv";
			array[50] = "en";
			array[51] = "dag";
			array[52] = "gik";
			array[53] = "det";
			array[54] = "op";
			array[55] = "for";
			array[56] = "ham";
			array[57] = "mennesker";
			array[58] = "stod";
			array[59] = "i";
			array[60] = "kø";
			array[61] = "for";
			array[62] = "at";
			array[63] = "sige";
			array[64] = "goddag";
			array[65] = "flere";
			array[66] = "kom";
			array[67] = "til";
			array[68] = "en";
			array[69] = "dag";
			array[70] = "blev";
			array[71] = "det";
			array[72] = "mange";
			array[73] = "fornøjelser";
			array[74] = "kom";
			array[75] = "og";
			array[76] = "gik";
			array[77] = "klokken";
			array[78] = "blev";
			array[79] = "sent";
			array[80] = "men";
			array[81] = "han";
			array[82] = "var";
			array[83] = "vågen";
			string[] array2 = new string[lines];
			for (int i = 0; i < lines; i++)
			{
				string text = "";
				int num = 0;
				for (int j = 0; j < form1.junkie.Next(words) + 4; j++)
				{
					if (num >= 6)
					{
						text += ", ";
						num = form1.junkie.Next(3);
					}
					text = text + array[form1.junkie.Next(84)] + " ";
					num++;
				}
				array2[i] = text;
			}
			return array2;
		}

		public string[] getSentenceVolaHovskiPovski(int lines, int words)
		{
			new List<string>();
			string str = "Der var engang en smuk tusse den hed alfred og boede i en skov skoven lå mellem to bjerge og midt imellem løb en flod";
			str += " I dalen boede fem tosser den ene havde en datter så smuk hun hed Magdalene hendes yndlingsdyr var en enhjørning som viste sig i en lysning";
			str += " i dalen to mennesker troede de ville have hævn og det var den rene sandhed godt nok sagde jesus en masse om kærlighed";
			string str2 = "Fire mennesker troede på Jesus men så kom en alien og sagde goddag på fransk han hed ipswitch og handler om";
			str2 += " tid og sted to patroner til du forstår det handler om divine intervention betyder på fransk at gud er med os";
			str2 += " hvad enten vi tror eller ej sådan er livet min ven vi handler i god tro altid vi er guds efterkommere";
			string str3 = "vi har en tid for os selv musikken er mærkelig og livet går vidre frøen bor i os alle alle er guds børn forstå mig ret";
			str3 += " sådan er livet vi moser med trends der får os i uføre hvem skal overtage showet det er en tanke fra det vilde vest vi er trætte af at";
			str3 += " forstå hvad der sker i fremtiden rummet er uendeligt vi har ingen chance for at begå os rigtigt det er en tanke fra de varme lande at vi er";
			str3 += " vanskelige at forstå sådan er virkeligheden vi elsker os selv og det ukendte";
			string str4 = "det hele handler om et grundstof så tungt at det ikke kan beskrives forskellige variationer af protoner og neutroner giver isotoper af en kerne";
			str4 += " fyldt med interaktioner tyngdeloven holder sammen på partiklerne som kredser om hinanden flere forskellige variationer giver forskellige muligheder at";
			str4 += " kombinere med hvem ville tro det var nemt at skabe et grundstof som ikke findes endnu spændende sager forstå det handler om at give rumforskning en chance";
			str4 += " for at begå sig i universet på lang sigt hvem vil holde på en hemmelighed så tung så længe";
			string str5 = "Der gik en mand i skolen han hed Olebole han var fjorten år og så kører vi langsomt gik det op for ham han ikke var";
			str5 += " den eneste der gik med bukserne om livet han brugte meget tid på at inkassere en formue fra Bent lige meget hvad gik han op i taskerne på kvinderne men han var ikke køn";
			str5 += " skønt hans mor havde sagt det livet er for kort til utroskab min ven sådan drejer det sig om livet her på klostret";
			str5 += " hvad jeg ikke vidste var han bed mig i underbukserne for trettende gang nok om det han hed vist bare GummiHans";
			string str6 = "Fjorten år på skole gangen og han var lige fyldt femten så fik han oprejsning for sine stylter men troede ikke sine egne øjne han var blind";
			str6 += " af raseri på fjortende år gik han ind til lærerinden og fik en guldkant på æblet for at ikke sige lyssky affærer med hans kone som var viet med HansPeter";
			str6 += " kom meget ud af fjerde sal vi vidste ikke hvad der var galt han sagde bare avs og sådan noget pædofile svin siger jeg nok om det han var sød nok";
			str6 += " i hans lede armhule dø forbistrede svinekam du nakker dig selv imorgen og så gik han hjem tulle blev træt af livet og sagde op for syttende gang nok om det han hed bare Bjarne";
			string str7 = "Vi hedder ikke det samme siger morfar vi kommer fra anus på en giraf så kan hun lære det vi spiser ikke pinochiokugler her i livet nok om svanset tanker";
			str7 += " vi myldrer frem i mørket siger jeg dig mørkekammer er jeg ikke heldig var hendes begrundelse nok om Tove hun var spedalsk i sin hjerne for pokker hvor lyder det godt";
			str7 += " mormor vi fejrer dig en anden dag med lys og lagkage helt din egen fødselsdag nok om Britta vi heiler ikke om livet sagde SvenOtto fire pindsvin har taget min nadver og";
			str7 += " jeg hader dig for det det pacifist perker bølle når truer du mig på livet så får du svansen om halsen din bøttesvensker vi går lige op i himlen sagde JytteMor";
			string[] array;
			switch (form1.junkie.Next(7))
			{
			case 0:
				array = str.Split(' ');
				break;
			case 1:
				array = str2.Split(' ');
				break;
			case 2:
				array = str3.Split(' ');
				break;
			case 3:
				array = str4.Split(' ');
				break;
			case 4:
				array = str5.Split(' ');
				break;
			case 5:
				array = str6.Split(' ');
				break;
			case 6:
				array = str7.Split(' ');
				break;
			default:
				array = str.Split(' ');
				break;
			}
			string[] array2 = new string[lines];
			for (int i = 0; i < lines; i++)
			{
				string text = "";
				int num = 0;
				for (int j = 0; j < form1.junkie.Next(words) + 4; j++)
				{
					if (num >= 6)
					{
						text += ", ";
						num = form1.junkie.Next(3);
					}
					text = text + array[form1.junkie.Next(array.Length)] + " ";
					num++;
				}
				array2[i] = text;
			}
			return array2;
		}
	}
}
