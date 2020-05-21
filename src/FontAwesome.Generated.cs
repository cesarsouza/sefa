// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.ComponentModel.DataAnnotations;

namespace System.Enums
{
    /// <summary>
    ///     Represents all icon characters in the free Font-Awesome icons library.
    ///     The members of this enumeration are marked with DisplayAttribute to help
    ///     show extra information about them in user forms more easily.
    /// </summary>
    /// 
    public enum FontAwesome : uint
    {
        /// <summary>
        ///     500Px ("fa-500px", \uf26e) icon.
        /// </summary>
        /// 
        [Display(Name = "500Px", Description = "fa-500px", GroupName = "brands")]
        F500Px = '\uf26e',
        
        /// <summary>
        ///     Accessible Icon ("fa-accessible-icon", \uf368) icon.
        /// </summary>
        /// 
        [Display(Name = "Accessible Icon", Description = "fa-accessible-icon", GroupName = "brands")]
        AccessibleIcon = '\uf368',
        
        /// <summary>
        ///     Accusoft ("fa-accusoft", \uf369) icon.
        /// </summary>
        /// 
        [Display(Name = "Accusoft", Description = "fa-accusoft", GroupName = "brands")]
        Accusoft = '\uf369',
        
        /// <summary>
        ///     Acquisitions Incorporated ("fa-acquisitions-incorporated", \uf6af) icon.
        /// </summary>
        /// 
        [Display(Name = "Acquisitions Incorporated", Description = "fa-acquisitions-incorporated", GroupName = "brands")]
        AcquisitionsIncorporated = '\uf6af',
        
        /// <summary>
        ///     Ad ("fa-ad", \uf641) icon.
        /// </summary>
        /// 
        [Display(Name = "Ad", Description = "fa-ad", GroupName = "duotone light regular solid")]
        Ad = '\uf641',
        
        /// <summary>
        ///     Address Book ("fa-address-book", \uf2b9) icon.
        /// </summary>
        /// 
        [Display(Name = "Address Book", Description = "fa-address-book", GroupName = "duotone light regular solid")]
        AddressBook = '\uf2b9',
        
        /// <summary>
        ///     Address Card ("fa-address-card", \uf2bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Address Card", Description = "fa-address-card", GroupName = "duotone light regular solid")]
        AddressCard = '\uf2bb',
        
        /// <summary>
        ///     Adjust ("fa-adjust", \uf042) icon.
        /// </summary>
        /// 
        [Display(Name = "Adjust", Description = "fa-adjust", GroupName = "duotone light regular solid")]
        Adjust = '\uf042',
        
        /// <summary>
        ///     Adn ("fa-adn", \uf170) icon.
        /// </summary>
        /// 
        [Display(Name = "Adn", Description = "fa-adn", GroupName = "brands")]
        Adn = '\uf170',
        
        /// <summary>
        ///     Adobe ("fa-adobe", \uf778) icon.
        /// </summary>
        /// 
        [Display(Name = "Adobe", Description = "fa-adobe", GroupName = "brands")]
        Adobe = '\uf778',
        
        /// <summary>
        ///     Adversal ("fa-adversal", \uf36a) icon.
        /// </summary>
        /// 
        [Display(Name = "Adversal", Description = "fa-adversal", GroupName = "brands")]
        Adversal = '\uf36a',
        
        /// <summary>
        ///     Affiliatetheme ("fa-affiliatetheme", \uf36b) icon.
        /// </summary>
        /// 
        [Display(Name = "Affiliatetheme", Description = "fa-affiliatetheme", GroupName = "brands")]
        Affiliatetheme = '\uf36b',
        
        /// <summary>
        ///     Airbnb ("fa-airbnb", \uf834) icon.
        /// </summary>
        /// 
        [Display(Name = "Airbnb", Description = "fa-airbnb", GroupName = "brands")]
        Airbnb = '\uf834',
        
        /// <summary>
        ///     Air Freshener ("fa-air-freshener", \uf5d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Air Freshener", Description = "fa-air-freshener", GroupName = "duotone light regular solid")]
        AirFreshener = '\uf5d0',
        
        /// <summary>
        ///     Algolia ("fa-algolia", \uf36c) icon.
        /// </summary>
        /// 
        [Display(Name = "Algolia", Description = "fa-algolia", GroupName = "brands")]
        Algolia = '\uf36c',
        
        /// <summary>
        ///     Align Center ("fa-align-center", \uf037) icon.
        /// </summary>
        /// 
        [Display(Name = "Align Center", Description = "fa-align-center", GroupName = "duotone light regular solid")]
        AlignCenter = '\uf037',
        
        /// <summary>
        ///     Align Justify ("fa-align-justify", \uf039) icon.
        /// </summary>
        /// 
        [Display(Name = "Align Justify", Description = "fa-align-justify", GroupName = "duotone light regular solid")]
        AlignJustify = '\uf039',
        
        /// <summary>
        ///     Align Left ("fa-align-left", \uf036) icon.
        /// </summary>
        /// 
        [Display(Name = "Align Left", Description = "fa-align-left", GroupName = "duotone light regular solid")]
        AlignLeft = '\uf036',
        
        /// <summary>
        ///     Align Right ("fa-align-right", \uf038) icon.
        /// </summary>
        /// 
        [Display(Name = "Align Right", Description = "fa-align-right", GroupName = "duotone light regular solid")]
        AlignRight = '\uf038',
        
        /// <summary>
        ///     Alipay ("fa-alipay", \uf642) icon.
        /// </summary>
        /// 
        [Display(Name = "Alipay", Description = "fa-alipay", GroupName = "brands")]
        Alipay = '\uf642',
        
        /// <summary>
        ///     Allergies ("fa-allergies", \uf461) icon.
        /// </summary>
        /// 
        [Display(Name = "Allergies", Description = "fa-allergies", GroupName = "duotone light regular solid")]
        Allergies = '\uf461',
        
        /// <summary>
        ///     Amazon ("fa-amazon", \uf270) icon.
        /// </summary>
        /// 
        [Display(Name = "Amazon", Description = "fa-amazon", GroupName = "brands")]
        Amazon = '\uf270',
        
        /// <summary>
        ///     Amazon Pay ("fa-amazon-pay", \uf42c) icon.
        /// </summary>
        /// 
        [Display(Name = "Amazon Pay", Description = "fa-amazon-pay", GroupName = "brands")]
        AmazonPay = '\uf42c',
        
        /// <summary>
        ///     Ambulance ("fa-ambulance", \uf0f9) icon.
        /// </summary>
        /// 
        [Display(Name = "Ambulance", Description = "fa-ambulance", GroupName = "duotone light regular solid")]
        Ambulance = '\uf0f9',
        
        /// <summary>
        ///     American Sign Language Interpreting ("fa-american-sign-language-interpreting", \uf2a3) icon.
        /// </summary>
        /// 
        [Display(Name = "American Sign Language Interpreting", Description = "fa-american-sign-language-interpreting", GroupName = "duotone light regular solid")]
        AmericanSignLanguageInterpreting = '\uf2a3',
        
        /// <summary>
        ///     Amilia ("fa-amilia", \uf36d) icon.
        /// </summary>
        /// 
        [Display(Name = "Amilia", Description = "fa-amilia", GroupName = "brands")]
        Amilia = '\uf36d',
        
        /// <summary>
        ///     Anchor ("fa-anchor", \uf13d) icon.
        /// </summary>
        /// 
        [Display(Name = "Anchor", Description = "fa-anchor", GroupName = "duotone light regular solid")]
        Anchor = '\uf13d',
        
        /// <summary>
        ///     Android ("fa-android", \uf17b) icon.
        /// </summary>
        /// 
        [Display(Name = "Android", Description = "fa-android", GroupName = "brands")]
        Android = '\uf17b',
        
        /// <summary>
        ///     Angellist ("fa-angellist", \uf209) icon.
        /// </summary>
        /// 
        [Display(Name = "Angellist", Description = "fa-angellist", GroupName = "brands")]
        Angellist = '\uf209',
        
        /// <summary>
        ///     Angle Double Down ("fa-angle-double-down", \uf103) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Double Down", Description = "fa-angle-double-down", GroupName = "duotone light regular solid")]
        AngleDoubleDown = '\uf103',
        
        /// <summary>
        ///     Angle Double Left ("fa-angle-double-left", \uf100) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Double Left", Description = "fa-angle-double-left", GroupName = "duotone light regular solid")]
        AngleDoubleLeft = '\uf100',
        
        /// <summary>
        ///     Angle Double Right ("fa-angle-double-right", \uf101) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Double Right", Description = "fa-angle-double-right", GroupName = "duotone light regular solid")]
        AngleDoubleRight = '\uf101',
        
        /// <summary>
        ///     Angle Double Up ("fa-angle-double-up", \uf102) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Double Up", Description = "fa-angle-double-up", GroupName = "duotone light regular solid")]
        AngleDoubleUp = '\uf102',
        
        /// <summary>
        ///     Angle Down ("fa-angle-down", \uf107) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Down", Description = "fa-angle-down", GroupName = "duotone light regular solid")]
        AngleDown = '\uf107',
        
        /// <summary>
        ///     Angle Left ("fa-angle-left", \uf104) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Left", Description = "fa-angle-left", GroupName = "duotone light regular solid")]
        AngleLeft = '\uf104',
        
        /// <summary>
        ///     Angle Right ("fa-angle-right", \uf105) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Right", Description = "fa-angle-right", GroupName = "duotone light regular solid")]
        AngleRight = '\uf105',
        
        /// <summary>
        ///     Angle Up ("fa-angle-up", \uf106) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Up", Description = "fa-angle-up", GroupName = "duotone light regular solid")]
        AngleUp = '\uf106',
        
        /// <summary>
        ///     Angry ("fa-angry", \uf556) icon.
        /// </summary>
        /// 
        [Display(Name = "Angry", Description = "fa-angry", GroupName = "duotone light regular solid")]
        Angry = '\uf556',
        
        /// <summary>
        ///     Angrycreative ("fa-angrycreative", \uf36e) icon.
        /// </summary>
        /// 
        [Display(Name = "Angrycreative", Description = "fa-angrycreative", GroupName = "brands")]
        Angrycreative = '\uf36e',
        
        /// <summary>
        ///     Angular ("fa-angular", \uf420) icon.
        /// </summary>
        /// 
        [Display(Name = "Angular", Description = "fa-angular", GroupName = "brands")]
        Angular = '\uf420',
        
        /// <summary>
        ///     Ankh ("fa-ankh", \uf644) icon.
        /// </summary>
        /// 
        [Display(Name = "Ankh", Description = "fa-ankh", GroupName = "duotone light regular solid")]
        Ankh = '\uf644',
        
        /// <summary>
        ///     Apper ("fa-apper", \uf371) icon.
        /// </summary>
        /// 
        [Display(Name = "Apper", Description = "fa-apper", GroupName = "brands")]
        Apper = '\uf371',
        
        /// <summary>
        ///     Apple ("fa-apple", \uf179) icon.
        /// </summary>
        /// 
        [Display(Name = "Apple", Description = "fa-apple", GroupName = "brands")]
        Apple = '\uf179',
        
        /// <summary>
        ///     Apple Alt ("fa-apple-alt", \uf5d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Apple Alt", Description = "fa-apple-alt", GroupName = "duotone light regular solid")]
        AppleAlt = '\uf5d1',
        
        /// <summary>
        ///     Apple Pay ("fa-apple-pay", \uf415) icon.
        /// </summary>
        /// 
        [Display(Name = "Apple Pay", Description = "fa-apple-pay", GroupName = "brands")]
        ApplePay = '\uf415',
        
        /// <summary>
        ///     App Store ("fa-app-store", \uf36f) icon.
        /// </summary>
        /// 
        [Display(Name = "App Store", Description = "fa-app-store", GroupName = "brands")]
        AppStore = '\uf36f',
        
        /// <summary>
        ///     App Store Ios ("fa-app-store-ios", \uf370) icon.
        /// </summary>
        /// 
        [Display(Name = "App Store Ios", Description = "fa-app-store-ios", GroupName = "brands")]
        AppStoreIos = '\uf370',
        
        /// <summary>
        ///     Archive ("fa-archive", \uf187) icon.
        /// </summary>
        /// 
        [Display(Name = "Archive", Description = "fa-archive", GroupName = "duotone light regular solid")]
        Archive = '\uf187',
        
        /// <summary>
        ///     Archway ("fa-archway", \uf557) icon.
        /// </summary>
        /// 
        [Display(Name = "Archway", Description = "fa-archway", GroupName = "duotone light regular solid")]
        Archway = '\uf557',
        
        /// <summary>
        ///     Arrow Alt Circle Down ("fa-arrow-alt-circle-down", \uf358) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Alt Circle Down", Description = "fa-arrow-alt-circle-down", GroupName = "duotone light regular solid")]
        ArrowAltCircleDown = '\uf358',
        
        /// <summary>
        ///     Arrow Alt Circle Left ("fa-arrow-alt-circle-left", \uf359) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Alt Circle Left", Description = "fa-arrow-alt-circle-left", GroupName = "duotone light regular solid")]
        ArrowAltCircleLeft = '\uf359',
        
        /// <summary>
        ///     Arrow Alt Circle Right ("fa-arrow-alt-circle-right", \uf35a) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Alt Circle Right", Description = "fa-arrow-alt-circle-right", GroupName = "duotone light regular solid")]
        ArrowAltCircleRight = '\uf35a',
        
        /// <summary>
        ///     Arrow Alt Circle Up ("fa-arrow-alt-circle-up", \uf35b) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Alt Circle Up", Description = "fa-arrow-alt-circle-up", GroupName = "duotone light regular solid")]
        ArrowAltCircleUp = '\uf35b',
        
        /// <summary>
        ///     Arrow Circle Down ("fa-arrow-circle-down", \uf0ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Circle Down", Description = "fa-arrow-circle-down", GroupName = "duotone light regular solid")]
        ArrowCircleDown = '\uf0ab',
        
        /// <summary>
        ///     Arrow Circle Left ("fa-arrow-circle-left", \uf0a8) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Circle Left", Description = "fa-arrow-circle-left", GroupName = "duotone light regular solid")]
        ArrowCircleLeft = '\uf0a8',
        
        /// <summary>
        ///     Arrow Circle Right ("fa-arrow-circle-right", \uf0a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Circle Right", Description = "fa-arrow-circle-right", GroupName = "duotone light regular solid")]
        ArrowCircleRight = '\uf0a9',
        
        /// <summary>
        ///     Arrow Circle Up ("fa-arrow-circle-up", \uf0aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Circle Up", Description = "fa-arrow-circle-up", GroupName = "duotone light regular solid")]
        ArrowCircleUp = '\uf0aa',
        
        /// <summary>
        ///     Arrow Down ("fa-arrow-down", \uf063) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Down", Description = "fa-arrow-down", GroupName = "duotone light regular solid")]
        ArrowDown = '\uf063',
        
        /// <summary>
        ///     Arrow Left ("fa-arrow-left", \uf060) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Left", Description = "fa-arrow-left", GroupName = "duotone light regular solid")]
        ArrowLeft = '\uf060',
        
        /// <summary>
        ///     Arrow Right ("fa-arrow-right", \uf061) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Right", Description = "fa-arrow-right", GroupName = "duotone light regular solid")]
        ArrowRight = '\uf061',
        
        /// <summary>
        ///     Arrows Alt ("fa-arrows-alt", \uf0b2) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrows Alt", Description = "fa-arrows-alt", GroupName = "duotone light regular solid")]
        ArrowsAlt = '\uf0b2',
        
        /// <summary>
        ///     Arrows Alt H ("fa-arrows-alt-h", \uf337) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrows Alt H", Description = "fa-arrows-alt-h", GroupName = "duotone light regular solid")]
        ArrowsAltH = '\uf337',
        
        /// <summary>
        ///     Arrows Alt V ("fa-arrows-alt-v", \uf338) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrows Alt V", Description = "fa-arrows-alt-v", GroupName = "duotone light regular solid")]
        ArrowsAltV = '\uf338',
        
        /// <summary>
        ///     Arrow Up ("fa-arrow-up", \uf062) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Up", Description = "fa-arrow-up", GroupName = "duotone light regular solid")]
        ArrowUp = '\uf062',
        
        /// <summary>
        ///     Artstation ("fa-artstation", \uf77a) icon.
        /// </summary>
        /// 
        [Display(Name = "Artstation", Description = "fa-artstation", GroupName = "brands")]
        Artstation = '\uf77a',
        
        /// <summary>
        ///     Assistive Listening Systems ("fa-assistive-listening-systems", \uf2a2) icon.
        /// </summary>
        /// 
        [Display(Name = "Assistive Listening Systems", Description = "fa-assistive-listening-systems", GroupName = "duotone light regular solid")]
        AssistiveListeningSystems = '\uf2a2',
        
        /// <summary>
        ///     Asterisk ("fa-asterisk", \uf069) icon.
        /// </summary>
        /// 
        [Display(Name = "Asterisk", Description = "fa-asterisk", GroupName = "duotone light regular solid")]
        Asterisk = '\uf069',
        
        /// <summary>
        ///     Asymmetrik ("fa-asymmetrik", \uf372) icon.
        /// </summary>
        /// 
        [Display(Name = "Asymmetrik", Description = "fa-asymmetrik", GroupName = "brands")]
        Asymmetrik = '\uf372',
        
        /// <summary>
        ///     At ("fa-at", \uf1fa) icon.
        /// </summary>
        /// 
        [Display(Name = "At", Description = "fa-at", GroupName = "duotone light regular solid")]
        At = '\uf1fa',
        
        /// <summary>
        ///     Atlas ("fa-atlas", \uf558) icon.
        /// </summary>
        /// 
        [Display(Name = "Atlas", Description = "fa-atlas", GroupName = "duotone light regular solid")]
        Atlas = '\uf558',
        
        /// <summary>
        ///     Atlassian ("fa-atlassian", \uf77b) icon.
        /// </summary>
        /// 
        [Display(Name = "Atlassian", Description = "fa-atlassian", GroupName = "brands")]
        Atlassian = '\uf77b',
        
        /// <summary>
        ///     Atom ("fa-atom", \uf5d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Atom", Description = "fa-atom", GroupName = "duotone light regular solid")]
        Atom = '\uf5d2',
        
        /// <summary>
        ///     Audible ("fa-audible", \uf373) icon.
        /// </summary>
        /// 
        [Display(Name = "Audible", Description = "fa-audible", GroupName = "brands")]
        Audible = '\uf373',
        
        /// <summary>
        ///     Audio Description ("fa-audio-description", \uf29e) icon.
        /// </summary>
        /// 
        [Display(Name = "Audio Description", Description = "fa-audio-description", GroupName = "duotone light regular solid")]
        AudioDescription = '\uf29e',
        
        /// <summary>
        ///     Autoprefixer ("fa-autoprefixer", \uf41c) icon.
        /// </summary>
        /// 
        [Display(Name = "Autoprefixer", Description = "fa-autoprefixer", GroupName = "brands")]
        Autoprefixer = '\uf41c',
        
        /// <summary>
        ///     Avianex ("fa-avianex", \uf374) icon.
        /// </summary>
        /// 
        [Display(Name = "Avianex", Description = "fa-avianex", GroupName = "brands")]
        Avianex = '\uf374',
        
        /// <summary>
        ///     Aviato ("fa-aviato", \uf421) icon.
        /// </summary>
        /// 
        [Display(Name = "Aviato", Description = "fa-aviato", GroupName = "brands")]
        Aviato = '\uf421',
        
        /// <summary>
        ///     Award ("fa-award", \uf559) icon.
        /// </summary>
        /// 
        [Display(Name = "Award", Description = "fa-award", GroupName = "duotone light regular solid")]
        Award = '\uf559',
        
        /// <summary>
        ///     Aws ("fa-aws", \uf375) icon.
        /// </summary>
        /// 
        [Display(Name = "Aws", Description = "fa-aws", GroupName = "brands")]
        Aws = '\uf375',
        
        /// <summary>
        ///     Baby ("fa-baby", \uf77c) icon.
        /// </summary>
        /// 
        [Display(Name = "Baby", Description = "fa-baby", GroupName = "duotone light regular solid")]
        Baby = '\uf77c',
        
        /// <summary>
        ///     Baby Carriage ("fa-baby-carriage", \uf77d) icon.
        /// </summary>
        /// 
        [Display(Name = "Baby Carriage", Description = "fa-baby-carriage", GroupName = "duotone light regular solid")]
        BabyCarriage = '\uf77d',
        
        /// <summary>
        ///     Backspace ("fa-backspace", \uf55a) icon.
        /// </summary>
        /// 
        [Display(Name = "Backspace", Description = "fa-backspace", GroupName = "duotone light regular solid")]
        Backspace = '\uf55a',
        
        /// <summary>
        ///     Backward ("fa-backward", \uf04a) icon.
        /// </summary>
        /// 
        [Display(Name = "Backward", Description = "fa-backward", GroupName = "duotone light regular solid")]
        Backward = '\uf04a',
        
        /// <summary>
        ///     Bacon ("fa-bacon", \uf7e5) icon.
        /// </summary>
        /// 
        [Display(Name = "Bacon", Description = "fa-bacon", GroupName = "duotone light regular solid")]
        Bacon = '\uf7e5',
        
        /// <summary>
        ///     Bahai ("fa-bahai", \uf666) icon.
        /// </summary>
        /// 
        [Display(Name = "Bahai", Description = "fa-bahai", GroupName = "duotone light regular solid")]
        Bahai = '\uf666',
        
        /// <summary>
        ///     Balance Scale ("fa-balance-scale", \uf24e) icon.
        /// </summary>
        /// 
        [Display(Name = "Balance Scale", Description = "fa-balance-scale", GroupName = "duotone light regular solid")]
        BalanceScale = '\uf24e',
        
        /// <summary>
        ///     Balance Scale Left ("fa-balance-scale-left", \uf515) icon.
        /// </summary>
        /// 
        [Display(Name = "Balance Scale Left", Description = "fa-balance-scale-left", GroupName = "duotone light regular solid")]
        BalanceScaleLeft = '\uf515',
        
        /// <summary>
        ///     Balance Scale Right ("fa-balance-scale-right", \uf516) icon.
        /// </summary>
        /// 
        [Display(Name = "Balance Scale Right", Description = "fa-balance-scale-right", GroupName = "duotone light regular solid")]
        BalanceScaleRight = '\uf516',
        
        /// <summary>
        ///     Ban ("fa-ban", \uf05e) icon.
        /// </summary>
        /// 
        [Display(Name = "Ban", Description = "fa-ban", GroupName = "duotone light regular solid")]
        Ban = '\uf05e',
        
        /// <summary>
        ///     Band Aid ("fa-band-aid", \uf462) icon.
        /// </summary>
        /// 
        [Display(Name = "Band Aid", Description = "fa-band-aid", GroupName = "duotone light regular solid")]
        BandAid = '\uf462',
        
        /// <summary>
        ///     Bandcamp ("fa-bandcamp", \uf2d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Bandcamp", Description = "fa-bandcamp", GroupName = "brands")]
        Bandcamp = '\uf2d5',
        
        /// <summary>
        ///     Barcode ("fa-barcode", \uf02a) icon.
        /// </summary>
        /// 
        [Display(Name = "Barcode", Description = "fa-barcode", GroupName = "duotone light regular solid")]
        Barcode = '\uf02a',
        
        /// <summary>
        ///     Bars ("fa-bars", \uf0c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Bars", Description = "fa-bars", GroupName = "duotone light regular solid")]
        Bars = '\uf0c9',
        
        /// <summary>
        ///     Baseball Ball ("fa-baseball-ball", \uf433) icon.
        /// </summary>
        /// 
        [Display(Name = "Baseball Ball", Description = "fa-baseball-ball", GroupName = "duotone light regular solid")]
        BaseballBall = '\uf433',
        
        /// <summary>
        ///     Basketball Ball ("fa-basketball-ball", \uf434) icon.
        /// </summary>
        /// 
        [Display(Name = "Basketball Ball", Description = "fa-basketball-ball", GroupName = "duotone light regular solid")]
        BasketballBall = '\uf434',
        
        /// <summary>
        ///     Bath ("fa-bath", \uf2cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Bath", Description = "fa-bath", GroupName = "duotone light regular solid")]
        Bath = '\uf2cd',
        
        /// <summary>
        ///     Battery Empty ("fa-battery-empty", \uf244) icon.
        /// </summary>
        /// 
        [Display(Name = "Battery Empty", Description = "fa-battery-empty", GroupName = "duotone light regular solid")]
        BatteryEmpty = '\uf244',
        
        /// <summary>
        ///     Battery Full ("fa-battery-full", \uf240) icon.
        /// </summary>
        /// 
        [Display(Name = "Battery Full", Description = "fa-battery-full", GroupName = "duotone light regular solid")]
        BatteryFull = '\uf240',
        
        /// <summary>
        ///     Battery Half ("fa-battery-half", \uf242) icon.
        /// </summary>
        /// 
        [Display(Name = "Battery Half", Description = "fa-battery-half", GroupName = "duotone light regular solid")]
        BatteryHalf = '\uf242',
        
        /// <summary>
        ///     Battery Quarter ("fa-battery-quarter", \uf243) icon.
        /// </summary>
        /// 
        [Display(Name = "Battery Quarter", Description = "fa-battery-quarter", GroupName = "duotone light regular solid")]
        BatteryQuarter = '\uf243',
        
        /// <summary>
        ///     Battery Three Quarters ("fa-battery-three-quarters", \uf241) icon.
        /// </summary>
        /// 
        [Display(Name = "Battery Three Quarters", Description = "fa-battery-three-quarters", GroupName = "duotone light regular solid")]
        BatteryThreeQuarters = '\uf241',
        
        /// <summary>
        ///     Battle Net ("fa-battle-net", \uf835) icon.
        /// </summary>
        /// 
        [Display(Name = "Battle Net", Description = "fa-battle-net", GroupName = "brands")]
        BattleNet = '\uf835',
        
        /// <summary>
        ///     Bed ("fa-bed", \uf236) icon.
        /// </summary>
        /// 
        [Display(Name = "Bed", Description = "fa-bed", GroupName = "duotone light regular solid")]
        Bed = '\uf236',
        
        /// <summary>
        ///     Beer ("fa-beer", \uf0fc) icon.
        /// </summary>
        /// 
        [Display(Name = "Beer", Description = "fa-beer", GroupName = "duotone light regular solid")]
        Beer = '\uf0fc',
        
        /// <summary>
        ///     Behance ("fa-behance", \uf1b4) icon.
        /// </summary>
        /// 
        [Display(Name = "Behance", Description = "fa-behance", GroupName = "brands")]
        Behance = '\uf1b4',
        
        /// <summary>
        ///     Behance Square ("fa-behance-square", \uf1b5) icon.
        /// </summary>
        /// 
        [Display(Name = "Behance Square", Description = "fa-behance-square", GroupName = "brands")]
        BehanceSquare = '\uf1b5',
        
        /// <summary>
        ///     Bell ("fa-bell", \uf0f3) icon.
        /// </summary>
        /// 
        [Display(Name = "Bell", Description = "fa-bell", GroupName = "duotone light regular solid")]
        Bell = '\uf0f3',
        
        /// <summary>
        ///     Bell Slash ("fa-bell-slash", \uf1f6) icon.
        /// </summary>
        /// 
        [Display(Name = "Bell Slash", Description = "fa-bell-slash", GroupName = "duotone light regular solid")]
        BellSlash = '\uf1f6',
        
        /// <summary>
        ///     Bezier Curve ("fa-bezier-curve", \uf55b) icon.
        /// </summary>
        /// 
        [Display(Name = "Bezier Curve", Description = "fa-bezier-curve", GroupName = "duotone light regular solid")]
        BezierCurve = '\uf55b',
        
        /// <summary>
        ///     Bible ("fa-bible", \uf647) icon.
        /// </summary>
        /// 
        [Display(Name = "Bible", Description = "fa-bible", GroupName = "duotone light regular solid")]
        Bible = '\uf647',
        
        /// <summary>
        ///     Bicycle ("fa-bicycle", \uf206) icon.
        /// </summary>
        /// 
        [Display(Name = "Bicycle", Description = "fa-bicycle", GroupName = "duotone light regular solid")]
        Bicycle = '\uf206',
        
        /// <summary>
        ///     Biking ("fa-biking", \uf84a) icon.
        /// </summary>
        /// 
        [Display(Name = "Biking", Description = "fa-biking", GroupName = "duotone light regular solid")]
        Biking = '\uf84a',
        
        /// <summary>
        ///     Bimobject ("fa-bimobject", \uf378) icon.
        /// </summary>
        /// 
        [Display(Name = "Bimobject", Description = "fa-bimobject", GroupName = "brands")]
        Bimobject = '\uf378',
        
        /// <summary>
        ///     Binoculars ("fa-binoculars", \uf1e5) icon.
        /// </summary>
        /// 
        [Display(Name = "Binoculars", Description = "fa-binoculars", GroupName = "duotone light regular solid")]
        Binoculars = '\uf1e5',
        
        /// <summary>
        ///     Biohazard ("fa-biohazard", \uf780) icon.
        /// </summary>
        /// 
        [Display(Name = "Biohazard", Description = "fa-biohazard", GroupName = "duotone light regular solid")]
        Biohazard = '\uf780',
        
        /// <summary>
        ///     Birthday Cake ("fa-birthday-cake", \uf1fd) icon.
        /// </summary>
        /// 
        [Display(Name = "Birthday Cake", Description = "fa-birthday-cake", GroupName = "duotone light regular solid")]
        BirthdayCake = '\uf1fd',
        
        /// <summary>
        ///     Bitbucket ("fa-bitbucket", \uf171) icon.
        /// </summary>
        /// 
        [Display(Name = "Bitbucket", Description = "fa-bitbucket", GroupName = "brands")]
        Bitbucket = '\uf171',
        
        /// <summary>
        ///     Bitcoin ("fa-bitcoin", \uf379) icon.
        /// </summary>
        /// 
        [Display(Name = "Bitcoin", Description = "fa-bitcoin", GroupName = "brands")]
        Bitcoin = '\uf379',
        
        /// <summary>
        ///     Bity ("fa-bity", \uf37a) icon.
        /// </summary>
        /// 
        [Display(Name = "Bity", Description = "fa-bity", GroupName = "brands")]
        Bity = '\uf37a',
        
        /// <summary>
        ///     Blackberry ("fa-blackberry", \uf37b) icon.
        /// </summary>
        /// 
        [Display(Name = "Blackberry", Description = "fa-blackberry", GroupName = "brands")]
        Blackberry = '\uf37b',
        
        /// <summary>
        ///     Black Tie ("fa-black-tie", \uf27e) icon.
        /// </summary>
        /// 
        [Display(Name = "Black Tie", Description = "fa-black-tie", GroupName = "brands")]
        BlackTie = '\uf27e',
        
        /// <summary>
        ///     Blender ("fa-blender", \uf517) icon.
        /// </summary>
        /// 
        [Display(Name = "Blender", Description = "fa-blender", GroupName = "duotone light regular solid")]
        Blender = '\uf517',
        
        /// <summary>
        ///     Blender Phone ("fa-blender-phone", \uf6b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Blender Phone", Description = "fa-blender-phone", GroupName = "duotone light regular solid")]
        BlenderPhone = '\uf6b6',
        
        /// <summary>
        ///     Blind ("fa-blind", \uf29d) icon.
        /// </summary>
        /// 
        [Display(Name = "Blind", Description = "fa-blind", GroupName = "duotone light regular solid")]
        Blind = '\uf29d',
        
        /// <summary>
        ///     Blog ("fa-blog", \uf781) icon.
        /// </summary>
        /// 
        [Display(Name = "Blog", Description = "fa-blog", GroupName = "duotone light regular solid")]
        Blog = '\uf781',
        
        /// <summary>
        ///     Blogger ("fa-blogger", \uf37c) icon.
        /// </summary>
        /// 
        [Display(Name = "Blogger", Description = "fa-blogger", GroupName = "brands")]
        Blogger = '\uf37c',
        
        /// <summary>
        ///     Blogger B ("fa-blogger-b", \uf37d) icon.
        /// </summary>
        /// 
        [Display(Name = "Blogger B", Description = "fa-blogger-b", GroupName = "brands")]
        BloggerB = '\uf37d',
        
        /// <summary>
        ///     Bluetooth ("fa-bluetooth", \uf293) icon.
        /// </summary>
        /// 
        [Display(Name = "Bluetooth", Description = "fa-bluetooth", GroupName = "brands")]
        Bluetooth = '\uf293',
        
        /// <summary>
        ///     Bluetooth B ("fa-bluetooth-b", \uf294) icon.
        /// </summary>
        /// 
        [Display(Name = "Bluetooth B", Description = "fa-bluetooth-b", GroupName = "brands")]
        BluetoothB = '\uf294',
        
        /// <summary>
        ///     Bold ("fa-bold", \uf032) icon.
        /// </summary>
        /// 
        [Display(Name = "Bold", Description = "fa-bold", GroupName = "duotone light regular solid")]
        Bold = '\uf032',
        
        /// <summary>
        ///     Bolt ("fa-bolt", \uf0e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Bolt", Description = "fa-bolt", GroupName = "duotone light regular solid")]
        Bolt = '\uf0e7',
        
        /// <summary>
        ///     Bomb ("fa-bomb", \uf1e2) icon.
        /// </summary>
        /// 
        [Display(Name = "Bomb", Description = "fa-bomb", GroupName = "duotone light regular solid")]
        Bomb = '\uf1e2',
        
        /// <summary>
        ///     Bone ("fa-bone", \uf5d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Bone", Description = "fa-bone", GroupName = "duotone light regular solid")]
        Bone = '\uf5d7',
        
        /// <summary>
        ///     Bong ("fa-bong", \uf55c) icon.
        /// </summary>
        /// 
        [Display(Name = "Bong", Description = "fa-bong", GroupName = "duotone light regular solid")]
        Bong = '\uf55c',
        
        /// <summary>
        ///     Book ("fa-book", \uf02d) icon.
        /// </summary>
        /// 
        [Display(Name = "Book", Description = "fa-book", GroupName = "duotone light regular solid")]
        Book = '\uf02d',
        
        /// <summary>
        ///     Book Dead ("fa-book-dead", \uf6b7) icon.
        /// </summary>
        /// 
        [Display(Name = "Book Dead", Description = "fa-book-dead", GroupName = "duotone light regular solid")]
        BookDead = '\uf6b7',
        
        /// <summary>
        ///     Bookmark ("fa-bookmark", \uf02e) icon.
        /// </summary>
        /// 
        [Display(Name = "Bookmark", Description = "fa-bookmark", GroupName = "duotone light regular solid")]
        Bookmark = '\uf02e',
        
        /// <summary>
        ///     Book Medical ("fa-book-medical", \uf7e6) icon.
        /// </summary>
        /// 
        [Display(Name = "Book Medical", Description = "fa-book-medical", GroupName = "duotone light regular solid")]
        BookMedical = '\uf7e6',
        
        /// <summary>
        ///     Book Open ("fa-book-open", \uf518) icon.
        /// </summary>
        /// 
        [Display(Name = "Book Open", Description = "fa-book-open", GroupName = "duotone light regular solid")]
        BookOpen = '\uf518',
        
        /// <summary>
        ///     Book Reader ("fa-book-reader", \uf5da) icon.
        /// </summary>
        /// 
        [Display(Name = "Book Reader", Description = "fa-book-reader", GroupName = "duotone light regular solid")]
        BookReader = '\uf5da',
        
        /// <summary>
        ///     Bootstrap ("fa-bootstrap", \uf836) icon.
        /// </summary>
        /// 
        [Display(Name = "Bootstrap", Description = "fa-bootstrap", GroupName = "brands")]
        Bootstrap = '\uf836',
        
        /// <summary>
        ///     Border All ("fa-border-all", \uf84c) icon.
        /// </summary>
        /// 
        [Display(Name = "Border All", Description = "fa-border-all", GroupName = "duotone light regular solid")]
        BorderAll = '\uf84c',
        
        /// <summary>
        ///     Border None ("fa-border-none", \uf850) icon.
        /// </summary>
        /// 
        [Display(Name = "Border None", Description = "fa-border-none", GroupName = "duotone light regular solid")]
        BorderNone = '\uf850',
        
        /// <summary>
        ///     Border Style ("fa-border-style", \uf853) icon.
        /// </summary>
        /// 
        [Display(Name = "Border Style", Description = "fa-border-style", GroupName = "duotone light regular solid")]
        BorderStyle = '\uf853',
        
        /// <summary>
        ///     Bowling Ball ("fa-bowling-ball", \uf436) icon.
        /// </summary>
        /// 
        [Display(Name = "Bowling Ball", Description = "fa-bowling-ball", GroupName = "duotone light regular solid")]
        BowlingBall = '\uf436',
        
        /// <summary>
        ///     Box ("fa-box", \uf466) icon.
        /// </summary>
        /// 
        [Display(Name = "Box", Description = "fa-box", GroupName = "duotone light regular solid")]
        Box = '\uf466',
        
        /// <summary>
        ///     Boxes ("fa-boxes", \uf468) icon.
        /// </summary>
        /// 
        [Display(Name = "Boxes", Description = "fa-boxes", GroupName = "duotone light regular solid")]
        Boxes = '\uf468',
        
        /// <summary>
        ///     Box Open ("fa-box-open", \uf49e) icon.
        /// </summary>
        /// 
        [Display(Name = "Box Open", Description = "fa-box-open", GroupName = "duotone light regular solid")]
        BoxOpen = '\uf49e',
        
        /// <summary>
        ///     Box Tissue ("fa-box-tissue", \uf95b) icon.
        /// </summary>
        /// 
        [Display(Name = "Box Tissue", Description = "fa-box-tissue", GroupName = "duotone light regular solid")]
        BoxTissue = '\uf95b',
        
        /// <summary>
        ///     Braille ("fa-braille", \uf2a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Braille", Description = "fa-braille", GroupName = "duotone light regular solid")]
        Braille = '\uf2a1',
        
        /// <summary>
        ///     Brain ("fa-brain", \uf5dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Brain", Description = "fa-brain", GroupName = "duotone light regular solid")]
        Brain = '\uf5dc',
        
        /// <summary>
        ///     Bread Slice ("fa-bread-slice", \uf7ec) icon.
        /// </summary>
        /// 
        [Display(Name = "Bread Slice", Description = "fa-bread-slice", GroupName = "duotone light regular solid")]
        BreadSlice = '\uf7ec',
        
        /// <summary>
        ///     Briefcase ("fa-briefcase", \uf0b1) icon.
        /// </summary>
        /// 
        [Display(Name = "Briefcase", Description = "fa-briefcase", GroupName = "duotone light regular solid")]
        Briefcase = '\uf0b1',
        
        /// <summary>
        ///     Briefcase Medical ("fa-briefcase-medical", \uf469) icon.
        /// </summary>
        /// 
        [Display(Name = "Briefcase Medical", Description = "fa-briefcase-medical", GroupName = "duotone light regular solid")]
        BriefcaseMedical = '\uf469',
        
        /// <summary>
        ///     Broadcast Tower ("fa-broadcast-tower", \uf519) icon.
        /// </summary>
        /// 
        [Display(Name = "Broadcast Tower", Description = "fa-broadcast-tower", GroupName = "duotone light regular solid")]
        BroadcastTower = '\uf519',
        
        /// <summary>
        ///     Broom ("fa-broom", \uf51a) icon.
        /// </summary>
        /// 
        [Display(Name = "Broom", Description = "fa-broom", GroupName = "duotone light regular solid")]
        Broom = '\uf51a',
        
        /// <summary>
        ///     Brush ("fa-brush", \uf55d) icon.
        /// </summary>
        /// 
        [Display(Name = "Brush", Description = "fa-brush", GroupName = "duotone light regular solid")]
        Brush = '\uf55d',
        
        /// <summary>
        ///     Btc ("fa-btc", \uf15a) icon.
        /// </summary>
        /// 
        [Display(Name = "Btc", Description = "fa-btc", GroupName = "brands")]
        Btc = '\uf15a',
        
        /// <summary>
        ///     Buffer ("fa-buffer", \uf837) icon.
        /// </summary>
        /// 
        [Display(Name = "Buffer", Description = "fa-buffer", GroupName = "brands")]
        Buffer = '\uf837',
        
        /// <summary>
        ///     Bug ("fa-bug", \uf188) icon.
        /// </summary>
        /// 
        [Display(Name = "Bug", Description = "fa-bug", GroupName = "duotone light regular solid")]
        Bug = '\uf188',
        
        /// <summary>
        ///     Building ("fa-building", \uf1ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Building", Description = "fa-building", GroupName = "duotone light regular solid")]
        Building = '\uf1ad',
        
        /// <summary>
        ///     Bullhorn ("fa-bullhorn", \uf0a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Bullhorn", Description = "fa-bullhorn", GroupName = "duotone light regular solid")]
        Bullhorn = '\uf0a1',
        
        /// <summary>
        ///     Bullseye ("fa-bullseye", \uf140) icon.
        /// </summary>
        /// 
        [Display(Name = "Bullseye", Description = "fa-bullseye", GroupName = "duotone light regular solid")]
        Bullseye = '\uf140',
        
        /// <summary>
        ///     Burn ("fa-burn", \uf46a) icon.
        /// </summary>
        /// 
        [Display(Name = "Burn", Description = "fa-burn", GroupName = "duotone light regular solid")]
        Burn = '\uf46a',
        
        /// <summary>
        ///     Buromobelexperte ("fa-buromobelexperte", \uf37f) icon.
        /// </summary>
        /// 
        [Display(Name = "Buromobelexperte", Description = "fa-buromobelexperte", GroupName = "brands")]
        Buromobelexperte = '\uf37f',
        
        /// <summary>
        ///     Bus ("fa-bus", \uf207) icon.
        /// </summary>
        /// 
        [Display(Name = "Bus", Description = "fa-bus", GroupName = "duotone light regular solid")]
        Bus = '\uf207',
        
        /// <summary>
        ///     Bus Alt ("fa-bus-alt", \uf55e) icon.
        /// </summary>
        /// 
        [Display(Name = "Bus Alt", Description = "fa-bus-alt", GroupName = "duotone light regular solid")]
        BusAlt = '\uf55e',
        
        /// <summary>
        ///     Business Time ("fa-business-time", \uf64a) icon.
        /// </summary>
        /// 
        [Display(Name = "Business Time", Description = "fa-business-time", GroupName = "duotone light regular solid")]
        BusinessTime = '\uf64a',
        
        /// <summary>
        ///     Buy N Large ("fa-buy-n-large", \uf8a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Buy N Large", Description = "fa-buy-n-large", GroupName = "brands")]
        BuyNLarge = '\uf8a6',
        
        /// <summary>
        ///     Buysellads ("fa-buysellads", \uf20d) icon.
        /// </summary>
        /// 
        [Display(Name = "Buysellads", Description = "fa-buysellads", GroupName = "brands")]
        Buysellads = '\uf20d',
        
        /// <summary>
        ///     Calculator ("fa-calculator", \uf1ec) icon.
        /// </summary>
        /// 
        [Display(Name = "Calculator", Description = "fa-calculator", GroupName = "duotone light regular solid")]
        Calculator = '\uf1ec',
        
        /// <summary>
        ///     Calendar ("fa-calendar", \uf133) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar", Description = "fa-calendar", GroupName = "duotone light regular solid")]
        Calendar = '\uf133',
        
        /// <summary>
        ///     Calendar Alt ("fa-calendar-alt", \uf073) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Alt", Description = "fa-calendar-alt", GroupName = "duotone light regular solid")]
        CalendarAlt = '\uf073',
        
        /// <summary>
        ///     Calendar Check ("fa-calendar-check", \uf274) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Check", Description = "fa-calendar-check", GroupName = "duotone light regular solid")]
        CalendarCheck = '\uf274',
        
        /// <summary>
        ///     Calendar Day ("fa-calendar-day", \uf783) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Day", Description = "fa-calendar-day", GroupName = "duotone light regular solid")]
        CalendarDay = '\uf783',
        
        /// <summary>
        ///     Calendar Minus ("fa-calendar-minus", \uf272) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Minus", Description = "fa-calendar-minus", GroupName = "duotone light regular solid")]
        CalendarMinus = '\uf272',
        
        /// <summary>
        ///     Calendar Plus ("fa-calendar-plus", \uf271) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Plus", Description = "fa-calendar-plus", GroupName = "duotone light regular solid")]
        CalendarPlus = '\uf271',
        
        /// <summary>
        ///     Calendar Times ("fa-calendar-times", \uf273) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Times", Description = "fa-calendar-times", GroupName = "duotone light regular solid")]
        CalendarTimes = '\uf273',
        
        /// <summary>
        ///     Calendar Week ("fa-calendar-week", \uf784) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Week", Description = "fa-calendar-week", GroupName = "duotone light regular solid")]
        CalendarWeek = '\uf784',
        
        /// <summary>
        ///     Camera ("fa-camera", \uf030) icon.
        /// </summary>
        /// 
        [Display(Name = "Camera", Description = "fa-camera", GroupName = "duotone light regular solid")]
        Camera = '\uf030',
        
        /// <summary>
        ///     Camera Retro ("fa-camera-retro", \uf083) icon.
        /// </summary>
        /// 
        [Display(Name = "Camera Retro", Description = "fa-camera-retro", GroupName = "duotone light regular solid")]
        CameraRetro = '\uf083',
        
        /// <summary>
        ///     Campground ("fa-campground", \uf6bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Campground", Description = "fa-campground", GroupName = "duotone light regular solid")]
        Campground = '\uf6bb',
        
        /// <summary>
        ///     Canadian Maple Leaf ("fa-canadian-maple-leaf", \uf785) icon.
        /// </summary>
        /// 
        [Display(Name = "Canadian Maple Leaf", Description = "fa-canadian-maple-leaf", GroupName = "brands")]
        CanadianMapleLeaf = '\uf785',
        
        /// <summary>
        ///     Candy Cane ("fa-candy-cane", \uf786) icon.
        /// </summary>
        /// 
        [Display(Name = "Candy Cane", Description = "fa-candy-cane", GroupName = "duotone light regular solid")]
        CandyCane = '\uf786',
        
        /// <summary>
        ///     Cannabis ("fa-cannabis", \uf55f) icon.
        /// </summary>
        /// 
        [Display(Name = "Cannabis", Description = "fa-cannabis", GroupName = "duotone light regular solid")]
        Cannabis = '\uf55f',
        
        /// <summary>
        ///     Capsules ("fa-capsules", \uf46b) icon.
        /// </summary>
        /// 
        [Display(Name = "Capsules", Description = "fa-capsules", GroupName = "duotone light regular solid")]
        Capsules = '\uf46b',
        
        /// <summary>
        ///     Car ("fa-car", \uf1b9) icon.
        /// </summary>
        /// 
        [Display(Name = "Car", Description = "fa-car", GroupName = "duotone light regular solid")]
        Car = '\uf1b9',
        
        /// <summary>
        ///     Car Alt ("fa-car-alt", \uf5de) icon.
        /// </summary>
        /// 
        [Display(Name = "Car Alt", Description = "fa-car-alt", GroupName = "duotone light regular solid")]
        CarAlt = '\uf5de',
        
        /// <summary>
        ///     Caravan ("fa-caravan", \uf8ff) icon.
        /// </summary>
        /// 
        [Display(Name = "Caravan", Description = "fa-caravan", GroupName = "duotone light regular solid")]
        Caravan = '\uf8ff',
        
        /// <summary>
        ///     Car Battery ("fa-car-battery", \uf5df) icon.
        /// </summary>
        /// 
        [Display(Name = "Car Battery", Description = "fa-car-battery", GroupName = "duotone light regular solid")]
        CarBattery = '\uf5df',
        
        /// <summary>
        ///     Car Crash ("fa-car-crash", \uf5e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Car Crash", Description = "fa-car-crash", GroupName = "duotone light regular solid")]
        CarCrash = '\uf5e1',
        
        /// <summary>
        ///     Caret Down ("fa-caret-down", \uf0d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Down", Description = "fa-caret-down", GroupName = "duotone light regular solid")]
        CaretDown = '\uf0d7',
        
        /// <summary>
        ///     Caret Left ("fa-caret-left", \uf0d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Left", Description = "fa-caret-left", GroupName = "duotone light regular solid")]
        CaretLeft = '\uf0d9',
        
        /// <summary>
        ///     Caret Right ("fa-caret-right", \uf0da) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Right", Description = "fa-caret-right", GroupName = "duotone light regular solid")]
        CaretRight = '\uf0da',
        
        /// <summary>
        ///     Caret Square Down ("fa-caret-square-down", \uf150) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Square Down", Description = "fa-caret-square-down", GroupName = "duotone light regular solid")]
        CaretSquareDown = '\uf150',
        
        /// <summary>
        ///     Caret Square Left ("fa-caret-square-left", \uf191) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Square Left", Description = "fa-caret-square-left", GroupName = "duotone light regular solid")]
        CaretSquareLeft = '\uf191',
        
        /// <summary>
        ///     Caret Square Right ("fa-caret-square-right", \uf152) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Square Right", Description = "fa-caret-square-right", GroupName = "duotone light regular solid")]
        CaretSquareRight = '\uf152',
        
        /// <summary>
        ///     Caret Square Up ("fa-caret-square-up", \uf151) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Square Up", Description = "fa-caret-square-up", GroupName = "duotone light regular solid")]
        CaretSquareUp = '\uf151',
        
        /// <summary>
        ///     Caret Up ("fa-caret-up", \uf0d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Up", Description = "fa-caret-up", GroupName = "duotone light regular solid")]
        CaretUp = '\uf0d8',
        
        /// <summary>
        ///     Carrot ("fa-carrot", \uf787) icon.
        /// </summary>
        /// 
        [Display(Name = "Carrot", Description = "fa-carrot", GroupName = "duotone light regular solid")]
        Carrot = '\uf787',
        
        /// <summary>
        ///     Car Side ("fa-car-side", \uf5e4) icon.
        /// </summary>
        /// 
        [Display(Name = "Car Side", Description = "fa-car-side", GroupName = "duotone light regular solid")]
        CarSide = '\uf5e4',
        
        /// <summary>
        ///     Cart Arrow Down ("fa-cart-arrow-down", \uf218) icon.
        /// </summary>
        /// 
        [Display(Name = "Cart Arrow Down", Description = "fa-cart-arrow-down", GroupName = "duotone light regular solid")]
        CartArrowDown = '\uf218',
        
        /// <summary>
        ///     Cart Plus ("fa-cart-plus", \uf217) icon.
        /// </summary>
        /// 
        [Display(Name = "Cart Plus", Description = "fa-cart-plus", GroupName = "duotone light regular solid")]
        CartPlus = '\uf217',
        
        /// <summary>
        ///     Cash Register ("fa-cash-register", \uf788) icon.
        /// </summary>
        /// 
        [Display(Name = "Cash Register", Description = "fa-cash-register", GroupName = "duotone light regular solid")]
        CashRegister = '\uf788',
        
        /// <summary>
        ///     Cat ("fa-cat", \uf6be) icon.
        /// </summary>
        /// 
        [Display(Name = "Cat", Description = "fa-cat", GroupName = "duotone light regular solid")]
        Cat = '\uf6be',
        
        /// <summary>
        ///     Cc Amazon Pay ("fa-cc-amazon-pay", \uf42d) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Amazon Pay", Description = "fa-cc-amazon-pay", GroupName = "brands")]
        CcAmazonPay = '\uf42d',
        
        /// <summary>
        ///     Cc Amex ("fa-cc-amex", \uf1f3) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Amex", Description = "fa-cc-amex", GroupName = "brands")]
        CcAmex = '\uf1f3',
        
        /// <summary>
        ///     Cc Apple Pay ("fa-cc-apple-pay", \uf416) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Apple Pay", Description = "fa-cc-apple-pay", GroupName = "brands")]
        CcApplePay = '\uf416',
        
        /// <summary>
        ///     Cc Diners Club ("fa-cc-diners-club", \uf24c) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Diners Club", Description = "fa-cc-diners-club", GroupName = "brands")]
        CcDinersClub = '\uf24c',
        
        /// <summary>
        ///     Cc Discover ("fa-cc-discover", \uf1f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Discover", Description = "fa-cc-discover", GroupName = "brands")]
        CcDiscover = '\uf1f2',
        
        /// <summary>
        ///     Cc Jcb ("fa-cc-jcb", \uf24b) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Jcb", Description = "fa-cc-jcb", GroupName = "brands")]
        CcJcb = '\uf24b',
        
        /// <summary>
        ///     Cc Mastercard ("fa-cc-mastercard", \uf1f1) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Mastercard", Description = "fa-cc-mastercard", GroupName = "brands")]
        CcMastercard = '\uf1f1',
        
        /// <summary>
        ///     Cc Paypal ("fa-cc-paypal", \uf1f4) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Paypal", Description = "fa-cc-paypal", GroupName = "brands")]
        CcPaypal = '\uf1f4',
        
        /// <summary>
        ///     Cc Stripe ("fa-cc-stripe", \uf1f5) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Stripe", Description = "fa-cc-stripe", GroupName = "brands")]
        CcStripe = '\uf1f5',
        
        /// <summary>
        ///     Cc Visa ("fa-cc-visa", \uf1f0) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Visa", Description = "fa-cc-visa", GroupName = "brands")]
        CcVisa = '\uf1f0',
        
        /// <summary>
        ///     Centercode ("fa-centercode", \uf380) icon.
        /// </summary>
        /// 
        [Display(Name = "Centercode", Description = "fa-centercode", GroupName = "brands")]
        Centercode = '\uf380',
        
        /// <summary>
        ///     Centos ("fa-centos", \uf789) icon.
        /// </summary>
        /// 
        [Display(Name = "Centos", Description = "fa-centos", GroupName = "brands")]
        Centos = '\uf789',
        
        /// <summary>
        ///     Certificate ("fa-certificate", \uf0a3) icon.
        /// </summary>
        /// 
        [Display(Name = "Certificate", Description = "fa-certificate", GroupName = "duotone light regular solid")]
        Certificate = '\uf0a3',
        
        /// <summary>
        ///     Chair ("fa-chair", \uf6c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Chair", Description = "fa-chair", GroupName = "duotone light regular solid")]
        Chair = '\uf6c0',
        
        /// <summary>
        ///     Chalkboard ("fa-chalkboard", \uf51b) icon.
        /// </summary>
        /// 
        [Display(Name = "Chalkboard", Description = "fa-chalkboard", GroupName = "duotone light regular solid")]
        Chalkboard = '\uf51b',
        
        /// <summary>
        ///     Chalkboard Teacher ("fa-chalkboard-teacher", \uf51c) icon.
        /// </summary>
        /// 
        [Display(Name = "Chalkboard Teacher", Description = "fa-chalkboard-teacher", GroupName = "duotone light regular solid")]
        ChalkboardTeacher = '\uf51c',
        
        /// <summary>
        ///     Charging Station ("fa-charging-station", \uf5e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Charging Station", Description = "fa-charging-station", GroupName = "duotone light regular solid")]
        ChargingStation = '\uf5e7',
        
        /// <summary>
        ///     Chart Area ("fa-chart-area", \uf1fe) icon.
        /// </summary>
        /// 
        [Display(Name = "Chart Area", Description = "fa-chart-area", GroupName = "duotone light regular solid")]
        ChartArea = '\uf1fe',
        
        /// <summary>
        ///     Chart Bar ("fa-chart-bar", \uf080) icon.
        /// </summary>
        /// 
        [Display(Name = "Chart Bar", Description = "fa-chart-bar", GroupName = "duotone light regular solid")]
        ChartBar = '\uf080',
        
        /// <summary>
        ///     Chart Line ("fa-chart-line", \uf201) icon.
        /// </summary>
        /// 
        [Display(Name = "Chart Line", Description = "fa-chart-line", GroupName = "duotone light regular solid")]
        ChartLine = '\uf201',
        
        /// <summary>
        ///     Chart Pie ("fa-chart-pie", \uf200) icon.
        /// </summary>
        /// 
        [Display(Name = "Chart Pie", Description = "fa-chart-pie", GroupName = "duotone light regular solid")]
        ChartPie = '\uf200',
        
        /// <summary>
        ///     Check ("fa-check", \uf00c) icon.
        /// </summary>
        /// 
        [Display(Name = "Check", Description = "fa-check", GroupName = "duotone light regular solid")]
        Check = '\uf00c',
        
        /// <summary>
        ///     Check Circle ("fa-check-circle", \uf058) icon.
        /// </summary>
        /// 
        [Display(Name = "Check Circle", Description = "fa-check-circle", GroupName = "duotone light regular solid")]
        CheckCircle = '\uf058',
        
        /// <summary>
        ///     Check Double ("fa-check-double", \uf560) icon.
        /// </summary>
        /// 
        [Display(Name = "Check Double", Description = "fa-check-double", GroupName = "duotone light regular solid")]
        CheckDouble = '\uf560',
        
        /// <summary>
        ///     Check Square ("fa-check-square", \uf14a) icon.
        /// </summary>
        /// 
        [Display(Name = "Check Square", Description = "fa-check-square", GroupName = "duotone light regular solid")]
        CheckSquare = '\uf14a',
        
        /// <summary>
        ///     Cheese ("fa-cheese", \uf7ef) icon.
        /// </summary>
        /// 
        [Display(Name = "Cheese", Description = "fa-cheese", GroupName = "duotone light regular solid")]
        Cheese = '\uf7ef',
        
        /// <summary>
        ///     Chess ("fa-chess", \uf439) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess", Description = "fa-chess", GroupName = "duotone light regular solid")]
        Chess = '\uf439',
        
        /// <summary>
        ///     Chess Bishop ("fa-chess-bishop", \uf43a) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Bishop", Description = "fa-chess-bishop", GroupName = "duotone light regular solid")]
        ChessBishop = '\uf43a',
        
        /// <summary>
        ///     Chess Board ("fa-chess-board", \uf43c) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Board", Description = "fa-chess-board", GroupName = "duotone light regular solid")]
        ChessBoard = '\uf43c',
        
        /// <summary>
        ///     Chess King ("fa-chess-king", \uf43f) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess King", Description = "fa-chess-king", GroupName = "duotone light regular solid")]
        ChessKing = '\uf43f',
        
        /// <summary>
        ///     Chess Knight ("fa-chess-knight", \uf441) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Knight", Description = "fa-chess-knight", GroupName = "duotone light regular solid")]
        ChessKnight = '\uf441',
        
        /// <summary>
        ///     Chess Pawn ("fa-chess-pawn", \uf443) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Pawn", Description = "fa-chess-pawn", GroupName = "duotone light regular solid")]
        ChessPawn = '\uf443',
        
        /// <summary>
        ///     Chess Queen ("fa-chess-queen", \uf445) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Queen", Description = "fa-chess-queen", GroupName = "duotone light regular solid")]
        ChessQueen = '\uf445',
        
        /// <summary>
        ///     Chess Rook ("fa-chess-rook", \uf447) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Rook", Description = "fa-chess-rook", GroupName = "duotone light regular solid")]
        ChessRook = '\uf447',
        
        /// <summary>
        ///     Chevron Circle Down ("fa-chevron-circle-down", \uf13a) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Circle Down", Description = "fa-chevron-circle-down", GroupName = "duotone light regular solid")]
        ChevronCircleDown = '\uf13a',
        
        /// <summary>
        ///     Chevron Circle Left ("fa-chevron-circle-left", \uf137) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Circle Left", Description = "fa-chevron-circle-left", GroupName = "duotone light regular solid")]
        ChevronCircleLeft = '\uf137',
        
        /// <summary>
        ///     Chevron Circle Right ("fa-chevron-circle-right", \uf138) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Circle Right", Description = "fa-chevron-circle-right", GroupName = "duotone light regular solid")]
        ChevronCircleRight = '\uf138',
        
        /// <summary>
        ///     Chevron Circle Up ("fa-chevron-circle-up", \uf139) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Circle Up", Description = "fa-chevron-circle-up", GroupName = "duotone light regular solid")]
        ChevronCircleUp = '\uf139',
        
        /// <summary>
        ///     Chevron Down ("fa-chevron-down", \uf078) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Down", Description = "fa-chevron-down", GroupName = "duotone light regular solid")]
        ChevronDown = '\uf078',
        
        /// <summary>
        ///     Chevron Left ("fa-chevron-left", \uf053) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Left", Description = "fa-chevron-left", GroupName = "duotone light regular solid")]
        ChevronLeft = '\uf053',
        
        /// <summary>
        ///     Chevron Right ("fa-chevron-right", \uf054) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Right", Description = "fa-chevron-right", GroupName = "duotone light regular solid")]
        ChevronRight = '\uf054',
        
        /// <summary>
        ///     Chevron Up ("fa-chevron-up", \uf077) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Up", Description = "fa-chevron-up", GroupName = "duotone light regular solid")]
        ChevronUp = '\uf077',
        
        /// <summary>
        ///     Child ("fa-child", \uf1ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Child", Description = "fa-child", GroupName = "duotone light regular solid")]
        Child = '\uf1ae',
        
        /// <summary>
        ///     Chrome ("fa-chrome", \uf268) icon.
        /// </summary>
        /// 
        [Display(Name = "Chrome", Description = "fa-chrome", GroupName = "brands")]
        Chrome = '\uf268',
        
        /// <summary>
        ///     Chromecast ("fa-chromecast", \uf838) icon.
        /// </summary>
        /// 
        [Display(Name = "Chromecast", Description = "fa-chromecast", GroupName = "brands")]
        Chromecast = '\uf838',
        
        /// <summary>
        ///     Church ("fa-church", \uf51d) icon.
        /// </summary>
        /// 
        [Display(Name = "Church", Description = "fa-church", GroupName = "duotone light regular solid")]
        Church = '\uf51d',
        
        /// <summary>
        ///     Circle ("fa-circle", \uf111) icon.
        /// </summary>
        /// 
        [Display(Name = "Circle", Description = "fa-circle", GroupName = "duotone light regular solid")]
        Circle = '\uf111',
        
        /// <summary>
        ///     Circle Notch ("fa-circle-notch", \uf1ce) icon.
        /// </summary>
        /// 
        [Display(Name = "Circle Notch", Description = "fa-circle-notch", GroupName = "duotone light regular solid")]
        CircleNotch = '\uf1ce',
        
        /// <summary>
        ///     City ("fa-city", \uf64f) icon.
        /// </summary>
        /// 
        [Display(Name = "City", Description = "fa-city", GroupName = "duotone light regular solid")]
        City = '\uf64f',
        
        /// <summary>
        ///     Clinic Medical ("fa-clinic-medical", \uf7f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Clinic Medical", Description = "fa-clinic-medical", GroupName = "duotone light regular solid")]
        ClinicMedical = '\uf7f2',
        
        /// <summary>
        ///     Clipboard ("fa-clipboard", \uf328) icon.
        /// </summary>
        /// 
        [Display(Name = "Clipboard", Description = "fa-clipboard", GroupName = "duotone light regular solid")]
        Clipboard = '\uf328',
        
        /// <summary>
        ///     Clipboard Check ("fa-clipboard-check", \uf46c) icon.
        /// </summary>
        /// 
        [Display(Name = "Clipboard Check", Description = "fa-clipboard-check", GroupName = "duotone light regular solid")]
        ClipboardCheck = '\uf46c',
        
        /// <summary>
        ///     Clipboard List ("fa-clipboard-list", \uf46d) icon.
        /// </summary>
        /// 
        [Display(Name = "Clipboard List", Description = "fa-clipboard-list", GroupName = "duotone light regular solid")]
        ClipboardList = '\uf46d',
        
        /// <summary>
        ///     Clock ("fa-clock", \uf017) icon.
        /// </summary>
        /// 
        [Display(Name = "Clock", Description = "fa-clock", GroupName = "duotone light regular solid")]
        Clock = '\uf017',
        
        /// <summary>
        ///     Clone ("fa-clone", \uf24d) icon.
        /// </summary>
        /// 
        [Display(Name = "Clone", Description = "fa-clone", GroupName = "duotone light regular solid")]
        Clone = '\uf24d',
        
        /// <summary>
        ///     Closed Captioning ("fa-closed-captioning", \uf20a) icon.
        /// </summary>
        /// 
        [Display(Name = "Closed Captioning", Description = "fa-closed-captioning", GroupName = "duotone light regular solid")]
        ClosedCaptioning = '\uf20a',
        
        /// <summary>
        ///     Cloud ("fa-cloud", \uf0c2) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud", Description = "fa-cloud", GroupName = "duotone light regular solid")]
        Cloud = '\uf0c2',
        
        /// <summary>
        ///     Cloud Download Alt ("fa-cloud-download-alt", \uf381) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Download Alt", Description = "fa-cloud-download-alt", GroupName = "duotone light regular solid")]
        CloudDownloadAlt = '\uf381',
        
        /// <summary>
        ///     Cloud Meatball ("fa-cloud-meatball", \uf73b) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Meatball", Description = "fa-cloud-meatball", GroupName = "duotone light regular solid")]
        CloudMeatball = '\uf73b',
        
        /// <summary>
        ///     Cloud Moon ("fa-cloud-moon", \uf6c3) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Moon", Description = "fa-cloud-moon", GroupName = "duotone light regular solid")]
        CloudMoon = '\uf6c3',
        
        /// <summary>
        ///     Cloud Moon Rain ("fa-cloud-moon-rain", \uf73c) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Moon Rain", Description = "fa-cloud-moon-rain", GroupName = "duotone light regular solid")]
        CloudMoonRain = '\uf73c',
        
        /// <summary>
        ///     Cloud Rain ("fa-cloud-rain", \uf73d) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Rain", Description = "fa-cloud-rain", GroupName = "duotone light regular solid")]
        CloudRain = '\uf73d',
        
        /// <summary>
        ///     Cloudscale ("fa-cloudscale", \uf383) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloudscale", Description = "fa-cloudscale", GroupName = "brands")]
        Cloudscale = '\uf383',
        
        /// <summary>
        ///     Cloud Showers Heavy ("fa-cloud-showers-heavy", \uf740) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Showers Heavy", Description = "fa-cloud-showers-heavy", GroupName = "duotone light regular solid")]
        CloudShowersHeavy = '\uf740',
        
        /// <summary>
        ///     Cloudsmith ("fa-cloudsmith", \uf384) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloudsmith", Description = "fa-cloudsmith", GroupName = "brands")]
        Cloudsmith = '\uf384',
        
        /// <summary>
        ///     Cloud Sun ("fa-cloud-sun", \uf6c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Sun", Description = "fa-cloud-sun", GroupName = "duotone light regular solid")]
        CloudSun = '\uf6c4',
        
        /// <summary>
        ///     Cloud Sun Rain ("fa-cloud-sun-rain", \uf743) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Sun Rain", Description = "fa-cloud-sun-rain", GroupName = "duotone light regular solid")]
        CloudSunRain = '\uf743',
        
        /// <summary>
        ///     Cloud Upload Alt ("fa-cloud-upload-alt", \uf382) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Upload Alt", Description = "fa-cloud-upload-alt", GroupName = "duotone light regular solid")]
        CloudUploadAlt = '\uf382',
        
        /// <summary>
        ///     Cloudversify ("fa-cloudversify", \uf385) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloudversify", Description = "fa-cloudversify", GroupName = "brands")]
        Cloudversify = '\uf385',
        
        /// <summary>
        ///     Cocktail ("fa-cocktail", \uf561) icon.
        /// </summary>
        /// 
        [Display(Name = "Cocktail", Description = "fa-cocktail", GroupName = "duotone light regular solid")]
        Cocktail = '\uf561',
        
        /// <summary>
        ///     Code ("fa-code", \uf121) icon.
        /// </summary>
        /// 
        [Display(Name = "Code", Description = "fa-code", GroupName = "duotone light regular solid")]
        Code = '\uf121',
        
        /// <summary>
        ///     Code Branch ("fa-code-branch", \uf126) icon.
        /// </summary>
        /// 
        [Display(Name = "Code Branch", Description = "fa-code-branch", GroupName = "duotone light regular solid")]
        CodeBranch = '\uf126',
        
        /// <summary>
        ///     Codepen ("fa-codepen", \uf1cb) icon.
        /// </summary>
        /// 
        [Display(Name = "Codepen", Description = "fa-codepen", GroupName = "brands")]
        Codepen = '\uf1cb',
        
        /// <summary>
        ///     Codiepie ("fa-codiepie", \uf284) icon.
        /// </summary>
        /// 
        [Display(Name = "Codiepie", Description = "fa-codiepie", GroupName = "brands")]
        Codiepie = '\uf284',
        
        /// <summary>
        ///     Coffee ("fa-coffee", \uf0f4) icon.
        /// </summary>
        /// 
        [Display(Name = "Coffee", Description = "fa-coffee", GroupName = "duotone light regular solid")]
        Coffee = '\uf0f4',
        
        /// <summary>
        ///     Cog ("fa-cog", \uf013) icon.
        /// </summary>
        /// 
        [Display(Name = "Cog", Description = "fa-cog", GroupName = "duotone light regular solid")]
        Cog = '\uf013',
        
        /// <summary>
        ///     Cogs ("fa-cogs", \uf085) icon.
        /// </summary>
        /// 
        [Display(Name = "Cogs", Description = "fa-cogs", GroupName = "duotone light regular solid")]
        Cogs = '\uf085',
        
        /// <summary>
        ///     Coins ("fa-coins", \uf51e) icon.
        /// </summary>
        /// 
        [Display(Name = "Coins", Description = "fa-coins", GroupName = "duotone light regular solid")]
        Coins = '\uf51e',
        
        /// <summary>
        ///     Columns ("fa-columns", \uf0db) icon.
        /// </summary>
        /// 
        [Display(Name = "Columns", Description = "fa-columns", GroupName = "duotone light regular solid")]
        Columns = '\uf0db',
        
        /// <summary>
        ///     Comment ("fa-comment", \uf075) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment", Description = "fa-comment", GroupName = "duotone light regular solid")]
        Comment = '\uf075',
        
        /// <summary>
        ///     Comment Alt ("fa-comment-alt", \uf27a) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment Alt", Description = "fa-comment-alt", GroupName = "duotone light regular solid")]
        CommentAlt = '\uf27a',
        
        /// <summary>
        ///     Comment Dollar ("fa-comment-dollar", \uf651) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment Dollar", Description = "fa-comment-dollar", GroupName = "duotone light regular solid")]
        CommentDollar = '\uf651',
        
        /// <summary>
        ///     Comment Dots ("fa-comment-dots", \uf4ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment Dots", Description = "fa-comment-dots", GroupName = "duotone light regular solid")]
        CommentDots = '\uf4ad',
        
        /// <summary>
        ///     Comment Medical ("fa-comment-medical", \uf7f5) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment Medical", Description = "fa-comment-medical", GroupName = "duotone light regular solid")]
        CommentMedical = '\uf7f5',
        
        /// <summary>
        ///     Comments ("fa-comments", \uf086) icon.
        /// </summary>
        /// 
        [Display(Name = "Comments", Description = "fa-comments", GroupName = "duotone light regular solid")]
        Comments = '\uf086',
        
        /// <summary>
        ///     Comments Dollar ("fa-comments-dollar", \uf653) icon.
        /// </summary>
        /// 
        [Display(Name = "Comments Dollar", Description = "fa-comments-dollar", GroupName = "duotone light regular solid")]
        CommentsDollar = '\uf653',
        
        /// <summary>
        ///     Comment Slash ("fa-comment-slash", \uf4b3) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment Slash", Description = "fa-comment-slash", GroupName = "duotone light regular solid")]
        CommentSlash = '\uf4b3',
        
        /// <summary>
        ///     Compact Disc ("fa-compact-disc", \uf51f) icon.
        /// </summary>
        /// 
        [Display(Name = "Compact Disc", Description = "fa-compact-disc", GroupName = "duotone light regular solid")]
        CompactDisc = '\uf51f',
        
        /// <summary>
        ///     Compass ("fa-compass", \uf14e) icon.
        /// </summary>
        /// 
        [Display(Name = "Compass", Description = "fa-compass", GroupName = "duotone light regular solid")]
        Compass = '\uf14e',
        
        /// <summary>
        ///     Compress ("fa-compress", \uf066) icon.
        /// </summary>
        /// 
        [Display(Name = "Compress", Description = "fa-compress", GroupName = "duotone light regular solid")]
        Compress = '\uf066',
        
        /// <summary>
        ///     Compress Alt ("fa-compress-alt", \uf422) icon.
        /// </summary>
        /// 
        [Display(Name = "Compress Alt", Description = "fa-compress-alt", GroupName = "duotone light regular solid")]
        CompressAlt = '\uf422',
        
        /// <summary>
        ///     Compress Arrows Alt ("fa-compress-arrows-alt", \uf78c) icon.
        /// </summary>
        /// 
        [Display(Name = "Compress Arrows Alt", Description = "fa-compress-arrows-alt", GroupName = "duotone light regular solid")]
        CompressArrowsAlt = '\uf78c',
        
        /// <summary>
        ///     Concierge Bell ("fa-concierge-bell", \uf562) icon.
        /// </summary>
        /// 
        [Display(Name = "Concierge Bell", Description = "fa-concierge-bell", GroupName = "duotone light regular solid")]
        ConciergeBell = '\uf562',
        
        /// <summary>
        ///     Confluence ("fa-confluence", \uf78d) icon.
        /// </summary>
        /// 
        [Display(Name = "Confluence", Description = "fa-confluence", GroupName = "brands")]
        Confluence = '\uf78d',
        
        /// <summary>
        ///     Connectdevelop ("fa-connectdevelop", \uf20e) icon.
        /// </summary>
        /// 
        [Display(Name = "Connectdevelop", Description = "fa-connectdevelop", GroupName = "brands")]
        Connectdevelop = '\uf20e',
        
        /// <summary>
        ///     Contao ("fa-contao", \uf26d) icon.
        /// </summary>
        /// 
        [Display(Name = "Contao", Description = "fa-contao", GroupName = "brands")]
        Contao = '\uf26d',
        
        /// <summary>
        ///     Cookie ("fa-cookie", \uf563) icon.
        /// </summary>
        /// 
        [Display(Name = "Cookie", Description = "fa-cookie", GroupName = "duotone light regular solid")]
        Cookie = '\uf563',
        
        /// <summary>
        ///     Cookie Bite ("fa-cookie-bite", \uf564) icon.
        /// </summary>
        /// 
        [Display(Name = "Cookie Bite", Description = "fa-cookie-bite", GroupName = "duotone light regular solid")]
        CookieBite = '\uf564',
        
        /// <summary>
        ///     Copy ("fa-copy", \uf0c5) icon.
        /// </summary>
        /// 
        [Display(Name = "Copy", Description = "fa-copy", GroupName = "duotone light regular solid")]
        Copy = '\uf0c5',
        
        /// <summary>
        ///     Copyright ("fa-copyright", \uf1f9) icon.
        /// </summary>
        /// 
        [Display(Name = "Copyright", Description = "fa-copyright", GroupName = "duotone light regular solid")]
        Copyright = '\uf1f9',
        
        /// <summary>
        ///     Cotton Bureau ("fa-cotton-bureau", \uf89e) icon.
        /// </summary>
        /// 
        [Display(Name = "Cotton Bureau", Description = "fa-cotton-bureau", GroupName = "brands")]
        CottonBureau = '\uf89e',
        
        /// <summary>
        ///     Couch ("fa-couch", \uf4b8) icon.
        /// </summary>
        /// 
        [Display(Name = "Couch", Description = "fa-couch", GroupName = "duotone light regular solid")]
        Couch = '\uf4b8',
        
        /// <summary>
        ///     Cpanel ("fa-cpanel", \uf388) icon.
        /// </summary>
        /// 
        [Display(Name = "Cpanel", Description = "fa-cpanel", GroupName = "brands")]
        Cpanel = '\uf388',
        
        /// <summary>
        ///     Creative Commons ("fa-creative-commons", \uf25e) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons", Description = "fa-creative-commons", GroupName = "brands")]
        CreativeCommons = '\uf25e',
        
        /// <summary>
        ///     Creative Commons By ("fa-creative-commons-by", \uf4e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons By", Description = "fa-creative-commons-by", GroupName = "brands")]
        CreativeCommonsBy = '\uf4e7',
        
        /// <summary>
        ///     Creative Commons Nc ("fa-creative-commons-nc", \uf4e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Nc", Description = "fa-creative-commons-nc", GroupName = "brands")]
        CreativeCommonsNc = '\uf4e8',
        
        /// <summary>
        ///     Creative Commons Nc Eu ("fa-creative-commons-nc-eu", \uf4e9) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Nc Eu", Description = "fa-creative-commons-nc-eu", GroupName = "brands")]
        CreativeCommonsNcEu = '\uf4e9',
        
        /// <summary>
        ///     Creative Commons Nc Jp ("fa-creative-commons-nc-jp", \uf4ea) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Nc Jp", Description = "fa-creative-commons-nc-jp", GroupName = "brands")]
        CreativeCommonsNcJp = '\uf4ea',
        
        /// <summary>
        ///     Creative Commons Nd ("fa-creative-commons-nd", \uf4eb) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Nd", Description = "fa-creative-commons-nd", GroupName = "brands")]
        CreativeCommonsNd = '\uf4eb',
        
        /// <summary>
        ///     Creative Commons Pd ("fa-creative-commons-pd", \uf4ec) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Pd", Description = "fa-creative-commons-pd", GroupName = "brands")]
        CreativeCommonsPd = '\uf4ec',
        
        /// <summary>
        ///     Creative Commons Pd Alt ("fa-creative-commons-pd-alt", \uf4ed) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Pd Alt", Description = "fa-creative-commons-pd-alt", GroupName = "brands")]
        CreativeCommonsPdAlt = '\uf4ed',
        
        /// <summary>
        ///     Creative Commons Remix ("fa-creative-commons-remix", \uf4ee) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Remix", Description = "fa-creative-commons-remix", GroupName = "brands")]
        CreativeCommonsRemix = '\uf4ee',
        
        /// <summary>
        ///     Creative Commons Sa ("fa-creative-commons-sa", \uf4ef) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Sa", Description = "fa-creative-commons-sa", GroupName = "brands")]
        CreativeCommonsSa = '\uf4ef',
        
        /// <summary>
        ///     Creative Commons Sampling ("fa-creative-commons-sampling", \uf4f0) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Sampling", Description = "fa-creative-commons-sampling", GroupName = "brands")]
        CreativeCommonsSampling = '\uf4f0',
        
        /// <summary>
        ///     Creative Commons Sampling Plus ("fa-creative-commons-sampling-plus", \uf4f1) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Sampling Plus", Description = "fa-creative-commons-sampling-plus", GroupName = "brands")]
        CreativeCommonsSamplingPlus = '\uf4f1',
        
        /// <summary>
        ///     Creative Commons Share ("fa-creative-commons-share", \uf4f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Share", Description = "fa-creative-commons-share", GroupName = "brands")]
        CreativeCommonsShare = '\uf4f2',
        
        /// <summary>
        ///     Creative Commons Zero ("fa-creative-commons-zero", \uf4f3) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Zero", Description = "fa-creative-commons-zero", GroupName = "brands")]
        CreativeCommonsZero = '\uf4f3',
        
        /// <summary>
        ///     Credit Card ("fa-credit-card", \uf09d) icon.
        /// </summary>
        /// 
        [Display(Name = "Credit Card", Description = "fa-credit-card", GroupName = "duotone light regular solid")]
        CreditCard = '\uf09d',
        
        /// <summary>
        ///     Critical Role ("fa-critical-role", \uf6c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Critical Role", Description = "fa-critical-role", GroupName = "brands")]
        CriticalRole = '\uf6c9',
        
        /// <summary>
        ///     Crop ("fa-crop", \uf125) icon.
        /// </summary>
        /// 
        [Display(Name = "Crop", Description = "fa-crop", GroupName = "duotone light regular solid")]
        Crop = '\uf125',
        
        /// <summary>
        ///     Crop Alt ("fa-crop-alt", \uf565) icon.
        /// </summary>
        /// 
        [Display(Name = "Crop Alt", Description = "fa-crop-alt", GroupName = "duotone light regular solid")]
        CropAlt = '\uf565',
        
        /// <summary>
        ///     Cross ("fa-cross", \uf654) icon.
        /// </summary>
        /// 
        [Display(Name = "Cross", Description = "fa-cross", GroupName = "duotone light regular solid")]
        Cross = '\uf654',
        
        /// <summary>
        ///     Crosshairs ("fa-crosshairs", \uf05b) icon.
        /// </summary>
        /// 
        [Display(Name = "Crosshairs", Description = "fa-crosshairs", GroupName = "duotone light regular solid")]
        Crosshairs = '\uf05b',
        
        /// <summary>
        ///     Crow ("fa-crow", \uf520) icon.
        /// </summary>
        /// 
        [Display(Name = "Crow", Description = "fa-crow", GroupName = "duotone light regular solid")]
        Crow = '\uf520',
        
        /// <summary>
        ///     Crown ("fa-crown", \uf521) icon.
        /// </summary>
        /// 
        [Display(Name = "Crown", Description = "fa-crown", GroupName = "duotone light regular solid")]
        Crown = '\uf521',
        
        /// <summary>
        ///     Crutch ("fa-crutch", \uf7f7) icon.
        /// </summary>
        /// 
        [Display(Name = "Crutch", Description = "fa-crutch", GroupName = "duotone light regular solid")]
        Crutch = '\uf7f7',
        
        /// <summary>
        ///     Css3 ("fa-css3", \uf13c) icon.
        /// </summary>
        /// 
        [Display(Name = "Css3", Description = "fa-css3", GroupName = "brands")]
        Css3 = '\uf13c',
        
        /// <summary>
        ///     Css3 Alt ("fa-css3-alt", \uf38b) icon.
        /// </summary>
        /// 
        [Display(Name = "Css3 Alt", Description = "fa-css3-alt", GroupName = "brands")]
        Css3Alt = '\uf38b',
        
        /// <summary>
        ///     Cube ("fa-cube", \uf1b2) icon.
        /// </summary>
        /// 
        [Display(Name = "Cube", Description = "fa-cube", GroupName = "duotone light regular solid")]
        Cube = '\uf1b2',
        
        /// <summary>
        ///     Cubes ("fa-cubes", \uf1b3) icon.
        /// </summary>
        /// 
        [Display(Name = "Cubes", Description = "fa-cubes", GroupName = "duotone light regular solid")]
        Cubes = '\uf1b3',
        
        /// <summary>
        ///     Cut ("fa-cut", \uf0c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Cut", Description = "fa-cut", GroupName = "duotone light regular solid")]
        Cut = '\uf0c4',
        
        /// <summary>
        ///     Cuttlefish ("fa-cuttlefish", \uf38c) icon.
        /// </summary>
        /// 
        [Display(Name = "Cuttlefish", Description = "fa-cuttlefish", GroupName = "brands")]
        Cuttlefish = '\uf38c',
        
        /// <summary>
        ///     Dailymotion ("fa-dailymotion", \uf952) icon.
        /// </summary>
        /// 
        [Display(Name = "Dailymotion", Description = "fa-dailymotion", GroupName = "brands")]
        Dailymotion = '\uf952',
        
        /// <summary>
        ///     D And D ("fa-d-and-d", \uf38d) icon.
        /// </summary>
        /// 
        [Display(Name = "D And D", Description = "fa-d-and-d", GroupName = "brands")]
        DAndD = '\uf38d',
        
        /// <summary>
        ///     D And D Beyond ("fa-d-and-d-beyond", \uf6ca) icon.
        /// </summary>
        /// 
        [Display(Name = "D And D Beyond", Description = "fa-d-and-d-beyond", GroupName = "brands")]
        DAndDBeyond = '\uf6ca',
        
        /// <summary>
        ///     Dashcube ("fa-dashcube", \uf210) icon.
        /// </summary>
        /// 
        [Display(Name = "Dashcube", Description = "fa-dashcube", GroupName = "brands")]
        Dashcube = '\uf210',
        
        /// <summary>
        ///     Database ("fa-database", \uf1c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Database", Description = "fa-database", GroupName = "duotone light regular solid")]
        Database = '\uf1c0',
        
        /// <summary>
        ///     Deaf ("fa-deaf", \uf2a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Deaf", Description = "fa-deaf", GroupName = "duotone light regular solid")]
        Deaf = '\uf2a4',
        
        /// <summary>
        ///     Delicious ("fa-delicious", \uf1a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Delicious", Description = "fa-delicious", GroupName = "brands")]
        Delicious = '\uf1a5',
        
        /// <summary>
        ///     Democrat ("fa-democrat", \uf747) icon.
        /// </summary>
        /// 
        [Display(Name = "Democrat", Description = "fa-democrat", GroupName = "duotone light regular solid")]
        Democrat = '\uf747',
        
        /// <summary>
        ///     Deploydog ("fa-deploydog", \uf38e) icon.
        /// </summary>
        /// 
        [Display(Name = "Deploydog", Description = "fa-deploydog", GroupName = "brands")]
        Deploydog = '\uf38e',
        
        /// <summary>
        ///     Deskpro ("fa-deskpro", \uf38f) icon.
        /// </summary>
        /// 
        [Display(Name = "Deskpro", Description = "fa-deskpro", GroupName = "brands")]
        Deskpro = '\uf38f',
        
        /// <summary>
        ///     Desktop ("fa-desktop", \uf108) icon.
        /// </summary>
        /// 
        [Display(Name = "Desktop", Description = "fa-desktop", GroupName = "duotone light regular solid")]
        Desktop = '\uf108',
        
        /// <summary>
        ///     Dev ("fa-dev", \uf6cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Dev", Description = "fa-dev", GroupName = "brands")]
        Dev = '\uf6cc',
        
        /// <summary>
        ///     Deviantart ("fa-deviantart", \uf1bd) icon.
        /// </summary>
        /// 
        [Display(Name = "Deviantart", Description = "fa-deviantart", GroupName = "brands")]
        Deviantart = '\uf1bd',
        
        /// <summary>
        ///     Dharmachakra ("fa-dharmachakra", \uf655) icon.
        /// </summary>
        /// 
        [Display(Name = "Dharmachakra", Description = "fa-dharmachakra", GroupName = "duotone light regular solid")]
        Dharmachakra = '\uf655',
        
        /// <summary>
        ///     Dhl ("fa-dhl", \uf790) icon.
        /// </summary>
        /// 
        [Display(Name = "Dhl", Description = "fa-dhl", GroupName = "brands")]
        Dhl = '\uf790',
        
        /// <summary>
        ///     Diagnoses ("fa-diagnoses", \uf470) icon.
        /// </summary>
        /// 
        [Display(Name = "Diagnoses", Description = "fa-diagnoses", GroupName = "duotone light regular solid")]
        Diagnoses = '\uf470',
        
        /// <summary>
        ///     Diaspora ("fa-diaspora", \uf791) icon.
        /// </summary>
        /// 
        [Display(Name = "Diaspora", Description = "fa-diaspora", GroupName = "brands")]
        Diaspora = '\uf791',
        
        /// <summary>
        ///     Dice ("fa-dice", \uf522) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice", Description = "fa-dice", GroupName = "duotone light regular solid")]
        Dice = '\uf522',
        
        /// <summary>
        ///     Dice D20 ("fa-dice-d20", \uf6cf) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice D20", Description = "fa-dice-d20", GroupName = "duotone light regular solid")]
        DiceD20 = '\uf6cf',
        
        /// <summary>
        ///     Dice D6 ("fa-dice-d6", \uf6d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice D6", Description = "fa-dice-d6", GroupName = "duotone light regular solid")]
        DiceD6 = '\uf6d1',
        
        /// <summary>
        ///     Dice Five ("fa-dice-five", \uf523) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice Five", Description = "fa-dice-five", GroupName = "duotone light regular solid")]
        DiceFive = '\uf523',
        
        /// <summary>
        ///     Dice Four ("fa-dice-four", \uf524) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice Four", Description = "fa-dice-four", GroupName = "duotone light regular solid")]
        DiceFour = '\uf524',
        
        /// <summary>
        ///     Dice One ("fa-dice-one", \uf525) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice One", Description = "fa-dice-one", GroupName = "duotone light regular solid")]
        DiceOne = '\uf525',
        
        /// <summary>
        ///     Dice Six ("fa-dice-six", \uf526) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice Six", Description = "fa-dice-six", GroupName = "duotone light regular solid")]
        DiceSix = '\uf526',
        
        /// <summary>
        ///     Dice Three ("fa-dice-three", \uf527) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice Three", Description = "fa-dice-three", GroupName = "duotone light regular solid")]
        DiceThree = '\uf527',
        
        /// <summary>
        ///     Dice Two ("fa-dice-two", \uf528) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice Two", Description = "fa-dice-two", GroupName = "duotone light regular solid")]
        DiceTwo = '\uf528',
        
        /// <summary>
        ///     Digg ("fa-digg", \uf1a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Digg", Description = "fa-digg", GroupName = "brands")]
        Digg = '\uf1a6',
        
        /// <summary>
        ///     Digital Ocean ("fa-digital-ocean", \uf391) icon.
        /// </summary>
        /// 
        [Display(Name = "Digital Ocean", Description = "fa-digital-ocean", GroupName = "brands")]
        DigitalOcean = '\uf391',
        
        /// <summary>
        ///     Digital Tachograph ("fa-digital-tachograph", \uf566) icon.
        /// </summary>
        /// 
        [Display(Name = "Digital Tachograph", Description = "fa-digital-tachograph", GroupName = "duotone light regular solid")]
        DigitalTachograph = '\uf566',
        
        /// <summary>
        ///     Directions ("fa-directions", \uf5eb) icon.
        /// </summary>
        /// 
        [Display(Name = "Directions", Description = "fa-directions", GroupName = "duotone light regular solid")]
        Directions = '\uf5eb',
        
        /// <summary>
        ///     Discord ("fa-discord", \uf392) icon.
        /// </summary>
        /// 
        [Display(Name = "Discord", Description = "fa-discord", GroupName = "brands")]
        Discord = '\uf392',
        
        /// <summary>
        ///     Discourse ("fa-discourse", \uf393) icon.
        /// </summary>
        /// 
        [Display(Name = "Discourse", Description = "fa-discourse", GroupName = "brands")]
        Discourse = '\uf393',
        
        /// <summary>
        ///     Disease ("fa-disease", \uf7fa) icon.
        /// </summary>
        /// 
        [Display(Name = "Disease", Description = "fa-disease", GroupName = "duotone light regular solid")]
        Disease = '\uf7fa',
        
        /// <summary>
        ///     Divide ("fa-divide", \uf529) icon.
        /// </summary>
        /// 
        [Display(Name = "Divide", Description = "fa-divide", GroupName = "duotone light regular solid")]
        Divide = '\uf529',
        
        /// <summary>
        ///     Dizzy ("fa-dizzy", \uf567) icon.
        /// </summary>
        /// 
        [Display(Name = "Dizzy", Description = "fa-dizzy", GroupName = "duotone light regular solid")]
        Dizzy = '\uf567',
        
        /// <summary>
        ///     Dna ("fa-dna", \uf471) icon.
        /// </summary>
        /// 
        [Display(Name = "Dna", Description = "fa-dna", GroupName = "duotone light regular solid")]
        Dna = '\uf471',
        
        /// <summary>
        ///     Dochub ("fa-dochub", \uf394) icon.
        /// </summary>
        /// 
        [Display(Name = "Dochub", Description = "fa-dochub", GroupName = "brands")]
        Dochub = '\uf394',
        
        /// <summary>
        ///     Docker ("fa-docker", \uf395) icon.
        /// </summary>
        /// 
        [Display(Name = "Docker", Description = "fa-docker", GroupName = "brands")]
        Docker = '\uf395',
        
        /// <summary>
        ///     Dog ("fa-dog", \uf6d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Dog", Description = "fa-dog", GroupName = "duotone light regular solid")]
        Dog = '\uf6d3',
        
        /// <summary>
        ///     Dollar Sign ("fa-dollar-sign", \uf155) icon.
        /// </summary>
        /// 
        [Display(Name = "Dollar Sign", Description = "fa-dollar-sign", GroupName = "duotone light regular solid")]
        DollarSign = '\uf155',
        
        /// <summary>
        ///     Dolly ("fa-dolly", \uf472) icon.
        /// </summary>
        /// 
        [Display(Name = "Dolly", Description = "fa-dolly", GroupName = "duotone light regular solid")]
        Dolly = '\uf472',
        
        /// <summary>
        ///     Dolly Flatbed ("fa-dolly-flatbed", \uf474) icon.
        /// </summary>
        /// 
        [Display(Name = "Dolly Flatbed", Description = "fa-dolly-flatbed", GroupName = "duotone light regular solid")]
        DollyFlatbed = '\uf474',
        
        /// <summary>
        ///     Donate ("fa-donate", \uf4b9) icon.
        /// </summary>
        /// 
        [Display(Name = "Donate", Description = "fa-donate", GroupName = "duotone light regular solid")]
        Donate = '\uf4b9',
        
        /// <summary>
        ///     Door Closed ("fa-door-closed", \uf52a) icon.
        /// </summary>
        /// 
        [Display(Name = "Door Closed", Description = "fa-door-closed", GroupName = "duotone light regular solid")]
        DoorClosed = '\uf52a',
        
        /// <summary>
        ///     Door Open ("fa-door-open", \uf52b) icon.
        /// </summary>
        /// 
        [Display(Name = "Door Open", Description = "fa-door-open", GroupName = "duotone light regular solid")]
        DoorOpen = '\uf52b',
        
        /// <summary>
        ///     Dot Circle ("fa-dot-circle", \uf192) icon.
        /// </summary>
        /// 
        [Display(Name = "Dot Circle", Description = "fa-dot-circle", GroupName = "duotone light regular solid")]
        DotCircle = '\uf192',
        
        /// <summary>
        ///     Dove ("fa-dove", \uf4ba) icon.
        /// </summary>
        /// 
        [Display(Name = "Dove", Description = "fa-dove", GroupName = "duotone light regular solid")]
        Dove = '\uf4ba',
        
        /// <summary>
        ///     Download ("fa-download", \uf019) icon.
        /// </summary>
        /// 
        [Display(Name = "Download", Description = "fa-download", GroupName = "duotone light regular solid")]
        Download = '\uf019',
        
        /// <summary>
        ///     Draft2digital ("fa-draft2digital", \uf396) icon.
        /// </summary>
        /// 
        [Display(Name = "Draft2digital", Description = "fa-draft2digital", GroupName = "brands")]
        Draft2digital = '\uf396',
        
        /// <summary>
        ///     Drafting Compass ("fa-drafting-compass", \uf568) icon.
        /// </summary>
        /// 
        [Display(Name = "Drafting Compass", Description = "fa-drafting-compass", GroupName = "duotone light regular solid")]
        DraftingCompass = '\uf568',
        
        /// <summary>
        ///     Dragon ("fa-dragon", \uf6d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Dragon", Description = "fa-dragon", GroupName = "duotone light regular solid")]
        Dragon = '\uf6d5',
        
        /// <summary>
        ///     Draw Polygon ("fa-draw-polygon", \uf5ee) icon.
        /// </summary>
        /// 
        [Display(Name = "Draw Polygon", Description = "fa-draw-polygon", GroupName = "duotone light regular solid")]
        DrawPolygon = '\uf5ee',
        
        /// <summary>
        ///     Dribbble ("fa-dribbble", \uf17d) icon.
        /// </summary>
        /// 
        [Display(Name = "Dribbble", Description = "fa-dribbble", GroupName = "brands")]
        Dribbble = '\uf17d',
        
        /// <summary>
        ///     Dribbble Square ("fa-dribbble-square", \uf397) icon.
        /// </summary>
        /// 
        [Display(Name = "Dribbble Square", Description = "fa-dribbble-square", GroupName = "brands")]
        DribbbleSquare = '\uf397',
        
        /// <summary>
        ///     Dropbox ("fa-dropbox", \uf16b) icon.
        /// </summary>
        /// 
        [Display(Name = "Dropbox", Description = "fa-dropbox", GroupName = "brands")]
        Dropbox = '\uf16b',
        
        /// <summary>
        ///     Drum ("fa-drum", \uf569) icon.
        /// </summary>
        /// 
        [Display(Name = "Drum", Description = "fa-drum", GroupName = "duotone light regular solid")]
        Drum = '\uf569',
        
        /// <summary>
        ///     Drum Steelpan ("fa-drum-steelpan", \uf56a) icon.
        /// </summary>
        /// 
        [Display(Name = "Drum Steelpan", Description = "fa-drum-steelpan", GroupName = "duotone light regular solid")]
        DrumSteelpan = '\uf56a',
        
        /// <summary>
        ///     Drumstick Bite ("fa-drumstick-bite", \uf6d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Drumstick Bite", Description = "fa-drumstick-bite", GroupName = "duotone light regular solid")]
        DrumstickBite = '\uf6d7',
        
        /// <summary>
        ///     Drupal ("fa-drupal", \uf1a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Drupal", Description = "fa-drupal", GroupName = "brands")]
        Drupal = '\uf1a9',
        
        /// <summary>
        ///     Dumbbell ("fa-dumbbell", \uf44b) icon.
        /// </summary>
        /// 
        [Display(Name = "Dumbbell", Description = "fa-dumbbell", GroupName = "duotone light regular solid")]
        Dumbbell = '\uf44b',
        
        /// <summary>
        ///     Dumpster ("fa-dumpster", \uf793) icon.
        /// </summary>
        /// 
        [Display(Name = "Dumpster", Description = "fa-dumpster", GroupName = "duotone light regular solid")]
        Dumpster = '\uf793',
        
        /// <summary>
        ///     Dumpster Fire ("fa-dumpster-fire", \uf794) icon.
        /// </summary>
        /// 
        [Display(Name = "Dumpster Fire", Description = "fa-dumpster-fire", GroupName = "duotone light regular solid")]
        DumpsterFire = '\uf794',
        
        /// <summary>
        ///     Dungeon ("fa-dungeon", \uf6d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Dungeon", Description = "fa-dungeon", GroupName = "duotone light regular solid")]
        Dungeon = '\uf6d9',
        
        /// <summary>
        ///     Dyalog ("fa-dyalog", \uf399) icon.
        /// </summary>
        /// 
        [Display(Name = "Dyalog", Description = "fa-dyalog", GroupName = "brands")]
        Dyalog = '\uf399',
        
        /// <summary>
        ///     Earlybirds ("fa-earlybirds", \uf39a) icon.
        /// </summary>
        /// 
        [Display(Name = "Earlybirds", Description = "fa-earlybirds", GroupName = "brands")]
        Earlybirds = '\uf39a',
        
        /// <summary>
        ///     Ebay ("fa-ebay", \uf4f4) icon.
        /// </summary>
        /// 
        [Display(Name = "Ebay", Description = "fa-ebay", GroupName = "brands")]
        Ebay = '\uf4f4',
        
        /// <summary>
        ///     Edge ("fa-edge", \uf282) icon.
        /// </summary>
        /// 
        [Display(Name = "Edge", Description = "fa-edge", GroupName = "brands")]
        Edge = '\uf282',
        
        /// <summary>
        ///     Edit ("fa-edit", \uf044) icon.
        /// </summary>
        /// 
        [Display(Name = "Edit", Description = "fa-edit", GroupName = "duotone light regular solid")]
        Edit = '\uf044',
        
        /// <summary>
        ///     Egg ("fa-egg", \uf7fb) icon.
        /// </summary>
        /// 
        [Display(Name = "Egg", Description = "fa-egg", GroupName = "duotone light regular solid")]
        Egg = '\uf7fb',
        
        /// <summary>
        ///     Eject ("fa-eject", \uf052) icon.
        /// </summary>
        /// 
        [Display(Name = "Eject", Description = "fa-eject", GroupName = "duotone light regular solid")]
        Eject = '\uf052',
        
        /// <summary>
        ///     Elementor ("fa-elementor", \uf430) icon.
        /// </summary>
        /// 
        [Display(Name = "Elementor", Description = "fa-elementor", GroupName = "brands")]
        Elementor = '\uf430',
        
        /// <summary>
        ///     Ellipsis H ("fa-ellipsis-h", \uf141) icon.
        /// </summary>
        /// 
        [Display(Name = "Ellipsis H", Description = "fa-ellipsis-h", GroupName = "duotone light regular solid")]
        EllipsisH = '\uf141',
        
        /// <summary>
        ///     Ellipsis V ("fa-ellipsis-v", \uf142) icon.
        /// </summary>
        /// 
        [Display(Name = "Ellipsis V", Description = "fa-ellipsis-v", GroupName = "duotone light regular solid")]
        EllipsisV = '\uf142',
        
        /// <summary>
        ///     Ello ("fa-ello", \uf5f1) icon.
        /// </summary>
        /// 
        [Display(Name = "Ello", Description = "fa-ello", GroupName = "brands")]
        Ello = '\uf5f1',
        
        /// <summary>
        ///     Ember ("fa-ember", \uf423) icon.
        /// </summary>
        /// 
        [Display(Name = "Ember", Description = "fa-ember", GroupName = "brands")]
        Ember = '\uf423',
        
        /// <summary>
        ///     Empire ("fa-empire", \uf1d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Empire", Description = "fa-empire", GroupName = "brands")]
        Empire = '\uf1d1',
        
        /// <summary>
        ///     Envelope ("fa-envelope", \uf0e0) icon.
        /// </summary>
        /// 
        [Display(Name = "Envelope", Description = "fa-envelope", GroupName = "duotone light regular solid")]
        Envelope = '\uf0e0',
        
        /// <summary>
        ///     Envelope Open ("fa-envelope-open", \uf2b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Envelope Open", Description = "fa-envelope-open", GroupName = "duotone light regular solid")]
        EnvelopeOpen = '\uf2b6',
        
        /// <summary>
        ///     Envelope Open Text ("fa-envelope-open-text", \uf658) icon.
        /// </summary>
        /// 
        [Display(Name = "Envelope Open Text", Description = "fa-envelope-open-text", GroupName = "duotone light regular solid")]
        EnvelopeOpenText = '\uf658',
        
        /// <summary>
        ///     Envelope Square ("fa-envelope-square", \uf199) icon.
        /// </summary>
        /// 
        [Display(Name = "Envelope Square", Description = "fa-envelope-square", GroupName = "duotone light regular solid")]
        EnvelopeSquare = '\uf199',
        
        /// <summary>
        ///     Envira ("fa-envira", \uf299) icon.
        /// </summary>
        /// 
        [Display(Name = "Envira", Description = "fa-envira", GroupName = "brands")]
        Envira = '\uf299',
        
        /// <summary>
        ///     Equals ("fa-equals", \uf52c) icon.
        /// </summary>
        /// 
        [Display(Name = "Equals", Description = "fa-equals", GroupName = "duotone light regular solid")]
        Equals = '\uf52c',
        
        /// <summary>
        ///     Eraser ("fa-eraser", \uf12d) icon.
        /// </summary>
        /// 
        [Display(Name = "Eraser", Description = "fa-eraser", GroupName = "duotone light regular solid")]
        Eraser = '\uf12d',
        
        /// <summary>
        ///     Erlang ("fa-erlang", \uf39d) icon.
        /// </summary>
        /// 
        [Display(Name = "Erlang", Description = "fa-erlang", GroupName = "brands")]
        Erlang = '\uf39d',
        
        /// <summary>
        ///     Ethereum ("fa-ethereum", \uf42e) icon.
        /// </summary>
        /// 
        [Display(Name = "Ethereum", Description = "fa-ethereum", GroupName = "brands")]
        Ethereum = '\uf42e',
        
        /// <summary>
        ///     Ethernet ("fa-ethernet", \uf796) icon.
        /// </summary>
        /// 
        [Display(Name = "Ethernet", Description = "fa-ethernet", GroupName = "duotone light regular solid")]
        Ethernet = '\uf796',
        
        /// <summary>
        ///     Etsy ("fa-etsy", \uf2d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Etsy", Description = "fa-etsy", GroupName = "brands")]
        Etsy = '\uf2d7',
        
        /// <summary>
        ///     Euro Sign ("fa-euro-sign", \uf153) icon.
        /// </summary>
        /// 
        [Display(Name = "Euro Sign", Description = "fa-euro-sign", GroupName = "duotone light regular solid")]
        EuroSign = '\uf153',
        
        /// <summary>
        ///     Evernote ("fa-evernote", \uf839) icon.
        /// </summary>
        /// 
        [Display(Name = "Evernote", Description = "fa-evernote", GroupName = "brands")]
        Evernote = '\uf839',
        
        /// <summary>
        ///     Exchange Alt ("fa-exchange-alt", \uf362) icon.
        /// </summary>
        /// 
        [Display(Name = "Exchange Alt", Description = "fa-exchange-alt", GroupName = "duotone light regular solid")]
        ExchangeAlt = '\uf362',
        
        /// <summary>
        ///     Exclamation ("fa-exclamation", \uf12a) icon.
        /// </summary>
        /// 
        [Display(Name = "Exclamation", Description = "fa-exclamation", GroupName = "duotone light regular solid")]
        Exclamation = '\uf12a',
        
        /// <summary>
        ///     Exclamation Circle ("fa-exclamation-circle", \uf06a) icon.
        /// </summary>
        /// 
        [Display(Name = "Exclamation Circle", Description = "fa-exclamation-circle", GroupName = "duotone light regular solid")]
        ExclamationCircle = '\uf06a',
        
        /// <summary>
        ///     Exclamation Triangle ("fa-exclamation-triangle", \uf071) icon.
        /// </summary>
        /// 
        [Display(Name = "Exclamation Triangle", Description = "fa-exclamation-triangle", GroupName = "duotone light regular solid")]
        ExclamationTriangle = '\uf071',
        
        /// <summary>
        ///     Expand ("fa-expand", \uf065) icon.
        /// </summary>
        /// 
        [Display(Name = "Expand", Description = "fa-expand", GroupName = "duotone light regular solid")]
        Expand = '\uf065',
        
        /// <summary>
        ///     Expand Alt ("fa-expand-alt", \uf424) icon.
        /// </summary>
        /// 
        [Display(Name = "Expand Alt", Description = "fa-expand-alt", GroupName = "duotone light regular solid")]
        ExpandAlt = '\uf424',
        
        /// <summary>
        ///     Expand Arrows Alt ("fa-expand-arrows-alt", \uf31e) icon.
        /// </summary>
        /// 
        [Display(Name = "Expand Arrows Alt", Description = "fa-expand-arrows-alt", GroupName = "duotone light regular solid")]
        ExpandArrowsAlt = '\uf31e',
        
        /// <summary>
        ///     Expeditedssl ("fa-expeditedssl", \uf23e) icon.
        /// </summary>
        /// 
        [Display(Name = "Expeditedssl", Description = "fa-expeditedssl", GroupName = "brands")]
        Expeditedssl = '\uf23e',
        
        /// <summary>
        ///     External Link Alt ("fa-external-link-alt", \uf35d) icon.
        /// </summary>
        /// 
        [Display(Name = "External Link Alt", Description = "fa-external-link-alt", GroupName = "duotone light regular solid")]
        ExternalLinkAlt = '\uf35d',
        
        /// <summary>
        ///     External Link Square Alt ("fa-external-link-square-alt", \uf360) icon.
        /// </summary>
        /// 
        [Display(Name = "External Link Square Alt", Description = "fa-external-link-square-alt", GroupName = "duotone light regular solid")]
        ExternalLinkSquareAlt = '\uf360',
        
        /// <summary>
        ///     Eye ("fa-eye", \uf06e) icon.
        /// </summary>
        /// 
        [Display(Name = "Eye", Description = "fa-eye", GroupName = "duotone light regular solid")]
        Eye = '\uf06e',
        
        /// <summary>
        ///     Eye Dropper ("fa-eye-dropper", \uf1fb) icon.
        /// </summary>
        /// 
        [Display(Name = "Eye Dropper", Description = "fa-eye-dropper", GroupName = "duotone light regular solid")]
        EyeDropper = '\uf1fb',
        
        /// <summary>
        ///     Eye Slash ("fa-eye-slash", \uf070) icon.
        /// </summary>
        /// 
        [Display(Name = "Eye Slash", Description = "fa-eye-slash", GroupName = "duotone light regular solid")]
        EyeSlash = '\uf070',
        
        /// <summary>
        ///     Facebook ("fa-facebook", \uf09a) icon.
        /// </summary>
        /// 
        [Display(Name = "Facebook", Description = "fa-facebook", GroupName = "brands")]
        Facebook = '\uf09a',
        
        /// <summary>
        ///     Facebook F ("fa-facebook-f", \uf39e) icon.
        /// </summary>
        /// 
        [Display(Name = "Facebook F", Description = "fa-facebook-f", GroupName = "brands")]
        FacebookF = '\uf39e',
        
        /// <summary>
        ///     Facebook Messenger ("fa-facebook-messenger", \uf39f) icon.
        /// </summary>
        /// 
        [Display(Name = "Facebook Messenger", Description = "fa-facebook-messenger", GroupName = "brands")]
        FacebookMessenger = '\uf39f',
        
        /// <summary>
        ///     Facebook Square ("fa-facebook-square", \uf082) icon.
        /// </summary>
        /// 
        [Display(Name = "Facebook Square", Description = "fa-facebook-square", GroupName = "brands")]
        FacebookSquare = '\uf082',
        
        /// <summary>
        ///     Fan ("fa-fan", \uf863) icon.
        /// </summary>
        /// 
        [Display(Name = "Fan", Description = "fa-fan", GroupName = "duotone light regular solid")]
        Fan = '\uf863',
        
        /// <summary>
        ///     Fantasy Flight Games ("fa-fantasy-flight-games", \uf6dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Fantasy Flight Games", Description = "fa-fantasy-flight-games", GroupName = "brands")]
        FantasyFlightGames = '\uf6dc',
        
        /// <summary>
        ///     Fast Backward ("fa-fast-backward", \uf049) icon.
        /// </summary>
        /// 
        [Display(Name = "Fast Backward", Description = "fa-fast-backward", GroupName = "duotone light regular solid")]
        FastBackward = '\uf049',
        
        /// <summary>
        ///     Fast Forward ("fa-fast-forward", \uf050) icon.
        /// </summary>
        /// 
        [Display(Name = "Fast Forward", Description = "fa-fast-forward", GroupName = "duotone light regular solid")]
        FastForward = '\uf050',
        
        /// <summary>
        ///     Faucet ("fa-faucet", \uf905) icon.
        /// </summary>
        /// 
        [Display(Name = "Faucet", Description = "fa-faucet", GroupName = "duotone light regular solid")]
        Faucet = '\uf905',
        
        /// <summary>
        ///     Fax ("fa-fax", \uf1ac) icon.
        /// </summary>
        /// 
        [Display(Name = "Fax", Description = "fa-fax", GroupName = "duotone light regular solid")]
        Fax = '\uf1ac',
        
        /// <summary>
        ///     Feather ("fa-feather", \uf52d) icon.
        /// </summary>
        /// 
        [Display(Name = "Feather", Description = "fa-feather", GroupName = "duotone light regular solid")]
        Feather = '\uf52d',
        
        /// <summary>
        ///     Feather Alt ("fa-feather-alt", \uf56b) icon.
        /// </summary>
        /// 
        [Display(Name = "Feather Alt", Description = "fa-feather-alt", GroupName = "duotone light regular solid")]
        FeatherAlt = '\uf56b',
        
        /// <summary>
        ///     Fedex ("fa-fedex", \uf797) icon.
        /// </summary>
        /// 
        [Display(Name = "Fedex", Description = "fa-fedex", GroupName = "brands")]
        Fedex = '\uf797',
        
        /// <summary>
        ///     Fedora ("fa-fedora", \uf798) icon.
        /// </summary>
        /// 
        [Display(Name = "Fedora", Description = "fa-fedora", GroupName = "brands")]
        Fedora = '\uf798',
        
        /// <summary>
        ///     Female ("fa-female", \uf182) icon.
        /// </summary>
        /// 
        [Display(Name = "Female", Description = "fa-female", GroupName = "duotone light regular solid")]
        Female = '\uf182',
        
        /// <summary>
        ///     Fighter Jet ("fa-fighter-jet", \uf0fb) icon.
        /// </summary>
        /// 
        [Display(Name = "Fighter Jet", Description = "fa-fighter-jet", GroupName = "duotone light regular solid")]
        FighterJet = '\uf0fb',
        
        /// <summary>
        ///     Figma ("fa-figma", \uf799) icon.
        /// </summary>
        /// 
        [Display(Name = "Figma", Description = "fa-figma", GroupName = "brands")]
        Figma = '\uf799',
        
        /// <summary>
        ///     File ("fa-file", \uf15b) icon.
        /// </summary>
        /// 
        [Display(Name = "File", Description = "fa-file", GroupName = "duotone light regular solid")]
        File = '\uf15b',
        
        /// <summary>
        ///     File Alt ("fa-file-alt", \uf15c) icon.
        /// </summary>
        /// 
        [Display(Name = "File Alt", Description = "fa-file-alt", GroupName = "duotone light regular solid")]
        FileAlt = '\uf15c',
        
        /// <summary>
        ///     File Archive ("fa-file-archive", \uf1c6) icon.
        /// </summary>
        /// 
        [Display(Name = "File Archive", Description = "fa-file-archive", GroupName = "duotone light regular solid")]
        FileArchive = '\uf1c6',
        
        /// <summary>
        ///     File Audio ("fa-file-audio", \uf1c7) icon.
        /// </summary>
        /// 
        [Display(Name = "File Audio", Description = "fa-file-audio", GroupName = "duotone light regular solid")]
        FileAudio = '\uf1c7',
        
        /// <summary>
        ///     File Code ("fa-file-code", \uf1c9) icon.
        /// </summary>
        /// 
        [Display(Name = "File Code", Description = "fa-file-code", GroupName = "duotone light regular solid")]
        FileCode = '\uf1c9',
        
        /// <summary>
        ///     File Contract ("fa-file-contract", \uf56c) icon.
        /// </summary>
        /// 
        [Display(Name = "File Contract", Description = "fa-file-contract", GroupName = "duotone light regular solid")]
        FileContract = '\uf56c',
        
        /// <summary>
        ///     File Csv ("fa-file-csv", \uf6dd) icon.
        /// </summary>
        /// 
        [Display(Name = "File Csv", Description = "fa-file-csv", GroupName = "duotone light regular solid")]
        FileCsv = '\uf6dd',
        
        /// <summary>
        ///     File Download ("fa-file-download", \uf56d) icon.
        /// </summary>
        /// 
        [Display(Name = "File Download", Description = "fa-file-download", GroupName = "duotone light regular solid")]
        FileDownload = '\uf56d',
        
        /// <summary>
        ///     File Excel ("fa-file-excel", \uf1c3) icon.
        /// </summary>
        /// 
        [Display(Name = "File Excel", Description = "fa-file-excel", GroupName = "duotone light regular solid")]
        FileExcel = '\uf1c3',
        
        /// <summary>
        ///     File Export ("fa-file-export", \uf56e) icon.
        /// </summary>
        /// 
        [Display(Name = "File Export", Description = "fa-file-export", GroupName = "duotone light regular solid")]
        FileExport = '\uf56e',
        
        /// <summary>
        ///     File Image ("fa-file-image", \uf1c5) icon.
        /// </summary>
        /// 
        [Display(Name = "File Image", Description = "fa-file-image", GroupName = "duotone light regular solid")]
        FileImage = '\uf1c5',
        
        /// <summary>
        ///     File Import ("fa-file-import", \uf56f) icon.
        /// </summary>
        /// 
        [Display(Name = "File Import", Description = "fa-file-import", GroupName = "duotone light regular solid")]
        FileImport = '\uf56f',
        
        /// <summary>
        ///     File Invoice ("fa-file-invoice", \uf570) icon.
        /// </summary>
        /// 
        [Display(Name = "File Invoice", Description = "fa-file-invoice", GroupName = "duotone light regular solid")]
        FileInvoice = '\uf570',
        
        /// <summary>
        ///     File Invoice Dollar ("fa-file-invoice-dollar", \uf571) icon.
        /// </summary>
        /// 
        [Display(Name = "File Invoice Dollar", Description = "fa-file-invoice-dollar", GroupName = "duotone light regular solid")]
        FileInvoiceDollar = '\uf571',
        
        /// <summary>
        ///     File Medical ("fa-file-medical", \uf477) icon.
        /// </summary>
        /// 
        [Display(Name = "File Medical", Description = "fa-file-medical", GroupName = "duotone light regular solid")]
        FileMedical = '\uf477',
        
        /// <summary>
        ///     File Medical Alt ("fa-file-medical-alt", \uf478) icon.
        /// </summary>
        /// 
        [Display(Name = "File Medical Alt", Description = "fa-file-medical-alt", GroupName = "duotone light regular solid")]
        FileMedicalAlt = '\uf478',
        
        /// <summary>
        ///     File Pdf ("fa-file-pdf", \uf1c1) icon.
        /// </summary>
        /// 
        [Display(Name = "File Pdf", Description = "fa-file-pdf", GroupName = "duotone light regular solid")]
        FilePdf = '\uf1c1',
        
        /// <summary>
        ///     File Powerpoint ("fa-file-powerpoint", \uf1c4) icon.
        /// </summary>
        /// 
        [Display(Name = "File Powerpoint", Description = "fa-file-powerpoint", GroupName = "duotone light regular solid")]
        FilePowerpoint = '\uf1c4',
        
        /// <summary>
        ///     File Prescription ("fa-file-prescription", \uf572) icon.
        /// </summary>
        /// 
        [Display(Name = "File Prescription", Description = "fa-file-prescription", GroupName = "duotone light regular solid")]
        FilePrescription = '\uf572',
        
        /// <summary>
        ///     File Signature ("fa-file-signature", \uf573) icon.
        /// </summary>
        /// 
        [Display(Name = "File Signature", Description = "fa-file-signature", GroupName = "duotone light regular solid")]
        FileSignature = '\uf573',
        
        /// <summary>
        ///     File Upload ("fa-file-upload", \uf574) icon.
        /// </summary>
        /// 
        [Display(Name = "File Upload", Description = "fa-file-upload", GroupName = "duotone light regular solid")]
        FileUpload = '\uf574',
        
        /// <summary>
        ///     File Video ("fa-file-video", \uf1c8) icon.
        /// </summary>
        /// 
        [Display(Name = "File Video", Description = "fa-file-video", GroupName = "duotone light regular solid")]
        FileVideo = '\uf1c8',
        
        /// <summary>
        ///     File Word ("fa-file-word", \uf1c2) icon.
        /// </summary>
        /// 
        [Display(Name = "File Word", Description = "fa-file-word", GroupName = "duotone light regular solid")]
        FileWord = '\uf1c2',
        
        /// <summary>
        ///     Fill ("fa-fill", \uf575) icon.
        /// </summary>
        /// 
        [Display(Name = "Fill", Description = "fa-fill", GroupName = "duotone light regular solid")]
        Fill = '\uf575',
        
        /// <summary>
        ///     Fill Drip ("fa-fill-drip", \uf576) icon.
        /// </summary>
        /// 
        [Display(Name = "Fill Drip", Description = "fa-fill-drip", GroupName = "duotone light regular solid")]
        FillDrip = '\uf576',
        
        /// <summary>
        ///     Film ("fa-film", \uf008) icon.
        /// </summary>
        /// 
        [Display(Name = "Film", Description = "fa-film", GroupName = "duotone light regular solid")]
        Film = '\uf008',
        
        /// <summary>
        ///     Filter ("fa-filter", \uf0b0) icon.
        /// </summary>
        /// 
        [Display(Name = "Filter", Description = "fa-filter", GroupName = "duotone light regular solid")]
        Filter = '\uf0b0',
        
        /// <summary>
        ///     Fingerprint ("fa-fingerprint", \uf577) icon.
        /// </summary>
        /// 
        [Display(Name = "Fingerprint", Description = "fa-fingerprint", GroupName = "duotone light regular solid")]
        Fingerprint = '\uf577',
        
        /// <summary>
        ///     Fire ("fa-fire", \uf06d) icon.
        /// </summary>
        /// 
        [Display(Name = "Fire", Description = "fa-fire", GroupName = "duotone light regular solid")]
        Fire = '\uf06d',
        
        /// <summary>
        ///     Fire Alt ("fa-fire-alt", \uf7e4) icon.
        /// </summary>
        /// 
        [Display(Name = "Fire Alt", Description = "fa-fire-alt", GroupName = "duotone light regular solid")]
        FireAlt = '\uf7e4',
        
        /// <summary>
        ///     Fire Extinguisher ("fa-fire-extinguisher", \uf134) icon.
        /// </summary>
        /// 
        [Display(Name = "Fire Extinguisher", Description = "fa-fire-extinguisher", GroupName = "duotone light regular solid")]
        FireExtinguisher = '\uf134',
        
        /// <summary>
        ///     Firefox ("fa-firefox", \uf269) icon.
        /// </summary>
        /// 
        [Display(Name = "Firefox", Description = "fa-firefox", GroupName = "brands")]
        Firefox = '\uf269',
        
        /// <summary>
        ///     Firefox Browser ("fa-firefox-browser", \uf907) icon.
        /// </summary>
        /// 
        [Display(Name = "Firefox Browser", Description = "fa-firefox-browser", GroupName = "brands")]
        FirefoxBrowser = '\uf907',
        
        /// <summary>
        ///     First Aid ("fa-first-aid", \uf479) icon.
        /// </summary>
        /// 
        [Display(Name = "First Aid", Description = "fa-first-aid", GroupName = "duotone light regular solid")]
        FirstAid = '\uf479',
        
        /// <summary>
        ///     Firstdraft ("fa-firstdraft", \uf3a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Firstdraft", Description = "fa-firstdraft", GroupName = "brands")]
        Firstdraft = '\uf3a1',
        
        /// <summary>
        ///     First Order ("fa-first-order", \uf2b0) icon.
        /// </summary>
        /// 
        [Display(Name = "First Order", Description = "fa-first-order", GroupName = "brands")]
        FirstOrder = '\uf2b0',
        
        /// <summary>
        ///     First Order Alt ("fa-first-order-alt", \uf50a) icon.
        /// </summary>
        /// 
        [Display(Name = "First Order Alt", Description = "fa-first-order-alt", GroupName = "brands")]
        FirstOrderAlt = '\uf50a',
        
        /// <summary>
        ///     Fish ("fa-fish", \uf578) icon.
        /// </summary>
        /// 
        [Display(Name = "Fish", Description = "fa-fish", GroupName = "duotone light regular solid")]
        Fish = '\uf578',
        
        /// <summary>
        ///     Fist Raised ("fa-fist-raised", \uf6de) icon.
        /// </summary>
        /// 
        [Display(Name = "Fist Raised", Description = "fa-fist-raised", GroupName = "duotone light regular solid")]
        FistRaised = '\uf6de',
        
        /// <summary>
        ///     Flag ("fa-flag", \uf024) icon.
        /// </summary>
        /// 
        [Display(Name = "Flag", Description = "fa-flag", GroupName = "duotone light regular solid")]
        Flag = '\uf024',
        
        /// <summary>
        ///     Flag Checkered ("fa-flag-checkered", \uf11e) icon.
        /// </summary>
        /// 
        [Display(Name = "Flag Checkered", Description = "fa-flag-checkered", GroupName = "duotone light regular solid")]
        FlagCheckered = '\uf11e',
        
        /// <summary>
        ///     Flag Usa ("fa-flag-usa", \uf74d) icon.
        /// </summary>
        /// 
        [Display(Name = "Flag Usa", Description = "fa-flag-usa", GroupName = "duotone light regular solid")]
        FlagUsa = '\uf74d',
        
        /// <summary>
        ///     Flask ("fa-flask", \uf0c3) icon.
        /// </summary>
        /// 
        [Display(Name = "Flask", Description = "fa-flask", GroupName = "duotone light regular solid")]
        Flask = '\uf0c3',
        
        /// <summary>
        ///     Flickr ("fa-flickr", \uf16e) icon.
        /// </summary>
        /// 
        [Display(Name = "Flickr", Description = "fa-flickr", GroupName = "brands")]
        Flickr = '\uf16e',
        
        /// <summary>
        ///     Flipboard ("fa-flipboard", \uf44d) icon.
        /// </summary>
        /// 
        [Display(Name = "Flipboard", Description = "fa-flipboard", GroupName = "brands")]
        Flipboard = '\uf44d',
        
        /// <summary>
        ///     Flushed ("fa-flushed", \uf579) icon.
        /// </summary>
        /// 
        [Display(Name = "Flushed", Description = "fa-flushed", GroupName = "duotone light regular solid")]
        Flushed = '\uf579',
        
        /// <summary>
        ///     Fly ("fa-fly", \uf417) icon.
        /// </summary>
        /// 
        [Display(Name = "Fly", Description = "fa-fly", GroupName = "brands")]
        Fly = '\uf417',
        
        /// <summary>
        ///     Folder ("fa-folder", \uf07b) icon.
        /// </summary>
        /// 
        [Display(Name = "Folder", Description = "fa-folder", GroupName = "duotone light regular solid")]
        Folder = '\uf07b',
        
        /// <summary>
        ///     Folder Minus ("fa-folder-minus", \uf65d) icon.
        /// </summary>
        /// 
        [Display(Name = "Folder Minus", Description = "fa-folder-minus", GroupName = "duotone light regular solid")]
        FolderMinus = '\uf65d',
        
        /// <summary>
        ///     Folder Open ("fa-folder-open", \uf07c) icon.
        /// </summary>
        /// 
        [Display(Name = "Folder Open", Description = "fa-folder-open", GroupName = "duotone light regular solid")]
        FolderOpen = '\uf07c',
        
        /// <summary>
        ///     Folder Plus ("fa-folder-plus", \uf65e) icon.
        /// </summary>
        /// 
        [Display(Name = "Folder Plus", Description = "fa-folder-plus", GroupName = "duotone light regular solid")]
        FolderPlus = '\uf65e',
        
        /// <summary>
        ///     Font ("fa-font", \uf031) icon.
        /// </summary>
        /// 
        [Display(Name = "Font", Description = "fa-font", GroupName = "duotone light regular solid")]
        Font = '\uf031',
        
        /// <summary>
        ///     Font Awesome ("fa-font-awesome", \uf2b4) icon.
        /// </summary>
        /// 
        [Display(Name = "Font Awesome", Description = "fa-font-awesome", GroupName = "brands")]
        FontAwesome = '\uf2b4',
        
        /// <summary>
        ///     Font Awesome Alt ("fa-font-awesome-alt", \uf35c) icon.
        /// </summary>
        /// 
        [Display(Name = "Font Awesome Alt", Description = "fa-font-awesome-alt", GroupName = "brands")]
        FontAwesomeAlt = '\uf35c',
        
        /// <summary>
        ///     Font Awesome Flag ("fa-font-awesome-flag", \uf425) icon.
        /// </summary>
        /// 
        [Display(Name = "Font Awesome Flag", Description = "fa-font-awesome-flag", GroupName = "brands")]
        FontAwesomeFlag = '\uf425',
        
        /// <summary>
        ///     Font Awesome Logo Full ("fa-font-awesome-logo-full", \uf4e6) icon.
        /// </summary>
        /// 
        [Display(Name = "Font Awesome Logo Full", Description = "fa-font-awesome-logo-full")]
        FontAwesomeLogoFull = '\uf4e6',
        
        /// <summary>
        ///     Fonticons ("fa-fonticons", \uf280) icon.
        /// </summary>
        /// 
        [Display(Name = "Fonticons", Description = "fa-fonticons", GroupName = "brands")]
        Fonticons = '\uf280',
        
        /// <summary>
        ///     Fonticons Fi ("fa-fonticons-fi", \uf3a2) icon.
        /// </summary>
        /// 
        [Display(Name = "Fonticons Fi", Description = "fa-fonticons-fi", GroupName = "brands")]
        FonticonsFi = '\uf3a2',
        
        /// <summary>
        ///     Football Ball ("fa-football-ball", \uf44e) icon.
        /// </summary>
        /// 
        [Display(Name = "Football Ball", Description = "fa-football-ball", GroupName = "duotone light regular solid")]
        FootballBall = '\uf44e',
        
        /// <summary>
        ///     Fort Awesome ("fa-fort-awesome", \uf286) icon.
        /// </summary>
        /// 
        [Display(Name = "Fort Awesome", Description = "fa-fort-awesome", GroupName = "brands")]
        FortAwesome = '\uf286',
        
        /// <summary>
        ///     Fort Awesome Alt ("fa-fort-awesome-alt", \uf3a3) icon.
        /// </summary>
        /// 
        [Display(Name = "Fort Awesome Alt", Description = "fa-fort-awesome-alt", GroupName = "brands")]
        FortAwesomeAlt = '\uf3a3',
        
        /// <summary>
        ///     Forumbee ("fa-forumbee", \uf211) icon.
        /// </summary>
        /// 
        [Display(Name = "Forumbee", Description = "fa-forumbee", GroupName = "brands")]
        Forumbee = '\uf211',
        
        /// <summary>
        ///     Forward ("fa-forward", \uf04e) icon.
        /// </summary>
        /// 
        [Display(Name = "Forward", Description = "fa-forward", GroupName = "duotone light regular solid")]
        Forward = '\uf04e',
        
        /// <summary>
        ///     Foursquare ("fa-foursquare", \uf180) icon.
        /// </summary>
        /// 
        [Display(Name = "Foursquare", Description = "fa-foursquare", GroupName = "brands")]
        Foursquare = '\uf180',
        
        /// <summary>
        ///     Freebsd ("fa-freebsd", \uf3a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Freebsd", Description = "fa-freebsd", GroupName = "brands")]
        Freebsd = '\uf3a4',
        
        /// <summary>
        ///     Free Code Camp ("fa-free-code-camp", \uf2c5) icon.
        /// </summary>
        /// 
        [Display(Name = "Free Code Camp", Description = "fa-free-code-camp", GroupName = "brands")]
        FreeCodeCamp = '\uf2c5',
        
        /// <summary>
        ///     Frog ("fa-frog", \uf52e) icon.
        /// </summary>
        /// 
        [Display(Name = "Frog", Description = "fa-frog", GroupName = "duotone light regular solid")]
        Frog = '\uf52e',
        
        /// <summary>
        ///     Frown ("fa-frown", \uf119) icon.
        /// </summary>
        /// 
        [Display(Name = "Frown", Description = "fa-frown", GroupName = "duotone light regular solid")]
        Frown = '\uf119',
        
        /// <summary>
        ///     Frown Open ("fa-frown-open", \uf57a) icon.
        /// </summary>
        /// 
        [Display(Name = "Frown Open", Description = "fa-frown-open", GroupName = "duotone light regular solid")]
        FrownOpen = '\uf57a',
        
        /// <summary>
        ///     Fulcrum ("fa-fulcrum", \uf50b) icon.
        /// </summary>
        /// 
        [Display(Name = "Fulcrum", Description = "fa-fulcrum", GroupName = "brands")]
        Fulcrum = '\uf50b',
        
        /// <summary>
        ///     Funnel Dollar ("fa-funnel-dollar", \uf662) icon.
        /// </summary>
        /// 
        [Display(Name = "Funnel Dollar", Description = "fa-funnel-dollar", GroupName = "duotone light regular solid")]
        FunnelDollar = '\uf662',
        
        /// <summary>
        ///     Futbol ("fa-futbol", \uf1e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Futbol", Description = "fa-futbol", GroupName = "duotone light regular solid")]
        Futbol = '\uf1e3',
        
        /// <summary>
        ///     Galactic Republic ("fa-galactic-republic", \uf50c) icon.
        /// </summary>
        /// 
        [Display(Name = "Galactic Republic", Description = "fa-galactic-republic", GroupName = "brands")]
        GalacticRepublic = '\uf50c',
        
        /// <summary>
        ///     Galactic Senate ("fa-galactic-senate", \uf50d) icon.
        /// </summary>
        /// 
        [Display(Name = "Galactic Senate", Description = "fa-galactic-senate", GroupName = "brands")]
        GalacticSenate = '\uf50d',
        
        /// <summary>
        ///     Gamepad ("fa-gamepad", \uf11b) icon.
        /// </summary>
        /// 
        [Display(Name = "Gamepad", Description = "fa-gamepad", GroupName = "duotone light regular solid")]
        Gamepad = '\uf11b',
        
        /// <summary>
        ///     Gas Pump ("fa-gas-pump", \uf52f) icon.
        /// </summary>
        /// 
        [Display(Name = "Gas Pump", Description = "fa-gas-pump", GroupName = "duotone light regular solid")]
        GasPump = '\uf52f',
        
        /// <summary>
        ///     Gavel ("fa-gavel", \uf0e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Gavel", Description = "fa-gavel", GroupName = "duotone light regular solid")]
        Gavel = '\uf0e3',
        
        /// <summary>
        ///     Gem ("fa-gem", \uf3a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Gem", Description = "fa-gem", GroupName = "duotone light regular solid")]
        Gem = '\uf3a5',
        
        /// <summary>
        ///     Genderless ("fa-genderless", \uf22d) icon.
        /// </summary>
        /// 
        [Display(Name = "Genderless", Description = "fa-genderless", GroupName = "duotone light regular solid")]
        Genderless = '\uf22d',
        
        /// <summary>
        ///     Get Pocket ("fa-get-pocket", \uf265) icon.
        /// </summary>
        /// 
        [Display(Name = "Get Pocket", Description = "fa-get-pocket", GroupName = "brands")]
        GetPocket = '\uf265',
        
        /// <summary>
        ///     Gg ("fa-gg", \uf260) icon.
        /// </summary>
        /// 
        [Display(Name = "Gg", Description = "fa-gg", GroupName = "brands")]
        Gg = '\uf260',
        
        /// <summary>
        ///     Gg Circle ("fa-gg-circle", \uf261) icon.
        /// </summary>
        /// 
        [Display(Name = "Gg Circle", Description = "fa-gg-circle", GroupName = "brands")]
        GgCircle = '\uf261',
        
        /// <summary>
        ///     Ghost ("fa-ghost", \uf6e2) icon.
        /// </summary>
        /// 
        [Display(Name = "Ghost", Description = "fa-ghost", GroupName = "duotone light regular solid")]
        Ghost = '\uf6e2',
        
        /// <summary>
        ///     Gift ("fa-gift", \uf06b) icon.
        /// </summary>
        /// 
        [Display(Name = "Gift", Description = "fa-gift", GroupName = "duotone light regular solid")]
        Gift = '\uf06b',
        
        /// <summary>
        ///     Gifts ("fa-gifts", \uf79c) icon.
        /// </summary>
        /// 
        [Display(Name = "Gifts", Description = "fa-gifts", GroupName = "duotone light regular solid")]
        Gifts = '\uf79c',
        
        /// <summary>
        ///     Git ("fa-git", \uf1d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Git", Description = "fa-git", GroupName = "brands")]
        Git = '\uf1d3',
        
        /// <summary>
        ///     Git Alt ("fa-git-alt", \uf841) icon.
        /// </summary>
        /// 
        [Display(Name = "Git Alt", Description = "fa-git-alt", GroupName = "brands")]
        GitAlt = '\uf841',
        
        /// <summary>
        ///     Github ("fa-github", \uf09b) icon.
        /// </summary>
        /// 
        [Display(Name = "Github", Description = "fa-github", GroupName = "brands")]
        Github = '\uf09b',
        
        /// <summary>
        ///     Github Alt ("fa-github-alt", \uf113) icon.
        /// </summary>
        /// 
        [Display(Name = "Github Alt", Description = "fa-github-alt", GroupName = "brands")]
        GithubAlt = '\uf113',
        
        /// <summary>
        ///     Github Square ("fa-github-square", \uf092) icon.
        /// </summary>
        /// 
        [Display(Name = "Github Square", Description = "fa-github-square", GroupName = "brands")]
        GithubSquare = '\uf092',
        
        /// <summary>
        ///     Gitkraken ("fa-gitkraken", \uf3a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Gitkraken", Description = "fa-gitkraken", GroupName = "brands")]
        Gitkraken = '\uf3a6',
        
        /// <summary>
        ///     Gitlab ("fa-gitlab", \uf296) icon.
        /// </summary>
        /// 
        [Display(Name = "Gitlab", Description = "fa-gitlab", GroupName = "brands")]
        Gitlab = '\uf296',
        
        /// <summary>
        ///     Git Square ("fa-git-square", \uf1d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Git Square", Description = "fa-git-square", GroupName = "brands")]
        GitSquare = '\uf1d2',
        
        /// <summary>
        ///     Gitter ("fa-gitter", \uf426) icon.
        /// </summary>
        /// 
        [Display(Name = "Gitter", Description = "fa-gitter", GroupName = "brands")]
        Gitter = '\uf426',
        
        /// <summary>
        ///     Glass Cheers ("fa-glass-cheers", \uf79f) icon.
        /// </summary>
        /// 
        [Display(Name = "Glass Cheers", Description = "fa-glass-cheers", GroupName = "duotone light regular solid")]
        GlassCheers = '\uf79f',
        
        /// <summary>
        ///     Glasses ("fa-glasses", \uf530) icon.
        /// </summary>
        /// 
        [Display(Name = "Glasses", Description = "fa-glasses", GroupName = "duotone light regular solid")]
        Glasses = '\uf530',
        
        /// <summary>
        ///     Glass Martini ("fa-glass-martini", \uf000) icon.
        /// </summary>
        /// 
        [Display(Name = "Glass Martini", Description = "fa-glass-martini", GroupName = "duotone light regular solid")]
        GlassMartini = '\uf000',
        
        /// <summary>
        ///     Glass Martini Alt ("fa-glass-martini-alt", \uf57b) icon.
        /// </summary>
        /// 
        [Display(Name = "Glass Martini Alt", Description = "fa-glass-martini-alt", GroupName = "duotone light regular solid")]
        GlassMartiniAlt = '\uf57b',
        
        /// <summary>
        ///     Glass Whiskey ("fa-glass-whiskey", \uf7a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Glass Whiskey", Description = "fa-glass-whiskey", GroupName = "duotone light regular solid")]
        GlassWhiskey = '\uf7a0',
        
        /// <summary>
        ///     Glide ("fa-glide", \uf2a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Glide", Description = "fa-glide", GroupName = "brands")]
        Glide = '\uf2a5',
        
        /// <summary>
        ///     Glide G ("fa-glide-g", \uf2a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Glide G", Description = "fa-glide-g", GroupName = "brands")]
        GlideG = '\uf2a6',
        
        /// <summary>
        ///     Globe ("fa-globe", \uf0ac) icon.
        /// </summary>
        /// 
        [Display(Name = "Globe", Description = "fa-globe", GroupName = "duotone light regular solid")]
        Globe = '\uf0ac',
        
        /// <summary>
        ///     Globe Africa ("fa-globe-africa", \uf57c) icon.
        /// </summary>
        /// 
        [Display(Name = "Globe Africa", Description = "fa-globe-africa", GroupName = "duotone light regular solid")]
        GlobeAfrica = '\uf57c',
        
        /// <summary>
        ///     Globe Americas ("fa-globe-americas", \uf57d) icon.
        /// </summary>
        /// 
        [Display(Name = "Globe Americas", Description = "fa-globe-americas", GroupName = "duotone light regular solid")]
        GlobeAmericas = '\uf57d',
        
        /// <summary>
        ///     Globe Asia ("fa-globe-asia", \uf57e) icon.
        /// </summary>
        /// 
        [Display(Name = "Globe Asia", Description = "fa-globe-asia", GroupName = "duotone light regular solid")]
        GlobeAsia = '\uf57e',
        
        /// <summary>
        ///     Globe Europe ("fa-globe-europe", \uf7a2) icon.
        /// </summary>
        /// 
        [Display(Name = "Globe Europe", Description = "fa-globe-europe", GroupName = "duotone light regular solid")]
        GlobeEurope = '\uf7a2',
        
        /// <summary>
        ///     Gofore ("fa-gofore", \uf3a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Gofore", Description = "fa-gofore", GroupName = "brands")]
        Gofore = '\uf3a7',
        
        /// <summary>
        ///     Golf Ball ("fa-golf-ball", \uf450) icon.
        /// </summary>
        /// 
        [Display(Name = "Golf Ball", Description = "fa-golf-ball", GroupName = "duotone light regular solid")]
        GolfBall = '\uf450',
        
        /// <summary>
        ///     Goodreads ("fa-goodreads", \uf3a8) icon.
        /// </summary>
        /// 
        [Display(Name = "Goodreads", Description = "fa-goodreads", GroupName = "brands")]
        Goodreads = '\uf3a8',
        
        /// <summary>
        ///     Goodreads G ("fa-goodreads-g", \uf3a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Goodreads G", Description = "fa-goodreads-g", GroupName = "brands")]
        GoodreadsG = '\uf3a9',
        
        /// <summary>
        ///     Google ("fa-google", \uf1a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Google", Description = "fa-google", GroupName = "brands")]
        Google = '\uf1a0',
        
        /// <summary>
        ///     Google Drive ("fa-google-drive", \uf3aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Drive", Description = "fa-google-drive", GroupName = "brands")]
        GoogleDrive = '\uf3aa',
        
        /// <summary>
        ///     Google Play ("fa-google-play", \uf3ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Play", Description = "fa-google-play", GroupName = "brands")]
        GooglePlay = '\uf3ab',
        
        /// <summary>
        ///     Google Plus ("fa-google-plus", \uf2b3) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Plus", Description = "fa-google-plus", GroupName = "brands")]
        GooglePlus = '\uf2b3',
        
        /// <summary>
        ///     Google Plus G ("fa-google-plus-g", \uf0d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Plus G", Description = "fa-google-plus-g", GroupName = "brands")]
        GooglePlusG = '\uf0d5',
        
        /// <summary>
        ///     Google Plus Square ("fa-google-plus-square", \uf0d4) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Plus Square", Description = "fa-google-plus-square", GroupName = "brands")]
        GooglePlusSquare = '\uf0d4',
        
        /// <summary>
        ///     Google Wallet ("fa-google-wallet", \uf1ee) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Wallet", Description = "fa-google-wallet", GroupName = "brands")]
        GoogleWallet = '\uf1ee',
        
        /// <summary>
        ///     Gopuram ("fa-gopuram", \uf664) icon.
        /// </summary>
        /// 
        [Display(Name = "Gopuram", Description = "fa-gopuram", GroupName = "duotone light regular solid")]
        Gopuram = '\uf664',
        
        /// <summary>
        ///     Graduation Cap ("fa-graduation-cap", \uf19d) icon.
        /// </summary>
        /// 
        [Display(Name = "Graduation Cap", Description = "fa-graduation-cap", GroupName = "duotone light regular solid")]
        GraduationCap = '\uf19d',
        
        /// <summary>
        ///     Gratipay ("fa-gratipay", \uf184) icon.
        /// </summary>
        /// 
        [Display(Name = "Gratipay", Description = "fa-gratipay", GroupName = "brands")]
        Gratipay = '\uf184',
        
        /// <summary>
        ///     Grav ("fa-grav", \uf2d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Grav", Description = "fa-grav", GroupName = "brands")]
        Grav = '\uf2d6',
        
        /// <summary>
        ///     Greater Than ("fa-greater-than", \uf531) icon.
        /// </summary>
        /// 
        [Display(Name = "Greater Than", Description = "fa-greater-than", GroupName = "duotone light regular solid")]
        GreaterThan = '\uf531',
        
        /// <summary>
        ///     Greater Than Equal ("fa-greater-than-equal", \uf532) icon.
        /// </summary>
        /// 
        [Display(Name = "Greater Than Equal", Description = "fa-greater-than-equal", GroupName = "duotone light regular solid")]
        GreaterThanEqual = '\uf532',
        
        /// <summary>
        ///     Grimace ("fa-grimace", \uf57f) icon.
        /// </summary>
        /// 
        [Display(Name = "Grimace", Description = "fa-grimace", GroupName = "duotone light regular solid")]
        Grimace = '\uf57f',
        
        /// <summary>
        ///     Grin ("fa-grin", \uf580) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin", Description = "fa-grin", GroupName = "duotone light regular solid")]
        Grin = '\uf580',
        
        /// <summary>
        ///     Grin Alt ("fa-grin-alt", \uf581) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Alt", Description = "fa-grin-alt", GroupName = "duotone light regular solid")]
        GrinAlt = '\uf581',
        
        /// <summary>
        ///     Grin Beam ("fa-grin-beam", \uf582) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Beam", Description = "fa-grin-beam", GroupName = "duotone light regular solid")]
        GrinBeam = '\uf582',
        
        /// <summary>
        ///     Grin Beam Sweat ("fa-grin-beam-sweat", \uf583) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Beam Sweat", Description = "fa-grin-beam-sweat", GroupName = "duotone light regular solid")]
        GrinBeamSweat = '\uf583',
        
        /// <summary>
        ///     Grin Hearts ("fa-grin-hearts", \uf584) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Hearts", Description = "fa-grin-hearts", GroupName = "duotone light regular solid")]
        GrinHearts = '\uf584',
        
        /// <summary>
        ///     Grin Squint ("fa-grin-squint", \uf585) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Squint", Description = "fa-grin-squint", GroupName = "duotone light regular solid")]
        GrinSquint = '\uf585',
        
        /// <summary>
        ///     Grin Squint Tears ("fa-grin-squint-tears", \uf586) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Squint Tears", Description = "fa-grin-squint-tears", GroupName = "duotone light regular solid")]
        GrinSquintTears = '\uf586',
        
        /// <summary>
        ///     Grin Stars ("fa-grin-stars", \uf587) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Stars", Description = "fa-grin-stars", GroupName = "duotone light regular solid")]
        GrinStars = '\uf587',
        
        /// <summary>
        ///     Grin Tears ("fa-grin-tears", \uf588) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Tears", Description = "fa-grin-tears", GroupName = "duotone light regular solid")]
        GrinTears = '\uf588',
        
        /// <summary>
        ///     Grin Tongue ("fa-grin-tongue", \uf589) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Tongue", Description = "fa-grin-tongue", GroupName = "duotone light regular solid")]
        GrinTongue = '\uf589',
        
        /// <summary>
        ///     Grin Tongue Squint ("fa-grin-tongue-squint", \uf58a) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Tongue Squint", Description = "fa-grin-tongue-squint", GroupName = "duotone light regular solid")]
        GrinTongueSquint = '\uf58a',
        
        /// <summary>
        ///     Grin Tongue Wink ("fa-grin-tongue-wink", \uf58b) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Tongue Wink", Description = "fa-grin-tongue-wink", GroupName = "duotone light regular solid")]
        GrinTongueWink = '\uf58b',
        
        /// <summary>
        ///     Grin Wink ("fa-grin-wink", \uf58c) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Wink", Description = "fa-grin-wink", GroupName = "duotone light regular solid")]
        GrinWink = '\uf58c',
        
        /// <summary>
        ///     Gripfire ("fa-gripfire", \uf3ac) icon.
        /// </summary>
        /// 
        [Display(Name = "Gripfire", Description = "fa-gripfire", GroupName = "brands")]
        Gripfire = '\uf3ac',
        
        /// <summary>
        ///     Grip Horizontal ("fa-grip-horizontal", \uf58d) icon.
        /// </summary>
        /// 
        [Display(Name = "Grip Horizontal", Description = "fa-grip-horizontal", GroupName = "duotone light regular solid")]
        GripHorizontal = '\uf58d',
        
        /// <summary>
        ///     Grip Lines ("fa-grip-lines", \uf7a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Grip Lines", Description = "fa-grip-lines", GroupName = "duotone light regular solid")]
        GripLines = '\uf7a4',
        
        /// <summary>
        ///     Grip Lines Vertical ("fa-grip-lines-vertical", \uf7a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Grip Lines Vertical", Description = "fa-grip-lines-vertical", GroupName = "duotone light regular solid")]
        GripLinesVertical = '\uf7a5',
        
        /// <summary>
        ///     Grip Vertical ("fa-grip-vertical", \uf58e) icon.
        /// </summary>
        /// 
        [Display(Name = "Grip Vertical", Description = "fa-grip-vertical", GroupName = "duotone light regular solid")]
        GripVertical = '\uf58e',
        
        /// <summary>
        ///     Grunt ("fa-grunt", \uf3ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Grunt", Description = "fa-grunt", GroupName = "brands")]
        Grunt = '\uf3ad',
        
        /// <summary>
        ///     Guitar ("fa-guitar", \uf7a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Guitar", Description = "fa-guitar", GroupName = "duotone light regular solid")]
        Guitar = '\uf7a6',
        
        /// <summary>
        ///     Gulp ("fa-gulp", \uf3ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Gulp", Description = "fa-gulp", GroupName = "brands")]
        Gulp = '\uf3ae',
        
        /// <summary>
        ///     Hacker News ("fa-hacker-news", \uf1d4) icon.
        /// </summary>
        /// 
        [Display(Name = "Hacker News", Description = "fa-hacker-news", GroupName = "brands")]
        HackerNews = '\uf1d4',
        
        /// <summary>
        ///     Hacker News Square ("fa-hacker-news-square", \uf3af) icon.
        /// </summary>
        /// 
        [Display(Name = "Hacker News Square", Description = "fa-hacker-news-square", GroupName = "brands")]
        HackerNewsSquare = '\uf3af',
        
        /// <summary>
        ///     Hackerrank ("fa-hackerrank", \uf5f7) icon.
        /// </summary>
        /// 
        [Display(Name = "Hackerrank", Description = "fa-hackerrank", GroupName = "brands")]
        Hackerrank = '\uf5f7',
        
        /// <summary>
        ///     Hamburger ("fa-hamburger", \uf805) icon.
        /// </summary>
        /// 
        [Display(Name = "Hamburger", Description = "fa-hamburger", GroupName = "duotone light regular solid")]
        Hamburger = '\uf805',
        
        /// <summary>
        ///     Hammer ("fa-hammer", \uf6e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Hammer", Description = "fa-hammer", GroupName = "duotone light regular solid")]
        Hammer = '\uf6e3',
        
        /// <summary>
        ///     Hamsa ("fa-hamsa", \uf665) icon.
        /// </summary>
        /// 
        [Display(Name = "Hamsa", Description = "fa-hamsa", GroupName = "duotone light regular solid")]
        Hamsa = '\uf665',
        
        /// <summary>
        ///     Hand Holding ("fa-hand-holding", \uf4bd) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Holding", Description = "fa-hand-holding", GroupName = "duotone light regular solid")]
        HandHolding = '\uf4bd',
        
        /// <summary>
        ///     Hand Holding Heart ("fa-hand-holding-heart", \uf4be) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Holding Heart", Description = "fa-hand-holding-heart", GroupName = "duotone light regular solid")]
        HandHoldingHeart = '\uf4be',
        
        /// <summary>
        ///     Hand Holding Medical ("fa-hand-holding-medical", \uf95c) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Holding Medical", Description = "fa-hand-holding-medical", GroupName = "duotone light regular solid")]
        HandHoldingMedical = '\uf95c',
        
        /// <summary>
        ///     Hand Holding Usd ("fa-hand-holding-usd", \uf4c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Holding Usd", Description = "fa-hand-holding-usd", GroupName = "duotone light regular solid")]
        HandHoldingUsd = '\uf4c0',
        
        /// <summary>
        ///     Hand Holding Water ("fa-hand-holding-water", \uf4c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Holding Water", Description = "fa-hand-holding-water", GroupName = "duotone light regular solid")]
        HandHoldingWater = '\uf4c1',
        
        /// <summary>
        ///     Hand Lizard ("fa-hand-lizard", \uf258) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Lizard", Description = "fa-hand-lizard", GroupName = "duotone light regular solid")]
        HandLizard = '\uf258',
        
        /// <summary>
        ///     Hand Middle Finger ("fa-hand-middle-finger", \uf806) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Middle Finger", Description = "fa-hand-middle-finger", GroupName = "duotone light regular solid")]
        HandMiddleFinger = '\uf806',
        
        /// <summary>
        ///     Hand Paper ("fa-hand-paper", \uf256) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Paper", Description = "fa-hand-paper", GroupName = "duotone light regular solid")]
        HandPaper = '\uf256',
        
        /// <summary>
        ///     Hand Peace ("fa-hand-peace", \uf25b) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Peace", Description = "fa-hand-peace", GroupName = "duotone light regular solid")]
        HandPeace = '\uf25b',
        
        /// <summary>
        ///     Hand Point Down ("fa-hand-point-down", \uf0a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Point Down", Description = "fa-hand-point-down", GroupName = "duotone light regular solid")]
        HandPointDown = '\uf0a7',
        
        /// <summary>
        ///     Hand Pointer ("fa-hand-pointer", \uf25a) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Pointer", Description = "fa-hand-pointer", GroupName = "duotone light regular solid")]
        HandPointer = '\uf25a',
        
        /// <summary>
        ///     Hand Point Left ("fa-hand-point-left", \uf0a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Point Left", Description = "fa-hand-point-left", GroupName = "duotone light regular solid")]
        HandPointLeft = '\uf0a5',
        
        /// <summary>
        ///     Hand Point Right ("fa-hand-point-right", \uf0a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Point Right", Description = "fa-hand-point-right", GroupName = "duotone light regular solid")]
        HandPointRight = '\uf0a4',
        
        /// <summary>
        ///     Hand Point Up ("fa-hand-point-up", \uf0a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Point Up", Description = "fa-hand-point-up", GroupName = "duotone light regular solid")]
        HandPointUp = '\uf0a6',
        
        /// <summary>
        ///     Hand Rock ("fa-hand-rock", \uf255) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Rock", Description = "fa-hand-rock", GroupName = "duotone light regular solid")]
        HandRock = '\uf255',
        
        /// <summary>
        ///     Hands ("fa-hands", \uf4c2) icon.
        /// </summary>
        /// 
        [Display(Name = "Hands", Description = "fa-hands", GroupName = "duotone light regular solid")]
        Hands = '\uf4c2',
        
        /// <summary>
        ///     Hand Scissors ("fa-hand-scissors", \uf257) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Scissors", Description = "fa-hand-scissors", GroupName = "duotone light regular solid")]
        HandScissors = '\uf257',
        
        /// <summary>
        ///     Handshake ("fa-handshake", \uf2b5) icon.
        /// </summary>
        /// 
        [Display(Name = "Handshake", Description = "fa-handshake", GroupName = "duotone light regular solid")]
        Handshake = '\uf2b5',
        
        /// <summary>
        ///     Handshake Alt Slash ("fa-handshake-alt-slash", \uf95f) icon.
        /// </summary>
        /// 
        [Display(Name = "Handshake Alt Slash", Description = "fa-handshake-alt-slash", GroupName = "duotone light regular solid")]
        HandshakeAltSlash = '\uf95f',
        
        /// <summary>
        ///     Handshake Slash ("fa-handshake-slash", \uf960) icon.
        /// </summary>
        /// 
        [Display(Name = "Handshake Slash", Description = "fa-handshake-slash", GroupName = "duotone light regular solid")]
        HandshakeSlash = '\uf960',
        
        /// <summary>
        ///     Hands Helping ("fa-hands-helping", \uf4c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Hands Helping", Description = "fa-hands-helping", GroupName = "duotone light regular solid")]
        HandsHelping = '\uf4c4',
        
        /// <summary>
        ///     Hand Sparkles ("fa-hand-sparkles", \uf95d) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Sparkles", Description = "fa-hand-sparkles", GroupName = "duotone light regular solid")]
        HandSparkles = '\uf95d',
        
        /// <summary>
        ///     Hand Spock ("fa-hand-spock", \uf259) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Spock", Description = "fa-hand-spock", GroupName = "duotone light regular solid")]
        HandSpock = '\uf259',
        
        /// <summary>
        ///     Hands Wash ("fa-hands-wash", \uf95e) icon.
        /// </summary>
        /// 
        [Display(Name = "Hands Wash", Description = "fa-hands-wash", GroupName = "duotone light regular solid")]
        HandsWash = '\uf95e',
        
        /// <summary>
        ///     Hanukiah ("fa-hanukiah", \uf6e6) icon.
        /// </summary>
        /// 
        [Display(Name = "Hanukiah", Description = "fa-hanukiah", GroupName = "duotone light regular solid")]
        Hanukiah = '\uf6e6',
        
        /// <summary>
        ///     Hard Hat ("fa-hard-hat", \uf807) icon.
        /// </summary>
        /// 
        [Display(Name = "Hard Hat", Description = "fa-hard-hat", GroupName = "duotone light regular solid")]
        HardHat = '\uf807',
        
        /// <summary>
        ///     Hashtag ("fa-hashtag", \uf292) icon.
        /// </summary>
        /// 
        [Display(Name = "Hashtag", Description = "fa-hashtag", GroupName = "duotone light regular solid")]
        Hashtag = '\uf292',
        
        /// <summary>
        ///     Hat Cowboy ("fa-hat-cowboy", \uf8c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Hat Cowboy", Description = "fa-hat-cowboy", GroupName = "duotone light regular solid")]
        HatCowboy = '\uf8c0',
        
        /// <summary>
        ///     Hat Cowboy Side ("fa-hat-cowboy-side", \uf8c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Hat Cowboy Side", Description = "fa-hat-cowboy-side", GroupName = "duotone light regular solid")]
        HatCowboySide = '\uf8c1',
        
        /// <summary>
        ///     Hat Wizard ("fa-hat-wizard", \uf6e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Hat Wizard", Description = "fa-hat-wizard", GroupName = "duotone light regular solid")]
        HatWizard = '\uf6e8',
        
        /// <summary>
        ///     Hdd ("fa-hdd", \uf0a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Hdd", Description = "fa-hdd", GroupName = "duotone light regular solid")]
        Hdd = '\uf0a0',
        
        /// <summary>
        ///     Heading ("fa-heading", \uf1dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Heading", Description = "fa-heading", GroupName = "duotone light regular solid")]
        Heading = '\uf1dc',
        
        /// <summary>
        ///     Headphones ("fa-headphones", \uf025) icon.
        /// </summary>
        /// 
        [Display(Name = "Headphones", Description = "fa-headphones", GroupName = "duotone light regular solid")]
        Headphones = '\uf025',
        
        /// <summary>
        ///     Headphones Alt ("fa-headphones-alt", \uf58f) icon.
        /// </summary>
        /// 
        [Display(Name = "Headphones Alt", Description = "fa-headphones-alt", GroupName = "duotone light regular solid")]
        HeadphonesAlt = '\uf58f',
        
        /// <summary>
        ///     Headset ("fa-headset", \uf590) icon.
        /// </summary>
        /// 
        [Display(Name = "Headset", Description = "fa-headset", GroupName = "duotone light regular solid")]
        Headset = '\uf590',
        
        /// <summary>
        ///     Head Side Cough ("fa-head-side-cough", \uf961) icon.
        /// </summary>
        /// 
        [Display(Name = "Head Side Cough", Description = "fa-head-side-cough", GroupName = "duotone light regular solid")]
        HeadSideCough = '\uf961',
        
        /// <summary>
        ///     Head Side Cough Slash ("fa-head-side-cough-slash", \uf962) icon.
        /// </summary>
        /// 
        [Display(Name = "Head Side Cough Slash", Description = "fa-head-side-cough-slash", GroupName = "duotone light regular solid")]
        HeadSideCoughSlash = '\uf962',
        
        /// <summary>
        ///     Head Side Mask ("fa-head-side-mask", \uf963) icon.
        /// </summary>
        /// 
        [Display(Name = "Head Side Mask", Description = "fa-head-side-mask", GroupName = "duotone light regular solid")]
        HeadSideMask = '\uf963',
        
        /// <summary>
        ///     Head Side Virus ("fa-head-side-virus", \uf964) icon.
        /// </summary>
        /// 
        [Display(Name = "Head Side Virus", Description = "fa-head-side-virus", GroupName = "duotone light regular solid")]
        HeadSideVirus = '\uf964',
        
        /// <summary>
        ///     Heart ("fa-heart", \uf004) icon.
        /// </summary>
        /// 
        [Display(Name = "Heart", Description = "fa-heart", GroupName = "duotone light regular solid")]
        Heart = '\uf004',
        
        /// <summary>
        ///     Heartbeat ("fa-heartbeat", \uf21e) icon.
        /// </summary>
        /// 
        [Display(Name = "Heartbeat", Description = "fa-heartbeat", GroupName = "duotone light regular solid")]
        Heartbeat = '\uf21e',
        
        /// <summary>
        ///     Heart Broken ("fa-heart-broken", \uf7a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Heart Broken", Description = "fa-heart-broken", GroupName = "duotone light regular solid")]
        HeartBroken = '\uf7a9',
        
        /// <summary>
        ///     Helicopter ("fa-helicopter", \uf533) icon.
        /// </summary>
        /// 
        [Display(Name = "Helicopter", Description = "fa-helicopter", GroupName = "duotone light regular solid")]
        Helicopter = '\uf533',
        
        /// <summary>
        ///     Highlighter ("fa-highlighter", \uf591) icon.
        /// </summary>
        /// 
        [Display(Name = "Highlighter", Description = "fa-highlighter", GroupName = "duotone light regular solid")]
        Highlighter = '\uf591',
        
        /// <summary>
        ///     Hiking ("fa-hiking", \uf6ec) icon.
        /// </summary>
        /// 
        [Display(Name = "Hiking", Description = "fa-hiking", GroupName = "duotone light regular solid")]
        Hiking = '\uf6ec',
        
        /// <summary>
        ///     Hippo ("fa-hippo", \uf6ed) icon.
        /// </summary>
        /// 
        [Display(Name = "Hippo", Description = "fa-hippo", GroupName = "duotone light regular solid")]
        Hippo = '\uf6ed',
        
        /// <summary>
        ///     Hips ("fa-hips", \uf452) icon.
        /// </summary>
        /// 
        [Display(Name = "Hips", Description = "fa-hips", GroupName = "brands")]
        Hips = '\uf452',
        
        /// <summary>
        ///     Hire A Helper ("fa-hire-a-helper", \uf3b0) icon.
        /// </summary>
        /// 
        [Display(Name = "Hire A Helper", Description = "fa-hire-a-helper", GroupName = "brands")]
        HireAHelper = '\uf3b0',
        
        /// <summary>
        ///     History ("fa-history", \uf1da) icon.
        /// </summary>
        /// 
        [Display(Name = "History", Description = "fa-history", GroupName = "duotone light regular solid")]
        History = '\uf1da',
        
        /// <summary>
        ///     Hockey Puck ("fa-hockey-puck", \uf453) icon.
        /// </summary>
        /// 
        [Display(Name = "Hockey Puck", Description = "fa-hockey-puck", GroupName = "duotone light regular solid")]
        HockeyPuck = '\uf453',
        
        /// <summary>
        ///     Holly Berry ("fa-holly-berry", \uf7aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Holly Berry", Description = "fa-holly-berry", GroupName = "duotone light regular solid")]
        HollyBerry = '\uf7aa',
        
        /// <summary>
        ///     Home ("fa-home", \uf015) icon.
        /// </summary>
        /// 
        [Display(Name = "Home", Description = "fa-home", GroupName = "duotone light regular solid")]
        Home = '\uf015',
        
        /// <summary>
        ///     Hooli ("fa-hooli", \uf427) icon.
        /// </summary>
        /// 
        [Display(Name = "Hooli", Description = "fa-hooli", GroupName = "brands")]
        Hooli = '\uf427',
        
        /// <summary>
        ///     Hornbill ("fa-hornbill", \uf592) icon.
        /// </summary>
        /// 
        [Display(Name = "Hornbill", Description = "fa-hornbill", GroupName = "brands")]
        Hornbill = '\uf592',
        
        /// <summary>
        ///     Horse ("fa-horse", \uf6f0) icon.
        /// </summary>
        /// 
        [Display(Name = "Horse", Description = "fa-horse", GroupName = "duotone light regular solid")]
        Horse = '\uf6f0',
        
        /// <summary>
        ///     Horse Head ("fa-horse-head", \uf7ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Horse Head", Description = "fa-horse-head", GroupName = "duotone light regular solid")]
        HorseHead = '\uf7ab',
        
        /// <summary>
        ///     Hospital ("fa-hospital", \uf0f8) icon.
        /// </summary>
        /// 
        [Display(Name = "Hospital", Description = "fa-hospital", GroupName = "duotone light regular solid")]
        Hospital = '\uf0f8',
        
        /// <summary>
        ///     Hospital Alt ("fa-hospital-alt", \uf47d) icon.
        /// </summary>
        /// 
        [Display(Name = "Hospital Alt", Description = "fa-hospital-alt", GroupName = "duotone light regular solid")]
        HospitalAlt = '\uf47d',
        
        /// <summary>
        ///     Hospital Symbol ("fa-hospital-symbol", \uf47e) icon.
        /// </summary>
        /// 
        [Display(Name = "Hospital Symbol", Description = "fa-hospital-symbol", GroupName = "duotone light regular solid")]
        HospitalSymbol = '\uf47e',
        
        /// <summary>
        ///     Hospital User ("fa-hospital-user", \uf80d) icon.
        /// </summary>
        /// 
        [Display(Name = "Hospital User", Description = "fa-hospital-user", GroupName = "duotone light regular solid")]
        HospitalUser = '\uf80d',
        
        /// <summary>
        ///     Hotdog ("fa-hotdog", \uf80f) icon.
        /// </summary>
        /// 
        [Display(Name = "Hotdog", Description = "fa-hotdog", GroupName = "duotone light regular solid")]
        Hotdog = '\uf80f',
        
        /// <summary>
        ///     Hotel ("fa-hotel", \uf594) icon.
        /// </summary>
        /// 
        [Display(Name = "Hotel", Description = "fa-hotel", GroupName = "duotone light regular solid")]
        Hotel = '\uf594',
        
        /// <summary>
        ///     Hotjar ("fa-hotjar", \uf3b1) icon.
        /// </summary>
        /// 
        [Display(Name = "Hotjar", Description = "fa-hotjar", GroupName = "brands")]
        Hotjar = '\uf3b1',
        
        /// <summary>
        ///     Hot Tub ("fa-hot-tub", \uf593) icon.
        /// </summary>
        /// 
        [Display(Name = "Hot Tub", Description = "fa-hot-tub", GroupName = "duotone light regular solid")]
        HotTub = '\uf593',
        
        /// <summary>
        ///     Hourglass ("fa-hourglass", \uf254) icon.
        /// </summary>
        /// 
        [Display(Name = "Hourglass", Description = "fa-hourglass", GroupName = "duotone light regular solid")]
        Hourglass = '\uf254',
        
        /// <summary>
        ///     Hourglass End ("fa-hourglass-end", \uf253) icon.
        /// </summary>
        /// 
        [Display(Name = "Hourglass End", Description = "fa-hourglass-end", GroupName = "duotone light regular solid")]
        HourglassEnd = '\uf253',
        
        /// <summary>
        ///     Hourglass Half ("fa-hourglass-half", \uf252) icon.
        /// </summary>
        /// 
        [Display(Name = "Hourglass Half", Description = "fa-hourglass-half", GroupName = "duotone light regular solid")]
        HourglassHalf = '\uf252',
        
        /// <summary>
        ///     Hourglass Start ("fa-hourglass-start", \uf251) icon.
        /// </summary>
        /// 
        [Display(Name = "Hourglass Start", Description = "fa-hourglass-start", GroupName = "duotone light regular solid")]
        HourglassStart = '\uf251',
        
        /// <summary>
        ///     House Damage ("fa-house-damage", \uf6f1) icon.
        /// </summary>
        /// 
        [Display(Name = "House Damage", Description = "fa-house-damage", GroupName = "duotone light regular solid")]
        HouseDamage = '\uf6f1',
        
        /// <summary>
        ///     House User ("fa-house-user", \uf965) icon.
        /// </summary>
        /// 
        [Display(Name = "House User", Description = "fa-house-user", GroupName = "duotone light regular solid")]
        HouseUser = '\uf965',
        
        /// <summary>
        ///     Houzz ("fa-houzz", \uf27c) icon.
        /// </summary>
        /// 
        [Display(Name = "Houzz", Description = "fa-houzz", GroupName = "brands")]
        Houzz = '\uf27c',
        
        /// <summary>
        ///     Hryvnia ("fa-hryvnia", \uf6f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Hryvnia", Description = "fa-hryvnia", GroupName = "duotone light regular solid")]
        Hryvnia = '\uf6f2',
        
        /// <summary>
        ///     H Square ("fa-h-square", \uf0fd) icon.
        /// </summary>
        /// 
        [Display(Name = "H Square", Description = "fa-h-square", GroupName = "duotone light regular solid")]
        HSquare = '\uf0fd',
        
        /// <summary>
        ///     Html5 ("fa-html5", \uf13b) icon.
        /// </summary>
        /// 
        [Display(Name = "Html5", Description = "fa-html5", GroupName = "brands")]
        Html5 = '\uf13b',
        
        /// <summary>
        ///     Hubspot ("fa-hubspot", \uf3b2) icon.
        /// </summary>
        /// 
        [Display(Name = "Hubspot", Description = "fa-hubspot", GroupName = "brands")]
        Hubspot = '\uf3b2',
        
        /// <summary>
        ///     Ice Cream ("fa-ice-cream", \uf810) icon.
        /// </summary>
        /// 
        [Display(Name = "Ice Cream", Description = "fa-ice-cream", GroupName = "duotone light regular solid")]
        IceCream = '\uf810',
        
        /// <summary>
        ///     Icicles ("fa-icicles", \uf7ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Icicles", Description = "fa-icicles", GroupName = "duotone light regular solid")]
        Icicles = '\uf7ad',
        
        /// <summary>
        ///     Icons ("fa-icons", \uf86d) icon.
        /// </summary>
        /// 
        [Display(Name = "Icons", Description = "fa-icons", GroupName = "duotone light regular solid")]
        Icons = '\uf86d',
        
        /// <summary>
        ///     I Cursor ("fa-i-cursor", \uf246) icon.
        /// </summary>
        /// 
        [Display(Name = "I Cursor", Description = "fa-i-cursor", GroupName = "duotone light regular solid")]
        ICursor = '\uf246',
        
        /// <summary>
        ///     Id Badge ("fa-id-badge", \uf2c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Id Badge", Description = "fa-id-badge", GroupName = "duotone light regular solid")]
        IdBadge = '\uf2c1',
        
        /// <summary>
        ///     Id Card ("fa-id-card", \uf2c2) icon.
        /// </summary>
        /// 
        [Display(Name = "Id Card", Description = "fa-id-card", GroupName = "duotone light regular solid")]
        IdCard = '\uf2c2',
        
        /// <summary>
        ///     Id Card Alt ("fa-id-card-alt", \uf47f) icon.
        /// </summary>
        /// 
        [Display(Name = "Id Card Alt", Description = "fa-id-card-alt", GroupName = "duotone light regular solid")]
        IdCardAlt = '\uf47f',
        
        /// <summary>
        ///     Ideal ("fa-ideal", \uf913) icon.
        /// </summary>
        /// 
        [Display(Name = "Ideal", Description = "fa-ideal", GroupName = "brands")]
        Ideal = '\uf913',
        
        /// <summary>
        ///     Igloo ("fa-igloo", \uf7ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Igloo", Description = "fa-igloo", GroupName = "duotone light regular solid")]
        Igloo = '\uf7ae',
        
        /// <summary>
        ///     Image ("fa-image", \uf03e) icon.
        /// </summary>
        /// 
        [Display(Name = "Image", Description = "fa-image", GroupName = "duotone light regular solid")]
        Image = '\uf03e',
        
        /// <summary>
        ///     Images ("fa-images", \uf302) icon.
        /// </summary>
        /// 
        [Display(Name = "Images", Description = "fa-images", GroupName = "duotone light regular solid")]
        Images = '\uf302',
        
        /// <summary>
        ///     Imdb ("fa-imdb", \uf2d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Imdb", Description = "fa-imdb", GroupName = "brands")]
        Imdb = '\uf2d8',
        
        /// <summary>
        ///     Inbox ("fa-inbox", \uf01c) icon.
        /// </summary>
        /// 
        [Display(Name = "Inbox", Description = "fa-inbox", GroupName = "duotone light regular solid")]
        Inbox = '\uf01c',
        
        /// <summary>
        ///     Indent ("fa-indent", \uf03c) icon.
        /// </summary>
        /// 
        [Display(Name = "Indent", Description = "fa-indent", GroupName = "duotone light regular solid")]
        Indent = '\uf03c',
        
        /// <summary>
        ///     Industry ("fa-industry", \uf275) icon.
        /// </summary>
        /// 
        [Display(Name = "Industry", Description = "fa-industry", GroupName = "duotone light regular solid")]
        Industry = '\uf275',
        
        /// <summary>
        ///     Infinity ("fa-infinity", \uf534) icon.
        /// </summary>
        /// 
        [Display(Name = "Infinity", Description = "fa-infinity", GroupName = "duotone light regular solid")]
        Infinity = '\uf534',
        
        /// <summary>
        ///     Info ("fa-info", \uf129) icon.
        /// </summary>
        /// 
        [Display(Name = "Info", Description = "fa-info", GroupName = "duotone light regular solid")]
        Info = '\uf129',
        
        /// <summary>
        ///     Info Circle ("fa-info-circle", \uf05a) icon.
        /// </summary>
        /// 
        [Display(Name = "Info Circle", Description = "fa-info-circle", GroupName = "duotone light regular solid")]
        InfoCircle = '\uf05a',
        
        /// <summary>
        ///     Instagram ("fa-instagram", \uf16d) icon.
        /// </summary>
        /// 
        [Display(Name = "Instagram", Description = "fa-instagram", GroupName = "brands")]
        Instagram = '\uf16d',
        
        /// <summary>
        ///     Instagram Square ("fa-instagram-square", \uf955) icon.
        /// </summary>
        /// 
        [Display(Name = "Instagram Square", Description = "fa-instagram-square", GroupName = "brands")]
        InstagramSquare = '\uf955',
        
        /// <summary>
        ///     Intercom ("fa-intercom", \uf7af) icon.
        /// </summary>
        /// 
        [Display(Name = "Intercom", Description = "fa-intercom", GroupName = "brands")]
        Intercom = '\uf7af',
        
        /// <summary>
        ///     Internet Explorer ("fa-internet-explorer", \uf26b) icon.
        /// </summary>
        /// 
        [Display(Name = "Internet Explorer", Description = "fa-internet-explorer", GroupName = "brands")]
        InternetExplorer = '\uf26b',
        
        /// <summary>
        ///     Invision ("fa-invision", \uf7b0) icon.
        /// </summary>
        /// 
        [Display(Name = "Invision", Description = "fa-invision", GroupName = "brands")]
        Invision = '\uf7b0',
        
        /// <summary>
        ///     Ioxhost ("fa-ioxhost", \uf208) icon.
        /// </summary>
        /// 
        [Display(Name = "Ioxhost", Description = "fa-ioxhost", GroupName = "brands")]
        Ioxhost = '\uf208',
        
        /// <summary>
        ///     Italic ("fa-italic", \uf033) icon.
        /// </summary>
        /// 
        [Display(Name = "Italic", Description = "fa-italic", GroupName = "duotone light regular solid")]
        Italic = '\uf033',
        
        /// <summary>
        ///     Itch Io ("fa-itch-io", \uf83a) icon.
        /// </summary>
        /// 
        [Display(Name = "Itch Io", Description = "fa-itch-io", GroupName = "brands")]
        ItchIo = '\uf83a',
        
        /// <summary>
        ///     Itunes ("fa-itunes", \uf3b4) icon.
        /// </summary>
        /// 
        [Display(Name = "Itunes", Description = "fa-itunes", GroupName = "brands")]
        Itunes = '\uf3b4',
        
        /// <summary>
        ///     Itunes Note ("fa-itunes-note", \uf3b5) icon.
        /// </summary>
        /// 
        [Display(Name = "Itunes Note", Description = "fa-itunes-note", GroupName = "brands")]
        ItunesNote = '\uf3b5',
        
        /// <summary>
        ///     Java ("fa-java", \uf4e4) icon.
        /// </summary>
        /// 
        [Display(Name = "Java", Description = "fa-java", GroupName = "brands")]
        Java = '\uf4e4',
        
        /// <summary>
        ///     Jedi ("fa-jedi", \uf669) icon.
        /// </summary>
        /// 
        [Display(Name = "Jedi", Description = "fa-jedi", GroupName = "duotone light regular solid")]
        Jedi = '\uf669',
        
        /// <summary>
        ///     Jedi Order ("fa-jedi-order", \uf50e) icon.
        /// </summary>
        /// 
        [Display(Name = "Jedi Order", Description = "fa-jedi-order", GroupName = "brands")]
        JediOrder = '\uf50e',
        
        /// <summary>
        ///     Jenkins ("fa-jenkins", \uf3b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Jenkins", Description = "fa-jenkins", GroupName = "brands")]
        Jenkins = '\uf3b6',
        
        /// <summary>
        ///     Jira ("fa-jira", \uf7b1) icon.
        /// </summary>
        /// 
        [Display(Name = "Jira", Description = "fa-jira", GroupName = "brands")]
        Jira = '\uf7b1',
        
        /// <summary>
        ///     Joget ("fa-joget", \uf3b7) icon.
        /// </summary>
        /// 
        [Display(Name = "Joget", Description = "fa-joget", GroupName = "brands")]
        Joget = '\uf3b7',
        
        /// <summary>
        ///     Joint ("fa-joint", \uf595) icon.
        /// </summary>
        /// 
        [Display(Name = "Joint", Description = "fa-joint", GroupName = "duotone light regular solid")]
        Joint = '\uf595',
        
        /// <summary>
        ///     Joomla ("fa-joomla", \uf1aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Joomla", Description = "fa-joomla", GroupName = "brands")]
        Joomla = '\uf1aa',
        
        /// <summary>
        ///     Journal Whills ("fa-journal-whills", \uf66a) icon.
        /// </summary>
        /// 
        [Display(Name = "Journal Whills", Description = "fa-journal-whills", GroupName = "duotone light regular solid")]
        JournalWhills = '\uf66a',
        
        /// <summary>
        ///     Js ("fa-js", \uf3b8) icon.
        /// </summary>
        /// 
        [Display(Name = "Js", Description = "fa-js", GroupName = "brands")]
        Js = '\uf3b8',
        
        /// <summary>
        ///     Jsfiddle ("fa-jsfiddle", \uf1cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Jsfiddle", Description = "fa-jsfiddle", GroupName = "brands")]
        Jsfiddle = '\uf1cc',
        
        /// <summary>
        ///     Js Square ("fa-js-square", \uf3b9) icon.
        /// </summary>
        /// 
        [Display(Name = "Js Square", Description = "fa-js-square", GroupName = "brands")]
        JsSquare = '\uf3b9',
        
        /// <summary>
        ///     Kaaba ("fa-kaaba", \uf66b) icon.
        /// </summary>
        /// 
        [Display(Name = "Kaaba", Description = "fa-kaaba", GroupName = "duotone light regular solid")]
        Kaaba = '\uf66b',
        
        /// <summary>
        ///     Kaggle ("fa-kaggle", \uf5fa) icon.
        /// </summary>
        /// 
        [Display(Name = "Kaggle", Description = "fa-kaggle", GroupName = "brands")]
        Kaggle = '\uf5fa',
        
        /// <summary>
        ///     Key ("fa-key", \uf084) icon.
        /// </summary>
        /// 
        [Display(Name = "Key", Description = "fa-key", GroupName = "duotone light regular solid")]
        Key = '\uf084',
        
        /// <summary>
        ///     Keybase ("fa-keybase", \uf4f5) icon.
        /// </summary>
        /// 
        [Display(Name = "Keybase", Description = "fa-keybase", GroupName = "brands")]
        Keybase = '\uf4f5',
        
        /// <summary>
        ///     Keyboard ("fa-keyboard", \uf11c) icon.
        /// </summary>
        /// 
        [Display(Name = "Keyboard", Description = "fa-keyboard", GroupName = "duotone light regular solid")]
        Keyboard = '\uf11c',
        
        /// <summary>
        ///     Keycdn ("fa-keycdn", \uf3ba) icon.
        /// </summary>
        /// 
        [Display(Name = "Keycdn", Description = "fa-keycdn", GroupName = "brands")]
        Keycdn = '\uf3ba',
        
        /// <summary>
        ///     Khanda ("fa-khanda", \uf66d) icon.
        /// </summary>
        /// 
        [Display(Name = "Khanda", Description = "fa-khanda", GroupName = "duotone light regular solid")]
        Khanda = '\uf66d',
        
        /// <summary>
        ///     Kickstarter ("fa-kickstarter", \uf3bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Kickstarter", Description = "fa-kickstarter", GroupName = "brands")]
        Kickstarter = '\uf3bb',
        
        /// <summary>
        ///     Kickstarter K ("fa-kickstarter-k", \uf3bc) icon.
        /// </summary>
        /// 
        [Display(Name = "Kickstarter K", Description = "fa-kickstarter-k", GroupName = "brands")]
        KickstarterK = '\uf3bc',
        
        /// <summary>
        ///     Kiss ("fa-kiss", \uf596) icon.
        /// </summary>
        /// 
        [Display(Name = "Kiss", Description = "fa-kiss", GroupName = "duotone light regular solid")]
        Kiss = '\uf596',
        
        /// <summary>
        ///     Kiss Beam ("fa-kiss-beam", \uf597) icon.
        /// </summary>
        /// 
        [Display(Name = "Kiss Beam", Description = "fa-kiss-beam", GroupName = "duotone light regular solid")]
        KissBeam = '\uf597',
        
        /// <summary>
        ///     Kiss Wink Heart ("fa-kiss-wink-heart", \uf598) icon.
        /// </summary>
        /// 
        [Display(Name = "Kiss Wink Heart", Description = "fa-kiss-wink-heart", GroupName = "duotone light regular solid")]
        KissWinkHeart = '\uf598',
        
        /// <summary>
        ///     Kiwi Bird ("fa-kiwi-bird", \uf535) icon.
        /// </summary>
        /// 
        [Display(Name = "Kiwi Bird", Description = "fa-kiwi-bird", GroupName = "duotone light regular solid")]
        KiwiBird = '\uf535',
        
        /// <summary>
        ///     Korvue ("fa-korvue", \uf42f) icon.
        /// </summary>
        /// 
        [Display(Name = "Korvue", Description = "fa-korvue", GroupName = "brands")]
        Korvue = '\uf42f',
        
        /// <summary>
        ///     Landmark ("fa-landmark", \uf66f) icon.
        /// </summary>
        /// 
        [Display(Name = "Landmark", Description = "fa-landmark", GroupName = "duotone light regular solid")]
        Landmark = '\uf66f',
        
        /// <summary>
        ///     Language ("fa-language", \uf1ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Language", Description = "fa-language", GroupName = "duotone light regular solid")]
        Language = '\uf1ab',
        
        /// <summary>
        ///     Laptop ("fa-laptop", \uf109) icon.
        /// </summary>
        /// 
        [Display(Name = "Laptop", Description = "fa-laptop", GroupName = "duotone light regular solid")]
        Laptop = '\uf109',
        
        /// <summary>
        ///     Laptop Code ("fa-laptop-code", \uf5fc) icon.
        /// </summary>
        /// 
        [Display(Name = "Laptop Code", Description = "fa-laptop-code", GroupName = "duotone light regular solid")]
        LaptopCode = '\uf5fc',
        
        /// <summary>
        ///     Laptop House ("fa-laptop-house", \uf966) icon.
        /// </summary>
        /// 
        [Display(Name = "Laptop House", Description = "fa-laptop-house", GroupName = "duotone light regular solid")]
        LaptopHouse = '\uf966',
        
        /// <summary>
        ///     Laptop Medical ("fa-laptop-medical", \uf812) icon.
        /// </summary>
        /// 
        [Display(Name = "Laptop Medical", Description = "fa-laptop-medical", GroupName = "duotone light regular solid")]
        LaptopMedical = '\uf812',
        
        /// <summary>
        ///     Laravel ("fa-laravel", \uf3bd) icon.
        /// </summary>
        /// 
        [Display(Name = "Laravel", Description = "fa-laravel", GroupName = "brands")]
        Laravel = '\uf3bd',
        
        /// <summary>
        ///     Lastfm ("fa-lastfm", \uf202) icon.
        /// </summary>
        /// 
        [Display(Name = "Lastfm", Description = "fa-lastfm", GroupName = "brands")]
        Lastfm = '\uf202',
        
        /// <summary>
        ///     Lastfm Square ("fa-lastfm-square", \uf203) icon.
        /// </summary>
        /// 
        [Display(Name = "Lastfm Square", Description = "fa-lastfm-square", GroupName = "brands")]
        LastfmSquare = '\uf203',
        
        /// <summary>
        ///     Laugh ("fa-laugh", \uf599) icon.
        /// </summary>
        /// 
        [Display(Name = "Laugh", Description = "fa-laugh", GroupName = "duotone light regular solid")]
        Laugh = '\uf599',
        
        /// <summary>
        ///     Laugh Beam ("fa-laugh-beam", \uf59a) icon.
        /// </summary>
        /// 
        [Display(Name = "Laugh Beam", Description = "fa-laugh-beam", GroupName = "duotone light regular solid")]
        LaughBeam = '\uf59a',
        
        /// <summary>
        ///     Laugh Squint ("fa-laugh-squint", \uf59b) icon.
        /// </summary>
        /// 
        [Display(Name = "Laugh Squint", Description = "fa-laugh-squint", GroupName = "duotone light regular solid")]
        LaughSquint = '\uf59b',
        
        /// <summary>
        ///     Laugh Wink ("fa-laugh-wink", \uf59c) icon.
        /// </summary>
        /// 
        [Display(Name = "Laugh Wink", Description = "fa-laugh-wink", GroupName = "duotone light regular solid")]
        LaughWink = '\uf59c',
        
        /// <summary>
        ///     Layer Group ("fa-layer-group", \uf5fd) icon.
        /// </summary>
        /// 
        [Display(Name = "Layer Group", Description = "fa-layer-group", GroupName = "duotone light regular solid")]
        LayerGroup = '\uf5fd',
        
        /// <summary>
        ///     Leaf ("fa-leaf", \uf06c) icon.
        /// </summary>
        /// 
        [Display(Name = "Leaf", Description = "fa-leaf", GroupName = "duotone light regular solid")]
        Leaf = '\uf06c',
        
        /// <summary>
        ///     Leanpub ("fa-leanpub", \uf212) icon.
        /// </summary>
        /// 
        [Display(Name = "Leanpub", Description = "fa-leanpub", GroupName = "brands")]
        Leanpub = '\uf212',
        
        /// <summary>
        ///     Lemon ("fa-lemon", \uf094) icon.
        /// </summary>
        /// 
        [Display(Name = "Lemon", Description = "fa-lemon", GroupName = "duotone light regular solid")]
        Lemon = '\uf094',
        
        /// <summary>
        ///     Less ("fa-less", \uf41d) icon.
        /// </summary>
        /// 
        [Display(Name = "Less", Description = "fa-less", GroupName = "brands")]
        Less = '\uf41d',
        
        /// <summary>
        ///     Less Than ("fa-less-than", \uf536) icon.
        /// </summary>
        /// 
        [Display(Name = "Less Than", Description = "fa-less-than", GroupName = "duotone light regular solid")]
        LessThan = '\uf536',
        
        /// <summary>
        ///     Less Than Equal ("fa-less-than-equal", \uf537) icon.
        /// </summary>
        /// 
        [Display(Name = "Less Than Equal", Description = "fa-less-than-equal", GroupName = "duotone light regular solid")]
        LessThanEqual = '\uf537',
        
        /// <summary>
        ///     Level Down Alt ("fa-level-down-alt", \uf3be) icon.
        /// </summary>
        /// 
        [Display(Name = "Level Down Alt", Description = "fa-level-down-alt", GroupName = "duotone light regular solid")]
        LevelDownAlt = '\uf3be',
        
        /// <summary>
        ///     Level Up Alt ("fa-level-up-alt", \uf3bf) icon.
        /// </summary>
        /// 
        [Display(Name = "Level Up Alt", Description = "fa-level-up-alt", GroupName = "duotone light regular solid")]
        LevelUpAlt = '\uf3bf',
        
        /// <summary>
        ///     Life Ring ("fa-life-ring", \uf1cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Life Ring", Description = "fa-life-ring", GroupName = "duotone light regular solid")]
        LifeRing = '\uf1cd',
        
        /// <summary>
        ///     Lightbulb ("fa-lightbulb", \uf0eb) icon.
        /// </summary>
        /// 
        [Display(Name = "Lightbulb", Description = "fa-lightbulb", GroupName = "duotone light regular solid")]
        Lightbulb = '\uf0eb',
        
        /// <summary>
        ///     Line ("fa-line", \uf3c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Line", Description = "fa-line", GroupName = "brands")]
        Line = '\uf3c0',
        
        /// <summary>
        ///     Link ("fa-link", \uf0c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Link", Description = "fa-link", GroupName = "duotone light regular solid")]
        Link = '\uf0c1',
        
        /// <summary>
        ///     Linkedin ("fa-linkedin", \uf08c) icon.
        /// </summary>
        /// 
        [Display(Name = "Linkedin", Description = "fa-linkedin", GroupName = "brands")]
        Linkedin = '\uf08c',
        
        /// <summary>
        ///     Linkedin In ("fa-linkedin-in", \uf0e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Linkedin In", Description = "fa-linkedin-in", GroupName = "brands")]
        LinkedinIn = '\uf0e1',
        
        /// <summary>
        ///     Linode ("fa-linode", \uf2b8) icon.
        /// </summary>
        /// 
        [Display(Name = "Linode", Description = "fa-linode", GroupName = "brands")]
        Linode = '\uf2b8',
        
        /// <summary>
        ///     Linux ("fa-linux", \uf17c) icon.
        /// </summary>
        /// 
        [Display(Name = "Linux", Description = "fa-linux", GroupName = "brands")]
        Linux = '\uf17c',
        
        /// <summary>
        ///     Lira Sign ("fa-lira-sign", \uf195) icon.
        /// </summary>
        /// 
        [Display(Name = "Lira Sign", Description = "fa-lira-sign", GroupName = "duotone light regular solid")]
        LiraSign = '\uf195',
        
        /// <summary>
        ///     List ("fa-list", \uf03a) icon.
        /// </summary>
        /// 
        [Display(Name = "List", Description = "fa-list", GroupName = "duotone light regular solid")]
        List = '\uf03a',
        
        /// <summary>
        ///     List Alt ("fa-list-alt", \uf022) icon.
        /// </summary>
        /// 
        [Display(Name = "List Alt", Description = "fa-list-alt", GroupName = "duotone light regular solid")]
        ListAlt = '\uf022',
        
        /// <summary>
        ///     List Ol ("fa-list-ol", \uf0cb) icon.
        /// </summary>
        /// 
        [Display(Name = "List Ol", Description = "fa-list-ol", GroupName = "duotone light regular solid")]
        ListOl = '\uf0cb',
        
        /// <summary>
        ///     List Ul ("fa-list-ul", \uf0ca) icon.
        /// </summary>
        /// 
        [Display(Name = "List Ul", Description = "fa-list-ul", GroupName = "duotone light regular solid")]
        ListUl = '\uf0ca',
        
        /// <summary>
        ///     Location Arrow ("fa-location-arrow", \uf124) icon.
        /// </summary>
        /// 
        [Display(Name = "Location Arrow", Description = "fa-location-arrow", GroupName = "duotone light regular solid")]
        LocationArrow = '\uf124',
        
        /// <summary>
        ///     Lock ("fa-lock", \uf023) icon.
        /// </summary>
        /// 
        [Display(Name = "Lock", Description = "fa-lock", GroupName = "duotone light regular solid")]
        Lock = '\uf023',
        
        /// <summary>
        ///     Lock Open ("fa-lock-open", \uf3c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Lock Open", Description = "fa-lock-open", GroupName = "duotone light regular solid")]
        LockOpen = '\uf3c1',
        
        /// <summary>
        ///     Long Arrow Alt Down ("fa-long-arrow-alt-down", \uf309) icon.
        /// </summary>
        /// 
        [Display(Name = "Long Arrow Alt Down", Description = "fa-long-arrow-alt-down", GroupName = "duotone light regular solid")]
        LongArrowAltDown = '\uf309',
        
        /// <summary>
        ///     Long Arrow Alt Left ("fa-long-arrow-alt-left", \uf30a) icon.
        /// </summary>
        /// 
        [Display(Name = "Long Arrow Alt Left", Description = "fa-long-arrow-alt-left", GroupName = "duotone light regular solid")]
        LongArrowAltLeft = '\uf30a',
        
        /// <summary>
        ///     Long Arrow Alt Right ("fa-long-arrow-alt-right", \uf30b) icon.
        /// </summary>
        /// 
        [Display(Name = "Long Arrow Alt Right", Description = "fa-long-arrow-alt-right", GroupName = "duotone light regular solid")]
        LongArrowAltRight = '\uf30b',
        
        /// <summary>
        ///     Long Arrow Alt Up ("fa-long-arrow-alt-up", \uf30c) icon.
        /// </summary>
        /// 
        [Display(Name = "Long Arrow Alt Up", Description = "fa-long-arrow-alt-up", GroupName = "duotone light regular solid")]
        LongArrowAltUp = '\uf30c',
        
        /// <summary>
        ///     Low Vision ("fa-low-vision", \uf2a8) icon.
        /// </summary>
        /// 
        [Display(Name = "Low Vision", Description = "fa-low-vision", GroupName = "duotone light regular solid")]
        LowVision = '\uf2a8',
        
        /// <summary>
        ///     Luggage Cart ("fa-luggage-cart", \uf59d) icon.
        /// </summary>
        /// 
        [Display(Name = "Luggage Cart", Description = "fa-luggage-cart", GroupName = "duotone light regular solid")]
        LuggageCart = '\uf59d',
        
        /// <summary>
        ///     Lungs ("fa-lungs", \uf604) icon.
        /// </summary>
        /// 
        [Display(Name = "Lungs", Description = "fa-lungs", GroupName = "duotone light regular solid")]
        Lungs = '\uf604',
        
        /// <summary>
        ///     Lungs Virus ("fa-lungs-virus", \uf967) icon.
        /// </summary>
        /// 
        [Display(Name = "Lungs Virus", Description = "fa-lungs-virus", GroupName = "duotone light regular solid")]
        LungsVirus = '\uf967',
        
        /// <summary>
        ///     Lyft ("fa-lyft", \uf3c3) icon.
        /// </summary>
        /// 
        [Display(Name = "Lyft", Description = "fa-lyft", GroupName = "brands")]
        Lyft = '\uf3c3',
        
        /// <summary>
        ///     Magento ("fa-magento", \uf3c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Magento", Description = "fa-magento", GroupName = "brands")]
        Magento = '\uf3c4',
        
        /// <summary>
        ///     Magic ("fa-magic", \uf0d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Magic", Description = "fa-magic", GroupName = "duotone light regular solid")]
        Magic = '\uf0d0',
        
        /// <summary>
        ///     Magnet ("fa-magnet", \uf076) icon.
        /// </summary>
        /// 
        [Display(Name = "Magnet", Description = "fa-magnet", GroupName = "duotone light regular solid")]
        Magnet = '\uf076',
        
        /// <summary>
        ///     Mail Bulk ("fa-mail-bulk", \uf674) icon.
        /// </summary>
        /// 
        [Display(Name = "Mail Bulk", Description = "fa-mail-bulk", GroupName = "duotone light regular solid")]
        MailBulk = '\uf674',
        
        /// <summary>
        ///     Mailchimp ("fa-mailchimp", \uf59e) icon.
        /// </summary>
        /// 
        [Display(Name = "Mailchimp", Description = "fa-mailchimp", GroupName = "brands")]
        Mailchimp = '\uf59e',
        
        /// <summary>
        ///     Male ("fa-male", \uf183) icon.
        /// </summary>
        /// 
        [Display(Name = "Male", Description = "fa-male", GroupName = "duotone light regular solid")]
        Male = '\uf183',
        
        /// <summary>
        ///     Mandalorian ("fa-mandalorian", \uf50f) icon.
        /// </summary>
        /// 
        [Display(Name = "Mandalorian", Description = "fa-mandalorian", GroupName = "brands")]
        Mandalorian = '\uf50f',
        
        /// <summary>
        ///     Map ("fa-map", \uf279) icon.
        /// </summary>
        /// 
        [Display(Name = "Map", Description = "fa-map", GroupName = "duotone light regular solid")]
        Map = '\uf279',
        
        /// <summary>
        ///     Map Marked ("fa-map-marked", \uf59f) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Marked", Description = "fa-map-marked", GroupName = "duotone light regular solid")]
        MapMarked = '\uf59f',
        
        /// <summary>
        ///     Map Marked Alt ("fa-map-marked-alt", \uf5a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Marked Alt", Description = "fa-map-marked-alt", GroupName = "duotone light regular solid")]
        MapMarkedAlt = '\uf5a0',
        
        /// <summary>
        ///     Map Marker ("fa-map-marker", \uf041) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Marker", Description = "fa-map-marker", GroupName = "duotone light regular solid")]
        MapMarker = '\uf041',
        
        /// <summary>
        ///     Map Marker Alt ("fa-map-marker-alt", \uf3c5) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Marker Alt", Description = "fa-map-marker-alt", GroupName = "duotone light regular solid")]
        MapMarkerAlt = '\uf3c5',
        
        /// <summary>
        ///     Map Pin ("fa-map-pin", \uf276) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Pin", Description = "fa-map-pin", GroupName = "duotone light regular solid")]
        MapPin = '\uf276',
        
        /// <summary>
        ///     Map Signs ("fa-map-signs", \uf277) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Signs", Description = "fa-map-signs", GroupName = "duotone light regular solid")]
        MapSigns = '\uf277',
        
        /// <summary>
        ///     Markdown ("fa-markdown", \uf60f) icon.
        /// </summary>
        /// 
        [Display(Name = "Markdown", Description = "fa-markdown", GroupName = "brands")]
        Markdown = '\uf60f',
        
        /// <summary>
        ///     Marker ("fa-marker", \uf5a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Marker", Description = "fa-marker", GroupName = "duotone light regular solid")]
        Marker = '\uf5a1',
        
        /// <summary>
        ///     Mars ("fa-mars", \uf222) icon.
        /// </summary>
        /// 
        [Display(Name = "Mars", Description = "fa-mars", GroupName = "duotone light regular solid")]
        Mars = '\uf222',
        
        /// <summary>
        ///     Mars Double ("fa-mars-double", \uf227) icon.
        /// </summary>
        /// 
        [Display(Name = "Mars Double", Description = "fa-mars-double", GroupName = "duotone light regular solid")]
        MarsDouble = '\uf227',
        
        /// <summary>
        ///     Mars Stroke ("fa-mars-stroke", \uf229) icon.
        /// </summary>
        /// 
        [Display(Name = "Mars Stroke", Description = "fa-mars-stroke", GroupName = "duotone light regular solid")]
        MarsStroke = '\uf229',
        
        /// <summary>
        ///     Mars Stroke H ("fa-mars-stroke-h", \uf22b) icon.
        /// </summary>
        /// 
        [Display(Name = "Mars Stroke H", Description = "fa-mars-stroke-h", GroupName = "duotone light regular solid")]
        MarsStrokeH = '\uf22b',
        
        /// <summary>
        ///     Mars Stroke V ("fa-mars-stroke-v", \uf22a) icon.
        /// </summary>
        /// 
        [Display(Name = "Mars Stroke V", Description = "fa-mars-stroke-v", GroupName = "duotone light regular solid")]
        MarsStrokeV = '\uf22a',
        
        /// <summary>
        ///     Mask ("fa-mask", \uf6fa) icon.
        /// </summary>
        /// 
        [Display(Name = "Mask", Description = "fa-mask", GroupName = "duotone light regular solid")]
        Mask = '\uf6fa',
        
        /// <summary>
        ///     Mastodon ("fa-mastodon", \uf4f6) icon.
        /// </summary>
        /// 
        [Display(Name = "Mastodon", Description = "fa-mastodon", GroupName = "brands")]
        Mastodon = '\uf4f6',
        
        /// <summary>
        ///     Maxcdn ("fa-maxcdn", \uf136) icon.
        /// </summary>
        /// 
        [Display(Name = "Maxcdn", Description = "fa-maxcdn", GroupName = "brands")]
        Maxcdn = '\uf136',
        
        /// <summary>
        ///     Mdb ("fa-mdb", \uf8ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Mdb", Description = "fa-mdb", GroupName = "brands")]
        Mdb = '\uf8ca',
        
        /// <summary>
        ///     Medal ("fa-medal", \uf5a2) icon.
        /// </summary>
        /// 
        [Display(Name = "Medal", Description = "fa-medal", GroupName = "duotone light regular solid")]
        Medal = '\uf5a2',
        
        /// <summary>
        ///     Medapps ("fa-medapps", \uf3c6) icon.
        /// </summary>
        /// 
        [Display(Name = "Medapps", Description = "fa-medapps", GroupName = "brands")]
        Medapps = '\uf3c6',
        
        /// <summary>
        ///     Medium ("fa-medium", \uf23a) icon.
        /// </summary>
        /// 
        [Display(Name = "Medium", Description = "fa-medium", GroupName = "brands")]
        Medium = '\uf23a',
        
        /// <summary>
        ///     Medium M ("fa-medium-m", \uf3c7) icon.
        /// </summary>
        /// 
        [Display(Name = "Medium M", Description = "fa-medium-m", GroupName = "brands")]
        MediumM = '\uf3c7',
        
        /// <summary>
        ///     Medkit ("fa-medkit", \uf0fa) icon.
        /// </summary>
        /// 
        [Display(Name = "Medkit", Description = "fa-medkit", GroupName = "duotone light regular solid")]
        Medkit = '\uf0fa',
        
        /// <summary>
        ///     Medrt ("fa-medrt", \uf3c8) icon.
        /// </summary>
        /// 
        [Display(Name = "Medrt", Description = "fa-medrt", GroupName = "brands")]
        Medrt = '\uf3c8',
        
        /// <summary>
        ///     Meetup ("fa-meetup", \uf2e0) icon.
        /// </summary>
        /// 
        [Display(Name = "Meetup", Description = "fa-meetup", GroupName = "brands")]
        Meetup = '\uf2e0',
        
        /// <summary>
        ///     Megaport ("fa-megaport", \uf5a3) icon.
        /// </summary>
        /// 
        [Display(Name = "Megaport", Description = "fa-megaport", GroupName = "brands")]
        Megaport = '\uf5a3',
        
        /// <summary>
        ///     Meh ("fa-meh", \uf11a) icon.
        /// </summary>
        /// 
        [Display(Name = "Meh", Description = "fa-meh", GroupName = "duotone light regular solid")]
        Meh = '\uf11a',
        
        /// <summary>
        ///     Meh Blank ("fa-meh-blank", \uf5a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Meh Blank", Description = "fa-meh-blank", GroupName = "duotone light regular solid")]
        MehBlank = '\uf5a4',
        
        /// <summary>
        ///     Meh Rolling Eyes ("fa-meh-rolling-eyes", \uf5a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Meh Rolling Eyes", Description = "fa-meh-rolling-eyes", GroupName = "duotone light regular solid")]
        MehRollingEyes = '\uf5a5',
        
        /// <summary>
        ///     Memory ("fa-memory", \uf538) icon.
        /// </summary>
        /// 
        [Display(Name = "Memory", Description = "fa-memory", GroupName = "duotone light regular solid")]
        Memory = '\uf538',
        
        /// <summary>
        ///     Mendeley ("fa-mendeley", \uf7b3) icon.
        /// </summary>
        /// 
        [Display(Name = "Mendeley", Description = "fa-mendeley", GroupName = "brands")]
        Mendeley = '\uf7b3',
        
        /// <summary>
        ///     Menorah ("fa-menorah", \uf676) icon.
        /// </summary>
        /// 
        [Display(Name = "Menorah", Description = "fa-menorah", GroupName = "duotone light regular solid")]
        Menorah = '\uf676',
        
        /// <summary>
        ///     Mercury ("fa-mercury", \uf223) icon.
        /// </summary>
        /// 
        [Display(Name = "Mercury", Description = "fa-mercury", GroupName = "duotone light regular solid")]
        Mercury = '\uf223',
        
        /// <summary>
        ///     Meteor ("fa-meteor", \uf753) icon.
        /// </summary>
        /// 
        [Display(Name = "Meteor", Description = "fa-meteor", GroupName = "duotone light regular solid")]
        Meteor = '\uf753',
        
        /// <summary>
        ///     Microblog ("fa-microblog", \uf91a) icon.
        /// </summary>
        /// 
        [Display(Name = "Microblog", Description = "fa-microblog", GroupName = "brands")]
        Microblog = '\uf91a',
        
        /// <summary>
        ///     Microchip ("fa-microchip", \uf2db) icon.
        /// </summary>
        /// 
        [Display(Name = "Microchip", Description = "fa-microchip", GroupName = "duotone light regular solid")]
        Microchip = '\uf2db',
        
        /// <summary>
        ///     Microphone ("fa-microphone", \uf130) icon.
        /// </summary>
        /// 
        [Display(Name = "Microphone", Description = "fa-microphone", GroupName = "duotone light regular solid")]
        Microphone = '\uf130',
        
        /// <summary>
        ///     Microphone Alt ("fa-microphone-alt", \uf3c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Microphone Alt", Description = "fa-microphone-alt", GroupName = "duotone light regular solid")]
        MicrophoneAlt = '\uf3c9',
        
        /// <summary>
        ///     Microphone Alt Slash ("fa-microphone-alt-slash", \uf539) icon.
        /// </summary>
        /// 
        [Display(Name = "Microphone Alt Slash", Description = "fa-microphone-alt-slash", GroupName = "duotone light regular solid")]
        MicrophoneAltSlash = '\uf539',
        
        /// <summary>
        ///     Microphone Slash ("fa-microphone-slash", \uf131) icon.
        /// </summary>
        /// 
        [Display(Name = "Microphone Slash", Description = "fa-microphone-slash", GroupName = "duotone light regular solid")]
        MicrophoneSlash = '\uf131',
        
        /// <summary>
        ///     Microscope ("fa-microscope", \uf610) icon.
        /// </summary>
        /// 
        [Display(Name = "Microscope", Description = "fa-microscope", GroupName = "duotone light regular solid")]
        Microscope = '\uf610',
        
        /// <summary>
        ///     Microsoft ("fa-microsoft", \uf3ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Microsoft", Description = "fa-microsoft", GroupName = "brands")]
        Microsoft = '\uf3ca',
        
        /// <summary>
        ///     Minus ("fa-minus", \uf068) icon.
        /// </summary>
        /// 
        [Display(Name = "Minus", Description = "fa-minus", GroupName = "duotone light regular solid")]
        Minus = '\uf068',
        
        /// <summary>
        ///     Minus Circle ("fa-minus-circle", \uf056) icon.
        /// </summary>
        /// 
        [Display(Name = "Minus Circle", Description = "fa-minus-circle", GroupName = "duotone light regular solid")]
        MinusCircle = '\uf056',
        
        /// <summary>
        ///     Minus Square ("fa-minus-square", \uf146) icon.
        /// </summary>
        /// 
        [Display(Name = "Minus Square", Description = "fa-minus-square", GroupName = "duotone light regular solid")]
        MinusSquare = '\uf146',
        
        /// <summary>
        ///     Mitten ("fa-mitten", \uf7b5) icon.
        /// </summary>
        /// 
        [Display(Name = "Mitten", Description = "fa-mitten", GroupName = "duotone light regular solid")]
        Mitten = '\uf7b5',
        
        /// <summary>
        ///     Mix ("fa-mix", \uf3cb) icon.
        /// </summary>
        /// 
        [Display(Name = "Mix", Description = "fa-mix", GroupName = "brands")]
        Mix = '\uf3cb',
        
        /// <summary>
        ///     Mixcloud ("fa-mixcloud", \uf289) icon.
        /// </summary>
        /// 
        [Display(Name = "Mixcloud", Description = "fa-mixcloud", GroupName = "brands")]
        Mixcloud = '\uf289',
        
        /// <summary>
        ///     Mixer ("fa-mixer", \uf956) icon.
        /// </summary>
        /// 
        [Display(Name = "Mixer", Description = "fa-mixer", GroupName = "brands")]
        Mixer = '\uf956',
        
        /// <summary>
        ///     Mizuni ("fa-mizuni", \uf3cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Mizuni", Description = "fa-mizuni", GroupName = "brands")]
        Mizuni = '\uf3cc',
        
        /// <summary>
        ///     Mobile ("fa-mobile", \uf10b) icon.
        /// </summary>
        /// 
        [Display(Name = "Mobile", Description = "fa-mobile", GroupName = "duotone light regular solid")]
        Mobile = '\uf10b',
        
        /// <summary>
        ///     Mobile Alt ("fa-mobile-alt", \uf3cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Mobile Alt", Description = "fa-mobile-alt", GroupName = "duotone light regular solid")]
        MobileAlt = '\uf3cd',
        
        /// <summary>
        ///     Modx ("fa-modx", \uf285) icon.
        /// </summary>
        /// 
        [Display(Name = "Modx", Description = "fa-modx", GroupName = "brands")]
        Modx = '\uf285',
        
        /// <summary>
        ///     Monero ("fa-monero", \uf3d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Monero", Description = "fa-monero", GroupName = "brands")]
        Monero = '\uf3d0',
        
        /// <summary>
        ///     Money Bill ("fa-money-bill", \uf0d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Bill", Description = "fa-money-bill", GroupName = "duotone light regular solid")]
        MoneyBill = '\uf0d6',
        
        /// <summary>
        ///     Money Bill Alt ("fa-money-bill-alt", \uf3d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Bill Alt", Description = "fa-money-bill-alt", GroupName = "duotone light regular solid")]
        MoneyBillAlt = '\uf3d1',
        
        /// <summary>
        ///     Money Bill Wave ("fa-money-bill-wave", \uf53a) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Bill Wave", Description = "fa-money-bill-wave", GroupName = "duotone light regular solid")]
        MoneyBillWave = '\uf53a',
        
        /// <summary>
        ///     Money Bill Wave Alt ("fa-money-bill-wave-alt", \uf53b) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Bill Wave Alt", Description = "fa-money-bill-wave-alt", GroupName = "duotone light regular solid")]
        MoneyBillWaveAlt = '\uf53b',
        
        /// <summary>
        ///     Money Check ("fa-money-check", \uf53c) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Check", Description = "fa-money-check", GroupName = "duotone light regular solid")]
        MoneyCheck = '\uf53c',
        
        /// <summary>
        ///     Money Check Alt ("fa-money-check-alt", \uf53d) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Check Alt", Description = "fa-money-check-alt", GroupName = "duotone light regular solid")]
        MoneyCheckAlt = '\uf53d',
        
        /// <summary>
        ///     Monument ("fa-monument", \uf5a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Monument", Description = "fa-monument", GroupName = "duotone light regular solid")]
        Monument = '\uf5a6',
        
        /// <summary>
        ///     Moon ("fa-moon", \uf186) icon.
        /// </summary>
        /// 
        [Display(Name = "Moon", Description = "fa-moon", GroupName = "duotone light regular solid")]
        Moon = '\uf186',
        
        /// <summary>
        ///     Mortar Pestle ("fa-mortar-pestle", \uf5a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Mortar Pestle", Description = "fa-mortar-pestle", GroupName = "duotone light regular solid")]
        MortarPestle = '\uf5a7',
        
        /// <summary>
        ///     Mosque ("fa-mosque", \uf678) icon.
        /// </summary>
        /// 
        [Display(Name = "Mosque", Description = "fa-mosque", GroupName = "duotone light regular solid")]
        Mosque = '\uf678',
        
        /// <summary>
        ///     Motorcycle ("fa-motorcycle", \uf21c) icon.
        /// </summary>
        /// 
        [Display(Name = "Motorcycle", Description = "fa-motorcycle", GroupName = "duotone light regular solid")]
        Motorcycle = '\uf21c',
        
        /// <summary>
        ///     Mountain ("fa-mountain", \uf6fc) icon.
        /// </summary>
        /// 
        [Display(Name = "Mountain", Description = "fa-mountain", GroupName = "duotone light regular solid")]
        Mountain = '\uf6fc',
        
        /// <summary>
        ///     Mouse ("fa-mouse", \uf8cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Mouse", Description = "fa-mouse", GroupName = "duotone light regular solid")]
        Mouse = '\uf8cc',
        
        /// <summary>
        ///     Mouse Pointer ("fa-mouse-pointer", \uf245) icon.
        /// </summary>
        /// 
        [Display(Name = "Mouse Pointer", Description = "fa-mouse-pointer", GroupName = "duotone light regular solid")]
        MousePointer = '\uf245',
        
        /// <summary>
        ///     Mug Hot ("fa-mug-hot", \uf7b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Mug Hot", Description = "fa-mug-hot", GroupName = "duotone light regular solid")]
        MugHot = '\uf7b6',
        
        /// <summary>
        ///     Music ("fa-music", \uf001) icon.
        /// </summary>
        /// 
        [Display(Name = "Music", Description = "fa-music", GroupName = "duotone light regular solid")]
        Music = '\uf001',
        
        /// <summary>
        ///     Napster ("fa-napster", \uf3d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Napster", Description = "fa-napster", GroupName = "brands")]
        Napster = '\uf3d2',
        
        /// <summary>
        ///     Neos ("fa-neos", \uf612) icon.
        /// </summary>
        /// 
        [Display(Name = "Neos", Description = "fa-neos", GroupName = "brands")]
        Neos = '\uf612',
        
        /// <summary>
        ///     Network Wired ("fa-network-wired", \uf6ff) icon.
        /// </summary>
        /// 
        [Display(Name = "Network Wired", Description = "fa-network-wired", GroupName = "duotone light regular solid")]
        NetworkWired = '\uf6ff',
        
        /// <summary>
        ///     Neuter ("fa-neuter", \uf22c) icon.
        /// </summary>
        /// 
        [Display(Name = "Neuter", Description = "fa-neuter", GroupName = "duotone light regular solid")]
        Neuter = '\uf22c',
        
        /// <summary>
        ///     Newspaper ("fa-newspaper", \uf1ea) icon.
        /// </summary>
        /// 
        [Display(Name = "Newspaper", Description = "fa-newspaper", GroupName = "duotone light regular solid")]
        Newspaper = '\uf1ea',
        
        /// <summary>
        ///     Nimblr ("fa-nimblr", \uf5a8) icon.
        /// </summary>
        /// 
        [Display(Name = "Nimblr", Description = "fa-nimblr", GroupName = "brands")]
        Nimblr = '\uf5a8',
        
        /// <summary>
        ///     Node ("fa-node", \uf419) icon.
        /// </summary>
        /// 
        [Display(Name = "Node", Description = "fa-node", GroupName = "brands")]
        Node = '\uf419',
        
        /// <summary>
        ///     Node Js ("fa-node-js", \uf3d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Node Js", Description = "fa-node-js", GroupName = "brands")]
        NodeJs = '\uf3d3',
        
        /// <summary>
        ///     Not Equal ("fa-not-equal", \uf53e) icon.
        /// </summary>
        /// 
        [Display(Name = "Not Equal", Description = "fa-not-equal", GroupName = "duotone light regular solid")]
        NotEqual = '\uf53e',
        
        /// <summary>
        ///     Notes Medical ("fa-notes-medical", \uf481) icon.
        /// </summary>
        /// 
        [Display(Name = "Notes Medical", Description = "fa-notes-medical", GroupName = "duotone light regular solid")]
        NotesMedical = '\uf481',
        
        /// <summary>
        ///     Npm ("fa-npm", \uf3d4) icon.
        /// </summary>
        /// 
        [Display(Name = "Npm", Description = "fa-npm", GroupName = "brands")]
        Npm = '\uf3d4',
        
        /// <summary>
        ///     Ns8 ("fa-ns8", \uf3d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Ns8", Description = "fa-ns8", GroupName = "brands")]
        Ns8 = '\uf3d5',
        
        /// <summary>
        ///     Nutritionix ("fa-nutritionix", \uf3d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Nutritionix", Description = "fa-nutritionix", GroupName = "brands")]
        Nutritionix = '\uf3d6',
        
        /// <summary>
        ///     Object Group ("fa-object-group", \uf247) icon.
        /// </summary>
        /// 
        [Display(Name = "Object Group", Description = "fa-object-group", GroupName = "duotone light regular solid")]
        ObjectGroup = '\uf247',
        
        /// <summary>
        ///     Object Ungroup ("fa-object-ungroup", \uf248) icon.
        /// </summary>
        /// 
        [Display(Name = "Object Ungroup", Description = "fa-object-ungroup", GroupName = "duotone light regular solid")]
        ObjectUngroup = '\uf248',
        
        /// <summary>
        ///     Odnoklassniki ("fa-odnoklassniki", \uf263) icon.
        /// </summary>
        /// 
        [Display(Name = "Odnoklassniki", Description = "fa-odnoklassniki", GroupName = "brands")]
        Odnoklassniki = '\uf263',
        
        /// <summary>
        ///     Odnoklassniki Square ("fa-odnoklassniki-square", \uf264) icon.
        /// </summary>
        /// 
        [Display(Name = "Odnoklassniki Square", Description = "fa-odnoklassniki-square", GroupName = "brands")]
        OdnoklassnikiSquare = '\uf264',
        
        /// <summary>
        ///     Oil Can ("fa-oil-can", \uf613) icon.
        /// </summary>
        /// 
        [Display(Name = "Oil Can", Description = "fa-oil-can", GroupName = "duotone light regular solid")]
        OilCan = '\uf613',
        
        /// <summary>
        ///     Old Republic ("fa-old-republic", \uf510) icon.
        /// </summary>
        /// 
        [Display(Name = "Old Republic", Description = "fa-old-republic", GroupName = "brands")]
        OldRepublic = '\uf510',
        
        /// <summary>
        ///     Om ("fa-om", \uf679) icon.
        /// </summary>
        /// 
        [Display(Name = "Om", Description = "fa-om", GroupName = "duotone light regular solid")]
        Om = '\uf679',
        
        /// <summary>
        ///     Opencart ("fa-opencart", \uf23d) icon.
        /// </summary>
        /// 
        [Display(Name = "Opencart", Description = "fa-opencart", GroupName = "brands")]
        Opencart = '\uf23d',
        
        /// <summary>
        ///     Openid ("fa-openid", \uf19b) icon.
        /// </summary>
        /// 
        [Display(Name = "Openid", Description = "fa-openid", GroupName = "brands")]
        Openid = '\uf19b',
        
        /// <summary>
        ///     Opera ("fa-opera", \uf26a) icon.
        /// </summary>
        /// 
        [Display(Name = "Opera", Description = "fa-opera", GroupName = "brands")]
        Opera = '\uf26a',
        
        /// <summary>
        ///     Optin Monster ("fa-optin-monster", \uf23c) icon.
        /// </summary>
        /// 
        [Display(Name = "Optin Monster", Description = "fa-optin-monster", GroupName = "brands")]
        OptinMonster = '\uf23c',
        
        /// <summary>
        ///     Orcid ("fa-orcid", \uf8d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Orcid", Description = "fa-orcid", GroupName = "brands")]
        Orcid = '\uf8d2',
        
        /// <summary>
        ///     Osi ("fa-osi", \uf41a) icon.
        /// </summary>
        /// 
        [Display(Name = "Osi", Description = "fa-osi", GroupName = "brands")]
        Osi = '\uf41a',
        
        /// <summary>
        ///     Otter ("fa-otter", \uf700) icon.
        /// </summary>
        /// 
        [Display(Name = "Otter", Description = "fa-otter", GroupName = "duotone light regular solid")]
        Otter = '\uf700',
        
        /// <summary>
        ///     Outdent ("fa-outdent", \uf03b) icon.
        /// </summary>
        /// 
        [Display(Name = "Outdent", Description = "fa-outdent", GroupName = "duotone light regular solid")]
        Outdent = '\uf03b',
        
        /// <summary>
        ///     Page4 ("fa-page4", \uf3d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Page4", Description = "fa-page4", GroupName = "brands")]
        Page4 = '\uf3d7',
        
        /// <summary>
        ///     Pagelines ("fa-pagelines", \uf18c) icon.
        /// </summary>
        /// 
        [Display(Name = "Pagelines", Description = "fa-pagelines", GroupName = "brands")]
        Pagelines = '\uf18c',
        
        /// <summary>
        ///     Pager ("fa-pager", \uf815) icon.
        /// </summary>
        /// 
        [Display(Name = "Pager", Description = "fa-pager", GroupName = "duotone light regular solid")]
        Pager = '\uf815',
        
        /// <summary>
        ///     Paint Brush ("fa-paint-brush", \uf1fc) icon.
        /// </summary>
        /// 
        [Display(Name = "Paint Brush", Description = "fa-paint-brush", GroupName = "duotone light regular solid")]
        PaintBrush = '\uf1fc',
        
        /// <summary>
        ///     Paint Roller ("fa-paint-roller", \uf5aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Paint Roller", Description = "fa-paint-roller", GroupName = "duotone light regular solid")]
        PaintRoller = '\uf5aa',
        
        /// <summary>
        ///     Palette ("fa-palette", \uf53f) icon.
        /// </summary>
        /// 
        [Display(Name = "Palette", Description = "fa-palette", GroupName = "duotone light regular solid")]
        Palette = '\uf53f',
        
        /// <summary>
        ///     Palfed ("fa-palfed", \uf3d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Palfed", Description = "fa-palfed", GroupName = "brands")]
        Palfed = '\uf3d8',
        
        /// <summary>
        ///     Pallet ("fa-pallet", \uf482) icon.
        /// </summary>
        /// 
        [Display(Name = "Pallet", Description = "fa-pallet", GroupName = "duotone light regular solid")]
        Pallet = '\uf482',
        
        /// <summary>
        ///     Paperclip ("fa-paperclip", \uf0c6) icon.
        /// </summary>
        /// 
        [Display(Name = "Paperclip", Description = "fa-paperclip", GroupName = "duotone light regular solid")]
        Paperclip = '\uf0c6',
        
        /// <summary>
        ///     Paper Plane ("fa-paper-plane", \uf1d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Paper Plane", Description = "fa-paper-plane", GroupName = "duotone light regular solid")]
        PaperPlane = '\uf1d8',
        
        /// <summary>
        ///     Parachute Box ("fa-parachute-box", \uf4cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Parachute Box", Description = "fa-parachute-box", GroupName = "duotone light regular solid")]
        ParachuteBox = '\uf4cd',
        
        /// <summary>
        ///     Paragraph ("fa-paragraph", \uf1dd) icon.
        /// </summary>
        /// 
        [Display(Name = "Paragraph", Description = "fa-paragraph", GroupName = "duotone light regular solid")]
        Paragraph = '\uf1dd',
        
        /// <summary>
        ///     Parking ("fa-parking", \uf540) icon.
        /// </summary>
        /// 
        [Display(Name = "Parking", Description = "fa-parking", GroupName = "duotone light regular solid")]
        Parking = '\uf540',
        
        /// <summary>
        ///     Passport ("fa-passport", \uf5ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Passport", Description = "fa-passport", GroupName = "duotone light regular solid")]
        Passport = '\uf5ab',
        
        /// <summary>
        ///     Pastafarianism ("fa-pastafarianism", \uf67b) icon.
        /// </summary>
        /// 
        [Display(Name = "Pastafarianism", Description = "fa-pastafarianism", GroupName = "duotone light regular solid")]
        Pastafarianism = '\uf67b',
        
        /// <summary>
        ///     Paste ("fa-paste", \uf0ea) icon.
        /// </summary>
        /// 
        [Display(Name = "Paste", Description = "fa-paste", GroupName = "duotone light regular solid")]
        Paste = '\uf0ea',
        
        /// <summary>
        ///     Patreon ("fa-patreon", \uf3d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Patreon", Description = "fa-patreon", GroupName = "brands")]
        Patreon = '\uf3d9',
        
        /// <summary>
        ///     Pause ("fa-pause", \uf04c) icon.
        /// </summary>
        /// 
        [Display(Name = "Pause", Description = "fa-pause", GroupName = "duotone light regular solid")]
        Pause = '\uf04c',
        
        /// <summary>
        ///     Pause Circle ("fa-pause-circle", \uf28b) icon.
        /// </summary>
        /// 
        [Display(Name = "Pause Circle", Description = "fa-pause-circle", GroupName = "duotone light regular solid")]
        PauseCircle = '\uf28b',
        
        /// <summary>
        ///     Paw ("fa-paw", \uf1b0) icon.
        /// </summary>
        /// 
        [Display(Name = "Paw", Description = "fa-paw", GroupName = "duotone light regular solid")]
        Paw = '\uf1b0',
        
        /// <summary>
        ///     Paypal ("fa-paypal", \uf1ed) icon.
        /// </summary>
        /// 
        [Display(Name = "Paypal", Description = "fa-paypal", GroupName = "brands")]
        Paypal = '\uf1ed',
        
        /// <summary>
        ///     Peace ("fa-peace", \uf67c) icon.
        /// </summary>
        /// 
        [Display(Name = "Peace", Description = "fa-peace", GroupName = "duotone light regular solid")]
        Peace = '\uf67c',
        
        /// <summary>
        ///     Pen ("fa-pen", \uf304) icon.
        /// </summary>
        /// 
        [Display(Name = "Pen", Description = "fa-pen", GroupName = "duotone light regular solid")]
        Pen = '\uf304',
        
        /// <summary>
        ///     Pen Alt ("fa-pen-alt", \uf305) icon.
        /// </summary>
        /// 
        [Display(Name = "Pen Alt", Description = "fa-pen-alt", GroupName = "duotone light regular solid")]
        PenAlt = '\uf305',
        
        /// <summary>
        ///     Pencil Alt ("fa-pencil-alt", \uf303) icon.
        /// </summary>
        /// 
        [Display(Name = "Pencil Alt", Description = "fa-pencil-alt", GroupName = "duotone light regular solid")]
        PencilAlt = '\uf303',
        
        /// <summary>
        ///     Pencil Ruler ("fa-pencil-ruler", \uf5ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Pencil Ruler", Description = "fa-pencil-ruler", GroupName = "duotone light regular solid")]
        PencilRuler = '\uf5ae',
        
        /// <summary>
        ///     Pen Fancy ("fa-pen-fancy", \uf5ac) icon.
        /// </summary>
        /// 
        [Display(Name = "Pen Fancy", Description = "fa-pen-fancy", GroupName = "duotone light regular solid")]
        PenFancy = '\uf5ac',
        
        /// <summary>
        ///     Pen Nib ("fa-pen-nib", \uf5ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Pen Nib", Description = "fa-pen-nib", GroupName = "duotone light regular solid")]
        PenNib = '\uf5ad',
        
        /// <summary>
        ///     Penny Arcade ("fa-penny-arcade", \uf704) icon.
        /// </summary>
        /// 
        [Display(Name = "Penny Arcade", Description = "fa-penny-arcade", GroupName = "brands")]
        PennyArcade = '\uf704',
        
        /// <summary>
        ///     Pen Square ("fa-pen-square", \uf14b) icon.
        /// </summary>
        /// 
        [Display(Name = "Pen Square", Description = "fa-pen-square", GroupName = "duotone light regular solid")]
        PenSquare = '\uf14b',
        
        /// <summary>
        ///     People Arrows ("fa-people-arrows", \uf968) icon.
        /// </summary>
        /// 
        [Display(Name = "People Arrows", Description = "fa-people-arrows", GroupName = "duotone light regular solid")]
        PeopleArrows = '\uf968',
        
        /// <summary>
        ///     People Carry ("fa-people-carry", \uf4ce) icon.
        /// </summary>
        /// 
        [Display(Name = "People Carry", Description = "fa-people-carry", GroupName = "duotone light regular solid")]
        PeopleCarry = '\uf4ce',
        
        /// <summary>
        ///     Pepper Hot ("fa-pepper-hot", \uf816) icon.
        /// </summary>
        /// 
        [Display(Name = "Pepper Hot", Description = "fa-pepper-hot", GroupName = "duotone light regular solid")]
        PepperHot = '\uf816',
        
        /// <summary>
        ///     Percent ("fa-percent", \uf295) icon.
        /// </summary>
        /// 
        [Display(Name = "Percent", Description = "fa-percent", GroupName = "duotone light regular solid")]
        Percent = '\uf295',
        
        /// <summary>
        ///     Percentage ("fa-percentage", \uf541) icon.
        /// </summary>
        /// 
        [Display(Name = "Percentage", Description = "fa-percentage", GroupName = "duotone light regular solid")]
        Percentage = '\uf541',
        
        /// <summary>
        ///     Periscope ("fa-periscope", \uf3da) icon.
        /// </summary>
        /// 
        [Display(Name = "Periscope", Description = "fa-periscope", GroupName = "brands")]
        Periscope = '\uf3da',
        
        /// <summary>
        ///     Person Booth ("fa-person-booth", \uf756) icon.
        /// </summary>
        /// 
        [Display(Name = "Person Booth", Description = "fa-person-booth", GroupName = "duotone light regular solid")]
        PersonBooth = '\uf756',
        
        /// <summary>
        ///     Phabricator ("fa-phabricator", \uf3db) icon.
        /// </summary>
        /// 
        [Display(Name = "Phabricator", Description = "fa-phabricator", GroupName = "brands")]
        Phabricator = '\uf3db',
        
        /// <summary>
        ///     Phoenix Framework ("fa-phoenix-framework", \uf3dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Phoenix Framework", Description = "fa-phoenix-framework", GroupName = "brands")]
        PhoenixFramework = '\uf3dc',
        
        /// <summary>
        ///     Phoenix Squadron ("fa-phoenix-squadron", \uf511) icon.
        /// </summary>
        /// 
        [Display(Name = "Phoenix Squadron", Description = "fa-phoenix-squadron", GroupName = "brands")]
        PhoenixSquadron = '\uf511',
        
        /// <summary>
        ///     Phone ("fa-phone", \uf095) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone", Description = "fa-phone", GroupName = "duotone light regular solid")]
        Phone = '\uf095',
        
        /// <summary>
        ///     Phone Alt ("fa-phone-alt", \uf879) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone Alt", Description = "fa-phone-alt", GroupName = "duotone light regular solid")]
        PhoneAlt = '\uf879',
        
        /// <summary>
        ///     Phone Slash ("fa-phone-slash", \uf3dd) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone Slash", Description = "fa-phone-slash", GroupName = "duotone light regular solid")]
        PhoneSlash = '\uf3dd',
        
        /// <summary>
        ///     Phone Square ("fa-phone-square", \uf098) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone Square", Description = "fa-phone-square", GroupName = "duotone light regular solid")]
        PhoneSquare = '\uf098',
        
        /// <summary>
        ///     Phone Square Alt ("fa-phone-square-alt", \uf87b) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone Square Alt", Description = "fa-phone-square-alt", GroupName = "duotone light regular solid")]
        PhoneSquareAlt = '\uf87b',
        
        /// <summary>
        ///     Phone Volume ("fa-phone-volume", \uf2a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone Volume", Description = "fa-phone-volume", GroupName = "duotone light regular solid")]
        PhoneVolume = '\uf2a0',
        
        /// <summary>
        ///     Photo Video ("fa-photo-video", \uf87c) icon.
        /// </summary>
        /// 
        [Display(Name = "Photo Video", Description = "fa-photo-video", GroupName = "duotone light regular solid")]
        PhotoVideo = '\uf87c',
        
        /// <summary>
        ///     Php ("fa-php", \uf457) icon.
        /// </summary>
        /// 
        [Display(Name = "Php", Description = "fa-php", GroupName = "brands")]
        Php = '\uf457',
        
        /// <summary>
        ///     Pied Piper ("fa-pied-piper", \uf2ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Pied Piper", Description = "fa-pied-piper", GroupName = "brands")]
        PiedPiper = '\uf2ae',
        
        /// <summary>
        ///     Pied Piper Alt ("fa-pied-piper-alt", \uf1a8) icon.
        /// </summary>
        /// 
        [Display(Name = "Pied Piper Alt", Description = "fa-pied-piper-alt", GroupName = "brands")]
        PiedPiperAlt = '\uf1a8',
        
        /// <summary>
        ///     Pied Piper Hat ("fa-pied-piper-hat", \uf4e5) icon.
        /// </summary>
        /// 
        [Display(Name = "Pied Piper Hat", Description = "fa-pied-piper-hat", GroupName = "brands")]
        PiedPiperHat = '\uf4e5',
        
        /// <summary>
        ///     Pied Piper Pp ("fa-pied-piper-pp", \uf1a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Pied Piper Pp", Description = "fa-pied-piper-pp", GroupName = "brands")]
        PiedPiperPp = '\uf1a7',
        
        /// <summary>
        ///     Pied Piper Square ("fa-pied-piper-square", \uf91e) icon.
        /// </summary>
        /// 
        [Display(Name = "Pied Piper Square", Description = "fa-pied-piper-square", GroupName = "brands")]
        PiedPiperSquare = '\uf91e',
        
        /// <summary>
        ///     Piggy Bank ("fa-piggy-bank", \uf4d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Piggy Bank", Description = "fa-piggy-bank", GroupName = "duotone light regular solid")]
        PiggyBank = '\uf4d3',
        
        /// <summary>
        ///     Pills ("fa-pills", \uf484) icon.
        /// </summary>
        /// 
        [Display(Name = "Pills", Description = "fa-pills", GroupName = "duotone light regular solid")]
        Pills = '\uf484',
        
        /// <summary>
        ///     Pinterest ("fa-pinterest", \uf0d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Pinterest", Description = "fa-pinterest", GroupName = "brands")]
        Pinterest = '\uf0d2',
        
        /// <summary>
        ///     Pinterest P ("fa-pinterest-p", \uf231) icon.
        /// </summary>
        /// 
        [Display(Name = "Pinterest P", Description = "fa-pinterest-p", GroupName = "brands")]
        PinterestP = '\uf231',
        
        /// <summary>
        ///     Pinterest Square ("fa-pinterest-square", \uf0d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Pinterest Square", Description = "fa-pinterest-square", GroupName = "brands")]
        PinterestSquare = '\uf0d3',
        
        /// <summary>
        ///     Pizza Slice ("fa-pizza-slice", \uf818) icon.
        /// </summary>
        /// 
        [Display(Name = "Pizza Slice", Description = "fa-pizza-slice", GroupName = "duotone light regular solid")]
        PizzaSlice = '\uf818',
        
        /// <summary>
        ///     Place Of Worship ("fa-place-of-worship", \uf67f) icon.
        /// </summary>
        /// 
        [Display(Name = "Place Of Worship", Description = "fa-place-of-worship", GroupName = "duotone light regular solid")]
        PlaceOfWorship = '\uf67f',
        
        /// <summary>
        ///     Plane ("fa-plane", \uf072) icon.
        /// </summary>
        /// 
        [Display(Name = "Plane", Description = "fa-plane", GroupName = "duotone light regular solid")]
        Plane = '\uf072',
        
        /// <summary>
        ///     Plane Arrival ("fa-plane-arrival", \uf5af) icon.
        /// </summary>
        /// 
        [Display(Name = "Plane Arrival", Description = "fa-plane-arrival", GroupName = "duotone light regular solid")]
        PlaneArrival = '\uf5af',
        
        /// <summary>
        ///     Plane Departure ("fa-plane-departure", \uf5b0) icon.
        /// </summary>
        /// 
        [Display(Name = "Plane Departure", Description = "fa-plane-departure", GroupName = "duotone light regular solid")]
        PlaneDeparture = '\uf5b0',
        
        /// <summary>
        ///     Plane Slash ("fa-plane-slash", \uf969) icon.
        /// </summary>
        /// 
        [Display(Name = "Plane Slash", Description = "fa-plane-slash", GroupName = "duotone light regular solid")]
        PlaneSlash = '\uf969',
        
        /// <summary>
        ///     Play ("fa-play", \uf04b) icon.
        /// </summary>
        /// 
        [Display(Name = "Play", Description = "fa-play", GroupName = "duotone light regular solid")]
        Play = '\uf04b',
        
        /// <summary>
        ///     Play Circle ("fa-play-circle", \uf144) icon.
        /// </summary>
        /// 
        [Display(Name = "Play Circle", Description = "fa-play-circle", GroupName = "duotone light regular solid")]
        PlayCircle = '\uf144',
        
        /// <summary>
        ///     Playstation ("fa-playstation", \uf3df) icon.
        /// </summary>
        /// 
        [Display(Name = "Playstation", Description = "fa-playstation", GroupName = "brands")]
        Playstation = '\uf3df',
        
        /// <summary>
        ///     Plug ("fa-plug", \uf1e6) icon.
        /// </summary>
        /// 
        [Display(Name = "Plug", Description = "fa-plug", GroupName = "duotone light regular solid")]
        Plug = '\uf1e6',
        
        /// <summary>
        ///     Plus ("fa-plus", \uf067) icon.
        /// </summary>
        /// 
        [Display(Name = "Plus", Description = "fa-plus", GroupName = "duotone light regular solid")]
        Plus = '\uf067',
        
        /// <summary>
        ///     Plus Circle ("fa-plus-circle", \uf055) icon.
        /// </summary>
        /// 
        [Display(Name = "Plus Circle", Description = "fa-plus-circle", GroupName = "duotone light regular solid")]
        PlusCircle = '\uf055',
        
        /// <summary>
        ///     Plus Square ("fa-plus-square", \uf0fe) icon.
        /// </summary>
        /// 
        [Display(Name = "Plus Square", Description = "fa-plus-square", GroupName = "duotone light regular solid")]
        PlusSquare = '\uf0fe',
        
        /// <summary>
        ///     Podcast ("fa-podcast", \uf2ce) icon.
        /// </summary>
        /// 
        [Display(Name = "Podcast", Description = "fa-podcast", GroupName = "duotone light regular solid")]
        Podcast = '\uf2ce',
        
        /// <summary>
        ///     Poll ("fa-poll", \uf681) icon.
        /// </summary>
        /// 
        [Display(Name = "Poll", Description = "fa-poll", GroupName = "duotone light regular solid")]
        Poll = '\uf681',
        
        /// <summary>
        ///     Poll H ("fa-poll-h", \uf682) icon.
        /// </summary>
        /// 
        [Display(Name = "Poll H", Description = "fa-poll-h", GroupName = "duotone light regular solid")]
        PollH = '\uf682',
        
        /// <summary>
        ///     Poo ("fa-poo", \uf2fe) icon.
        /// </summary>
        /// 
        [Display(Name = "Poo", Description = "fa-poo", GroupName = "duotone light regular solid")]
        Poo = '\uf2fe',
        
        /// <summary>
        ///     Poop ("fa-poop", \uf619) icon.
        /// </summary>
        /// 
        [Display(Name = "Poop", Description = "fa-poop", GroupName = "duotone light regular solid")]
        Poop = '\uf619',
        
        /// <summary>
        ///     Poo Storm ("fa-poo-storm", \uf75a) icon.
        /// </summary>
        /// 
        [Display(Name = "Poo Storm", Description = "fa-poo-storm", GroupName = "duotone light regular solid")]
        PooStorm = '\uf75a',
        
        /// <summary>
        ///     Portrait ("fa-portrait", \uf3e0) icon.
        /// </summary>
        /// 
        [Display(Name = "Portrait", Description = "fa-portrait", GroupName = "duotone light regular solid")]
        Portrait = '\uf3e0',
        
        /// <summary>
        ///     Pound Sign ("fa-pound-sign", \uf154) icon.
        /// </summary>
        /// 
        [Display(Name = "Pound Sign", Description = "fa-pound-sign", GroupName = "duotone light regular solid")]
        PoundSign = '\uf154',
        
        /// <summary>
        ///     Power Off ("fa-power-off", \uf011) icon.
        /// </summary>
        /// 
        [Display(Name = "Power Off", Description = "fa-power-off", GroupName = "duotone light regular solid")]
        PowerOff = '\uf011',
        
        /// <summary>
        ///     Pray ("fa-pray", \uf683) icon.
        /// </summary>
        /// 
        [Display(Name = "Pray", Description = "fa-pray", GroupName = "duotone light regular solid")]
        Pray = '\uf683',
        
        /// <summary>
        ///     Praying Hands ("fa-praying-hands", \uf684) icon.
        /// </summary>
        /// 
        [Display(Name = "Praying Hands", Description = "fa-praying-hands", GroupName = "duotone light regular solid")]
        PrayingHands = '\uf684',
        
        /// <summary>
        ///     Prescription ("fa-prescription", \uf5b1) icon.
        /// </summary>
        /// 
        [Display(Name = "Prescription", Description = "fa-prescription", GroupName = "duotone light regular solid")]
        Prescription = '\uf5b1',
        
        /// <summary>
        ///     Prescription Bottle ("fa-prescription-bottle", \uf485) icon.
        /// </summary>
        /// 
        [Display(Name = "Prescription Bottle", Description = "fa-prescription-bottle", GroupName = "duotone light regular solid")]
        PrescriptionBottle = '\uf485',
        
        /// <summary>
        ///     Prescription Bottle Alt ("fa-prescription-bottle-alt", \uf486) icon.
        /// </summary>
        /// 
        [Display(Name = "Prescription Bottle Alt", Description = "fa-prescription-bottle-alt", GroupName = "duotone light regular solid")]
        PrescriptionBottleAlt = '\uf486',
        
        /// <summary>
        ///     Print ("fa-print", \uf02f) icon.
        /// </summary>
        /// 
        [Display(Name = "Print", Description = "fa-print", GroupName = "duotone light regular solid")]
        Print = '\uf02f',
        
        /// <summary>
        ///     Procedures ("fa-procedures", \uf487) icon.
        /// </summary>
        /// 
        [Display(Name = "Procedures", Description = "fa-procedures", GroupName = "duotone light regular solid")]
        Procedures = '\uf487',
        
        /// <summary>
        ///     Product Hunt ("fa-product-hunt", \uf288) icon.
        /// </summary>
        /// 
        [Display(Name = "Product Hunt", Description = "fa-product-hunt", GroupName = "brands")]
        ProductHunt = '\uf288',
        
        /// <summary>
        ///     Project Diagram ("fa-project-diagram", \uf542) icon.
        /// </summary>
        /// 
        [Display(Name = "Project Diagram", Description = "fa-project-diagram", GroupName = "duotone light regular solid")]
        ProjectDiagram = '\uf542',
        
        /// <summary>
        ///     Pump Medical ("fa-pump-medical", \uf96a) icon.
        /// </summary>
        /// 
        [Display(Name = "Pump Medical", Description = "fa-pump-medical", GroupName = "duotone light regular solid")]
        PumpMedical = '\uf96a',
        
        /// <summary>
        ///     Pump Soap ("fa-pump-soap", \uf96b) icon.
        /// </summary>
        /// 
        [Display(Name = "Pump Soap", Description = "fa-pump-soap", GroupName = "duotone light regular solid")]
        PumpSoap = '\uf96b',
        
        /// <summary>
        ///     Pushed ("fa-pushed", \uf3e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Pushed", Description = "fa-pushed", GroupName = "brands")]
        Pushed = '\uf3e1',
        
        /// <summary>
        ///     Puzzle Piece ("fa-puzzle-piece", \uf12e) icon.
        /// </summary>
        /// 
        [Display(Name = "Puzzle Piece", Description = "fa-puzzle-piece", GroupName = "duotone light regular solid")]
        PuzzlePiece = '\uf12e',
        
        /// <summary>
        ///     Python ("fa-python", \uf3e2) icon.
        /// </summary>
        /// 
        [Display(Name = "Python", Description = "fa-python", GroupName = "brands")]
        Python = '\uf3e2',
        
        /// <summary>
        ///     Qq ("fa-qq", \uf1d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Qq", Description = "fa-qq", GroupName = "brands")]
        Qq = '\uf1d6',
        
        /// <summary>
        ///     Qrcode ("fa-qrcode", \uf029) icon.
        /// </summary>
        /// 
        [Display(Name = "Qrcode", Description = "fa-qrcode", GroupName = "duotone light regular solid")]
        Qrcode = '\uf029',
        
        /// <summary>
        ///     Question ("fa-question", \uf128) icon.
        /// </summary>
        /// 
        [Display(Name = "Question", Description = "fa-question", GroupName = "duotone light regular solid")]
        Question = '\uf128',
        
        /// <summary>
        ///     Question Circle ("fa-question-circle", \uf059) icon.
        /// </summary>
        /// 
        [Display(Name = "Question Circle", Description = "fa-question-circle", GroupName = "duotone light regular solid")]
        QuestionCircle = '\uf059',
        
        /// <summary>
        ///     Quidditch ("fa-quidditch", \uf458) icon.
        /// </summary>
        /// 
        [Display(Name = "Quidditch", Description = "fa-quidditch", GroupName = "duotone light regular solid")]
        Quidditch = '\uf458',
        
        /// <summary>
        ///     Quinscape ("fa-quinscape", \uf459) icon.
        /// </summary>
        /// 
        [Display(Name = "Quinscape", Description = "fa-quinscape", GroupName = "brands")]
        Quinscape = '\uf459',
        
        /// <summary>
        ///     Quora ("fa-quora", \uf2c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Quora", Description = "fa-quora", GroupName = "brands")]
        Quora = '\uf2c4',
        
        /// <summary>
        ///     Quote Left ("fa-quote-left", \uf10d) icon.
        /// </summary>
        /// 
        [Display(Name = "Quote Left", Description = "fa-quote-left", GroupName = "duotone light regular solid")]
        QuoteLeft = '\uf10d',
        
        /// <summary>
        ///     Quote Right ("fa-quote-right", \uf10e) icon.
        /// </summary>
        /// 
        [Display(Name = "Quote Right", Description = "fa-quote-right", GroupName = "duotone light regular solid")]
        QuoteRight = '\uf10e',
        
        /// <summary>
        ///     Quran ("fa-quran", \uf687) icon.
        /// </summary>
        /// 
        [Display(Name = "Quran", Description = "fa-quran", GroupName = "duotone light regular solid")]
        Quran = '\uf687',
        
        /// <summary>
        ///     Radiation ("fa-radiation", \uf7b9) icon.
        /// </summary>
        /// 
        [Display(Name = "Radiation", Description = "fa-radiation", GroupName = "duotone light regular solid")]
        Radiation = '\uf7b9',
        
        /// <summary>
        ///     Radiation Alt ("fa-radiation-alt", \uf7ba) icon.
        /// </summary>
        /// 
        [Display(Name = "Radiation Alt", Description = "fa-radiation-alt", GroupName = "duotone light regular solid")]
        RadiationAlt = '\uf7ba',
        
        /// <summary>
        ///     Rainbow ("fa-rainbow", \uf75b) icon.
        /// </summary>
        /// 
        [Display(Name = "Rainbow", Description = "fa-rainbow", GroupName = "duotone light regular solid")]
        Rainbow = '\uf75b',
        
        /// <summary>
        ///     Random ("fa-random", \uf074) icon.
        /// </summary>
        /// 
        [Display(Name = "Random", Description = "fa-random", GroupName = "duotone light regular solid")]
        Random = '\uf074',
        
        /// <summary>
        ///     Raspberry Pi ("fa-raspberry-pi", \uf7bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Raspberry Pi", Description = "fa-raspberry-pi", GroupName = "brands")]
        RaspberryPi = '\uf7bb',
        
        /// <summary>
        ///     Ravelry ("fa-ravelry", \uf2d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Ravelry", Description = "fa-ravelry", GroupName = "brands")]
        Ravelry = '\uf2d9',
        
        /// <summary>
        ///     React ("fa-react", \uf41b) icon.
        /// </summary>
        /// 
        [Display(Name = "React", Description = "fa-react", GroupName = "brands")]
        React = '\uf41b',
        
        /// <summary>
        ///     Reacteurope ("fa-reacteurope", \uf75d) icon.
        /// </summary>
        /// 
        [Display(Name = "Reacteurope", Description = "fa-reacteurope", GroupName = "brands")]
        Reacteurope = '\uf75d',
        
        /// <summary>
        ///     Readme ("fa-readme", \uf4d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Readme", Description = "fa-readme", GroupName = "brands")]
        Readme = '\uf4d5',
        
        /// <summary>
        ///     Rebel ("fa-rebel", \uf1d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Rebel", Description = "fa-rebel", GroupName = "brands")]
        Rebel = '\uf1d0',
        
        /// <summary>
        ///     Receipt ("fa-receipt", \uf543) icon.
        /// </summary>
        /// 
        [Display(Name = "Receipt", Description = "fa-receipt", GroupName = "duotone light regular solid")]
        Receipt = '\uf543',
        
        /// <summary>
        ///     Record Vinyl ("fa-record-vinyl", \uf8d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Record Vinyl", Description = "fa-record-vinyl", GroupName = "duotone light regular solid")]
        RecordVinyl = '\uf8d9',
        
        /// <summary>
        ///     Recycle ("fa-recycle", \uf1b8) icon.
        /// </summary>
        /// 
        [Display(Name = "Recycle", Description = "fa-recycle", GroupName = "duotone light regular solid")]
        Recycle = '\uf1b8',
        
        /// <summary>
        ///     Reddit ("fa-reddit", \uf1a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Reddit", Description = "fa-reddit", GroupName = "brands")]
        Reddit = '\uf1a1',
        
        /// <summary>
        ///     Reddit Alien ("fa-reddit-alien", \uf281) icon.
        /// </summary>
        /// 
        [Display(Name = "Reddit Alien", Description = "fa-reddit-alien", GroupName = "brands")]
        RedditAlien = '\uf281',
        
        /// <summary>
        ///     Reddit Square ("fa-reddit-square", \uf1a2) icon.
        /// </summary>
        /// 
        [Display(Name = "Reddit Square", Description = "fa-reddit-square", GroupName = "brands")]
        RedditSquare = '\uf1a2',
        
        /// <summary>
        ///     Redhat ("fa-redhat", \uf7bc) icon.
        /// </summary>
        /// 
        [Display(Name = "Redhat", Description = "fa-redhat", GroupName = "brands")]
        Redhat = '\uf7bc',
        
        /// <summary>
        ///     Redo ("fa-redo", \uf01e) icon.
        /// </summary>
        /// 
        [Display(Name = "Redo", Description = "fa-redo", GroupName = "duotone light regular solid")]
        Redo = '\uf01e',
        
        /// <summary>
        ///     Redo Alt ("fa-redo-alt", \uf2f9) icon.
        /// </summary>
        /// 
        [Display(Name = "Redo Alt", Description = "fa-redo-alt", GroupName = "duotone light regular solid")]
        RedoAlt = '\uf2f9',
        
        /// <summary>
        ///     Red River ("fa-red-river", \uf3e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Red River", Description = "fa-red-river", GroupName = "brands")]
        RedRiver = '\uf3e3',
        
        /// <summary>
        ///     Registered ("fa-registered", \uf25d) icon.
        /// </summary>
        /// 
        [Display(Name = "Registered", Description = "fa-registered", GroupName = "duotone light regular solid")]
        Registered = '\uf25d',
        
        /// <summary>
        ///     Remove Format ("fa-remove-format", \uf87d) icon.
        /// </summary>
        /// 
        [Display(Name = "Remove Format", Description = "fa-remove-format", GroupName = "duotone light regular solid")]
        RemoveFormat = '\uf87d',
        
        /// <summary>
        ///     Renren ("fa-renren", \uf18b) icon.
        /// </summary>
        /// 
        [Display(Name = "Renren", Description = "fa-renren", GroupName = "brands")]
        Renren = '\uf18b',
        
        /// <summary>
        ///     Reply ("fa-reply", \uf3e5) icon.
        /// </summary>
        /// 
        [Display(Name = "Reply", Description = "fa-reply", GroupName = "duotone light regular solid")]
        Reply = '\uf3e5',
        
        /// <summary>
        ///     Reply All ("fa-reply-all", \uf122) icon.
        /// </summary>
        /// 
        [Display(Name = "Reply All", Description = "fa-reply-all", GroupName = "duotone light regular solid")]
        ReplyAll = '\uf122',
        
        /// <summary>
        ///     Replyd ("fa-replyd", \uf3e6) icon.
        /// </summary>
        /// 
        [Display(Name = "Replyd", Description = "fa-replyd", GroupName = "brands")]
        Replyd = '\uf3e6',
        
        /// <summary>
        ///     Republican ("fa-republican", \uf75e) icon.
        /// </summary>
        /// 
        [Display(Name = "Republican", Description = "fa-republican", GroupName = "duotone light regular solid")]
        Republican = '\uf75e',
        
        /// <summary>
        ///     Researchgate ("fa-researchgate", \uf4f8) icon.
        /// </summary>
        /// 
        [Display(Name = "Researchgate", Description = "fa-researchgate", GroupName = "brands")]
        Researchgate = '\uf4f8',
        
        /// <summary>
        ///     Resolving ("fa-resolving", \uf3e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Resolving", Description = "fa-resolving", GroupName = "brands")]
        Resolving = '\uf3e7',
        
        /// <summary>
        ///     Restroom ("fa-restroom", \uf7bd) icon.
        /// </summary>
        /// 
        [Display(Name = "Restroom", Description = "fa-restroom", GroupName = "duotone light regular solid")]
        Restroom = '\uf7bd',
        
        /// <summary>
        ///     Retweet ("fa-retweet", \uf079) icon.
        /// </summary>
        /// 
        [Display(Name = "Retweet", Description = "fa-retweet", GroupName = "duotone light regular solid")]
        Retweet = '\uf079',
        
        /// <summary>
        ///     Rev ("fa-rev", \uf5b2) icon.
        /// </summary>
        /// 
        [Display(Name = "Rev", Description = "fa-rev", GroupName = "brands")]
        Rev = '\uf5b2',
        
        /// <summary>
        ///     Ribbon ("fa-ribbon", \uf4d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Ribbon", Description = "fa-ribbon", GroupName = "duotone light regular solid")]
        Ribbon = '\uf4d6',
        
        /// <summary>
        ///     Ring ("fa-ring", \uf70b) icon.
        /// </summary>
        /// 
        [Display(Name = "Ring", Description = "fa-ring", GroupName = "duotone light regular solid")]
        Ring = '\uf70b',
        
        /// <summary>
        ///     Road ("fa-road", \uf018) icon.
        /// </summary>
        /// 
        [Display(Name = "Road", Description = "fa-road", GroupName = "duotone light regular solid")]
        Road = '\uf018',
        
        /// <summary>
        ///     Robot ("fa-robot", \uf544) icon.
        /// </summary>
        /// 
        [Display(Name = "Robot", Description = "fa-robot", GroupName = "duotone light regular solid")]
        Robot = '\uf544',
        
        /// <summary>
        ///     Rocket ("fa-rocket", \uf135) icon.
        /// </summary>
        /// 
        [Display(Name = "Rocket", Description = "fa-rocket", GroupName = "duotone light regular solid")]
        Rocket = '\uf135',
        
        /// <summary>
        ///     Rocketchat ("fa-rocketchat", \uf3e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Rocketchat", Description = "fa-rocketchat", GroupName = "brands")]
        Rocketchat = '\uf3e8',
        
        /// <summary>
        ///     Rockrms ("fa-rockrms", \uf3e9) icon.
        /// </summary>
        /// 
        [Display(Name = "Rockrms", Description = "fa-rockrms", GroupName = "brands")]
        Rockrms = '\uf3e9',
        
        /// <summary>
        ///     Route ("fa-route", \uf4d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Route", Description = "fa-route", GroupName = "duotone light regular solid")]
        Route = '\uf4d7',
        
        /// <summary>
        ///     R Project ("fa-r-project", \uf4f7) icon.
        /// </summary>
        /// 
        [Display(Name = "R Project", Description = "fa-r-project", GroupName = "brands")]
        RProject = '\uf4f7',
        
        /// <summary>
        ///     Rss ("fa-rss", \uf09e) icon.
        /// </summary>
        /// 
        [Display(Name = "Rss", Description = "fa-rss", GroupName = "duotone light regular solid")]
        Rss = '\uf09e',
        
        /// <summary>
        ///     Rss Square ("fa-rss-square", \uf143) icon.
        /// </summary>
        /// 
        [Display(Name = "Rss Square", Description = "fa-rss-square", GroupName = "duotone light regular solid")]
        RssSquare = '\uf143',
        
        /// <summary>
        ///     Ruble Sign ("fa-ruble-sign", \uf158) icon.
        /// </summary>
        /// 
        [Display(Name = "Ruble Sign", Description = "fa-ruble-sign", GroupName = "duotone light regular solid")]
        RubleSign = '\uf158',
        
        /// <summary>
        ///     Ruler ("fa-ruler", \uf545) icon.
        /// </summary>
        /// 
        [Display(Name = "Ruler", Description = "fa-ruler", GroupName = "duotone light regular solid")]
        Ruler = '\uf545',
        
        /// <summary>
        ///     Ruler Combined ("fa-ruler-combined", \uf546) icon.
        /// </summary>
        /// 
        [Display(Name = "Ruler Combined", Description = "fa-ruler-combined", GroupName = "duotone light regular solid")]
        RulerCombined = '\uf546',
        
        /// <summary>
        ///     Ruler Horizontal ("fa-ruler-horizontal", \uf547) icon.
        /// </summary>
        /// 
        [Display(Name = "Ruler Horizontal", Description = "fa-ruler-horizontal", GroupName = "duotone light regular solid")]
        RulerHorizontal = '\uf547',
        
        /// <summary>
        ///     Ruler Vertical ("fa-ruler-vertical", \uf548) icon.
        /// </summary>
        /// 
        [Display(Name = "Ruler Vertical", Description = "fa-ruler-vertical", GroupName = "duotone light regular solid")]
        RulerVertical = '\uf548',
        
        /// <summary>
        ///     Running ("fa-running", \uf70c) icon.
        /// </summary>
        /// 
        [Display(Name = "Running", Description = "fa-running", GroupName = "duotone light regular solid")]
        Running = '\uf70c',
        
        /// <summary>
        ///     Rupee Sign ("fa-rupee-sign", \uf156) icon.
        /// </summary>
        /// 
        [Display(Name = "Rupee Sign", Description = "fa-rupee-sign", GroupName = "duotone light regular solid")]
        RupeeSign = '\uf156',
        
        /// <summary>
        ///     Sad Cry ("fa-sad-cry", \uf5b3) icon.
        /// </summary>
        /// 
        [Display(Name = "Sad Cry", Description = "fa-sad-cry", GroupName = "duotone light regular solid")]
        SadCry = '\uf5b3',
        
        /// <summary>
        ///     Sad Tear ("fa-sad-tear", \uf5b4) icon.
        /// </summary>
        /// 
        [Display(Name = "Sad Tear", Description = "fa-sad-tear", GroupName = "duotone light regular solid")]
        SadTear = '\uf5b4',
        
        /// <summary>
        ///     Safari ("fa-safari", \uf267) icon.
        /// </summary>
        /// 
        [Display(Name = "Safari", Description = "fa-safari", GroupName = "brands")]
        Safari = '\uf267',
        
        /// <summary>
        ///     Salesforce ("fa-salesforce", \uf83b) icon.
        /// </summary>
        /// 
        [Display(Name = "Salesforce", Description = "fa-salesforce", GroupName = "brands")]
        Salesforce = '\uf83b',
        
        /// <summary>
        ///     Sass ("fa-sass", \uf41e) icon.
        /// </summary>
        /// 
        [Display(Name = "Sass", Description = "fa-sass", GroupName = "brands")]
        Sass = '\uf41e',
        
        /// <summary>
        ///     Satellite ("fa-satellite", \uf7bf) icon.
        /// </summary>
        /// 
        [Display(Name = "Satellite", Description = "fa-satellite", GroupName = "duotone light regular solid")]
        Satellite = '\uf7bf',
        
        /// <summary>
        ///     Satellite Dish ("fa-satellite-dish", \uf7c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Satellite Dish", Description = "fa-satellite-dish", GroupName = "duotone light regular solid")]
        SatelliteDish = '\uf7c0',
        
        /// <summary>
        ///     Save ("fa-save", \uf0c7) icon.
        /// </summary>
        /// 
        [Display(Name = "Save", Description = "fa-save", GroupName = "duotone light regular solid")]
        Save = '\uf0c7',
        
        /// <summary>
        ///     Schlix ("fa-schlix", \uf3ea) icon.
        /// </summary>
        /// 
        [Display(Name = "Schlix", Description = "fa-schlix", GroupName = "brands")]
        Schlix = '\uf3ea',
        
        /// <summary>
        ///     School ("fa-school", \uf549) icon.
        /// </summary>
        /// 
        [Display(Name = "School", Description = "fa-school", GroupName = "duotone light regular solid")]
        School = '\uf549',
        
        /// <summary>
        ///     Screwdriver ("fa-screwdriver", \uf54a) icon.
        /// </summary>
        /// 
        [Display(Name = "Screwdriver", Description = "fa-screwdriver", GroupName = "duotone light regular solid")]
        Screwdriver = '\uf54a',
        
        /// <summary>
        ///     Scribd ("fa-scribd", \uf28a) icon.
        /// </summary>
        /// 
        [Display(Name = "Scribd", Description = "fa-scribd", GroupName = "brands")]
        Scribd = '\uf28a',
        
        /// <summary>
        ///     Scroll ("fa-scroll", \uf70e) icon.
        /// </summary>
        /// 
        [Display(Name = "Scroll", Description = "fa-scroll", GroupName = "duotone light regular solid")]
        Scroll = '\uf70e',
        
        /// <summary>
        ///     Sd Card ("fa-sd-card", \uf7c2) icon.
        /// </summary>
        /// 
        [Display(Name = "Sd Card", Description = "fa-sd-card", GroupName = "duotone light regular solid")]
        SdCard = '\uf7c2',
        
        /// <summary>
        ///     Search ("fa-search", \uf002) icon.
        /// </summary>
        /// 
        [Display(Name = "Search", Description = "fa-search", GroupName = "duotone light regular solid")]
        Search = '\uf002',
        
        /// <summary>
        ///     Search Dollar ("fa-search-dollar", \uf688) icon.
        /// </summary>
        /// 
        [Display(Name = "Search Dollar", Description = "fa-search-dollar", GroupName = "duotone light regular solid")]
        SearchDollar = '\uf688',
        
        /// <summary>
        ///     Searchengin ("fa-searchengin", \uf3eb) icon.
        /// </summary>
        /// 
        [Display(Name = "Searchengin", Description = "fa-searchengin", GroupName = "brands")]
        Searchengin = '\uf3eb',
        
        /// <summary>
        ///     Search Location ("fa-search-location", \uf689) icon.
        /// </summary>
        /// 
        [Display(Name = "Search Location", Description = "fa-search-location", GroupName = "duotone light regular solid")]
        SearchLocation = '\uf689',
        
        /// <summary>
        ///     Search Minus ("fa-search-minus", \uf010) icon.
        /// </summary>
        /// 
        [Display(Name = "Search Minus", Description = "fa-search-minus", GroupName = "duotone light regular solid")]
        SearchMinus = '\uf010',
        
        /// <summary>
        ///     Search Plus ("fa-search-plus", \uf00e) icon.
        /// </summary>
        /// 
        [Display(Name = "Search Plus", Description = "fa-search-plus", GroupName = "duotone light regular solid")]
        SearchPlus = '\uf00e',
        
        /// <summary>
        ///     Seedling ("fa-seedling", \uf4d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Seedling", Description = "fa-seedling", GroupName = "duotone light regular solid")]
        Seedling = '\uf4d8',
        
        /// <summary>
        ///     Sellcast ("fa-sellcast", \uf2da) icon.
        /// </summary>
        /// 
        [Display(Name = "Sellcast", Description = "fa-sellcast", GroupName = "brands")]
        Sellcast = '\uf2da',
        
        /// <summary>
        ///     Sellsy ("fa-sellsy", \uf213) icon.
        /// </summary>
        /// 
        [Display(Name = "Sellsy", Description = "fa-sellsy", GroupName = "brands")]
        Sellsy = '\uf213',
        
        /// <summary>
        ///     Server ("fa-server", \uf233) icon.
        /// </summary>
        /// 
        [Display(Name = "Server", Description = "fa-server", GroupName = "duotone light regular solid")]
        Server = '\uf233',
        
        /// <summary>
        ///     Servicestack ("fa-servicestack", \uf3ec) icon.
        /// </summary>
        /// 
        [Display(Name = "Servicestack", Description = "fa-servicestack", GroupName = "brands")]
        Servicestack = '\uf3ec',
        
        /// <summary>
        ///     Shapes ("fa-shapes", \uf61f) icon.
        /// </summary>
        /// 
        [Display(Name = "Shapes", Description = "fa-shapes", GroupName = "duotone light regular solid")]
        Shapes = '\uf61f',
        
        /// <summary>
        ///     Share ("fa-share", \uf064) icon.
        /// </summary>
        /// 
        [Display(Name = "Share", Description = "fa-share", GroupName = "duotone light regular solid")]
        Share = '\uf064',
        
        /// <summary>
        ///     Share Alt ("fa-share-alt", \uf1e0) icon.
        /// </summary>
        /// 
        [Display(Name = "Share Alt", Description = "fa-share-alt", GroupName = "duotone light regular solid")]
        ShareAlt = '\uf1e0',
        
        /// <summary>
        ///     Share Alt Square ("fa-share-alt-square", \uf1e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Share Alt Square", Description = "fa-share-alt-square", GroupName = "duotone light regular solid")]
        ShareAltSquare = '\uf1e1',
        
        /// <summary>
        ///     Share Square ("fa-share-square", \uf14d) icon.
        /// </summary>
        /// 
        [Display(Name = "Share Square", Description = "fa-share-square", GroupName = "duotone light regular solid")]
        ShareSquare = '\uf14d',
        
        /// <summary>
        ///     Shekel Sign ("fa-shekel-sign", \uf20b) icon.
        /// </summary>
        /// 
        [Display(Name = "Shekel Sign", Description = "fa-shekel-sign", GroupName = "duotone light regular solid")]
        ShekelSign = '\uf20b',
        
        /// <summary>
        ///     Shield Alt ("fa-shield-alt", \uf3ed) icon.
        /// </summary>
        /// 
        [Display(Name = "Shield Alt", Description = "fa-shield-alt", GroupName = "duotone light regular solid")]
        ShieldAlt = '\uf3ed',
        
        /// <summary>
        ///     Shield Virus ("fa-shield-virus", \uf96c) icon.
        /// </summary>
        /// 
        [Display(Name = "Shield Virus", Description = "fa-shield-virus", GroupName = "duotone light regular solid")]
        ShieldVirus = '\uf96c',
        
        /// <summary>
        ///     Ship ("fa-ship", \uf21a) icon.
        /// </summary>
        /// 
        [Display(Name = "Ship", Description = "fa-ship", GroupName = "duotone light regular solid")]
        Ship = '\uf21a',
        
        /// <summary>
        ///     Shipping Fast ("fa-shipping-fast", \uf48b) icon.
        /// </summary>
        /// 
        [Display(Name = "Shipping Fast", Description = "fa-shipping-fast", GroupName = "duotone light regular solid")]
        ShippingFast = '\uf48b',
        
        /// <summary>
        ///     Shirtsinbulk ("fa-shirtsinbulk", \uf214) icon.
        /// </summary>
        /// 
        [Display(Name = "Shirtsinbulk", Description = "fa-shirtsinbulk", GroupName = "brands")]
        Shirtsinbulk = '\uf214',
        
        /// <summary>
        ///     Shoe Prints ("fa-shoe-prints", \uf54b) icon.
        /// </summary>
        /// 
        [Display(Name = "Shoe Prints", Description = "fa-shoe-prints", GroupName = "duotone light regular solid")]
        ShoePrints = '\uf54b',
        
        /// <summary>
        ///     Shopify ("fa-shopify", \uf957) icon.
        /// </summary>
        /// 
        [Display(Name = "Shopify", Description = "fa-shopify", GroupName = "brands")]
        Shopify = '\uf957',
        
        /// <summary>
        ///     Shopping Bag ("fa-shopping-bag", \uf290) icon.
        /// </summary>
        /// 
        [Display(Name = "Shopping Bag", Description = "fa-shopping-bag", GroupName = "duotone light regular solid")]
        ShoppingBag = '\uf290',
        
        /// <summary>
        ///     Shopping Basket ("fa-shopping-basket", \uf291) icon.
        /// </summary>
        /// 
        [Display(Name = "Shopping Basket", Description = "fa-shopping-basket", GroupName = "duotone light regular solid")]
        ShoppingBasket = '\uf291',
        
        /// <summary>
        ///     Shopping Cart ("fa-shopping-cart", \uf07a) icon.
        /// </summary>
        /// 
        [Display(Name = "Shopping Cart", Description = "fa-shopping-cart", GroupName = "duotone light regular solid")]
        ShoppingCart = '\uf07a',
        
        /// <summary>
        ///     Shopware ("fa-shopware", \uf5b5) icon.
        /// </summary>
        /// 
        [Display(Name = "Shopware", Description = "fa-shopware", GroupName = "brands")]
        Shopware = '\uf5b5',
        
        /// <summary>
        ///     Shower ("fa-shower", \uf2cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Shower", Description = "fa-shower", GroupName = "duotone light regular solid")]
        Shower = '\uf2cc',
        
        /// <summary>
        ///     Shuttle Van ("fa-shuttle-van", \uf5b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Shuttle Van", Description = "fa-shuttle-van", GroupName = "duotone light regular solid")]
        ShuttleVan = '\uf5b6',
        
        /// <summary>
        ///     Sign ("fa-sign", \uf4d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Sign", Description = "fa-sign", GroupName = "duotone light regular solid")]
        Sign = '\uf4d9',
        
        /// <summary>
        ///     Signal ("fa-signal", \uf012) icon.
        /// </summary>
        /// 
        [Display(Name = "Signal", Description = "fa-signal", GroupName = "duotone light regular solid")]
        Signal = '\uf012',
        
        /// <summary>
        ///     Signature ("fa-signature", \uf5b7) icon.
        /// </summary>
        /// 
        [Display(Name = "Signature", Description = "fa-signature", GroupName = "duotone light regular solid")]
        Signature = '\uf5b7',
        
        /// <summary>
        ///     Sign In Alt ("fa-sign-in-alt", \uf2f6) icon.
        /// </summary>
        /// 
        [Display(Name = "Sign In Alt", Description = "fa-sign-in-alt", GroupName = "duotone light regular solid")]
        SignInAlt = '\uf2f6',
        
        /// <summary>
        ///     Sign Language ("fa-sign-language", \uf2a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Sign Language", Description = "fa-sign-language", GroupName = "duotone light regular solid")]
        SignLanguage = '\uf2a7',
        
        /// <summary>
        ///     Sign Out Alt ("fa-sign-out-alt", \uf2f5) icon.
        /// </summary>
        /// 
        [Display(Name = "Sign Out Alt", Description = "fa-sign-out-alt", GroupName = "duotone light regular solid")]
        SignOutAlt = '\uf2f5',
        
        /// <summary>
        ///     Sim Card ("fa-sim-card", \uf7c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Sim Card", Description = "fa-sim-card", GroupName = "duotone light regular solid")]
        SimCard = '\uf7c4',
        
        /// <summary>
        ///     Simplybuilt ("fa-simplybuilt", \uf215) icon.
        /// </summary>
        /// 
        [Display(Name = "Simplybuilt", Description = "fa-simplybuilt", GroupName = "brands")]
        Simplybuilt = '\uf215',
        
        /// <summary>
        ///     Sistrix ("fa-sistrix", \uf3ee) icon.
        /// </summary>
        /// 
        [Display(Name = "Sistrix", Description = "fa-sistrix", GroupName = "brands")]
        Sistrix = '\uf3ee',
        
        /// <summary>
        ///     Sitemap ("fa-sitemap", \uf0e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Sitemap", Description = "fa-sitemap", GroupName = "duotone light regular solid")]
        Sitemap = '\uf0e8',
        
        /// <summary>
        ///     Sith ("fa-sith", \uf512) icon.
        /// </summary>
        /// 
        [Display(Name = "Sith", Description = "fa-sith", GroupName = "brands")]
        Sith = '\uf512',
        
        /// <summary>
        ///     Skating ("fa-skating", \uf7c5) icon.
        /// </summary>
        /// 
        [Display(Name = "Skating", Description = "fa-skating", GroupName = "duotone light regular solid")]
        Skating = '\uf7c5',
        
        /// <summary>
        ///     Sketch ("fa-sketch", \uf7c6) icon.
        /// </summary>
        /// 
        [Display(Name = "Sketch", Description = "fa-sketch", GroupName = "brands")]
        Sketch = '\uf7c6',
        
        /// <summary>
        ///     Skiing ("fa-skiing", \uf7c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Skiing", Description = "fa-skiing", GroupName = "duotone light regular solid")]
        Skiing = '\uf7c9',
        
        /// <summary>
        ///     Skiing Nordic ("fa-skiing-nordic", \uf7ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Skiing Nordic", Description = "fa-skiing-nordic", GroupName = "duotone light regular solid")]
        SkiingNordic = '\uf7ca',
        
        /// <summary>
        ///     Skull ("fa-skull", \uf54c) icon.
        /// </summary>
        /// 
        [Display(Name = "Skull", Description = "fa-skull", GroupName = "duotone light regular solid")]
        Skull = '\uf54c',
        
        /// <summary>
        ///     Skull Crossbones ("fa-skull-crossbones", \uf714) icon.
        /// </summary>
        /// 
        [Display(Name = "Skull Crossbones", Description = "fa-skull-crossbones", GroupName = "duotone light regular solid")]
        SkullCrossbones = '\uf714',
        
        /// <summary>
        ///     Skyatlas ("fa-skyatlas", \uf216) icon.
        /// </summary>
        /// 
        [Display(Name = "Skyatlas", Description = "fa-skyatlas", GroupName = "brands")]
        Skyatlas = '\uf216',
        
        /// <summary>
        ///     Skype ("fa-skype", \uf17e) icon.
        /// </summary>
        /// 
        [Display(Name = "Skype", Description = "fa-skype", GroupName = "brands")]
        Skype = '\uf17e',
        
        /// <summary>
        ///     Slack ("fa-slack", \uf198) icon.
        /// </summary>
        /// 
        [Display(Name = "Slack", Description = "fa-slack", GroupName = "brands")]
        Slack = '\uf198',
        
        /// <summary>
        ///     Slack Hash ("fa-slack-hash", \uf3ef) icon.
        /// </summary>
        /// 
        [Display(Name = "Slack Hash", Description = "fa-slack-hash", GroupName = "brands")]
        SlackHash = '\uf3ef',
        
        /// <summary>
        ///     Slash ("fa-slash", \uf715) icon.
        /// </summary>
        /// 
        [Display(Name = "Slash", Description = "fa-slash", GroupName = "duotone light regular solid")]
        Slash = '\uf715',
        
        /// <summary>
        ///     Sleigh ("fa-sleigh", \uf7cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Sleigh", Description = "fa-sleigh", GroupName = "duotone light regular solid")]
        Sleigh = '\uf7cc',
        
        /// <summary>
        ///     Sliders H ("fa-sliders-h", \uf1de) icon.
        /// </summary>
        /// 
        [Display(Name = "Sliders H", Description = "fa-sliders-h", GroupName = "duotone light regular solid")]
        SlidersH = '\uf1de',
        
        /// <summary>
        ///     Slideshare ("fa-slideshare", \uf1e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Slideshare", Description = "fa-slideshare", GroupName = "brands")]
        Slideshare = '\uf1e7',
        
        /// <summary>
        ///     Smile ("fa-smile", \uf118) icon.
        /// </summary>
        /// 
        [Display(Name = "Smile", Description = "fa-smile", GroupName = "duotone light regular solid")]
        Smile = '\uf118',
        
        /// <summary>
        ///     Smile Beam ("fa-smile-beam", \uf5b8) icon.
        /// </summary>
        /// 
        [Display(Name = "Smile Beam", Description = "fa-smile-beam", GroupName = "duotone light regular solid")]
        SmileBeam = '\uf5b8',
        
        /// <summary>
        ///     Smile Wink ("fa-smile-wink", \uf4da) icon.
        /// </summary>
        /// 
        [Display(Name = "Smile Wink", Description = "fa-smile-wink", GroupName = "duotone light regular solid")]
        SmileWink = '\uf4da',
        
        /// <summary>
        ///     Smog ("fa-smog", \uf75f) icon.
        /// </summary>
        /// 
        [Display(Name = "Smog", Description = "fa-smog", GroupName = "duotone light regular solid")]
        Smog = '\uf75f',
        
        /// <summary>
        ///     Smoking ("fa-smoking", \uf48d) icon.
        /// </summary>
        /// 
        [Display(Name = "Smoking", Description = "fa-smoking", GroupName = "duotone light regular solid")]
        Smoking = '\uf48d',
        
        /// <summary>
        ///     Smoking Ban ("fa-smoking-ban", \uf54d) icon.
        /// </summary>
        /// 
        [Display(Name = "Smoking Ban", Description = "fa-smoking-ban", GroupName = "duotone light regular solid")]
        SmokingBan = '\uf54d',
        
        /// <summary>
        ///     Sms ("fa-sms", \uf7cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Sms", Description = "fa-sms", GroupName = "duotone light regular solid")]
        Sms = '\uf7cd',
        
        /// <summary>
        ///     Snapchat ("fa-snapchat", \uf2ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Snapchat", Description = "fa-snapchat", GroupName = "brands")]
        Snapchat = '\uf2ab',
        
        /// <summary>
        ///     Snapchat Ghost ("fa-snapchat-ghost", \uf2ac) icon.
        /// </summary>
        /// 
        [Display(Name = "Snapchat Ghost", Description = "fa-snapchat-ghost", GroupName = "brands")]
        SnapchatGhost = '\uf2ac',
        
        /// <summary>
        ///     Snapchat Square ("fa-snapchat-square", \uf2ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Snapchat Square", Description = "fa-snapchat-square", GroupName = "brands")]
        SnapchatSquare = '\uf2ad',
        
        /// <summary>
        ///     Snowboarding ("fa-snowboarding", \uf7ce) icon.
        /// </summary>
        /// 
        [Display(Name = "Snowboarding", Description = "fa-snowboarding", GroupName = "duotone light regular solid")]
        Snowboarding = '\uf7ce',
        
        /// <summary>
        ///     Snowflake ("fa-snowflake", \uf2dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Snowflake", Description = "fa-snowflake", GroupName = "duotone light regular solid")]
        Snowflake = '\uf2dc',
        
        /// <summary>
        ///     Snowman ("fa-snowman", \uf7d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Snowman", Description = "fa-snowman", GroupName = "duotone light regular solid")]
        Snowman = '\uf7d0',
        
        /// <summary>
        ///     Snowplow ("fa-snowplow", \uf7d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Snowplow", Description = "fa-snowplow", GroupName = "duotone light regular solid")]
        Snowplow = '\uf7d2',
        
        /// <summary>
        ///     Soap ("fa-soap", \uf96e) icon.
        /// </summary>
        /// 
        [Display(Name = "Soap", Description = "fa-soap", GroupName = "duotone light regular solid")]
        Soap = '\uf96e',
        
        /// <summary>
        ///     Socks ("fa-socks", \uf696) icon.
        /// </summary>
        /// 
        [Display(Name = "Socks", Description = "fa-socks", GroupName = "duotone light regular solid")]
        Socks = '\uf696',
        
        /// <summary>
        ///     Solar Panel ("fa-solar-panel", \uf5ba) icon.
        /// </summary>
        /// 
        [Display(Name = "Solar Panel", Description = "fa-solar-panel", GroupName = "duotone light regular solid")]
        SolarPanel = '\uf5ba',
        
        /// <summary>
        ///     Sort ("fa-sort", \uf0dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort", Description = "fa-sort", GroupName = "duotone light regular solid")]
        Sort = '\uf0dc',
        
        /// <summary>
        ///     Sort Alpha Down ("fa-sort-alpha-down", \uf15d) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Alpha Down", Description = "fa-sort-alpha-down", GroupName = "duotone light regular solid")]
        SortAlphaDown = '\uf15d',
        
        /// <summary>
        ///     Sort Alpha Down Alt ("fa-sort-alpha-down-alt", \uf881) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Alpha Down Alt", Description = "fa-sort-alpha-down-alt", GroupName = "duotone light regular solid")]
        SortAlphaDownAlt = '\uf881',
        
        /// <summary>
        ///     Sort Alpha Up ("fa-sort-alpha-up", \uf15e) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Alpha Up", Description = "fa-sort-alpha-up", GroupName = "duotone light regular solid")]
        SortAlphaUp = '\uf15e',
        
        /// <summary>
        ///     Sort Alpha Up Alt ("fa-sort-alpha-up-alt", \uf882) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Alpha Up Alt", Description = "fa-sort-alpha-up-alt", GroupName = "duotone light regular solid")]
        SortAlphaUpAlt = '\uf882',
        
        /// <summary>
        ///     Sort Amount Down ("fa-sort-amount-down", \uf160) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Amount Down", Description = "fa-sort-amount-down", GroupName = "duotone light regular solid")]
        SortAmountDown = '\uf160',
        
        /// <summary>
        ///     Sort Amount Down Alt ("fa-sort-amount-down-alt", \uf884) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Amount Down Alt", Description = "fa-sort-amount-down-alt", GroupName = "duotone light regular solid")]
        SortAmountDownAlt = '\uf884',
        
        /// <summary>
        ///     Sort Amount Up ("fa-sort-amount-up", \uf161) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Amount Up", Description = "fa-sort-amount-up", GroupName = "duotone light regular solid")]
        SortAmountUp = '\uf161',
        
        /// <summary>
        ///     Sort Amount Up Alt ("fa-sort-amount-up-alt", \uf885) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Amount Up Alt", Description = "fa-sort-amount-up-alt", GroupName = "duotone light regular solid")]
        SortAmountUpAlt = '\uf885',
        
        /// <summary>
        ///     Sort Down ("fa-sort-down", \uf0dd) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Down", Description = "fa-sort-down", GroupName = "duotone light regular solid")]
        SortDown = '\uf0dd',
        
        /// <summary>
        ///     Sort Numeric Down ("fa-sort-numeric-down", \uf162) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Numeric Down", Description = "fa-sort-numeric-down", GroupName = "duotone light regular solid")]
        SortNumericDown = '\uf162',
        
        /// <summary>
        ///     Sort Numeric Down Alt ("fa-sort-numeric-down-alt", \uf886) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Numeric Down Alt", Description = "fa-sort-numeric-down-alt", GroupName = "duotone light regular solid")]
        SortNumericDownAlt = '\uf886',
        
        /// <summary>
        ///     Sort Numeric Up ("fa-sort-numeric-up", \uf163) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Numeric Up", Description = "fa-sort-numeric-up", GroupName = "duotone light regular solid")]
        SortNumericUp = '\uf163',
        
        /// <summary>
        ///     Sort Numeric Up Alt ("fa-sort-numeric-up-alt", \uf887) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Numeric Up Alt", Description = "fa-sort-numeric-up-alt", GroupName = "duotone light regular solid")]
        SortNumericUpAlt = '\uf887',
        
        /// <summary>
        ///     Sort Up ("fa-sort-up", \uf0de) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Up", Description = "fa-sort-up", GroupName = "duotone light regular solid")]
        SortUp = '\uf0de',
        
        /// <summary>
        ///     Soundcloud ("fa-soundcloud", \uf1be) icon.
        /// </summary>
        /// 
        [Display(Name = "Soundcloud", Description = "fa-soundcloud", GroupName = "brands")]
        Soundcloud = '\uf1be',
        
        /// <summary>
        ///     Sourcetree ("fa-sourcetree", \uf7d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Sourcetree", Description = "fa-sourcetree", GroupName = "brands")]
        Sourcetree = '\uf7d3',
        
        /// <summary>
        ///     Spa ("fa-spa", \uf5bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Spa", Description = "fa-spa", GroupName = "duotone light regular solid")]
        Spa = '\uf5bb',
        
        /// <summary>
        ///     Space Shuttle ("fa-space-shuttle", \uf197) icon.
        /// </summary>
        /// 
        [Display(Name = "Space Shuttle", Description = "fa-space-shuttle", GroupName = "duotone light regular solid")]
        SpaceShuttle = '\uf197',
        
        /// <summary>
        ///     Speakap ("fa-speakap", \uf3f3) icon.
        /// </summary>
        /// 
        [Display(Name = "Speakap", Description = "fa-speakap", GroupName = "brands")]
        Speakap = '\uf3f3',
        
        /// <summary>
        ///     Speaker Deck ("fa-speaker-deck", \uf83c) icon.
        /// </summary>
        /// 
        [Display(Name = "Speaker Deck", Description = "fa-speaker-deck", GroupName = "brands")]
        SpeakerDeck = '\uf83c',
        
        /// <summary>
        ///     Spell Check ("fa-spell-check", \uf891) icon.
        /// </summary>
        /// 
        [Display(Name = "Spell Check", Description = "fa-spell-check", GroupName = "duotone light regular solid")]
        SpellCheck = '\uf891',
        
        /// <summary>
        ///     Spider ("fa-spider", \uf717) icon.
        /// </summary>
        /// 
        [Display(Name = "Spider", Description = "fa-spider", GroupName = "duotone light regular solid")]
        Spider = '\uf717',
        
        /// <summary>
        ///     Spinner ("fa-spinner", \uf110) icon.
        /// </summary>
        /// 
        [Display(Name = "Spinner", Description = "fa-spinner", GroupName = "duotone light regular solid")]
        Spinner = '\uf110',
        
        /// <summary>
        ///     Splotch ("fa-splotch", \uf5bc) icon.
        /// </summary>
        /// 
        [Display(Name = "Splotch", Description = "fa-splotch", GroupName = "duotone light regular solid")]
        Splotch = '\uf5bc',
        
        /// <summary>
        ///     Spotify ("fa-spotify", \uf1bc) icon.
        /// </summary>
        /// 
        [Display(Name = "Spotify", Description = "fa-spotify", GroupName = "brands")]
        Spotify = '\uf1bc',
        
        /// <summary>
        ///     Spray Can ("fa-spray-can", \uf5bd) icon.
        /// </summary>
        /// 
        [Display(Name = "Spray Can", Description = "fa-spray-can", GroupName = "duotone light regular solid")]
        SprayCan = '\uf5bd',
        
        /// <summary>
        ///     Square ("fa-square", \uf0c8) icon.
        /// </summary>
        /// 
        [Display(Name = "Square", Description = "fa-square", GroupName = "duotone light regular solid")]
        Square = '\uf0c8',
        
        /// <summary>
        ///     Square Full ("fa-square-full", \uf45c) icon.
        /// </summary>
        /// 
        [Display(Name = "Square Full", Description = "fa-square-full", GroupName = "duotone light regular solid")]
        SquareFull = '\uf45c',
        
        /// <summary>
        ///     Square Root Alt ("fa-square-root-alt", \uf698) icon.
        /// </summary>
        /// 
        [Display(Name = "Square Root Alt", Description = "fa-square-root-alt", GroupName = "duotone light regular solid")]
        SquareRootAlt = '\uf698',
        
        /// <summary>
        ///     Squarespace ("fa-squarespace", \uf5be) icon.
        /// </summary>
        /// 
        [Display(Name = "Squarespace", Description = "fa-squarespace", GroupName = "brands")]
        Squarespace = '\uf5be',
        
        /// <summary>
        ///     Stack Exchange ("fa-stack-exchange", \uf18d) icon.
        /// </summary>
        /// 
        [Display(Name = "Stack Exchange", Description = "fa-stack-exchange", GroupName = "brands")]
        StackExchange = '\uf18d',
        
        /// <summary>
        ///     Stack Overflow ("fa-stack-overflow", \uf16c) icon.
        /// </summary>
        /// 
        [Display(Name = "Stack Overflow", Description = "fa-stack-overflow", GroupName = "brands")]
        StackOverflow = '\uf16c',
        
        /// <summary>
        ///     Stackpath ("fa-stackpath", \uf842) icon.
        /// </summary>
        /// 
        [Display(Name = "Stackpath", Description = "fa-stackpath", GroupName = "brands")]
        Stackpath = '\uf842',
        
        /// <summary>
        ///     Stamp ("fa-stamp", \uf5bf) icon.
        /// </summary>
        /// 
        [Display(Name = "Stamp", Description = "fa-stamp", GroupName = "duotone light regular solid")]
        Stamp = '\uf5bf',
        
        /// <summary>
        ///     Star ("fa-star", \uf005) icon.
        /// </summary>
        /// 
        [Display(Name = "Star", Description = "fa-star", GroupName = "duotone light regular solid")]
        Star = '\uf005',
        
        /// <summary>
        ///     Star And Crescent ("fa-star-and-crescent", \uf699) icon.
        /// </summary>
        /// 
        [Display(Name = "Star And Crescent", Description = "fa-star-and-crescent", GroupName = "duotone light regular solid")]
        StarAndCrescent = '\uf699',
        
        /// <summary>
        ///     Star Half ("fa-star-half", \uf089) icon.
        /// </summary>
        /// 
        [Display(Name = "Star Half", Description = "fa-star-half", GroupName = "duotone light regular solid")]
        StarHalf = '\uf089',
        
        /// <summary>
        ///     Star Half Alt ("fa-star-half-alt", \uf5c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Star Half Alt", Description = "fa-star-half-alt", GroupName = "duotone light regular solid")]
        StarHalfAlt = '\uf5c0',
        
        /// <summary>
        ///     Star Of David ("fa-star-of-david", \uf69a) icon.
        /// </summary>
        /// 
        [Display(Name = "Star Of David", Description = "fa-star-of-david", GroupName = "duotone light regular solid")]
        StarOfDavid = '\uf69a',
        
        /// <summary>
        ///     Star Of Life ("fa-star-of-life", \uf621) icon.
        /// </summary>
        /// 
        [Display(Name = "Star Of Life", Description = "fa-star-of-life", GroupName = "duotone light regular solid")]
        StarOfLife = '\uf621',
        
        /// <summary>
        ///     Staylinked ("fa-staylinked", \uf3f5) icon.
        /// </summary>
        /// 
        [Display(Name = "Staylinked", Description = "fa-staylinked", GroupName = "brands")]
        Staylinked = '\uf3f5',
        
        /// <summary>
        ///     Steam ("fa-steam", \uf1b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Steam", Description = "fa-steam", GroupName = "brands")]
        Steam = '\uf1b6',
        
        /// <summary>
        ///     Steam Square ("fa-steam-square", \uf1b7) icon.
        /// </summary>
        /// 
        [Display(Name = "Steam Square", Description = "fa-steam-square", GroupName = "brands")]
        SteamSquare = '\uf1b7',
        
        /// <summary>
        ///     Steam Symbol ("fa-steam-symbol", \uf3f6) icon.
        /// </summary>
        /// 
        [Display(Name = "Steam Symbol", Description = "fa-steam-symbol", GroupName = "brands")]
        SteamSymbol = '\uf3f6',
        
        /// <summary>
        ///     Step Backward ("fa-step-backward", \uf048) icon.
        /// </summary>
        /// 
        [Display(Name = "Step Backward", Description = "fa-step-backward", GroupName = "duotone light regular solid")]
        StepBackward = '\uf048',
        
        /// <summary>
        ///     Step Forward ("fa-step-forward", \uf051) icon.
        /// </summary>
        /// 
        [Display(Name = "Step Forward", Description = "fa-step-forward", GroupName = "duotone light regular solid")]
        StepForward = '\uf051',
        
        /// <summary>
        ///     Stethoscope ("fa-stethoscope", \uf0f1) icon.
        /// </summary>
        /// 
        [Display(Name = "Stethoscope", Description = "fa-stethoscope", GroupName = "duotone light regular solid")]
        Stethoscope = '\uf0f1',
        
        /// <summary>
        ///     Sticker Mule ("fa-sticker-mule", \uf3f7) icon.
        /// </summary>
        /// 
        [Display(Name = "Sticker Mule", Description = "fa-sticker-mule", GroupName = "brands")]
        StickerMule = '\uf3f7',
        
        /// <summary>
        ///     Sticky Note ("fa-sticky-note", \uf249) icon.
        /// </summary>
        /// 
        [Display(Name = "Sticky Note", Description = "fa-sticky-note", GroupName = "duotone light regular solid")]
        StickyNote = '\uf249',
        
        /// <summary>
        ///     Stop ("fa-stop", \uf04d) icon.
        /// </summary>
        /// 
        [Display(Name = "Stop", Description = "fa-stop", GroupName = "duotone light regular solid")]
        Stop = '\uf04d',
        
        /// <summary>
        ///     Stop Circle ("fa-stop-circle", \uf28d) icon.
        /// </summary>
        /// 
        [Display(Name = "Stop Circle", Description = "fa-stop-circle", GroupName = "duotone light regular solid")]
        StopCircle = '\uf28d',
        
        /// <summary>
        ///     Stopwatch ("fa-stopwatch", \uf2f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Stopwatch", Description = "fa-stopwatch", GroupName = "duotone light regular solid")]
        Stopwatch = '\uf2f2',
        
        /// <summary>
        ///     Stopwatch 20 ("fa-stopwatch-20", \uf96f) icon.
        /// </summary>
        /// 
        [Display(Name = "Stopwatch 20", Description = "fa-stopwatch-20", GroupName = "duotone light regular solid")]
        Stopwatch20 = '\uf96f',
        
        /// <summary>
        ///     Store ("fa-store", \uf54e) icon.
        /// </summary>
        /// 
        [Display(Name = "Store", Description = "fa-store", GroupName = "duotone light regular solid")]
        Store = '\uf54e',
        
        /// <summary>
        ///     Store Alt ("fa-store-alt", \uf54f) icon.
        /// </summary>
        /// 
        [Display(Name = "Store Alt", Description = "fa-store-alt", GroupName = "duotone light regular solid")]
        StoreAlt = '\uf54f',
        
        /// <summary>
        ///     Store Alt Slash ("fa-store-alt-slash", \uf970) icon.
        /// </summary>
        /// 
        [Display(Name = "Store Alt Slash", Description = "fa-store-alt-slash", GroupName = "duotone light regular solid")]
        StoreAltSlash = '\uf970',
        
        /// <summary>
        ///     Store Slash ("fa-store-slash", \uf971) icon.
        /// </summary>
        /// 
        [Display(Name = "Store Slash", Description = "fa-store-slash", GroupName = "duotone light regular solid")]
        StoreSlash = '\uf971',
        
        /// <summary>
        ///     Strava ("fa-strava", \uf428) icon.
        /// </summary>
        /// 
        [Display(Name = "Strava", Description = "fa-strava", GroupName = "brands")]
        Strava = '\uf428',
        
        /// <summary>
        ///     Stream ("fa-stream", \uf550) icon.
        /// </summary>
        /// 
        [Display(Name = "Stream", Description = "fa-stream", GroupName = "duotone light regular solid")]
        Stream = '\uf550',
        
        /// <summary>
        ///     Street View ("fa-street-view", \uf21d) icon.
        /// </summary>
        /// 
        [Display(Name = "Street View", Description = "fa-street-view", GroupName = "duotone light regular solid")]
        StreetView = '\uf21d',
        
        /// <summary>
        ///     Strikethrough ("fa-strikethrough", \uf0cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Strikethrough", Description = "fa-strikethrough", GroupName = "duotone light regular solid")]
        Strikethrough = '\uf0cc',
        
        /// <summary>
        ///     Stripe ("fa-stripe", \uf429) icon.
        /// </summary>
        /// 
        [Display(Name = "Stripe", Description = "fa-stripe", GroupName = "brands")]
        Stripe = '\uf429',
        
        /// <summary>
        ///     Stripe S ("fa-stripe-s", \uf42a) icon.
        /// </summary>
        /// 
        [Display(Name = "Stripe S", Description = "fa-stripe-s", GroupName = "brands")]
        StripeS = '\uf42a',
        
        /// <summary>
        ///     Stroopwafel ("fa-stroopwafel", \uf551) icon.
        /// </summary>
        /// 
        [Display(Name = "Stroopwafel", Description = "fa-stroopwafel", GroupName = "duotone light regular solid")]
        Stroopwafel = '\uf551',
        
        /// <summary>
        ///     Studiovinari ("fa-studiovinari", \uf3f8) icon.
        /// </summary>
        /// 
        [Display(Name = "Studiovinari", Description = "fa-studiovinari", GroupName = "brands")]
        Studiovinari = '\uf3f8',
        
        /// <summary>
        ///     Stumbleupon ("fa-stumbleupon", \uf1a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Stumbleupon", Description = "fa-stumbleupon", GroupName = "brands")]
        Stumbleupon = '\uf1a4',
        
        /// <summary>
        ///     Stumbleupon Circle ("fa-stumbleupon-circle", \uf1a3) icon.
        /// </summary>
        /// 
        [Display(Name = "Stumbleupon Circle", Description = "fa-stumbleupon-circle", GroupName = "brands")]
        StumbleuponCircle = '\uf1a3',
        
        /// <summary>
        ///     Subscript ("fa-subscript", \uf12c) icon.
        /// </summary>
        /// 
        [Display(Name = "Subscript", Description = "fa-subscript", GroupName = "duotone light regular solid")]
        Subscript = '\uf12c',
        
        /// <summary>
        ///     Subway ("fa-subway", \uf239) icon.
        /// </summary>
        /// 
        [Display(Name = "Subway", Description = "fa-subway", GroupName = "duotone light regular solid")]
        Subway = '\uf239',
        
        /// <summary>
        ///     Suitcase ("fa-suitcase", \uf0f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Suitcase", Description = "fa-suitcase", GroupName = "duotone light regular solid")]
        Suitcase = '\uf0f2',
        
        /// <summary>
        ///     Suitcase Rolling ("fa-suitcase-rolling", \uf5c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Suitcase Rolling", Description = "fa-suitcase-rolling", GroupName = "duotone light regular solid")]
        SuitcaseRolling = '\uf5c1',
        
        /// <summary>
        ///     Sun ("fa-sun", \uf185) icon.
        /// </summary>
        /// 
        [Display(Name = "Sun", Description = "fa-sun", GroupName = "duotone light regular solid")]
        Sun = '\uf185',
        
        /// <summary>
        ///     Superpowers ("fa-superpowers", \uf2dd) icon.
        /// </summary>
        /// 
        [Display(Name = "Superpowers", Description = "fa-superpowers", GroupName = "brands")]
        Superpowers = '\uf2dd',
        
        /// <summary>
        ///     Superscript ("fa-superscript", \uf12b) icon.
        /// </summary>
        /// 
        [Display(Name = "Superscript", Description = "fa-superscript", GroupName = "duotone light regular solid")]
        Superscript = '\uf12b',
        
        /// <summary>
        ///     Supple ("fa-supple", \uf3f9) icon.
        /// </summary>
        /// 
        [Display(Name = "Supple", Description = "fa-supple", GroupName = "brands")]
        Supple = '\uf3f9',
        
        /// <summary>
        ///     Surprise ("fa-surprise", \uf5c2) icon.
        /// </summary>
        /// 
        [Display(Name = "Surprise", Description = "fa-surprise", GroupName = "duotone light regular solid")]
        Surprise = '\uf5c2',
        
        /// <summary>
        ///     Suse ("fa-suse", \uf7d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Suse", Description = "fa-suse", GroupName = "brands")]
        Suse = '\uf7d6',
        
        /// <summary>
        ///     Swatchbook ("fa-swatchbook", \uf5c3) icon.
        /// </summary>
        /// 
        [Display(Name = "Swatchbook", Description = "fa-swatchbook", GroupName = "duotone light regular solid")]
        Swatchbook = '\uf5c3',
        
        /// <summary>
        ///     Swift ("fa-swift", \uf8e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Swift", Description = "fa-swift", GroupName = "brands")]
        Swift = '\uf8e1',
        
        /// <summary>
        ///     Swimmer ("fa-swimmer", \uf5c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Swimmer", Description = "fa-swimmer", GroupName = "duotone light regular solid")]
        Swimmer = '\uf5c4',
        
        /// <summary>
        ///     Swimming Pool ("fa-swimming-pool", \uf5c5) icon.
        /// </summary>
        /// 
        [Display(Name = "Swimming Pool", Description = "fa-swimming-pool", GroupName = "duotone light regular solid")]
        SwimmingPool = '\uf5c5',
        
        /// <summary>
        ///     Symfony ("fa-symfony", \uf83d) icon.
        /// </summary>
        /// 
        [Display(Name = "Symfony", Description = "fa-symfony", GroupName = "brands")]
        Symfony = '\uf83d',
        
        /// <summary>
        ///     Synagogue ("fa-synagogue", \uf69b) icon.
        /// </summary>
        /// 
        [Display(Name = "Synagogue", Description = "fa-synagogue", GroupName = "duotone light regular solid")]
        Synagogue = '\uf69b',
        
        /// <summary>
        ///     Sync ("fa-sync", \uf021) icon.
        /// </summary>
        /// 
        [Display(Name = "Sync", Description = "fa-sync", GroupName = "duotone light regular solid")]
        Sync = '\uf021',
        
        /// <summary>
        ///     Sync Alt ("fa-sync-alt", \uf2f1) icon.
        /// </summary>
        /// 
        [Display(Name = "Sync Alt", Description = "fa-sync-alt", GroupName = "duotone light regular solid")]
        SyncAlt = '\uf2f1',
        
        /// <summary>
        ///     Syringe ("fa-syringe", \uf48e) icon.
        /// </summary>
        /// 
        [Display(Name = "Syringe", Description = "fa-syringe", GroupName = "duotone light regular solid")]
        Syringe = '\uf48e',
        
        /// <summary>
        ///     Table ("fa-table", \uf0ce) icon.
        /// </summary>
        /// 
        [Display(Name = "Table", Description = "fa-table", GroupName = "duotone light regular solid")]
        Table = '\uf0ce',
        
        /// <summary>
        ///     Tablet ("fa-tablet", \uf10a) icon.
        /// </summary>
        /// 
        [Display(Name = "Tablet", Description = "fa-tablet", GroupName = "duotone light regular solid")]
        Tablet = '\uf10a',
        
        /// <summary>
        ///     Tablet Alt ("fa-tablet-alt", \uf3fa) icon.
        /// </summary>
        /// 
        [Display(Name = "Tablet Alt", Description = "fa-tablet-alt", GroupName = "duotone light regular solid")]
        TabletAlt = '\uf3fa',
        
        /// <summary>
        ///     Table Tennis ("fa-table-tennis", \uf45d) icon.
        /// </summary>
        /// 
        [Display(Name = "Table Tennis", Description = "fa-table-tennis", GroupName = "duotone light regular solid")]
        TableTennis = '\uf45d',
        
        /// <summary>
        ///     Tablets ("fa-tablets", \uf490) icon.
        /// </summary>
        /// 
        [Display(Name = "Tablets", Description = "fa-tablets", GroupName = "duotone light regular solid")]
        Tablets = '\uf490',
        
        /// <summary>
        ///     Tachometer Alt ("fa-tachometer-alt", \uf3fd) icon.
        /// </summary>
        /// 
        [Display(Name = "Tachometer Alt", Description = "fa-tachometer-alt", GroupName = "duotone light regular solid")]
        TachometerAlt = '\uf3fd',
        
        /// <summary>
        ///     Tag ("fa-tag", \uf02b) icon.
        /// </summary>
        /// 
        [Display(Name = "Tag", Description = "fa-tag", GroupName = "duotone light regular solid")]
        Tag = '\uf02b',
        
        /// <summary>
        ///     Tags ("fa-tags", \uf02c) icon.
        /// </summary>
        /// 
        [Display(Name = "Tags", Description = "fa-tags", GroupName = "duotone light regular solid")]
        Tags = '\uf02c',
        
        /// <summary>
        ///     Tape ("fa-tape", \uf4db) icon.
        /// </summary>
        /// 
        [Display(Name = "Tape", Description = "fa-tape", GroupName = "duotone light regular solid")]
        Tape = '\uf4db',
        
        /// <summary>
        ///     Tasks ("fa-tasks", \uf0ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Tasks", Description = "fa-tasks", GroupName = "duotone light regular solid")]
        Tasks = '\uf0ae',
        
        /// <summary>
        ///     Taxi ("fa-taxi", \uf1ba) icon.
        /// </summary>
        /// 
        [Display(Name = "Taxi", Description = "fa-taxi", GroupName = "duotone light regular solid")]
        Taxi = '\uf1ba',
        
        /// <summary>
        ///     Teamspeak ("fa-teamspeak", \uf4f9) icon.
        /// </summary>
        /// 
        [Display(Name = "Teamspeak", Description = "fa-teamspeak", GroupName = "brands")]
        Teamspeak = '\uf4f9',
        
        /// <summary>
        ///     Teeth ("fa-teeth", \uf62e) icon.
        /// </summary>
        /// 
        [Display(Name = "Teeth", Description = "fa-teeth", GroupName = "duotone light regular solid")]
        Teeth = '\uf62e',
        
        /// <summary>
        ///     Teeth Open ("fa-teeth-open", \uf62f) icon.
        /// </summary>
        /// 
        [Display(Name = "Teeth Open", Description = "fa-teeth-open", GroupName = "duotone light regular solid")]
        TeethOpen = '\uf62f',
        
        /// <summary>
        ///     Telegram ("fa-telegram", \uf2c6) icon.
        /// </summary>
        /// 
        [Display(Name = "Telegram", Description = "fa-telegram", GroupName = "brands")]
        Telegram = '\uf2c6',
        
        /// <summary>
        ///     Telegram Plane ("fa-telegram-plane", \uf3fe) icon.
        /// </summary>
        /// 
        [Display(Name = "Telegram Plane", Description = "fa-telegram-plane", GroupName = "brands")]
        TelegramPlane = '\uf3fe',
        
        /// <summary>
        ///     Temperature High ("fa-temperature-high", \uf769) icon.
        /// </summary>
        /// 
        [Display(Name = "Temperature High", Description = "fa-temperature-high", GroupName = "duotone light regular solid")]
        TemperatureHigh = '\uf769',
        
        /// <summary>
        ///     Temperature Low ("fa-temperature-low", \uf76b) icon.
        /// </summary>
        /// 
        [Display(Name = "Temperature Low", Description = "fa-temperature-low", GroupName = "duotone light regular solid")]
        TemperatureLow = '\uf76b',
        
        /// <summary>
        ///     Tencent Weibo ("fa-tencent-weibo", \uf1d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Tencent Weibo", Description = "fa-tencent-weibo", GroupName = "brands")]
        TencentWeibo = '\uf1d5',
        
        /// <summary>
        ///     Tenge ("fa-tenge", \uf7d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Tenge", Description = "fa-tenge", GroupName = "duotone light regular solid")]
        Tenge = '\uf7d7',
        
        /// <summary>
        ///     Terminal ("fa-terminal", \uf120) icon.
        /// </summary>
        /// 
        [Display(Name = "Terminal", Description = "fa-terminal", GroupName = "duotone light regular solid")]
        Terminal = '\uf120',
        
        /// <summary>
        ///     Text Height ("fa-text-height", \uf034) icon.
        /// </summary>
        /// 
        [Display(Name = "Text Height", Description = "fa-text-height", GroupName = "duotone light regular solid")]
        TextHeight = '\uf034',
        
        /// <summary>
        ///     Text Width ("fa-text-width", \uf035) icon.
        /// </summary>
        /// 
        [Display(Name = "Text Width", Description = "fa-text-width", GroupName = "duotone light regular solid")]
        TextWidth = '\uf035',
        
        /// <summary>
        ///     Th ("fa-th", \uf00a) icon.
        /// </summary>
        /// 
        [Display(Name = "Th", Description = "fa-th", GroupName = "duotone light regular solid")]
        Th = '\uf00a',
        
        /// <summary>
        ///     Theater Masks ("fa-theater-masks", \uf630) icon.
        /// </summary>
        /// 
        [Display(Name = "Theater Masks", Description = "fa-theater-masks", GroupName = "duotone light regular solid")]
        TheaterMasks = '\uf630',
        
        /// <summary>
        ///     Themeco ("fa-themeco", \uf5c6) icon.
        /// </summary>
        /// 
        [Display(Name = "Themeco", Description = "fa-themeco", GroupName = "brands")]
        Themeco = '\uf5c6',
        
        /// <summary>
        ///     Themeisle ("fa-themeisle", \uf2b2) icon.
        /// </summary>
        /// 
        [Display(Name = "Themeisle", Description = "fa-themeisle", GroupName = "brands")]
        Themeisle = '\uf2b2',
        
        /// <summary>
        ///     The Red Yeti ("fa-the-red-yeti", \uf69d) icon.
        /// </summary>
        /// 
        [Display(Name = "The Red Yeti", Description = "fa-the-red-yeti", GroupName = "brands")]
        TheRedYeti = '\uf69d',
        
        /// <summary>
        ///     Thermometer ("fa-thermometer", \uf491) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer", Description = "fa-thermometer", GroupName = "duotone light regular solid")]
        Thermometer = '\uf491',
        
        /// <summary>
        ///     Thermometer Empty ("fa-thermometer-empty", \uf2cb) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer Empty", Description = "fa-thermometer-empty", GroupName = "duotone light regular solid")]
        ThermometerEmpty = '\uf2cb',
        
        /// <summary>
        ///     Thermometer Full ("fa-thermometer-full", \uf2c7) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer Full", Description = "fa-thermometer-full", GroupName = "duotone light regular solid")]
        ThermometerFull = '\uf2c7',
        
        /// <summary>
        ///     Thermometer Half ("fa-thermometer-half", \uf2c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer Half", Description = "fa-thermometer-half", GroupName = "duotone light regular solid")]
        ThermometerHalf = '\uf2c9',
        
        /// <summary>
        ///     Thermometer Quarter ("fa-thermometer-quarter", \uf2ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer Quarter", Description = "fa-thermometer-quarter", GroupName = "duotone light regular solid")]
        ThermometerQuarter = '\uf2ca',
        
        /// <summary>
        ///     Thermometer Three Quarters ("fa-thermometer-three-quarters", \uf2c8) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer Three Quarters", Description = "fa-thermometer-three-quarters", GroupName = "duotone light regular solid")]
        ThermometerThreeQuarters = '\uf2c8',
        
        /// <summary>
        ///     Think Peaks ("fa-think-peaks", \uf731) icon.
        /// </summary>
        /// 
        [Display(Name = "Think Peaks", Description = "fa-think-peaks", GroupName = "brands")]
        ThinkPeaks = '\uf731',
        
        /// <summary>
        ///     Th Large ("fa-th-large", \uf009) icon.
        /// </summary>
        /// 
        [Display(Name = "Th Large", Description = "fa-th-large", GroupName = "duotone light regular solid")]
        ThLarge = '\uf009',
        
        /// <summary>
        ///     Th List ("fa-th-list", \uf00b) icon.
        /// </summary>
        /// 
        [Display(Name = "Th List", Description = "fa-th-list", GroupName = "duotone light regular solid")]
        ThList = '\uf00b',
        
        /// <summary>
        ///     Thumbs Down ("fa-thumbs-down", \uf165) icon.
        /// </summary>
        /// 
        [Display(Name = "Thumbs Down", Description = "fa-thumbs-down", GroupName = "duotone light regular solid")]
        ThumbsDown = '\uf165',
        
        /// <summary>
        ///     Thumbs Up ("fa-thumbs-up", \uf164) icon.
        /// </summary>
        /// 
        [Display(Name = "Thumbs Up", Description = "fa-thumbs-up", GroupName = "duotone light regular solid")]
        ThumbsUp = '\uf164',
        
        /// <summary>
        ///     Thumbtack ("fa-thumbtack", \uf08d) icon.
        /// </summary>
        /// 
        [Display(Name = "Thumbtack", Description = "fa-thumbtack", GroupName = "duotone light regular solid")]
        Thumbtack = '\uf08d',
        
        /// <summary>
        ///     Ticket Alt ("fa-ticket-alt", \uf3ff) icon.
        /// </summary>
        /// 
        [Display(Name = "Ticket Alt", Description = "fa-ticket-alt", GroupName = "duotone light regular solid")]
        TicketAlt = '\uf3ff',
        
        /// <summary>
        ///     Times ("fa-times", \uf00d) icon.
        /// </summary>
        /// 
        [Display(Name = "Times", Description = "fa-times", GroupName = "duotone light regular solid")]
        Times = '\uf00d',
        
        /// <summary>
        ///     Times Circle ("fa-times-circle", \uf057) icon.
        /// </summary>
        /// 
        [Display(Name = "Times Circle", Description = "fa-times-circle", GroupName = "duotone light regular solid")]
        TimesCircle = '\uf057',
        
        /// <summary>
        ///     Tint ("fa-tint", \uf043) icon.
        /// </summary>
        /// 
        [Display(Name = "Tint", Description = "fa-tint", GroupName = "duotone light regular solid")]
        Tint = '\uf043',
        
        /// <summary>
        ///     Tint Slash ("fa-tint-slash", \uf5c7) icon.
        /// </summary>
        /// 
        [Display(Name = "Tint Slash", Description = "fa-tint-slash", GroupName = "duotone light regular solid")]
        TintSlash = '\uf5c7',
        
        /// <summary>
        ///     Tired ("fa-tired", \uf5c8) icon.
        /// </summary>
        /// 
        [Display(Name = "Tired", Description = "fa-tired", GroupName = "duotone light regular solid")]
        Tired = '\uf5c8',
        
        /// <summary>
        ///     Toggle Off ("fa-toggle-off", \uf204) icon.
        /// </summary>
        /// 
        [Display(Name = "Toggle Off", Description = "fa-toggle-off", GroupName = "duotone light regular solid")]
        ToggleOff = '\uf204',
        
        /// <summary>
        ///     Toggle On ("fa-toggle-on", \uf205) icon.
        /// </summary>
        /// 
        [Display(Name = "Toggle On", Description = "fa-toggle-on", GroupName = "duotone light regular solid")]
        ToggleOn = '\uf205',
        
        /// <summary>
        ///     Toilet ("fa-toilet", \uf7d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Toilet", Description = "fa-toilet", GroupName = "duotone light regular solid")]
        Toilet = '\uf7d8',
        
        /// <summary>
        ///     Toilet Paper ("fa-toilet-paper", \uf71e) icon.
        /// </summary>
        /// 
        [Display(Name = "Toilet Paper", Description = "fa-toilet-paper", GroupName = "duotone light regular solid")]
        ToiletPaper = '\uf71e',
        
        /// <summary>
        ///     Toilet Paper Slash ("fa-toilet-paper-slash", \uf972) icon.
        /// </summary>
        /// 
        [Display(Name = "Toilet Paper Slash", Description = "fa-toilet-paper-slash", GroupName = "duotone light regular solid")]
        ToiletPaperSlash = '\uf972',
        
        /// <summary>
        ///     Toolbox ("fa-toolbox", \uf552) icon.
        /// </summary>
        /// 
        [Display(Name = "Toolbox", Description = "fa-toolbox", GroupName = "duotone light regular solid")]
        Toolbox = '\uf552',
        
        /// <summary>
        ///     Tools ("fa-tools", \uf7d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Tools", Description = "fa-tools", GroupName = "duotone light regular solid")]
        Tools = '\uf7d9',
        
        /// <summary>
        ///     Tooth ("fa-tooth", \uf5c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Tooth", Description = "fa-tooth", GroupName = "duotone light regular solid")]
        Tooth = '\uf5c9',
        
        /// <summary>
        ///     Torah ("fa-torah", \uf6a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Torah", Description = "fa-torah", GroupName = "duotone light regular solid")]
        Torah = '\uf6a0',
        
        /// <summary>
        ///     Torii Gate ("fa-torii-gate", \uf6a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Torii Gate", Description = "fa-torii-gate", GroupName = "duotone light regular solid")]
        ToriiGate = '\uf6a1',
        
        /// <summary>
        ///     Tractor ("fa-tractor", \uf722) icon.
        /// </summary>
        /// 
        [Display(Name = "Tractor", Description = "fa-tractor", GroupName = "duotone light regular solid")]
        Tractor = '\uf722',
        
        /// <summary>
        ///     Trade Federation ("fa-trade-federation", \uf513) icon.
        /// </summary>
        /// 
        [Display(Name = "Trade Federation", Description = "fa-trade-federation", GroupName = "brands")]
        TradeFederation = '\uf513',
        
        /// <summary>
        ///     Trademark ("fa-trademark", \uf25c) icon.
        /// </summary>
        /// 
        [Display(Name = "Trademark", Description = "fa-trademark", GroupName = "duotone light regular solid")]
        Trademark = '\uf25c',
        
        /// <summary>
        ///     Traffic Light ("fa-traffic-light", \uf637) icon.
        /// </summary>
        /// 
        [Display(Name = "Traffic Light", Description = "fa-traffic-light", GroupName = "duotone light regular solid")]
        TrafficLight = '\uf637',
        
        /// <summary>
        ///     Trailer ("fa-trailer", \uf941) icon.
        /// </summary>
        /// 
        [Display(Name = "Trailer", Description = "fa-trailer", GroupName = "duotone light regular solid")]
        Trailer = '\uf941',
        
        /// <summary>
        ///     Train ("fa-train", \uf238) icon.
        /// </summary>
        /// 
        [Display(Name = "Train", Description = "fa-train", GroupName = "duotone light regular solid")]
        Train = '\uf238',
        
        /// <summary>
        ///     Tram ("fa-tram", \uf7da) icon.
        /// </summary>
        /// 
        [Display(Name = "Tram", Description = "fa-tram", GroupName = "duotone light regular solid")]
        Tram = '\uf7da',
        
        /// <summary>
        ///     Transgender ("fa-transgender", \uf224) icon.
        /// </summary>
        /// 
        [Display(Name = "Transgender", Description = "fa-transgender", GroupName = "duotone light regular solid")]
        Transgender = '\uf224',
        
        /// <summary>
        ///     Transgender Alt ("fa-transgender-alt", \uf225) icon.
        /// </summary>
        /// 
        [Display(Name = "Transgender Alt", Description = "fa-transgender-alt", GroupName = "duotone light regular solid")]
        TransgenderAlt = '\uf225',
        
        /// <summary>
        ///     Trash ("fa-trash", \uf1f8) icon.
        /// </summary>
        /// 
        [Display(Name = "Trash", Description = "fa-trash", GroupName = "duotone light regular solid")]
        Trash = '\uf1f8',
        
        /// <summary>
        ///     Trash Alt ("fa-trash-alt", \uf2ed) icon.
        /// </summary>
        /// 
        [Display(Name = "Trash Alt", Description = "fa-trash-alt", GroupName = "duotone light regular solid")]
        TrashAlt = '\uf2ed',
        
        /// <summary>
        ///     Trash Restore ("fa-trash-restore", \uf829) icon.
        /// </summary>
        /// 
        [Display(Name = "Trash Restore", Description = "fa-trash-restore", GroupName = "duotone light regular solid")]
        TrashRestore = '\uf829',
        
        /// <summary>
        ///     Trash Restore Alt ("fa-trash-restore-alt", \uf82a) icon.
        /// </summary>
        /// 
        [Display(Name = "Trash Restore Alt", Description = "fa-trash-restore-alt", GroupName = "duotone light regular solid")]
        TrashRestoreAlt = '\uf82a',
        
        /// <summary>
        ///     Tree ("fa-tree", \uf1bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Tree", Description = "fa-tree", GroupName = "duotone light regular solid")]
        Tree = '\uf1bb',
        
        /// <summary>
        ///     Trello ("fa-trello", \uf181) icon.
        /// </summary>
        /// 
        [Display(Name = "Trello", Description = "fa-trello", GroupName = "brands")]
        Trello = '\uf181',
        
        /// <summary>
        ///     Tripadvisor ("fa-tripadvisor", \uf262) icon.
        /// </summary>
        /// 
        [Display(Name = "Tripadvisor", Description = "fa-tripadvisor", GroupName = "brands")]
        Tripadvisor = '\uf262',
        
        /// <summary>
        ///     Trophy ("fa-trophy", \uf091) icon.
        /// </summary>
        /// 
        [Display(Name = "Trophy", Description = "fa-trophy", GroupName = "duotone light regular solid")]
        Trophy = '\uf091',
        
        /// <summary>
        ///     Truck ("fa-truck", \uf0d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Truck", Description = "fa-truck", GroupName = "duotone light regular solid")]
        Truck = '\uf0d1',
        
        /// <summary>
        ///     Truck Loading ("fa-truck-loading", \uf4de) icon.
        /// </summary>
        /// 
        [Display(Name = "Truck Loading", Description = "fa-truck-loading", GroupName = "duotone light regular solid")]
        TruckLoading = '\uf4de',
        
        /// <summary>
        ///     Truck Monster ("fa-truck-monster", \uf63b) icon.
        /// </summary>
        /// 
        [Display(Name = "Truck Monster", Description = "fa-truck-monster", GroupName = "duotone light regular solid")]
        TruckMonster = '\uf63b',
        
        /// <summary>
        ///     Truck Moving ("fa-truck-moving", \uf4df) icon.
        /// </summary>
        /// 
        [Display(Name = "Truck Moving", Description = "fa-truck-moving", GroupName = "duotone light regular solid")]
        TruckMoving = '\uf4df',
        
        /// <summary>
        ///     Truck Pickup ("fa-truck-pickup", \uf63c) icon.
        /// </summary>
        /// 
        [Display(Name = "Truck Pickup", Description = "fa-truck-pickup", GroupName = "duotone light regular solid")]
        TruckPickup = '\uf63c',
        
        /// <summary>
        ///     Tshirt ("fa-tshirt", \uf553) icon.
        /// </summary>
        /// 
        [Display(Name = "Tshirt", Description = "fa-tshirt", GroupName = "duotone light regular solid")]
        Tshirt = '\uf553',
        
        /// <summary>
        ///     Tty ("fa-tty", \uf1e4) icon.
        /// </summary>
        /// 
        [Display(Name = "Tty", Description = "fa-tty", GroupName = "duotone light regular solid")]
        Tty = '\uf1e4',
        
        /// <summary>
        ///     Tumblr ("fa-tumblr", \uf173) icon.
        /// </summary>
        /// 
        [Display(Name = "Tumblr", Description = "fa-tumblr", GroupName = "brands")]
        Tumblr = '\uf173',
        
        /// <summary>
        ///     Tumblr Square ("fa-tumblr-square", \uf174) icon.
        /// </summary>
        /// 
        [Display(Name = "Tumblr Square", Description = "fa-tumblr-square", GroupName = "brands")]
        TumblrSquare = '\uf174',
        
        /// <summary>
        ///     Tv ("fa-tv", \uf26c) icon.
        /// </summary>
        /// 
        [Display(Name = "Tv", Description = "fa-tv", GroupName = "duotone light regular solid")]
        Tv = '\uf26c',
        
        /// <summary>
        ///     Twitch ("fa-twitch", \uf1e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Twitch", Description = "fa-twitch", GroupName = "brands")]
        Twitch = '\uf1e8',
        
        /// <summary>
        ///     Twitter ("fa-twitter", \uf099) icon.
        /// </summary>
        /// 
        [Display(Name = "Twitter", Description = "fa-twitter", GroupName = "brands")]
        Twitter = '\uf099',
        
        /// <summary>
        ///     Twitter Square ("fa-twitter-square", \uf081) icon.
        /// </summary>
        /// 
        [Display(Name = "Twitter Square", Description = "fa-twitter-square", GroupName = "brands")]
        TwitterSquare = '\uf081',
        
        /// <summary>
        ///     Typo3 ("fa-typo3", \uf42b) icon.
        /// </summary>
        /// 
        [Display(Name = "Typo3", Description = "fa-typo3", GroupName = "brands")]
        Typo3 = '\uf42b',
        
        /// <summary>
        ///     Uber ("fa-uber", \uf402) icon.
        /// </summary>
        /// 
        [Display(Name = "Uber", Description = "fa-uber", GroupName = "brands")]
        Uber = '\uf402',
        
        /// <summary>
        ///     Ubuntu ("fa-ubuntu", \uf7df) icon.
        /// </summary>
        /// 
        [Display(Name = "Ubuntu", Description = "fa-ubuntu", GroupName = "brands")]
        Ubuntu = '\uf7df',
        
        /// <summary>
        ///     Uikit ("fa-uikit", \uf403) icon.
        /// </summary>
        /// 
        [Display(Name = "Uikit", Description = "fa-uikit", GroupName = "brands")]
        Uikit = '\uf403',
        
        /// <summary>
        ///     Umbraco ("fa-umbraco", \uf8e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Umbraco", Description = "fa-umbraco", GroupName = "brands")]
        Umbraco = '\uf8e8',
        
        /// <summary>
        ///     Umbrella ("fa-umbrella", \uf0e9) icon.
        /// </summary>
        /// 
        [Display(Name = "Umbrella", Description = "fa-umbrella", GroupName = "duotone light regular solid")]
        Umbrella = '\uf0e9',
        
        /// <summary>
        ///     Umbrella Beach ("fa-umbrella-beach", \uf5ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Umbrella Beach", Description = "fa-umbrella-beach", GroupName = "duotone light regular solid")]
        UmbrellaBeach = '\uf5ca',
        
        /// <summary>
        ///     Underline ("fa-underline", \uf0cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Underline", Description = "fa-underline", GroupName = "duotone light regular solid")]
        Underline = '\uf0cd',
        
        /// <summary>
        ///     Undo ("fa-undo", \uf0e2) icon.
        /// </summary>
        /// 
        [Display(Name = "Undo", Description = "fa-undo", GroupName = "duotone light regular solid")]
        Undo = '\uf0e2',
        
        /// <summary>
        ///     Undo Alt ("fa-undo-alt", \uf2ea) icon.
        /// </summary>
        /// 
        [Display(Name = "Undo Alt", Description = "fa-undo-alt", GroupName = "duotone light regular solid")]
        UndoAlt = '\uf2ea',
        
        /// <summary>
        ///     Uniregistry ("fa-uniregistry", \uf404) icon.
        /// </summary>
        /// 
        [Display(Name = "Uniregistry", Description = "fa-uniregistry", GroupName = "brands")]
        Uniregistry = '\uf404',
        
        /// <summary>
        ///     Unity ("fa-unity", \uf949) icon.
        /// </summary>
        /// 
        [Display(Name = "Unity", Description = "fa-unity", GroupName = "brands")]
        Unity = '\uf949',
        
        /// <summary>
        ///     Universal Access ("fa-universal-access", \uf29a) icon.
        /// </summary>
        /// 
        [Display(Name = "Universal Access", Description = "fa-universal-access", GroupName = "duotone light regular solid")]
        UniversalAccess = '\uf29a',
        
        /// <summary>
        ///     University ("fa-university", \uf19c) icon.
        /// </summary>
        /// 
        [Display(Name = "University", Description = "fa-university", GroupName = "duotone light regular solid")]
        University = '\uf19c',
        
        /// <summary>
        ///     Unlink ("fa-unlink", \uf127) icon.
        /// </summary>
        /// 
        [Display(Name = "Unlink", Description = "fa-unlink", GroupName = "duotone light regular solid")]
        Unlink = '\uf127',
        
        /// <summary>
        ///     Unlock ("fa-unlock", \uf09c) icon.
        /// </summary>
        /// 
        [Display(Name = "Unlock", Description = "fa-unlock", GroupName = "duotone light regular solid")]
        Unlock = '\uf09c',
        
        /// <summary>
        ///     Unlock Alt ("fa-unlock-alt", \uf13e) icon.
        /// </summary>
        /// 
        [Display(Name = "Unlock Alt", Description = "fa-unlock-alt", GroupName = "duotone light regular solid")]
        UnlockAlt = '\uf13e',
        
        /// <summary>
        ///     Untappd ("fa-untappd", \uf405) icon.
        /// </summary>
        /// 
        [Display(Name = "Untappd", Description = "fa-untappd", GroupName = "brands")]
        Untappd = '\uf405',
        
        /// <summary>
        ///     Upload ("fa-upload", \uf093) icon.
        /// </summary>
        /// 
        [Display(Name = "Upload", Description = "fa-upload", GroupName = "duotone light regular solid")]
        Upload = '\uf093',
        
        /// <summary>
        ///     Ups ("fa-ups", \uf7e0) icon.
        /// </summary>
        /// 
        [Display(Name = "Ups", Description = "fa-ups", GroupName = "brands")]
        Ups = '\uf7e0',
        
        /// <summary>
        ///     Usb ("fa-usb", \uf287) icon.
        /// </summary>
        /// 
        [Display(Name = "Usb", Description = "fa-usb", GroupName = "brands")]
        Usb = '\uf287',
        
        /// <summary>
        ///     User ("fa-user", \uf007) icon.
        /// </summary>
        /// 
        [Display(Name = "User", Description = "fa-user", GroupName = "duotone light regular solid")]
        User = '\uf007',
        
        /// <summary>
        ///     User Alt ("fa-user-alt", \uf406) icon.
        /// </summary>
        /// 
        [Display(Name = "User Alt", Description = "fa-user-alt", GroupName = "duotone light regular solid")]
        UserAlt = '\uf406',
        
        /// <summary>
        ///     User Alt Slash ("fa-user-alt-slash", \uf4fa) icon.
        /// </summary>
        /// 
        [Display(Name = "User Alt Slash", Description = "fa-user-alt-slash", GroupName = "duotone light regular solid")]
        UserAltSlash = '\uf4fa',
        
        /// <summary>
        ///     User Astronaut ("fa-user-astronaut", \uf4fb) icon.
        /// </summary>
        /// 
        [Display(Name = "User Astronaut", Description = "fa-user-astronaut", GroupName = "duotone light regular solid")]
        UserAstronaut = '\uf4fb',
        
        /// <summary>
        ///     User Check ("fa-user-check", \uf4fc) icon.
        /// </summary>
        /// 
        [Display(Name = "User Check", Description = "fa-user-check", GroupName = "duotone light regular solid")]
        UserCheck = '\uf4fc',
        
        /// <summary>
        ///     User Circle ("fa-user-circle", \uf2bd) icon.
        /// </summary>
        /// 
        [Display(Name = "User Circle", Description = "fa-user-circle", GroupName = "duotone light regular solid")]
        UserCircle = '\uf2bd',
        
        /// <summary>
        ///     User Clock ("fa-user-clock", \uf4fd) icon.
        /// </summary>
        /// 
        [Display(Name = "User Clock", Description = "fa-user-clock", GroupName = "duotone light regular solid")]
        UserClock = '\uf4fd',
        
        /// <summary>
        ///     User Cog ("fa-user-cog", \uf4fe) icon.
        /// </summary>
        /// 
        [Display(Name = "User Cog", Description = "fa-user-cog", GroupName = "duotone light regular solid")]
        UserCog = '\uf4fe',
        
        /// <summary>
        ///     User Edit ("fa-user-edit", \uf4ff) icon.
        /// </summary>
        /// 
        [Display(Name = "User Edit", Description = "fa-user-edit", GroupName = "duotone light regular solid")]
        UserEdit = '\uf4ff',
        
        /// <summary>
        ///     User Friends ("fa-user-friends", \uf500) icon.
        /// </summary>
        /// 
        [Display(Name = "User Friends", Description = "fa-user-friends", GroupName = "duotone light regular solid")]
        UserFriends = '\uf500',
        
        /// <summary>
        ///     User Graduate ("fa-user-graduate", \uf501) icon.
        /// </summary>
        /// 
        [Display(Name = "User Graduate", Description = "fa-user-graduate", GroupName = "duotone light regular solid")]
        UserGraduate = '\uf501',
        
        /// <summary>
        ///     User Injured ("fa-user-injured", \uf728) icon.
        /// </summary>
        /// 
        [Display(Name = "User Injured", Description = "fa-user-injured", GroupName = "duotone light regular solid")]
        UserInjured = '\uf728',
        
        /// <summary>
        ///     User Lock ("fa-user-lock", \uf502) icon.
        /// </summary>
        /// 
        [Display(Name = "User Lock", Description = "fa-user-lock", GroupName = "duotone light regular solid")]
        UserLock = '\uf502',
        
        /// <summary>
        ///     User Md ("fa-user-md", \uf0f0) icon.
        /// </summary>
        /// 
        [Display(Name = "User Md", Description = "fa-user-md", GroupName = "duotone light regular solid")]
        UserMd = '\uf0f0',
        
        /// <summary>
        ///     User Minus ("fa-user-minus", \uf503) icon.
        /// </summary>
        /// 
        [Display(Name = "User Minus", Description = "fa-user-minus", GroupName = "duotone light regular solid")]
        UserMinus = '\uf503',
        
        /// <summary>
        ///     User Ninja ("fa-user-ninja", \uf504) icon.
        /// </summary>
        /// 
        [Display(Name = "User Ninja", Description = "fa-user-ninja", GroupName = "duotone light regular solid")]
        UserNinja = '\uf504',
        
        /// <summary>
        ///     User Nurse ("fa-user-nurse", \uf82f) icon.
        /// </summary>
        /// 
        [Display(Name = "User Nurse", Description = "fa-user-nurse", GroupName = "duotone light regular solid")]
        UserNurse = '\uf82f',
        
        /// <summary>
        ///     User Plus ("fa-user-plus", \uf234) icon.
        /// </summary>
        /// 
        [Display(Name = "User Plus", Description = "fa-user-plus", GroupName = "duotone light regular solid")]
        UserPlus = '\uf234',
        
        /// <summary>
        ///     Users ("fa-users", \uf0c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Users", Description = "fa-users", GroupName = "duotone light regular solid")]
        Users = '\uf0c0',
        
        /// <summary>
        ///     Users Cog ("fa-users-cog", \uf509) icon.
        /// </summary>
        /// 
        [Display(Name = "Users Cog", Description = "fa-users-cog", GroupName = "duotone light regular solid")]
        UsersCog = '\uf509',
        
        /// <summary>
        ///     User Secret ("fa-user-secret", \uf21b) icon.
        /// </summary>
        /// 
        [Display(Name = "User Secret", Description = "fa-user-secret", GroupName = "duotone light regular solid")]
        UserSecret = '\uf21b',
        
        /// <summary>
        ///     User Shield ("fa-user-shield", \uf505) icon.
        /// </summary>
        /// 
        [Display(Name = "User Shield", Description = "fa-user-shield", GroupName = "duotone light regular solid")]
        UserShield = '\uf505',
        
        /// <summary>
        ///     User Slash ("fa-user-slash", \uf506) icon.
        /// </summary>
        /// 
        [Display(Name = "User Slash", Description = "fa-user-slash", GroupName = "duotone light regular solid")]
        UserSlash = '\uf506',
        
        /// <summary>
        ///     User Tag ("fa-user-tag", \uf507) icon.
        /// </summary>
        /// 
        [Display(Name = "User Tag", Description = "fa-user-tag", GroupName = "duotone light regular solid")]
        UserTag = '\uf507',
        
        /// <summary>
        ///     User Tie ("fa-user-tie", \uf508) icon.
        /// </summary>
        /// 
        [Display(Name = "User Tie", Description = "fa-user-tie", GroupName = "duotone light regular solid")]
        UserTie = '\uf508',
        
        /// <summary>
        ///     User Times ("fa-user-times", \uf235) icon.
        /// </summary>
        /// 
        [Display(Name = "User Times", Description = "fa-user-times", GroupName = "duotone light regular solid")]
        UserTimes = '\uf235',
        
        /// <summary>
        ///     Usps ("fa-usps", \uf7e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Usps", Description = "fa-usps", GroupName = "brands")]
        Usps = '\uf7e1',
        
        /// <summary>
        ///     Ussunnah ("fa-ussunnah", \uf407) icon.
        /// </summary>
        /// 
        [Display(Name = "Ussunnah", Description = "fa-ussunnah", GroupName = "brands")]
        Ussunnah = '\uf407',
        
        /// <summary>
        ///     Utensils ("fa-utensils", \uf2e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Utensils", Description = "fa-utensils", GroupName = "duotone light regular solid")]
        Utensils = '\uf2e7',
        
        /// <summary>
        ///     Utensil Spoon ("fa-utensil-spoon", \uf2e5) icon.
        /// </summary>
        /// 
        [Display(Name = "Utensil Spoon", Description = "fa-utensil-spoon", GroupName = "duotone light regular solid")]
        UtensilSpoon = '\uf2e5',
        
        /// <summary>
        ///     Vaadin ("fa-vaadin", \uf408) icon.
        /// </summary>
        /// 
        [Display(Name = "Vaadin", Description = "fa-vaadin", GroupName = "brands")]
        Vaadin = '\uf408',
        
        /// <summary>
        ///     Vector Square ("fa-vector-square", \uf5cb) icon.
        /// </summary>
        /// 
        [Display(Name = "Vector Square", Description = "fa-vector-square", GroupName = "duotone light regular solid")]
        VectorSquare = '\uf5cb',
        
        /// <summary>
        ///     Venus ("fa-venus", \uf221) icon.
        /// </summary>
        /// 
        [Display(Name = "Venus", Description = "fa-venus", GroupName = "duotone light regular solid")]
        Venus = '\uf221',
        
        /// <summary>
        ///     Venus Double ("fa-venus-double", \uf226) icon.
        /// </summary>
        /// 
        [Display(Name = "Venus Double", Description = "fa-venus-double", GroupName = "duotone light regular solid")]
        VenusDouble = '\uf226',
        
        /// <summary>
        ///     Venus Mars ("fa-venus-mars", \uf228) icon.
        /// </summary>
        /// 
        [Display(Name = "Venus Mars", Description = "fa-venus-mars", GroupName = "duotone light regular solid")]
        VenusMars = '\uf228',
        
        /// <summary>
        ///     Viacoin ("fa-viacoin", \uf237) icon.
        /// </summary>
        /// 
        [Display(Name = "Viacoin", Description = "fa-viacoin", GroupName = "brands")]
        Viacoin = '\uf237',
        
        /// <summary>
        ///     Viadeo ("fa-viadeo", \uf2a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Viadeo", Description = "fa-viadeo", GroupName = "brands")]
        Viadeo = '\uf2a9',
        
        /// <summary>
        ///     Viadeo Square ("fa-viadeo-square", \uf2aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Viadeo Square", Description = "fa-viadeo-square", GroupName = "brands")]
        ViadeoSquare = '\uf2aa',
        
        /// <summary>
        ///     Vial ("fa-vial", \uf492) icon.
        /// </summary>
        /// 
        [Display(Name = "Vial", Description = "fa-vial", GroupName = "duotone light regular solid")]
        Vial = '\uf492',
        
        /// <summary>
        ///     Vials ("fa-vials", \uf493) icon.
        /// </summary>
        /// 
        [Display(Name = "Vials", Description = "fa-vials", GroupName = "duotone light regular solid")]
        Vials = '\uf493',
        
        /// <summary>
        ///     Viber ("fa-viber", \uf409) icon.
        /// </summary>
        /// 
        [Display(Name = "Viber", Description = "fa-viber", GroupName = "brands")]
        Viber = '\uf409',
        
        /// <summary>
        ///     Video ("fa-video", \uf03d) icon.
        /// </summary>
        /// 
        [Display(Name = "Video", Description = "fa-video", GroupName = "duotone light regular solid")]
        Video = '\uf03d',
        
        /// <summary>
        ///     Video Slash ("fa-video-slash", \uf4e2) icon.
        /// </summary>
        /// 
        [Display(Name = "Video Slash", Description = "fa-video-slash", GroupName = "duotone light regular solid")]
        VideoSlash = '\uf4e2',
        
        /// <summary>
        ///     Vihara ("fa-vihara", \uf6a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Vihara", Description = "fa-vihara", GroupName = "duotone light regular solid")]
        Vihara = '\uf6a7',
        
        /// <summary>
        ///     Vimeo ("fa-vimeo", \uf40a) icon.
        /// </summary>
        /// 
        [Display(Name = "Vimeo", Description = "fa-vimeo", GroupName = "brands")]
        Vimeo = '\uf40a',
        
        /// <summary>
        ///     Vimeo Square ("fa-vimeo-square", \uf194) icon.
        /// </summary>
        /// 
        [Display(Name = "Vimeo Square", Description = "fa-vimeo-square", GroupName = "brands")]
        VimeoSquare = '\uf194',
        
        /// <summary>
        ///     Vimeo V ("fa-vimeo-v", \uf27d) icon.
        /// </summary>
        /// 
        [Display(Name = "Vimeo V", Description = "fa-vimeo-v", GroupName = "brands")]
        VimeoV = '\uf27d',
        
        /// <summary>
        ///     Vine ("fa-vine", \uf1ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Vine", Description = "fa-vine", GroupName = "brands")]
        Vine = '\uf1ca',
        
        /// <summary>
        ///     Virus ("fa-virus", \uf974) icon.
        /// </summary>
        /// 
        [Display(Name = "Virus", Description = "fa-virus", GroupName = "duotone light regular solid")]
        Virus = '\uf974',
        
        /// <summary>
        ///     Viruses ("fa-viruses", \uf976) icon.
        /// </summary>
        /// 
        [Display(Name = "Viruses", Description = "fa-viruses", GroupName = "duotone light regular solid")]
        Viruses = '\uf976',
        
        /// <summary>
        ///     Virus Slash ("fa-virus-slash", \uf975) icon.
        /// </summary>
        /// 
        [Display(Name = "Virus Slash", Description = "fa-virus-slash", GroupName = "duotone light regular solid")]
        VirusSlash = '\uf975',
        
        /// <summary>
        ///     Vk ("fa-vk", \uf189) icon.
        /// </summary>
        /// 
        [Display(Name = "Vk", Description = "fa-vk", GroupName = "brands")]
        Vk = '\uf189',
        
        /// <summary>
        ///     Vnv ("fa-vnv", \uf40b) icon.
        /// </summary>
        /// 
        [Display(Name = "Vnv", Description = "fa-vnv", GroupName = "brands")]
        Vnv = '\uf40b',
        
        /// <summary>
        ///     Voicemail ("fa-voicemail", \uf897) icon.
        /// </summary>
        /// 
        [Display(Name = "Voicemail", Description = "fa-voicemail", GroupName = "duotone light regular solid")]
        Voicemail = '\uf897',
        
        /// <summary>
        ///     Volleyball Ball ("fa-volleyball-ball", \uf45f) icon.
        /// </summary>
        /// 
        [Display(Name = "Volleyball Ball", Description = "fa-volleyball-ball", GroupName = "duotone light regular solid")]
        VolleyballBall = '\uf45f',
        
        /// <summary>
        ///     Volume Down ("fa-volume-down", \uf027) icon.
        /// </summary>
        /// 
        [Display(Name = "Volume Down", Description = "fa-volume-down", GroupName = "duotone light regular solid")]
        VolumeDown = '\uf027',
        
        /// <summary>
        ///     Volume Mute ("fa-volume-mute", \uf6a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Volume Mute", Description = "fa-volume-mute", GroupName = "duotone light regular solid")]
        VolumeMute = '\uf6a9',
        
        /// <summary>
        ///     Volume Off ("fa-volume-off", \uf026) icon.
        /// </summary>
        /// 
        [Display(Name = "Volume Off", Description = "fa-volume-off", GroupName = "duotone light regular solid")]
        VolumeOff = '\uf026',
        
        /// <summary>
        ///     Volume Up ("fa-volume-up", \uf028) icon.
        /// </summary>
        /// 
        [Display(Name = "Volume Up", Description = "fa-volume-up", GroupName = "duotone light regular solid")]
        VolumeUp = '\uf028',
        
        /// <summary>
        ///     Vote Yea ("fa-vote-yea", \uf772) icon.
        /// </summary>
        /// 
        [Display(Name = "Vote Yea", Description = "fa-vote-yea", GroupName = "duotone light regular solid")]
        VoteYea = '\uf772',
        
        /// <summary>
        ///     Vr Cardboard ("fa-vr-cardboard", \uf729) icon.
        /// </summary>
        /// 
        [Display(Name = "Vr Cardboard", Description = "fa-vr-cardboard", GroupName = "duotone light regular solid")]
        VrCardboard = '\uf729',
        
        /// <summary>
        ///     Vuejs ("fa-vuejs", \uf41f) icon.
        /// </summary>
        /// 
        [Display(Name = "Vuejs", Description = "fa-vuejs", GroupName = "brands")]
        Vuejs = '\uf41f',
        
        /// <summary>
        ///     Walking ("fa-walking", \uf554) icon.
        /// </summary>
        /// 
        [Display(Name = "Walking", Description = "fa-walking", GroupName = "duotone light regular solid")]
        Walking = '\uf554',
        
        /// <summary>
        ///     Wallet ("fa-wallet", \uf555) icon.
        /// </summary>
        /// 
        [Display(Name = "Wallet", Description = "fa-wallet", GroupName = "duotone light regular solid")]
        Wallet = '\uf555',
        
        /// <summary>
        ///     Warehouse ("fa-warehouse", \uf494) icon.
        /// </summary>
        /// 
        [Display(Name = "Warehouse", Description = "fa-warehouse", GroupName = "duotone light regular solid")]
        Warehouse = '\uf494',
        
        /// <summary>
        ///     Water ("fa-water", \uf773) icon.
        /// </summary>
        /// 
        [Display(Name = "Water", Description = "fa-water", GroupName = "duotone light regular solid")]
        Water = '\uf773',
        
        /// <summary>
        ///     Wave Square ("fa-wave-square", \uf83e) icon.
        /// </summary>
        /// 
        [Display(Name = "Wave Square", Description = "fa-wave-square", GroupName = "duotone light regular solid")]
        WaveSquare = '\uf83e',
        
        /// <summary>
        ///     Waze ("fa-waze", \uf83f) icon.
        /// </summary>
        /// 
        [Display(Name = "Waze", Description = "fa-waze", GroupName = "brands")]
        Waze = '\uf83f',
        
        /// <summary>
        ///     Weebly ("fa-weebly", \uf5cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Weebly", Description = "fa-weebly", GroupName = "brands")]
        Weebly = '\uf5cc',
        
        /// <summary>
        ///     Weibo ("fa-weibo", \uf18a) icon.
        /// </summary>
        /// 
        [Display(Name = "Weibo", Description = "fa-weibo", GroupName = "brands")]
        Weibo = '\uf18a',
        
        /// <summary>
        ///     Weight ("fa-weight", \uf496) icon.
        /// </summary>
        /// 
        [Display(Name = "Weight", Description = "fa-weight", GroupName = "duotone light regular solid")]
        Weight = '\uf496',
        
        /// <summary>
        ///     Weight Hanging ("fa-weight-hanging", \uf5cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Weight Hanging", Description = "fa-weight-hanging", GroupName = "duotone light regular solid")]
        WeightHanging = '\uf5cd',
        
        /// <summary>
        ///     Weixin ("fa-weixin", \uf1d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Weixin", Description = "fa-weixin", GroupName = "brands")]
        Weixin = '\uf1d7',
        
        /// <summary>
        ///     Whatsapp ("fa-whatsapp", \uf232) icon.
        /// </summary>
        /// 
        [Display(Name = "Whatsapp", Description = "fa-whatsapp", GroupName = "brands")]
        Whatsapp = '\uf232',
        
        /// <summary>
        ///     Whatsapp Square ("fa-whatsapp-square", \uf40c) icon.
        /// </summary>
        /// 
        [Display(Name = "Whatsapp Square", Description = "fa-whatsapp-square", GroupName = "brands")]
        WhatsappSquare = '\uf40c',
        
        /// <summary>
        ///     Wheelchair ("fa-wheelchair", \uf193) icon.
        /// </summary>
        /// 
        [Display(Name = "Wheelchair", Description = "fa-wheelchair", GroupName = "duotone light regular solid")]
        Wheelchair = '\uf193',
        
        /// <summary>
        ///     Whmcs ("fa-whmcs", \uf40d) icon.
        /// </summary>
        /// 
        [Display(Name = "Whmcs", Description = "fa-whmcs", GroupName = "brands")]
        Whmcs = '\uf40d',
        
        /// <summary>
        ///     Wifi ("fa-wifi", \uf1eb) icon.
        /// </summary>
        /// 
        [Display(Name = "Wifi", Description = "fa-wifi", GroupName = "duotone light regular solid")]
        Wifi = '\uf1eb',
        
        /// <summary>
        ///     Wikipedia W ("fa-wikipedia-w", \uf266) icon.
        /// </summary>
        /// 
        [Display(Name = "Wikipedia W", Description = "fa-wikipedia-w", GroupName = "brands")]
        WikipediaW = '\uf266',
        
        /// <summary>
        ///     Wind ("fa-wind", \uf72e) icon.
        /// </summary>
        /// 
        [Display(Name = "Wind", Description = "fa-wind", GroupName = "duotone light regular solid")]
        Wind = '\uf72e',
        
        /// <summary>
        ///     Window Close ("fa-window-close", \uf410) icon.
        /// </summary>
        /// 
        [Display(Name = "Window Close", Description = "fa-window-close", GroupName = "duotone light regular solid")]
        WindowClose = '\uf410',
        
        /// <summary>
        ///     Window Maximize ("fa-window-maximize", \uf2d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Window Maximize", Description = "fa-window-maximize", GroupName = "duotone light regular solid")]
        WindowMaximize = '\uf2d0',
        
        /// <summary>
        ///     Window Minimize ("fa-window-minimize", \uf2d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Window Minimize", Description = "fa-window-minimize", GroupName = "duotone light regular solid")]
        WindowMinimize = '\uf2d1',
        
        /// <summary>
        ///     Window Restore ("fa-window-restore", \uf2d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Window Restore", Description = "fa-window-restore", GroupName = "duotone light regular solid")]
        WindowRestore = '\uf2d2',
        
        /// <summary>
        ///     Windows ("fa-windows", \uf17a) icon.
        /// </summary>
        /// 
        [Display(Name = "Windows", Description = "fa-windows", GroupName = "brands")]
        Windows = '\uf17a',
        
        /// <summary>
        ///     Wine Bottle ("fa-wine-bottle", \uf72f) icon.
        /// </summary>
        /// 
        [Display(Name = "Wine Bottle", Description = "fa-wine-bottle", GroupName = "duotone light regular solid")]
        WineBottle = '\uf72f',
        
        /// <summary>
        ///     Wine Glass ("fa-wine-glass", \uf4e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Wine Glass", Description = "fa-wine-glass", GroupName = "duotone light regular solid")]
        WineGlass = '\uf4e3',
        
        /// <summary>
        ///     Wine Glass Alt ("fa-wine-glass-alt", \uf5ce) icon.
        /// </summary>
        /// 
        [Display(Name = "Wine Glass Alt", Description = "fa-wine-glass-alt", GroupName = "duotone light regular solid")]
        WineGlassAlt = '\uf5ce',
        
        /// <summary>
        ///     Wix ("fa-wix", \uf5cf) icon.
        /// </summary>
        /// 
        [Display(Name = "Wix", Description = "fa-wix", GroupName = "brands")]
        Wix = '\uf5cf',
        
        /// <summary>
        ///     Wizards Of The Coast ("fa-wizards-of-the-coast", \uf730) icon.
        /// </summary>
        /// 
        [Display(Name = "Wizards Of The Coast", Description = "fa-wizards-of-the-coast", GroupName = "brands")]
        WizardsOfTheCoast = '\uf730',
        
        /// <summary>
        ///     Wolf Pack Battalion ("fa-wolf-pack-battalion", \uf514) icon.
        /// </summary>
        /// 
        [Display(Name = "Wolf Pack Battalion", Description = "fa-wolf-pack-battalion", GroupName = "brands")]
        WolfPackBattalion = '\uf514',
        
        /// <summary>
        ///     Won Sign ("fa-won-sign", \uf159) icon.
        /// </summary>
        /// 
        [Display(Name = "Won Sign", Description = "fa-won-sign", GroupName = "duotone light regular solid")]
        WonSign = '\uf159',
        
        /// <summary>
        ///     Wordpress ("fa-wordpress", \uf19a) icon.
        /// </summary>
        /// 
        [Display(Name = "Wordpress", Description = "fa-wordpress", GroupName = "brands")]
        Wordpress = '\uf19a',
        
        /// <summary>
        ///     Wordpress Simple ("fa-wordpress-simple", \uf411) icon.
        /// </summary>
        /// 
        [Display(Name = "Wordpress Simple", Description = "fa-wordpress-simple", GroupName = "brands")]
        WordpressSimple = '\uf411',
        
        /// <summary>
        ///     Wpbeginner ("fa-wpbeginner", \uf297) icon.
        /// </summary>
        /// 
        [Display(Name = "Wpbeginner", Description = "fa-wpbeginner", GroupName = "brands")]
        Wpbeginner = '\uf297',
        
        /// <summary>
        ///     Wpexplorer ("fa-wpexplorer", \uf2de) icon.
        /// </summary>
        /// 
        [Display(Name = "Wpexplorer", Description = "fa-wpexplorer", GroupName = "brands")]
        Wpexplorer = '\uf2de',
        
        /// <summary>
        ///     Wpforms ("fa-wpforms", \uf298) icon.
        /// </summary>
        /// 
        [Display(Name = "Wpforms", Description = "fa-wpforms", GroupName = "brands")]
        Wpforms = '\uf298',
        
        /// <summary>
        ///     Wpressr ("fa-wpressr", \uf3e4) icon.
        /// </summary>
        /// 
        [Display(Name = "Wpressr", Description = "fa-wpressr", GroupName = "brands")]
        Wpressr = '\uf3e4',
        
        /// <summary>
        ///     Wrench ("fa-wrench", \uf0ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Wrench", Description = "fa-wrench", GroupName = "duotone light regular solid")]
        Wrench = '\uf0ad',
        
        /// <summary>
        ///     Xbox ("fa-xbox", \uf412) icon.
        /// </summary>
        /// 
        [Display(Name = "Xbox", Description = "fa-xbox", GroupName = "brands")]
        Xbox = '\uf412',
        
        /// <summary>
        ///     Xing ("fa-xing", \uf168) icon.
        /// </summary>
        /// 
        [Display(Name = "Xing", Description = "fa-xing", GroupName = "brands")]
        Xing = '\uf168',
        
        /// <summary>
        ///     Xing Square ("fa-xing-square", \uf169) icon.
        /// </summary>
        /// 
        [Display(Name = "Xing Square", Description = "fa-xing-square", GroupName = "brands")]
        XingSquare = '\uf169',
        
        /// <summary>
        ///     X Ray ("fa-x-ray", \uf497) icon.
        /// </summary>
        /// 
        [Display(Name = "X Ray", Description = "fa-x-ray", GroupName = "duotone light regular solid")]
        XRay = '\uf497',
        
        /// <summary>
        ///     Yahoo ("fa-yahoo", \uf19e) icon.
        /// </summary>
        /// 
        [Display(Name = "Yahoo", Description = "fa-yahoo", GroupName = "brands")]
        Yahoo = '\uf19e',
        
        /// <summary>
        ///     Yammer ("fa-yammer", \uf840) icon.
        /// </summary>
        /// 
        [Display(Name = "Yammer", Description = "fa-yammer", GroupName = "brands")]
        Yammer = '\uf840',
        
        /// <summary>
        ///     Yandex ("fa-yandex", \uf413) icon.
        /// </summary>
        /// 
        [Display(Name = "Yandex", Description = "fa-yandex", GroupName = "brands")]
        Yandex = '\uf413',
        
        /// <summary>
        ///     Yandex International ("fa-yandex-international", \uf414) icon.
        /// </summary>
        /// 
        [Display(Name = "Yandex International", Description = "fa-yandex-international", GroupName = "brands")]
        YandexInternational = '\uf414',
        
        /// <summary>
        ///     Yarn ("fa-yarn", \uf7e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Yarn", Description = "fa-yarn", GroupName = "brands")]
        Yarn = '\uf7e3',
        
        /// <summary>
        ///     Y Combinator ("fa-y-combinator", \uf23b) icon.
        /// </summary>
        /// 
        [Display(Name = "Y Combinator", Description = "fa-y-combinator", GroupName = "brands")]
        YCombinator = '\uf23b',
        
        /// <summary>
        ///     Yelp ("fa-yelp", \uf1e9) icon.
        /// </summary>
        /// 
        [Display(Name = "Yelp", Description = "fa-yelp", GroupName = "brands")]
        Yelp = '\uf1e9',
        
        /// <summary>
        ///     Yen Sign ("fa-yen-sign", \uf157) icon.
        /// </summary>
        /// 
        [Display(Name = "Yen Sign", Description = "fa-yen-sign", GroupName = "duotone light regular solid")]
        YenSign = '\uf157',
        
        /// <summary>
        ///     Yin Yang ("fa-yin-yang", \uf6ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Yin Yang", Description = "fa-yin-yang", GroupName = "duotone light regular solid")]
        YinYang = '\uf6ad',
        
        /// <summary>
        ///     Yoast ("fa-yoast", \uf2b1) icon.
        /// </summary>
        /// 
        [Display(Name = "Yoast", Description = "fa-yoast", GroupName = "brands")]
        Yoast = '\uf2b1',
        
        /// <summary>
        ///     Youtube ("fa-youtube", \uf167) icon.
        /// </summary>
        /// 
        [Display(Name = "Youtube", Description = "fa-youtube", GroupName = "brands")]
        Youtube = '\uf167',
        
        /// <summary>
        ///     Youtube Square ("fa-youtube-square", \uf431) icon.
        /// </summary>
        /// 
        [Display(Name = "Youtube Square", Description = "fa-youtube-square", GroupName = "brands")]
        YoutubeSquare = '\uf431',
        
        /// <summary>
        ///     Zhihu ("fa-zhihu", \uf63f) icon.
        /// </summary>
        /// 
        [Display(Name = "Zhihu", Description = "fa-zhihu", GroupName = "brands")]
        Zhihu = '\uf63f',
        
    }
    
    /// <summary>
    ///     Represents style groups in the Font-Awesome icons library.
    /// </summary>
    /// 
    public enum FontAwesomeStyle : uint
    {
        /// <summary>
        ///     Brands ("fab") style.
        /// </summary>
        /// 
        [Display(Name = "Brands", Description = "fab")]
        Brands = 'b',
        
        /// <summary>
        ///     Duotone ("fad") style.
        /// </summary>
        /// 
        [Display(Name = "Duotone", Description = "fad")]
        Duotone = 'd',
        
        /// <summary>
        ///     Light ("fal") style.
        /// </summary>
        /// 
        [Display(Name = "Light", Description = "fal")]
        Light = 'l',
        
        /// <summary>
        ///     Regular ("far") style.
        /// </summary>
        /// 
        [Display(Name = "Regular", Description = "far")]
        Regular = 'r',
        
        /// <summary>
        ///     Solid ("fas") style.
        /// </summary>
        /// 
        [Display(Name = "Solid", Description = "fas")]
        Solid = 's',
        
    }
    
    public static partial class Extensions
    {
        /// <summary>
        ///   Gets the CSS class associated with a <see cref="FontAwesome"/> icon.
        /// </summary>
        /// 
        public static string GetCss(this FontAwesomeStyle style) => style switch
        {
            FontAwesomeStyle.Brands => "fab",
            FontAwesomeStyle.Duotone => "fad",
            FontAwesomeStyle.Light => "fal",
            FontAwesomeStyle.Regular => "far",
            FontAwesomeStyle.Solid => "fas",
            _ => throw new ArgumentOutOfRangeException(nameof(style))
        };

        /// <summary>
        ///   Gets the postfix char associated with a <see cref="FontAwesomeStyle"/> style.
        /// </summary>
        /// 
        public static char GetPostfix(this FontAwesomeStyle style) => (char)style;
    }
    public static partial class Extensions
    {
        /// <summary>
        ///   Gets the CSS class associated with a <see cref="FontAwesome"/> icon.
        /// </summary>
        /// 
        public static string GetCss(this FontAwesome icon) => icon switch
        {
            FontAwesome.F500Px => "fa-500px",
            FontAwesome.AccessibleIcon => "fa-accessible-icon",
            FontAwesome.Accusoft => "fa-accusoft",
            FontAwesome.AcquisitionsIncorporated => "fa-acquisitions-incorporated",
            FontAwesome.Ad => "fa-ad",
            FontAwesome.AddressBook => "fa-address-book",
            FontAwesome.AddressCard => "fa-address-card",
            FontAwesome.Adjust => "fa-adjust",
            FontAwesome.Adn => "fa-adn",
            FontAwesome.Adobe => "fa-adobe",
            FontAwesome.Adversal => "fa-adversal",
            FontAwesome.Affiliatetheme => "fa-affiliatetheme",
            FontAwesome.Airbnb => "fa-airbnb",
            FontAwesome.AirFreshener => "fa-air-freshener",
            FontAwesome.Algolia => "fa-algolia",
            FontAwesome.AlignCenter => "fa-align-center",
            FontAwesome.AlignJustify => "fa-align-justify",
            FontAwesome.AlignLeft => "fa-align-left",
            FontAwesome.AlignRight => "fa-align-right",
            FontAwesome.Alipay => "fa-alipay",
            FontAwesome.Allergies => "fa-allergies",
            FontAwesome.Amazon => "fa-amazon",
            FontAwesome.AmazonPay => "fa-amazon-pay",
            FontAwesome.Ambulance => "fa-ambulance",
            FontAwesome.AmericanSignLanguageInterpreting => "fa-american-sign-language-interpreting",
            FontAwesome.Amilia => "fa-amilia",
            FontAwesome.Anchor => "fa-anchor",
            FontAwesome.Android => "fa-android",
            FontAwesome.Angellist => "fa-angellist",
            FontAwesome.AngleDoubleDown => "fa-angle-double-down",
            FontAwesome.AngleDoubleLeft => "fa-angle-double-left",
            FontAwesome.AngleDoubleRight => "fa-angle-double-right",
            FontAwesome.AngleDoubleUp => "fa-angle-double-up",
            FontAwesome.AngleDown => "fa-angle-down",
            FontAwesome.AngleLeft => "fa-angle-left",
            FontAwesome.AngleRight => "fa-angle-right",
            FontAwesome.AngleUp => "fa-angle-up",
            FontAwesome.Angry => "fa-angry",
            FontAwesome.Angrycreative => "fa-angrycreative",
            FontAwesome.Angular => "fa-angular",
            FontAwesome.Ankh => "fa-ankh",
            FontAwesome.Apper => "fa-apper",
            FontAwesome.Apple => "fa-apple",
            FontAwesome.AppleAlt => "fa-apple-alt",
            FontAwesome.ApplePay => "fa-apple-pay",
            FontAwesome.AppStore => "fa-app-store",
            FontAwesome.AppStoreIos => "fa-app-store-ios",
            FontAwesome.Archive => "fa-archive",
            FontAwesome.Archway => "fa-archway",
            FontAwesome.ArrowAltCircleDown => "fa-arrow-alt-circle-down",
            FontAwesome.ArrowAltCircleLeft => "fa-arrow-alt-circle-left",
            FontAwesome.ArrowAltCircleRight => "fa-arrow-alt-circle-right",
            FontAwesome.ArrowAltCircleUp => "fa-arrow-alt-circle-up",
            FontAwesome.ArrowCircleDown => "fa-arrow-circle-down",
            FontAwesome.ArrowCircleLeft => "fa-arrow-circle-left",
            FontAwesome.ArrowCircleRight => "fa-arrow-circle-right",
            FontAwesome.ArrowCircleUp => "fa-arrow-circle-up",
            FontAwesome.ArrowDown => "fa-arrow-down",
            FontAwesome.ArrowLeft => "fa-arrow-left",
            FontAwesome.ArrowRight => "fa-arrow-right",
            FontAwesome.ArrowsAlt => "fa-arrows-alt",
            FontAwesome.ArrowsAltH => "fa-arrows-alt-h",
            FontAwesome.ArrowsAltV => "fa-arrows-alt-v",
            FontAwesome.ArrowUp => "fa-arrow-up",
            FontAwesome.Artstation => "fa-artstation",
            FontAwesome.AssistiveListeningSystems => "fa-assistive-listening-systems",
            FontAwesome.Asterisk => "fa-asterisk",
            FontAwesome.Asymmetrik => "fa-asymmetrik",
            FontAwesome.At => "fa-at",
            FontAwesome.Atlas => "fa-atlas",
            FontAwesome.Atlassian => "fa-atlassian",
            FontAwesome.Atom => "fa-atom",
            FontAwesome.Audible => "fa-audible",
            FontAwesome.AudioDescription => "fa-audio-description",
            FontAwesome.Autoprefixer => "fa-autoprefixer",
            FontAwesome.Avianex => "fa-avianex",
            FontAwesome.Aviato => "fa-aviato",
            FontAwesome.Award => "fa-award",
            FontAwesome.Aws => "fa-aws",
            FontAwesome.Baby => "fa-baby",
            FontAwesome.BabyCarriage => "fa-baby-carriage",
            FontAwesome.Backspace => "fa-backspace",
            FontAwesome.Backward => "fa-backward",
            FontAwesome.Bacon => "fa-bacon",
            FontAwesome.Bahai => "fa-bahai",
            FontAwesome.BalanceScale => "fa-balance-scale",
            FontAwesome.BalanceScaleLeft => "fa-balance-scale-left",
            FontAwesome.BalanceScaleRight => "fa-balance-scale-right",
            FontAwesome.Ban => "fa-ban",
            FontAwesome.BandAid => "fa-band-aid",
            FontAwesome.Bandcamp => "fa-bandcamp",
            FontAwesome.Barcode => "fa-barcode",
            FontAwesome.Bars => "fa-bars",
            FontAwesome.BaseballBall => "fa-baseball-ball",
            FontAwesome.BasketballBall => "fa-basketball-ball",
            FontAwesome.Bath => "fa-bath",
            FontAwesome.BatteryEmpty => "fa-battery-empty",
            FontAwesome.BatteryFull => "fa-battery-full",
            FontAwesome.BatteryHalf => "fa-battery-half",
            FontAwesome.BatteryQuarter => "fa-battery-quarter",
            FontAwesome.BatteryThreeQuarters => "fa-battery-three-quarters",
            FontAwesome.BattleNet => "fa-battle-net",
            FontAwesome.Bed => "fa-bed",
            FontAwesome.Beer => "fa-beer",
            FontAwesome.Behance => "fa-behance",
            FontAwesome.BehanceSquare => "fa-behance-square",
            FontAwesome.Bell => "fa-bell",
            FontAwesome.BellSlash => "fa-bell-slash",
            FontAwesome.BezierCurve => "fa-bezier-curve",
            FontAwesome.Bible => "fa-bible",
            FontAwesome.Bicycle => "fa-bicycle",
            FontAwesome.Biking => "fa-biking",
            FontAwesome.Bimobject => "fa-bimobject",
            FontAwesome.Binoculars => "fa-binoculars",
            FontAwesome.Biohazard => "fa-biohazard",
            FontAwesome.BirthdayCake => "fa-birthday-cake",
            FontAwesome.Bitbucket => "fa-bitbucket",
            FontAwesome.Bitcoin => "fa-bitcoin",
            FontAwesome.Bity => "fa-bity",
            FontAwesome.Blackberry => "fa-blackberry",
            FontAwesome.BlackTie => "fa-black-tie",
            FontAwesome.Blender => "fa-blender",
            FontAwesome.BlenderPhone => "fa-blender-phone",
            FontAwesome.Blind => "fa-blind",
            FontAwesome.Blog => "fa-blog",
            FontAwesome.Blogger => "fa-blogger",
            FontAwesome.BloggerB => "fa-blogger-b",
            FontAwesome.Bluetooth => "fa-bluetooth",
            FontAwesome.BluetoothB => "fa-bluetooth-b",
            FontAwesome.Bold => "fa-bold",
            FontAwesome.Bolt => "fa-bolt",
            FontAwesome.Bomb => "fa-bomb",
            FontAwesome.Bone => "fa-bone",
            FontAwesome.Bong => "fa-bong",
            FontAwesome.Book => "fa-book",
            FontAwesome.BookDead => "fa-book-dead",
            FontAwesome.Bookmark => "fa-bookmark",
            FontAwesome.BookMedical => "fa-book-medical",
            FontAwesome.BookOpen => "fa-book-open",
            FontAwesome.BookReader => "fa-book-reader",
            FontAwesome.Bootstrap => "fa-bootstrap",
            FontAwesome.BorderAll => "fa-border-all",
            FontAwesome.BorderNone => "fa-border-none",
            FontAwesome.BorderStyle => "fa-border-style",
            FontAwesome.BowlingBall => "fa-bowling-ball",
            FontAwesome.Box => "fa-box",
            FontAwesome.Boxes => "fa-boxes",
            FontAwesome.BoxOpen => "fa-box-open",
            FontAwesome.BoxTissue => "fa-box-tissue",
            FontAwesome.Braille => "fa-braille",
            FontAwesome.Brain => "fa-brain",
            FontAwesome.BreadSlice => "fa-bread-slice",
            FontAwesome.Briefcase => "fa-briefcase",
            FontAwesome.BriefcaseMedical => "fa-briefcase-medical",
            FontAwesome.BroadcastTower => "fa-broadcast-tower",
            FontAwesome.Broom => "fa-broom",
            FontAwesome.Brush => "fa-brush",
            FontAwesome.Btc => "fa-btc",
            FontAwesome.Buffer => "fa-buffer",
            FontAwesome.Bug => "fa-bug",
            FontAwesome.Building => "fa-building",
            FontAwesome.Bullhorn => "fa-bullhorn",
            FontAwesome.Bullseye => "fa-bullseye",
            FontAwesome.Burn => "fa-burn",
            FontAwesome.Buromobelexperte => "fa-buromobelexperte",
            FontAwesome.Bus => "fa-bus",
            FontAwesome.BusAlt => "fa-bus-alt",
            FontAwesome.BusinessTime => "fa-business-time",
            FontAwesome.BuyNLarge => "fa-buy-n-large",
            FontAwesome.Buysellads => "fa-buysellads",
            FontAwesome.Calculator => "fa-calculator",
            FontAwesome.Calendar => "fa-calendar",
            FontAwesome.CalendarAlt => "fa-calendar-alt",
            FontAwesome.CalendarCheck => "fa-calendar-check",
            FontAwesome.CalendarDay => "fa-calendar-day",
            FontAwesome.CalendarMinus => "fa-calendar-minus",
            FontAwesome.CalendarPlus => "fa-calendar-plus",
            FontAwesome.CalendarTimes => "fa-calendar-times",
            FontAwesome.CalendarWeek => "fa-calendar-week",
            FontAwesome.Camera => "fa-camera",
            FontAwesome.CameraRetro => "fa-camera-retro",
            FontAwesome.Campground => "fa-campground",
            FontAwesome.CanadianMapleLeaf => "fa-canadian-maple-leaf",
            FontAwesome.CandyCane => "fa-candy-cane",
            FontAwesome.Cannabis => "fa-cannabis",
            FontAwesome.Capsules => "fa-capsules",
            FontAwesome.Car => "fa-car",
            FontAwesome.CarAlt => "fa-car-alt",
            FontAwesome.Caravan => "fa-caravan",
            FontAwesome.CarBattery => "fa-car-battery",
            FontAwesome.CarCrash => "fa-car-crash",
            FontAwesome.CaretDown => "fa-caret-down",
            FontAwesome.CaretLeft => "fa-caret-left",
            FontAwesome.CaretRight => "fa-caret-right",
            FontAwesome.CaretSquareDown => "fa-caret-square-down",
            FontAwesome.CaretSquareLeft => "fa-caret-square-left",
            FontAwesome.CaretSquareRight => "fa-caret-square-right",
            FontAwesome.CaretSquareUp => "fa-caret-square-up",
            FontAwesome.CaretUp => "fa-caret-up",
            FontAwesome.Carrot => "fa-carrot",
            FontAwesome.CarSide => "fa-car-side",
            FontAwesome.CartArrowDown => "fa-cart-arrow-down",
            FontAwesome.CartPlus => "fa-cart-plus",
            FontAwesome.CashRegister => "fa-cash-register",
            FontAwesome.Cat => "fa-cat",
            FontAwesome.CcAmazonPay => "fa-cc-amazon-pay",
            FontAwesome.CcAmex => "fa-cc-amex",
            FontAwesome.CcApplePay => "fa-cc-apple-pay",
            FontAwesome.CcDinersClub => "fa-cc-diners-club",
            FontAwesome.CcDiscover => "fa-cc-discover",
            FontAwesome.CcJcb => "fa-cc-jcb",
            FontAwesome.CcMastercard => "fa-cc-mastercard",
            FontAwesome.CcPaypal => "fa-cc-paypal",
            FontAwesome.CcStripe => "fa-cc-stripe",
            FontAwesome.CcVisa => "fa-cc-visa",
            FontAwesome.Centercode => "fa-centercode",
            FontAwesome.Centos => "fa-centos",
            FontAwesome.Certificate => "fa-certificate",
            FontAwesome.Chair => "fa-chair",
            FontAwesome.Chalkboard => "fa-chalkboard",
            FontAwesome.ChalkboardTeacher => "fa-chalkboard-teacher",
            FontAwesome.ChargingStation => "fa-charging-station",
            FontAwesome.ChartArea => "fa-chart-area",
            FontAwesome.ChartBar => "fa-chart-bar",
            FontAwesome.ChartLine => "fa-chart-line",
            FontAwesome.ChartPie => "fa-chart-pie",
            FontAwesome.Check => "fa-check",
            FontAwesome.CheckCircle => "fa-check-circle",
            FontAwesome.CheckDouble => "fa-check-double",
            FontAwesome.CheckSquare => "fa-check-square",
            FontAwesome.Cheese => "fa-cheese",
            FontAwesome.Chess => "fa-chess",
            FontAwesome.ChessBishop => "fa-chess-bishop",
            FontAwesome.ChessBoard => "fa-chess-board",
            FontAwesome.ChessKing => "fa-chess-king",
            FontAwesome.ChessKnight => "fa-chess-knight",
            FontAwesome.ChessPawn => "fa-chess-pawn",
            FontAwesome.ChessQueen => "fa-chess-queen",
            FontAwesome.ChessRook => "fa-chess-rook",
            FontAwesome.ChevronCircleDown => "fa-chevron-circle-down",
            FontAwesome.ChevronCircleLeft => "fa-chevron-circle-left",
            FontAwesome.ChevronCircleRight => "fa-chevron-circle-right",
            FontAwesome.ChevronCircleUp => "fa-chevron-circle-up",
            FontAwesome.ChevronDown => "fa-chevron-down",
            FontAwesome.ChevronLeft => "fa-chevron-left",
            FontAwesome.ChevronRight => "fa-chevron-right",
            FontAwesome.ChevronUp => "fa-chevron-up",
            FontAwesome.Child => "fa-child",
            FontAwesome.Chrome => "fa-chrome",
            FontAwesome.Chromecast => "fa-chromecast",
            FontAwesome.Church => "fa-church",
            FontAwesome.Circle => "fa-circle",
            FontAwesome.CircleNotch => "fa-circle-notch",
            FontAwesome.City => "fa-city",
            FontAwesome.ClinicMedical => "fa-clinic-medical",
            FontAwesome.Clipboard => "fa-clipboard",
            FontAwesome.ClipboardCheck => "fa-clipboard-check",
            FontAwesome.ClipboardList => "fa-clipboard-list",
            FontAwesome.Clock => "fa-clock",
            FontAwesome.Clone => "fa-clone",
            FontAwesome.ClosedCaptioning => "fa-closed-captioning",
            FontAwesome.Cloud => "fa-cloud",
            FontAwesome.CloudDownloadAlt => "fa-cloud-download-alt",
            FontAwesome.CloudMeatball => "fa-cloud-meatball",
            FontAwesome.CloudMoon => "fa-cloud-moon",
            FontAwesome.CloudMoonRain => "fa-cloud-moon-rain",
            FontAwesome.CloudRain => "fa-cloud-rain",
            FontAwesome.Cloudscale => "fa-cloudscale",
            FontAwesome.CloudShowersHeavy => "fa-cloud-showers-heavy",
            FontAwesome.Cloudsmith => "fa-cloudsmith",
            FontAwesome.CloudSun => "fa-cloud-sun",
            FontAwesome.CloudSunRain => "fa-cloud-sun-rain",
            FontAwesome.CloudUploadAlt => "fa-cloud-upload-alt",
            FontAwesome.Cloudversify => "fa-cloudversify",
            FontAwesome.Cocktail => "fa-cocktail",
            FontAwesome.Code => "fa-code",
            FontAwesome.CodeBranch => "fa-code-branch",
            FontAwesome.Codepen => "fa-codepen",
            FontAwesome.Codiepie => "fa-codiepie",
            FontAwesome.Coffee => "fa-coffee",
            FontAwesome.Cog => "fa-cog",
            FontAwesome.Cogs => "fa-cogs",
            FontAwesome.Coins => "fa-coins",
            FontAwesome.Columns => "fa-columns",
            FontAwesome.Comment => "fa-comment",
            FontAwesome.CommentAlt => "fa-comment-alt",
            FontAwesome.CommentDollar => "fa-comment-dollar",
            FontAwesome.CommentDots => "fa-comment-dots",
            FontAwesome.CommentMedical => "fa-comment-medical",
            FontAwesome.Comments => "fa-comments",
            FontAwesome.CommentsDollar => "fa-comments-dollar",
            FontAwesome.CommentSlash => "fa-comment-slash",
            FontAwesome.CompactDisc => "fa-compact-disc",
            FontAwesome.Compass => "fa-compass",
            FontAwesome.Compress => "fa-compress",
            FontAwesome.CompressAlt => "fa-compress-alt",
            FontAwesome.CompressArrowsAlt => "fa-compress-arrows-alt",
            FontAwesome.ConciergeBell => "fa-concierge-bell",
            FontAwesome.Confluence => "fa-confluence",
            FontAwesome.Connectdevelop => "fa-connectdevelop",
            FontAwesome.Contao => "fa-contao",
            FontAwesome.Cookie => "fa-cookie",
            FontAwesome.CookieBite => "fa-cookie-bite",
            FontAwesome.Copy => "fa-copy",
            FontAwesome.Copyright => "fa-copyright",
            FontAwesome.CottonBureau => "fa-cotton-bureau",
            FontAwesome.Couch => "fa-couch",
            FontAwesome.Cpanel => "fa-cpanel",
            FontAwesome.CreativeCommons => "fa-creative-commons",
            FontAwesome.CreativeCommonsBy => "fa-creative-commons-by",
            FontAwesome.CreativeCommonsNc => "fa-creative-commons-nc",
            FontAwesome.CreativeCommonsNcEu => "fa-creative-commons-nc-eu",
            FontAwesome.CreativeCommonsNcJp => "fa-creative-commons-nc-jp",
            FontAwesome.CreativeCommonsNd => "fa-creative-commons-nd",
            FontAwesome.CreativeCommonsPd => "fa-creative-commons-pd",
            FontAwesome.CreativeCommonsPdAlt => "fa-creative-commons-pd-alt",
            FontAwesome.CreativeCommonsRemix => "fa-creative-commons-remix",
            FontAwesome.CreativeCommonsSa => "fa-creative-commons-sa",
            FontAwesome.CreativeCommonsSampling => "fa-creative-commons-sampling",
            FontAwesome.CreativeCommonsSamplingPlus => "fa-creative-commons-sampling-plus",
            FontAwesome.CreativeCommonsShare => "fa-creative-commons-share",
            FontAwesome.CreativeCommonsZero => "fa-creative-commons-zero",
            FontAwesome.CreditCard => "fa-credit-card",
            FontAwesome.CriticalRole => "fa-critical-role",
            FontAwesome.Crop => "fa-crop",
            FontAwesome.CropAlt => "fa-crop-alt",
            FontAwesome.Cross => "fa-cross",
            FontAwesome.Crosshairs => "fa-crosshairs",
            FontAwesome.Crow => "fa-crow",
            FontAwesome.Crown => "fa-crown",
            FontAwesome.Crutch => "fa-crutch",
            FontAwesome.Css3 => "fa-css3",
            FontAwesome.Css3Alt => "fa-css3-alt",
            FontAwesome.Cube => "fa-cube",
            FontAwesome.Cubes => "fa-cubes",
            FontAwesome.Cut => "fa-cut",
            FontAwesome.Cuttlefish => "fa-cuttlefish",
            FontAwesome.Dailymotion => "fa-dailymotion",
            FontAwesome.DAndD => "fa-d-and-d",
            FontAwesome.DAndDBeyond => "fa-d-and-d-beyond",
            FontAwesome.Dashcube => "fa-dashcube",
            FontAwesome.Database => "fa-database",
            FontAwesome.Deaf => "fa-deaf",
            FontAwesome.Delicious => "fa-delicious",
            FontAwesome.Democrat => "fa-democrat",
            FontAwesome.Deploydog => "fa-deploydog",
            FontAwesome.Deskpro => "fa-deskpro",
            FontAwesome.Desktop => "fa-desktop",
            FontAwesome.Dev => "fa-dev",
            FontAwesome.Deviantart => "fa-deviantart",
            FontAwesome.Dharmachakra => "fa-dharmachakra",
            FontAwesome.Dhl => "fa-dhl",
            FontAwesome.Diagnoses => "fa-diagnoses",
            FontAwesome.Diaspora => "fa-diaspora",
            FontAwesome.Dice => "fa-dice",
            FontAwesome.DiceD20 => "fa-dice-d20",
            FontAwesome.DiceD6 => "fa-dice-d6",
            FontAwesome.DiceFive => "fa-dice-five",
            FontAwesome.DiceFour => "fa-dice-four",
            FontAwesome.DiceOne => "fa-dice-one",
            FontAwesome.DiceSix => "fa-dice-six",
            FontAwesome.DiceThree => "fa-dice-three",
            FontAwesome.DiceTwo => "fa-dice-two",
            FontAwesome.Digg => "fa-digg",
            FontAwesome.DigitalOcean => "fa-digital-ocean",
            FontAwesome.DigitalTachograph => "fa-digital-tachograph",
            FontAwesome.Directions => "fa-directions",
            FontAwesome.Discord => "fa-discord",
            FontAwesome.Discourse => "fa-discourse",
            FontAwesome.Disease => "fa-disease",
            FontAwesome.Divide => "fa-divide",
            FontAwesome.Dizzy => "fa-dizzy",
            FontAwesome.Dna => "fa-dna",
            FontAwesome.Dochub => "fa-dochub",
            FontAwesome.Docker => "fa-docker",
            FontAwesome.Dog => "fa-dog",
            FontAwesome.DollarSign => "fa-dollar-sign",
            FontAwesome.Dolly => "fa-dolly",
            FontAwesome.DollyFlatbed => "fa-dolly-flatbed",
            FontAwesome.Donate => "fa-donate",
            FontAwesome.DoorClosed => "fa-door-closed",
            FontAwesome.DoorOpen => "fa-door-open",
            FontAwesome.DotCircle => "fa-dot-circle",
            FontAwesome.Dove => "fa-dove",
            FontAwesome.Download => "fa-download",
            FontAwesome.Draft2digital => "fa-draft2digital",
            FontAwesome.DraftingCompass => "fa-drafting-compass",
            FontAwesome.Dragon => "fa-dragon",
            FontAwesome.DrawPolygon => "fa-draw-polygon",
            FontAwesome.Dribbble => "fa-dribbble",
            FontAwesome.DribbbleSquare => "fa-dribbble-square",
            FontAwesome.Dropbox => "fa-dropbox",
            FontAwesome.Drum => "fa-drum",
            FontAwesome.DrumSteelpan => "fa-drum-steelpan",
            FontAwesome.DrumstickBite => "fa-drumstick-bite",
            FontAwesome.Drupal => "fa-drupal",
            FontAwesome.Dumbbell => "fa-dumbbell",
            FontAwesome.Dumpster => "fa-dumpster",
            FontAwesome.DumpsterFire => "fa-dumpster-fire",
            FontAwesome.Dungeon => "fa-dungeon",
            FontAwesome.Dyalog => "fa-dyalog",
            FontAwesome.Earlybirds => "fa-earlybirds",
            FontAwesome.Ebay => "fa-ebay",
            FontAwesome.Edge => "fa-edge",
            FontAwesome.Edit => "fa-edit",
            FontAwesome.Egg => "fa-egg",
            FontAwesome.Eject => "fa-eject",
            FontAwesome.Elementor => "fa-elementor",
            FontAwesome.EllipsisH => "fa-ellipsis-h",
            FontAwesome.EllipsisV => "fa-ellipsis-v",
            FontAwesome.Ello => "fa-ello",
            FontAwesome.Ember => "fa-ember",
            FontAwesome.Empire => "fa-empire",
            FontAwesome.Envelope => "fa-envelope",
            FontAwesome.EnvelopeOpen => "fa-envelope-open",
            FontAwesome.EnvelopeOpenText => "fa-envelope-open-text",
            FontAwesome.EnvelopeSquare => "fa-envelope-square",
            FontAwesome.Envira => "fa-envira",
            FontAwesome.Equals => "fa-equals",
            FontAwesome.Eraser => "fa-eraser",
            FontAwesome.Erlang => "fa-erlang",
            FontAwesome.Ethereum => "fa-ethereum",
            FontAwesome.Ethernet => "fa-ethernet",
            FontAwesome.Etsy => "fa-etsy",
            FontAwesome.EuroSign => "fa-euro-sign",
            FontAwesome.Evernote => "fa-evernote",
            FontAwesome.ExchangeAlt => "fa-exchange-alt",
            FontAwesome.Exclamation => "fa-exclamation",
            FontAwesome.ExclamationCircle => "fa-exclamation-circle",
            FontAwesome.ExclamationTriangle => "fa-exclamation-triangle",
            FontAwesome.Expand => "fa-expand",
            FontAwesome.ExpandAlt => "fa-expand-alt",
            FontAwesome.ExpandArrowsAlt => "fa-expand-arrows-alt",
            FontAwesome.Expeditedssl => "fa-expeditedssl",
            FontAwesome.ExternalLinkAlt => "fa-external-link-alt",
            FontAwesome.ExternalLinkSquareAlt => "fa-external-link-square-alt",
            FontAwesome.Eye => "fa-eye",
            FontAwesome.EyeDropper => "fa-eye-dropper",
            FontAwesome.EyeSlash => "fa-eye-slash",
            FontAwesome.Facebook => "fa-facebook",
            FontAwesome.FacebookF => "fa-facebook-f",
            FontAwesome.FacebookMessenger => "fa-facebook-messenger",
            FontAwesome.FacebookSquare => "fa-facebook-square",
            FontAwesome.Fan => "fa-fan",
            FontAwesome.FantasyFlightGames => "fa-fantasy-flight-games",
            FontAwesome.FastBackward => "fa-fast-backward",
            FontAwesome.FastForward => "fa-fast-forward",
            FontAwesome.Faucet => "fa-faucet",
            FontAwesome.Fax => "fa-fax",
            FontAwesome.Feather => "fa-feather",
            FontAwesome.FeatherAlt => "fa-feather-alt",
            FontAwesome.Fedex => "fa-fedex",
            FontAwesome.Fedora => "fa-fedora",
            FontAwesome.Female => "fa-female",
            FontAwesome.FighterJet => "fa-fighter-jet",
            FontAwesome.Figma => "fa-figma",
            FontAwesome.File => "fa-file",
            FontAwesome.FileAlt => "fa-file-alt",
            FontAwesome.FileArchive => "fa-file-archive",
            FontAwesome.FileAudio => "fa-file-audio",
            FontAwesome.FileCode => "fa-file-code",
            FontAwesome.FileContract => "fa-file-contract",
            FontAwesome.FileCsv => "fa-file-csv",
            FontAwesome.FileDownload => "fa-file-download",
            FontAwesome.FileExcel => "fa-file-excel",
            FontAwesome.FileExport => "fa-file-export",
            FontAwesome.FileImage => "fa-file-image",
            FontAwesome.FileImport => "fa-file-import",
            FontAwesome.FileInvoice => "fa-file-invoice",
            FontAwesome.FileInvoiceDollar => "fa-file-invoice-dollar",
            FontAwesome.FileMedical => "fa-file-medical",
            FontAwesome.FileMedicalAlt => "fa-file-medical-alt",
            FontAwesome.FilePdf => "fa-file-pdf",
            FontAwesome.FilePowerpoint => "fa-file-powerpoint",
            FontAwesome.FilePrescription => "fa-file-prescription",
            FontAwesome.FileSignature => "fa-file-signature",
            FontAwesome.FileUpload => "fa-file-upload",
            FontAwesome.FileVideo => "fa-file-video",
            FontAwesome.FileWord => "fa-file-word",
            FontAwesome.Fill => "fa-fill",
            FontAwesome.FillDrip => "fa-fill-drip",
            FontAwesome.Film => "fa-film",
            FontAwesome.Filter => "fa-filter",
            FontAwesome.Fingerprint => "fa-fingerprint",
            FontAwesome.Fire => "fa-fire",
            FontAwesome.FireAlt => "fa-fire-alt",
            FontAwesome.FireExtinguisher => "fa-fire-extinguisher",
            FontAwesome.Firefox => "fa-firefox",
            FontAwesome.FirefoxBrowser => "fa-firefox-browser",
            FontAwesome.FirstAid => "fa-first-aid",
            FontAwesome.Firstdraft => "fa-firstdraft",
            FontAwesome.FirstOrder => "fa-first-order",
            FontAwesome.FirstOrderAlt => "fa-first-order-alt",
            FontAwesome.Fish => "fa-fish",
            FontAwesome.FistRaised => "fa-fist-raised",
            FontAwesome.Flag => "fa-flag",
            FontAwesome.FlagCheckered => "fa-flag-checkered",
            FontAwesome.FlagUsa => "fa-flag-usa",
            FontAwesome.Flask => "fa-flask",
            FontAwesome.Flickr => "fa-flickr",
            FontAwesome.Flipboard => "fa-flipboard",
            FontAwesome.Flushed => "fa-flushed",
            FontAwesome.Fly => "fa-fly",
            FontAwesome.Folder => "fa-folder",
            FontAwesome.FolderMinus => "fa-folder-minus",
            FontAwesome.FolderOpen => "fa-folder-open",
            FontAwesome.FolderPlus => "fa-folder-plus",
            FontAwesome.Font => "fa-font",
            FontAwesome.FontAwesome => "fa-font-awesome",
            FontAwesome.FontAwesomeAlt => "fa-font-awesome-alt",
            FontAwesome.FontAwesomeFlag => "fa-font-awesome-flag",
            FontAwesome.FontAwesomeLogoFull => "fa-font-awesome-logo-full",
            FontAwesome.Fonticons => "fa-fonticons",
            FontAwesome.FonticonsFi => "fa-fonticons-fi",
            FontAwesome.FootballBall => "fa-football-ball",
            FontAwesome.FortAwesome => "fa-fort-awesome",
            FontAwesome.FortAwesomeAlt => "fa-fort-awesome-alt",
            FontAwesome.Forumbee => "fa-forumbee",
            FontAwesome.Forward => "fa-forward",
            FontAwesome.Foursquare => "fa-foursquare",
            FontAwesome.Freebsd => "fa-freebsd",
            FontAwesome.FreeCodeCamp => "fa-free-code-camp",
            FontAwesome.Frog => "fa-frog",
            FontAwesome.Frown => "fa-frown",
            FontAwesome.FrownOpen => "fa-frown-open",
            FontAwesome.Fulcrum => "fa-fulcrum",
            FontAwesome.FunnelDollar => "fa-funnel-dollar",
            FontAwesome.Futbol => "fa-futbol",
            FontAwesome.GalacticRepublic => "fa-galactic-republic",
            FontAwesome.GalacticSenate => "fa-galactic-senate",
            FontAwesome.Gamepad => "fa-gamepad",
            FontAwesome.GasPump => "fa-gas-pump",
            FontAwesome.Gavel => "fa-gavel",
            FontAwesome.Gem => "fa-gem",
            FontAwesome.Genderless => "fa-genderless",
            FontAwesome.GetPocket => "fa-get-pocket",
            FontAwesome.Gg => "fa-gg",
            FontAwesome.GgCircle => "fa-gg-circle",
            FontAwesome.Ghost => "fa-ghost",
            FontAwesome.Gift => "fa-gift",
            FontAwesome.Gifts => "fa-gifts",
            FontAwesome.Git => "fa-git",
            FontAwesome.GitAlt => "fa-git-alt",
            FontAwesome.Github => "fa-github",
            FontAwesome.GithubAlt => "fa-github-alt",
            FontAwesome.GithubSquare => "fa-github-square",
            FontAwesome.Gitkraken => "fa-gitkraken",
            FontAwesome.Gitlab => "fa-gitlab",
            FontAwesome.GitSquare => "fa-git-square",
            FontAwesome.Gitter => "fa-gitter",
            FontAwesome.GlassCheers => "fa-glass-cheers",
            FontAwesome.Glasses => "fa-glasses",
            FontAwesome.GlassMartini => "fa-glass-martini",
            FontAwesome.GlassMartiniAlt => "fa-glass-martini-alt",
            FontAwesome.GlassWhiskey => "fa-glass-whiskey",
            FontAwesome.Glide => "fa-glide",
            FontAwesome.GlideG => "fa-glide-g",
            FontAwesome.Globe => "fa-globe",
            FontAwesome.GlobeAfrica => "fa-globe-africa",
            FontAwesome.GlobeAmericas => "fa-globe-americas",
            FontAwesome.GlobeAsia => "fa-globe-asia",
            FontAwesome.GlobeEurope => "fa-globe-europe",
            FontAwesome.Gofore => "fa-gofore",
            FontAwesome.GolfBall => "fa-golf-ball",
            FontAwesome.Goodreads => "fa-goodreads",
            FontAwesome.GoodreadsG => "fa-goodreads-g",
            FontAwesome.Google => "fa-google",
            FontAwesome.GoogleDrive => "fa-google-drive",
            FontAwesome.GooglePlay => "fa-google-play",
            FontAwesome.GooglePlus => "fa-google-plus",
            FontAwesome.GooglePlusG => "fa-google-plus-g",
            FontAwesome.GooglePlusSquare => "fa-google-plus-square",
            FontAwesome.GoogleWallet => "fa-google-wallet",
            FontAwesome.Gopuram => "fa-gopuram",
            FontAwesome.GraduationCap => "fa-graduation-cap",
            FontAwesome.Gratipay => "fa-gratipay",
            FontAwesome.Grav => "fa-grav",
            FontAwesome.GreaterThan => "fa-greater-than",
            FontAwesome.GreaterThanEqual => "fa-greater-than-equal",
            FontAwesome.Grimace => "fa-grimace",
            FontAwesome.Grin => "fa-grin",
            FontAwesome.GrinAlt => "fa-grin-alt",
            FontAwesome.GrinBeam => "fa-grin-beam",
            FontAwesome.GrinBeamSweat => "fa-grin-beam-sweat",
            FontAwesome.GrinHearts => "fa-grin-hearts",
            FontAwesome.GrinSquint => "fa-grin-squint",
            FontAwesome.GrinSquintTears => "fa-grin-squint-tears",
            FontAwesome.GrinStars => "fa-grin-stars",
            FontAwesome.GrinTears => "fa-grin-tears",
            FontAwesome.GrinTongue => "fa-grin-tongue",
            FontAwesome.GrinTongueSquint => "fa-grin-tongue-squint",
            FontAwesome.GrinTongueWink => "fa-grin-tongue-wink",
            FontAwesome.GrinWink => "fa-grin-wink",
            FontAwesome.Gripfire => "fa-gripfire",
            FontAwesome.GripHorizontal => "fa-grip-horizontal",
            FontAwesome.GripLines => "fa-grip-lines",
            FontAwesome.GripLinesVertical => "fa-grip-lines-vertical",
            FontAwesome.GripVertical => "fa-grip-vertical",
            FontAwesome.Grunt => "fa-grunt",
            FontAwesome.Guitar => "fa-guitar",
            FontAwesome.Gulp => "fa-gulp",
            FontAwesome.HackerNews => "fa-hacker-news",
            FontAwesome.HackerNewsSquare => "fa-hacker-news-square",
            FontAwesome.Hackerrank => "fa-hackerrank",
            FontAwesome.Hamburger => "fa-hamburger",
            FontAwesome.Hammer => "fa-hammer",
            FontAwesome.Hamsa => "fa-hamsa",
            FontAwesome.HandHolding => "fa-hand-holding",
            FontAwesome.HandHoldingHeart => "fa-hand-holding-heart",
            FontAwesome.HandHoldingMedical => "fa-hand-holding-medical",
            FontAwesome.HandHoldingUsd => "fa-hand-holding-usd",
            FontAwesome.HandHoldingWater => "fa-hand-holding-water",
            FontAwesome.HandLizard => "fa-hand-lizard",
            FontAwesome.HandMiddleFinger => "fa-hand-middle-finger",
            FontAwesome.HandPaper => "fa-hand-paper",
            FontAwesome.HandPeace => "fa-hand-peace",
            FontAwesome.HandPointDown => "fa-hand-point-down",
            FontAwesome.HandPointer => "fa-hand-pointer",
            FontAwesome.HandPointLeft => "fa-hand-point-left",
            FontAwesome.HandPointRight => "fa-hand-point-right",
            FontAwesome.HandPointUp => "fa-hand-point-up",
            FontAwesome.HandRock => "fa-hand-rock",
            FontAwesome.Hands => "fa-hands",
            FontAwesome.HandScissors => "fa-hand-scissors",
            FontAwesome.Handshake => "fa-handshake",
            FontAwesome.HandshakeAltSlash => "fa-handshake-alt-slash",
            FontAwesome.HandshakeSlash => "fa-handshake-slash",
            FontAwesome.HandsHelping => "fa-hands-helping",
            FontAwesome.HandSparkles => "fa-hand-sparkles",
            FontAwesome.HandSpock => "fa-hand-spock",
            FontAwesome.HandsWash => "fa-hands-wash",
            FontAwesome.Hanukiah => "fa-hanukiah",
            FontAwesome.HardHat => "fa-hard-hat",
            FontAwesome.Hashtag => "fa-hashtag",
            FontAwesome.HatCowboy => "fa-hat-cowboy",
            FontAwesome.HatCowboySide => "fa-hat-cowboy-side",
            FontAwesome.HatWizard => "fa-hat-wizard",
            FontAwesome.Hdd => "fa-hdd",
            FontAwesome.Heading => "fa-heading",
            FontAwesome.Headphones => "fa-headphones",
            FontAwesome.HeadphonesAlt => "fa-headphones-alt",
            FontAwesome.Headset => "fa-headset",
            FontAwesome.HeadSideCough => "fa-head-side-cough",
            FontAwesome.HeadSideCoughSlash => "fa-head-side-cough-slash",
            FontAwesome.HeadSideMask => "fa-head-side-mask",
            FontAwesome.HeadSideVirus => "fa-head-side-virus",
            FontAwesome.Heart => "fa-heart",
            FontAwesome.Heartbeat => "fa-heartbeat",
            FontAwesome.HeartBroken => "fa-heart-broken",
            FontAwesome.Helicopter => "fa-helicopter",
            FontAwesome.Highlighter => "fa-highlighter",
            FontAwesome.Hiking => "fa-hiking",
            FontAwesome.Hippo => "fa-hippo",
            FontAwesome.Hips => "fa-hips",
            FontAwesome.HireAHelper => "fa-hire-a-helper",
            FontAwesome.History => "fa-history",
            FontAwesome.HockeyPuck => "fa-hockey-puck",
            FontAwesome.HollyBerry => "fa-holly-berry",
            FontAwesome.Home => "fa-home",
            FontAwesome.Hooli => "fa-hooli",
            FontAwesome.Hornbill => "fa-hornbill",
            FontAwesome.Horse => "fa-horse",
            FontAwesome.HorseHead => "fa-horse-head",
            FontAwesome.Hospital => "fa-hospital",
            FontAwesome.HospitalAlt => "fa-hospital-alt",
            FontAwesome.HospitalSymbol => "fa-hospital-symbol",
            FontAwesome.HospitalUser => "fa-hospital-user",
            FontAwesome.Hotdog => "fa-hotdog",
            FontAwesome.Hotel => "fa-hotel",
            FontAwesome.Hotjar => "fa-hotjar",
            FontAwesome.HotTub => "fa-hot-tub",
            FontAwesome.Hourglass => "fa-hourglass",
            FontAwesome.HourglassEnd => "fa-hourglass-end",
            FontAwesome.HourglassHalf => "fa-hourglass-half",
            FontAwesome.HourglassStart => "fa-hourglass-start",
            FontAwesome.HouseDamage => "fa-house-damage",
            FontAwesome.HouseUser => "fa-house-user",
            FontAwesome.Houzz => "fa-houzz",
            FontAwesome.Hryvnia => "fa-hryvnia",
            FontAwesome.HSquare => "fa-h-square",
            FontAwesome.Html5 => "fa-html5",
            FontAwesome.Hubspot => "fa-hubspot",
            FontAwesome.IceCream => "fa-ice-cream",
            FontAwesome.Icicles => "fa-icicles",
            FontAwesome.Icons => "fa-icons",
            FontAwesome.ICursor => "fa-i-cursor",
            FontAwesome.IdBadge => "fa-id-badge",
            FontAwesome.IdCard => "fa-id-card",
            FontAwesome.IdCardAlt => "fa-id-card-alt",
            FontAwesome.Ideal => "fa-ideal",
            FontAwesome.Igloo => "fa-igloo",
            FontAwesome.Image => "fa-image",
            FontAwesome.Images => "fa-images",
            FontAwesome.Imdb => "fa-imdb",
            FontAwesome.Inbox => "fa-inbox",
            FontAwesome.Indent => "fa-indent",
            FontAwesome.Industry => "fa-industry",
            FontAwesome.Infinity => "fa-infinity",
            FontAwesome.Info => "fa-info",
            FontAwesome.InfoCircle => "fa-info-circle",
            FontAwesome.Instagram => "fa-instagram",
            FontAwesome.InstagramSquare => "fa-instagram-square",
            FontAwesome.Intercom => "fa-intercom",
            FontAwesome.InternetExplorer => "fa-internet-explorer",
            FontAwesome.Invision => "fa-invision",
            FontAwesome.Ioxhost => "fa-ioxhost",
            FontAwesome.Italic => "fa-italic",
            FontAwesome.ItchIo => "fa-itch-io",
            FontAwesome.Itunes => "fa-itunes",
            FontAwesome.ItunesNote => "fa-itunes-note",
            FontAwesome.Java => "fa-java",
            FontAwesome.Jedi => "fa-jedi",
            FontAwesome.JediOrder => "fa-jedi-order",
            FontAwesome.Jenkins => "fa-jenkins",
            FontAwesome.Jira => "fa-jira",
            FontAwesome.Joget => "fa-joget",
            FontAwesome.Joint => "fa-joint",
            FontAwesome.Joomla => "fa-joomla",
            FontAwesome.JournalWhills => "fa-journal-whills",
            FontAwesome.Js => "fa-js",
            FontAwesome.Jsfiddle => "fa-jsfiddle",
            FontAwesome.JsSquare => "fa-js-square",
            FontAwesome.Kaaba => "fa-kaaba",
            FontAwesome.Kaggle => "fa-kaggle",
            FontAwesome.Key => "fa-key",
            FontAwesome.Keybase => "fa-keybase",
            FontAwesome.Keyboard => "fa-keyboard",
            FontAwesome.Keycdn => "fa-keycdn",
            FontAwesome.Khanda => "fa-khanda",
            FontAwesome.Kickstarter => "fa-kickstarter",
            FontAwesome.KickstarterK => "fa-kickstarter-k",
            FontAwesome.Kiss => "fa-kiss",
            FontAwesome.KissBeam => "fa-kiss-beam",
            FontAwesome.KissWinkHeart => "fa-kiss-wink-heart",
            FontAwesome.KiwiBird => "fa-kiwi-bird",
            FontAwesome.Korvue => "fa-korvue",
            FontAwesome.Landmark => "fa-landmark",
            FontAwesome.Language => "fa-language",
            FontAwesome.Laptop => "fa-laptop",
            FontAwesome.LaptopCode => "fa-laptop-code",
            FontAwesome.LaptopHouse => "fa-laptop-house",
            FontAwesome.LaptopMedical => "fa-laptop-medical",
            FontAwesome.Laravel => "fa-laravel",
            FontAwesome.Lastfm => "fa-lastfm",
            FontAwesome.LastfmSquare => "fa-lastfm-square",
            FontAwesome.Laugh => "fa-laugh",
            FontAwesome.LaughBeam => "fa-laugh-beam",
            FontAwesome.LaughSquint => "fa-laugh-squint",
            FontAwesome.LaughWink => "fa-laugh-wink",
            FontAwesome.LayerGroup => "fa-layer-group",
            FontAwesome.Leaf => "fa-leaf",
            FontAwesome.Leanpub => "fa-leanpub",
            FontAwesome.Lemon => "fa-lemon",
            FontAwesome.Less => "fa-less",
            FontAwesome.LessThan => "fa-less-than",
            FontAwesome.LessThanEqual => "fa-less-than-equal",
            FontAwesome.LevelDownAlt => "fa-level-down-alt",
            FontAwesome.LevelUpAlt => "fa-level-up-alt",
            FontAwesome.LifeRing => "fa-life-ring",
            FontAwesome.Lightbulb => "fa-lightbulb",
            FontAwesome.Line => "fa-line",
            FontAwesome.Link => "fa-link",
            FontAwesome.Linkedin => "fa-linkedin",
            FontAwesome.LinkedinIn => "fa-linkedin-in",
            FontAwesome.Linode => "fa-linode",
            FontAwesome.Linux => "fa-linux",
            FontAwesome.LiraSign => "fa-lira-sign",
            FontAwesome.List => "fa-list",
            FontAwesome.ListAlt => "fa-list-alt",
            FontAwesome.ListOl => "fa-list-ol",
            FontAwesome.ListUl => "fa-list-ul",
            FontAwesome.LocationArrow => "fa-location-arrow",
            FontAwesome.Lock => "fa-lock",
            FontAwesome.LockOpen => "fa-lock-open",
            FontAwesome.LongArrowAltDown => "fa-long-arrow-alt-down",
            FontAwesome.LongArrowAltLeft => "fa-long-arrow-alt-left",
            FontAwesome.LongArrowAltRight => "fa-long-arrow-alt-right",
            FontAwesome.LongArrowAltUp => "fa-long-arrow-alt-up",
            FontAwesome.LowVision => "fa-low-vision",
            FontAwesome.LuggageCart => "fa-luggage-cart",
            FontAwesome.Lungs => "fa-lungs",
            FontAwesome.LungsVirus => "fa-lungs-virus",
            FontAwesome.Lyft => "fa-lyft",
            FontAwesome.Magento => "fa-magento",
            FontAwesome.Magic => "fa-magic",
            FontAwesome.Magnet => "fa-magnet",
            FontAwesome.MailBulk => "fa-mail-bulk",
            FontAwesome.Mailchimp => "fa-mailchimp",
            FontAwesome.Male => "fa-male",
            FontAwesome.Mandalorian => "fa-mandalorian",
            FontAwesome.Map => "fa-map",
            FontAwesome.MapMarked => "fa-map-marked",
            FontAwesome.MapMarkedAlt => "fa-map-marked-alt",
            FontAwesome.MapMarker => "fa-map-marker",
            FontAwesome.MapMarkerAlt => "fa-map-marker-alt",
            FontAwesome.MapPin => "fa-map-pin",
            FontAwesome.MapSigns => "fa-map-signs",
            FontAwesome.Markdown => "fa-markdown",
            FontAwesome.Marker => "fa-marker",
            FontAwesome.Mars => "fa-mars",
            FontAwesome.MarsDouble => "fa-mars-double",
            FontAwesome.MarsStroke => "fa-mars-stroke",
            FontAwesome.MarsStrokeH => "fa-mars-stroke-h",
            FontAwesome.MarsStrokeV => "fa-mars-stroke-v",
            FontAwesome.Mask => "fa-mask",
            FontAwesome.Mastodon => "fa-mastodon",
            FontAwesome.Maxcdn => "fa-maxcdn",
            FontAwesome.Mdb => "fa-mdb",
            FontAwesome.Medal => "fa-medal",
            FontAwesome.Medapps => "fa-medapps",
            FontAwesome.Medium => "fa-medium",
            FontAwesome.MediumM => "fa-medium-m",
            FontAwesome.Medkit => "fa-medkit",
            FontAwesome.Medrt => "fa-medrt",
            FontAwesome.Meetup => "fa-meetup",
            FontAwesome.Megaport => "fa-megaport",
            FontAwesome.Meh => "fa-meh",
            FontAwesome.MehBlank => "fa-meh-blank",
            FontAwesome.MehRollingEyes => "fa-meh-rolling-eyes",
            FontAwesome.Memory => "fa-memory",
            FontAwesome.Mendeley => "fa-mendeley",
            FontAwesome.Menorah => "fa-menorah",
            FontAwesome.Mercury => "fa-mercury",
            FontAwesome.Meteor => "fa-meteor",
            FontAwesome.Microblog => "fa-microblog",
            FontAwesome.Microchip => "fa-microchip",
            FontAwesome.Microphone => "fa-microphone",
            FontAwesome.MicrophoneAlt => "fa-microphone-alt",
            FontAwesome.MicrophoneAltSlash => "fa-microphone-alt-slash",
            FontAwesome.MicrophoneSlash => "fa-microphone-slash",
            FontAwesome.Microscope => "fa-microscope",
            FontAwesome.Microsoft => "fa-microsoft",
            FontAwesome.Minus => "fa-minus",
            FontAwesome.MinusCircle => "fa-minus-circle",
            FontAwesome.MinusSquare => "fa-minus-square",
            FontAwesome.Mitten => "fa-mitten",
            FontAwesome.Mix => "fa-mix",
            FontAwesome.Mixcloud => "fa-mixcloud",
            FontAwesome.Mixer => "fa-mixer",
            FontAwesome.Mizuni => "fa-mizuni",
            FontAwesome.Mobile => "fa-mobile",
            FontAwesome.MobileAlt => "fa-mobile-alt",
            FontAwesome.Modx => "fa-modx",
            FontAwesome.Monero => "fa-monero",
            FontAwesome.MoneyBill => "fa-money-bill",
            FontAwesome.MoneyBillAlt => "fa-money-bill-alt",
            FontAwesome.MoneyBillWave => "fa-money-bill-wave",
            FontAwesome.MoneyBillWaveAlt => "fa-money-bill-wave-alt",
            FontAwesome.MoneyCheck => "fa-money-check",
            FontAwesome.MoneyCheckAlt => "fa-money-check-alt",
            FontAwesome.Monument => "fa-monument",
            FontAwesome.Moon => "fa-moon",
            FontAwesome.MortarPestle => "fa-mortar-pestle",
            FontAwesome.Mosque => "fa-mosque",
            FontAwesome.Motorcycle => "fa-motorcycle",
            FontAwesome.Mountain => "fa-mountain",
            FontAwesome.Mouse => "fa-mouse",
            FontAwesome.MousePointer => "fa-mouse-pointer",
            FontAwesome.MugHot => "fa-mug-hot",
            FontAwesome.Music => "fa-music",
            FontAwesome.Napster => "fa-napster",
            FontAwesome.Neos => "fa-neos",
            FontAwesome.NetworkWired => "fa-network-wired",
            FontAwesome.Neuter => "fa-neuter",
            FontAwesome.Newspaper => "fa-newspaper",
            FontAwesome.Nimblr => "fa-nimblr",
            FontAwesome.Node => "fa-node",
            FontAwesome.NodeJs => "fa-node-js",
            FontAwesome.NotEqual => "fa-not-equal",
            FontAwesome.NotesMedical => "fa-notes-medical",
            FontAwesome.Npm => "fa-npm",
            FontAwesome.Ns8 => "fa-ns8",
            FontAwesome.Nutritionix => "fa-nutritionix",
            FontAwesome.ObjectGroup => "fa-object-group",
            FontAwesome.ObjectUngroup => "fa-object-ungroup",
            FontAwesome.Odnoklassniki => "fa-odnoklassniki",
            FontAwesome.OdnoklassnikiSquare => "fa-odnoklassniki-square",
            FontAwesome.OilCan => "fa-oil-can",
            FontAwesome.OldRepublic => "fa-old-republic",
            FontAwesome.Om => "fa-om",
            FontAwesome.Opencart => "fa-opencart",
            FontAwesome.Openid => "fa-openid",
            FontAwesome.Opera => "fa-opera",
            FontAwesome.OptinMonster => "fa-optin-monster",
            FontAwesome.Orcid => "fa-orcid",
            FontAwesome.Osi => "fa-osi",
            FontAwesome.Otter => "fa-otter",
            FontAwesome.Outdent => "fa-outdent",
            FontAwesome.Page4 => "fa-page4",
            FontAwesome.Pagelines => "fa-pagelines",
            FontAwesome.Pager => "fa-pager",
            FontAwesome.PaintBrush => "fa-paint-brush",
            FontAwesome.PaintRoller => "fa-paint-roller",
            FontAwesome.Palette => "fa-palette",
            FontAwesome.Palfed => "fa-palfed",
            FontAwesome.Pallet => "fa-pallet",
            FontAwesome.Paperclip => "fa-paperclip",
            FontAwesome.PaperPlane => "fa-paper-plane",
            FontAwesome.ParachuteBox => "fa-parachute-box",
            FontAwesome.Paragraph => "fa-paragraph",
            FontAwesome.Parking => "fa-parking",
            FontAwesome.Passport => "fa-passport",
            FontAwesome.Pastafarianism => "fa-pastafarianism",
            FontAwesome.Paste => "fa-paste",
            FontAwesome.Patreon => "fa-patreon",
            FontAwesome.Pause => "fa-pause",
            FontAwesome.PauseCircle => "fa-pause-circle",
            FontAwesome.Paw => "fa-paw",
            FontAwesome.Paypal => "fa-paypal",
            FontAwesome.Peace => "fa-peace",
            FontAwesome.Pen => "fa-pen",
            FontAwesome.PenAlt => "fa-pen-alt",
            FontAwesome.PencilAlt => "fa-pencil-alt",
            FontAwesome.PencilRuler => "fa-pencil-ruler",
            FontAwesome.PenFancy => "fa-pen-fancy",
            FontAwesome.PenNib => "fa-pen-nib",
            FontAwesome.PennyArcade => "fa-penny-arcade",
            FontAwesome.PenSquare => "fa-pen-square",
            FontAwesome.PeopleArrows => "fa-people-arrows",
            FontAwesome.PeopleCarry => "fa-people-carry",
            FontAwesome.PepperHot => "fa-pepper-hot",
            FontAwesome.Percent => "fa-percent",
            FontAwesome.Percentage => "fa-percentage",
            FontAwesome.Periscope => "fa-periscope",
            FontAwesome.PersonBooth => "fa-person-booth",
            FontAwesome.Phabricator => "fa-phabricator",
            FontAwesome.PhoenixFramework => "fa-phoenix-framework",
            FontAwesome.PhoenixSquadron => "fa-phoenix-squadron",
            FontAwesome.Phone => "fa-phone",
            FontAwesome.PhoneAlt => "fa-phone-alt",
            FontAwesome.PhoneSlash => "fa-phone-slash",
            FontAwesome.PhoneSquare => "fa-phone-square",
            FontAwesome.PhoneSquareAlt => "fa-phone-square-alt",
            FontAwesome.PhoneVolume => "fa-phone-volume",
            FontAwesome.PhotoVideo => "fa-photo-video",
            FontAwesome.Php => "fa-php",
            FontAwesome.PiedPiper => "fa-pied-piper",
            FontAwesome.PiedPiperAlt => "fa-pied-piper-alt",
            FontAwesome.PiedPiperHat => "fa-pied-piper-hat",
            FontAwesome.PiedPiperPp => "fa-pied-piper-pp",
            FontAwesome.PiedPiperSquare => "fa-pied-piper-square",
            FontAwesome.PiggyBank => "fa-piggy-bank",
            FontAwesome.Pills => "fa-pills",
            FontAwesome.Pinterest => "fa-pinterest",
            FontAwesome.PinterestP => "fa-pinterest-p",
            FontAwesome.PinterestSquare => "fa-pinterest-square",
            FontAwesome.PizzaSlice => "fa-pizza-slice",
            FontAwesome.PlaceOfWorship => "fa-place-of-worship",
            FontAwesome.Plane => "fa-plane",
            FontAwesome.PlaneArrival => "fa-plane-arrival",
            FontAwesome.PlaneDeparture => "fa-plane-departure",
            FontAwesome.PlaneSlash => "fa-plane-slash",
            FontAwesome.Play => "fa-play",
            FontAwesome.PlayCircle => "fa-play-circle",
            FontAwesome.Playstation => "fa-playstation",
            FontAwesome.Plug => "fa-plug",
            FontAwesome.Plus => "fa-plus",
            FontAwesome.PlusCircle => "fa-plus-circle",
            FontAwesome.PlusSquare => "fa-plus-square",
            FontAwesome.Podcast => "fa-podcast",
            FontAwesome.Poll => "fa-poll",
            FontAwesome.PollH => "fa-poll-h",
            FontAwesome.Poo => "fa-poo",
            FontAwesome.Poop => "fa-poop",
            FontAwesome.PooStorm => "fa-poo-storm",
            FontAwesome.Portrait => "fa-portrait",
            FontAwesome.PoundSign => "fa-pound-sign",
            FontAwesome.PowerOff => "fa-power-off",
            FontAwesome.Pray => "fa-pray",
            FontAwesome.PrayingHands => "fa-praying-hands",
            FontAwesome.Prescription => "fa-prescription",
            FontAwesome.PrescriptionBottle => "fa-prescription-bottle",
            FontAwesome.PrescriptionBottleAlt => "fa-prescription-bottle-alt",
            FontAwesome.Print => "fa-print",
            FontAwesome.Procedures => "fa-procedures",
            FontAwesome.ProductHunt => "fa-product-hunt",
            FontAwesome.ProjectDiagram => "fa-project-diagram",
            FontAwesome.PumpMedical => "fa-pump-medical",
            FontAwesome.PumpSoap => "fa-pump-soap",
            FontAwesome.Pushed => "fa-pushed",
            FontAwesome.PuzzlePiece => "fa-puzzle-piece",
            FontAwesome.Python => "fa-python",
            FontAwesome.Qq => "fa-qq",
            FontAwesome.Qrcode => "fa-qrcode",
            FontAwesome.Question => "fa-question",
            FontAwesome.QuestionCircle => "fa-question-circle",
            FontAwesome.Quidditch => "fa-quidditch",
            FontAwesome.Quinscape => "fa-quinscape",
            FontAwesome.Quora => "fa-quora",
            FontAwesome.QuoteLeft => "fa-quote-left",
            FontAwesome.QuoteRight => "fa-quote-right",
            FontAwesome.Quran => "fa-quran",
            FontAwesome.Radiation => "fa-radiation",
            FontAwesome.RadiationAlt => "fa-radiation-alt",
            FontAwesome.Rainbow => "fa-rainbow",
            FontAwesome.Random => "fa-random",
            FontAwesome.RaspberryPi => "fa-raspberry-pi",
            FontAwesome.Ravelry => "fa-ravelry",
            FontAwesome.React => "fa-react",
            FontAwesome.Reacteurope => "fa-reacteurope",
            FontAwesome.Readme => "fa-readme",
            FontAwesome.Rebel => "fa-rebel",
            FontAwesome.Receipt => "fa-receipt",
            FontAwesome.RecordVinyl => "fa-record-vinyl",
            FontAwesome.Recycle => "fa-recycle",
            FontAwesome.Reddit => "fa-reddit",
            FontAwesome.RedditAlien => "fa-reddit-alien",
            FontAwesome.RedditSquare => "fa-reddit-square",
            FontAwesome.Redhat => "fa-redhat",
            FontAwesome.Redo => "fa-redo",
            FontAwesome.RedoAlt => "fa-redo-alt",
            FontAwesome.RedRiver => "fa-red-river",
            FontAwesome.Registered => "fa-registered",
            FontAwesome.RemoveFormat => "fa-remove-format",
            FontAwesome.Renren => "fa-renren",
            FontAwesome.Reply => "fa-reply",
            FontAwesome.ReplyAll => "fa-reply-all",
            FontAwesome.Replyd => "fa-replyd",
            FontAwesome.Republican => "fa-republican",
            FontAwesome.Researchgate => "fa-researchgate",
            FontAwesome.Resolving => "fa-resolving",
            FontAwesome.Restroom => "fa-restroom",
            FontAwesome.Retweet => "fa-retweet",
            FontAwesome.Rev => "fa-rev",
            FontAwesome.Ribbon => "fa-ribbon",
            FontAwesome.Ring => "fa-ring",
            FontAwesome.Road => "fa-road",
            FontAwesome.Robot => "fa-robot",
            FontAwesome.Rocket => "fa-rocket",
            FontAwesome.Rocketchat => "fa-rocketchat",
            FontAwesome.Rockrms => "fa-rockrms",
            FontAwesome.Route => "fa-route",
            FontAwesome.RProject => "fa-r-project",
            FontAwesome.Rss => "fa-rss",
            FontAwesome.RssSquare => "fa-rss-square",
            FontAwesome.RubleSign => "fa-ruble-sign",
            FontAwesome.Ruler => "fa-ruler",
            FontAwesome.RulerCombined => "fa-ruler-combined",
            FontAwesome.RulerHorizontal => "fa-ruler-horizontal",
            FontAwesome.RulerVertical => "fa-ruler-vertical",
            FontAwesome.Running => "fa-running",
            FontAwesome.RupeeSign => "fa-rupee-sign",
            FontAwesome.SadCry => "fa-sad-cry",
            FontAwesome.SadTear => "fa-sad-tear",
            FontAwesome.Safari => "fa-safari",
            FontAwesome.Salesforce => "fa-salesforce",
            FontAwesome.Sass => "fa-sass",
            FontAwesome.Satellite => "fa-satellite",
            FontAwesome.SatelliteDish => "fa-satellite-dish",
            FontAwesome.Save => "fa-save",
            FontAwesome.Schlix => "fa-schlix",
            FontAwesome.School => "fa-school",
            FontAwesome.Screwdriver => "fa-screwdriver",
            FontAwesome.Scribd => "fa-scribd",
            FontAwesome.Scroll => "fa-scroll",
            FontAwesome.SdCard => "fa-sd-card",
            FontAwesome.Search => "fa-search",
            FontAwesome.SearchDollar => "fa-search-dollar",
            FontAwesome.Searchengin => "fa-searchengin",
            FontAwesome.SearchLocation => "fa-search-location",
            FontAwesome.SearchMinus => "fa-search-minus",
            FontAwesome.SearchPlus => "fa-search-plus",
            FontAwesome.Seedling => "fa-seedling",
            FontAwesome.Sellcast => "fa-sellcast",
            FontAwesome.Sellsy => "fa-sellsy",
            FontAwesome.Server => "fa-server",
            FontAwesome.Servicestack => "fa-servicestack",
            FontAwesome.Shapes => "fa-shapes",
            FontAwesome.Share => "fa-share",
            FontAwesome.ShareAlt => "fa-share-alt",
            FontAwesome.ShareAltSquare => "fa-share-alt-square",
            FontAwesome.ShareSquare => "fa-share-square",
            FontAwesome.ShekelSign => "fa-shekel-sign",
            FontAwesome.ShieldAlt => "fa-shield-alt",
            FontAwesome.ShieldVirus => "fa-shield-virus",
            FontAwesome.Ship => "fa-ship",
            FontAwesome.ShippingFast => "fa-shipping-fast",
            FontAwesome.Shirtsinbulk => "fa-shirtsinbulk",
            FontAwesome.ShoePrints => "fa-shoe-prints",
            FontAwesome.Shopify => "fa-shopify",
            FontAwesome.ShoppingBag => "fa-shopping-bag",
            FontAwesome.ShoppingBasket => "fa-shopping-basket",
            FontAwesome.ShoppingCart => "fa-shopping-cart",
            FontAwesome.Shopware => "fa-shopware",
            FontAwesome.Shower => "fa-shower",
            FontAwesome.ShuttleVan => "fa-shuttle-van",
            FontAwesome.Sign => "fa-sign",
            FontAwesome.Signal => "fa-signal",
            FontAwesome.Signature => "fa-signature",
            FontAwesome.SignInAlt => "fa-sign-in-alt",
            FontAwesome.SignLanguage => "fa-sign-language",
            FontAwesome.SignOutAlt => "fa-sign-out-alt",
            FontAwesome.SimCard => "fa-sim-card",
            FontAwesome.Simplybuilt => "fa-simplybuilt",
            FontAwesome.Sistrix => "fa-sistrix",
            FontAwesome.Sitemap => "fa-sitemap",
            FontAwesome.Sith => "fa-sith",
            FontAwesome.Skating => "fa-skating",
            FontAwesome.Sketch => "fa-sketch",
            FontAwesome.Skiing => "fa-skiing",
            FontAwesome.SkiingNordic => "fa-skiing-nordic",
            FontAwesome.Skull => "fa-skull",
            FontAwesome.SkullCrossbones => "fa-skull-crossbones",
            FontAwesome.Skyatlas => "fa-skyatlas",
            FontAwesome.Skype => "fa-skype",
            FontAwesome.Slack => "fa-slack",
            FontAwesome.SlackHash => "fa-slack-hash",
            FontAwesome.Slash => "fa-slash",
            FontAwesome.Sleigh => "fa-sleigh",
            FontAwesome.SlidersH => "fa-sliders-h",
            FontAwesome.Slideshare => "fa-slideshare",
            FontAwesome.Smile => "fa-smile",
            FontAwesome.SmileBeam => "fa-smile-beam",
            FontAwesome.SmileWink => "fa-smile-wink",
            FontAwesome.Smog => "fa-smog",
            FontAwesome.Smoking => "fa-smoking",
            FontAwesome.SmokingBan => "fa-smoking-ban",
            FontAwesome.Sms => "fa-sms",
            FontAwesome.Snapchat => "fa-snapchat",
            FontAwesome.SnapchatGhost => "fa-snapchat-ghost",
            FontAwesome.SnapchatSquare => "fa-snapchat-square",
            FontAwesome.Snowboarding => "fa-snowboarding",
            FontAwesome.Snowflake => "fa-snowflake",
            FontAwesome.Snowman => "fa-snowman",
            FontAwesome.Snowplow => "fa-snowplow",
            FontAwesome.Soap => "fa-soap",
            FontAwesome.Socks => "fa-socks",
            FontAwesome.SolarPanel => "fa-solar-panel",
            FontAwesome.Sort => "fa-sort",
            FontAwesome.SortAlphaDown => "fa-sort-alpha-down",
            FontAwesome.SortAlphaDownAlt => "fa-sort-alpha-down-alt",
            FontAwesome.SortAlphaUp => "fa-sort-alpha-up",
            FontAwesome.SortAlphaUpAlt => "fa-sort-alpha-up-alt",
            FontAwesome.SortAmountDown => "fa-sort-amount-down",
            FontAwesome.SortAmountDownAlt => "fa-sort-amount-down-alt",
            FontAwesome.SortAmountUp => "fa-sort-amount-up",
            FontAwesome.SortAmountUpAlt => "fa-sort-amount-up-alt",
            FontAwesome.SortDown => "fa-sort-down",
            FontAwesome.SortNumericDown => "fa-sort-numeric-down",
            FontAwesome.SortNumericDownAlt => "fa-sort-numeric-down-alt",
            FontAwesome.SortNumericUp => "fa-sort-numeric-up",
            FontAwesome.SortNumericUpAlt => "fa-sort-numeric-up-alt",
            FontAwesome.SortUp => "fa-sort-up",
            FontAwesome.Soundcloud => "fa-soundcloud",
            FontAwesome.Sourcetree => "fa-sourcetree",
            FontAwesome.Spa => "fa-spa",
            FontAwesome.SpaceShuttle => "fa-space-shuttle",
            FontAwesome.Speakap => "fa-speakap",
            FontAwesome.SpeakerDeck => "fa-speaker-deck",
            FontAwesome.SpellCheck => "fa-spell-check",
            FontAwesome.Spider => "fa-spider",
            FontAwesome.Spinner => "fa-spinner",
            FontAwesome.Splotch => "fa-splotch",
            FontAwesome.Spotify => "fa-spotify",
            FontAwesome.SprayCan => "fa-spray-can",
            FontAwesome.Square => "fa-square",
            FontAwesome.SquareFull => "fa-square-full",
            FontAwesome.SquareRootAlt => "fa-square-root-alt",
            FontAwesome.Squarespace => "fa-squarespace",
            FontAwesome.StackExchange => "fa-stack-exchange",
            FontAwesome.StackOverflow => "fa-stack-overflow",
            FontAwesome.Stackpath => "fa-stackpath",
            FontAwesome.Stamp => "fa-stamp",
            FontAwesome.Star => "fa-star",
            FontAwesome.StarAndCrescent => "fa-star-and-crescent",
            FontAwesome.StarHalf => "fa-star-half",
            FontAwesome.StarHalfAlt => "fa-star-half-alt",
            FontAwesome.StarOfDavid => "fa-star-of-david",
            FontAwesome.StarOfLife => "fa-star-of-life",
            FontAwesome.Staylinked => "fa-staylinked",
            FontAwesome.Steam => "fa-steam",
            FontAwesome.SteamSquare => "fa-steam-square",
            FontAwesome.SteamSymbol => "fa-steam-symbol",
            FontAwesome.StepBackward => "fa-step-backward",
            FontAwesome.StepForward => "fa-step-forward",
            FontAwesome.Stethoscope => "fa-stethoscope",
            FontAwesome.StickerMule => "fa-sticker-mule",
            FontAwesome.StickyNote => "fa-sticky-note",
            FontAwesome.Stop => "fa-stop",
            FontAwesome.StopCircle => "fa-stop-circle",
            FontAwesome.Stopwatch => "fa-stopwatch",
            FontAwesome.Stopwatch20 => "fa-stopwatch-20",
            FontAwesome.Store => "fa-store",
            FontAwesome.StoreAlt => "fa-store-alt",
            FontAwesome.StoreAltSlash => "fa-store-alt-slash",
            FontAwesome.StoreSlash => "fa-store-slash",
            FontAwesome.Strava => "fa-strava",
            FontAwesome.Stream => "fa-stream",
            FontAwesome.StreetView => "fa-street-view",
            FontAwesome.Strikethrough => "fa-strikethrough",
            FontAwesome.Stripe => "fa-stripe",
            FontAwesome.StripeS => "fa-stripe-s",
            FontAwesome.Stroopwafel => "fa-stroopwafel",
            FontAwesome.Studiovinari => "fa-studiovinari",
            FontAwesome.Stumbleupon => "fa-stumbleupon",
            FontAwesome.StumbleuponCircle => "fa-stumbleupon-circle",
            FontAwesome.Subscript => "fa-subscript",
            FontAwesome.Subway => "fa-subway",
            FontAwesome.Suitcase => "fa-suitcase",
            FontAwesome.SuitcaseRolling => "fa-suitcase-rolling",
            FontAwesome.Sun => "fa-sun",
            FontAwesome.Superpowers => "fa-superpowers",
            FontAwesome.Superscript => "fa-superscript",
            FontAwesome.Supple => "fa-supple",
            FontAwesome.Surprise => "fa-surprise",
            FontAwesome.Suse => "fa-suse",
            FontAwesome.Swatchbook => "fa-swatchbook",
            FontAwesome.Swift => "fa-swift",
            FontAwesome.Swimmer => "fa-swimmer",
            FontAwesome.SwimmingPool => "fa-swimming-pool",
            FontAwesome.Symfony => "fa-symfony",
            FontAwesome.Synagogue => "fa-synagogue",
            FontAwesome.Sync => "fa-sync",
            FontAwesome.SyncAlt => "fa-sync-alt",
            FontAwesome.Syringe => "fa-syringe",
            FontAwesome.Table => "fa-table",
            FontAwesome.Tablet => "fa-tablet",
            FontAwesome.TabletAlt => "fa-tablet-alt",
            FontAwesome.TableTennis => "fa-table-tennis",
            FontAwesome.Tablets => "fa-tablets",
            FontAwesome.TachometerAlt => "fa-tachometer-alt",
            FontAwesome.Tag => "fa-tag",
            FontAwesome.Tags => "fa-tags",
            FontAwesome.Tape => "fa-tape",
            FontAwesome.Tasks => "fa-tasks",
            FontAwesome.Taxi => "fa-taxi",
            FontAwesome.Teamspeak => "fa-teamspeak",
            FontAwesome.Teeth => "fa-teeth",
            FontAwesome.TeethOpen => "fa-teeth-open",
            FontAwesome.Telegram => "fa-telegram",
            FontAwesome.TelegramPlane => "fa-telegram-plane",
            FontAwesome.TemperatureHigh => "fa-temperature-high",
            FontAwesome.TemperatureLow => "fa-temperature-low",
            FontAwesome.TencentWeibo => "fa-tencent-weibo",
            FontAwesome.Tenge => "fa-tenge",
            FontAwesome.Terminal => "fa-terminal",
            FontAwesome.TextHeight => "fa-text-height",
            FontAwesome.TextWidth => "fa-text-width",
            FontAwesome.Th => "fa-th",
            FontAwesome.TheaterMasks => "fa-theater-masks",
            FontAwesome.Themeco => "fa-themeco",
            FontAwesome.Themeisle => "fa-themeisle",
            FontAwesome.TheRedYeti => "fa-the-red-yeti",
            FontAwesome.Thermometer => "fa-thermometer",
            FontAwesome.ThermometerEmpty => "fa-thermometer-empty",
            FontAwesome.ThermometerFull => "fa-thermometer-full",
            FontAwesome.ThermometerHalf => "fa-thermometer-half",
            FontAwesome.ThermometerQuarter => "fa-thermometer-quarter",
            FontAwesome.ThermometerThreeQuarters => "fa-thermometer-three-quarters",
            FontAwesome.ThinkPeaks => "fa-think-peaks",
            FontAwesome.ThLarge => "fa-th-large",
            FontAwesome.ThList => "fa-th-list",
            FontAwesome.ThumbsDown => "fa-thumbs-down",
            FontAwesome.ThumbsUp => "fa-thumbs-up",
            FontAwesome.Thumbtack => "fa-thumbtack",
            FontAwesome.TicketAlt => "fa-ticket-alt",
            FontAwesome.Times => "fa-times",
            FontAwesome.TimesCircle => "fa-times-circle",
            FontAwesome.Tint => "fa-tint",
            FontAwesome.TintSlash => "fa-tint-slash",
            FontAwesome.Tired => "fa-tired",
            FontAwesome.ToggleOff => "fa-toggle-off",
            FontAwesome.ToggleOn => "fa-toggle-on",
            FontAwesome.Toilet => "fa-toilet",
            FontAwesome.ToiletPaper => "fa-toilet-paper",
            FontAwesome.ToiletPaperSlash => "fa-toilet-paper-slash",
            FontAwesome.Toolbox => "fa-toolbox",
            FontAwesome.Tools => "fa-tools",
            FontAwesome.Tooth => "fa-tooth",
            FontAwesome.Torah => "fa-torah",
            FontAwesome.ToriiGate => "fa-torii-gate",
            FontAwesome.Tractor => "fa-tractor",
            FontAwesome.TradeFederation => "fa-trade-federation",
            FontAwesome.Trademark => "fa-trademark",
            FontAwesome.TrafficLight => "fa-traffic-light",
            FontAwesome.Trailer => "fa-trailer",
            FontAwesome.Train => "fa-train",
            FontAwesome.Tram => "fa-tram",
            FontAwesome.Transgender => "fa-transgender",
            FontAwesome.TransgenderAlt => "fa-transgender-alt",
            FontAwesome.Trash => "fa-trash",
            FontAwesome.TrashAlt => "fa-trash-alt",
            FontAwesome.TrashRestore => "fa-trash-restore",
            FontAwesome.TrashRestoreAlt => "fa-trash-restore-alt",
            FontAwesome.Tree => "fa-tree",
            FontAwesome.Trello => "fa-trello",
            FontAwesome.Tripadvisor => "fa-tripadvisor",
            FontAwesome.Trophy => "fa-trophy",
            FontAwesome.Truck => "fa-truck",
            FontAwesome.TruckLoading => "fa-truck-loading",
            FontAwesome.TruckMonster => "fa-truck-monster",
            FontAwesome.TruckMoving => "fa-truck-moving",
            FontAwesome.TruckPickup => "fa-truck-pickup",
            FontAwesome.Tshirt => "fa-tshirt",
            FontAwesome.Tty => "fa-tty",
            FontAwesome.Tumblr => "fa-tumblr",
            FontAwesome.TumblrSquare => "fa-tumblr-square",
            FontAwesome.Tv => "fa-tv",
            FontAwesome.Twitch => "fa-twitch",
            FontAwesome.Twitter => "fa-twitter",
            FontAwesome.TwitterSquare => "fa-twitter-square",
            FontAwesome.Typo3 => "fa-typo3",
            FontAwesome.Uber => "fa-uber",
            FontAwesome.Ubuntu => "fa-ubuntu",
            FontAwesome.Uikit => "fa-uikit",
            FontAwesome.Umbraco => "fa-umbraco",
            FontAwesome.Umbrella => "fa-umbrella",
            FontAwesome.UmbrellaBeach => "fa-umbrella-beach",
            FontAwesome.Underline => "fa-underline",
            FontAwesome.Undo => "fa-undo",
            FontAwesome.UndoAlt => "fa-undo-alt",
            FontAwesome.Uniregistry => "fa-uniregistry",
            FontAwesome.Unity => "fa-unity",
            FontAwesome.UniversalAccess => "fa-universal-access",
            FontAwesome.University => "fa-university",
            FontAwesome.Unlink => "fa-unlink",
            FontAwesome.Unlock => "fa-unlock",
            FontAwesome.UnlockAlt => "fa-unlock-alt",
            FontAwesome.Untappd => "fa-untappd",
            FontAwesome.Upload => "fa-upload",
            FontAwesome.Ups => "fa-ups",
            FontAwesome.Usb => "fa-usb",
            FontAwesome.User => "fa-user",
            FontAwesome.UserAlt => "fa-user-alt",
            FontAwesome.UserAltSlash => "fa-user-alt-slash",
            FontAwesome.UserAstronaut => "fa-user-astronaut",
            FontAwesome.UserCheck => "fa-user-check",
            FontAwesome.UserCircle => "fa-user-circle",
            FontAwesome.UserClock => "fa-user-clock",
            FontAwesome.UserCog => "fa-user-cog",
            FontAwesome.UserEdit => "fa-user-edit",
            FontAwesome.UserFriends => "fa-user-friends",
            FontAwesome.UserGraduate => "fa-user-graduate",
            FontAwesome.UserInjured => "fa-user-injured",
            FontAwesome.UserLock => "fa-user-lock",
            FontAwesome.UserMd => "fa-user-md",
            FontAwesome.UserMinus => "fa-user-minus",
            FontAwesome.UserNinja => "fa-user-ninja",
            FontAwesome.UserNurse => "fa-user-nurse",
            FontAwesome.UserPlus => "fa-user-plus",
            FontAwesome.Users => "fa-users",
            FontAwesome.UsersCog => "fa-users-cog",
            FontAwesome.UserSecret => "fa-user-secret",
            FontAwesome.UserShield => "fa-user-shield",
            FontAwesome.UserSlash => "fa-user-slash",
            FontAwesome.UserTag => "fa-user-tag",
            FontAwesome.UserTie => "fa-user-tie",
            FontAwesome.UserTimes => "fa-user-times",
            FontAwesome.Usps => "fa-usps",
            FontAwesome.Ussunnah => "fa-ussunnah",
            FontAwesome.Utensils => "fa-utensils",
            FontAwesome.UtensilSpoon => "fa-utensil-spoon",
            FontAwesome.Vaadin => "fa-vaadin",
            FontAwesome.VectorSquare => "fa-vector-square",
            FontAwesome.Venus => "fa-venus",
            FontAwesome.VenusDouble => "fa-venus-double",
            FontAwesome.VenusMars => "fa-venus-mars",
            FontAwesome.Viacoin => "fa-viacoin",
            FontAwesome.Viadeo => "fa-viadeo",
            FontAwesome.ViadeoSquare => "fa-viadeo-square",
            FontAwesome.Vial => "fa-vial",
            FontAwesome.Vials => "fa-vials",
            FontAwesome.Viber => "fa-viber",
            FontAwesome.Video => "fa-video",
            FontAwesome.VideoSlash => "fa-video-slash",
            FontAwesome.Vihara => "fa-vihara",
            FontAwesome.Vimeo => "fa-vimeo",
            FontAwesome.VimeoSquare => "fa-vimeo-square",
            FontAwesome.VimeoV => "fa-vimeo-v",
            FontAwesome.Vine => "fa-vine",
            FontAwesome.Virus => "fa-virus",
            FontAwesome.Viruses => "fa-viruses",
            FontAwesome.VirusSlash => "fa-virus-slash",
            FontAwesome.Vk => "fa-vk",
            FontAwesome.Vnv => "fa-vnv",
            FontAwesome.Voicemail => "fa-voicemail",
            FontAwesome.VolleyballBall => "fa-volleyball-ball",
            FontAwesome.VolumeDown => "fa-volume-down",
            FontAwesome.VolumeMute => "fa-volume-mute",
            FontAwesome.VolumeOff => "fa-volume-off",
            FontAwesome.VolumeUp => "fa-volume-up",
            FontAwesome.VoteYea => "fa-vote-yea",
            FontAwesome.VrCardboard => "fa-vr-cardboard",
            FontAwesome.Vuejs => "fa-vuejs",
            FontAwesome.Walking => "fa-walking",
            FontAwesome.Wallet => "fa-wallet",
            FontAwesome.Warehouse => "fa-warehouse",
            FontAwesome.Water => "fa-water",
            FontAwesome.WaveSquare => "fa-wave-square",
            FontAwesome.Waze => "fa-waze",
            FontAwesome.Weebly => "fa-weebly",
            FontAwesome.Weibo => "fa-weibo",
            FontAwesome.Weight => "fa-weight",
            FontAwesome.WeightHanging => "fa-weight-hanging",
            FontAwesome.Weixin => "fa-weixin",
            FontAwesome.Whatsapp => "fa-whatsapp",
            FontAwesome.WhatsappSquare => "fa-whatsapp-square",
            FontAwesome.Wheelchair => "fa-wheelchair",
            FontAwesome.Whmcs => "fa-whmcs",
            FontAwesome.Wifi => "fa-wifi",
            FontAwesome.WikipediaW => "fa-wikipedia-w",
            FontAwesome.Wind => "fa-wind",
            FontAwesome.WindowClose => "fa-window-close",
            FontAwesome.WindowMaximize => "fa-window-maximize",
            FontAwesome.WindowMinimize => "fa-window-minimize",
            FontAwesome.WindowRestore => "fa-window-restore",
            FontAwesome.Windows => "fa-windows",
            FontAwesome.WineBottle => "fa-wine-bottle",
            FontAwesome.WineGlass => "fa-wine-glass",
            FontAwesome.WineGlassAlt => "fa-wine-glass-alt",
            FontAwesome.Wix => "fa-wix",
            FontAwesome.WizardsOfTheCoast => "fa-wizards-of-the-coast",
            FontAwesome.WolfPackBattalion => "fa-wolf-pack-battalion",
            FontAwesome.WonSign => "fa-won-sign",
            FontAwesome.Wordpress => "fa-wordpress",
            FontAwesome.WordpressSimple => "fa-wordpress-simple",
            FontAwesome.Wpbeginner => "fa-wpbeginner",
            FontAwesome.Wpexplorer => "fa-wpexplorer",
            FontAwesome.Wpforms => "fa-wpforms",
            FontAwesome.Wpressr => "fa-wpressr",
            FontAwesome.Wrench => "fa-wrench",
            FontAwesome.Xbox => "fa-xbox",
            FontAwesome.Xing => "fa-xing",
            FontAwesome.XingSquare => "fa-xing-square",
            FontAwesome.XRay => "fa-x-ray",
            FontAwesome.Yahoo => "fa-yahoo",
            FontAwesome.Yammer => "fa-yammer",
            FontAwesome.Yandex => "fa-yandex",
            FontAwesome.YandexInternational => "fa-yandex-international",
            FontAwesome.Yarn => "fa-yarn",
            FontAwesome.YCombinator => "fa-y-combinator",
            FontAwesome.Yelp => "fa-yelp",
            FontAwesome.YenSign => "fa-yen-sign",
            FontAwesome.YinYang => "fa-yin-yang",
            FontAwesome.Yoast => "fa-yoast",
            FontAwesome.Youtube => "fa-youtube",
            FontAwesome.YoutubeSquare => "fa-youtube-square",
            FontAwesome.Zhihu => "fa-zhihu",
            _ => throw new ArgumentOutOfRangeException(nameof(icon))
        };

        /// <summary>
        ///   Gets the UTF-8 char associated with a <see cref="FontAwesome"/> icon.
        /// </summary>
        /// 
        public static char GetUnicode(this FontAwesome icon) => (char)icon;
    }
}
