// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace System.Enums.FontAwesome
{
    /// <summary>
    ///     Represents all icon characters in the free Font-Awesome icons library.
    ///     The members of this enumeration are marked with DisplayAttribute to help
    ///     show extra information about them in user forms more easily.
    /// </summary>
    /// 
    public enum FontAwesomeIcons
    {
        [Display(Name = "Accessible Icon", Description = "fa-accessible-icon")]
        AccessibleIcon = '\uf368',
        
        [Display(Name = "Accusoft", Description = "fa-accusoft")]
        Accusoft = '\uf369',
        
        [Display(Name = "Acquisitions Incorporated", Description = "fa-acquisitions-incorporated")]
        AcquisitionsIncorporated = '\uf6af',
        
        [Display(Name = "Ad", Description = "fa-ad")]
        Ad = '\uf641',
        
        [Display(Name = "Address Book", Description = "fa-address-book")]
        AddressBook = '\uf2b9',
        
        [Display(Name = "Address Card", Description = "fa-address-card")]
        AddressCard = '\uf2bb',
        
        [Display(Name = "Adjust", Description = "fa-adjust")]
        Adjust = '\uf042',
        
        [Display(Name = "Adn", Description = "fa-adn")]
        Adn = '\uf170',
        
        [Display(Name = "Adobe", Description = "fa-adobe")]
        Adobe = '\uf778',
        
        [Display(Name = "Adversal", Description = "fa-adversal")]
        Adversal = '\uf36a',
        
        [Display(Name = "Affiliatetheme", Description = "fa-affiliatetheme")]
        Affiliatetheme = '\uf36b',
        
        [Display(Name = "Air Freshener", Description = "fa-air-freshener")]
        AirFreshener = '\uf5d0',
        
        [Display(Name = "Airbnb", Description = "fa-airbnb")]
        Airbnb = '\uf834',
        
        [Display(Name = "Algolia", Description = "fa-algolia")]
        Algolia = '\uf36c',
        
        [Display(Name = "Align Center", Description = "fa-align-center")]
        AlignCenter = '\uf037',
        
        [Display(Name = "Align Justify", Description = "fa-align-justify")]
        AlignJustify = '\uf039',
        
        [Display(Name = "Align Left", Description = "fa-align-left")]
        AlignLeft = '\uf036',
        
        [Display(Name = "Align Right", Description = "fa-align-right")]
        AlignRight = '\uf038',
        
        [Display(Name = "Alipay", Description = "fa-alipay")]
        Alipay = '\uf642',
        
        [Display(Name = "Allergies", Description = "fa-allergies")]
        Allergies = '\uf461',
        
        [Display(Name = "Amazon", Description = "fa-amazon")]
        Amazon = '\uf270',
        
        [Display(Name = "Amazon Pay", Description = "fa-amazon-pay")]
        AmazonPay = '\uf42c',
        
        [Display(Name = "Ambulance", Description = "fa-ambulance")]
        Ambulance = '\uf0f9',
        
        [Display(Name = "American Sign Language Interpreting", Description = "fa-american-sign-language-interpreting")]
        AmericanSignLanguageInterpreting = '\uf2a3',
        
        [Display(Name = "Amilia", Description = "fa-amilia")]
        Amilia = '\uf36d',
        
        [Display(Name = "Anchor", Description = "fa-anchor")]
        Anchor = '\uf13d',
        
        [Display(Name = "Android", Description = "fa-android")]
        Android = '\uf17b',
        
        [Display(Name = "Angellist", Description = "fa-angellist")]
        Angellist = '\uf209',
        
        [Display(Name = "Angle Double Down", Description = "fa-angle-double-down")]
        AngleDoubleDown = '\uf103',
        
        [Display(Name = "Angle Double Left", Description = "fa-angle-double-left")]
        AngleDoubleLeft = '\uf100',
        
        [Display(Name = "Angle Double Right", Description = "fa-angle-double-right")]
        AngleDoubleRight = '\uf101',
        
        [Display(Name = "Angle Double Up", Description = "fa-angle-double-up")]
        AngleDoubleUp = '\uf102',
        
        [Display(Name = "Angle Down", Description = "fa-angle-down")]
        AngleDown = '\uf107',
        
        [Display(Name = "Angle Left", Description = "fa-angle-left")]
        AngleLeft = '\uf104',
        
        [Display(Name = "Angle Right", Description = "fa-angle-right")]
        AngleRight = '\uf105',
        
        [Display(Name = "Angle Up", Description = "fa-angle-up")]
        AngleUp = '\uf106',
        
        [Display(Name = "Angry", Description = "fa-angry")]
        Angry = '\uf556',
        
        [Display(Name = "Angrycreative", Description = "fa-angrycreative")]
        Angrycreative = '\uf36e',
        
        [Display(Name = "Angular", Description = "fa-angular")]
        Angular = '\uf420',
        
        [Display(Name = "Ankh", Description = "fa-ankh")]
        Ankh = '\uf644',
        
        [Display(Name = "App Store", Description = "fa-app-store")]
        AppStore = '\uf36f',
        
        [Display(Name = "App Store Ios", Description = "fa-app-store-ios")]
        AppStoreIos = '\uf370',
        
        [Display(Name = "Apper", Description = "fa-apper")]
        Apper = '\uf371',
        
        [Display(Name = "Apple", Description = "fa-apple")]
        Apple = '\uf179',
        
        [Display(Name = "Apple Alt", Description = "fa-apple-alt")]
        AppleAlt = '\uf5d1',
        
        [Display(Name = "Apple Pay", Description = "fa-apple-pay")]
        ApplePay = '\uf415',
        
        [Display(Name = "Archive", Description = "fa-archive")]
        Archive = '\uf187',
        
        [Display(Name = "Archway", Description = "fa-archway")]
        Archway = '\uf557',
        
        [Display(Name = "Arrow Alt Circle Down", Description = "fa-arrow-alt-circle-down")]
        ArrowAltCircleDown = '\uf358',
        
        [Display(Name = "Arrow Alt Circle Left", Description = "fa-arrow-alt-circle-left")]
        ArrowAltCircleLeft = '\uf359',
        
        [Display(Name = "Arrow Alt Circle Right", Description = "fa-arrow-alt-circle-right")]
        ArrowAltCircleRight = '\uf35a',
        
        [Display(Name = "Arrow Alt Circle Up", Description = "fa-arrow-alt-circle-up")]
        ArrowAltCircleUp = '\uf35b',
        
        [Display(Name = "Arrow Circle Down", Description = "fa-arrow-circle-down")]
        ArrowCircleDown = '\uf0ab',
        
        [Display(Name = "Arrow Circle Left", Description = "fa-arrow-circle-left")]
        ArrowCircleLeft = '\uf0a8',
        
        [Display(Name = "Arrow Circle Right", Description = "fa-arrow-circle-right")]
        ArrowCircleRight = '\uf0a9',
        
        [Display(Name = "Arrow Circle Up", Description = "fa-arrow-circle-up")]
        ArrowCircleUp = '\uf0aa',
        
        [Display(Name = "Arrow Down", Description = "fa-arrow-down")]
        ArrowDown = '\uf063',
        
        [Display(Name = "Arrow Left", Description = "fa-arrow-left")]
        ArrowLeft = '\uf060',
        
        [Display(Name = "Arrow Right", Description = "fa-arrow-right")]
        ArrowRight = '\uf061',
        
        [Display(Name = "Arrow Up", Description = "fa-arrow-up")]
        ArrowUp = '\uf062',
        
        [Display(Name = "Arrows Alt", Description = "fa-arrows-alt")]
        ArrowsAlt = '\uf0b2',
        
        [Display(Name = "Arrows Alt H", Description = "fa-arrows-alt-h")]
        ArrowsAltH = '\uf337',
        
        [Display(Name = "Arrows Alt V", Description = "fa-arrows-alt-v")]
        ArrowsAltV = '\uf338',
        
        [Display(Name = "Artstation", Description = "fa-artstation")]
        Artstation = '\uf77a',
        
        [Display(Name = "Assistive Listening Systems", Description = "fa-assistive-listening-systems")]
        AssistiveListeningSystems = '\uf2a2',
        
        [Display(Name = "Asterisk", Description = "fa-asterisk")]
        Asterisk = '\uf069',
        
        [Display(Name = "Asymmetrik", Description = "fa-asymmetrik")]
        Asymmetrik = '\uf372',
        
        [Display(Name = "At", Description = "fa-at")]
        At = '\uf1fa',
        
        [Display(Name = "Atlas", Description = "fa-atlas")]
        Atlas = '\uf558',
        
        [Display(Name = "Atlassian", Description = "fa-atlassian")]
        Atlassian = '\uf77b',
        
        [Display(Name = "Atom", Description = "fa-atom")]
        Atom = '\uf5d2',
        
        [Display(Name = "Audible", Description = "fa-audible")]
        Audible = '\uf373',
        
        [Display(Name = "Audio Description", Description = "fa-audio-description")]
        AudioDescription = '\uf29e',
        
        [Display(Name = "Autoprefixer", Description = "fa-autoprefixer")]
        Autoprefixer = '\uf41c',
        
        [Display(Name = "Avianex", Description = "fa-avianex")]
        Avianex = '\uf374',
        
        [Display(Name = "Aviato", Description = "fa-aviato")]
        Aviato = '\uf421',
        
        [Display(Name = "Award", Description = "fa-award")]
        Award = '\uf559',
        
        [Display(Name = "Aws", Description = "fa-aws")]
        Aws = '\uf375',
        
        [Display(Name = "Baby", Description = "fa-baby")]
        Baby = '\uf77c',
        
        [Display(Name = "Baby Carriage", Description = "fa-baby-carriage")]
        BabyCarriage = '\uf77d',
        
        [Display(Name = "Backspace", Description = "fa-backspace")]
        Backspace = '\uf55a',
        
        [Display(Name = "Backward", Description = "fa-backward")]
        Backward = '\uf04a',
        
        [Display(Name = "Bacon", Description = "fa-bacon")]
        Bacon = '\uf7e5',
        
        [Display(Name = "Bahai", Description = "fa-bahai")]
        Bahai = '\uf666',
        
        [Display(Name = "Balance Scale", Description = "fa-balance-scale")]
        BalanceScale = '\uf24e',
        
        [Display(Name = "Balance Scale Left", Description = "fa-balance-scale-left")]
        BalanceScaleLeft = '\uf515',
        
        [Display(Name = "Balance Scale Right", Description = "fa-balance-scale-right")]
        BalanceScaleRight = '\uf516',
        
        [Display(Name = "Ban", Description = "fa-ban")]
        Ban = '\uf05e',
        
        [Display(Name = "Band Aid", Description = "fa-band-aid")]
        BandAid = '\uf462',
        
        [Display(Name = "Bandcamp", Description = "fa-bandcamp")]
        Bandcamp = '\uf2d5',
        
        [Display(Name = "Barcode", Description = "fa-barcode")]
        Barcode = '\uf02a',
        
        [Display(Name = "Bars", Description = "fa-bars")]
        Bars = '\uf0c9',
        
        [Display(Name = "Baseball Ball", Description = "fa-baseball-ball")]
        BaseballBall = '\uf433',
        
        [Display(Name = "Basketball Ball", Description = "fa-basketball-ball")]
        BasketballBall = '\uf434',
        
        [Display(Name = "Bath", Description = "fa-bath")]
        Bath = '\uf2cd',
        
        [Display(Name = "Battery Empty", Description = "fa-battery-empty")]
        BatteryEmpty = '\uf244',
        
        [Display(Name = "Battery Full", Description = "fa-battery-full")]
        BatteryFull = '\uf240',
        
        [Display(Name = "Battery Half", Description = "fa-battery-half")]
        BatteryHalf = '\uf242',
        
        [Display(Name = "Battery Quarter", Description = "fa-battery-quarter")]
        BatteryQuarter = '\uf243',
        
        [Display(Name = "Battery Three Quarters", Description = "fa-battery-three-quarters")]
        BatteryThreeQuarters = '\uf241',
        
        [Display(Name = "Battle Net", Description = "fa-battle-net")]
        BattleNet = '\uf835',
        
        [Display(Name = "Bed", Description = "fa-bed")]
        Bed = '\uf236',
        
        [Display(Name = "Beer", Description = "fa-beer")]
        Beer = '\uf0fc',
        
        [Display(Name = "Behance", Description = "fa-behance")]
        Behance = '\uf1b4',
        
        [Display(Name = "Behance Square", Description = "fa-behance-square")]
        BehanceSquare = '\uf1b5',
        
        [Display(Name = "Bell", Description = "fa-bell")]
        Bell = '\uf0f3',
        
        [Display(Name = "Bell Slash", Description = "fa-bell-slash")]
        BellSlash = '\uf1f6',
        
        [Display(Name = "Bezier Curve", Description = "fa-bezier-curve")]
        BezierCurve = '\uf55b',
        
        [Display(Name = "Bible", Description = "fa-bible")]
        Bible = '\uf647',
        
        [Display(Name = "Bicycle", Description = "fa-bicycle")]
        Bicycle = '\uf206',
        
        [Display(Name = "Biking", Description = "fa-biking")]
        Biking = '\uf84a',
        
        [Display(Name = "Bimobject", Description = "fa-bimobject")]
        Bimobject = '\uf378',
        
        [Display(Name = "Binoculars", Description = "fa-binoculars")]
        Binoculars = '\uf1e5',
        
        [Display(Name = "Biohazard", Description = "fa-biohazard")]
        Biohazard = '\uf780',
        
        [Display(Name = "Birthday Cake", Description = "fa-birthday-cake")]
        BirthdayCake = '\uf1fd',
        
        [Display(Name = "Bitbucket", Description = "fa-bitbucket")]
        Bitbucket = '\uf171',
        
        [Display(Name = "Bitcoin", Description = "fa-bitcoin")]
        Bitcoin = '\uf379',
        
        [Display(Name = "Bity", Description = "fa-bity")]
        Bity = '\uf37a',
        
        [Display(Name = "Black Tie", Description = "fa-black-tie")]
        BlackTie = '\uf27e',
        
        [Display(Name = "Blackberry", Description = "fa-blackberry")]
        Blackberry = '\uf37b',
        
        [Display(Name = "Blender", Description = "fa-blender")]
        Blender = '\uf517',
        
        [Display(Name = "Blender Phone", Description = "fa-blender-phone")]
        BlenderPhone = '\uf6b6',
        
        [Display(Name = "Blind", Description = "fa-blind")]
        Blind = '\uf29d',
        
        [Display(Name = "Blog", Description = "fa-blog")]
        Blog = '\uf781',
        
        [Display(Name = "Blogger", Description = "fa-blogger")]
        Blogger = '\uf37c',
        
        [Display(Name = "Blogger B", Description = "fa-blogger-b")]
        BloggerB = '\uf37d',
        
        [Display(Name = "Bluetooth", Description = "fa-bluetooth")]
        Bluetooth = '\uf293',
        
        [Display(Name = "Bluetooth B", Description = "fa-bluetooth-b")]
        BluetoothB = '\uf294',
        
        [Display(Name = "Bold", Description = "fa-bold")]
        Bold = '\uf032',
        
        [Display(Name = "Bolt", Description = "fa-bolt")]
        Bolt = '\uf0e7',
        
        [Display(Name = "Bomb", Description = "fa-bomb")]
        Bomb = '\uf1e2',
        
        [Display(Name = "Bone", Description = "fa-bone")]
        Bone = '\uf5d7',
        
        [Display(Name = "Bong", Description = "fa-bong")]
        Bong = '\uf55c',
        
        [Display(Name = "Book", Description = "fa-book")]
        Book = '\uf02d',
        
        [Display(Name = "Book Dead", Description = "fa-book-dead")]
        BookDead = '\uf6b7',
        
        [Display(Name = "Book Medical", Description = "fa-book-medical")]
        BookMedical = '\uf7e6',
        
        [Display(Name = "Book Open", Description = "fa-book-open")]
        BookOpen = '\uf518',
        
        [Display(Name = "Book Reader", Description = "fa-book-reader")]
        BookReader = '\uf5da',
        
        [Display(Name = "Bookmark", Description = "fa-bookmark")]
        Bookmark = '\uf02e',
        
        [Display(Name = "Bootstrap", Description = "fa-bootstrap")]
        Bootstrap = '\uf836',
        
        [Display(Name = "Border All", Description = "fa-border-all")]
        BorderAll = '\uf84c',
        
        [Display(Name = "Border None", Description = "fa-border-none")]
        BorderNone = '\uf850',
        
        [Display(Name = "Border Style", Description = "fa-border-style")]
        BorderStyle = '\uf853',
        
        [Display(Name = "Bowling Ball", Description = "fa-bowling-ball")]
        BowlingBall = '\uf436',
        
        [Display(Name = "Box", Description = "fa-box")]
        Box = '\uf466',
        
        [Display(Name = "Box Open", Description = "fa-box-open")]
        BoxOpen = '\uf49e',
        
        [Display(Name = "Box Tissue", Description = "fa-box-tissue")]
        BoxTissue = '\uf95b',
        
        [Display(Name = "Boxes", Description = "fa-boxes")]
        Boxes = '\uf468',
        
        [Display(Name = "Braille", Description = "fa-braille")]
        Braille = '\uf2a1',
        
        [Display(Name = "Brain", Description = "fa-brain")]
        Brain = '\uf5dc',
        
        [Display(Name = "Bread Slice", Description = "fa-bread-slice")]
        BreadSlice = '\uf7ec',
        
        [Display(Name = "Briefcase", Description = "fa-briefcase")]
        Briefcase = '\uf0b1',
        
        [Display(Name = "Briefcase Medical", Description = "fa-briefcase-medical")]
        BriefcaseMedical = '\uf469',
        
        [Display(Name = "Broadcast Tower", Description = "fa-broadcast-tower")]
        BroadcastTower = '\uf519',
        
        [Display(Name = "Broom", Description = "fa-broom")]
        Broom = '\uf51a',
        
        [Display(Name = "Brush", Description = "fa-brush")]
        Brush = '\uf55d',
        
        [Display(Name = "Btc", Description = "fa-btc")]
        Btc = '\uf15a',
        
        [Display(Name = "Buffer", Description = "fa-buffer")]
        Buffer = '\uf837',
        
        [Display(Name = "Bug", Description = "fa-bug")]
        Bug = '\uf188',
        
        [Display(Name = "Building", Description = "fa-building")]
        Building = '\uf1ad',
        
        [Display(Name = "Bullhorn", Description = "fa-bullhorn")]
        Bullhorn = '\uf0a1',
        
        [Display(Name = "Bullseye", Description = "fa-bullseye")]
        Bullseye = '\uf140',
        
        [Display(Name = "Burn", Description = "fa-burn")]
        Burn = '\uf46a',
        
        [Display(Name = "Buromobelexperte", Description = "fa-buromobelexperte")]
        Buromobelexperte = '\uf37f',
        
        [Display(Name = "Bus", Description = "fa-bus")]
        Bus = '\uf207',
        
        [Display(Name = "Bus Alt", Description = "fa-bus-alt")]
        BusAlt = '\uf55e',
        
        [Display(Name = "Business Time", Description = "fa-business-time")]
        BusinessTime = '\uf64a',
        
        [Display(Name = "Buy N Large", Description = "fa-buy-n-large")]
        BuyNLarge = '\uf8a6',
        
        [Display(Name = "Buysellads", Description = "fa-buysellads")]
        Buysellads = '\uf20d',
        
        [Display(Name = "Calculator", Description = "fa-calculator")]
        Calculator = '\uf1ec',
        
        [Display(Name = "Calendar", Description = "fa-calendar")]
        Calendar = '\uf133',
        
        [Display(Name = "Calendar Alt", Description = "fa-calendar-alt")]
        CalendarAlt = '\uf073',
        
        [Display(Name = "Calendar Check", Description = "fa-calendar-check")]
        CalendarCheck = '\uf274',
        
        [Display(Name = "Calendar Day", Description = "fa-calendar-day")]
        CalendarDay = '\uf783',
        
        [Display(Name = "Calendar Minus", Description = "fa-calendar-minus")]
        CalendarMinus = '\uf272',
        
        [Display(Name = "Calendar Plus", Description = "fa-calendar-plus")]
        CalendarPlus = '\uf271',
        
        [Display(Name = "Calendar Times", Description = "fa-calendar-times")]
        CalendarTimes = '\uf273',
        
        [Display(Name = "Calendar Week", Description = "fa-calendar-week")]
        CalendarWeek = '\uf784',
        
        [Display(Name = "Camera", Description = "fa-camera")]
        Camera = '\uf030',
        
        [Display(Name = "Camera Retro", Description = "fa-camera-retro")]
        CameraRetro = '\uf083',
        
        [Display(Name = "Campground", Description = "fa-campground")]
        Campground = '\uf6bb',
        
        [Display(Name = "Canadian Maple Leaf", Description = "fa-canadian-maple-leaf")]
        CanadianMapleLeaf = '\uf785',
        
        [Display(Name = "Candy Cane", Description = "fa-candy-cane")]
        CandyCane = '\uf786',
        
        [Display(Name = "Cannabis", Description = "fa-cannabis")]
        Cannabis = '\uf55f',
        
        [Display(Name = "Capsules", Description = "fa-capsules")]
        Capsules = '\uf46b',
        
        [Display(Name = "Car", Description = "fa-car")]
        Car = '\uf1b9',
        
        [Display(Name = "Car Alt", Description = "fa-car-alt")]
        CarAlt = '\uf5de',
        
        [Display(Name = "Car Battery", Description = "fa-car-battery")]
        CarBattery = '\uf5df',
        
        [Display(Name = "Car Crash", Description = "fa-car-crash")]
        CarCrash = '\uf5e1',
        
        [Display(Name = "Car Side", Description = "fa-car-side")]
        CarSide = '\uf5e4',
        
        [Display(Name = "Caravan", Description = "fa-caravan")]
        Caravan = '\uf8ff',
        
        [Display(Name = "Caret Down", Description = "fa-caret-down")]
        CaretDown = '\uf0d7',
        
        [Display(Name = "Caret Left", Description = "fa-caret-left")]
        CaretLeft = '\uf0d9',
        
        [Display(Name = "Caret Right", Description = "fa-caret-right")]
        CaretRight = '\uf0da',
        
        [Display(Name = "Caret Square Down", Description = "fa-caret-square-down")]
        CaretSquareDown = '\uf150',
        
        [Display(Name = "Caret Square Left", Description = "fa-caret-square-left")]
        CaretSquareLeft = '\uf191',
        
        [Display(Name = "Caret Square Right", Description = "fa-caret-square-right")]
        CaretSquareRight = '\uf152',
        
        [Display(Name = "Caret Square Up", Description = "fa-caret-square-up")]
        CaretSquareUp = '\uf151',
        
        [Display(Name = "Caret Up", Description = "fa-caret-up")]
        CaretUp = '\uf0d8',
        
        [Display(Name = "Carrot", Description = "fa-carrot")]
        Carrot = '\uf787',
        
        [Display(Name = "Cart Arrow Down", Description = "fa-cart-arrow-down")]
        CartArrowDown = '\uf218',
        
        [Display(Name = "Cart Plus", Description = "fa-cart-plus")]
        CartPlus = '\uf217',
        
        [Display(Name = "Cash Register", Description = "fa-cash-register")]
        CashRegister = '\uf788',
        
        [Display(Name = "Cat", Description = "fa-cat")]
        Cat = '\uf6be',
        
        [Display(Name = "Cc Amazon Pay", Description = "fa-cc-amazon-pay")]
        CcAmazonPay = '\uf42d',
        
        [Display(Name = "Cc Amex", Description = "fa-cc-amex")]
        CcAmex = '\uf1f3',
        
        [Display(Name = "Cc Apple Pay", Description = "fa-cc-apple-pay")]
        CcApplePay = '\uf416',
        
        [Display(Name = "Cc Diners Club", Description = "fa-cc-diners-club")]
        CcDinersClub = '\uf24c',
        
        [Display(Name = "Cc Discover", Description = "fa-cc-discover")]
        CcDiscover = '\uf1f2',
        
        [Display(Name = "Cc Jcb", Description = "fa-cc-jcb")]
        CcJcb = '\uf24b',
        
        [Display(Name = "Cc Mastercard", Description = "fa-cc-mastercard")]
        CcMastercard = '\uf1f1',
        
        [Display(Name = "Cc Paypal", Description = "fa-cc-paypal")]
        CcPaypal = '\uf1f4',
        
        [Display(Name = "Cc Stripe", Description = "fa-cc-stripe")]
        CcStripe = '\uf1f5',
        
        [Display(Name = "Cc Visa", Description = "fa-cc-visa")]
        CcVisa = '\uf1f0',
        
        [Display(Name = "Centercode", Description = "fa-centercode")]
        Centercode = '\uf380',
        
        [Display(Name = "Centos", Description = "fa-centos")]
        Centos = '\uf789',
        
        [Display(Name = "Certificate", Description = "fa-certificate")]
        Certificate = '\uf0a3',
        
        [Display(Name = "Chair", Description = "fa-chair")]
        Chair = '\uf6c0',
        
        [Display(Name = "Chalkboard", Description = "fa-chalkboard")]
        Chalkboard = '\uf51b',
        
        [Display(Name = "Chalkboard Teacher", Description = "fa-chalkboard-teacher")]
        ChalkboardTeacher = '\uf51c',
        
        [Display(Name = "Charging Station", Description = "fa-charging-station")]
        ChargingStation = '\uf5e7',
        
        [Display(Name = "Chart Area", Description = "fa-chart-area")]
        ChartArea = '\uf1fe',
        
        [Display(Name = "Chart Bar", Description = "fa-chart-bar")]
        ChartBar = '\uf080',
        
        [Display(Name = "Chart Line", Description = "fa-chart-line")]
        ChartLine = '\uf201',
        
        [Display(Name = "Chart Pie", Description = "fa-chart-pie")]
        ChartPie = '\uf200',
        
        [Display(Name = "Check", Description = "fa-check")]
        Check = '\uf00c',
        
        [Display(Name = "Check Circle", Description = "fa-check-circle")]
        CheckCircle = '\uf058',
        
        [Display(Name = "Check Double", Description = "fa-check-double")]
        CheckDouble = '\uf560',
        
        [Display(Name = "Check Square", Description = "fa-check-square")]
        CheckSquare = '\uf14a',
        
        [Display(Name = "Cheese", Description = "fa-cheese")]
        Cheese = '\uf7ef',
        
        [Display(Name = "Chess", Description = "fa-chess")]
        Chess = '\uf439',
        
        [Display(Name = "Chess Bishop", Description = "fa-chess-bishop")]
        ChessBishop = '\uf43a',
        
        [Display(Name = "Chess Board", Description = "fa-chess-board")]
        ChessBoard = '\uf43c',
        
        [Display(Name = "Chess King", Description = "fa-chess-king")]
        ChessKing = '\uf43f',
        
        [Display(Name = "Chess Knight", Description = "fa-chess-knight")]
        ChessKnight = '\uf441',
        
        [Display(Name = "Chess Pawn", Description = "fa-chess-pawn")]
        ChessPawn = '\uf443',
        
        [Display(Name = "Chess Queen", Description = "fa-chess-queen")]
        ChessQueen = '\uf445',
        
        [Display(Name = "Chess Rook", Description = "fa-chess-rook")]
        ChessRook = '\uf447',
        
        [Display(Name = "Chevron Circle Down", Description = "fa-chevron-circle-down")]
        ChevronCircleDown = '\uf13a',
        
        [Display(Name = "Chevron Circle Left", Description = "fa-chevron-circle-left")]
        ChevronCircleLeft = '\uf137',
        
        [Display(Name = "Chevron Circle Right", Description = "fa-chevron-circle-right")]
        ChevronCircleRight = '\uf138',
        
        [Display(Name = "Chevron Circle Up", Description = "fa-chevron-circle-up")]
        ChevronCircleUp = '\uf139',
        
        [Display(Name = "Chevron Down", Description = "fa-chevron-down")]
        ChevronDown = '\uf078',
        
        [Display(Name = "Chevron Left", Description = "fa-chevron-left")]
        ChevronLeft = '\uf053',
        
        [Display(Name = "Chevron Right", Description = "fa-chevron-right")]
        ChevronRight = '\uf054',
        
        [Display(Name = "Chevron Up", Description = "fa-chevron-up")]
        ChevronUp = '\uf077',
        
        [Display(Name = "Child", Description = "fa-child")]
        Child = '\uf1ae',
        
        [Display(Name = "Chrome", Description = "fa-chrome")]
        Chrome = '\uf268',
        
        [Display(Name = "Chromecast", Description = "fa-chromecast")]
        Chromecast = '\uf838',
        
        [Display(Name = "Church", Description = "fa-church")]
        Church = '\uf51d',
        
        [Display(Name = "Circle", Description = "fa-circle")]
        Circle = '\uf111',
        
        [Display(Name = "Circle Notch", Description = "fa-circle-notch")]
        CircleNotch = '\uf1ce',
        
        [Display(Name = "City", Description = "fa-city")]
        City = '\uf64f',
        
        [Display(Name = "Clinic Medical", Description = "fa-clinic-medical")]
        ClinicMedical = '\uf7f2',
        
        [Display(Name = "Clipboard", Description = "fa-clipboard")]
        Clipboard = '\uf328',
        
        [Display(Name = "Clipboard Check", Description = "fa-clipboard-check")]
        ClipboardCheck = '\uf46c',
        
        [Display(Name = "Clipboard List", Description = "fa-clipboard-list")]
        ClipboardList = '\uf46d',
        
        [Display(Name = "Clock", Description = "fa-clock")]
        Clock = '\uf017',
        
        [Display(Name = "Clone", Description = "fa-clone")]
        Clone = '\uf24d',
        
        [Display(Name = "Closed Captioning", Description = "fa-closed-captioning")]
        ClosedCaptioning = '\uf20a',
        
        [Display(Name = "Cloud", Description = "fa-cloud")]
        Cloud = '\uf0c2',
        
        [Display(Name = "Cloud Download Alt", Description = "fa-cloud-download-alt")]
        CloudDownloadAlt = '\uf381',
        
        [Display(Name = "Cloud Meatball", Description = "fa-cloud-meatball")]
        CloudMeatball = '\uf73b',
        
        [Display(Name = "Cloud Moon", Description = "fa-cloud-moon")]
        CloudMoon = '\uf6c3',
        
        [Display(Name = "Cloud Moon Rain", Description = "fa-cloud-moon-rain")]
        CloudMoonRain = '\uf73c',
        
        [Display(Name = "Cloud Rain", Description = "fa-cloud-rain")]
        CloudRain = '\uf73d',
        
        [Display(Name = "Cloud Showers Heavy", Description = "fa-cloud-showers-heavy")]
        CloudShowersHeavy = '\uf740',
        
        [Display(Name = "Cloud Sun", Description = "fa-cloud-sun")]
        CloudSun = '\uf6c4',
        
        [Display(Name = "Cloud Sun Rain", Description = "fa-cloud-sun-rain")]
        CloudSunRain = '\uf743',
        
        [Display(Name = "Cloud Upload Alt", Description = "fa-cloud-upload-alt")]
        CloudUploadAlt = '\uf382',
        
        [Display(Name = "Cloudscale", Description = "fa-cloudscale")]
        Cloudscale = '\uf383',
        
        [Display(Name = "Cloudsmith", Description = "fa-cloudsmith")]
        Cloudsmith = '\uf384',
        
        [Display(Name = "Cloudversify", Description = "fa-cloudversify")]
        Cloudversify = '\uf385',
        
        [Display(Name = "Cocktail", Description = "fa-cocktail")]
        Cocktail = '\uf561',
        
        [Display(Name = "Code", Description = "fa-code")]
        Code = '\uf121',
        
        [Display(Name = "Code Branch", Description = "fa-code-branch")]
        CodeBranch = '\uf126',
        
        [Display(Name = "Codepen", Description = "fa-codepen")]
        Codepen = '\uf1cb',
        
        [Display(Name = "Codiepie", Description = "fa-codiepie")]
        Codiepie = '\uf284',
        
        [Display(Name = "Coffee", Description = "fa-coffee")]
        Coffee = '\uf0f4',
        
        [Display(Name = "Cog", Description = "fa-cog")]
        Cog = '\uf013',
        
        [Display(Name = "Cogs", Description = "fa-cogs")]
        Cogs = '\uf085',
        
        [Display(Name = "Coins", Description = "fa-coins")]
        Coins = '\uf51e',
        
        [Display(Name = "Columns", Description = "fa-columns")]
        Columns = '\uf0db',
        
        [Display(Name = "Comment", Description = "fa-comment")]
        Comment = '\uf075',
        
        [Display(Name = "Comment Alt", Description = "fa-comment-alt")]
        CommentAlt = '\uf27a',
        
        [Display(Name = "Comment Dollar", Description = "fa-comment-dollar")]
        CommentDollar = '\uf651',
        
        [Display(Name = "Comment Dots", Description = "fa-comment-dots")]
        CommentDots = '\uf4ad',
        
        [Display(Name = "Comment Medical", Description = "fa-comment-medical")]
        CommentMedical = '\uf7f5',
        
        [Display(Name = "Comment Slash", Description = "fa-comment-slash")]
        CommentSlash = '\uf4b3',
        
        [Display(Name = "Comments", Description = "fa-comments")]
        Comments = '\uf086',
        
        [Display(Name = "Comments Dollar", Description = "fa-comments-dollar")]
        CommentsDollar = '\uf653',
        
        [Display(Name = "Compact Disc", Description = "fa-compact-disc")]
        CompactDisc = '\uf51f',
        
        [Display(Name = "Compass", Description = "fa-compass")]
        Compass = '\uf14e',
        
        [Display(Name = "Compress", Description = "fa-compress")]
        Compress = '\uf066',
        
        [Display(Name = "Compress Alt", Description = "fa-compress-alt")]
        CompressAlt = '\uf422',
        
        [Display(Name = "Compress Arrows Alt", Description = "fa-compress-arrows-alt")]
        CompressArrowsAlt = '\uf78c',
        
        [Display(Name = "Concierge Bell", Description = "fa-concierge-bell")]
        ConciergeBell = '\uf562',
        
        [Display(Name = "Confluence", Description = "fa-confluence")]
        Confluence = '\uf78d',
        
        [Display(Name = "Connectdevelop", Description = "fa-connectdevelop")]
        Connectdevelop = '\uf20e',
        
        [Display(Name = "Contao", Description = "fa-contao")]
        Contao = '\uf26d',
        
        [Display(Name = "Cookie", Description = "fa-cookie")]
        Cookie = '\uf563',
        
        [Display(Name = "Cookie Bite", Description = "fa-cookie-bite")]
        CookieBite = '\uf564',
        
        [Display(Name = "Copy", Description = "fa-copy")]
        Copy = '\uf0c5',
        
        [Display(Name = "Copyright", Description = "fa-copyright")]
        Copyright = '\uf1f9',
        
        [Display(Name = "Cotton Bureau", Description = "fa-cotton-bureau")]
        CottonBureau = '\uf89e',
        
        [Display(Name = "Couch", Description = "fa-couch")]
        Couch = '\uf4b8',
        
        [Display(Name = "Cpanel", Description = "fa-cpanel")]
        Cpanel = '\uf388',
        
        [Display(Name = "Creative Commons", Description = "fa-creative-commons")]
        CreativeCommons = '\uf25e',
        
        [Display(Name = "Creative Commons By", Description = "fa-creative-commons-by")]
        CreativeCommonsBy = '\uf4e7',
        
        [Display(Name = "Creative Commons Nc", Description = "fa-creative-commons-nc")]
        CreativeCommonsNc = '\uf4e8',
        
        [Display(Name = "Creative Commons Nc Eu", Description = "fa-creative-commons-nc-eu")]
        CreativeCommonsNcEu = '\uf4e9',
        
        [Display(Name = "Creative Commons Nc Jp", Description = "fa-creative-commons-nc-jp")]
        CreativeCommonsNcJp = '\uf4ea',
        
        [Display(Name = "Creative Commons Nd", Description = "fa-creative-commons-nd")]
        CreativeCommonsNd = '\uf4eb',
        
        [Display(Name = "Creative Commons Pd", Description = "fa-creative-commons-pd")]
        CreativeCommonsPd = '\uf4ec',
        
        [Display(Name = "Creative Commons Pd Alt", Description = "fa-creative-commons-pd-alt")]
        CreativeCommonsPdAlt = '\uf4ed',
        
        [Display(Name = "Creative Commons Remix", Description = "fa-creative-commons-remix")]
        CreativeCommonsRemix = '\uf4ee',
        
        [Display(Name = "Creative Commons Sa", Description = "fa-creative-commons-sa")]
        CreativeCommonsSa = '\uf4ef',
        
        [Display(Name = "Creative Commons Sampling", Description = "fa-creative-commons-sampling")]
        CreativeCommonsSampling = '\uf4f0',
        
        [Display(Name = "Creative Commons Sampling Plus", Description = "fa-creative-commons-sampling-plus")]
        CreativeCommonsSamplingPlus = '\uf4f1',
        
        [Display(Name = "Creative Commons Share", Description = "fa-creative-commons-share")]
        CreativeCommonsShare = '\uf4f2',
        
        [Display(Name = "Creative Commons Zero", Description = "fa-creative-commons-zero")]
        CreativeCommonsZero = '\uf4f3',
        
        [Display(Name = "Credit Card", Description = "fa-credit-card")]
        CreditCard = '\uf09d',
        
        [Display(Name = "Critical Role", Description = "fa-critical-role")]
        CriticalRole = '\uf6c9',
        
        [Display(Name = "Crop", Description = "fa-crop")]
        Crop = '\uf125',
        
        [Display(Name = "Crop Alt", Description = "fa-crop-alt")]
        CropAlt = '\uf565',
        
        [Display(Name = "Cross", Description = "fa-cross")]
        Cross = '\uf654',
        
        [Display(Name = "Crosshairs", Description = "fa-crosshairs")]
        Crosshairs = '\uf05b',
        
        [Display(Name = "Crow", Description = "fa-crow")]
        Crow = '\uf520',
        
        [Display(Name = "Crown", Description = "fa-crown")]
        Crown = '\uf521',
        
        [Display(Name = "Crutch", Description = "fa-crutch")]
        Crutch = '\uf7f7',
        
        [Display(Name = "Css3", Description = "fa-css3")]
        Css3 = '\uf13c',
        
        [Display(Name = "Css3 Alt", Description = "fa-css3-alt")]
        Css3Alt = '\uf38b',
        
        [Display(Name = "Cube", Description = "fa-cube")]
        Cube = '\uf1b2',
        
        [Display(Name = "Cubes", Description = "fa-cubes")]
        Cubes = '\uf1b3',
        
        [Display(Name = "Cut", Description = "fa-cut")]
        Cut = '\uf0c4',
        
        [Display(Name = "Cuttlefish", Description = "fa-cuttlefish")]
        Cuttlefish = '\uf38c',
        
        [Display(Name = "D And D", Description = "fa-d-and-d")]
        DAndD = '\uf38d',
        
        [Display(Name = "D And D Beyond", Description = "fa-d-and-d-beyond")]
        DAndDBeyond = '\uf6ca',
        
        [Display(Name = "Dailymotion", Description = "fa-dailymotion")]
        Dailymotion = '\uf952',
        
        [Display(Name = "Dashcube", Description = "fa-dashcube")]
        Dashcube = '\uf210',
        
        [Display(Name = "Database", Description = "fa-database")]
        Database = '\uf1c0',
        
        [Display(Name = "Deaf", Description = "fa-deaf")]
        Deaf = '\uf2a4',
        
        [Display(Name = "Delicious", Description = "fa-delicious")]
        Delicious = '\uf1a5',
        
        [Display(Name = "Democrat", Description = "fa-democrat")]
        Democrat = '\uf747',
        
        [Display(Name = "Deploydog", Description = "fa-deploydog")]
        Deploydog = '\uf38e',
        
        [Display(Name = "Deskpro", Description = "fa-deskpro")]
        Deskpro = '\uf38f',
        
        [Display(Name = "Desktop", Description = "fa-desktop")]
        Desktop = '\uf108',
        
        [Display(Name = "Dev", Description = "fa-dev")]
        Dev = '\uf6cc',
        
        [Display(Name = "Deviantart", Description = "fa-deviantart")]
        Deviantart = '\uf1bd',
        
        [Display(Name = "Dharmachakra", Description = "fa-dharmachakra")]
        Dharmachakra = '\uf655',
        
        [Display(Name = "Dhl", Description = "fa-dhl")]
        Dhl = '\uf790',
        
        [Display(Name = "Diagnoses", Description = "fa-diagnoses")]
        Diagnoses = '\uf470',
        
        [Display(Name = "Diaspora", Description = "fa-diaspora")]
        Diaspora = '\uf791',
        
        [Display(Name = "Dice", Description = "fa-dice")]
        Dice = '\uf522',
        
        [Display(Name = "Dice D20", Description = "fa-dice-d20")]
        DiceD20 = '\uf6cf',
        
        [Display(Name = "Dice D6", Description = "fa-dice-d6")]
        DiceD6 = '\uf6d1',
        
        [Display(Name = "Dice Five", Description = "fa-dice-five")]
        DiceFive = '\uf523',
        
        [Display(Name = "Dice Four", Description = "fa-dice-four")]
        DiceFour = '\uf524',
        
        [Display(Name = "Dice One", Description = "fa-dice-one")]
        DiceOne = '\uf525',
        
        [Display(Name = "Dice Six", Description = "fa-dice-six")]
        DiceSix = '\uf526',
        
        [Display(Name = "Dice Three", Description = "fa-dice-three")]
        DiceThree = '\uf527',
        
        [Display(Name = "Dice Two", Description = "fa-dice-two")]
        DiceTwo = '\uf528',
        
        [Display(Name = "Digg", Description = "fa-digg")]
        Digg = '\uf1a6',
        
        [Display(Name = "Digital Ocean", Description = "fa-digital-ocean")]
        DigitalOcean = '\uf391',
        
        [Display(Name = "Digital Tachograph", Description = "fa-digital-tachograph")]
        DigitalTachograph = '\uf566',
        
        [Display(Name = "Directions", Description = "fa-directions")]
        Directions = '\uf5eb',
        
        [Display(Name = "Discord", Description = "fa-discord")]
        Discord = '\uf392',
        
        [Display(Name = "Discourse", Description = "fa-discourse")]
        Discourse = '\uf393',
        
        [Display(Name = "Disease", Description = "fa-disease")]
        Disease = '\uf7fa',
        
        [Display(Name = "Divide", Description = "fa-divide")]
        Divide = '\uf529',
        
        [Display(Name = "Dizzy", Description = "fa-dizzy")]
        Dizzy = '\uf567',
        
        [Display(Name = "Dna", Description = "fa-dna")]
        Dna = '\uf471',
        
        [Display(Name = "Dochub", Description = "fa-dochub")]
        Dochub = '\uf394',
        
        [Display(Name = "Docker", Description = "fa-docker")]
        Docker = '\uf395',
        
        [Display(Name = "Dog", Description = "fa-dog")]
        Dog = '\uf6d3',
        
        [Display(Name = "Dollar Sign", Description = "fa-dollar-sign")]
        DollarSign = '\uf155',
        
        [Display(Name = "Dolly", Description = "fa-dolly")]
        Dolly = '\uf472',
        
        [Display(Name = "Dolly Flatbed", Description = "fa-dolly-flatbed")]
        DollyFlatbed = '\uf474',
        
        [Display(Name = "Donate", Description = "fa-donate")]
        Donate = '\uf4b9',
        
        [Display(Name = "Door Closed", Description = "fa-door-closed")]
        DoorClosed = '\uf52a',
        
        [Display(Name = "Door Open", Description = "fa-door-open")]
        DoorOpen = '\uf52b',
        
        [Display(Name = "Dot Circle", Description = "fa-dot-circle")]
        DotCircle = '\uf192',
        
        [Display(Name = "Dove", Description = "fa-dove")]
        Dove = '\uf4ba',
        
        [Display(Name = "Download", Description = "fa-download")]
        Download = '\uf019',
        
        [Display(Name = "Draft2digital", Description = "fa-draft2digital")]
        Draft2digital = '\uf396',
        
        [Display(Name = "Drafting Compass", Description = "fa-drafting-compass")]
        DraftingCompass = '\uf568',
        
        [Display(Name = "Dragon", Description = "fa-dragon")]
        Dragon = '\uf6d5',
        
        [Display(Name = "Draw Polygon", Description = "fa-draw-polygon")]
        DrawPolygon = '\uf5ee',
        
        [Display(Name = "Dribbble", Description = "fa-dribbble")]
        Dribbble = '\uf17d',
        
        [Display(Name = "Dribbble Square", Description = "fa-dribbble-square")]
        DribbbleSquare = '\uf397',
        
        [Display(Name = "Dropbox", Description = "fa-dropbox")]
        Dropbox = '\uf16b',
        
        [Display(Name = "Drum", Description = "fa-drum")]
        Drum = '\uf569',
        
        [Display(Name = "Drum Steelpan", Description = "fa-drum-steelpan")]
        DrumSteelpan = '\uf56a',
        
        [Display(Name = "Drumstick Bite", Description = "fa-drumstick-bite")]
        DrumstickBite = '\uf6d7',
        
        [Display(Name = "Drupal", Description = "fa-drupal")]
        Drupal = '\uf1a9',
        
        [Display(Name = "Dumbbell", Description = "fa-dumbbell")]
        Dumbbell = '\uf44b',
        
        [Display(Name = "Dumpster", Description = "fa-dumpster")]
        Dumpster = '\uf793',
        
        [Display(Name = "Dumpster Fire", Description = "fa-dumpster-fire")]
        DumpsterFire = '\uf794',
        
        [Display(Name = "Dungeon", Description = "fa-dungeon")]
        Dungeon = '\uf6d9',
        
        [Display(Name = "Dyalog", Description = "fa-dyalog")]
        Dyalog = '\uf399',
        
        [Display(Name = "Earlybirds", Description = "fa-earlybirds")]
        Earlybirds = '\uf39a',
        
        [Display(Name = "Ebay", Description = "fa-ebay")]
        Ebay = '\uf4f4',
        
        [Display(Name = "Edge", Description = "fa-edge")]
        Edge = '\uf282',
        
        [Display(Name = "Edit", Description = "fa-edit")]
        Edit = '\uf044',
        
        [Display(Name = "Egg", Description = "fa-egg")]
        Egg = '\uf7fb',
        
        [Display(Name = "Eject", Description = "fa-eject")]
        Eject = '\uf052',
        
        [Display(Name = "Elementor", Description = "fa-elementor")]
        Elementor = '\uf430',
        
        [Display(Name = "Ellipsis H", Description = "fa-ellipsis-h")]
        EllipsisH = '\uf141',
        
        [Display(Name = "Ellipsis V", Description = "fa-ellipsis-v")]
        EllipsisV = '\uf142',
        
        [Display(Name = "Ello", Description = "fa-ello")]
        Ello = '\uf5f1',
        
        [Display(Name = "Ember", Description = "fa-ember")]
        Ember = '\uf423',
        
        [Display(Name = "Empire", Description = "fa-empire")]
        Empire = '\uf1d1',
        
        [Display(Name = "Envelope", Description = "fa-envelope")]
        Envelope = '\uf0e0',
        
        [Display(Name = "Envelope Open", Description = "fa-envelope-open")]
        EnvelopeOpen = '\uf2b6',
        
        [Display(Name = "Envelope Open Text", Description = "fa-envelope-open-text")]
        EnvelopeOpenText = '\uf658',
        
        [Display(Name = "Envelope Square", Description = "fa-envelope-square")]
        EnvelopeSquare = '\uf199',
        
        [Display(Name = "Envira", Description = "fa-envira")]
        Envira = '\uf299',
        
        [Display(Name = "Equals", Description = "fa-equals")]
        Equals = '\uf52c',
        
        [Display(Name = "Eraser", Description = "fa-eraser")]
        Eraser = '\uf12d',
        
        [Display(Name = "Erlang", Description = "fa-erlang")]
        Erlang = '\uf39d',
        
        [Display(Name = "Ethereum", Description = "fa-ethereum")]
        Ethereum = '\uf42e',
        
        [Display(Name = "Ethernet", Description = "fa-ethernet")]
        Ethernet = '\uf796',
        
        [Display(Name = "Etsy", Description = "fa-etsy")]
        Etsy = '\uf2d7',
        
        [Display(Name = "Euro Sign", Description = "fa-euro-sign")]
        EuroSign = '\uf153',
        
        [Display(Name = "Evernote", Description = "fa-evernote")]
        Evernote = '\uf839',
        
        [Display(Name = "Exchange Alt", Description = "fa-exchange-alt")]
        ExchangeAlt = '\uf362',
        
        [Display(Name = "Exclamation", Description = "fa-exclamation")]
        Exclamation = '\uf12a',
        
        [Display(Name = "Exclamation Circle", Description = "fa-exclamation-circle")]
        ExclamationCircle = '\uf06a',
        
        [Display(Name = "Exclamation Triangle", Description = "fa-exclamation-triangle")]
        ExclamationTriangle = '\uf071',
        
        [Display(Name = "Expand", Description = "fa-expand")]
        Expand = '\uf065',
        
        [Display(Name = "Expand Alt", Description = "fa-expand-alt")]
        ExpandAlt = '\uf424',
        
        [Display(Name = "Expand Arrows Alt", Description = "fa-expand-arrows-alt")]
        ExpandArrowsAlt = '\uf31e',
        
        [Display(Name = "Expeditedssl", Description = "fa-expeditedssl")]
        Expeditedssl = '\uf23e',
        
        [Display(Name = "External Link Alt", Description = "fa-external-link-alt")]
        ExternalLinkAlt = '\uf35d',
        
        [Display(Name = "External Link Square Alt", Description = "fa-external-link-square-alt")]
        ExternalLinkSquareAlt = '\uf360',
        
        [Display(Name = "Eye", Description = "fa-eye")]
        Eye = '\uf06e',
        
        [Display(Name = "Eye Dropper", Description = "fa-eye-dropper")]
        EyeDropper = '\uf1fb',
        
        [Display(Name = "Eye Slash", Description = "fa-eye-slash")]
        EyeSlash = '\uf070',
        
        [Display(Name = "Facebook", Description = "fa-facebook")]
        Facebook = '\uf09a',
        
        [Display(Name = "Facebook F", Description = "fa-facebook-f")]
        FacebookF = '\uf39e',
        
        [Display(Name = "Facebook Messenger", Description = "fa-facebook-messenger")]
        FacebookMessenger = '\uf39f',
        
        [Display(Name = "Facebook Square", Description = "fa-facebook-square")]
        FacebookSquare = '\uf082',
        
        [Display(Name = "Fan", Description = "fa-fan")]
        Fan = '\uf863',
        
        [Display(Name = "Fantasy Flight Games", Description = "fa-fantasy-flight-games")]
        FantasyFlightGames = '\uf6dc',
        
        [Display(Name = "Fast Backward", Description = "fa-fast-backward")]
        FastBackward = '\uf049',
        
        [Display(Name = "Fast Forward", Description = "fa-fast-forward")]
        FastForward = '\uf050',
        
        [Display(Name = "Faucet", Description = "fa-faucet")]
        Faucet = '\uf905',
        
        [Display(Name = "Fax", Description = "fa-fax")]
        Fax = '\uf1ac',
        
        [Display(Name = "Feather", Description = "fa-feather")]
        Feather = '\uf52d',
        
        [Display(Name = "Feather Alt", Description = "fa-feather-alt")]
        FeatherAlt = '\uf56b',
        
        [Display(Name = "Fedex", Description = "fa-fedex")]
        Fedex = '\uf797',
        
        [Display(Name = "Fedora", Description = "fa-fedora")]
        Fedora = '\uf798',
        
        [Display(Name = "Female", Description = "fa-female")]
        Female = '\uf182',
        
        [Display(Name = "Fighter Jet", Description = "fa-fighter-jet")]
        FighterJet = '\uf0fb',
        
        [Display(Name = "Figma", Description = "fa-figma")]
        Figma = '\uf799',
        
        [Display(Name = "File", Description = "fa-file")]
        File = '\uf15b',
        
        [Display(Name = "File Alt", Description = "fa-file-alt")]
        FileAlt = '\uf15c',
        
        [Display(Name = "File Archive", Description = "fa-file-archive")]
        FileArchive = '\uf1c6',
        
        [Display(Name = "File Audio", Description = "fa-file-audio")]
        FileAudio = '\uf1c7',
        
        [Display(Name = "File Code", Description = "fa-file-code")]
        FileCode = '\uf1c9',
        
        [Display(Name = "File Contract", Description = "fa-file-contract")]
        FileContract = '\uf56c',
        
        [Display(Name = "File Csv", Description = "fa-file-csv")]
        FileCsv = '\uf6dd',
        
        [Display(Name = "File Download", Description = "fa-file-download")]
        FileDownload = '\uf56d',
        
        [Display(Name = "File Excel", Description = "fa-file-excel")]
        FileExcel = '\uf1c3',
        
        [Display(Name = "File Export", Description = "fa-file-export")]
        FileExport = '\uf56e',
        
        [Display(Name = "File Image", Description = "fa-file-image")]
        FileImage = '\uf1c5',
        
        [Display(Name = "File Import", Description = "fa-file-import")]
        FileImport = '\uf56f',
        
        [Display(Name = "File Invoice", Description = "fa-file-invoice")]
        FileInvoice = '\uf570',
        
        [Display(Name = "File Invoice Dollar", Description = "fa-file-invoice-dollar")]
        FileInvoiceDollar = '\uf571',
        
        [Display(Name = "File Medical", Description = "fa-file-medical")]
        FileMedical = '\uf477',
        
        [Display(Name = "File Medical Alt", Description = "fa-file-medical-alt")]
        FileMedicalAlt = '\uf478',
        
        [Display(Name = "File Pdf", Description = "fa-file-pdf")]
        FilePdf = '\uf1c1',
        
        [Display(Name = "File Powerpoint", Description = "fa-file-powerpoint")]
        FilePowerpoint = '\uf1c4',
        
        [Display(Name = "File Prescription", Description = "fa-file-prescription")]
        FilePrescription = '\uf572',
        
        [Display(Name = "File Signature", Description = "fa-file-signature")]
        FileSignature = '\uf573',
        
        [Display(Name = "File Upload", Description = "fa-file-upload")]
        FileUpload = '\uf574',
        
        [Display(Name = "File Video", Description = "fa-file-video")]
        FileVideo = '\uf1c8',
        
        [Display(Name = "File Word", Description = "fa-file-word")]
        FileWord = '\uf1c2',
        
        [Display(Name = "Fill", Description = "fa-fill")]
        Fill = '\uf575',
        
        [Display(Name = "Fill Drip", Description = "fa-fill-drip")]
        FillDrip = '\uf576',
        
        [Display(Name = "Film", Description = "fa-film")]
        Film = '\uf008',
        
        [Display(Name = "Filter", Description = "fa-filter")]
        Filter = '\uf0b0',
        
        [Display(Name = "Fingerprint", Description = "fa-fingerprint")]
        Fingerprint = '\uf577',
        
        [Display(Name = "Fire", Description = "fa-fire")]
        Fire = '\uf06d',
        
        [Display(Name = "Fire Alt", Description = "fa-fire-alt")]
        FireAlt = '\uf7e4',
        
        [Display(Name = "Fire Extinguisher", Description = "fa-fire-extinguisher")]
        FireExtinguisher = '\uf134',
        
        [Display(Name = "Firefox", Description = "fa-firefox")]
        Firefox = '\uf269',
        
        [Display(Name = "Firefox Browser", Description = "fa-firefox-browser")]
        FirefoxBrowser = '\uf907',
        
        [Display(Name = "First Aid", Description = "fa-first-aid")]
        FirstAid = '\uf479',
        
        [Display(Name = "First Order", Description = "fa-first-order")]
        FirstOrder = '\uf2b0',
        
        [Display(Name = "First Order Alt", Description = "fa-first-order-alt")]
        FirstOrderAlt = '\uf50a',
        
        [Display(Name = "Firstdraft", Description = "fa-firstdraft")]
        Firstdraft = '\uf3a1',
        
        [Display(Name = "Fish", Description = "fa-fish")]
        Fish = '\uf578',
        
        [Display(Name = "Fist Raised", Description = "fa-fist-raised")]
        FistRaised = '\uf6de',
        
        [Display(Name = "Flag", Description = "fa-flag")]
        Flag = '\uf024',
        
        [Display(Name = "Flag Checkered", Description = "fa-flag-checkered")]
        FlagCheckered = '\uf11e',
        
        [Display(Name = "Flag Usa", Description = "fa-flag-usa")]
        FlagUsa = '\uf74d',
        
        [Display(Name = "Flask", Description = "fa-flask")]
        Flask = '\uf0c3',
        
        [Display(Name = "Flickr", Description = "fa-flickr")]
        Flickr = '\uf16e',
        
        [Display(Name = "Flipboard", Description = "fa-flipboard")]
        Flipboard = '\uf44d',
        
        [Display(Name = "Flushed", Description = "fa-flushed")]
        Flushed = '\uf579',
        
        [Display(Name = "Fly", Description = "fa-fly")]
        Fly = '\uf417',
        
        [Display(Name = "Folder", Description = "fa-folder")]
        Folder = '\uf07b',
        
        [Display(Name = "Folder Minus", Description = "fa-folder-minus")]
        FolderMinus = '\uf65d',
        
        [Display(Name = "Folder Open", Description = "fa-folder-open")]
        FolderOpen = '\uf07c',
        
        [Display(Name = "Folder Plus", Description = "fa-folder-plus")]
        FolderPlus = '\uf65e',
        
        [Display(Name = "Font", Description = "fa-font")]
        Font = '\uf031',
        
        [Display(Name = "Font Awesome", Description = "fa-font-awesome")]
        FontAwesome = '\uf2b4',
        
        [Display(Name = "Font Awesome Alt", Description = "fa-font-awesome-alt")]
        FontAwesomeAlt = '\uf35c',
        
        [Display(Name = "Font Awesome Flag", Description = "fa-font-awesome-flag")]
        FontAwesomeFlag = '\uf425',
        
        [Display(Name = "Font Awesome Logo Full", Description = "fa-font-awesome-logo-full")]
        FontAwesomeLogoFull = '\uf4e6',
        
        [Display(Name = "Fonticons", Description = "fa-fonticons")]
        Fonticons = '\uf280',
        
        [Display(Name = "Fonticons Fi", Description = "fa-fonticons-fi")]
        FonticonsFi = '\uf3a2',
        
        [Display(Name = "Football Ball", Description = "fa-football-ball")]
        FootballBall = '\uf44e',
        
        [Display(Name = "Fort Awesome", Description = "fa-fort-awesome")]
        FortAwesome = '\uf286',
        
        [Display(Name = "Fort Awesome Alt", Description = "fa-fort-awesome-alt")]
        FortAwesomeAlt = '\uf3a3',
        
        [Display(Name = "Forumbee", Description = "fa-forumbee")]
        Forumbee = '\uf211',
        
        [Display(Name = "Forward", Description = "fa-forward")]
        Forward = '\uf04e',
        
        [Display(Name = "Foursquare", Description = "fa-foursquare")]
        Foursquare = '\uf180',
        
        [Display(Name = "Free Code Camp", Description = "fa-free-code-camp")]
        FreeCodeCamp = '\uf2c5',
        
        [Display(Name = "Freebsd", Description = "fa-freebsd")]
        Freebsd = '\uf3a4',
        
        [Display(Name = "Frog", Description = "fa-frog")]
        Frog = '\uf52e',
        
        [Display(Name = "Frown", Description = "fa-frown")]
        Frown = '\uf119',
        
        [Display(Name = "Frown Open", Description = "fa-frown-open")]
        FrownOpen = '\uf57a',
        
        [Display(Name = "Fulcrum", Description = "fa-fulcrum")]
        Fulcrum = '\uf50b',
        
        [Display(Name = "Funnel Dollar", Description = "fa-funnel-dollar")]
        FunnelDollar = '\uf662',
        
        [Display(Name = "Futbol", Description = "fa-futbol")]
        Futbol = '\uf1e3',
        
        [Display(Name = "Galactic Republic", Description = "fa-galactic-republic")]
        GalacticRepublic = '\uf50c',
        
        [Display(Name = "Galactic Senate", Description = "fa-galactic-senate")]
        GalacticSenate = '\uf50d',
        
        [Display(Name = "Gamepad", Description = "fa-gamepad")]
        Gamepad = '\uf11b',
        
        [Display(Name = "Gas Pump", Description = "fa-gas-pump")]
        GasPump = '\uf52f',
        
        [Display(Name = "Gavel", Description = "fa-gavel")]
        Gavel = '\uf0e3',
        
        [Display(Name = "Gem", Description = "fa-gem")]
        Gem = '\uf3a5',
        
        [Display(Name = "Genderless", Description = "fa-genderless")]
        Genderless = '\uf22d',
        
        [Display(Name = "Get Pocket", Description = "fa-get-pocket")]
        GetPocket = '\uf265',
        
        [Display(Name = "Gg", Description = "fa-gg")]
        Gg = '\uf260',
        
        [Display(Name = "Gg Circle", Description = "fa-gg-circle")]
        GgCircle = '\uf261',
        
        [Display(Name = "Ghost", Description = "fa-ghost")]
        Ghost = '\uf6e2',
        
        [Display(Name = "Gift", Description = "fa-gift")]
        Gift = '\uf06b',
        
        [Display(Name = "Gifts", Description = "fa-gifts")]
        Gifts = '\uf79c',
        
        [Display(Name = "Git", Description = "fa-git")]
        Git = '\uf1d3',
        
        [Display(Name = "Git Alt", Description = "fa-git-alt")]
        GitAlt = '\uf841',
        
        [Display(Name = "Git Square", Description = "fa-git-square")]
        GitSquare = '\uf1d2',
        
        [Display(Name = "Github", Description = "fa-github")]
        Github = '\uf09b',
        
        [Display(Name = "Github Alt", Description = "fa-github-alt")]
        GithubAlt = '\uf113',
        
        [Display(Name = "Github Square", Description = "fa-github-square")]
        GithubSquare = '\uf092',
        
        [Display(Name = "Gitkraken", Description = "fa-gitkraken")]
        Gitkraken = '\uf3a6',
        
        [Display(Name = "Gitlab", Description = "fa-gitlab")]
        Gitlab = '\uf296',
        
        [Display(Name = "Gitter", Description = "fa-gitter")]
        Gitter = '\uf426',
        
        [Display(Name = "Glass Cheers", Description = "fa-glass-cheers")]
        GlassCheers = '\uf79f',
        
        [Display(Name = "Glass Martini", Description = "fa-glass-martini")]
        GlassMartini = '\uf000',
        
        [Display(Name = "Glass Martini Alt", Description = "fa-glass-martini-alt")]
        GlassMartiniAlt = '\uf57b',
        
        [Display(Name = "Glass Whiskey", Description = "fa-glass-whiskey")]
        GlassWhiskey = '\uf7a0',
        
        [Display(Name = "Glasses", Description = "fa-glasses")]
        Glasses = '\uf530',
        
        [Display(Name = "Glide", Description = "fa-glide")]
        Glide = '\uf2a5',
        
        [Display(Name = "Glide G", Description = "fa-glide-g")]
        GlideG = '\uf2a6',
        
        [Display(Name = "Globe", Description = "fa-globe")]
        Globe = '\uf0ac',
        
        [Display(Name = "Globe Africa", Description = "fa-globe-africa")]
        GlobeAfrica = '\uf57c',
        
        [Display(Name = "Globe Americas", Description = "fa-globe-americas")]
        GlobeAmericas = '\uf57d',
        
        [Display(Name = "Globe Asia", Description = "fa-globe-asia")]
        GlobeAsia = '\uf57e',
        
        [Display(Name = "Globe Europe", Description = "fa-globe-europe")]
        GlobeEurope = '\uf7a2',
        
        [Display(Name = "Gofore", Description = "fa-gofore")]
        Gofore = '\uf3a7',
        
        [Display(Name = "Golf Ball", Description = "fa-golf-ball")]
        GolfBall = '\uf450',
        
        [Display(Name = "Goodreads", Description = "fa-goodreads")]
        Goodreads = '\uf3a8',
        
        [Display(Name = "Goodreads G", Description = "fa-goodreads-g")]
        GoodreadsG = '\uf3a9',
        
        [Display(Name = "Google", Description = "fa-google")]
        Google = '\uf1a0',
        
        [Display(Name = "Google Drive", Description = "fa-google-drive")]
        GoogleDrive = '\uf3aa',
        
        [Display(Name = "Google Play", Description = "fa-google-play")]
        GooglePlay = '\uf3ab',
        
        [Display(Name = "Google Plus", Description = "fa-google-plus")]
        GooglePlus = '\uf2b3',
        
        [Display(Name = "Google Plus G", Description = "fa-google-plus-g")]
        GooglePlusG = '\uf0d5',
        
        [Display(Name = "Google Plus Square", Description = "fa-google-plus-square")]
        GooglePlusSquare = '\uf0d4',
        
        [Display(Name = "Google Wallet", Description = "fa-google-wallet")]
        GoogleWallet = '\uf1ee',
        
        [Display(Name = "Gopuram", Description = "fa-gopuram")]
        Gopuram = '\uf664',
        
        [Display(Name = "Graduation Cap", Description = "fa-graduation-cap")]
        GraduationCap = '\uf19d',
        
        [Display(Name = "Gratipay", Description = "fa-gratipay")]
        Gratipay = '\uf184',
        
        [Display(Name = "Grav", Description = "fa-grav")]
        Grav = '\uf2d6',
        
        [Display(Name = "Greater Than", Description = "fa-greater-than")]
        GreaterThan = '\uf531',
        
        [Display(Name = "Greater Than Equal", Description = "fa-greater-than-equal")]
        GreaterThanEqual = '\uf532',
        
        [Display(Name = "Grimace", Description = "fa-grimace")]
        Grimace = '\uf57f',
        
        [Display(Name = "Grin", Description = "fa-grin")]
        Grin = '\uf580',
        
        [Display(Name = "Grin Alt", Description = "fa-grin-alt")]
        GrinAlt = '\uf581',
        
        [Display(Name = "Grin Beam", Description = "fa-grin-beam")]
        GrinBeam = '\uf582',
        
        [Display(Name = "Grin Beam Sweat", Description = "fa-grin-beam-sweat")]
        GrinBeamSweat = '\uf583',
        
        [Display(Name = "Grin Hearts", Description = "fa-grin-hearts")]
        GrinHearts = '\uf584',
        
        [Display(Name = "Grin Squint", Description = "fa-grin-squint")]
        GrinSquint = '\uf585',
        
        [Display(Name = "Grin Squint Tears", Description = "fa-grin-squint-tears")]
        GrinSquintTears = '\uf586',
        
        [Display(Name = "Grin Stars", Description = "fa-grin-stars")]
        GrinStars = '\uf587',
        
        [Display(Name = "Grin Tears", Description = "fa-grin-tears")]
        GrinTears = '\uf588',
        
        [Display(Name = "Grin Tongue", Description = "fa-grin-tongue")]
        GrinTongue = '\uf589',
        
        [Display(Name = "Grin Tongue Squint", Description = "fa-grin-tongue-squint")]
        GrinTongueSquint = '\uf58a',
        
        [Display(Name = "Grin Tongue Wink", Description = "fa-grin-tongue-wink")]
        GrinTongueWink = '\uf58b',
        
        [Display(Name = "Grin Wink", Description = "fa-grin-wink")]
        GrinWink = '\uf58c',
        
        [Display(Name = "Grip Horizontal", Description = "fa-grip-horizontal")]
        GripHorizontal = '\uf58d',
        
        [Display(Name = "Grip Lines", Description = "fa-grip-lines")]
        GripLines = '\uf7a4',
        
        [Display(Name = "Grip Lines Vertical", Description = "fa-grip-lines-vertical")]
        GripLinesVertical = '\uf7a5',
        
        [Display(Name = "Grip Vertical", Description = "fa-grip-vertical")]
        GripVertical = '\uf58e',
        
        [Display(Name = "Gripfire", Description = "fa-gripfire")]
        Gripfire = '\uf3ac',
        
        [Display(Name = "Grunt", Description = "fa-grunt")]
        Grunt = '\uf3ad',
        
        [Display(Name = "Guitar", Description = "fa-guitar")]
        Guitar = '\uf7a6',
        
        [Display(Name = "Gulp", Description = "fa-gulp")]
        Gulp = '\uf3ae',
        
        [Display(Name = "H Square", Description = "fa-h-square")]
        HSquare = '\uf0fd',
        
        [Display(Name = "Hacker News", Description = "fa-hacker-news")]
        HackerNews = '\uf1d4',
        
        [Display(Name = "Hacker News Square", Description = "fa-hacker-news-square")]
        HackerNewsSquare = '\uf3af',
        
        [Display(Name = "Hackerrank", Description = "fa-hackerrank")]
        Hackerrank = '\uf5f7',
        
        [Display(Name = "Hamburger", Description = "fa-hamburger")]
        Hamburger = '\uf805',
        
        [Display(Name = "Hammer", Description = "fa-hammer")]
        Hammer = '\uf6e3',
        
        [Display(Name = "Hamsa", Description = "fa-hamsa")]
        Hamsa = '\uf665',
        
        [Display(Name = "Hand Holding", Description = "fa-hand-holding")]
        HandHolding = '\uf4bd',
        
        [Display(Name = "Hand Holding Heart", Description = "fa-hand-holding-heart")]
        HandHoldingHeart = '\uf4be',
        
        [Display(Name = "Hand Holding Medical", Description = "fa-hand-holding-medical")]
        HandHoldingMedical = '\uf95c',
        
        [Display(Name = "Hand Holding Usd", Description = "fa-hand-holding-usd")]
        HandHoldingUsd = '\uf4c0',
        
        [Display(Name = "Hand Holding Water", Description = "fa-hand-holding-water")]
        HandHoldingWater = '\uf4c1',
        
        [Display(Name = "Hand Lizard", Description = "fa-hand-lizard")]
        HandLizard = '\uf258',
        
        [Display(Name = "Hand Middle Finger", Description = "fa-hand-middle-finger")]
        HandMiddleFinger = '\uf806',
        
        [Display(Name = "Hand Paper", Description = "fa-hand-paper")]
        HandPaper = '\uf256',
        
        [Display(Name = "Hand Peace", Description = "fa-hand-peace")]
        HandPeace = '\uf25b',
        
        [Display(Name = "Hand Point Down", Description = "fa-hand-point-down")]
        HandPointDown = '\uf0a7',
        
        [Display(Name = "Hand Point Left", Description = "fa-hand-point-left")]
        HandPointLeft = '\uf0a5',
        
        [Display(Name = "Hand Point Right", Description = "fa-hand-point-right")]
        HandPointRight = '\uf0a4',
        
        [Display(Name = "Hand Point Up", Description = "fa-hand-point-up")]
        HandPointUp = '\uf0a6',
        
        [Display(Name = "Hand Pointer", Description = "fa-hand-pointer")]
        HandPointer = '\uf25a',
        
        [Display(Name = "Hand Rock", Description = "fa-hand-rock")]
        HandRock = '\uf255',
        
        [Display(Name = "Hand Scissors", Description = "fa-hand-scissors")]
        HandScissors = '\uf257',
        
        [Display(Name = "Hand Sparkles", Description = "fa-hand-sparkles")]
        HandSparkles = '\uf95d',
        
        [Display(Name = "Hand Spock", Description = "fa-hand-spock")]
        HandSpock = '\uf259',
        
        [Display(Name = "Hands", Description = "fa-hands")]
        Hands = '\uf4c2',
        
        [Display(Name = "Hands Helping", Description = "fa-hands-helping")]
        HandsHelping = '\uf4c4',
        
        [Display(Name = "Hands Wash", Description = "fa-hands-wash")]
        HandsWash = '\uf95e',
        
        [Display(Name = "Handshake", Description = "fa-handshake")]
        Handshake = '\uf2b5',
        
        [Display(Name = "Handshake Alt Slash", Description = "fa-handshake-alt-slash")]
        HandshakeAltSlash = '\uf95f',
        
        [Display(Name = "Handshake Slash", Description = "fa-handshake-slash")]
        HandshakeSlash = '\uf960',
        
        [Display(Name = "Hanukiah", Description = "fa-hanukiah")]
        Hanukiah = '\uf6e6',
        
        [Display(Name = "Hard Hat", Description = "fa-hard-hat")]
        HardHat = '\uf807',
        
        [Display(Name = "Hashtag", Description = "fa-hashtag")]
        Hashtag = '\uf292',
        
        [Display(Name = "Hat Cowboy", Description = "fa-hat-cowboy")]
        HatCowboy = '\uf8c0',
        
        [Display(Name = "Hat Cowboy Side", Description = "fa-hat-cowboy-side")]
        HatCowboySide = '\uf8c1',
        
        [Display(Name = "Hat Wizard", Description = "fa-hat-wizard")]
        HatWizard = '\uf6e8',
        
        [Display(Name = "Hdd", Description = "fa-hdd")]
        Hdd = '\uf0a0',
        
        [Display(Name = "Head Side Cough", Description = "fa-head-side-cough")]
        HeadSideCough = '\uf961',
        
        [Display(Name = "Head Side Cough Slash", Description = "fa-head-side-cough-slash")]
        HeadSideCoughSlash = '\uf962',
        
        [Display(Name = "Head Side Mask", Description = "fa-head-side-mask")]
        HeadSideMask = '\uf963',
        
        [Display(Name = "Head Side Virus", Description = "fa-head-side-virus")]
        HeadSideVirus = '\uf964',
        
        [Display(Name = "Heading", Description = "fa-heading")]
        Heading = '\uf1dc',
        
        [Display(Name = "Headphones", Description = "fa-headphones")]
        Headphones = '\uf025',
        
        [Display(Name = "Headphones Alt", Description = "fa-headphones-alt")]
        HeadphonesAlt = '\uf58f',
        
        [Display(Name = "Headset", Description = "fa-headset")]
        Headset = '\uf590',
        
        [Display(Name = "Heart", Description = "fa-heart")]
        Heart = '\uf004',
        
        [Display(Name = "Heart Broken", Description = "fa-heart-broken")]
        HeartBroken = '\uf7a9',
        
        [Display(Name = "Heartbeat", Description = "fa-heartbeat")]
        Heartbeat = '\uf21e',
        
        [Display(Name = "Helicopter", Description = "fa-helicopter")]
        Helicopter = '\uf533',
        
        [Display(Name = "Highlighter", Description = "fa-highlighter")]
        Highlighter = '\uf591',
        
        [Display(Name = "Hiking", Description = "fa-hiking")]
        Hiking = '\uf6ec',
        
        [Display(Name = "Hippo", Description = "fa-hippo")]
        Hippo = '\uf6ed',
        
        [Display(Name = "Hips", Description = "fa-hips")]
        Hips = '\uf452',
        
        [Display(Name = "Hire A Helper", Description = "fa-hire-a-helper")]
        HireAHelper = '\uf3b0',
        
        [Display(Name = "History", Description = "fa-history")]
        History = '\uf1da',
        
        [Display(Name = "Hockey Puck", Description = "fa-hockey-puck")]
        HockeyPuck = '\uf453',
        
        [Display(Name = "Holly Berry", Description = "fa-holly-berry")]
        HollyBerry = '\uf7aa',
        
        [Display(Name = "Home", Description = "fa-home")]
        Home = '\uf015',
        
        [Display(Name = "Hooli", Description = "fa-hooli")]
        Hooli = '\uf427',
        
        [Display(Name = "Hornbill", Description = "fa-hornbill")]
        Hornbill = '\uf592',
        
        [Display(Name = "Horse", Description = "fa-horse")]
        Horse = '\uf6f0',
        
        [Display(Name = "Horse Head", Description = "fa-horse-head")]
        HorseHead = '\uf7ab',
        
        [Display(Name = "Hospital", Description = "fa-hospital")]
        Hospital = '\uf0f8',
        
        [Display(Name = "Hospital Alt", Description = "fa-hospital-alt")]
        HospitalAlt = '\uf47d',
        
        [Display(Name = "Hospital Symbol", Description = "fa-hospital-symbol")]
        HospitalSymbol = '\uf47e',
        
        [Display(Name = "Hospital User", Description = "fa-hospital-user")]
        HospitalUser = '\uf80d',
        
        [Display(Name = "Hot Tub", Description = "fa-hot-tub")]
        HotTub = '\uf593',
        
        [Display(Name = "Hotdog", Description = "fa-hotdog")]
        Hotdog = '\uf80f',
        
        [Display(Name = "Hotel", Description = "fa-hotel")]
        Hotel = '\uf594',
        
        [Display(Name = "Hotjar", Description = "fa-hotjar")]
        Hotjar = '\uf3b1',
        
        [Display(Name = "Hourglass", Description = "fa-hourglass")]
        Hourglass = '\uf254',
        
        [Display(Name = "Hourglass End", Description = "fa-hourglass-end")]
        HourglassEnd = '\uf253',
        
        [Display(Name = "Hourglass Half", Description = "fa-hourglass-half")]
        HourglassHalf = '\uf252',
        
        [Display(Name = "Hourglass Start", Description = "fa-hourglass-start")]
        HourglassStart = '\uf251',
        
        [Display(Name = "House Damage", Description = "fa-house-damage")]
        HouseDamage = '\uf6f1',
        
        [Display(Name = "House User", Description = "fa-house-user")]
        HouseUser = '\uf965',
        
        [Display(Name = "Houzz", Description = "fa-houzz")]
        Houzz = '\uf27c',
        
        [Display(Name = "Hryvnia", Description = "fa-hryvnia")]
        Hryvnia = '\uf6f2',
        
        [Display(Name = "Html5", Description = "fa-html5")]
        Html5 = '\uf13b',
        
        [Display(Name = "Hubspot", Description = "fa-hubspot")]
        Hubspot = '\uf3b2',
        
        [Display(Name = "I Cursor", Description = "fa-i-cursor")]
        ICursor = '\uf246',
        
        [Display(Name = "Ice Cream", Description = "fa-ice-cream")]
        IceCream = '\uf810',
        
        [Display(Name = "Icicles", Description = "fa-icicles")]
        Icicles = '\uf7ad',
        
        [Display(Name = "Icons", Description = "fa-icons")]
        Icons = '\uf86d',
        
        [Display(Name = "Id Badge", Description = "fa-id-badge")]
        IdBadge = '\uf2c1',
        
        [Display(Name = "Id Card", Description = "fa-id-card")]
        IdCard = '\uf2c2',
        
        [Display(Name = "Id Card Alt", Description = "fa-id-card-alt")]
        IdCardAlt = '\uf47f',
        
        [Display(Name = "Ideal", Description = "fa-ideal")]
        Ideal = '\uf913',
        
        [Display(Name = "Igloo", Description = "fa-igloo")]
        Igloo = '\uf7ae',
        
        [Display(Name = "Image", Description = "fa-image")]
        Image = '\uf03e',
        
        [Display(Name = "Images", Description = "fa-images")]
        Images = '\uf302',
        
        [Display(Name = "Imdb", Description = "fa-imdb")]
        Imdb = '\uf2d8',
        
        [Display(Name = "Inbox", Description = "fa-inbox")]
        Inbox = '\uf01c',
        
        [Display(Name = "Indent", Description = "fa-indent")]
        Indent = '\uf03c',
        
        [Display(Name = "Industry", Description = "fa-industry")]
        Industry = '\uf275',
        
        [Display(Name = "Infinity", Description = "fa-infinity")]
        Infinity = '\uf534',
        
        [Display(Name = "Info", Description = "fa-info")]
        Info = '\uf129',
        
        [Display(Name = "Info Circle", Description = "fa-info-circle")]
        InfoCircle = '\uf05a',
        
        [Display(Name = "Instagram", Description = "fa-instagram")]
        Instagram = '\uf16d',
        
        [Display(Name = "Instagram Square", Description = "fa-instagram-square")]
        InstagramSquare = '\uf955',
        
        [Display(Name = "Intercom", Description = "fa-intercom")]
        Intercom = '\uf7af',
        
        [Display(Name = "Internet Explorer", Description = "fa-internet-explorer")]
        InternetExplorer = '\uf26b',
        
        [Display(Name = "Invision", Description = "fa-invision")]
        Invision = '\uf7b0',
        
        [Display(Name = "Ioxhost", Description = "fa-ioxhost")]
        Ioxhost = '\uf208',
        
        [Display(Name = "Italic", Description = "fa-italic")]
        Italic = '\uf033',
        
        [Display(Name = "Itch Io", Description = "fa-itch-io")]
        ItchIo = '\uf83a',
        
        [Display(Name = "Itunes", Description = "fa-itunes")]
        Itunes = '\uf3b4',
        
        [Display(Name = "Itunes Note", Description = "fa-itunes-note")]
        ItunesNote = '\uf3b5',
        
        [Display(Name = "Java", Description = "fa-java")]
        Java = '\uf4e4',
        
        [Display(Name = "Jedi", Description = "fa-jedi")]
        Jedi = '\uf669',
        
        [Display(Name = "Jedi Order", Description = "fa-jedi-order")]
        JediOrder = '\uf50e',
        
        [Display(Name = "Jenkins", Description = "fa-jenkins")]
        Jenkins = '\uf3b6',
        
        [Display(Name = "Jira", Description = "fa-jira")]
        Jira = '\uf7b1',
        
        [Display(Name = "Joget", Description = "fa-joget")]
        Joget = '\uf3b7',
        
        [Display(Name = "Joint", Description = "fa-joint")]
        Joint = '\uf595',
        
        [Display(Name = "Joomla", Description = "fa-joomla")]
        Joomla = '\uf1aa',
        
        [Display(Name = "Journal Whills", Description = "fa-journal-whills")]
        JournalWhills = '\uf66a',
        
        [Display(Name = "Js", Description = "fa-js")]
        Js = '\uf3b8',
        
        [Display(Name = "Js Square", Description = "fa-js-square")]
        JsSquare = '\uf3b9',
        
        [Display(Name = "Jsfiddle", Description = "fa-jsfiddle")]
        Jsfiddle = '\uf1cc',
        
        [Display(Name = "Kaaba", Description = "fa-kaaba")]
        Kaaba = '\uf66b',
        
        [Display(Name = "Kaggle", Description = "fa-kaggle")]
        Kaggle = '\uf5fa',
        
        [Display(Name = "Key", Description = "fa-key")]
        Key = '\uf084',
        
        [Display(Name = "Keybase", Description = "fa-keybase")]
        Keybase = '\uf4f5',
        
        [Display(Name = "Keyboard", Description = "fa-keyboard")]
        Keyboard = '\uf11c',
        
        [Display(Name = "Keycdn", Description = "fa-keycdn")]
        Keycdn = '\uf3ba',
        
        [Display(Name = "Khanda", Description = "fa-khanda")]
        Khanda = '\uf66d',
        
        [Display(Name = "Kickstarter", Description = "fa-kickstarter")]
        Kickstarter = '\uf3bb',
        
        [Display(Name = "Kickstarter K", Description = "fa-kickstarter-k")]
        KickstarterK = '\uf3bc',
        
        [Display(Name = "Kiss", Description = "fa-kiss")]
        Kiss = '\uf596',
        
        [Display(Name = "Kiss Beam", Description = "fa-kiss-beam")]
        KissBeam = '\uf597',
        
        [Display(Name = "Kiss Wink Heart", Description = "fa-kiss-wink-heart")]
        KissWinkHeart = '\uf598',
        
        [Display(Name = "Kiwi Bird", Description = "fa-kiwi-bird")]
        KiwiBird = '\uf535',
        
        [Display(Name = "Korvue", Description = "fa-korvue")]
        Korvue = '\uf42f',
        
        [Display(Name = "Landmark", Description = "fa-landmark")]
        Landmark = '\uf66f',
        
        [Display(Name = "Language", Description = "fa-language")]
        Language = '\uf1ab',
        
        [Display(Name = "Laptop", Description = "fa-laptop")]
        Laptop = '\uf109',
        
        [Display(Name = "Laptop Code", Description = "fa-laptop-code")]
        LaptopCode = '\uf5fc',
        
        [Display(Name = "Laptop House", Description = "fa-laptop-house")]
        LaptopHouse = '\uf966',
        
        [Display(Name = "Laptop Medical", Description = "fa-laptop-medical")]
        LaptopMedical = '\uf812',
        
        [Display(Name = "Laravel", Description = "fa-laravel")]
        Laravel = '\uf3bd',
        
        [Display(Name = "Lastfm", Description = "fa-lastfm")]
        Lastfm = '\uf202',
        
        [Display(Name = "Lastfm Square", Description = "fa-lastfm-square")]
        LastfmSquare = '\uf203',
        
        [Display(Name = "Laugh", Description = "fa-laugh")]
        Laugh = '\uf599',
        
        [Display(Name = "Laugh Beam", Description = "fa-laugh-beam")]
        LaughBeam = '\uf59a',
        
        [Display(Name = "Laugh Squint", Description = "fa-laugh-squint")]
        LaughSquint = '\uf59b',
        
        [Display(Name = "Laugh Wink", Description = "fa-laugh-wink")]
        LaughWink = '\uf59c',
        
        [Display(Name = "Layer Group", Description = "fa-layer-group")]
        LayerGroup = '\uf5fd',
        
        [Display(Name = "Leaf", Description = "fa-leaf")]
        Leaf = '\uf06c',
        
        [Display(Name = "Leanpub", Description = "fa-leanpub")]
        Leanpub = '\uf212',
        
        [Display(Name = "Lemon", Description = "fa-lemon")]
        Lemon = '\uf094',
        
        [Display(Name = "Less", Description = "fa-less")]
        Less = '\uf41d',
        
        [Display(Name = "Less Than", Description = "fa-less-than")]
        LessThan = '\uf536',
        
        [Display(Name = "Less Than Equal", Description = "fa-less-than-equal")]
        LessThanEqual = '\uf537',
        
        [Display(Name = "Level Down Alt", Description = "fa-level-down-alt")]
        LevelDownAlt = '\uf3be',
        
        [Display(Name = "Level Up Alt", Description = "fa-level-up-alt")]
        LevelUpAlt = '\uf3bf',
        
        [Display(Name = "Life Ring", Description = "fa-life-ring")]
        LifeRing = '\uf1cd',
        
        [Display(Name = "Lightbulb", Description = "fa-lightbulb")]
        Lightbulb = '\uf0eb',
        
        [Display(Name = "Line", Description = "fa-line")]
        Line = '\uf3c0',
        
        [Display(Name = "Link", Description = "fa-link")]
        Link = '\uf0c1',
        
        [Display(Name = "Linkedin", Description = "fa-linkedin")]
        Linkedin = '\uf08c',
        
        [Display(Name = "Linkedin In", Description = "fa-linkedin-in")]
        LinkedinIn = '\uf0e1',
        
        [Display(Name = "Linode", Description = "fa-linode")]
        Linode = '\uf2b8',
        
        [Display(Name = "Linux", Description = "fa-linux")]
        Linux = '\uf17c',
        
        [Display(Name = "Lira Sign", Description = "fa-lira-sign")]
        LiraSign = '\uf195',
        
        [Display(Name = "List", Description = "fa-list")]
        List = '\uf03a',
        
        [Display(Name = "List Alt", Description = "fa-list-alt")]
        ListAlt = '\uf022',
        
        [Display(Name = "List Ol", Description = "fa-list-ol")]
        ListOl = '\uf0cb',
        
        [Display(Name = "List Ul", Description = "fa-list-ul")]
        ListUl = '\uf0ca',
        
        [Display(Name = "Location Arrow", Description = "fa-location-arrow")]
        LocationArrow = '\uf124',
        
        [Display(Name = "Lock", Description = "fa-lock")]
        Lock = '\uf023',
        
        [Display(Name = "Lock Open", Description = "fa-lock-open")]
        LockOpen = '\uf3c1',
        
        [Display(Name = "Long Arrow Alt Down", Description = "fa-long-arrow-alt-down")]
        LongArrowAltDown = '\uf309',
        
        [Display(Name = "Long Arrow Alt Left", Description = "fa-long-arrow-alt-left")]
        LongArrowAltLeft = '\uf30a',
        
        [Display(Name = "Long Arrow Alt Right", Description = "fa-long-arrow-alt-right")]
        LongArrowAltRight = '\uf30b',
        
        [Display(Name = "Long Arrow Alt Up", Description = "fa-long-arrow-alt-up")]
        LongArrowAltUp = '\uf30c',
        
        [Display(Name = "Low Vision", Description = "fa-low-vision")]
        LowVision = '\uf2a8',
        
        [Display(Name = "Luggage Cart", Description = "fa-luggage-cart")]
        LuggageCart = '\uf59d',
        
        [Display(Name = "Lungs", Description = "fa-lungs")]
        Lungs = '\uf604',
        
        [Display(Name = "Lungs Virus", Description = "fa-lungs-virus")]
        LungsVirus = '\uf967',
        
        [Display(Name = "Lyft", Description = "fa-lyft")]
        Lyft = '\uf3c3',
        
        [Display(Name = "Magento", Description = "fa-magento")]
        Magento = '\uf3c4',
        
        [Display(Name = "Magic", Description = "fa-magic")]
        Magic = '\uf0d0',
        
        [Display(Name = "Magnet", Description = "fa-magnet")]
        Magnet = '\uf076',
        
        [Display(Name = "Mail Bulk", Description = "fa-mail-bulk")]
        MailBulk = '\uf674',
        
        [Display(Name = "Mailchimp", Description = "fa-mailchimp")]
        Mailchimp = '\uf59e',
        
        [Display(Name = "Male", Description = "fa-male")]
        Male = '\uf183',
        
        [Display(Name = "Mandalorian", Description = "fa-mandalorian")]
        Mandalorian = '\uf50f',
        
        [Display(Name = "Map", Description = "fa-map")]
        Map = '\uf279',
        
        [Display(Name = "Map Marked", Description = "fa-map-marked")]
        MapMarked = '\uf59f',
        
        [Display(Name = "Map Marked Alt", Description = "fa-map-marked-alt")]
        MapMarkedAlt = '\uf5a0',
        
        [Display(Name = "Map Marker", Description = "fa-map-marker")]
        MapMarker = '\uf041',
        
        [Display(Name = "Map Marker Alt", Description = "fa-map-marker-alt")]
        MapMarkerAlt = '\uf3c5',
        
        [Display(Name = "Map Pin", Description = "fa-map-pin")]
        MapPin = '\uf276',
        
        [Display(Name = "Map Signs", Description = "fa-map-signs")]
        MapSigns = '\uf277',
        
        [Display(Name = "Markdown", Description = "fa-markdown")]
        Markdown = '\uf60f',
        
        [Display(Name = "Marker", Description = "fa-marker")]
        Marker = '\uf5a1',
        
        [Display(Name = "Mars", Description = "fa-mars")]
        Mars = '\uf222',
        
        [Display(Name = "Mars Double", Description = "fa-mars-double")]
        MarsDouble = '\uf227',
        
        [Display(Name = "Mars Stroke", Description = "fa-mars-stroke")]
        MarsStroke = '\uf229',
        
        [Display(Name = "Mars Stroke H", Description = "fa-mars-stroke-h")]
        MarsStrokeH = '\uf22b',
        
        [Display(Name = "Mars Stroke V", Description = "fa-mars-stroke-v")]
        MarsStrokeV = '\uf22a',
        
        [Display(Name = "Mask", Description = "fa-mask")]
        Mask = '\uf6fa',
        
        [Display(Name = "Mastodon", Description = "fa-mastodon")]
        Mastodon = '\uf4f6',
        
        [Display(Name = "Maxcdn", Description = "fa-maxcdn")]
        Maxcdn = '\uf136',
        
        [Display(Name = "Mdb", Description = "fa-mdb")]
        Mdb = '\uf8ca',
        
        [Display(Name = "Medal", Description = "fa-medal")]
        Medal = '\uf5a2',
        
        [Display(Name = "Medapps", Description = "fa-medapps")]
        Medapps = '\uf3c6',
        
        [Display(Name = "Medium", Description = "fa-medium")]
        Medium = '\uf23a',
        
        [Display(Name = "Medium M", Description = "fa-medium-m")]
        MediumM = '\uf3c7',
        
        [Display(Name = "Medkit", Description = "fa-medkit")]
        Medkit = '\uf0fa',
        
        [Display(Name = "Medrt", Description = "fa-medrt")]
        Medrt = '\uf3c8',
        
        [Display(Name = "Meetup", Description = "fa-meetup")]
        Meetup = '\uf2e0',
        
        [Display(Name = "Megaport", Description = "fa-megaport")]
        Megaport = '\uf5a3',
        
        [Display(Name = "Meh", Description = "fa-meh")]
        Meh = '\uf11a',
        
        [Display(Name = "Meh Blank", Description = "fa-meh-blank")]
        MehBlank = '\uf5a4',
        
        [Display(Name = "Meh Rolling Eyes", Description = "fa-meh-rolling-eyes")]
        MehRollingEyes = '\uf5a5',
        
        [Display(Name = "Memory", Description = "fa-memory")]
        Memory = '\uf538',
        
        [Display(Name = "Mendeley", Description = "fa-mendeley")]
        Mendeley = '\uf7b3',
        
        [Display(Name = "Menorah", Description = "fa-menorah")]
        Menorah = '\uf676',
        
        [Display(Name = "Mercury", Description = "fa-mercury")]
        Mercury = '\uf223',
        
        [Display(Name = "Meteor", Description = "fa-meteor")]
        Meteor = '\uf753',
        
        [Display(Name = "Microblog", Description = "fa-microblog")]
        Microblog = '\uf91a',
        
        [Display(Name = "Microchip", Description = "fa-microchip")]
        Microchip = '\uf2db',
        
        [Display(Name = "Microphone", Description = "fa-microphone")]
        Microphone = '\uf130',
        
        [Display(Name = "Microphone Alt", Description = "fa-microphone-alt")]
        MicrophoneAlt = '\uf3c9',
        
        [Display(Name = "Microphone Alt Slash", Description = "fa-microphone-alt-slash")]
        MicrophoneAltSlash = '\uf539',
        
        [Display(Name = "Microphone Slash", Description = "fa-microphone-slash")]
        MicrophoneSlash = '\uf131',
        
        [Display(Name = "Microscope", Description = "fa-microscope")]
        Microscope = '\uf610',
        
        [Display(Name = "Microsoft", Description = "fa-microsoft")]
        Microsoft = '\uf3ca',
        
        [Display(Name = "Minus", Description = "fa-minus")]
        Minus = '\uf068',
        
        [Display(Name = "Minus Circle", Description = "fa-minus-circle")]
        MinusCircle = '\uf056',
        
        [Display(Name = "Minus Square", Description = "fa-minus-square")]
        MinusSquare = '\uf146',
        
        [Display(Name = "Mitten", Description = "fa-mitten")]
        Mitten = '\uf7b5',
        
        [Display(Name = "Mix", Description = "fa-mix")]
        Mix = '\uf3cb',
        
        [Display(Name = "Mixcloud", Description = "fa-mixcloud")]
        Mixcloud = '\uf289',
        
        [Display(Name = "Mixer", Description = "fa-mixer")]
        Mixer = '\uf956',
        
        [Display(Name = "Mizuni", Description = "fa-mizuni")]
        Mizuni = '\uf3cc',
        
        [Display(Name = "Mobile", Description = "fa-mobile")]
        Mobile = '\uf10b',
        
        [Display(Name = "Mobile Alt", Description = "fa-mobile-alt")]
        MobileAlt = '\uf3cd',
        
        [Display(Name = "Modx", Description = "fa-modx")]
        Modx = '\uf285',
        
        [Display(Name = "Monero", Description = "fa-monero")]
        Monero = '\uf3d0',
        
        [Display(Name = "Money Bill", Description = "fa-money-bill")]
        MoneyBill = '\uf0d6',
        
        [Display(Name = "Money Bill Alt", Description = "fa-money-bill-alt")]
        MoneyBillAlt = '\uf3d1',
        
        [Display(Name = "Money Bill Wave", Description = "fa-money-bill-wave")]
        MoneyBillWave = '\uf53a',
        
        [Display(Name = "Money Bill Wave Alt", Description = "fa-money-bill-wave-alt")]
        MoneyBillWaveAlt = '\uf53b',
        
        [Display(Name = "Money Check", Description = "fa-money-check")]
        MoneyCheck = '\uf53c',
        
        [Display(Name = "Money Check Alt", Description = "fa-money-check-alt")]
        MoneyCheckAlt = '\uf53d',
        
        [Display(Name = "Monument", Description = "fa-monument")]
        Monument = '\uf5a6',
        
        [Display(Name = "Moon", Description = "fa-moon")]
        Moon = '\uf186',
        
        [Display(Name = "Mortar Pestle", Description = "fa-mortar-pestle")]
        MortarPestle = '\uf5a7',
        
        [Display(Name = "Mosque", Description = "fa-mosque")]
        Mosque = '\uf678',
        
        [Display(Name = "Motorcycle", Description = "fa-motorcycle")]
        Motorcycle = '\uf21c',
        
        [Display(Name = "Mountain", Description = "fa-mountain")]
        Mountain = '\uf6fc',
        
        [Display(Name = "Mouse", Description = "fa-mouse")]
        Mouse = '\uf8cc',
        
        [Display(Name = "Mouse Pointer", Description = "fa-mouse-pointer")]
        MousePointer = '\uf245',
        
        [Display(Name = "Mug Hot", Description = "fa-mug-hot")]
        MugHot = '\uf7b6',
        
        [Display(Name = "Music", Description = "fa-music")]
        Music = '\uf001',
        
        [Display(Name = "Napster", Description = "fa-napster")]
        Napster = '\uf3d2',
        
        [Display(Name = "Neos", Description = "fa-neos")]
        Neos = '\uf612',
        
        [Display(Name = "Network Wired", Description = "fa-network-wired")]
        NetworkWired = '\uf6ff',
        
        [Display(Name = "Neuter", Description = "fa-neuter")]
        Neuter = '\uf22c',
        
        [Display(Name = "Newspaper", Description = "fa-newspaper")]
        Newspaper = '\uf1ea',
        
        [Display(Name = "Nimblr", Description = "fa-nimblr")]
        Nimblr = '\uf5a8',
        
        [Display(Name = "Node", Description = "fa-node")]
        Node = '\uf419',
        
        [Display(Name = "Node Js", Description = "fa-node-js")]
        NodeJs = '\uf3d3',
        
        [Display(Name = "Not Equal", Description = "fa-not-equal")]
        NotEqual = '\uf53e',
        
        [Display(Name = "Notes Medical", Description = "fa-notes-medical")]
        NotesMedical = '\uf481',
        
        [Display(Name = "Npm", Description = "fa-npm")]
        Npm = '\uf3d4',
        
        [Display(Name = "Ns8", Description = "fa-ns8")]
        Ns8 = '\uf3d5',
        
        [Display(Name = "Nutritionix", Description = "fa-nutritionix")]
        Nutritionix = '\uf3d6',
        
        [Display(Name = "Object Group", Description = "fa-object-group")]
        ObjectGroup = '\uf247',
        
        [Display(Name = "Object Ungroup", Description = "fa-object-ungroup")]
        ObjectUngroup = '\uf248',
        
        [Display(Name = "Odnoklassniki", Description = "fa-odnoklassniki")]
        Odnoklassniki = '\uf263',
        
        [Display(Name = "Odnoklassniki Square", Description = "fa-odnoklassniki-square")]
        OdnoklassnikiSquare = '\uf264',
        
        [Display(Name = "Oil Can", Description = "fa-oil-can")]
        OilCan = '\uf613',
        
        [Display(Name = "Old Republic", Description = "fa-old-republic")]
        OldRepublic = '\uf510',
        
        [Display(Name = "Om", Description = "fa-om")]
        Om = '\uf679',
        
        [Display(Name = "Opencart", Description = "fa-opencart")]
        Opencart = '\uf23d',
        
        [Display(Name = "Openid", Description = "fa-openid")]
        Openid = '\uf19b',
        
        [Display(Name = "Opera", Description = "fa-opera")]
        Opera = '\uf26a',
        
        [Display(Name = "Optin Monster", Description = "fa-optin-monster")]
        OptinMonster = '\uf23c',
        
        [Display(Name = "Orcid", Description = "fa-orcid")]
        Orcid = '\uf8d2',
        
        [Display(Name = "Osi", Description = "fa-osi")]
        Osi = '\uf41a',
        
        [Display(Name = "Otter", Description = "fa-otter")]
        Otter = '\uf700',
        
        [Display(Name = "Outdent", Description = "fa-outdent")]
        Outdent = '\uf03b',
        
        [Display(Name = "Page4", Description = "fa-page4")]
        Page4 = '\uf3d7',
        
        [Display(Name = "Pagelines", Description = "fa-pagelines")]
        Pagelines = '\uf18c',
        
        [Display(Name = "Pager", Description = "fa-pager")]
        Pager = '\uf815',
        
        [Display(Name = "Paint Brush", Description = "fa-paint-brush")]
        PaintBrush = '\uf1fc',
        
        [Display(Name = "Paint Roller", Description = "fa-paint-roller")]
        PaintRoller = '\uf5aa',
        
        [Display(Name = "Palette", Description = "fa-palette")]
        Palette = '\uf53f',
        
        [Display(Name = "Palfed", Description = "fa-palfed")]
        Palfed = '\uf3d8',
        
        [Display(Name = "Pallet", Description = "fa-pallet")]
        Pallet = '\uf482',
        
        [Display(Name = "Paper Plane", Description = "fa-paper-plane")]
        PaperPlane = '\uf1d8',
        
        [Display(Name = "Paperclip", Description = "fa-paperclip")]
        Paperclip = '\uf0c6',
        
        [Display(Name = "Parachute Box", Description = "fa-parachute-box")]
        ParachuteBox = '\uf4cd',
        
        [Display(Name = "Paragraph", Description = "fa-paragraph")]
        Paragraph = '\uf1dd',
        
        [Display(Name = "Parking", Description = "fa-parking")]
        Parking = '\uf540',
        
        [Display(Name = "Passport", Description = "fa-passport")]
        Passport = '\uf5ab',
        
        [Display(Name = "Pastafarianism", Description = "fa-pastafarianism")]
        Pastafarianism = '\uf67b',
        
        [Display(Name = "Paste", Description = "fa-paste")]
        Paste = '\uf0ea',
        
        [Display(Name = "Patreon", Description = "fa-patreon")]
        Patreon = '\uf3d9',
        
        [Display(Name = "Pause", Description = "fa-pause")]
        Pause = '\uf04c',
        
        [Display(Name = "Pause Circle", Description = "fa-pause-circle")]
        PauseCircle = '\uf28b',
        
        [Display(Name = "Paw", Description = "fa-paw")]
        Paw = '\uf1b0',
        
        [Display(Name = "Paypal", Description = "fa-paypal")]
        Paypal = '\uf1ed',
        
        [Display(Name = "Peace", Description = "fa-peace")]
        Peace = '\uf67c',
        
        [Display(Name = "Pen", Description = "fa-pen")]
        Pen = '\uf304',
        
        [Display(Name = "Pen Alt", Description = "fa-pen-alt")]
        PenAlt = '\uf305',
        
        [Display(Name = "Pen Fancy", Description = "fa-pen-fancy")]
        PenFancy = '\uf5ac',
        
        [Display(Name = "Pen Nib", Description = "fa-pen-nib")]
        PenNib = '\uf5ad',
        
        [Display(Name = "Pen Square", Description = "fa-pen-square")]
        PenSquare = '\uf14b',
        
        [Display(Name = "Pencil Alt", Description = "fa-pencil-alt")]
        PencilAlt = '\uf303',
        
        [Display(Name = "Pencil Ruler", Description = "fa-pencil-ruler")]
        PencilRuler = '\uf5ae',
        
        [Display(Name = "Penny Arcade", Description = "fa-penny-arcade")]
        PennyArcade = '\uf704',
        
        [Display(Name = "People Arrows", Description = "fa-people-arrows")]
        PeopleArrows = '\uf968',
        
        [Display(Name = "People Carry", Description = "fa-people-carry")]
        PeopleCarry = '\uf4ce',
        
        [Display(Name = "Pepper Hot", Description = "fa-pepper-hot")]
        PepperHot = '\uf816',
        
        [Display(Name = "Percent", Description = "fa-percent")]
        Percent = '\uf295',
        
        [Display(Name = "Percentage", Description = "fa-percentage")]
        Percentage = '\uf541',
        
        [Display(Name = "Periscope", Description = "fa-periscope")]
        Periscope = '\uf3da',
        
        [Display(Name = "Person Booth", Description = "fa-person-booth")]
        PersonBooth = '\uf756',
        
        [Display(Name = "Phabricator", Description = "fa-phabricator")]
        Phabricator = '\uf3db',
        
        [Display(Name = "Phoenix Framework", Description = "fa-phoenix-framework")]
        PhoenixFramework = '\uf3dc',
        
        [Display(Name = "Phoenix Squadron", Description = "fa-phoenix-squadron")]
        PhoenixSquadron = '\uf511',
        
        [Display(Name = "Phone", Description = "fa-phone")]
        Phone = '\uf095',
        
        [Display(Name = "Phone Alt", Description = "fa-phone-alt")]
        PhoneAlt = '\uf879',
        
        [Display(Name = "Phone Slash", Description = "fa-phone-slash")]
        PhoneSlash = '\uf3dd',
        
        [Display(Name = "Phone Square", Description = "fa-phone-square")]
        PhoneSquare = '\uf098',
        
        [Display(Name = "Phone Square Alt", Description = "fa-phone-square-alt")]
        PhoneSquareAlt = '\uf87b',
        
        [Display(Name = "Phone Volume", Description = "fa-phone-volume")]
        PhoneVolume = '\uf2a0',
        
        [Display(Name = "Photo Video", Description = "fa-photo-video")]
        PhotoVideo = '\uf87c',
        
        [Display(Name = "Php", Description = "fa-php")]
        Php = '\uf457',
        
        [Display(Name = "Pied Piper", Description = "fa-pied-piper")]
        PiedPiper = '\uf2ae',
        
        [Display(Name = "Pied Piper Alt", Description = "fa-pied-piper-alt")]
        PiedPiperAlt = '\uf1a8',
        
        [Display(Name = "Pied Piper Hat", Description = "fa-pied-piper-hat")]
        PiedPiperHat = '\uf4e5',
        
        [Display(Name = "Pied Piper Pp", Description = "fa-pied-piper-pp")]
        PiedPiperPp = '\uf1a7',
        
        [Display(Name = "Pied Piper Square", Description = "fa-pied-piper-square")]
        PiedPiperSquare = '\uf91e',
        
        [Display(Name = "Piggy Bank", Description = "fa-piggy-bank")]
        PiggyBank = '\uf4d3',
        
        [Display(Name = "Pills", Description = "fa-pills")]
        Pills = '\uf484',
        
        [Display(Name = "Pinterest", Description = "fa-pinterest")]
        Pinterest = '\uf0d2',
        
        [Display(Name = "Pinterest P", Description = "fa-pinterest-p")]
        PinterestP = '\uf231',
        
        [Display(Name = "Pinterest Square", Description = "fa-pinterest-square")]
        PinterestSquare = '\uf0d3',
        
        [Display(Name = "Pizza Slice", Description = "fa-pizza-slice")]
        PizzaSlice = '\uf818',
        
        [Display(Name = "Place Of Worship", Description = "fa-place-of-worship")]
        PlaceOfWorship = '\uf67f',
        
        [Display(Name = "Plane", Description = "fa-plane")]
        Plane = '\uf072',
        
        [Display(Name = "Plane Arrival", Description = "fa-plane-arrival")]
        PlaneArrival = '\uf5af',
        
        [Display(Name = "Plane Departure", Description = "fa-plane-departure")]
        PlaneDeparture = '\uf5b0',
        
        [Display(Name = "Plane Slash", Description = "fa-plane-slash")]
        PlaneSlash = '\uf969',
        
        [Display(Name = "Play", Description = "fa-play")]
        Play = '\uf04b',
        
        [Display(Name = "Play Circle", Description = "fa-play-circle")]
        PlayCircle = '\uf144',
        
        [Display(Name = "Playstation", Description = "fa-playstation")]
        Playstation = '\uf3df',
        
        [Display(Name = "Plug", Description = "fa-plug")]
        Plug = '\uf1e6',
        
        [Display(Name = "Plus", Description = "fa-plus")]
        Plus = '\uf067',
        
        [Display(Name = "Plus Circle", Description = "fa-plus-circle")]
        PlusCircle = '\uf055',
        
        [Display(Name = "Plus Square", Description = "fa-plus-square")]
        PlusSquare = '\uf0fe',
        
        [Display(Name = "Podcast", Description = "fa-podcast")]
        Podcast = '\uf2ce',
        
        [Display(Name = "Poll", Description = "fa-poll")]
        Poll = '\uf681',
        
        [Display(Name = "Poll H", Description = "fa-poll-h")]
        PollH = '\uf682',
        
        [Display(Name = "Poo", Description = "fa-poo")]
        Poo = '\uf2fe',
        
        [Display(Name = "Poo Storm", Description = "fa-poo-storm")]
        PooStorm = '\uf75a',
        
        [Display(Name = "Poop", Description = "fa-poop")]
        Poop = '\uf619',
        
        [Display(Name = "Portrait", Description = "fa-portrait")]
        Portrait = '\uf3e0',
        
        [Display(Name = "Pound Sign", Description = "fa-pound-sign")]
        PoundSign = '\uf154',
        
        [Display(Name = "Power Off", Description = "fa-power-off")]
        PowerOff = '\uf011',
        
        [Display(Name = "Pray", Description = "fa-pray")]
        Pray = '\uf683',
        
        [Display(Name = "Praying Hands", Description = "fa-praying-hands")]
        PrayingHands = '\uf684',
        
        [Display(Name = "Prescription", Description = "fa-prescription")]
        Prescription = '\uf5b1',
        
        [Display(Name = "Prescription Bottle", Description = "fa-prescription-bottle")]
        PrescriptionBottle = '\uf485',
        
        [Display(Name = "Prescription Bottle Alt", Description = "fa-prescription-bottle-alt")]
        PrescriptionBottleAlt = '\uf486',
        
        [Display(Name = "Print", Description = "fa-print")]
        Print = '\uf02f',
        
        [Display(Name = "Procedures", Description = "fa-procedures")]
        Procedures = '\uf487',
        
        [Display(Name = "Product Hunt", Description = "fa-product-hunt")]
        ProductHunt = '\uf288',
        
        [Display(Name = "Project Diagram", Description = "fa-project-diagram")]
        ProjectDiagram = '\uf542',
        
        [Display(Name = "Pump Medical", Description = "fa-pump-medical")]
        PumpMedical = '\uf96a',
        
        [Display(Name = "Pump Soap", Description = "fa-pump-soap")]
        PumpSoap = '\uf96b',
        
        [Display(Name = "Pushed", Description = "fa-pushed")]
        Pushed = '\uf3e1',
        
        [Display(Name = "Puzzle Piece", Description = "fa-puzzle-piece")]
        PuzzlePiece = '\uf12e',
        
        [Display(Name = "Python", Description = "fa-python")]
        Python = '\uf3e2',
        
        [Display(Name = "Qq", Description = "fa-qq")]
        Qq = '\uf1d6',
        
        [Display(Name = "Qrcode", Description = "fa-qrcode")]
        Qrcode = '\uf029',
        
        [Display(Name = "Question", Description = "fa-question")]
        Question = '\uf128',
        
        [Display(Name = "Question Circle", Description = "fa-question-circle")]
        QuestionCircle = '\uf059',
        
        [Display(Name = "Quidditch", Description = "fa-quidditch")]
        Quidditch = '\uf458',
        
        [Display(Name = "Quinscape", Description = "fa-quinscape")]
        Quinscape = '\uf459',
        
        [Display(Name = "Quora", Description = "fa-quora")]
        Quora = '\uf2c4',
        
        [Display(Name = "Quote Left", Description = "fa-quote-left")]
        QuoteLeft = '\uf10d',
        
        [Display(Name = "Quote Right", Description = "fa-quote-right")]
        QuoteRight = '\uf10e',
        
        [Display(Name = "Quran", Description = "fa-quran")]
        Quran = '\uf687',
        
        [Display(Name = "R Project", Description = "fa-r-project")]
        RProject = '\uf4f7',
        
        [Display(Name = "Radiation", Description = "fa-radiation")]
        Radiation = '\uf7b9',
        
        [Display(Name = "Radiation Alt", Description = "fa-radiation-alt")]
        RadiationAlt = '\uf7ba',
        
        [Display(Name = "Rainbow", Description = "fa-rainbow")]
        Rainbow = '\uf75b',
        
        [Display(Name = "Random", Description = "fa-random")]
        Random = '\uf074',
        
        [Display(Name = "Raspberry Pi", Description = "fa-raspberry-pi")]
        RaspberryPi = '\uf7bb',
        
        [Display(Name = "Ravelry", Description = "fa-ravelry")]
        Ravelry = '\uf2d9',
        
        [Display(Name = "React", Description = "fa-react")]
        React = '\uf41b',
        
        [Display(Name = "Reacteurope", Description = "fa-reacteurope")]
        Reacteurope = '\uf75d',
        
        [Display(Name = "Readme", Description = "fa-readme")]
        Readme = '\uf4d5',
        
        [Display(Name = "Rebel", Description = "fa-rebel")]
        Rebel = '\uf1d0',
        
        [Display(Name = "Receipt", Description = "fa-receipt")]
        Receipt = '\uf543',
        
        [Display(Name = "Record Vinyl", Description = "fa-record-vinyl")]
        RecordVinyl = '\uf8d9',
        
        [Display(Name = "Recycle", Description = "fa-recycle")]
        Recycle = '\uf1b8',
        
        [Display(Name = "Red River", Description = "fa-red-river")]
        RedRiver = '\uf3e3',
        
        [Display(Name = "Reddit", Description = "fa-reddit")]
        Reddit = '\uf1a1',
        
        [Display(Name = "Reddit Alien", Description = "fa-reddit-alien")]
        RedditAlien = '\uf281',
        
        [Display(Name = "Reddit Square", Description = "fa-reddit-square")]
        RedditSquare = '\uf1a2',
        
        [Display(Name = "Redhat", Description = "fa-redhat")]
        Redhat = '\uf7bc',
        
        [Display(Name = "Redo", Description = "fa-redo")]
        Redo = '\uf01e',
        
        [Display(Name = "Redo Alt", Description = "fa-redo-alt")]
        RedoAlt = '\uf2f9',
        
        [Display(Name = "Registered", Description = "fa-registered")]
        Registered = '\uf25d',
        
        [Display(Name = "Remove Format", Description = "fa-remove-format")]
        RemoveFormat = '\uf87d',
        
        [Display(Name = "Renren", Description = "fa-renren")]
        Renren = '\uf18b',
        
        [Display(Name = "Reply", Description = "fa-reply")]
        Reply = '\uf3e5',
        
        [Display(Name = "Reply All", Description = "fa-reply-all")]
        ReplyAll = '\uf122',
        
        [Display(Name = "Replyd", Description = "fa-replyd")]
        Replyd = '\uf3e6',
        
        [Display(Name = "Republican", Description = "fa-republican")]
        Republican = '\uf75e',
        
        [Display(Name = "Researchgate", Description = "fa-researchgate")]
        Researchgate = '\uf4f8',
        
        [Display(Name = "Resolving", Description = "fa-resolving")]
        Resolving = '\uf3e7',
        
        [Display(Name = "Restroom", Description = "fa-restroom")]
        Restroom = '\uf7bd',
        
        [Display(Name = "Retweet", Description = "fa-retweet")]
        Retweet = '\uf079',
        
        [Display(Name = "Rev", Description = "fa-rev")]
        Rev = '\uf5b2',
        
        [Display(Name = "Ribbon", Description = "fa-ribbon")]
        Ribbon = '\uf4d6',
        
        [Display(Name = "Ring", Description = "fa-ring")]
        Ring = '\uf70b',
        
        [Display(Name = "Road", Description = "fa-road")]
        Road = '\uf018',
        
        [Display(Name = "Robot", Description = "fa-robot")]
        Robot = '\uf544',
        
        [Display(Name = "Rocket", Description = "fa-rocket")]
        Rocket = '\uf135',
        
        [Display(Name = "Rocketchat", Description = "fa-rocketchat")]
        Rocketchat = '\uf3e8',
        
        [Display(Name = "Rockrms", Description = "fa-rockrms")]
        Rockrms = '\uf3e9',
        
        [Display(Name = "Route", Description = "fa-route")]
        Route = '\uf4d7',
        
        [Display(Name = "Rss", Description = "fa-rss")]
        Rss = '\uf09e',
        
        [Display(Name = "Rss Square", Description = "fa-rss-square")]
        RssSquare = '\uf143',
        
        [Display(Name = "Ruble Sign", Description = "fa-ruble-sign")]
        RubleSign = '\uf158',
        
        [Display(Name = "Ruler", Description = "fa-ruler")]
        Ruler = '\uf545',
        
        [Display(Name = "Ruler Combined", Description = "fa-ruler-combined")]
        RulerCombined = '\uf546',
        
        [Display(Name = "Ruler Horizontal", Description = "fa-ruler-horizontal")]
        RulerHorizontal = '\uf547',
        
        [Display(Name = "Ruler Vertical", Description = "fa-ruler-vertical")]
        RulerVertical = '\uf548',
        
        [Display(Name = "Running", Description = "fa-running")]
        Running = '\uf70c',
        
        [Display(Name = "Rupee Sign", Description = "fa-rupee-sign")]
        RupeeSign = '\uf156',
        
        [Display(Name = "Sad Cry", Description = "fa-sad-cry")]
        SadCry = '\uf5b3',
        
        [Display(Name = "Sad Tear", Description = "fa-sad-tear")]
        SadTear = '\uf5b4',
        
        [Display(Name = "Safari", Description = "fa-safari")]
        Safari = '\uf267',
        
        [Display(Name = "Salesforce", Description = "fa-salesforce")]
        Salesforce = '\uf83b',
        
        [Display(Name = "Sass", Description = "fa-sass")]
        Sass = '\uf41e',
        
        [Display(Name = "Satellite", Description = "fa-satellite")]
        Satellite = '\uf7bf',
        
        [Display(Name = "Satellite Dish", Description = "fa-satellite-dish")]
        SatelliteDish = '\uf7c0',
        
        [Display(Name = "Save", Description = "fa-save")]
        Save = '\uf0c7',
        
        [Display(Name = "Schlix", Description = "fa-schlix")]
        Schlix = '\uf3ea',
        
        [Display(Name = "School", Description = "fa-school")]
        School = '\uf549',
        
        [Display(Name = "Screwdriver", Description = "fa-screwdriver")]
        Screwdriver = '\uf54a',
        
        [Display(Name = "Scribd", Description = "fa-scribd")]
        Scribd = '\uf28a',
        
        [Display(Name = "Scroll", Description = "fa-scroll")]
        Scroll = '\uf70e',
        
        [Display(Name = "Sd Card", Description = "fa-sd-card")]
        SdCard = '\uf7c2',
        
        [Display(Name = "Search", Description = "fa-search")]
        Search = '\uf002',
        
        [Display(Name = "Search Dollar", Description = "fa-search-dollar")]
        SearchDollar = '\uf688',
        
        [Display(Name = "Search Location", Description = "fa-search-location")]
        SearchLocation = '\uf689',
        
        [Display(Name = "Search Minus", Description = "fa-search-minus")]
        SearchMinus = '\uf010',
        
        [Display(Name = "Search Plus", Description = "fa-search-plus")]
        SearchPlus = '\uf00e',
        
        [Display(Name = "Searchengin", Description = "fa-searchengin")]
        Searchengin = '\uf3eb',
        
        [Display(Name = "Seedling", Description = "fa-seedling")]
        Seedling = '\uf4d8',
        
        [Display(Name = "Sellcast", Description = "fa-sellcast")]
        Sellcast = '\uf2da',
        
        [Display(Name = "Sellsy", Description = "fa-sellsy")]
        Sellsy = '\uf213',
        
        [Display(Name = "Server", Description = "fa-server")]
        Server = '\uf233',
        
        [Display(Name = "Servicestack", Description = "fa-servicestack")]
        Servicestack = '\uf3ec',
        
        [Display(Name = "Shapes", Description = "fa-shapes")]
        Shapes = '\uf61f',
        
        [Display(Name = "Share", Description = "fa-share")]
        Share = '\uf064',
        
        [Display(Name = "Share Alt", Description = "fa-share-alt")]
        ShareAlt = '\uf1e0',
        
        [Display(Name = "Share Alt Square", Description = "fa-share-alt-square")]
        ShareAltSquare = '\uf1e1',
        
        [Display(Name = "Share Square", Description = "fa-share-square")]
        ShareSquare = '\uf14d',
        
        [Display(Name = "Shekel Sign", Description = "fa-shekel-sign")]
        ShekelSign = '\uf20b',
        
        [Display(Name = "Shield Alt", Description = "fa-shield-alt")]
        ShieldAlt = '\uf3ed',
        
        [Display(Name = "Shield Virus", Description = "fa-shield-virus")]
        ShieldVirus = '\uf96c',
        
        [Display(Name = "Ship", Description = "fa-ship")]
        Ship = '\uf21a',
        
        [Display(Name = "Shipping Fast", Description = "fa-shipping-fast")]
        ShippingFast = '\uf48b',
        
        [Display(Name = "Shirtsinbulk", Description = "fa-shirtsinbulk")]
        Shirtsinbulk = '\uf214',
        
        [Display(Name = "Shoe Prints", Description = "fa-shoe-prints")]
        ShoePrints = '\uf54b',
        
        [Display(Name = "Shopify", Description = "fa-shopify")]
        Shopify = '\uf957',
        
        [Display(Name = "Shopping Bag", Description = "fa-shopping-bag")]
        ShoppingBag = '\uf290',
        
        [Display(Name = "Shopping Basket", Description = "fa-shopping-basket")]
        ShoppingBasket = '\uf291',
        
        [Display(Name = "Shopping Cart", Description = "fa-shopping-cart")]
        ShoppingCart = '\uf07a',
        
        [Display(Name = "Shopware", Description = "fa-shopware")]
        Shopware = '\uf5b5',
        
        [Display(Name = "Shower", Description = "fa-shower")]
        Shower = '\uf2cc',
        
        [Display(Name = "Shuttle Van", Description = "fa-shuttle-van")]
        ShuttleVan = '\uf5b6',
        
        [Display(Name = "Sign", Description = "fa-sign")]
        Sign = '\uf4d9',
        
        [Display(Name = "Sign In Alt", Description = "fa-sign-in-alt")]
        SignInAlt = '\uf2f6',
        
        [Display(Name = "Sign Language", Description = "fa-sign-language")]
        SignLanguage = '\uf2a7',
        
        [Display(Name = "Sign Out Alt", Description = "fa-sign-out-alt")]
        SignOutAlt = '\uf2f5',
        
        [Display(Name = "Signal", Description = "fa-signal")]
        Signal = '\uf012',
        
        [Display(Name = "Signature", Description = "fa-signature")]
        Signature = '\uf5b7',
        
        [Display(Name = "Sim Card", Description = "fa-sim-card")]
        SimCard = '\uf7c4',
        
        [Display(Name = "Simplybuilt", Description = "fa-simplybuilt")]
        Simplybuilt = '\uf215',
        
        [Display(Name = "Sistrix", Description = "fa-sistrix")]
        Sistrix = '\uf3ee',
        
        [Display(Name = "Sitemap", Description = "fa-sitemap")]
        Sitemap = '\uf0e8',
        
        [Display(Name = "Sith", Description = "fa-sith")]
        Sith = '\uf512',
        
        [Display(Name = "Skating", Description = "fa-skating")]
        Skating = '\uf7c5',
        
        [Display(Name = "Sketch", Description = "fa-sketch")]
        Sketch = '\uf7c6',
        
        [Display(Name = "Skiing", Description = "fa-skiing")]
        Skiing = '\uf7c9',
        
        [Display(Name = "Skiing Nordic", Description = "fa-skiing-nordic")]
        SkiingNordic = '\uf7ca',
        
        [Display(Name = "Skull", Description = "fa-skull")]
        Skull = '\uf54c',
        
        [Display(Name = "Skull Crossbones", Description = "fa-skull-crossbones")]
        SkullCrossbones = '\uf714',
        
        [Display(Name = "Skyatlas", Description = "fa-skyatlas")]
        Skyatlas = '\uf216',
        
        [Display(Name = "Skype", Description = "fa-skype")]
        Skype = '\uf17e',
        
        [Display(Name = "Slack", Description = "fa-slack")]
        Slack = '\uf198',
        
        [Display(Name = "Slack Hash", Description = "fa-slack-hash")]
        SlackHash = '\uf3ef',
        
        [Display(Name = "Slash", Description = "fa-slash")]
        Slash = '\uf715',
        
        [Display(Name = "Sleigh", Description = "fa-sleigh")]
        Sleigh = '\uf7cc',
        
        [Display(Name = "Sliders H", Description = "fa-sliders-h")]
        SlidersH = '\uf1de',
        
        [Display(Name = "Slideshare", Description = "fa-slideshare")]
        Slideshare = '\uf1e7',
        
        [Display(Name = "Smile", Description = "fa-smile")]
        Smile = '\uf118',
        
        [Display(Name = "Smile Beam", Description = "fa-smile-beam")]
        SmileBeam = '\uf5b8',
        
        [Display(Name = "Smile Wink", Description = "fa-smile-wink")]
        SmileWink = '\uf4da',
        
        [Display(Name = "Smog", Description = "fa-smog")]
        Smog = '\uf75f',
        
        [Display(Name = "Smoking", Description = "fa-smoking")]
        Smoking = '\uf48d',
        
        [Display(Name = "Smoking Ban", Description = "fa-smoking-ban")]
        SmokingBan = '\uf54d',
        
        [Display(Name = "Sms", Description = "fa-sms")]
        Sms = '\uf7cd',
        
        [Display(Name = "Snapchat", Description = "fa-snapchat")]
        Snapchat = '\uf2ab',
        
        [Display(Name = "Snapchat Ghost", Description = "fa-snapchat-ghost")]
        SnapchatGhost = '\uf2ac',
        
        [Display(Name = "Snapchat Square", Description = "fa-snapchat-square")]
        SnapchatSquare = '\uf2ad',
        
        [Display(Name = "Snowboarding", Description = "fa-snowboarding")]
        Snowboarding = '\uf7ce',
        
        [Display(Name = "Snowflake", Description = "fa-snowflake")]
        Snowflake = '\uf2dc',
        
        [Display(Name = "Snowman", Description = "fa-snowman")]
        Snowman = '\uf7d0',
        
        [Display(Name = "Snowplow", Description = "fa-snowplow")]
        Snowplow = '\uf7d2',
        
        [Display(Name = "Soap", Description = "fa-soap")]
        Soap = '\uf96e',
        
        [Display(Name = "Socks", Description = "fa-socks")]
        Socks = '\uf696',
        
        [Display(Name = "Solar Panel", Description = "fa-solar-panel")]
        SolarPanel = '\uf5ba',
        
        [Display(Name = "Sort", Description = "fa-sort")]
        Sort = '\uf0dc',
        
        [Display(Name = "Sort Alpha Down", Description = "fa-sort-alpha-down")]
        SortAlphaDown = '\uf15d',
        
        [Display(Name = "Sort Alpha Down Alt", Description = "fa-sort-alpha-down-alt")]
        SortAlphaDownAlt = '\uf881',
        
        [Display(Name = "Sort Alpha Up", Description = "fa-sort-alpha-up")]
        SortAlphaUp = '\uf15e',
        
        [Display(Name = "Sort Alpha Up Alt", Description = "fa-sort-alpha-up-alt")]
        SortAlphaUpAlt = '\uf882',
        
        [Display(Name = "Sort Amount Down", Description = "fa-sort-amount-down")]
        SortAmountDown = '\uf160',
        
        [Display(Name = "Sort Amount Down Alt", Description = "fa-sort-amount-down-alt")]
        SortAmountDownAlt = '\uf884',
        
        [Display(Name = "Sort Amount Up", Description = "fa-sort-amount-up")]
        SortAmountUp = '\uf161',
        
        [Display(Name = "Sort Amount Up Alt", Description = "fa-sort-amount-up-alt")]
        SortAmountUpAlt = '\uf885',
        
        [Display(Name = "Sort Down", Description = "fa-sort-down")]
        SortDown = '\uf0dd',
        
        [Display(Name = "Sort Numeric Down", Description = "fa-sort-numeric-down")]
        SortNumericDown = '\uf162',
        
        [Display(Name = "Sort Numeric Down Alt", Description = "fa-sort-numeric-down-alt")]
        SortNumericDownAlt = '\uf886',
        
        [Display(Name = "Sort Numeric Up", Description = "fa-sort-numeric-up")]
        SortNumericUp = '\uf163',
        
        [Display(Name = "Sort Numeric Up Alt", Description = "fa-sort-numeric-up-alt")]
        SortNumericUpAlt = '\uf887',
        
        [Display(Name = "Sort Up", Description = "fa-sort-up")]
        SortUp = '\uf0de',
        
        [Display(Name = "Soundcloud", Description = "fa-soundcloud")]
        Soundcloud = '\uf1be',
        
        [Display(Name = "Sourcetree", Description = "fa-sourcetree")]
        Sourcetree = '\uf7d3',
        
        [Display(Name = "Spa", Description = "fa-spa")]
        Spa = '\uf5bb',
        
        [Display(Name = "Space Shuttle", Description = "fa-space-shuttle")]
        SpaceShuttle = '\uf197',
        
        [Display(Name = "Speakap", Description = "fa-speakap")]
        Speakap = '\uf3f3',
        
        [Display(Name = "Speaker Deck", Description = "fa-speaker-deck")]
        SpeakerDeck = '\uf83c',
        
        [Display(Name = "Spell Check", Description = "fa-spell-check")]
        SpellCheck = '\uf891',
        
        [Display(Name = "Spider", Description = "fa-spider")]
        Spider = '\uf717',
        
        [Display(Name = "Spinner", Description = "fa-spinner")]
        Spinner = '\uf110',
        
        [Display(Name = "Splotch", Description = "fa-splotch")]
        Splotch = '\uf5bc',
        
        [Display(Name = "Spotify", Description = "fa-spotify")]
        Spotify = '\uf1bc',
        
        [Display(Name = "Spray Can", Description = "fa-spray-can")]
        SprayCan = '\uf5bd',
        
        [Display(Name = "Square", Description = "fa-square")]
        Square = '\uf0c8',
        
        [Display(Name = "Square Full", Description = "fa-square-full")]
        SquareFull = '\uf45c',
        
        [Display(Name = "Square Root Alt", Description = "fa-square-root-alt")]
        SquareRootAlt = '\uf698',
        
        [Display(Name = "Squarespace", Description = "fa-squarespace")]
        Squarespace = '\uf5be',
        
        [Display(Name = "Stack Exchange", Description = "fa-stack-exchange")]
        StackExchange = '\uf18d',
        
        [Display(Name = "Stack Overflow", Description = "fa-stack-overflow")]
        StackOverflow = '\uf16c',
        
        [Display(Name = "Stackpath", Description = "fa-stackpath")]
        Stackpath = '\uf842',
        
        [Display(Name = "Stamp", Description = "fa-stamp")]
        Stamp = '\uf5bf',
        
        [Display(Name = "Star", Description = "fa-star")]
        Star = '\uf005',
        
        [Display(Name = "Star And Crescent", Description = "fa-star-and-crescent")]
        StarAndCrescent = '\uf699',
        
        [Display(Name = "Star Half", Description = "fa-star-half")]
        StarHalf = '\uf089',
        
        [Display(Name = "Star Half Alt", Description = "fa-star-half-alt")]
        StarHalfAlt = '\uf5c0',
        
        [Display(Name = "Star Of David", Description = "fa-star-of-david")]
        StarOfDavid = '\uf69a',
        
        [Display(Name = "Star Of Life", Description = "fa-star-of-life")]
        StarOfLife = '\uf621',
        
        [Display(Name = "Staylinked", Description = "fa-staylinked")]
        Staylinked = '\uf3f5',
        
        [Display(Name = "Steam", Description = "fa-steam")]
        Steam = '\uf1b6',
        
        [Display(Name = "Steam Square", Description = "fa-steam-square")]
        SteamSquare = '\uf1b7',
        
        [Display(Name = "Steam Symbol", Description = "fa-steam-symbol")]
        SteamSymbol = '\uf3f6',
        
        [Display(Name = "Step Backward", Description = "fa-step-backward")]
        StepBackward = '\uf048',
        
        [Display(Name = "Step Forward", Description = "fa-step-forward")]
        StepForward = '\uf051',
        
        [Display(Name = "Stethoscope", Description = "fa-stethoscope")]
        Stethoscope = '\uf0f1',
        
        [Display(Name = "Sticker Mule", Description = "fa-sticker-mule")]
        StickerMule = '\uf3f7',
        
        [Display(Name = "Sticky Note", Description = "fa-sticky-note")]
        StickyNote = '\uf249',
        
        [Display(Name = "Stop", Description = "fa-stop")]
        Stop = '\uf04d',
        
        [Display(Name = "Stop Circle", Description = "fa-stop-circle")]
        StopCircle = '\uf28d',
        
        [Display(Name = "Stopwatch", Description = "fa-stopwatch")]
        Stopwatch = '\uf2f2',
        
        [Display(Name = "Stopwatch 20", Description = "fa-stopwatch-20")]
        Stopwatch20 = '\uf96f',
        
        [Display(Name = "Store", Description = "fa-store")]
        Store = '\uf54e',
        
        [Display(Name = "Store Alt", Description = "fa-store-alt")]
        StoreAlt = '\uf54f',
        
        [Display(Name = "Store Alt Slash", Description = "fa-store-alt-slash")]
        StoreAltSlash = '\uf970',
        
        [Display(Name = "Store Slash", Description = "fa-store-slash")]
        StoreSlash = '\uf971',
        
        [Display(Name = "Strava", Description = "fa-strava")]
        Strava = '\uf428',
        
        [Display(Name = "Stream", Description = "fa-stream")]
        Stream = '\uf550',
        
        [Display(Name = "Street View", Description = "fa-street-view")]
        StreetView = '\uf21d',
        
        [Display(Name = "Strikethrough", Description = "fa-strikethrough")]
        Strikethrough = '\uf0cc',
        
        [Display(Name = "Stripe", Description = "fa-stripe")]
        Stripe = '\uf429',
        
        [Display(Name = "Stripe S", Description = "fa-stripe-s")]
        StripeS = '\uf42a',
        
        [Display(Name = "Stroopwafel", Description = "fa-stroopwafel")]
        Stroopwafel = '\uf551',
        
        [Display(Name = "Studiovinari", Description = "fa-studiovinari")]
        Studiovinari = '\uf3f8',
        
        [Display(Name = "Stumbleupon", Description = "fa-stumbleupon")]
        Stumbleupon = '\uf1a4',
        
        [Display(Name = "Stumbleupon Circle", Description = "fa-stumbleupon-circle")]
        StumbleuponCircle = '\uf1a3',
        
        [Display(Name = "Subscript", Description = "fa-subscript")]
        Subscript = '\uf12c',
        
        [Display(Name = "Subway", Description = "fa-subway")]
        Subway = '\uf239',
        
        [Display(Name = "Suitcase", Description = "fa-suitcase")]
        Suitcase = '\uf0f2',
        
        [Display(Name = "Suitcase Rolling", Description = "fa-suitcase-rolling")]
        SuitcaseRolling = '\uf5c1',
        
        [Display(Name = "Sun", Description = "fa-sun")]
        Sun = '\uf185',
        
        [Display(Name = "Superpowers", Description = "fa-superpowers")]
        Superpowers = '\uf2dd',
        
        [Display(Name = "Superscript", Description = "fa-superscript")]
        Superscript = '\uf12b',
        
        [Display(Name = "Supple", Description = "fa-supple")]
        Supple = '\uf3f9',
        
        [Display(Name = "Surprise", Description = "fa-surprise")]
        Surprise = '\uf5c2',
        
        [Display(Name = "Suse", Description = "fa-suse")]
        Suse = '\uf7d6',
        
        [Display(Name = "Swatchbook", Description = "fa-swatchbook")]
        Swatchbook = '\uf5c3',
        
        [Display(Name = "Swift", Description = "fa-swift")]
        Swift = '\uf8e1',
        
        [Display(Name = "Swimmer", Description = "fa-swimmer")]
        Swimmer = '\uf5c4',
        
        [Display(Name = "Swimming Pool", Description = "fa-swimming-pool")]
        SwimmingPool = '\uf5c5',
        
        [Display(Name = "Symfony", Description = "fa-symfony")]
        Symfony = '\uf83d',
        
        [Display(Name = "Synagogue", Description = "fa-synagogue")]
        Synagogue = '\uf69b',
        
        [Display(Name = "Sync", Description = "fa-sync")]
        Sync = '\uf021',
        
        [Display(Name = "Sync Alt", Description = "fa-sync-alt")]
        SyncAlt = '\uf2f1',
        
        [Display(Name = "Syringe", Description = "fa-syringe")]
        Syringe = '\uf48e',
        
        [Display(Name = "Table", Description = "fa-table")]
        Table = '\uf0ce',
        
        [Display(Name = "Table Tennis", Description = "fa-table-tennis")]
        TableTennis = '\uf45d',
        
        [Display(Name = "Tablet", Description = "fa-tablet")]
        Tablet = '\uf10a',
        
        [Display(Name = "Tablet Alt", Description = "fa-tablet-alt")]
        TabletAlt = '\uf3fa',
        
        [Display(Name = "Tablets", Description = "fa-tablets")]
        Tablets = '\uf490',
        
        [Display(Name = "Tachometer Alt", Description = "fa-tachometer-alt")]
        TachometerAlt = '\uf3fd',
        
        [Display(Name = "Tag", Description = "fa-tag")]
        Tag = '\uf02b',
        
        [Display(Name = "Tags", Description = "fa-tags")]
        Tags = '\uf02c',
        
        [Display(Name = "Tape", Description = "fa-tape")]
        Tape = '\uf4db',
        
        [Display(Name = "Tasks", Description = "fa-tasks")]
        Tasks = '\uf0ae',
        
        [Display(Name = "Taxi", Description = "fa-taxi")]
        Taxi = '\uf1ba',
        
        [Display(Name = "Teamspeak", Description = "fa-teamspeak")]
        Teamspeak = '\uf4f9',
        
        [Display(Name = "Teeth", Description = "fa-teeth")]
        Teeth = '\uf62e',
        
        [Display(Name = "Teeth Open", Description = "fa-teeth-open")]
        TeethOpen = '\uf62f',
        
        [Display(Name = "Telegram", Description = "fa-telegram")]
        Telegram = '\uf2c6',
        
        [Display(Name = "Telegram Plane", Description = "fa-telegram-plane")]
        TelegramPlane = '\uf3fe',
        
        [Display(Name = "Temperature High", Description = "fa-temperature-high")]
        TemperatureHigh = '\uf769',
        
        [Display(Name = "Temperature Low", Description = "fa-temperature-low")]
        TemperatureLow = '\uf76b',
        
        [Display(Name = "Tencent Weibo", Description = "fa-tencent-weibo")]
        TencentWeibo = '\uf1d5',
        
        [Display(Name = "Tenge", Description = "fa-tenge")]
        Tenge = '\uf7d7',
        
        [Display(Name = "Terminal", Description = "fa-terminal")]
        Terminal = '\uf120',
        
        [Display(Name = "Text Height", Description = "fa-text-height")]
        TextHeight = '\uf034',
        
        [Display(Name = "Text Width", Description = "fa-text-width")]
        TextWidth = '\uf035',
        
        [Display(Name = "Th", Description = "fa-th")]
        Th = '\uf00a',
        
        [Display(Name = "Th Large", Description = "fa-th-large")]
        ThLarge = '\uf009',
        
        [Display(Name = "Th List", Description = "fa-th-list")]
        ThList = '\uf00b',
        
        [Display(Name = "The Red Yeti", Description = "fa-the-red-yeti")]
        TheRedYeti = '\uf69d',
        
        [Display(Name = "Theater Masks", Description = "fa-theater-masks")]
        TheaterMasks = '\uf630',
        
        [Display(Name = "Themeco", Description = "fa-themeco")]
        Themeco = '\uf5c6',
        
        [Display(Name = "Themeisle", Description = "fa-themeisle")]
        Themeisle = '\uf2b2',
        
        [Display(Name = "Thermometer", Description = "fa-thermometer")]
        Thermometer = '\uf491',
        
        [Display(Name = "Thermometer Empty", Description = "fa-thermometer-empty")]
        ThermometerEmpty = '\uf2cb',
        
        [Display(Name = "Thermometer Full", Description = "fa-thermometer-full")]
        ThermometerFull = '\uf2c7',
        
        [Display(Name = "Thermometer Half", Description = "fa-thermometer-half")]
        ThermometerHalf = '\uf2c9',
        
        [Display(Name = "Thermometer Quarter", Description = "fa-thermometer-quarter")]
        ThermometerQuarter = '\uf2ca',
        
        [Display(Name = "Thermometer Three Quarters", Description = "fa-thermometer-three-quarters")]
        ThermometerThreeQuarters = '\uf2c8',
        
        [Display(Name = "Think Peaks", Description = "fa-think-peaks")]
        ThinkPeaks = '\uf731',
        
        [Display(Name = "Thumbs Down", Description = "fa-thumbs-down")]
        ThumbsDown = '\uf165',
        
        [Display(Name = "Thumbs Up", Description = "fa-thumbs-up")]
        ThumbsUp = '\uf164',
        
        [Display(Name = "Thumbtack", Description = "fa-thumbtack")]
        Thumbtack = '\uf08d',
        
        [Display(Name = "Ticket Alt", Description = "fa-ticket-alt")]
        TicketAlt = '\uf3ff',
        
        [Display(Name = "Times", Description = "fa-times")]
        Times = '\uf00d',
        
        [Display(Name = "Times Circle", Description = "fa-times-circle")]
        TimesCircle = '\uf057',
        
        [Display(Name = "Tint", Description = "fa-tint")]
        Tint = '\uf043',
        
        [Display(Name = "Tint Slash", Description = "fa-tint-slash")]
        TintSlash = '\uf5c7',
        
        [Display(Name = "Tired", Description = "fa-tired")]
        Tired = '\uf5c8',
        
        [Display(Name = "Toggle Off", Description = "fa-toggle-off")]
        ToggleOff = '\uf204',
        
        [Display(Name = "Toggle On", Description = "fa-toggle-on")]
        ToggleOn = '\uf205',
        
        [Display(Name = "Toilet", Description = "fa-toilet")]
        Toilet = '\uf7d8',
        
        [Display(Name = "Toilet Paper", Description = "fa-toilet-paper")]
        ToiletPaper = '\uf71e',
        
        [Display(Name = "Toilet Paper Slash", Description = "fa-toilet-paper-slash")]
        ToiletPaperSlash = '\uf972',
        
        [Display(Name = "Toolbox", Description = "fa-toolbox")]
        Toolbox = '\uf552',
        
        [Display(Name = "Tools", Description = "fa-tools")]
        Tools = '\uf7d9',
        
        [Display(Name = "Tooth", Description = "fa-tooth")]
        Tooth = '\uf5c9',
        
        [Display(Name = "Torah", Description = "fa-torah")]
        Torah = '\uf6a0',
        
        [Display(Name = "Torii Gate", Description = "fa-torii-gate")]
        ToriiGate = '\uf6a1',
        
        [Display(Name = "Tractor", Description = "fa-tractor")]
        Tractor = '\uf722',
        
        [Display(Name = "Trade Federation", Description = "fa-trade-federation")]
        TradeFederation = '\uf513',
        
        [Display(Name = "Trademark", Description = "fa-trademark")]
        Trademark = '\uf25c',
        
        [Display(Name = "Traffic Light", Description = "fa-traffic-light")]
        TrafficLight = '\uf637',
        
        [Display(Name = "Trailer", Description = "fa-trailer")]
        Trailer = '\uf941',
        
        [Display(Name = "Train", Description = "fa-train")]
        Train = '\uf238',
        
        [Display(Name = "Tram", Description = "fa-tram")]
        Tram = '\uf7da',
        
        [Display(Name = "Transgender", Description = "fa-transgender")]
        Transgender = '\uf224',
        
        [Display(Name = "Transgender Alt", Description = "fa-transgender-alt")]
        TransgenderAlt = '\uf225',
        
        [Display(Name = "Trash", Description = "fa-trash")]
        Trash = '\uf1f8',
        
        [Display(Name = "Trash Alt", Description = "fa-trash-alt")]
        TrashAlt = '\uf2ed',
        
        [Display(Name = "Trash Restore", Description = "fa-trash-restore")]
        TrashRestore = '\uf829',
        
        [Display(Name = "Trash Restore Alt", Description = "fa-trash-restore-alt")]
        TrashRestoreAlt = '\uf82a',
        
        [Display(Name = "Tree", Description = "fa-tree")]
        Tree = '\uf1bb',
        
        [Display(Name = "Trello", Description = "fa-trello")]
        Trello = '\uf181',
        
        [Display(Name = "Tripadvisor", Description = "fa-tripadvisor")]
        Tripadvisor = '\uf262',
        
        [Display(Name = "Trophy", Description = "fa-trophy")]
        Trophy = '\uf091',
        
        [Display(Name = "Truck", Description = "fa-truck")]
        Truck = '\uf0d1',
        
        [Display(Name = "Truck Loading", Description = "fa-truck-loading")]
        TruckLoading = '\uf4de',
        
        [Display(Name = "Truck Monster", Description = "fa-truck-monster")]
        TruckMonster = '\uf63b',
        
        [Display(Name = "Truck Moving", Description = "fa-truck-moving")]
        TruckMoving = '\uf4df',
        
        [Display(Name = "Truck Pickup", Description = "fa-truck-pickup")]
        TruckPickup = '\uf63c',
        
        [Display(Name = "Tshirt", Description = "fa-tshirt")]
        Tshirt = '\uf553',
        
        [Display(Name = "Tty", Description = "fa-tty")]
        Tty = '\uf1e4',
        
        [Display(Name = "Tumblr", Description = "fa-tumblr")]
        Tumblr = '\uf173',
        
        [Display(Name = "Tumblr Square", Description = "fa-tumblr-square")]
        TumblrSquare = '\uf174',
        
        [Display(Name = "Tv", Description = "fa-tv")]
        Tv = '\uf26c',
        
        [Display(Name = "Twitch", Description = "fa-twitch")]
        Twitch = '\uf1e8',
        
        [Display(Name = "Twitter", Description = "fa-twitter")]
        Twitter = '\uf099',
        
        [Display(Name = "Twitter Square", Description = "fa-twitter-square")]
        TwitterSquare = '\uf081',
        
        [Display(Name = "Typo3", Description = "fa-typo3")]
        Typo3 = '\uf42b',
        
        [Display(Name = "Uber", Description = "fa-uber")]
        Uber = '\uf402',
        
        [Display(Name = "Ubuntu", Description = "fa-ubuntu")]
        Ubuntu = '\uf7df',
        
        [Display(Name = "Uikit", Description = "fa-uikit")]
        Uikit = '\uf403',
        
        [Display(Name = "Umbraco", Description = "fa-umbraco")]
        Umbraco = '\uf8e8',
        
        [Display(Name = "Umbrella", Description = "fa-umbrella")]
        Umbrella = '\uf0e9',
        
        [Display(Name = "Umbrella Beach", Description = "fa-umbrella-beach")]
        UmbrellaBeach = '\uf5ca',
        
        [Display(Name = "Underline", Description = "fa-underline")]
        Underline = '\uf0cd',
        
        [Display(Name = "Undo", Description = "fa-undo")]
        Undo = '\uf0e2',
        
        [Display(Name = "Undo Alt", Description = "fa-undo-alt")]
        UndoAlt = '\uf2ea',
        
        [Display(Name = "Uniregistry", Description = "fa-uniregistry")]
        Uniregistry = '\uf404',
        
        [Display(Name = "Unity", Description = "fa-unity")]
        Unity = '\uf949',
        
        [Display(Name = "Universal Access", Description = "fa-universal-access")]
        UniversalAccess = '\uf29a',
        
        [Display(Name = "University", Description = "fa-university")]
        University = '\uf19c',
        
        [Display(Name = "Unlink", Description = "fa-unlink")]
        Unlink = '\uf127',
        
        [Display(Name = "Unlock", Description = "fa-unlock")]
        Unlock = '\uf09c',
        
        [Display(Name = "Unlock Alt", Description = "fa-unlock-alt")]
        UnlockAlt = '\uf13e',
        
        [Display(Name = "Untappd", Description = "fa-untappd")]
        Untappd = '\uf405',
        
        [Display(Name = "Upload", Description = "fa-upload")]
        Upload = '\uf093',
        
        [Display(Name = "Ups", Description = "fa-ups")]
        Ups = '\uf7e0',
        
        [Display(Name = "Usb", Description = "fa-usb")]
        Usb = '\uf287',
        
        [Display(Name = "User", Description = "fa-user")]
        User = '\uf007',
        
        [Display(Name = "User Alt", Description = "fa-user-alt")]
        UserAlt = '\uf406',
        
        [Display(Name = "User Alt Slash", Description = "fa-user-alt-slash")]
        UserAltSlash = '\uf4fa',
        
        [Display(Name = "User Astronaut", Description = "fa-user-astronaut")]
        UserAstronaut = '\uf4fb',
        
        [Display(Name = "User Check", Description = "fa-user-check")]
        UserCheck = '\uf4fc',
        
        [Display(Name = "User Circle", Description = "fa-user-circle")]
        UserCircle = '\uf2bd',
        
        [Display(Name = "User Clock", Description = "fa-user-clock")]
        UserClock = '\uf4fd',
        
        [Display(Name = "User Cog", Description = "fa-user-cog")]
        UserCog = '\uf4fe',
        
        [Display(Name = "User Edit", Description = "fa-user-edit")]
        UserEdit = '\uf4ff',
        
        [Display(Name = "User Friends", Description = "fa-user-friends")]
        UserFriends = '\uf500',
        
        [Display(Name = "User Graduate", Description = "fa-user-graduate")]
        UserGraduate = '\uf501',
        
        [Display(Name = "User Injured", Description = "fa-user-injured")]
        UserInjured = '\uf728',
        
        [Display(Name = "User Lock", Description = "fa-user-lock")]
        UserLock = '\uf502',
        
        [Display(Name = "User Md", Description = "fa-user-md")]
        UserMd = '\uf0f0',
        
        [Display(Name = "User Minus", Description = "fa-user-minus")]
        UserMinus = '\uf503',
        
        [Display(Name = "User Ninja", Description = "fa-user-ninja")]
        UserNinja = '\uf504',
        
        [Display(Name = "User Nurse", Description = "fa-user-nurse")]
        UserNurse = '\uf82f',
        
        [Display(Name = "User Plus", Description = "fa-user-plus")]
        UserPlus = '\uf234',
        
        [Display(Name = "User Secret", Description = "fa-user-secret")]
        UserSecret = '\uf21b',
        
        [Display(Name = "User Shield", Description = "fa-user-shield")]
        UserShield = '\uf505',
        
        [Display(Name = "User Slash", Description = "fa-user-slash")]
        UserSlash = '\uf506',
        
        [Display(Name = "User Tag", Description = "fa-user-tag")]
        UserTag = '\uf507',
        
        [Display(Name = "User Tie", Description = "fa-user-tie")]
        UserTie = '\uf508',
        
        [Display(Name = "User Times", Description = "fa-user-times")]
        UserTimes = '\uf235',
        
        [Display(Name = "Users", Description = "fa-users")]
        Users = '\uf0c0',
        
        [Display(Name = "Users Cog", Description = "fa-users-cog")]
        UsersCog = '\uf509',
        
        [Display(Name = "Usps", Description = "fa-usps")]
        Usps = '\uf7e1',
        
        [Display(Name = "Ussunnah", Description = "fa-ussunnah")]
        Ussunnah = '\uf407',
        
        [Display(Name = "Utensil Spoon", Description = "fa-utensil-spoon")]
        UtensilSpoon = '\uf2e5',
        
        [Display(Name = "Utensils", Description = "fa-utensils")]
        Utensils = '\uf2e7',
        
        [Display(Name = "Vaadin", Description = "fa-vaadin")]
        Vaadin = '\uf408',
        
        [Display(Name = "Vector Square", Description = "fa-vector-square")]
        VectorSquare = '\uf5cb',
        
        [Display(Name = "Venus", Description = "fa-venus")]
        Venus = '\uf221',
        
        [Display(Name = "Venus Double", Description = "fa-venus-double")]
        VenusDouble = '\uf226',
        
        [Display(Name = "Venus Mars", Description = "fa-venus-mars")]
        VenusMars = '\uf228',
        
        [Display(Name = "Viacoin", Description = "fa-viacoin")]
        Viacoin = '\uf237',
        
        [Display(Name = "Viadeo", Description = "fa-viadeo")]
        Viadeo = '\uf2a9',
        
        [Display(Name = "Viadeo Square", Description = "fa-viadeo-square")]
        ViadeoSquare = '\uf2aa',
        
        [Display(Name = "Vial", Description = "fa-vial")]
        Vial = '\uf492',
        
        [Display(Name = "Vials", Description = "fa-vials")]
        Vials = '\uf493',
        
        [Display(Name = "Viber", Description = "fa-viber")]
        Viber = '\uf409',
        
        [Display(Name = "Video", Description = "fa-video")]
        Video = '\uf03d',
        
        [Display(Name = "Video Slash", Description = "fa-video-slash")]
        VideoSlash = '\uf4e2',
        
        [Display(Name = "Vihara", Description = "fa-vihara")]
        Vihara = '\uf6a7',
        
        [Display(Name = "Vimeo", Description = "fa-vimeo")]
        Vimeo = '\uf40a',
        
        [Display(Name = "Vimeo Square", Description = "fa-vimeo-square")]
        VimeoSquare = '\uf194',
        
        [Display(Name = "Vimeo V", Description = "fa-vimeo-v")]
        VimeoV = '\uf27d',
        
        [Display(Name = "Vine", Description = "fa-vine")]
        Vine = '\uf1ca',
        
        [Display(Name = "Virus", Description = "fa-virus")]
        Virus = '\uf974',
        
        [Display(Name = "Virus Slash", Description = "fa-virus-slash")]
        VirusSlash = '\uf975',
        
        [Display(Name = "Viruses", Description = "fa-viruses")]
        Viruses = '\uf976',
        
        [Display(Name = "Vk", Description = "fa-vk")]
        Vk = '\uf189',
        
        [Display(Name = "Vnv", Description = "fa-vnv")]
        Vnv = '\uf40b',
        
        [Display(Name = "Voicemail", Description = "fa-voicemail")]
        Voicemail = '\uf897',
        
        [Display(Name = "Volleyball Ball", Description = "fa-volleyball-ball")]
        VolleyballBall = '\uf45f',
        
        [Display(Name = "Volume Down", Description = "fa-volume-down")]
        VolumeDown = '\uf027',
        
        [Display(Name = "Volume Mute", Description = "fa-volume-mute")]
        VolumeMute = '\uf6a9',
        
        [Display(Name = "Volume Off", Description = "fa-volume-off")]
        VolumeOff = '\uf026',
        
        [Display(Name = "Volume Up", Description = "fa-volume-up")]
        VolumeUp = '\uf028',
        
        [Display(Name = "Vote Yea", Description = "fa-vote-yea")]
        VoteYea = '\uf772',
        
        [Display(Name = "Vr Cardboard", Description = "fa-vr-cardboard")]
        VrCardboard = '\uf729',
        
        [Display(Name = "Vuejs", Description = "fa-vuejs")]
        Vuejs = '\uf41f',
        
        [Display(Name = "Walking", Description = "fa-walking")]
        Walking = '\uf554',
        
        [Display(Name = "Wallet", Description = "fa-wallet")]
        Wallet = '\uf555',
        
        [Display(Name = "Warehouse", Description = "fa-warehouse")]
        Warehouse = '\uf494',
        
        [Display(Name = "Water", Description = "fa-water")]
        Water = '\uf773',
        
        [Display(Name = "Wave Square", Description = "fa-wave-square")]
        WaveSquare = '\uf83e',
        
        [Display(Name = "Waze", Description = "fa-waze")]
        Waze = '\uf83f',
        
        [Display(Name = "Weebly", Description = "fa-weebly")]
        Weebly = '\uf5cc',
        
        [Display(Name = "Weibo", Description = "fa-weibo")]
        Weibo = '\uf18a',
        
        [Display(Name = "Weight", Description = "fa-weight")]
        Weight = '\uf496',
        
        [Display(Name = "Weight Hanging", Description = "fa-weight-hanging")]
        WeightHanging = '\uf5cd',
        
        [Display(Name = "Weixin", Description = "fa-weixin")]
        Weixin = '\uf1d7',
        
        [Display(Name = "Whatsapp", Description = "fa-whatsapp")]
        Whatsapp = '\uf232',
        
        [Display(Name = "Whatsapp Square", Description = "fa-whatsapp-square")]
        WhatsappSquare = '\uf40c',
        
        [Display(Name = "Wheelchair", Description = "fa-wheelchair")]
        Wheelchair = '\uf193',
        
        [Display(Name = "Whmcs", Description = "fa-whmcs")]
        Whmcs = '\uf40d',
        
        [Display(Name = "Wifi", Description = "fa-wifi")]
        Wifi = '\uf1eb',
        
        [Display(Name = "Wikipedia W", Description = "fa-wikipedia-w")]
        WikipediaW = '\uf266',
        
        [Display(Name = "Wind", Description = "fa-wind")]
        Wind = '\uf72e',
        
        [Display(Name = "Window Close", Description = "fa-window-close")]
        WindowClose = '\uf410',
        
        [Display(Name = "Window Maximize", Description = "fa-window-maximize")]
        WindowMaximize = '\uf2d0',
        
        [Display(Name = "Window Minimize", Description = "fa-window-minimize")]
        WindowMinimize = '\uf2d1',
        
        [Display(Name = "Window Restore", Description = "fa-window-restore")]
        WindowRestore = '\uf2d2',
        
        [Display(Name = "Windows", Description = "fa-windows")]
        Windows = '\uf17a',
        
        [Display(Name = "Wine Bottle", Description = "fa-wine-bottle")]
        WineBottle = '\uf72f',
        
        [Display(Name = "Wine Glass", Description = "fa-wine-glass")]
        WineGlass = '\uf4e3',
        
        [Display(Name = "Wine Glass Alt", Description = "fa-wine-glass-alt")]
        WineGlassAlt = '\uf5ce',
        
        [Display(Name = "Wix", Description = "fa-wix")]
        Wix = '\uf5cf',
        
        [Display(Name = "Wizards Of The Coast", Description = "fa-wizards-of-the-coast")]
        WizardsOfTheCoast = '\uf730',
        
        [Display(Name = "Wolf Pack Battalion", Description = "fa-wolf-pack-battalion")]
        WolfPackBattalion = '\uf514',
        
        [Display(Name = "Won Sign", Description = "fa-won-sign")]
        WonSign = '\uf159',
        
        [Display(Name = "Wordpress", Description = "fa-wordpress")]
        Wordpress = '\uf19a',
        
        [Display(Name = "Wordpress Simple", Description = "fa-wordpress-simple")]
        WordpressSimple = '\uf411',
        
        [Display(Name = "Wpbeginner", Description = "fa-wpbeginner")]
        Wpbeginner = '\uf297',
        
        [Display(Name = "Wpexplorer", Description = "fa-wpexplorer")]
        Wpexplorer = '\uf2de',
        
        [Display(Name = "Wpforms", Description = "fa-wpforms")]
        Wpforms = '\uf298',
        
        [Display(Name = "Wpressr", Description = "fa-wpressr")]
        Wpressr = '\uf3e4',
        
        [Display(Name = "Wrench", Description = "fa-wrench")]
        Wrench = '\uf0ad',
        
        [Display(Name = "X Ray", Description = "fa-x-ray")]
        XRay = '\uf497',
        
        [Display(Name = "Xbox", Description = "fa-xbox")]
        Xbox = '\uf412',
        
        [Display(Name = "Xing", Description = "fa-xing")]
        Xing = '\uf168',
        
        [Display(Name = "Xing Square", Description = "fa-xing-square")]
        XingSquare = '\uf169',
        
        [Display(Name = "Y Combinator", Description = "fa-y-combinator")]
        YCombinator = '\uf23b',
        
        [Display(Name = "Yahoo", Description = "fa-yahoo")]
        Yahoo = '\uf19e',
        
        [Display(Name = "Yammer", Description = "fa-yammer")]
        Yammer = '\uf840',
        
        [Display(Name = "Yandex", Description = "fa-yandex")]
        Yandex = '\uf413',
        
        [Display(Name = "Yandex International", Description = "fa-yandex-international")]
        YandexInternational = '\uf414',
        
        [Display(Name = "Yarn", Description = "fa-yarn")]
        Yarn = '\uf7e3',
        
        [Display(Name = "Yelp", Description = "fa-yelp")]
        Yelp = '\uf1e9',
        
        [Display(Name = "Yen Sign", Description = "fa-yen-sign")]
        YenSign = '\uf157',
        
        [Display(Name = "Yin Yang", Description = "fa-yin-yang")]
        YinYang = '\uf6ad',
        
        [Display(Name = "Yoast", Description = "fa-yoast")]
        Yoast = '\uf2b1',
        
        [Display(Name = "Youtube", Description = "fa-youtube")]
        Youtube = '\uf167',
        
        [Display(Name = "Youtube Square", Description = "fa-youtube-square")]
        YoutubeSquare = '\uf431',
        
        [Display(Name = "Zhihu", Description = "fa-zhihu")]
        Zhihu = '\uf63f',
        
    }
    
    public static partial class Extensions
    {
        static Dictionary<FontAwesomeIcons, string> values = new Dictionary<FontAwesomeIcons, string>
        {
            { FontAwesomeIcons.AccessibleIcon, "fa-accessible-icon" },
            { FontAwesomeIcons.Accusoft, "fa-accusoft" },
            { FontAwesomeIcons.AcquisitionsIncorporated, "fa-acquisitions-incorporated" },
            { FontAwesomeIcons.Ad, "fa-ad" },
            { FontAwesomeIcons.AddressBook, "fa-address-book" },
            { FontAwesomeIcons.AddressCard, "fa-address-card" },
            { FontAwesomeIcons.Adjust, "fa-adjust" },
            { FontAwesomeIcons.Adn, "fa-adn" },
            { FontAwesomeIcons.Adobe, "fa-adobe" },
            { FontAwesomeIcons.Adversal, "fa-adversal" },
            { FontAwesomeIcons.Affiliatetheme, "fa-affiliatetheme" },
            { FontAwesomeIcons.AirFreshener, "fa-air-freshener" },
            { FontAwesomeIcons.Airbnb, "fa-airbnb" },
            { FontAwesomeIcons.Algolia, "fa-algolia" },
            { FontAwesomeIcons.AlignCenter, "fa-align-center" },
            { FontAwesomeIcons.AlignJustify, "fa-align-justify" },
            { FontAwesomeIcons.AlignLeft, "fa-align-left" },
            { FontAwesomeIcons.AlignRight, "fa-align-right" },
            { FontAwesomeIcons.Alipay, "fa-alipay" },
            { FontAwesomeIcons.Allergies, "fa-allergies" },
            { FontAwesomeIcons.Amazon, "fa-amazon" },
            { FontAwesomeIcons.AmazonPay, "fa-amazon-pay" },
            { FontAwesomeIcons.Ambulance, "fa-ambulance" },
            { FontAwesomeIcons.AmericanSignLanguageInterpreting, "fa-american-sign-language-interpreting" },
            { FontAwesomeIcons.Amilia, "fa-amilia" },
            { FontAwesomeIcons.Anchor, "fa-anchor" },
            { FontAwesomeIcons.Android, "fa-android" },
            { FontAwesomeIcons.Angellist, "fa-angellist" },
            { FontAwesomeIcons.AngleDoubleDown, "fa-angle-double-down" },
            { FontAwesomeIcons.AngleDoubleLeft, "fa-angle-double-left" },
            { FontAwesomeIcons.AngleDoubleRight, "fa-angle-double-right" },
            { FontAwesomeIcons.AngleDoubleUp, "fa-angle-double-up" },
            { FontAwesomeIcons.AngleDown, "fa-angle-down" },
            { FontAwesomeIcons.AngleLeft, "fa-angle-left" },
            { FontAwesomeIcons.AngleRight, "fa-angle-right" },
            { FontAwesomeIcons.AngleUp, "fa-angle-up" },
            { FontAwesomeIcons.Angry, "fa-angry" },
            { FontAwesomeIcons.Angrycreative, "fa-angrycreative" },
            { FontAwesomeIcons.Angular, "fa-angular" },
            { FontAwesomeIcons.Ankh, "fa-ankh" },
            { FontAwesomeIcons.AppStore, "fa-app-store" },
            { FontAwesomeIcons.AppStoreIos, "fa-app-store-ios" },
            { FontAwesomeIcons.Apper, "fa-apper" },
            { FontAwesomeIcons.Apple, "fa-apple" },
            { FontAwesomeIcons.AppleAlt, "fa-apple-alt" },
            { FontAwesomeIcons.ApplePay, "fa-apple-pay" },
            { FontAwesomeIcons.Archive, "fa-archive" },
            { FontAwesomeIcons.Archway, "fa-archway" },
            { FontAwesomeIcons.ArrowAltCircleDown, "fa-arrow-alt-circle-down" },
            { FontAwesomeIcons.ArrowAltCircleLeft, "fa-arrow-alt-circle-left" },
            { FontAwesomeIcons.ArrowAltCircleRight, "fa-arrow-alt-circle-right" },
            { FontAwesomeIcons.ArrowAltCircleUp, "fa-arrow-alt-circle-up" },
            { FontAwesomeIcons.ArrowCircleDown, "fa-arrow-circle-down" },
            { FontAwesomeIcons.ArrowCircleLeft, "fa-arrow-circle-left" },
            { FontAwesomeIcons.ArrowCircleRight, "fa-arrow-circle-right" },
            { FontAwesomeIcons.ArrowCircleUp, "fa-arrow-circle-up" },
            { FontAwesomeIcons.ArrowDown, "fa-arrow-down" },
            { FontAwesomeIcons.ArrowLeft, "fa-arrow-left" },
            { FontAwesomeIcons.ArrowRight, "fa-arrow-right" },
            { FontAwesomeIcons.ArrowUp, "fa-arrow-up" },
            { FontAwesomeIcons.ArrowsAlt, "fa-arrows-alt" },
            { FontAwesomeIcons.ArrowsAltH, "fa-arrows-alt-h" },
            { FontAwesomeIcons.ArrowsAltV, "fa-arrows-alt-v" },
            { FontAwesomeIcons.Artstation, "fa-artstation" },
            { FontAwesomeIcons.AssistiveListeningSystems, "fa-assistive-listening-systems" },
            { FontAwesomeIcons.Asterisk, "fa-asterisk" },
            { FontAwesomeIcons.Asymmetrik, "fa-asymmetrik" },
            { FontAwesomeIcons.At, "fa-at" },
            { FontAwesomeIcons.Atlas, "fa-atlas" },
            { FontAwesomeIcons.Atlassian, "fa-atlassian" },
            { FontAwesomeIcons.Atom, "fa-atom" },
            { FontAwesomeIcons.Audible, "fa-audible" },
            { FontAwesomeIcons.AudioDescription, "fa-audio-description" },
            { FontAwesomeIcons.Autoprefixer, "fa-autoprefixer" },
            { FontAwesomeIcons.Avianex, "fa-avianex" },
            { FontAwesomeIcons.Aviato, "fa-aviato" },
            { FontAwesomeIcons.Award, "fa-award" },
            { FontAwesomeIcons.Aws, "fa-aws" },
            { FontAwesomeIcons.Baby, "fa-baby" },
            { FontAwesomeIcons.BabyCarriage, "fa-baby-carriage" },
            { FontAwesomeIcons.Backspace, "fa-backspace" },
            { FontAwesomeIcons.Backward, "fa-backward" },
            { FontAwesomeIcons.Bacon, "fa-bacon" },
            { FontAwesomeIcons.Bahai, "fa-bahai" },
            { FontAwesomeIcons.BalanceScale, "fa-balance-scale" },
            { FontAwesomeIcons.BalanceScaleLeft, "fa-balance-scale-left" },
            { FontAwesomeIcons.BalanceScaleRight, "fa-balance-scale-right" },
            { FontAwesomeIcons.Ban, "fa-ban" },
            { FontAwesomeIcons.BandAid, "fa-band-aid" },
            { FontAwesomeIcons.Bandcamp, "fa-bandcamp" },
            { FontAwesomeIcons.Barcode, "fa-barcode" },
            { FontAwesomeIcons.Bars, "fa-bars" },
            { FontAwesomeIcons.BaseballBall, "fa-baseball-ball" },
            { FontAwesomeIcons.BasketballBall, "fa-basketball-ball" },
            { FontAwesomeIcons.Bath, "fa-bath" },
            { FontAwesomeIcons.BatteryEmpty, "fa-battery-empty" },
            { FontAwesomeIcons.BatteryFull, "fa-battery-full" },
            { FontAwesomeIcons.BatteryHalf, "fa-battery-half" },
            { FontAwesomeIcons.BatteryQuarter, "fa-battery-quarter" },
            { FontAwesomeIcons.BatteryThreeQuarters, "fa-battery-three-quarters" },
            { FontAwesomeIcons.BattleNet, "fa-battle-net" },
            { FontAwesomeIcons.Bed, "fa-bed" },
            { FontAwesomeIcons.Beer, "fa-beer" },
            { FontAwesomeIcons.Behance, "fa-behance" },
            { FontAwesomeIcons.BehanceSquare, "fa-behance-square" },
            { FontAwesomeIcons.Bell, "fa-bell" },
            { FontAwesomeIcons.BellSlash, "fa-bell-slash" },
            { FontAwesomeIcons.BezierCurve, "fa-bezier-curve" },
            { FontAwesomeIcons.Bible, "fa-bible" },
            { FontAwesomeIcons.Bicycle, "fa-bicycle" },
            { FontAwesomeIcons.Biking, "fa-biking" },
            { FontAwesomeIcons.Bimobject, "fa-bimobject" },
            { FontAwesomeIcons.Binoculars, "fa-binoculars" },
            { FontAwesomeIcons.Biohazard, "fa-biohazard" },
            { FontAwesomeIcons.BirthdayCake, "fa-birthday-cake" },
            { FontAwesomeIcons.Bitbucket, "fa-bitbucket" },
            { FontAwesomeIcons.Bitcoin, "fa-bitcoin" },
            { FontAwesomeIcons.Bity, "fa-bity" },
            { FontAwesomeIcons.BlackTie, "fa-black-tie" },
            { FontAwesomeIcons.Blackberry, "fa-blackberry" },
            { FontAwesomeIcons.Blender, "fa-blender" },
            { FontAwesomeIcons.BlenderPhone, "fa-blender-phone" },
            { FontAwesomeIcons.Blind, "fa-blind" },
            { FontAwesomeIcons.Blog, "fa-blog" },
            { FontAwesomeIcons.Blogger, "fa-blogger" },
            { FontAwesomeIcons.BloggerB, "fa-blogger-b" },
            { FontAwesomeIcons.Bluetooth, "fa-bluetooth" },
            { FontAwesomeIcons.BluetoothB, "fa-bluetooth-b" },
            { FontAwesomeIcons.Bold, "fa-bold" },
            { FontAwesomeIcons.Bolt, "fa-bolt" },
            { FontAwesomeIcons.Bomb, "fa-bomb" },
            { FontAwesomeIcons.Bone, "fa-bone" },
            { FontAwesomeIcons.Bong, "fa-bong" },
            { FontAwesomeIcons.Book, "fa-book" },
            { FontAwesomeIcons.BookDead, "fa-book-dead" },
            { FontAwesomeIcons.BookMedical, "fa-book-medical" },
            { FontAwesomeIcons.BookOpen, "fa-book-open" },
            { FontAwesomeIcons.BookReader, "fa-book-reader" },
            { FontAwesomeIcons.Bookmark, "fa-bookmark" },
            { FontAwesomeIcons.Bootstrap, "fa-bootstrap" },
            { FontAwesomeIcons.BorderAll, "fa-border-all" },
            { FontAwesomeIcons.BorderNone, "fa-border-none" },
            { FontAwesomeIcons.BorderStyle, "fa-border-style" },
            { FontAwesomeIcons.BowlingBall, "fa-bowling-ball" },
            { FontAwesomeIcons.Box, "fa-box" },
            { FontAwesomeIcons.BoxOpen, "fa-box-open" },
            { FontAwesomeIcons.BoxTissue, "fa-box-tissue" },
            { FontAwesomeIcons.Boxes, "fa-boxes" },
            { FontAwesomeIcons.Braille, "fa-braille" },
            { FontAwesomeIcons.Brain, "fa-brain" },
            { FontAwesomeIcons.BreadSlice, "fa-bread-slice" },
            { FontAwesomeIcons.Briefcase, "fa-briefcase" },
            { FontAwesomeIcons.BriefcaseMedical, "fa-briefcase-medical" },
            { FontAwesomeIcons.BroadcastTower, "fa-broadcast-tower" },
            { FontAwesomeIcons.Broom, "fa-broom" },
            { FontAwesomeIcons.Brush, "fa-brush" },
            { FontAwesomeIcons.Btc, "fa-btc" },
            { FontAwesomeIcons.Buffer, "fa-buffer" },
            { FontAwesomeIcons.Bug, "fa-bug" },
            { FontAwesomeIcons.Building, "fa-building" },
            { FontAwesomeIcons.Bullhorn, "fa-bullhorn" },
            { FontAwesomeIcons.Bullseye, "fa-bullseye" },
            { FontAwesomeIcons.Burn, "fa-burn" },
            { FontAwesomeIcons.Buromobelexperte, "fa-buromobelexperte" },
            { FontAwesomeIcons.Bus, "fa-bus" },
            { FontAwesomeIcons.BusAlt, "fa-bus-alt" },
            { FontAwesomeIcons.BusinessTime, "fa-business-time" },
            { FontAwesomeIcons.BuyNLarge, "fa-buy-n-large" },
            { FontAwesomeIcons.Buysellads, "fa-buysellads" },
            { FontAwesomeIcons.Calculator, "fa-calculator" },
            { FontAwesomeIcons.Calendar, "fa-calendar" },
            { FontAwesomeIcons.CalendarAlt, "fa-calendar-alt" },
            { FontAwesomeIcons.CalendarCheck, "fa-calendar-check" },
            { FontAwesomeIcons.CalendarDay, "fa-calendar-day" },
            { FontAwesomeIcons.CalendarMinus, "fa-calendar-minus" },
            { FontAwesomeIcons.CalendarPlus, "fa-calendar-plus" },
            { FontAwesomeIcons.CalendarTimes, "fa-calendar-times" },
            { FontAwesomeIcons.CalendarWeek, "fa-calendar-week" },
            { FontAwesomeIcons.Camera, "fa-camera" },
            { FontAwesomeIcons.CameraRetro, "fa-camera-retro" },
            { FontAwesomeIcons.Campground, "fa-campground" },
            { FontAwesomeIcons.CanadianMapleLeaf, "fa-canadian-maple-leaf" },
            { FontAwesomeIcons.CandyCane, "fa-candy-cane" },
            { FontAwesomeIcons.Cannabis, "fa-cannabis" },
            { FontAwesomeIcons.Capsules, "fa-capsules" },
            { FontAwesomeIcons.Car, "fa-car" },
            { FontAwesomeIcons.CarAlt, "fa-car-alt" },
            { FontAwesomeIcons.CarBattery, "fa-car-battery" },
            { FontAwesomeIcons.CarCrash, "fa-car-crash" },
            { FontAwesomeIcons.CarSide, "fa-car-side" },
            { FontAwesomeIcons.Caravan, "fa-caravan" },
            { FontAwesomeIcons.CaretDown, "fa-caret-down" },
            { FontAwesomeIcons.CaretLeft, "fa-caret-left" },
            { FontAwesomeIcons.CaretRight, "fa-caret-right" },
            { FontAwesomeIcons.CaretSquareDown, "fa-caret-square-down" },
            { FontAwesomeIcons.CaretSquareLeft, "fa-caret-square-left" },
            { FontAwesomeIcons.CaretSquareRight, "fa-caret-square-right" },
            { FontAwesomeIcons.CaretSquareUp, "fa-caret-square-up" },
            { FontAwesomeIcons.CaretUp, "fa-caret-up" },
            { FontAwesomeIcons.Carrot, "fa-carrot" },
            { FontAwesomeIcons.CartArrowDown, "fa-cart-arrow-down" },
            { FontAwesomeIcons.CartPlus, "fa-cart-plus" },
            { FontAwesomeIcons.CashRegister, "fa-cash-register" },
            { FontAwesomeIcons.Cat, "fa-cat" },
            { FontAwesomeIcons.CcAmazonPay, "fa-cc-amazon-pay" },
            { FontAwesomeIcons.CcAmex, "fa-cc-amex" },
            { FontAwesomeIcons.CcApplePay, "fa-cc-apple-pay" },
            { FontAwesomeIcons.CcDinersClub, "fa-cc-diners-club" },
            { FontAwesomeIcons.CcDiscover, "fa-cc-discover" },
            { FontAwesomeIcons.CcJcb, "fa-cc-jcb" },
            { FontAwesomeIcons.CcMastercard, "fa-cc-mastercard" },
            { FontAwesomeIcons.CcPaypal, "fa-cc-paypal" },
            { FontAwesomeIcons.CcStripe, "fa-cc-stripe" },
            { FontAwesomeIcons.CcVisa, "fa-cc-visa" },
            { FontAwesomeIcons.Centercode, "fa-centercode" },
            { FontAwesomeIcons.Centos, "fa-centos" },
            { FontAwesomeIcons.Certificate, "fa-certificate" },
            { FontAwesomeIcons.Chair, "fa-chair" },
            { FontAwesomeIcons.Chalkboard, "fa-chalkboard" },
            { FontAwesomeIcons.ChalkboardTeacher, "fa-chalkboard-teacher" },
            { FontAwesomeIcons.ChargingStation, "fa-charging-station" },
            { FontAwesomeIcons.ChartArea, "fa-chart-area" },
            { FontAwesomeIcons.ChartBar, "fa-chart-bar" },
            { FontAwesomeIcons.ChartLine, "fa-chart-line" },
            { FontAwesomeIcons.ChartPie, "fa-chart-pie" },
            { FontAwesomeIcons.Check, "fa-check" },
            { FontAwesomeIcons.CheckCircle, "fa-check-circle" },
            { FontAwesomeIcons.CheckDouble, "fa-check-double" },
            { FontAwesomeIcons.CheckSquare, "fa-check-square" },
            { FontAwesomeIcons.Cheese, "fa-cheese" },
            { FontAwesomeIcons.Chess, "fa-chess" },
            { FontAwesomeIcons.ChessBishop, "fa-chess-bishop" },
            { FontAwesomeIcons.ChessBoard, "fa-chess-board" },
            { FontAwesomeIcons.ChessKing, "fa-chess-king" },
            { FontAwesomeIcons.ChessKnight, "fa-chess-knight" },
            { FontAwesomeIcons.ChessPawn, "fa-chess-pawn" },
            { FontAwesomeIcons.ChessQueen, "fa-chess-queen" },
            { FontAwesomeIcons.ChessRook, "fa-chess-rook" },
            { FontAwesomeIcons.ChevronCircleDown, "fa-chevron-circle-down" },
            { FontAwesomeIcons.ChevronCircleLeft, "fa-chevron-circle-left" },
            { FontAwesomeIcons.ChevronCircleRight, "fa-chevron-circle-right" },
            { FontAwesomeIcons.ChevronCircleUp, "fa-chevron-circle-up" },
            { FontAwesomeIcons.ChevronDown, "fa-chevron-down" },
            { FontAwesomeIcons.ChevronLeft, "fa-chevron-left" },
            { FontAwesomeIcons.ChevronRight, "fa-chevron-right" },
            { FontAwesomeIcons.ChevronUp, "fa-chevron-up" },
            { FontAwesomeIcons.Child, "fa-child" },
            { FontAwesomeIcons.Chrome, "fa-chrome" },
            { FontAwesomeIcons.Chromecast, "fa-chromecast" },
            { FontAwesomeIcons.Church, "fa-church" },
            { FontAwesomeIcons.Circle, "fa-circle" },
            { FontAwesomeIcons.CircleNotch, "fa-circle-notch" },
            { FontAwesomeIcons.City, "fa-city" },
            { FontAwesomeIcons.ClinicMedical, "fa-clinic-medical" },
            { FontAwesomeIcons.Clipboard, "fa-clipboard" },
            { FontAwesomeIcons.ClipboardCheck, "fa-clipboard-check" },
            { FontAwesomeIcons.ClipboardList, "fa-clipboard-list" },
            { FontAwesomeIcons.Clock, "fa-clock" },
            { FontAwesomeIcons.Clone, "fa-clone" },
            { FontAwesomeIcons.ClosedCaptioning, "fa-closed-captioning" },
            { FontAwesomeIcons.Cloud, "fa-cloud" },
            { FontAwesomeIcons.CloudDownloadAlt, "fa-cloud-download-alt" },
            { FontAwesomeIcons.CloudMeatball, "fa-cloud-meatball" },
            { FontAwesomeIcons.CloudMoon, "fa-cloud-moon" },
            { FontAwesomeIcons.CloudMoonRain, "fa-cloud-moon-rain" },
            { FontAwesomeIcons.CloudRain, "fa-cloud-rain" },
            { FontAwesomeIcons.CloudShowersHeavy, "fa-cloud-showers-heavy" },
            { FontAwesomeIcons.CloudSun, "fa-cloud-sun" },
            { FontAwesomeIcons.CloudSunRain, "fa-cloud-sun-rain" },
            { FontAwesomeIcons.CloudUploadAlt, "fa-cloud-upload-alt" },
            { FontAwesomeIcons.Cloudscale, "fa-cloudscale" },
            { FontAwesomeIcons.Cloudsmith, "fa-cloudsmith" },
            { FontAwesomeIcons.Cloudversify, "fa-cloudversify" },
            { FontAwesomeIcons.Cocktail, "fa-cocktail" },
            { FontAwesomeIcons.Code, "fa-code" },
            { FontAwesomeIcons.CodeBranch, "fa-code-branch" },
            { FontAwesomeIcons.Codepen, "fa-codepen" },
            { FontAwesomeIcons.Codiepie, "fa-codiepie" },
            { FontAwesomeIcons.Coffee, "fa-coffee" },
            { FontAwesomeIcons.Cog, "fa-cog" },
            { FontAwesomeIcons.Cogs, "fa-cogs" },
            { FontAwesomeIcons.Coins, "fa-coins" },
            { FontAwesomeIcons.Columns, "fa-columns" },
            { FontAwesomeIcons.Comment, "fa-comment" },
            { FontAwesomeIcons.CommentAlt, "fa-comment-alt" },
            { FontAwesomeIcons.CommentDollar, "fa-comment-dollar" },
            { FontAwesomeIcons.CommentDots, "fa-comment-dots" },
            { FontAwesomeIcons.CommentMedical, "fa-comment-medical" },
            { FontAwesomeIcons.CommentSlash, "fa-comment-slash" },
            { FontAwesomeIcons.Comments, "fa-comments" },
            { FontAwesomeIcons.CommentsDollar, "fa-comments-dollar" },
            { FontAwesomeIcons.CompactDisc, "fa-compact-disc" },
            { FontAwesomeIcons.Compass, "fa-compass" },
            { FontAwesomeIcons.Compress, "fa-compress" },
            { FontAwesomeIcons.CompressAlt, "fa-compress-alt" },
            { FontAwesomeIcons.CompressArrowsAlt, "fa-compress-arrows-alt" },
            { FontAwesomeIcons.ConciergeBell, "fa-concierge-bell" },
            { FontAwesomeIcons.Confluence, "fa-confluence" },
            { FontAwesomeIcons.Connectdevelop, "fa-connectdevelop" },
            { FontAwesomeIcons.Contao, "fa-contao" },
            { FontAwesomeIcons.Cookie, "fa-cookie" },
            { FontAwesomeIcons.CookieBite, "fa-cookie-bite" },
            { FontAwesomeIcons.Copy, "fa-copy" },
            { FontAwesomeIcons.Copyright, "fa-copyright" },
            { FontAwesomeIcons.CottonBureau, "fa-cotton-bureau" },
            { FontAwesomeIcons.Couch, "fa-couch" },
            { FontAwesomeIcons.Cpanel, "fa-cpanel" },
            { FontAwesomeIcons.CreativeCommons, "fa-creative-commons" },
            { FontAwesomeIcons.CreativeCommonsBy, "fa-creative-commons-by" },
            { FontAwesomeIcons.CreativeCommonsNc, "fa-creative-commons-nc" },
            { FontAwesomeIcons.CreativeCommonsNcEu, "fa-creative-commons-nc-eu" },
            { FontAwesomeIcons.CreativeCommonsNcJp, "fa-creative-commons-nc-jp" },
            { FontAwesomeIcons.CreativeCommonsNd, "fa-creative-commons-nd" },
            { FontAwesomeIcons.CreativeCommonsPd, "fa-creative-commons-pd" },
            { FontAwesomeIcons.CreativeCommonsPdAlt, "fa-creative-commons-pd-alt" },
            { FontAwesomeIcons.CreativeCommonsRemix, "fa-creative-commons-remix" },
            { FontAwesomeIcons.CreativeCommonsSa, "fa-creative-commons-sa" },
            { FontAwesomeIcons.CreativeCommonsSampling, "fa-creative-commons-sampling" },
            { FontAwesomeIcons.CreativeCommonsSamplingPlus, "fa-creative-commons-sampling-plus" },
            { FontAwesomeIcons.CreativeCommonsShare, "fa-creative-commons-share" },
            { FontAwesomeIcons.CreativeCommonsZero, "fa-creative-commons-zero" },
            { FontAwesomeIcons.CreditCard, "fa-credit-card" },
            { FontAwesomeIcons.CriticalRole, "fa-critical-role" },
            { FontAwesomeIcons.Crop, "fa-crop" },
            { FontAwesomeIcons.CropAlt, "fa-crop-alt" },
            { FontAwesomeIcons.Cross, "fa-cross" },
            { FontAwesomeIcons.Crosshairs, "fa-crosshairs" },
            { FontAwesomeIcons.Crow, "fa-crow" },
            { FontAwesomeIcons.Crown, "fa-crown" },
            { FontAwesomeIcons.Crutch, "fa-crutch" },
            { FontAwesomeIcons.Css3, "fa-css3" },
            { FontAwesomeIcons.Css3Alt, "fa-css3-alt" },
            { FontAwesomeIcons.Cube, "fa-cube" },
            { FontAwesomeIcons.Cubes, "fa-cubes" },
            { FontAwesomeIcons.Cut, "fa-cut" },
            { FontAwesomeIcons.Cuttlefish, "fa-cuttlefish" },
            { FontAwesomeIcons.DAndD, "fa-d-and-d" },
            { FontAwesomeIcons.DAndDBeyond, "fa-d-and-d-beyond" },
            { FontAwesomeIcons.Dailymotion, "fa-dailymotion" },
            { FontAwesomeIcons.Dashcube, "fa-dashcube" },
            { FontAwesomeIcons.Database, "fa-database" },
            { FontAwesomeIcons.Deaf, "fa-deaf" },
            { FontAwesomeIcons.Delicious, "fa-delicious" },
            { FontAwesomeIcons.Democrat, "fa-democrat" },
            { FontAwesomeIcons.Deploydog, "fa-deploydog" },
            { FontAwesomeIcons.Deskpro, "fa-deskpro" },
            { FontAwesomeIcons.Desktop, "fa-desktop" },
            { FontAwesomeIcons.Dev, "fa-dev" },
            { FontAwesomeIcons.Deviantart, "fa-deviantart" },
            { FontAwesomeIcons.Dharmachakra, "fa-dharmachakra" },
            { FontAwesomeIcons.Dhl, "fa-dhl" },
            { FontAwesomeIcons.Diagnoses, "fa-diagnoses" },
            { FontAwesomeIcons.Diaspora, "fa-diaspora" },
            { FontAwesomeIcons.Dice, "fa-dice" },
            { FontAwesomeIcons.DiceD20, "fa-dice-d20" },
            { FontAwesomeIcons.DiceD6, "fa-dice-d6" },
            { FontAwesomeIcons.DiceFive, "fa-dice-five" },
            { FontAwesomeIcons.DiceFour, "fa-dice-four" },
            { FontAwesomeIcons.DiceOne, "fa-dice-one" },
            { FontAwesomeIcons.DiceSix, "fa-dice-six" },
            { FontAwesomeIcons.DiceThree, "fa-dice-three" },
            { FontAwesomeIcons.DiceTwo, "fa-dice-two" },
            { FontAwesomeIcons.Digg, "fa-digg" },
            { FontAwesomeIcons.DigitalOcean, "fa-digital-ocean" },
            { FontAwesomeIcons.DigitalTachograph, "fa-digital-tachograph" },
            { FontAwesomeIcons.Directions, "fa-directions" },
            { FontAwesomeIcons.Discord, "fa-discord" },
            { FontAwesomeIcons.Discourse, "fa-discourse" },
            { FontAwesomeIcons.Disease, "fa-disease" },
            { FontAwesomeIcons.Divide, "fa-divide" },
            { FontAwesomeIcons.Dizzy, "fa-dizzy" },
            { FontAwesomeIcons.Dna, "fa-dna" },
            { FontAwesomeIcons.Dochub, "fa-dochub" },
            { FontAwesomeIcons.Docker, "fa-docker" },
            { FontAwesomeIcons.Dog, "fa-dog" },
            { FontAwesomeIcons.DollarSign, "fa-dollar-sign" },
            { FontAwesomeIcons.Dolly, "fa-dolly" },
            { FontAwesomeIcons.DollyFlatbed, "fa-dolly-flatbed" },
            { FontAwesomeIcons.Donate, "fa-donate" },
            { FontAwesomeIcons.DoorClosed, "fa-door-closed" },
            { FontAwesomeIcons.DoorOpen, "fa-door-open" },
            { FontAwesomeIcons.DotCircle, "fa-dot-circle" },
            { FontAwesomeIcons.Dove, "fa-dove" },
            { FontAwesomeIcons.Download, "fa-download" },
            { FontAwesomeIcons.Draft2digital, "fa-draft2digital" },
            { FontAwesomeIcons.DraftingCompass, "fa-drafting-compass" },
            { FontAwesomeIcons.Dragon, "fa-dragon" },
            { FontAwesomeIcons.DrawPolygon, "fa-draw-polygon" },
            { FontAwesomeIcons.Dribbble, "fa-dribbble" },
            { FontAwesomeIcons.DribbbleSquare, "fa-dribbble-square" },
            { FontAwesomeIcons.Dropbox, "fa-dropbox" },
            { FontAwesomeIcons.Drum, "fa-drum" },
            { FontAwesomeIcons.DrumSteelpan, "fa-drum-steelpan" },
            { FontAwesomeIcons.DrumstickBite, "fa-drumstick-bite" },
            { FontAwesomeIcons.Drupal, "fa-drupal" },
            { FontAwesomeIcons.Dumbbell, "fa-dumbbell" },
            { FontAwesomeIcons.Dumpster, "fa-dumpster" },
            { FontAwesomeIcons.DumpsterFire, "fa-dumpster-fire" },
            { FontAwesomeIcons.Dungeon, "fa-dungeon" },
            { FontAwesomeIcons.Dyalog, "fa-dyalog" },
            { FontAwesomeIcons.Earlybirds, "fa-earlybirds" },
            { FontAwesomeIcons.Ebay, "fa-ebay" },
            { FontAwesomeIcons.Edge, "fa-edge" },
            { FontAwesomeIcons.Edit, "fa-edit" },
            { FontAwesomeIcons.Egg, "fa-egg" },
            { FontAwesomeIcons.Eject, "fa-eject" },
            { FontAwesomeIcons.Elementor, "fa-elementor" },
            { FontAwesomeIcons.EllipsisH, "fa-ellipsis-h" },
            { FontAwesomeIcons.EllipsisV, "fa-ellipsis-v" },
            { FontAwesomeIcons.Ello, "fa-ello" },
            { FontAwesomeIcons.Ember, "fa-ember" },
            { FontAwesomeIcons.Empire, "fa-empire" },
            { FontAwesomeIcons.Envelope, "fa-envelope" },
            { FontAwesomeIcons.EnvelopeOpen, "fa-envelope-open" },
            { FontAwesomeIcons.EnvelopeOpenText, "fa-envelope-open-text" },
            { FontAwesomeIcons.EnvelopeSquare, "fa-envelope-square" },
            { FontAwesomeIcons.Envira, "fa-envira" },
            { FontAwesomeIcons.Equals, "fa-equals" },
            { FontAwesomeIcons.Eraser, "fa-eraser" },
            { FontAwesomeIcons.Erlang, "fa-erlang" },
            { FontAwesomeIcons.Ethereum, "fa-ethereum" },
            { FontAwesomeIcons.Ethernet, "fa-ethernet" },
            { FontAwesomeIcons.Etsy, "fa-etsy" },
            { FontAwesomeIcons.EuroSign, "fa-euro-sign" },
            { FontAwesomeIcons.Evernote, "fa-evernote" },
            { FontAwesomeIcons.ExchangeAlt, "fa-exchange-alt" },
            { FontAwesomeIcons.Exclamation, "fa-exclamation" },
            { FontAwesomeIcons.ExclamationCircle, "fa-exclamation-circle" },
            { FontAwesomeIcons.ExclamationTriangle, "fa-exclamation-triangle" },
            { FontAwesomeIcons.Expand, "fa-expand" },
            { FontAwesomeIcons.ExpandAlt, "fa-expand-alt" },
            { FontAwesomeIcons.ExpandArrowsAlt, "fa-expand-arrows-alt" },
            { FontAwesomeIcons.Expeditedssl, "fa-expeditedssl" },
            { FontAwesomeIcons.ExternalLinkAlt, "fa-external-link-alt" },
            { FontAwesomeIcons.ExternalLinkSquareAlt, "fa-external-link-square-alt" },
            { FontAwesomeIcons.Eye, "fa-eye" },
            { FontAwesomeIcons.EyeDropper, "fa-eye-dropper" },
            { FontAwesomeIcons.EyeSlash, "fa-eye-slash" },
            { FontAwesomeIcons.Facebook, "fa-facebook" },
            { FontAwesomeIcons.FacebookF, "fa-facebook-f" },
            { FontAwesomeIcons.FacebookMessenger, "fa-facebook-messenger" },
            { FontAwesomeIcons.FacebookSquare, "fa-facebook-square" },
            { FontAwesomeIcons.Fan, "fa-fan" },
            { FontAwesomeIcons.FantasyFlightGames, "fa-fantasy-flight-games" },
            { FontAwesomeIcons.FastBackward, "fa-fast-backward" },
            { FontAwesomeIcons.FastForward, "fa-fast-forward" },
            { FontAwesomeIcons.Faucet, "fa-faucet" },
            { FontAwesomeIcons.Fax, "fa-fax" },
            { FontAwesomeIcons.Feather, "fa-feather" },
            { FontAwesomeIcons.FeatherAlt, "fa-feather-alt" },
            { FontAwesomeIcons.Fedex, "fa-fedex" },
            { FontAwesomeIcons.Fedora, "fa-fedora" },
            { FontAwesomeIcons.Female, "fa-female" },
            { FontAwesomeIcons.FighterJet, "fa-fighter-jet" },
            { FontAwesomeIcons.Figma, "fa-figma" },
            { FontAwesomeIcons.File, "fa-file" },
            { FontAwesomeIcons.FileAlt, "fa-file-alt" },
            { FontAwesomeIcons.FileArchive, "fa-file-archive" },
            { FontAwesomeIcons.FileAudio, "fa-file-audio" },
            { FontAwesomeIcons.FileCode, "fa-file-code" },
            { FontAwesomeIcons.FileContract, "fa-file-contract" },
            { FontAwesomeIcons.FileCsv, "fa-file-csv" },
            { FontAwesomeIcons.FileDownload, "fa-file-download" },
            { FontAwesomeIcons.FileExcel, "fa-file-excel" },
            { FontAwesomeIcons.FileExport, "fa-file-export" },
            { FontAwesomeIcons.FileImage, "fa-file-image" },
            { FontAwesomeIcons.FileImport, "fa-file-import" },
            { FontAwesomeIcons.FileInvoice, "fa-file-invoice" },
            { FontAwesomeIcons.FileInvoiceDollar, "fa-file-invoice-dollar" },
            { FontAwesomeIcons.FileMedical, "fa-file-medical" },
            { FontAwesomeIcons.FileMedicalAlt, "fa-file-medical-alt" },
            { FontAwesomeIcons.FilePdf, "fa-file-pdf" },
            { FontAwesomeIcons.FilePowerpoint, "fa-file-powerpoint" },
            { FontAwesomeIcons.FilePrescription, "fa-file-prescription" },
            { FontAwesomeIcons.FileSignature, "fa-file-signature" },
            { FontAwesomeIcons.FileUpload, "fa-file-upload" },
            { FontAwesomeIcons.FileVideo, "fa-file-video" },
            { FontAwesomeIcons.FileWord, "fa-file-word" },
            { FontAwesomeIcons.Fill, "fa-fill" },
            { FontAwesomeIcons.FillDrip, "fa-fill-drip" },
            { FontAwesomeIcons.Film, "fa-film" },
            { FontAwesomeIcons.Filter, "fa-filter" },
            { FontAwesomeIcons.Fingerprint, "fa-fingerprint" },
            { FontAwesomeIcons.Fire, "fa-fire" },
            { FontAwesomeIcons.FireAlt, "fa-fire-alt" },
            { FontAwesomeIcons.FireExtinguisher, "fa-fire-extinguisher" },
            { FontAwesomeIcons.Firefox, "fa-firefox" },
            { FontAwesomeIcons.FirefoxBrowser, "fa-firefox-browser" },
            { FontAwesomeIcons.FirstAid, "fa-first-aid" },
            { FontAwesomeIcons.FirstOrder, "fa-first-order" },
            { FontAwesomeIcons.FirstOrderAlt, "fa-first-order-alt" },
            { FontAwesomeIcons.Firstdraft, "fa-firstdraft" },
            { FontAwesomeIcons.Fish, "fa-fish" },
            { FontAwesomeIcons.FistRaised, "fa-fist-raised" },
            { FontAwesomeIcons.Flag, "fa-flag" },
            { FontAwesomeIcons.FlagCheckered, "fa-flag-checkered" },
            { FontAwesomeIcons.FlagUsa, "fa-flag-usa" },
            { FontAwesomeIcons.Flask, "fa-flask" },
            { FontAwesomeIcons.Flickr, "fa-flickr" },
            { FontAwesomeIcons.Flipboard, "fa-flipboard" },
            { FontAwesomeIcons.Flushed, "fa-flushed" },
            { FontAwesomeIcons.Fly, "fa-fly" },
            { FontAwesomeIcons.Folder, "fa-folder" },
            { FontAwesomeIcons.FolderMinus, "fa-folder-minus" },
            { FontAwesomeIcons.FolderOpen, "fa-folder-open" },
            { FontAwesomeIcons.FolderPlus, "fa-folder-plus" },
            { FontAwesomeIcons.Font, "fa-font" },
            { FontAwesomeIcons.FontAwesome, "fa-font-awesome" },
            { FontAwesomeIcons.FontAwesomeAlt, "fa-font-awesome-alt" },
            { FontAwesomeIcons.FontAwesomeFlag, "fa-font-awesome-flag" },
            { FontAwesomeIcons.FontAwesomeLogoFull, "fa-font-awesome-logo-full" },
            { FontAwesomeIcons.Fonticons, "fa-fonticons" },
            { FontAwesomeIcons.FonticonsFi, "fa-fonticons-fi" },
            { FontAwesomeIcons.FootballBall, "fa-football-ball" },
            { FontAwesomeIcons.FortAwesome, "fa-fort-awesome" },
            { FontAwesomeIcons.FortAwesomeAlt, "fa-fort-awesome-alt" },
            { FontAwesomeIcons.Forumbee, "fa-forumbee" },
            { FontAwesomeIcons.Forward, "fa-forward" },
            { FontAwesomeIcons.Foursquare, "fa-foursquare" },
            { FontAwesomeIcons.FreeCodeCamp, "fa-free-code-camp" },
            { FontAwesomeIcons.Freebsd, "fa-freebsd" },
            { FontAwesomeIcons.Frog, "fa-frog" },
            { FontAwesomeIcons.Frown, "fa-frown" },
            { FontAwesomeIcons.FrownOpen, "fa-frown-open" },
            { FontAwesomeIcons.Fulcrum, "fa-fulcrum" },
            { FontAwesomeIcons.FunnelDollar, "fa-funnel-dollar" },
            { FontAwesomeIcons.Futbol, "fa-futbol" },
            { FontAwesomeIcons.GalacticRepublic, "fa-galactic-republic" },
            { FontAwesomeIcons.GalacticSenate, "fa-galactic-senate" },
            { FontAwesomeIcons.Gamepad, "fa-gamepad" },
            { FontAwesomeIcons.GasPump, "fa-gas-pump" },
            { FontAwesomeIcons.Gavel, "fa-gavel" },
            { FontAwesomeIcons.Gem, "fa-gem" },
            { FontAwesomeIcons.Genderless, "fa-genderless" },
            { FontAwesomeIcons.GetPocket, "fa-get-pocket" },
            { FontAwesomeIcons.Gg, "fa-gg" },
            { FontAwesomeIcons.GgCircle, "fa-gg-circle" },
            { FontAwesomeIcons.Ghost, "fa-ghost" },
            { FontAwesomeIcons.Gift, "fa-gift" },
            { FontAwesomeIcons.Gifts, "fa-gifts" },
            { FontAwesomeIcons.Git, "fa-git" },
            { FontAwesomeIcons.GitAlt, "fa-git-alt" },
            { FontAwesomeIcons.GitSquare, "fa-git-square" },
            { FontAwesomeIcons.Github, "fa-github" },
            { FontAwesomeIcons.GithubAlt, "fa-github-alt" },
            { FontAwesomeIcons.GithubSquare, "fa-github-square" },
            { FontAwesomeIcons.Gitkraken, "fa-gitkraken" },
            { FontAwesomeIcons.Gitlab, "fa-gitlab" },
            { FontAwesomeIcons.Gitter, "fa-gitter" },
            { FontAwesomeIcons.GlassCheers, "fa-glass-cheers" },
            { FontAwesomeIcons.GlassMartini, "fa-glass-martini" },
            { FontAwesomeIcons.GlassMartiniAlt, "fa-glass-martini-alt" },
            { FontAwesomeIcons.GlassWhiskey, "fa-glass-whiskey" },
            { FontAwesomeIcons.Glasses, "fa-glasses" },
            { FontAwesomeIcons.Glide, "fa-glide" },
            { FontAwesomeIcons.GlideG, "fa-glide-g" },
            { FontAwesomeIcons.Globe, "fa-globe" },
            { FontAwesomeIcons.GlobeAfrica, "fa-globe-africa" },
            { FontAwesomeIcons.GlobeAmericas, "fa-globe-americas" },
            { FontAwesomeIcons.GlobeAsia, "fa-globe-asia" },
            { FontAwesomeIcons.GlobeEurope, "fa-globe-europe" },
            { FontAwesomeIcons.Gofore, "fa-gofore" },
            { FontAwesomeIcons.GolfBall, "fa-golf-ball" },
            { FontAwesomeIcons.Goodreads, "fa-goodreads" },
            { FontAwesomeIcons.GoodreadsG, "fa-goodreads-g" },
            { FontAwesomeIcons.Google, "fa-google" },
            { FontAwesomeIcons.GoogleDrive, "fa-google-drive" },
            { FontAwesomeIcons.GooglePlay, "fa-google-play" },
            { FontAwesomeIcons.GooglePlus, "fa-google-plus" },
            { FontAwesomeIcons.GooglePlusG, "fa-google-plus-g" },
            { FontAwesomeIcons.GooglePlusSquare, "fa-google-plus-square" },
            { FontAwesomeIcons.GoogleWallet, "fa-google-wallet" },
            { FontAwesomeIcons.Gopuram, "fa-gopuram" },
            { FontAwesomeIcons.GraduationCap, "fa-graduation-cap" },
            { FontAwesomeIcons.Gratipay, "fa-gratipay" },
            { FontAwesomeIcons.Grav, "fa-grav" },
            { FontAwesomeIcons.GreaterThan, "fa-greater-than" },
            { FontAwesomeIcons.GreaterThanEqual, "fa-greater-than-equal" },
            { FontAwesomeIcons.Grimace, "fa-grimace" },
            { FontAwesomeIcons.Grin, "fa-grin" },
            { FontAwesomeIcons.GrinAlt, "fa-grin-alt" },
            { FontAwesomeIcons.GrinBeam, "fa-grin-beam" },
            { FontAwesomeIcons.GrinBeamSweat, "fa-grin-beam-sweat" },
            { FontAwesomeIcons.GrinHearts, "fa-grin-hearts" },
            { FontAwesomeIcons.GrinSquint, "fa-grin-squint" },
            { FontAwesomeIcons.GrinSquintTears, "fa-grin-squint-tears" },
            { FontAwesomeIcons.GrinStars, "fa-grin-stars" },
            { FontAwesomeIcons.GrinTears, "fa-grin-tears" },
            { FontAwesomeIcons.GrinTongue, "fa-grin-tongue" },
            { FontAwesomeIcons.GrinTongueSquint, "fa-grin-tongue-squint" },
            { FontAwesomeIcons.GrinTongueWink, "fa-grin-tongue-wink" },
            { FontAwesomeIcons.GrinWink, "fa-grin-wink" },
            { FontAwesomeIcons.GripHorizontal, "fa-grip-horizontal" },
            { FontAwesomeIcons.GripLines, "fa-grip-lines" },
            { FontAwesomeIcons.GripLinesVertical, "fa-grip-lines-vertical" },
            { FontAwesomeIcons.GripVertical, "fa-grip-vertical" },
            { FontAwesomeIcons.Gripfire, "fa-gripfire" },
            { FontAwesomeIcons.Grunt, "fa-grunt" },
            { FontAwesomeIcons.Guitar, "fa-guitar" },
            { FontAwesomeIcons.Gulp, "fa-gulp" },
            { FontAwesomeIcons.HSquare, "fa-h-square" },
            { FontAwesomeIcons.HackerNews, "fa-hacker-news" },
            { FontAwesomeIcons.HackerNewsSquare, "fa-hacker-news-square" },
            { FontAwesomeIcons.Hackerrank, "fa-hackerrank" },
            { FontAwesomeIcons.Hamburger, "fa-hamburger" },
            { FontAwesomeIcons.Hammer, "fa-hammer" },
            { FontAwesomeIcons.Hamsa, "fa-hamsa" },
            { FontAwesomeIcons.HandHolding, "fa-hand-holding" },
            { FontAwesomeIcons.HandHoldingHeart, "fa-hand-holding-heart" },
            { FontAwesomeIcons.HandHoldingMedical, "fa-hand-holding-medical" },
            { FontAwesomeIcons.HandHoldingUsd, "fa-hand-holding-usd" },
            { FontAwesomeIcons.HandHoldingWater, "fa-hand-holding-water" },
            { FontAwesomeIcons.HandLizard, "fa-hand-lizard" },
            { FontAwesomeIcons.HandMiddleFinger, "fa-hand-middle-finger" },
            { FontAwesomeIcons.HandPaper, "fa-hand-paper" },
            { FontAwesomeIcons.HandPeace, "fa-hand-peace" },
            { FontAwesomeIcons.HandPointDown, "fa-hand-point-down" },
            { FontAwesomeIcons.HandPointLeft, "fa-hand-point-left" },
            { FontAwesomeIcons.HandPointRight, "fa-hand-point-right" },
            { FontAwesomeIcons.HandPointUp, "fa-hand-point-up" },
            { FontAwesomeIcons.HandPointer, "fa-hand-pointer" },
            { FontAwesomeIcons.HandRock, "fa-hand-rock" },
            { FontAwesomeIcons.HandScissors, "fa-hand-scissors" },
            { FontAwesomeIcons.HandSparkles, "fa-hand-sparkles" },
            { FontAwesomeIcons.HandSpock, "fa-hand-spock" },
            { FontAwesomeIcons.Hands, "fa-hands" },
            { FontAwesomeIcons.HandsHelping, "fa-hands-helping" },
            { FontAwesomeIcons.HandsWash, "fa-hands-wash" },
            { FontAwesomeIcons.Handshake, "fa-handshake" },
            { FontAwesomeIcons.HandshakeAltSlash, "fa-handshake-alt-slash" },
            { FontAwesomeIcons.HandshakeSlash, "fa-handshake-slash" },
            { FontAwesomeIcons.Hanukiah, "fa-hanukiah" },
            { FontAwesomeIcons.HardHat, "fa-hard-hat" },
            { FontAwesomeIcons.Hashtag, "fa-hashtag" },
            { FontAwesomeIcons.HatCowboy, "fa-hat-cowboy" },
            { FontAwesomeIcons.HatCowboySide, "fa-hat-cowboy-side" },
            { FontAwesomeIcons.HatWizard, "fa-hat-wizard" },
            { FontAwesomeIcons.Hdd, "fa-hdd" },
            { FontAwesomeIcons.HeadSideCough, "fa-head-side-cough" },
            { FontAwesomeIcons.HeadSideCoughSlash, "fa-head-side-cough-slash" },
            { FontAwesomeIcons.HeadSideMask, "fa-head-side-mask" },
            { FontAwesomeIcons.HeadSideVirus, "fa-head-side-virus" },
            { FontAwesomeIcons.Heading, "fa-heading" },
            { FontAwesomeIcons.Headphones, "fa-headphones" },
            { FontAwesomeIcons.HeadphonesAlt, "fa-headphones-alt" },
            { FontAwesomeIcons.Headset, "fa-headset" },
            { FontAwesomeIcons.Heart, "fa-heart" },
            { FontAwesomeIcons.HeartBroken, "fa-heart-broken" },
            { FontAwesomeIcons.Heartbeat, "fa-heartbeat" },
            { FontAwesomeIcons.Helicopter, "fa-helicopter" },
            { FontAwesomeIcons.Highlighter, "fa-highlighter" },
            { FontAwesomeIcons.Hiking, "fa-hiking" },
            { FontAwesomeIcons.Hippo, "fa-hippo" },
            { FontAwesomeIcons.Hips, "fa-hips" },
            { FontAwesomeIcons.HireAHelper, "fa-hire-a-helper" },
            { FontAwesomeIcons.History, "fa-history" },
            { FontAwesomeIcons.HockeyPuck, "fa-hockey-puck" },
            { FontAwesomeIcons.HollyBerry, "fa-holly-berry" },
            { FontAwesomeIcons.Home, "fa-home" },
            { FontAwesomeIcons.Hooli, "fa-hooli" },
            { FontAwesomeIcons.Hornbill, "fa-hornbill" },
            { FontAwesomeIcons.Horse, "fa-horse" },
            { FontAwesomeIcons.HorseHead, "fa-horse-head" },
            { FontAwesomeIcons.Hospital, "fa-hospital" },
            { FontAwesomeIcons.HospitalAlt, "fa-hospital-alt" },
            { FontAwesomeIcons.HospitalSymbol, "fa-hospital-symbol" },
            { FontAwesomeIcons.HospitalUser, "fa-hospital-user" },
            { FontAwesomeIcons.HotTub, "fa-hot-tub" },
            { FontAwesomeIcons.Hotdog, "fa-hotdog" },
            { FontAwesomeIcons.Hotel, "fa-hotel" },
            { FontAwesomeIcons.Hotjar, "fa-hotjar" },
            { FontAwesomeIcons.Hourglass, "fa-hourglass" },
            { FontAwesomeIcons.HourglassEnd, "fa-hourglass-end" },
            { FontAwesomeIcons.HourglassHalf, "fa-hourglass-half" },
            { FontAwesomeIcons.HourglassStart, "fa-hourglass-start" },
            { FontAwesomeIcons.HouseDamage, "fa-house-damage" },
            { FontAwesomeIcons.HouseUser, "fa-house-user" },
            { FontAwesomeIcons.Houzz, "fa-houzz" },
            { FontAwesomeIcons.Hryvnia, "fa-hryvnia" },
            { FontAwesomeIcons.Html5, "fa-html5" },
            { FontAwesomeIcons.Hubspot, "fa-hubspot" },
            { FontAwesomeIcons.ICursor, "fa-i-cursor" },
            { FontAwesomeIcons.IceCream, "fa-ice-cream" },
            { FontAwesomeIcons.Icicles, "fa-icicles" },
            { FontAwesomeIcons.Icons, "fa-icons" },
            { FontAwesomeIcons.IdBadge, "fa-id-badge" },
            { FontAwesomeIcons.IdCard, "fa-id-card" },
            { FontAwesomeIcons.IdCardAlt, "fa-id-card-alt" },
            { FontAwesomeIcons.Ideal, "fa-ideal" },
            { FontAwesomeIcons.Igloo, "fa-igloo" },
            { FontAwesomeIcons.Image, "fa-image" },
            { FontAwesomeIcons.Images, "fa-images" },
            { FontAwesomeIcons.Imdb, "fa-imdb" },
            { FontAwesomeIcons.Inbox, "fa-inbox" },
            { FontAwesomeIcons.Indent, "fa-indent" },
            { FontAwesomeIcons.Industry, "fa-industry" },
            { FontAwesomeIcons.Infinity, "fa-infinity" },
            { FontAwesomeIcons.Info, "fa-info" },
            { FontAwesomeIcons.InfoCircle, "fa-info-circle" },
            { FontAwesomeIcons.Instagram, "fa-instagram" },
            { FontAwesomeIcons.InstagramSquare, "fa-instagram-square" },
            { FontAwesomeIcons.Intercom, "fa-intercom" },
            { FontAwesomeIcons.InternetExplorer, "fa-internet-explorer" },
            { FontAwesomeIcons.Invision, "fa-invision" },
            { FontAwesomeIcons.Ioxhost, "fa-ioxhost" },
            { FontAwesomeIcons.Italic, "fa-italic" },
            { FontAwesomeIcons.ItchIo, "fa-itch-io" },
            { FontAwesomeIcons.Itunes, "fa-itunes" },
            { FontAwesomeIcons.ItunesNote, "fa-itunes-note" },
            { FontAwesomeIcons.Java, "fa-java" },
            { FontAwesomeIcons.Jedi, "fa-jedi" },
            { FontAwesomeIcons.JediOrder, "fa-jedi-order" },
            { FontAwesomeIcons.Jenkins, "fa-jenkins" },
            { FontAwesomeIcons.Jira, "fa-jira" },
            { FontAwesomeIcons.Joget, "fa-joget" },
            { FontAwesomeIcons.Joint, "fa-joint" },
            { FontAwesomeIcons.Joomla, "fa-joomla" },
            { FontAwesomeIcons.JournalWhills, "fa-journal-whills" },
            { FontAwesomeIcons.Js, "fa-js" },
            { FontAwesomeIcons.JsSquare, "fa-js-square" },
            { FontAwesomeIcons.Jsfiddle, "fa-jsfiddle" },
            { FontAwesomeIcons.Kaaba, "fa-kaaba" },
            { FontAwesomeIcons.Kaggle, "fa-kaggle" },
            { FontAwesomeIcons.Key, "fa-key" },
            { FontAwesomeIcons.Keybase, "fa-keybase" },
            { FontAwesomeIcons.Keyboard, "fa-keyboard" },
            { FontAwesomeIcons.Keycdn, "fa-keycdn" },
            { FontAwesomeIcons.Khanda, "fa-khanda" },
            { FontAwesomeIcons.Kickstarter, "fa-kickstarter" },
            { FontAwesomeIcons.KickstarterK, "fa-kickstarter-k" },
            { FontAwesomeIcons.Kiss, "fa-kiss" },
            { FontAwesomeIcons.KissBeam, "fa-kiss-beam" },
            { FontAwesomeIcons.KissWinkHeart, "fa-kiss-wink-heart" },
            { FontAwesomeIcons.KiwiBird, "fa-kiwi-bird" },
            { FontAwesomeIcons.Korvue, "fa-korvue" },
            { FontAwesomeIcons.Landmark, "fa-landmark" },
            { FontAwesomeIcons.Language, "fa-language" },
            { FontAwesomeIcons.Laptop, "fa-laptop" },
            { FontAwesomeIcons.LaptopCode, "fa-laptop-code" },
            { FontAwesomeIcons.LaptopHouse, "fa-laptop-house" },
            { FontAwesomeIcons.LaptopMedical, "fa-laptop-medical" },
            { FontAwesomeIcons.Laravel, "fa-laravel" },
            { FontAwesomeIcons.Lastfm, "fa-lastfm" },
            { FontAwesomeIcons.LastfmSquare, "fa-lastfm-square" },
            { FontAwesomeIcons.Laugh, "fa-laugh" },
            { FontAwesomeIcons.LaughBeam, "fa-laugh-beam" },
            { FontAwesomeIcons.LaughSquint, "fa-laugh-squint" },
            { FontAwesomeIcons.LaughWink, "fa-laugh-wink" },
            { FontAwesomeIcons.LayerGroup, "fa-layer-group" },
            { FontAwesomeIcons.Leaf, "fa-leaf" },
            { FontAwesomeIcons.Leanpub, "fa-leanpub" },
            { FontAwesomeIcons.Lemon, "fa-lemon" },
            { FontAwesomeIcons.Less, "fa-less" },
            { FontAwesomeIcons.LessThan, "fa-less-than" },
            { FontAwesomeIcons.LessThanEqual, "fa-less-than-equal" },
            { FontAwesomeIcons.LevelDownAlt, "fa-level-down-alt" },
            { FontAwesomeIcons.LevelUpAlt, "fa-level-up-alt" },
            { FontAwesomeIcons.LifeRing, "fa-life-ring" },
            { FontAwesomeIcons.Lightbulb, "fa-lightbulb" },
            { FontAwesomeIcons.Line, "fa-line" },
            { FontAwesomeIcons.Link, "fa-link" },
            { FontAwesomeIcons.Linkedin, "fa-linkedin" },
            { FontAwesomeIcons.LinkedinIn, "fa-linkedin-in" },
            { FontAwesomeIcons.Linode, "fa-linode" },
            { FontAwesomeIcons.Linux, "fa-linux" },
            { FontAwesomeIcons.LiraSign, "fa-lira-sign" },
            { FontAwesomeIcons.List, "fa-list" },
            { FontAwesomeIcons.ListAlt, "fa-list-alt" },
            { FontAwesomeIcons.ListOl, "fa-list-ol" },
            { FontAwesomeIcons.ListUl, "fa-list-ul" },
            { FontAwesomeIcons.LocationArrow, "fa-location-arrow" },
            { FontAwesomeIcons.Lock, "fa-lock" },
            { FontAwesomeIcons.LockOpen, "fa-lock-open" },
            { FontAwesomeIcons.LongArrowAltDown, "fa-long-arrow-alt-down" },
            { FontAwesomeIcons.LongArrowAltLeft, "fa-long-arrow-alt-left" },
            { FontAwesomeIcons.LongArrowAltRight, "fa-long-arrow-alt-right" },
            { FontAwesomeIcons.LongArrowAltUp, "fa-long-arrow-alt-up" },
            { FontAwesomeIcons.LowVision, "fa-low-vision" },
            { FontAwesomeIcons.LuggageCart, "fa-luggage-cart" },
            { FontAwesomeIcons.Lungs, "fa-lungs" },
            { FontAwesomeIcons.LungsVirus, "fa-lungs-virus" },
            { FontAwesomeIcons.Lyft, "fa-lyft" },
            { FontAwesomeIcons.Magento, "fa-magento" },
            { FontAwesomeIcons.Magic, "fa-magic" },
            { FontAwesomeIcons.Magnet, "fa-magnet" },
            { FontAwesomeIcons.MailBulk, "fa-mail-bulk" },
            { FontAwesomeIcons.Mailchimp, "fa-mailchimp" },
            { FontAwesomeIcons.Male, "fa-male" },
            { FontAwesomeIcons.Mandalorian, "fa-mandalorian" },
            { FontAwesomeIcons.Map, "fa-map" },
            { FontAwesomeIcons.MapMarked, "fa-map-marked" },
            { FontAwesomeIcons.MapMarkedAlt, "fa-map-marked-alt" },
            { FontAwesomeIcons.MapMarker, "fa-map-marker" },
            { FontAwesomeIcons.MapMarkerAlt, "fa-map-marker-alt" },
            { FontAwesomeIcons.MapPin, "fa-map-pin" },
            { FontAwesomeIcons.MapSigns, "fa-map-signs" },
            { FontAwesomeIcons.Markdown, "fa-markdown" },
            { FontAwesomeIcons.Marker, "fa-marker" },
            { FontAwesomeIcons.Mars, "fa-mars" },
            { FontAwesomeIcons.MarsDouble, "fa-mars-double" },
            { FontAwesomeIcons.MarsStroke, "fa-mars-stroke" },
            { FontAwesomeIcons.MarsStrokeH, "fa-mars-stroke-h" },
            { FontAwesomeIcons.MarsStrokeV, "fa-mars-stroke-v" },
            { FontAwesomeIcons.Mask, "fa-mask" },
            { FontAwesomeIcons.Mastodon, "fa-mastodon" },
            { FontAwesomeIcons.Maxcdn, "fa-maxcdn" },
            { FontAwesomeIcons.Mdb, "fa-mdb" },
            { FontAwesomeIcons.Medal, "fa-medal" },
            { FontAwesomeIcons.Medapps, "fa-medapps" },
            { FontAwesomeIcons.Medium, "fa-medium" },
            { FontAwesomeIcons.MediumM, "fa-medium-m" },
            { FontAwesomeIcons.Medkit, "fa-medkit" },
            { FontAwesomeIcons.Medrt, "fa-medrt" },
            { FontAwesomeIcons.Meetup, "fa-meetup" },
            { FontAwesomeIcons.Megaport, "fa-megaport" },
            { FontAwesomeIcons.Meh, "fa-meh" },
            { FontAwesomeIcons.MehBlank, "fa-meh-blank" },
            { FontAwesomeIcons.MehRollingEyes, "fa-meh-rolling-eyes" },
            { FontAwesomeIcons.Memory, "fa-memory" },
            { FontAwesomeIcons.Mendeley, "fa-mendeley" },
            { FontAwesomeIcons.Menorah, "fa-menorah" },
            { FontAwesomeIcons.Mercury, "fa-mercury" },
            { FontAwesomeIcons.Meteor, "fa-meteor" },
            { FontAwesomeIcons.Microblog, "fa-microblog" },
            { FontAwesomeIcons.Microchip, "fa-microchip" },
            { FontAwesomeIcons.Microphone, "fa-microphone" },
            { FontAwesomeIcons.MicrophoneAlt, "fa-microphone-alt" },
            { FontAwesomeIcons.MicrophoneAltSlash, "fa-microphone-alt-slash" },
            { FontAwesomeIcons.MicrophoneSlash, "fa-microphone-slash" },
            { FontAwesomeIcons.Microscope, "fa-microscope" },
            { FontAwesomeIcons.Microsoft, "fa-microsoft" },
            { FontAwesomeIcons.Minus, "fa-minus" },
            { FontAwesomeIcons.MinusCircle, "fa-minus-circle" },
            { FontAwesomeIcons.MinusSquare, "fa-minus-square" },
            { FontAwesomeIcons.Mitten, "fa-mitten" },
            { FontAwesomeIcons.Mix, "fa-mix" },
            { FontAwesomeIcons.Mixcloud, "fa-mixcloud" },
            { FontAwesomeIcons.Mixer, "fa-mixer" },
            { FontAwesomeIcons.Mizuni, "fa-mizuni" },
            { FontAwesomeIcons.Mobile, "fa-mobile" },
            { FontAwesomeIcons.MobileAlt, "fa-mobile-alt" },
            { FontAwesomeIcons.Modx, "fa-modx" },
            { FontAwesomeIcons.Monero, "fa-monero" },
            { FontAwesomeIcons.MoneyBill, "fa-money-bill" },
            { FontAwesomeIcons.MoneyBillAlt, "fa-money-bill-alt" },
            { FontAwesomeIcons.MoneyBillWave, "fa-money-bill-wave" },
            { FontAwesomeIcons.MoneyBillWaveAlt, "fa-money-bill-wave-alt" },
            { FontAwesomeIcons.MoneyCheck, "fa-money-check" },
            { FontAwesomeIcons.MoneyCheckAlt, "fa-money-check-alt" },
            { FontAwesomeIcons.Monument, "fa-monument" },
            { FontAwesomeIcons.Moon, "fa-moon" },
            { FontAwesomeIcons.MortarPestle, "fa-mortar-pestle" },
            { FontAwesomeIcons.Mosque, "fa-mosque" },
            { FontAwesomeIcons.Motorcycle, "fa-motorcycle" },
            { FontAwesomeIcons.Mountain, "fa-mountain" },
            { FontAwesomeIcons.Mouse, "fa-mouse" },
            { FontAwesomeIcons.MousePointer, "fa-mouse-pointer" },
            { FontAwesomeIcons.MugHot, "fa-mug-hot" },
            { FontAwesomeIcons.Music, "fa-music" },
            { FontAwesomeIcons.Napster, "fa-napster" },
            { FontAwesomeIcons.Neos, "fa-neos" },
            { FontAwesomeIcons.NetworkWired, "fa-network-wired" },
            { FontAwesomeIcons.Neuter, "fa-neuter" },
            { FontAwesomeIcons.Newspaper, "fa-newspaper" },
            { FontAwesomeIcons.Nimblr, "fa-nimblr" },
            { FontAwesomeIcons.Node, "fa-node" },
            { FontAwesomeIcons.NodeJs, "fa-node-js" },
            { FontAwesomeIcons.NotEqual, "fa-not-equal" },
            { FontAwesomeIcons.NotesMedical, "fa-notes-medical" },
            { FontAwesomeIcons.Npm, "fa-npm" },
            { FontAwesomeIcons.Ns8, "fa-ns8" },
            { FontAwesomeIcons.Nutritionix, "fa-nutritionix" },
            { FontAwesomeIcons.ObjectGroup, "fa-object-group" },
            { FontAwesomeIcons.ObjectUngroup, "fa-object-ungroup" },
            { FontAwesomeIcons.Odnoklassniki, "fa-odnoklassniki" },
            { FontAwesomeIcons.OdnoklassnikiSquare, "fa-odnoklassniki-square" },
            { FontAwesomeIcons.OilCan, "fa-oil-can" },
            { FontAwesomeIcons.OldRepublic, "fa-old-republic" },
            { FontAwesomeIcons.Om, "fa-om" },
            { FontAwesomeIcons.Opencart, "fa-opencart" },
            { FontAwesomeIcons.Openid, "fa-openid" },
            { FontAwesomeIcons.Opera, "fa-opera" },
            { FontAwesomeIcons.OptinMonster, "fa-optin-monster" },
            { FontAwesomeIcons.Orcid, "fa-orcid" },
            { FontAwesomeIcons.Osi, "fa-osi" },
            { FontAwesomeIcons.Otter, "fa-otter" },
            { FontAwesomeIcons.Outdent, "fa-outdent" },
            { FontAwesomeIcons.Page4, "fa-page4" },
            { FontAwesomeIcons.Pagelines, "fa-pagelines" },
            { FontAwesomeIcons.Pager, "fa-pager" },
            { FontAwesomeIcons.PaintBrush, "fa-paint-brush" },
            { FontAwesomeIcons.PaintRoller, "fa-paint-roller" },
            { FontAwesomeIcons.Palette, "fa-palette" },
            { FontAwesomeIcons.Palfed, "fa-palfed" },
            { FontAwesomeIcons.Pallet, "fa-pallet" },
            { FontAwesomeIcons.PaperPlane, "fa-paper-plane" },
            { FontAwesomeIcons.Paperclip, "fa-paperclip" },
            { FontAwesomeIcons.ParachuteBox, "fa-parachute-box" },
            { FontAwesomeIcons.Paragraph, "fa-paragraph" },
            { FontAwesomeIcons.Parking, "fa-parking" },
            { FontAwesomeIcons.Passport, "fa-passport" },
            { FontAwesomeIcons.Pastafarianism, "fa-pastafarianism" },
            { FontAwesomeIcons.Paste, "fa-paste" },
            { FontAwesomeIcons.Patreon, "fa-patreon" },
            { FontAwesomeIcons.Pause, "fa-pause" },
            { FontAwesomeIcons.PauseCircle, "fa-pause-circle" },
            { FontAwesomeIcons.Paw, "fa-paw" },
            { FontAwesomeIcons.Paypal, "fa-paypal" },
            { FontAwesomeIcons.Peace, "fa-peace" },
            { FontAwesomeIcons.Pen, "fa-pen" },
            { FontAwesomeIcons.PenAlt, "fa-pen-alt" },
            { FontAwesomeIcons.PenFancy, "fa-pen-fancy" },
            { FontAwesomeIcons.PenNib, "fa-pen-nib" },
            { FontAwesomeIcons.PenSquare, "fa-pen-square" },
            { FontAwesomeIcons.PencilAlt, "fa-pencil-alt" },
            { FontAwesomeIcons.PencilRuler, "fa-pencil-ruler" },
            { FontAwesomeIcons.PennyArcade, "fa-penny-arcade" },
            { FontAwesomeIcons.PeopleArrows, "fa-people-arrows" },
            { FontAwesomeIcons.PeopleCarry, "fa-people-carry" },
            { FontAwesomeIcons.PepperHot, "fa-pepper-hot" },
            { FontAwesomeIcons.Percent, "fa-percent" },
            { FontAwesomeIcons.Percentage, "fa-percentage" },
            { FontAwesomeIcons.Periscope, "fa-periscope" },
            { FontAwesomeIcons.PersonBooth, "fa-person-booth" },
            { FontAwesomeIcons.Phabricator, "fa-phabricator" },
            { FontAwesomeIcons.PhoenixFramework, "fa-phoenix-framework" },
            { FontAwesomeIcons.PhoenixSquadron, "fa-phoenix-squadron" },
            { FontAwesomeIcons.Phone, "fa-phone" },
            { FontAwesomeIcons.PhoneAlt, "fa-phone-alt" },
            { FontAwesomeIcons.PhoneSlash, "fa-phone-slash" },
            { FontAwesomeIcons.PhoneSquare, "fa-phone-square" },
            { FontAwesomeIcons.PhoneSquareAlt, "fa-phone-square-alt" },
            { FontAwesomeIcons.PhoneVolume, "fa-phone-volume" },
            { FontAwesomeIcons.PhotoVideo, "fa-photo-video" },
            { FontAwesomeIcons.Php, "fa-php" },
            { FontAwesomeIcons.PiedPiper, "fa-pied-piper" },
            { FontAwesomeIcons.PiedPiperAlt, "fa-pied-piper-alt" },
            { FontAwesomeIcons.PiedPiperHat, "fa-pied-piper-hat" },
            { FontAwesomeIcons.PiedPiperPp, "fa-pied-piper-pp" },
            { FontAwesomeIcons.PiedPiperSquare, "fa-pied-piper-square" },
            { FontAwesomeIcons.PiggyBank, "fa-piggy-bank" },
            { FontAwesomeIcons.Pills, "fa-pills" },
            { FontAwesomeIcons.Pinterest, "fa-pinterest" },
            { FontAwesomeIcons.PinterestP, "fa-pinterest-p" },
            { FontAwesomeIcons.PinterestSquare, "fa-pinterest-square" },
            { FontAwesomeIcons.PizzaSlice, "fa-pizza-slice" },
            { FontAwesomeIcons.PlaceOfWorship, "fa-place-of-worship" },
            { FontAwesomeIcons.Plane, "fa-plane" },
            { FontAwesomeIcons.PlaneArrival, "fa-plane-arrival" },
            { FontAwesomeIcons.PlaneDeparture, "fa-plane-departure" },
            { FontAwesomeIcons.PlaneSlash, "fa-plane-slash" },
            { FontAwesomeIcons.Play, "fa-play" },
            { FontAwesomeIcons.PlayCircle, "fa-play-circle" },
            { FontAwesomeIcons.Playstation, "fa-playstation" },
            { FontAwesomeIcons.Plug, "fa-plug" },
            { FontAwesomeIcons.Plus, "fa-plus" },
            { FontAwesomeIcons.PlusCircle, "fa-plus-circle" },
            { FontAwesomeIcons.PlusSquare, "fa-plus-square" },
            { FontAwesomeIcons.Podcast, "fa-podcast" },
            { FontAwesomeIcons.Poll, "fa-poll" },
            { FontAwesomeIcons.PollH, "fa-poll-h" },
            { FontAwesomeIcons.Poo, "fa-poo" },
            { FontAwesomeIcons.PooStorm, "fa-poo-storm" },
            { FontAwesomeIcons.Poop, "fa-poop" },
            { FontAwesomeIcons.Portrait, "fa-portrait" },
            { FontAwesomeIcons.PoundSign, "fa-pound-sign" },
            { FontAwesomeIcons.PowerOff, "fa-power-off" },
            { FontAwesomeIcons.Pray, "fa-pray" },
            { FontAwesomeIcons.PrayingHands, "fa-praying-hands" },
            { FontAwesomeIcons.Prescription, "fa-prescription" },
            { FontAwesomeIcons.PrescriptionBottle, "fa-prescription-bottle" },
            { FontAwesomeIcons.PrescriptionBottleAlt, "fa-prescription-bottle-alt" },
            { FontAwesomeIcons.Print, "fa-print" },
            { FontAwesomeIcons.Procedures, "fa-procedures" },
            { FontAwesomeIcons.ProductHunt, "fa-product-hunt" },
            { FontAwesomeIcons.ProjectDiagram, "fa-project-diagram" },
            { FontAwesomeIcons.PumpMedical, "fa-pump-medical" },
            { FontAwesomeIcons.PumpSoap, "fa-pump-soap" },
            { FontAwesomeIcons.Pushed, "fa-pushed" },
            { FontAwesomeIcons.PuzzlePiece, "fa-puzzle-piece" },
            { FontAwesomeIcons.Python, "fa-python" },
            { FontAwesomeIcons.Qq, "fa-qq" },
            { FontAwesomeIcons.Qrcode, "fa-qrcode" },
            { FontAwesomeIcons.Question, "fa-question" },
            { FontAwesomeIcons.QuestionCircle, "fa-question-circle" },
            { FontAwesomeIcons.Quidditch, "fa-quidditch" },
            { FontAwesomeIcons.Quinscape, "fa-quinscape" },
            { FontAwesomeIcons.Quora, "fa-quora" },
            { FontAwesomeIcons.QuoteLeft, "fa-quote-left" },
            { FontAwesomeIcons.QuoteRight, "fa-quote-right" },
            { FontAwesomeIcons.Quran, "fa-quran" },
            { FontAwesomeIcons.RProject, "fa-r-project" },
            { FontAwesomeIcons.Radiation, "fa-radiation" },
            { FontAwesomeIcons.RadiationAlt, "fa-radiation-alt" },
            { FontAwesomeIcons.Rainbow, "fa-rainbow" },
            { FontAwesomeIcons.Random, "fa-random" },
            { FontAwesomeIcons.RaspberryPi, "fa-raspberry-pi" },
            { FontAwesomeIcons.Ravelry, "fa-ravelry" },
            { FontAwesomeIcons.React, "fa-react" },
            { FontAwesomeIcons.Reacteurope, "fa-reacteurope" },
            { FontAwesomeIcons.Readme, "fa-readme" },
            { FontAwesomeIcons.Rebel, "fa-rebel" },
            { FontAwesomeIcons.Receipt, "fa-receipt" },
            { FontAwesomeIcons.RecordVinyl, "fa-record-vinyl" },
            { FontAwesomeIcons.Recycle, "fa-recycle" },
            { FontAwesomeIcons.RedRiver, "fa-red-river" },
            { FontAwesomeIcons.Reddit, "fa-reddit" },
            { FontAwesomeIcons.RedditAlien, "fa-reddit-alien" },
            { FontAwesomeIcons.RedditSquare, "fa-reddit-square" },
            { FontAwesomeIcons.Redhat, "fa-redhat" },
            { FontAwesomeIcons.Redo, "fa-redo" },
            { FontAwesomeIcons.RedoAlt, "fa-redo-alt" },
            { FontAwesomeIcons.Registered, "fa-registered" },
            { FontAwesomeIcons.RemoveFormat, "fa-remove-format" },
            { FontAwesomeIcons.Renren, "fa-renren" },
            { FontAwesomeIcons.Reply, "fa-reply" },
            { FontAwesomeIcons.ReplyAll, "fa-reply-all" },
            { FontAwesomeIcons.Replyd, "fa-replyd" },
            { FontAwesomeIcons.Republican, "fa-republican" },
            { FontAwesomeIcons.Researchgate, "fa-researchgate" },
            { FontAwesomeIcons.Resolving, "fa-resolving" },
            { FontAwesomeIcons.Restroom, "fa-restroom" },
            { FontAwesomeIcons.Retweet, "fa-retweet" },
            { FontAwesomeIcons.Rev, "fa-rev" },
            { FontAwesomeIcons.Ribbon, "fa-ribbon" },
            { FontAwesomeIcons.Ring, "fa-ring" },
            { FontAwesomeIcons.Road, "fa-road" },
            { FontAwesomeIcons.Robot, "fa-robot" },
            { FontAwesomeIcons.Rocket, "fa-rocket" },
            { FontAwesomeIcons.Rocketchat, "fa-rocketchat" },
            { FontAwesomeIcons.Rockrms, "fa-rockrms" },
            { FontAwesomeIcons.Route, "fa-route" },
            { FontAwesomeIcons.Rss, "fa-rss" },
            { FontAwesomeIcons.RssSquare, "fa-rss-square" },
            { FontAwesomeIcons.RubleSign, "fa-ruble-sign" },
            { FontAwesomeIcons.Ruler, "fa-ruler" },
            { FontAwesomeIcons.RulerCombined, "fa-ruler-combined" },
            { FontAwesomeIcons.RulerHorizontal, "fa-ruler-horizontal" },
            { FontAwesomeIcons.RulerVertical, "fa-ruler-vertical" },
            { FontAwesomeIcons.Running, "fa-running" },
            { FontAwesomeIcons.RupeeSign, "fa-rupee-sign" },
            { FontAwesomeIcons.SadCry, "fa-sad-cry" },
            { FontAwesomeIcons.SadTear, "fa-sad-tear" },
            { FontAwesomeIcons.Safari, "fa-safari" },
            { FontAwesomeIcons.Salesforce, "fa-salesforce" },
            { FontAwesomeIcons.Sass, "fa-sass" },
            { FontAwesomeIcons.Satellite, "fa-satellite" },
            { FontAwesomeIcons.SatelliteDish, "fa-satellite-dish" },
            { FontAwesomeIcons.Save, "fa-save" },
            { FontAwesomeIcons.Schlix, "fa-schlix" },
            { FontAwesomeIcons.School, "fa-school" },
            { FontAwesomeIcons.Screwdriver, "fa-screwdriver" },
            { FontAwesomeIcons.Scribd, "fa-scribd" },
            { FontAwesomeIcons.Scroll, "fa-scroll" },
            { FontAwesomeIcons.SdCard, "fa-sd-card" },
            { FontAwesomeIcons.Search, "fa-search" },
            { FontAwesomeIcons.SearchDollar, "fa-search-dollar" },
            { FontAwesomeIcons.SearchLocation, "fa-search-location" },
            { FontAwesomeIcons.SearchMinus, "fa-search-minus" },
            { FontAwesomeIcons.SearchPlus, "fa-search-plus" },
            { FontAwesomeIcons.Searchengin, "fa-searchengin" },
            { FontAwesomeIcons.Seedling, "fa-seedling" },
            { FontAwesomeIcons.Sellcast, "fa-sellcast" },
            { FontAwesomeIcons.Sellsy, "fa-sellsy" },
            { FontAwesomeIcons.Server, "fa-server" },
            { FontAwesomeIcons.Servicestack, "fa-servicestack" },
            { FontAwesomeIcons.Shapes, "fa-shapes" },
            { FontAwesomeIcons.Share, "fa-share" },
            { FontAwesomeIcons.ShareAlt, "fa-share-alt" },
            { FontAwesomeIcons.ShareAltSquare, "fa-share-alt-square" },
            { FontAwesomeIcons.ShareSquare, "fa-share-square" },
            { FontAwesomeIcons.ShekelSign, "fa-shekel-sign" },
            { FontAwesomeIcons.ShieldAlt, "fa-shield-alt" },
            { FontAwesomeIcons.ShieldVirus, "fa-shield-virus" },
            { FontAwesomeIcons.Ship, "fa-ship" },
            { FontAwesomeIcons.ShippingFast, "fa-shipping-fast" },
            { FontAwesomeIcons.Shirtsinbulk, "fa-shirtsinbulk" },
            { FontAwesomeIcons.ShoePrints, "fa-shoe-prints" },
            { FontAwesomeIcons.Shopify, "fa-shopify" },
            { FontAwesomeIcons.ShoppingBag, "fa-shopping-bag" },
            { FontAwesomeIcons.ShoppingBasket, "fa-shopping-basket" },
            { FontAwesomeIcons.ShoppingCart, "fa-shopping-cart" },
            { FontAwesomeIcons.Shopware, "fa-shopware" },
            { FontAwesomeIcons.Shower, "fa-shower" },
            { FontAwesomeIcons.ShuttleVan, "fa-shuttle-van" },
            { FontAwesomeIcons.Sign, "fa-sign" },
            { FontAwesomeIcons.SignInAlt, "fa-sign-in-alt" },
            { FontAwesomeIcons.SignLanguage, "fa-sign-language" },
            { FontAwesomeIcons.SignOutAlt, "fa-sign-out-alt" },
            { FontAwesomeIcons.Signal, "fa-signal" },
            { FontAwesomeIcons.Signature, "fa-signature" },
            { FontAwesomeIcons.SimCard, "fa-sim-card" },
            { FontAwesomeIcons.Simplybuilt, "fa-simplybuilt" },
            { FontAwesomeIcons.Sistrix, "fa-sistrix" },
            { FontAwesomeIcons.Sitemap, "fa-sitemap" },
            { FontAwesomeIcons.Sith, "fa-sith" },
            { FontAwesomeIcons.Skating, "fa-skating" },
            { FontAwesomeIcons.Sketch, "fa-sketch" },
            { FontAwesomeIcons.Skiing, "fa-skiing" },
            { FontAwesomeIcons.SkiingNordic, "fa-skiing-nordic" },
            { FontAwesomeIcons.Skull, "fa-skull" },
            { FontAwesomeIcons.SkullCrossbones, "fa-skull-crossbones" },
            { FontAwesomeIcons.Skyatlas, "fa-skyatlas" },
            { FontAwesomeIcons.Skype, "fa-skype" },
            { FontAwesomeIcons.Slack, "fa-slack" },
            { FontAwesomeIcons.SlackHash, "fa-slack-hash" },
            { FontAwesomeIcons.Slash, "fa-slash" },
            { FontAwesomeIcons.Sleigh, "fa-sleigh" },
            { FontAwesomeIcons.SlidersH, "fa-sliders-h" },
            { FontAwesomeIcons.Slideshare, "fa-slideshare" },
            { FontAwesomeIcons.Smile, "fa-smile" },
            { FontAwesomeIcons.SmileBeam, "fa-smile-beam" },
            { FontAwesomeIcons.SmileWink, "fa-smile-wink" },
            { FontAwesomeIcons.Smog, "fa-smog" },
            { FontAwesomeIcons.Smoking, "fa-smoking" },
            { FontAwesomeIcons.SmokingBan, "fa-smoking-ban" },
            { FontAwesomeIcons.Sms, "fa-sms" },
            { FontAwesomeIcons.Snapchat, "fa-snapchat" },
            { FontAwesomeIcons.SnapchatGhost, "fa-snapchat-ghost" },
            { FontAwesomeIcons.SnapchatSquare, "fa-snapchat-square" },
            { FontAwesomeIcons.Snowboarding, "fa-snowboarding" },
            { FontAwesomeIcons.Snowflake, "fa-snowflake" },
            { FontAwesomeIcons.Snowman, "fa-snowman" },
            { FontAwesomeIcons.Snowplow, "fa-snowplow" },
            { FontAwesomeIcons.Soap, "fa-soap" },
            { FontAwesomeIcons.Socks, "fa-socks" },
            { FontAwesomeIcons.SolarPanel, "fa-solar-panel" },
            { FontAwesomeIcons.Sort, "fa-sort" },
            { FontAwesomeIcons.SortAlphaDown, "fa-sort-alpha-down" },
            { FontAwesomeIcons.SortAlphaDownAlt, "fa-sort-alpha-down-alt" },
            { FontAwesomeIcons.SortAlphaUp, "fa-sort-alpha-up" },
            { FontAwesomeIcons.SortAlphaUpAlt, "fa-sort-alpha-up-alt" },
            { FontAwesomeIcons.SortAmountDown, "fa-sort-amount-down" },
            { FontAwesomeIcons.SortAmountDownAlt, "fa-sort-amount-down-alt" },
            { FontAwesomeIcons.SortAmountUp, "fa-sort-amount-up" },
            { FontAwesomeIcons.SortAmountUpAlt, "fa-sort-amount-up-alt" },
            { FontAwesomeIcons.SortDown, "fa-sort-down" },
            { FontAwesomeIcons.SortNumericDown, "fa-sort-numeric-down" },
            { FontAwesomeIcons.SortNumericDownAlt, "fa-sort-numeric-down-alt" },
            { FontAwesomeIcons.SortNumericUp, "fa-sort-numeric-up" },
            { FontAwesomeIcons.SortNumericUpAlt, "fa-sort-numeric-up-alt" },
            { FontAwesomeIcons.SortUp, "fa-sort-up" },
            { FontAwesomeIcons.Soundcloud, "fa-soundcloud" },
            { FontAwesomeIcons.Sourcetree, "fa-sourcetree" },
            { FontAwesomeIcons.Spa, "fa-spa" },
            { FontAwesomeIcons.SpaceShuttle, "fa-space-shuttle" },
            { FontAwesomeIcons.Speakap, "fa-speakap" },
            { FontAwesomeIcons.SpeakerDeck, "fa-speaker-deck" },
            { FontAwesomeIcons.SpellCheck, "fa-spell-check" },
            { FontAwesomeIcons.Spider, "fa-spider" },
            { FontAwesomeIcons.Spinner, "fa-spinner" },
            { FontAwesomeIcons.Splotch, "fa-splotch" },
            { FontAwesomeIcons.Spotify, "fa-spotify" },
            { FontAwesomeIcons.SprayCan, "fa-spray-can" },
            { FontAwesomeIcons.Square, "fa-square" },
            { FontAwesomeIcons.SquareFull, "fa-square-full" },
            { FontAwesomeIcons.SquareRootAlt, "fa-square-root-alt" },
            { FontAwesomeIcons.Squarespace, "fa-squarespace" },
            { FontAwesomeIcons.StackExchange, "fa-stack-exchange" },
            { FontAwesomeIcons.StackOverflow, "fa-stack-overflow" },
            { FontAwesomeIcons.Stackpath, "fa-stackpath" },
            { FontAwesomeIcons.Stamp, "fa-stamp" },
            { FontAwesomeIcons.Star, "fa-star" },
            { FontAwesomeIcons.StarAndCrescent, "fa-star-and-crescent" },
            { FontAwesomeIcons.StarHalf, "fa-star-half" },
            { FontAwesomeIcons.StarHalfAlt, "fa-star-half-alt" },
            { FontAwesomeIcons.StarOfDavid, "fa-star-of-david" },
            { FontAwesomeIcons.StarOfLife, "fa-star-of-life" },
            { FontAwesomeIcons.Staylinked, "fa-staylinked" },
            { FontAwesomeIcons.Steam, "fa-steam" },
            { FontAwesomeIcons.SteamSquare, "fa-steam-square" },
            { FontAwesomeIcons.SteamSymbol, "fa-steam-symbol" },
            { FontAwesomeIcons.StepBackward, "fa-step-backward" },
            { FontAwesomeIcons.StepForward, "fa-step-forward" },
            { FontAwesomeIcons.Stethoscope, "fa-stethoscope" },
            { FontAwesomeIcons.StickerMule, "fa-sticker-mule" },
            { FontAwesomeIcons.StickyNote, "fa-sticky-note" },
            { FontAwesomeIcons.Stop, "fa-stop" },
            { FontAwesomeIcons.StopCircle, "fa-stop-circle" },
            { FontAwesomeIcons.Stopwatch, "fa-stopwatch" },
            { FontAwesomeIcons.Stopwatch20, "fa-stopwatch-20" },
            { FontAwesomeIcons.Store, "fa-store" },
            { FontAwesomeIcons.StoreAlt, "fa-store-alt" },
            { FontAwesomeIcons.StoreAltSlash, "fa-store-alt-slash" },
            { FontAwesomeIcons.StoreSlash, "fa-store-slash" },
            { FontAwesomeIcons.Strava, "fa-strava" },
            { FontAwesomeIcons.Stream, "fa-stream" },
            { FontAwesomeIcons.StreetView, "fa-street-view" },
            { FontAwesomeIcons.Strikethrough, "fa-strikethrough" },
            { FontAwesomeIcons.Stripe, "fa-stripe" },
            { FontAwesomeIcons.StripeS, "fa-stripe-s" },
            { FontAwesomeIcons.Stroopwafel, "fa-stroopwafel" },
            { FontAwesomeIcons.Studiovinari, "fa-studiovinari" },
            { FontAwesomeIcons.Stumbleupon, "fa-stumbleupon" },
            { FontAwesomeIcons.StumbleuponCircle, "fa-stumbleupon-circle" },
            { FontAwesomeIcons.Subscript, "fa-subscript" },
            { FontAwesomeIcons.Subway, "fa-subway" },
            { FontAwesomeIcons.Suitcase, "fa-suitcase" },
            { FontAwesomeIcons.SuitcaseRolling, "fa-suitcase-rolling" },
            { FontAwesomeIcons.Sun, "fa-sun" },
            { FontAwesomeIcons.Superpowers, "fa-superpowers" },
            { FontAwesomeIcons.Superscript, "fa-superscript" },
            { FontAwesomeIcons.Supple, "fa-supple" },
            { FontAwesomeIcons.Surprise, "fa-surprise" },
            { FontAwesomeIcons.Suse, "fa-suse" },
            { FontAwesomeIcons.Swatchbook, "fa-swatchbook" },
            { FontAwesomeIcons.Swift, "fa-swift" },
            { FontAwesomeIcons.Swimmer, "fa-swimmer" },
            { FontAwesomeIcons.SwimmingPool, "fa-swimming-pool" },
            { FontAwesomeIcons.Symfony, "fa-symfony" },
            { FontAwesomeIcons.Synagogue, "fa-synagogue" },
            { FontAwesomeIcons.Sync, "fa-sync" },
            { FontAwesomeIcons.SyncAlt, "fa-sync-alt" },
            { FontAwesomeIcons.Syringe, "fa-syringe" },
            { FontAwesomeIcons.Table, "fa-table" },
            { FontAwesomeIcons.TableTennis, "fa-table-tennis" },
            { FontAwesomeIcons.Tablet, "fa-tablet" },
            { FontAwesomeIcons.TabletAlt, "fa-tablet-alt" },
            { FontAwesomeIcons.Tablets, "fa-tablets" },
            { FontAwesomeIcons.TachometerAlt, "fa-tachometer-alt" },
            { FontAwesomeIcons.Tag, "fa-tag" },
            { FontAwesomeIcons.Tags, "fa-tags" },
            { FontAwesomeIcons.Tape, "fa-tape" },
            { FontAwesomeIcons.Tasks, "fa-tasks" },
            { FontAwesomeIcons.Taxi, "fa-taxi" },
            { FontAwesomeIcons.Teamspeak, "fa-teamspeak" },
            { FontAwesomeIcons.Teeth, "fa-teeth" },
            { FontAwesomeIcons.TeethOpen, "fa-teeth-open" },
            { FontAwesomeIcons.Telegram, "fa-telegram" },
            { FontAwesomeIcons.TelegramPlane, "fa-telegram-plane" },
            { FontAwesomeIcons.TemperatureHigh, "fa-temperature-high" },
            { FontAwesomeIcons.TemperatureLow, "fa-temperature-low" },
            { FontAwesomeIcons.TencentWeibo, "fa-tencent-weibo" },
            { FontAwesomeIcons.Tenge, "fa-tenge" },
            { FontAwesomeIcons.Terminal, "fa-terminal" },
            { FontAwesomeIcons.TextHeight, "fa-text-height" },
            { FontAwesomeIcons.TextWidth, "fa-text-width" },
            { FontAwesomeIcons.Th, "fa-th" },
            { FontAwesomeIcons.ThLarge, "fa-th-large" },
            { FontAwesomeIcons.ThList, "fa-th-list" },
            { FontAwesomeIcons.TheRedYeti, "fa-the-red-yeti" },
            { FontAwesomeIcons.TheaterMasks, "fa-theater-masks" },
            { FontAwesomeIcons.Themeco, "fa-themeco" },
            { FontAwesomeIcons.Themeisle, "fa-themeisle" },
            { FontAwesomeIcons.Thermometer, "fa-thermometer" },
            { FontAwesomeIcons.ThermometerEmpty, "fa-thermometer-empty" },
            { FontAwesomeIcons.ThermometerFull, "fa-thermometer-full" },
            { FontAwesomeIcons.ThermometerHalf, "fa-thermometer-half" },
            { FontAwesomeIcons.ThermometerQuarter, "fa-thermometer-quarter" },
            { FontAwesomeIcons.ThermometerThreeQuarters, "fa-thermometer-three-quarters" },
            { FontAwesomeIcons.ThinkPeaks, "fa-think-peaks" },
            { FontAwesomeIcons.ThumbsDown, "fa-thumbs-down" },
            { FontAwesomeIcons.ThumbsUp, "fa-thumbs-up" },
            { FontAwesomeIcons.Thumbtack, "fa-thumbtack" },
            { FontAwesomeIcons.TicketAlt, "fa-ticket-alt" },
            { FontAwesomeIcons.Times, "fa-times" },
            { FontAwesomeIcons.TimesCircle, "fa-times-circle" },
            { FontAwesomeIcons.Tint, "fa-tint" },
            { FontAwesomeIcons.TintSlash, "fa-tint-slash" },
            { FontAwesomeIcons.Tired, "fa-tired" },
            { FontAwesomeIcons.ToggleOff, "fa-toggle-off" },
            { FontAwesomeIcons.ToggleOn, "fa-toggle-on" },
            { FontAwesomeIcons.Toilet, "fa-toilet" },
            { FontAwesomeIcons.ToiletPaper, "fa-toilet-paper" },
            { FontAwesomeIcons.ToiletPaperSlash, "fa-toilet-paper-slash" },
            { FontAwesomeIcons.Toolbox, "fa-toolbox" },
            { FontAwesomeIcons.Tools, "fa-tools" },
            { FontAwesomeIcons.Tooth, "fa-tooth" },
            { FontAwesomeIcons.Torah, "fa-torah" },
            { FontAwesomeIcons.ToriiGate, "fa-torii-gate" },
            { FontAwesomeIcons.Tractor, "fa-tractor" },
            { FontAwesomeIcons.TradeFederation, "fa-trade-federation" },
            { FontAwesomeIcons.Trademark, "fa-trademark" },
            { FontAwesomeIcons.TrafficLight, "fa-traffic-light" },
            { FontAwesomeIcons.Trailer, "fa-trailer" },
            { FontAwesomeIcons.Train, "fa-train" },
            { FontAwesomeIcons.Tram, "fa-tram" },
            { FontAwesomeIcons.Transgender, "fa-transgender" },
            { FontAwesomeIcons.TransgenderAlt, "fa-transgender-alt" },
            { FontAwesomeIcons.Trash, "fa-trash" },
            { FontAwesomeIcons.TrashAlt, "fa-trash-alt" },
            { FontAwesomeIcons.TrashRestore, "fa-trash-restore" },
            { FontAwesomeIcons.TrashRestoreAlt, "fa-trash-restore-alt" },
            { FontAwesomeIcons.Tree, "fa-tree" },
            { FontAwesomeIcons.Trello, "fa-trello" },
            { FontAwesomeIcons.Tripadvisor, "fa-tripadvisor" },
            { FontAwesomeIcons.Trophy, "fa-trophy" },
            { FontAwesomeIcons.Truck, "fa-truck" },
            { FontAwesomeIcons.TruckLoading, "fa-truck-loading" },
            { FontAwesomeIcons.TruckMonster, "fa-truck-monster" },
            { FontAwesomeIcons.TruckMoving, "fa-truck-moving" },
            { FontAwesomeIcons.TruckPickup, "fa-truck-pickup" },
            { FontAwesomeIcons.Tshirt, "fa-tshirt" },
            { FontAwesomeIcons.Tty, "fa-tty" },
            { FontAwesomeIcons.Tumblr, "fa-tumblr" },
            { FontAwesomeIcons.TumblrSquare, "fa-tumblr-square" },
            { FontAwesomeIcons.Tv, "fa-tv" },
            { FontAwesomeIcons.Twitch, "fa-twitch" },
            { FontAwesomeIcons.Twitter, "fa-twitter" },
            { FontAwesomeIcons.TwitterSquare, "fa-twitter-square" },
            { FontAwesomeIcons.Typo3, "fa-typo3" },
            { FontAwesomeIcons.Uber, "fa-uber" },
            { FontAwesomeIcons.Ubuntu, "fa-ubuntu" },
            { FontAwesomeIcons.Uikit, "fa-uikit" },
            { FontAwesomeIcons.Umbraco, "fa-umbraco" },
            { FontAwesomeIcons.Umbrella, "fa-umbrella" },
            { FontAwesomeIcons.UmbrellaBeach, "fa-umbrella-beach" },
            { FontAwesomeIcons.Underline, "fa-underline" },
            { FontAwesomeIcons.Undo, "fa-undo" },
            { FontAwesomeIcons.UndoAlt, "fa-undo-alt" },
            { FontAwesomeIcons.Uniregistry, "fa-uniregistry" },
            { FontAwesomeIcons.Unity, "fa-unity" },
            { FontAwesomeIcons.UniversalAccess, "fa-universal-access" },
            { FontAwesomeIcons.University, "fa-university" },
            { FontAwesomeIcons.Unlink, "fa-unlink" },
            { FontAwesomeIcons.Unlock, "fa-unlock" },
            { FontAwesomeIcons.UnlockAlt, "fa-unlock-alt" },
            { FontAwesomeIcons.Untappd, "fa-untappd" },
            { FontAwesomeIcons.Upload, "fa-upload" },
            { FontAwesomeIcons.Ups, "fa-ups" },
            { FontAwesomeIcons.Usb, "fa-usb" },
            { FontAwesomeIcons.User, "fa-user" },
            { FontAwesomeIcons.UserAlt, "fa-user-alt" },
            { FontAwesomeIcons.UserAltSlash, "fa-user-alt-slash" },
            { FontAwesomeIcons.UserAstronaut, "fa-user-astronaut" },
            { FontAwesomeIcons.UserCheck, "fa-user-check" },
            { FontAwesomeIcons.UserCircle, "fa-user-circle" },
            { FontAwesomeIcons.UserClock, "fa-user-clock" },
            { FontAwesomeIcons.UserCog, "fa-user-cog" },
            { FontAwesomeIcons.UserEdit, "fa-user-edit" },
            { FontAwesomeIcons.UserFriends, "fa-user-friends" },
            { FontAwesomeIcons.UserGraduate, "fa-user-graduate" },
            { FontAwesomeIcons.UserInjured, "fa-user-injured" },
            { FontAwesomeIcons.UserLock, "fa-user-lock" },
            { FontAwesomeIcons.UserMd, "fa-user-md" },
            { FontAwesomeIcons.UserMinus, "fa-user-minus" },
            { FontAwesomeIcons.UserNinja, "fa-user-ninja" },
            { FontAwesomeIcons.UserNurse, "fa-user-nurse" },
            { FontAwesomeIcons.UserPlus, "fa-user-plus" },
            { FontAwesomeIcons.UserSecret, "fa-user-secret" },
            { FontAwesomeIcons.UserShield, "fa-user-shield" },
            { FontAwesomeIcons.UserSlash, "fa-user-slash" },
            { FontAwesomeIcons.UserTag, "fa-user-tag" },
            { FontAwesomeIcons.UserTie, "fa-user-tie" },
            { FontAwesomeIcons.UserTimes, "fa-user-times" },
            { FontAwesomeIcons.Users, "fa-users" },
            { FontAwesomeIcons.UsersCog, "fa-users-cog" },
            { FontAwesomeIcons.Usps, "fa-usps" },
            { FontAwesomeIcons.Ussunnah, "fa-ussunnah" },
            { FontAwesomeIcons.UtensilSpoon, "fa-utensil-spoon" },
            { FontAwesomeIcons.Utensils, "fa-utensils" },
            { FontAwesomeIcons.Vaadin, "fa-vaadin" },
            { FontAwesomeIcons.VectorSquare, "fa-vector-square" },
            { FontAwesomeIcons.Venus, "fa-venus" },
            { FontAwesomeIcons.VenusDouble, "fa-venus-double" },
            { FontAwesomeIcons.VenusMars, "fa-venus-mars" },
            { FontAwesomeIcons.Viacoin, "fa-viacoin" },
            { FontAwesomeIcons.Viadeo, "fa-viadeo" },
            { FontAwesomeIcons.ViadeoSquare, "fa-viadeo-square" },
            { FontAwesomeIcons.Vial, "fa-vial" },
            { FontAwesomeIcons.Vials, "fa-vials" },
            { FontAwesomeIcons.Viber, "fa-viber" },
            { FontAwesomeIcons.Video, "fa-video" },
            { FontAwesomeIcons.VideoSlash, "fa-video-slash" },
            { FontAwesomeIcons.Vihara, "fa-vihara" },
            { FontAwesomeIcons.Vimeo, "fa-vimeo" },
            { FontAwesomeIcons.VimeoSquare, "fa-vimeo-square" },
            { FontAwesomeIcons.VimeoV, "fa-vimeo-v" },
            { FontAwesomeIcons.Vine, "fa-vine" },
            { FontAwesomeIcons.Virus, "fa-virus" },
            { FontAwesomeIcons.VirusSlash, "fa-virus-slash" },
            { FontAwesomeIcons.Viruses, "fa-viruses" },
            { FontAwesomeIcons.Vk, "fa-vk" },
            { FontAwesomeIcons.Vnv, "fa-vnv" },
            { FontAwesomeIcons.Voicemail, "fa-voicemail" },
            { FontAwesomeIcons.VolleyballBall, "fa-volleyball-ball" },
            { FontAwesomeIcons.VolumeDown, "fa-volume-down" },
            { FontAwesomeIcons.VolumeMute, "fa-volume-mute" },
            { FontAwesomeIcons.VolumeOff, "fa-volume-off" },
            { FontAwesomeIcons.VolumeUp, "fa-volume-up" },
            { FontAwesomeIcons.VoteYea, "fa-vote-yea" },
            { FontAwesomeIcons.VrCardboard, "fa-vr-cardboard" },
            { FontAwesomeIcons.Vuejs, "fa-vuejs" },
            { FontAwesomeIcons.Walking, "fa-walking" },
            { FontAwesomeIcons.Wallet, "fa-wallet" },
            { FontAwesomeIcons.Warehouse, "fa-warehouse" },
            { FontAwesomeIcons.Water, "fa-water" },
            { FontAwesomeIcons.WaveSquare, "fa-wave-square" },
            { FontAwesomeIcons.Waze, "fa-waze" },
            { FontAwesomeIcons.Weebly, "fa-weebly" },
            { FontAwesomeIcons.Weibo, "fa-weibo" },
            { FontAwesomeIcons.Weight, "fa-weight" },
            { FontAwesomeIcons.WeightHanging, "fa-weight-hanging" },
            { FontAwesomeIcons.Weixin, "fa-weixin" },
            { FontAwesomeIcons.Whatsapp, "fa-whatsapp" },
            { FontAwesomeIcons.WhatsappSquare, "fa-whatsapp-square" },
            { FontAwesomeIcons.Wheelchair, "fa-wheelchair" },
            { FontAwesomeIcons.Whmcs, "fa-whmcs" },
            { FontAwesomeIcons.Wifi, "fa-wifi" },
            { FontAwesomeIcons.WikipediaW, "fa-wikipedia-w" },
            { FontAwesomeIcons.Wind, "fa-wind" },
            { FontAwesomeIcons.WindowClose, "fa-window-close" },
            { FontAwesomeIcons.WindowMaximize, "fa-window-maximize" },
            { FontAwesomeIcons.WindowMinimize, "fa-window-minimize" },
            { FontAwesomeIcons.WindowRestore, "fa-window-restore" },
            { FontAwesomeIcons.Windows, "fa-windows" },
            { FontAwesomeIcons.WineBottle, "fa-wine-bottle" },
            { FontAwesomeIcons.WineGlass, "fa-wine-glass" },
            { FontAwesomeIcons.WineGlassAlt, "fa-wine-glass-alt" },
            { FontAwesomeIcons.Wix, "fa-wix" },
            { FontAwesomeIcons.WizardsOfTheCoast, "fa-wizards-of-the-coast" },
            { FontAwesomeIcons.WolfPackBattalion, "fa-wolf-pack-battalion" },
            { FontAwesomeIcons.WonSign, "fa-won-sign" },
            { FontAwesomeIcons.Wordpress, "fa-wordpress" },
            { FontAwesomeIcons.WordpressSimple, "fa-wordpress-simple" },
            { FontAwesomeIcons.Wpbeginner, "fa-wpbeginner" },
            { FontAwesomeIcons.Wpexplorer, "fa-wpexplorer" },
            { FontAwesomeIcons.Wpforms, "fa-wpforms" },
            { FontAwesomeIcons.Wpressr, "fa-wpressr" },
            { FontAwesomeIcons.Wrench, "fa-wrench" },
            { FontAwesomeIcons.XRay, "fa-x-ray" },
            { FontAwesomeIcons.Xbox, "fa-xbox" },
            { FontAwesomeIcons.Xing, "fa-xing" },
            { FontAwesomeIcons.XingSquare, "fa-xing-square" },
            { FontAwesomeIcons.YCombinator, "fa-y-combinator" },
            { FontAwesomeIcons.Yahoo, "fa-yahoo" },
            { FontAwesomeIcons.Yammer, "fa-yammer" },
            { FontAwesomeIcons.Yandex, "fa-yandex" },
            { FontAwesomeIcons.YandexInternational, "fa-yandex-international" },
            { FontAwesomeIcons.Yarn, "fa-yarn" },
            { FontAwesomeIcons.Yelp, "fa-yelp" },
            { FontAwesomeIcons.YenSign, "fa-yen-sign" },
            { FontAwesomeIcons.YinYang, "fa-yin-yang" },
            { FontAwesomeIcons.Yoast, "fa-yoast" },
            { FontAwesomeIcons.Youtube, "fa-youtube" },
            { FontAwesomeIcons.YoutubeSquare, "fa-youtube-square" },
            { FontAwesomeIcons.Zhihu, "fa-zhihu" },
        };
    }
}
