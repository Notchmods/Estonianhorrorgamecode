using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Languagesetting : MonoBehaviour
{
    public Text[] Textset;
    public int language;
    public bool ingame;
    public bool cutscene;
    // Start is called before the first frame update
    void Start() {
            int languge = PlayerPrefs.GetInt("language");
        language = languge;
    }

    // Update is called once per frame
    void Update()
    {
        if (language == 0)
        {
            if (ingame == false)
            {
                if(cutscene == false)
                {
                    Textset[0].text = "Play";
                    Textset[1].text = "Credits";
                    Textset[2].text = "Language options";
                    Textset[3].text = "Exit";
                    Textset[4].text = "The Forest Goblin";
                    Textset[5].text = "The Forest Goblin";
                    Textset[6].text = "Director: Notchmods\nProgrammer: Notchmods\n3D model: Fearlessmuffins\nMusic: Horror Music World(YouTube)\nAssets: Unity Standard assets\nInspired by: @Iwantdie nightmare of his friends";
                    Textset[7].text = "Pick a difficulty:";
                    Textset[8].text = "2 Goblin is enough";
                    Textset[9].text = "I can handle him";
                    Textset[10].text = "Veteran";
                }
            }
            if(ingame == true)
            {
                Textset[0].text = "Joe(Client)";
                Textset[1].text = "Hey this is Joe, you're here to day to exterminate a Goblin.\n I want this place free of Goblin.";
                Textset[2].text = "Joe(Client)";
                Textset[3].text = "To exterminate the Goblin you must get retrieve the antidote and load it into a tranquilizer\n gun.  Then shoot it at the Goblin. The last known location of the antidote is at the cabin.\n Go there and you'll find the antidote";
                Textset[4].text = "Joe(Client)";
                Textset[5].text = "Becareful of the Goblin, they're smart and can detect you if you're really close to them. \n Avoid them at all cost or you'll be like our last exterminator \n good luck exterminator 1.";
                Textset[6].text = "Objective: Find the cabin";
                Textset[7].text = "Objective: He's chasing you lose the goblin";
                Textset[8].text = "Objective: Unlock the door";
                Textset[9].text = "Joe(Client)";
                Textset[10].text = "Looks like you're at the last location where our last exterminator was at. Don't kick it down \notherwise it'll alert the goblins.\n Also press F to turn on and off the lights.";
                Textset[11].text = "Joe(Client)";
                Textset[12].text = "What you need to do is to find 6 keys. The Goblin\n know that we're going to come and they might've scattered it across the park what you need to do is\n to find these keys and unlock the door with it.";
                Textset[13].text = "Objective: Find the 6 keys(Tip: They  are really bright)\nKey: ";
                Textset[14].text = "Objective: Unlock the door again and check the cabin";
                Textset[15].text = "Joe(Client)";
                Textset[16].text = "So you've busted in through the door. Did you find any trace of the previous exterminator.";
                Textset[17].text = "Joe(Client)";
                Textset[18].text = "How shocking.... His body is covered with white sticky stuff. I think they\n might've...... on him....... Well check for the antidote in the last \nexterminator body.";
                Textset[19].text = "Joe(Client)";
                Textset[20].text = "Well you've got the antidote and the pistol, now \nit's time to exterminate them. Good luck I hope that you'll survive";
                Textset[21].text = "Objective: Eliminate all the goblins in across the national park \n Goblin: ";
                Textset[22].text = "Ammo: ";
                Textset[23].text = "You've been killed by the Goblin";
                Textset[24].text = "Restart";
                Textset[25].text = "Main Menu" ;
                Textset[26].text = "Resume";
                Textset[27].text = "Restart";
                Textset[28].text = "Main Menu";
            }

            if(cutscene == true)
            {
                Textset[0].text = "Joe(Client)";
                Textset[1].text = "< Messages";
                Textset[2].text = "Contact";
                Textset[3].text = "Well good job, you've finally freed this beautiful national park from the goblins.";
                Textset[4].text = "Thank you sir.";
                Textset[5].text = "About exterminator one, we'll send a crew \n to the park to see whether he's dead or alive. He's definitely a goner, a \n state funded funeral will be held for him.";
                Textset[6].text = "About my pay.............";
                Textset[7].text = "Don't worry, 20,000 EUROS will be deposited \n in your bank account immediately, also for\n your information the prime minister of Estonia \nwants to speak with you too.";
                Textset[8].text = "Main menu";
            }
        }

        if(language==1)
        {
            if(ingame == false)
            {
                if(cutscene == false)
                {
                    Textset[0].text = "开始";
                    Textset[1].text = "信用";
                    Textset[2].text = "语言选项";
                    Textset[3].text = "出入";
                    Textset[4].text = "森林妖精";
                    Textset[5].text = "森林妖精";
                    Textset[6].text = "导演：Notchmods\n程序员：Notchmods\n3D模型：Fearlessmuffins\n音乐: Horror Music World(YouTube)\n 资产: Unity Standard assets\n灵感来源：@Iwantdie他的朋友们的噩梦";
                    Textset[7].text = "选择一个困难:";
                    Textset[8].text = "2妖精就够了";
                    Textset[9].text = "我可以应付他";
                    Textset[10].text = "老将";
                }
            }
            if (ingame == true)
            {
                Textset[0].text = "乔（客户）";
                Textset[1].text = "你好这是客户乔, 今天你来这里去杀妖精.\n 我不要看到一个妖精在这里.";
                Textset[2].text = "乔（客户）";
                Textset[3].text = "要消灭地精，您必须获取解毒剂并将其装入镇静剂 \n 枪中。然后在哥布林射击。解毒剂的最后一个已知位置是在机舱中。\n 转到那里，您会找到解毒剂";
                Textset[4].text = "乔（客户)";
                Textset[5].text = "小心, 那个妖精是很聪明的和如果你很靠近他们会杀死你。 \n如果你没避免妖精你会想我的以前的灭虫剂。 \n 祝你好运除虫剂1.";
                Textset[6].text = "目标:找那个房子。";
                Textset[7].text = "目标： 避免那个妖精他在追逐你。";
                Textset[8].text = "目标： 开房子的门";
                Textset[9].text = "乔（客户)";
                Textset[10].text = "你现在最后除虫剂1的地方。 别踢那个门 \n它会提醒妖精。\n 同时按F打开和关闭灯。";
                Textset[11].text = "乔（客户)";
                Textset[12].text = "如果你要开房子的们你要找六个钥匙. 妖精\n 知道我们要来和它们乱放要是在全个公园。\n 你要找钥匙和那个房子的开门";
                Textset[13].text = "目标：找六个钥匙。(钥匙是很光的)\n钥匙: ";
                Textset[14].text = "目标：去房子里开门和检查那个地方";
                Textset[15].text = "乔（客户)";
                Textset[16].text = "你说有开门了，你是否找到了前驱虫剂的痕迹。";
                Textset[17].text = "乔（客户)";
                Textset[18].text = "多么令人震惊……他的身体被白色粘稠的东西覆盖。我觉得他们\n 有...... 在他的身上....... 好在最后一个灭虫剂体内检查解毒剂。";
                Textset[19].text = "乔（客户)";
                Textset[20].text = "好啊你有那个解毒剂和抢了, 现在 \n你要用你的抢和解毒剂去杀他。希望你可以。祝你好运，我希望你能活下来";
                Textset[21].text = "目标：消灭整个国家公园中的所有妖精 \n 妖精: ";
                Textset[22].text = "弹药:";
                Textset[23].text = "你被妖精杀了。";
                Textset[24].text = "重新开始";
                Textset[25].text = "大厅";
                Textset[26].text = "继续玩";
                Textset[27].text = "重新开始";
                Textset[28].text = "大厅";
            }

            if (cutscene == true)
            {
                Textset[0].text = "乔（客户)";
                Textset[1].text = "< 信息";
                Textset[2].text = "联系";
                Textset[3].text = "干得好，您终于把这个美丽的国家公园从妖精中解救了出来.";
                Textset[4].text = "谢谢您。";
                Textset[5].text = "关于除虫剂一，我们将派一个工作人员 \n 去公园看看他是死还是活。他绝对是一个行者，一个\n 国家资助的葬礼将为他举行。";
                Textset[6].text = "关于我的工资.............";
                Textset[7].text = "不用担心，将存入20,000欧元\n 立即在您的银行帐户中\n 供您参考爱沙尼亚总理 \n也想和你说话.";
                Textset[8].text = "大厅";
            }
        }
            
        if (language==2)
        {
            if (ingame == false)
            {
                if(cutscene == false)
                {
                    Textset[0].text = "Alusta";
                    Textset[1].text = "Autorid";
                    Textset[2].text = "Keelevalikud";
                    Textset[3].text = "Välju";
                    Textset[4].text = "Metsahaldjas";
                    Textset[5].text = "Metsahaldjas";
                    Textset[6].text = "Režissöör: Notchmods \n Programmeerija: Notchmods \n 3D-mudel: kartmatud muffinid \n Muusika: õudusmuusika maailm (YouTube)\n Varad: ühtsuse standardvarad \n Inspiratsiooniallikas: @Iwantdieud temausõprade õ";
                    Textset[7].text = "Valige raske:";
                    Textset[8].text = "Piisab 2 haldjast    ";
                    Textset[9].text = "Ma saan temaga hakkama";
                    Textset[10].text = "veteran";
                }
            }
            if (ingame == true)
            {
                Textset[0].text = "Joe (klient)";
                Textset[1].text = "Hei, see on Joe, sa oled täna siin, et Goblin hävitada.\n Ma tahan, et see koht oleks vaba Goblinist.";
                Textset[2].text = "Joe (klient)";
                Textset[3].text = "Goblini hävitamiseks peate hankima vastumürgi ja laadima selle rahustisse\n relv. Siis tulista see Goblinile. Antidoodi viimane teadaolev asukoht on salongis.\n Minge sinna ja leiate vastumürgi";
                Textset[4].text = "Joe (klient)";
                Textset[5].text = "Goblini suhtes on nad nutikad ja suudavad teid tuvastada, kui olete neile tõesti lähedal. \n Vältige neid iga hinna eest, muidu olete nagu meie viimane hävitaja \n õnne hävitaja 1.";
                Textset[6].text = "Eesmärk: salongi leidmine";
                Textset[7].text = "Eesmärk: Ta jälitab teid, et kaotate kääbuse!!!";
                Textset[8].text = "Eesmärk: avage uks";
                Textset[9].text = "Joe(klient)";
                Textset[10].text = "Paistab, et olete viimases kohas, kus meie viimane hävitaja oli. \n Ära lase seda maha muidu hoiatab taid.\n Tulede sisse- ja väljalülitamiseks vajutage ka klahvi F.";
                Textset[11].text = "Joe(klient)";
                Textset[12].text = "Peate leidma 6 võtit. Goblin\n tea, et me tuleme ja nad võivad selle laiali pargis laiali ajada, mida sa tegema pead\n nende võtmete leidmiseks ja sellega ukse avamiseks.";
                Textset[13].text = "Eesmärk: leidke 6 võtit(näpunäide: need on tõesti eredad)\nKlahv: ";
                Textset[14].text = "Eesmärk: avage uks uuesti ja kontrollige salongi";
                Textset[15].text = "Joe(klient)";
                Textset[16].text = "Nii et olete ukse vahelt sisse kukkunud. Kas leidsite jälgi eelmisest hävitajast.";
                Textset[17].text = "Joe(klient)";
                Textset[18].text = "Kui šokeeriv .... Tema keha on kaetud valge kleepuva kraamiga. Ma arvan, et nemad\n oleks võinud ...... teda ....... Noh, kontrollige vastumürki viimases \nhävitaja keha.";
                Textset[19].text = "Joe(klient)";
                Textset[20].text = "Nüüd on teil vastumürk ja püstol olemas \non aeg need hävitada. Edu ma loodan, et te ellu jääte";
                Textset[21].text = "Eesmärk: Kõrvaldage kogu rahvuspargis olevad goblinid \n Goblin: ";
                Textset[22].text = "Laskemoon: ";
                Textset[23].text = "Goblin on sind tapnud";
                Textset[24].text = "Taaskäivita";
                Textset[25].text = "Peamenüü";
                Textset[26].text = "Jätka";
                Textset[27].text = "Taaskäivita";
                Textset[28].text = "Peamenüü";
            }
            if (cutscene == true)
            {
                Textset[0].text = "Joe(klient)";
                Textset[1].text = "< Sõnum";
                Textset[2].text = "Võta ühendust";
                Textset[3].text = "Hästi hea töö, olete lõpuks vabastanud selle ilusa rahvuspargi kobaratest.";
                Textset[4].text = "Tänan härra.";
                Textset[5].text = "Umbes hävitaja kohta saadame meeskonna \n parki, et näha, kas ta on surnud või elus. Ta on kindlasti goner, a\n tema jaoks korraldatakse riigi rahastatud matused.";
                Textset[6].text = "Minu palga kohta .............";
                Textset[7].text = "Ärge muretsege, deponeeritakse 20 000 eurot \n kohe oma pangakontol, ka\n teie teave Eesti peaminister\ntahab ka sinuga rääkida.";
                Textset[8].text = "Peamenüü";
            }
        }

        if (language==3)
        {
            if (ingame == false)
            {
                if(cutscene == false){
                    Textset[0].text = "Reproducir";
                    Textset[1].text = "Créditos";
                    Textset[2].text = "Opciones de lenguaje";
                    Textset[3].text = "Ruidoso";
                    Textset[4].text = "Hada del bosque";
                    Textset[5].text = "Hada del bosque";
                    Textset[6].text = "Director: Notchmods \n Programador: Notchmods \n Modelo 3D: Fearlessmuffins \n Música: Horror Music World (YouTube) \n Activos: Activos de Unity Standard \n Inspirado por: @Iwantdie pesadilla de sus amigos";
                    Textset[7].text = "Elige tu dificultad";
                    Textset[8].text = "2 Goblin es suficiente";
                    Textset[9].text = "Puedo manejarlo";
                    Textset[10].text = "Veterano";
                }
            }
            if (ingame == true)
            {
                Textset[0].text = "Joe (cliente)";
                Textset[1].text = "Hola este es Joe, estás aquí hoy para exterminar a un Goblin.\n Quiero este lugar libre de Goblin.";
                Textset[2].text = "Joe (cliente)";
                Textset[3].text = "Para exterminar al Goblin debes recuperar el antídoto y cargarlo en un tranquilizante.\n pistola.  Entonces dispárale al Goblin. La última ubicación conocida del antídoto es la cabina.\n Ve allí y encontrarás el antídoto";
                Textset[4].text = "Joe (cliente)";
                Textset[5].text = "Ten cuidado con los Goblin, son inteligentes y pueden detectarte si estás realmente cerca de ellos. \n Evítalos a toda costa o serás como nuestro último exterminador. \n buena suerte exterminador 1.";
                Textset[6].text = "Objetivo: encontrar la cabaña";
                Textset[7].text = "Objetivo: te persigue, pierdes al duende";

            }
        }
    }


    public void activateenglish()
    {
        language = 0;
        PlayerPrefs.SetInt("language", 0);
        PlayerPrefs.Save();
    }

    public void activateChinese()
    {
        language = 1;
        PlayerPrefs.SetInt("language", 1);
        PlayerPrefs.Save();
    }

    public void activateEesti()
    {
        language = 2;
        PlayerPrefs.SetInt("language", 2);
        PlayerPrefs.Save();
    }
    public void activateSpanish()
    {
        language = 3;
            PlayerPrefs.SetInt("language", 3);
            PlayerPrefs.Save();
    }
}   
