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
        Icon500Px = '\uf26e',
        
        /// <summary>
        ///     Accessible Icon ("fa-accessible-icon", \uf368) icon.
        /// </summary>
        /// 
        [Display(Name = "Accessible Icon", Description = "fa-accessible-icon", GroupName = "brands")]
        IconAccessibleIcon = '\uf368',
        
        /// <summary>
        ///     Accusoft ("fa-accusoft", \uf369) icon.
        /// </summary>
        /// 
        [Display(Name = "Accusoft", Description = "fa-accusoft", GroupName = "brands")]
        IconAccusoft = '\uf369',
        
        /// <summary>
        ///     Acquisitions Incorporated ("fa-acquisitions-incorporated", \uf6af) icon.
        /// </summary>
        /// 
        [Display(Name = "Acquisitions Incorporated", Description = "fa-acquisitions-incorporated", GroupName = "brands")]
        IconAcquisitionsIncorporated = '\uf6af',
        
        /// <summary>
        ///     Ad ("fa-ad", \uf641) icon.
        /// </summary>
        /// 
        [Display(Name = "Ad", Description = "fa-ad", GroupName = "duotone light regular solid")]
        IconAd = '\uf641',
        
        /// <summary>
        ///     Address Book ("fa-address-book", \uf2b9) icon.
        /// </summary>
        /// 
        [Display(Name = "Address Book", Description = "fa-address-book", GroupName = "duotone light regular solid")]
        IconAddressBook = '\uf2b9',
        
        /// <summary>
        ///     Address Card ("fa-address-card", \uf2bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Address Card", Description = "fa-address-card", GroupName = "duotone light regular solid")]
        IconAddressCard = '\uf2bb',
        
        /// <summary>
        ///     Adjust ("fa-adjust", \uf042) icon.
        /// </summary>
        /// 
        [Display(Name = "Adjust", Description = "fa-adjust", GroupName = "duotone light regular solid")]
        IconAdjust = '\uf042',
        
        /// <summary>
        ///     Adn ("fa-adn", \uf170) icon.
        /// </summary>
        /// 
        [Display(Name = "Adn", Description = "fa-adn", GroupName = "brands")]
        IconAdn = '\uf170',
        
        /// <summary>
        ///     Adobe ("fa-adobe", \uf778) icon.
        /// </summary>
        /// 
        [Display(Name = "Adobe", Description = "fa-adobe", GroupName = "brands")]
        IconAdobe = '\uf778',
        
        /// <summary>
        ///     Adversal ("fa-adversal", \uf36a) icon.
        /// </summary>
        /// 
        [Display(Name = "Adversal", Description = "fa-adversal", GroupName = "brands")]
        IconAdversal = '\uf36a',
        
        /// <summary>
        ///     Affiliatetheme ("fa-affiliatetheme", \uf36b) icon.
        /// </summary>
        /// 
        [Display(Name = "Affiliatetheme", Description = "fa-affiliatetheme", GroupName = "brands")]
        IconAffiliatetheme = '\uf36b',
        
        /// <summary>
        ///     Airbnb ("fa-airbnb", \uf834) icon.
        /// </summary>
        /// 
        [Display(Name = "Airbnb", Description = "fa-airbnb", GroupName = "brands")]
        IconAirbnb = '\uf834',
        
        /// <summary>
        ///     Air Freshener ("fa-air-freshener", \uf5d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Air Freshener", Description = "fa-air-freshener", GroupName = "duotone light regular solid")]
        IconAirFreshener = '\uf5d0',
        
        /// <summary>
        ///     Algolia ("fa-algolia", \uf36c) icon.
        /// </summary>
        /// 
        [Display(Name = "Algolia", Description = "fa-algolia", GroupName = "brands")]
        IconAlgolia = '\uf36c',
        
        /// <summary>
        ///     Align Center ("fa-align-center", \uf037) icon.
        /// </summary>
        /// 
        [Display(Name = "Align Center", Description = "fa-align-center", GroupName = "duotone light regular solid")]
        IconAlignCenter = '\uf037',
        
        /// <summary>
        ///     Align Justify ("fa-align-justify", \uf039) icon.
        /// </summary>
        /// 
        [Display(Name = "Align Justify", Description = "fa-align-justify", GroupName = "duotone light regular solid")]
        IconAlignJustify = '\uf039',
        
        /// <summary>
        ///     Align Left ("fa-align-left", \uf036) icon.
        /// </summary>
        /// 
        [Display(Name = "Align Left", Description = "fa-align-left", GroupName = "duotone light regular solid")]
        IconAlignLeft = '\uf036',
        
        /// <summary>
        ///     Align Right ("fa-align-right", \uf038) icon.
        /// </summary>
        /// 
        [Display(Name = "Align Right", Description = "fa-align-right", GroupName = "duotone light regular solid")]
        IconAlignRight = '\uf038',
        
        /// <summary>
        ///     Alipay ("fa-alipay", \uf642) icon.
        /// </summary>
        /// 
        [Display(Name = "Alipay", Description = "fa-alipay", GroupName = "brands")]
        IconAlipay = '\uf642',
        
        /// <summary>
        ///     Allergies ("fa-allergies", \uf461) icon.
        /// </summary>
        /// 
        [Display(Name = "Allergies", Description = "fa-allergies", GroupName = "duotone light regular solid")]
        IconAllergies = '\uf461',
        
        /// <summary>
        ///     Amazon ("fa-amazon", \uf270) icon.
        /// </summary>
        /// 
        [Display(Name = "Amazon", Description = "fa-amazon", GroupName = "brands")]
        IconAmazon = '\uf270',
        
        /// <summary>
        ///     Amazon Pay ("fa-amazon-pay", \uf42c) icon.
        /// </summary>
        /// 
        [Display(Name = "Amazon Pay", Description = "fa-amazon-pay", GroupName = "brands")]
        IconAmazonPay = '\uf42c',
        
        /// <summary>
        ///     Ambulance ("fa-ambulance", \uf0f9) icon.
        /// </summary>
        /// 
        [Display(Name = "Ambulance", Description = "fa-ambulance", GroupName = "duotone light regular solid")]
        IconAmbulance = '\uf0f9',
        
        /// <summary>
        ///     American Sign Language Interpreting ("fa-american-sign-language-interpreting", \uf2a3) icon.
        /// </summary>
        /// 
        [Display(Name = "American Sign Language Interpreting", Description = "fa-american-sign-language-interpreting", GroupName = "duotone light regular solid")]
        IconAmericanSignLanguageInterpreting = '\uf2a3',
        
        /// <summary>
        ///     Amilia ("fa-amilia", \uf36d) icon.
        /// </summary>
        /// 
        [Display(Name = "Amilia", Description = "fa-amilia", GroupName = "brands")]
        IconAmilia = '\uf36d',
        
        /// <summary>
        ///     Anchor ("fa-anchor", \uf13d) icon.
        /// </summary>
        /// 
        [Display(Name = "Anchor", Description = "fa-anchor", GroupName = "duotone light regular solid")]
        IconAnchor = '\uf13d',
        
        /// <summary>
        ///     Android ("fa-android", \uf17b) icon.
        /// </summary>
        /// 
        [Display(Name = "Android", Description = "fa-android", GroupName = "brands")]
        IconAndroid = '\uf17b',
        
        /// <summary>
        ///     Angellist ("fa-angellist", \uf209) icon.
        /// </summary>
        /// 
        [Display(Name = "Angellist", Description = "fa-angellist", GroupName = "brands")]
        IconAngellist = '\uf209',
        
        /// <summary>
        ///     Angle Double Down ("fa-angle-double-down", \uf103) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Double Down", Description = "fa-angle-double-down", GroupName = "duotone light regular solid")]
        IconAngleDoubleDown = '\uf103',
        
        /// <summary>
        ///     Angle Double Left ("fa-angle-double-left", \uf100) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Double Left", Description = "fa-angle-double-left", GroupName = "duotone light regular solid")]
        IconAngleDoubleLeft = '\uf100',
        
        /// <summary>
        ///     Angle Double Right ("fa-angle-double-right", \uf101) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Double Right", Description = "fa-angle-double-right", GroupName = "duotone light regular solid")]
        IconAngleDoubleRight = '\uf101',
        
        /// <summary>
        ///     Angle Double Up ("fa-angle-double-up", \uf102) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Double Up", Description = "fa-angle-double-up", GroupName = "duotone light regular solid")]
        IconAngleDoubleUp = '\uf102',
        
        /// <summary>
        ///     Angle Down ("fa-angle-down", \uf107) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Down", Description = "fa-angle-down", GroupName = "duotone light regular solid")]
        IconAngleDown = '\uf107',
        
        /// <summary>
        ///     Angle Left ("fa-angle-left", \uf104) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Left", Description = "fa-angle-left", GroupName = "duotone light regular solid")]
        IconAngleLeft = '\uf104',
        
        /// <summary>
        ///     Angle Right ("fa-angle-right", \uf105) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Right", Description = "fa-angle-right", GroupName = "duotone light regular solid")]
        IconAngleRight = '\uf105',
        
        /// <summary>
        ///     Angle Up ("fa-angle-up", \uf106) icon.
        /// </summary>
        /// 
        [Display(Name = "Angle Up", Description = "fa-angle-up", GroupName = "duotone light regular solid")]
        IconAngleUp = '\uf106',
        
        /// <summary>
        ///     Angry ("fa-angry", \uf556) icon.
        /// </summary>
        /// 
        [Display(Name = "Angry", Description = "fa-angry", GroupName = "duotone light regular solid")]
        IconAngry = '\uf556',
        
        /// <summary>
        ///     Angrycreative ("fa-angrycreative", \uf36e) icon.
        /// </summary>
        /// 
        [Display(Name = "Angrycreative", Description = "fa-angrycreative", GroupName = "brands")]
        IconAngrycreative = '\uf36e',
        
        /// <summary>
        ///     Angular ("fa-angular", \uf420) icon.
        /// </summary>
        /// 
        [Display(Name = "Angular", Description = "fa-angular", GroupName = "brands")]
        IconAngular = '\uf420',
        
        /// <summary>
        ///     Ankh ("fa-ankh", \uf644) icon.
        /// </summary>
        /// 
        [Display(Name = "Ankh", Description = "fa-ankh", GroupName = "duotone light regular solid")]
        IconAnkh = '\uf644',
        
        /// <summary>
        ///     Apper ("fa-apper", \uf371) icon.
        /// </summary>
        /// 
        [Display(Name = "Apper", Description = "fa-apper", GroupName = "brands")]
        IconApper = '\uf371',
        
        /// <summary>
        ///     Apple ("fa-apple", \uf179) icon.
        /// </summary>
        /// 
        [Display(Name = "Apple", Description = "fa-apple", GroupName = "brands")]
        IconApple = '\uf179',
        
        /// <summary>
        ///     Apple Alt ("fa-apple-alt", \uf5d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Apple Alt", Description = "fa-apple-alt", GroupName = "duotone light regular solid")]
        IconAppleAlt = '\uf5d1',
        
        /// <summary>
        ///     Apple Pay ("fa-apple-pay", \uf415) icon.
        /// </summary>
        /// 
        [Display(Name = "Apple Pay", Description = "fa-apple-pay", GroupName = "brands")]
        IconApplePay = '\uf415',
        
        /// <summary>
        ///     App Store ("fa-app-store", \uf36f) icon.
        /// </summary>
        /// 
        [Display(Name = "App Store", Description = "fa-app-store", GroupName = "brands")]
        IconAppStore = '\uf36f',
        
        /// <summary>
        ///     App Store Ios ("fa-app-store-ios", \uf370) icon.
        /// </summary>
        /// 
        [Display(Name = "App Store Ios", Description = "fa-app-store-ios", GroupName = "brands")]
        IconAppStoreIos = '\uf370',
        
        /// <summary>
        ///     Archive ("fa-archive", \uf187) icon.
        /// </summary>
        /// 
        [Display(Name = "Archive", Description = "fa-archive", GroupName = "duotone light regular solid")]
        IconArchive = '\uf187',
        
        /// <summary>
        ///     Archway ("fa-archway", \uf557) icon.
        /// </summary>
        /// 
        [Display(Name = "Archway", Description = "fa-archway", GroupName = "duotone light regular solid")]
        IconArchway = '\uf557',
        
        /// <summary>
        ///     Arrow Alt Circle Down ("fa-arrow-alt-circle-down", \uf358) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Alt Circle Down", Description = "fa-arrow-alt-circle-down", GroupName = "duotone light regular solid")]
        IconArrowAltCircleDown = '\uf358',
        
        /// <summary>
        ///     Arrow Alt Circle Left ("fa-arrow-alt-circle-left", \uf359) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Alt Circle Left", Description = "fa-arrow-alt-circle-left", GroupName = "duotone light regular solid")]
        IconArrowAltCircleLeft = '\uf359',
        
        /// <summary>
        ///     Arrow Alt Circle Right ("fa-arrow-alt-circle-right", \uf35a) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Alt Circle Right", Description = "fa-arrow-alt-circle-right", GroupName = "duotone light regular solid")]
        IconArrowAltCircleRight = '\uf35a',
        
        /// <summary>
        ///     Arrow Alt Circle Up ("fa-arrow-alt-circle-up", \uf35b) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Alt Circle Up", Description = "fa-arrow-alt-circle-up", GroupName = "duotone light regular solid")]
        IconArrowAltCircleUp = '\uf35b',
        
        /// <summary>
        ///     Arrow Circle Down ("fa-arrow-circle-down", \uf0ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Circle Down", Description = "fa-arrow-circle-down", GroupName = "duotone light regular solid")]
        IconArrowCircleDown = '\uf0ab',
        
        /// <summary>
        ///     Arrow Circle Left ("fa-arrow-circle-left", \uf0a8) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Circle Left", Description = "fa-arrow-circle-left", GroupName = "duotone light regular solid")]
        IconArrowCircleLeft = '\uf0a8',
        
        /// <summary>
        ///     Arrow Circle Right ("fa-arrow-circle-right", \uf0a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Circle Right", Description = "fa-arrow-circle-right", GroupName = "duotone light regular solid")]
        IconArrowCircleRight = '\uf0a9',
        
        /// <summary>
        ///     Arrow Circle Up ("fa-arrow-circle-up", \uf0aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Circle Up", Description = "fa-arrow-circle-up", GroupName = "duotone light regular solid")]
        IconArrowCircleUp = '\uf0aa',
        
        /// <summary>
        ///     Arrow Down ("fa-arrow-down", \uf063) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Down", Description = "fa-arrow-down", GroupName = "duotone light regular solid")]
        IconArrowDown = '\uf063',
        
        /// <summary>
        ///     Arrow Left ("fa-arrow-left", \uf060) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Left", Description = "fa-arrow-left", GroupName = "duotone light regular solid")]
        IconArrowLeft = '\uf060',
        
        /// <summary>
        ///     Arrow Right ("fa-arrow-right", \uf061) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Right", Description = "fa-arrow-right", GroupName = "duotone light regular solid")]
        IconArrowRight = '\uf061',
        
        /// <summary>
        ///     Arrows Alt ("fa-arrows-alt", \uf0b2) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrows Alt", Description = "fa-arrows-alt", GroupName = "duotone light regular solid")]
        IconArrowsAlt = '\uf0b2',
        
        /// <summary>
        ///     Arrows Alt H ("fa-arrows-alt-h", \uf337) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrows Alt H", Description = "fa-arrows-alt-h", GroupName = "duotone light regular solid")]
        IconArrowsAltH = '\uf337',
        
        /// <summary>
        ///     Arrows Alt V ("fa-arrows-alt-v", \uf338) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrows Alt V", Description = "fa-arrows-alt-v", GroupName = "duotone light regular solid")]
        IconArrowsAltV = '\uf338',
        
        /// <summary>
        ///     Arrow Up ("fa-arrow-up", \uf062) icon.
        /// </summary>
        /// 
        [Display(Name = "Arrow Up", Description = "fa-arrow-up", GroupName = "duotone light regular solid")]
        IconArrowUp = '\uf062',
        
        /// <summary>
        ///     Artstation ("fa-artstation", \uf77a) icon.
        /// </summary>
        /// 
        [Display(Name = "Artstation", Description = "fa-artstation", GroupName = "brands")]
        IconArtstation = '\uf77a',
        
        /// <summary>
        ///     Assistive Listening Systems ("fa-assistive-listening-systems", \uf2a2) icon.
        /// </summary>
        /// 
        [Display(Name = "Assistive Listening Systems", Description = "fa-assistive-listening-systems", GroupName = "duotone light regular solid")]
        IconAssistiveListeningSystems = '\uf2a2',
        
        /// <summary>
        ///     Asterisk ("fa-asterisk", \uf069) icon.
        /// </summary>
        /// 
        [Display(Name = "Asterisk", Description = "fa-asterisk", GroupName = "duotone light regular solid")]
        IconAsterisk = '\uf069',
        
        /// <summary>
        ///     Asymmetrik ("fa-asymmetrik", \uf372) icon.
        /// </summary>
        /// 
        [Display(Name = "Asymmetrik", Description = "fa-asymmetrik", GroupName = "brands")]
        IconAsymmetrik = '\uf372',
        
        /// <summary>
        ///     At ("fa-at", \uf1fa) icon.
        /// </summary>
        /// 
        [Display(Name = "At", Description = "fa-at", GroupName = "duotone light regular solid")]
        IconAt = '\uf1fa',
        
        /// <summary>
        ///     Atlas ("fa-atlas", \uf558) icon.
        /// </summary>
        /// 
        [Display(Name = "Atlas", Description = "fa-atlas", GroupName = "duotone light regular solid")]
        IconAtlas = '\uf558',
        
        /// <summary>
        ///     Atlassian ("fa-atlassian", \uf77b) icon.
        /// </summary>
        /// 
        [Display(Name = "Atlassian", Description = "fa-atlassian", GroupName = "brands")]
        IconAtlassian = '\uf77b',
        
        /// <summary>
        ///     Atom ("fa-atom", \uf5d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Atom", Description = "fa-atom", GroupName = "duotone light regular solid")]
        IconAtom = '\uf5d2',
        
        /// <summary>
        ///     Audible ("fa-audible", \uf373) icon.
        /// </summary>
        /// 
        [Display(Name = "Audible", Description = "fa-audible", GroupName = "brands")]
        IconAudible = '\uf373',
        
        /// <summary>
        ///     Audio Description ("fa-audio-description", \uf29e) icon.
        /// </summary>
        /// 
        [Display(Name = "Audio Description", Description = "fa-audio-description", GroupName = "duotone light regular solid")]
        IconAudioDescription = '\uf29e',
        
        /// <summary>
        ///     Autoprefixer ("fa-autoprefixer", \uf41c) icon.
        /// </summary>
        /// 
        [Display(Name = "Autoprefixer", Description = "fa-autoprefixer", GroupName = "brands")]
        IconAutoprefixer = '\uf41c',
        
        /// <summary>
        ///     Avianex ("fa-avianex", \uf374) icon.
        /// </summary>
        /// 
        [Display(Name = "Avianex", Description = "fa-avianex", GroupName = "brands")]
        IconAvianex = '\uf374',
        
        /// <summary>
        ///     Aviato ("fa-aviato", \uf421) icon.
        /// </summary>
        /// 
        [Display(Name = "Aviato", Description = "fa-aviato", GroupName = "brands")]
        IconAviato = '\uf421',
        
        /// <summary>
        ///     Award ("fa-award", \uf559) icon.
        /// </summary>
        /// 
        [Display(Name = "Award", Description = "fa-award", GroupName = "duotone light regular solid")]
        IconAward = '\uf559',
        
        /// <summary>
        ///     Aws ("fa-aws", \uf375) icon.
        /// </summary>
        /// 
        [Display(Name = "Aws", Description = "fa-aws", GroupName = "brands")]
        IconAws = '\uf375',
        
        /// <summary>
        ///     Baby ("fa-baby", \uf77c) icon.
        /// </summary>
        /// 
        [Display(Name = "Baby", Description = "fa-baby", GroupName = "duotone light regular solid")]
        IconBaby = '\uf77c',
        
        /// <summary>
        ///     Baby Carriage ("fa-baby-carriage", \uf77d) icon.
        /// </summary>
        /// 
        [Display(Name = "Baby Carriage", Description = "fa-baby-carriage", GroupName = "duotone light regular solid")]
        IconBabyCarriage = '\uf77d',
        
        /// <summary>
        ///     Backspace ("fa-backspace", \uf55a) icon.
        /// </summary>
        /// 
        [Display(Name = "Backspace", Description = "fa-backspace", GroupName = "duotone light regular solid")]
        IconBackspace = '\uf55a',
        
        /// <summary>
        ///     Backward ("fa-backward", \uf04a) icon.
        /// </summary>
        /// 
        [Display(Name = "Backward", Description = "fa-backward", GroupName = "duotone light regular solid")]
        IconBackward = '\uf04a',
        
        /// <summary>
        ///     Bacon ("fa-bacon", \uf7e5) icon.
        /// </summary>
        /// 
        [Display(Name = "Bacon", Description = "fa-bacon", GroupName = "duotone light regular solid")]
        IconBacon = '\uf7e5',
        
        /// <summary>
        ///     Bahai ("fa-bahai", \uf666) icon.
        /// </summary>
        /// 
        [Display(Name = "Bahai", Description = "fa-bahai", GroupName = "duotone light regular solid")]
        IconBahai = '\uf666',
        
        /// <summary>
        ///     Balance Scale ("fa-balance-scale", \uf24e) icon.
        /// </summary>
        /// 
        [Display(Name = "Balance Scale", Description = "fa-balance-scale", GroupName = "duotone light regular solid")]
        IconBalanceScale = '\uf24e',
        
        /// <summary>
        ///     Balance Scale Left ("fa-balance-scale-left", \uf515) icon.
        /// </summary>
        /// 
        [Display(Name = "Balance Scale Left", Description = "fa-balance-scale-left", GroupName = "duotone light regular solid")]
        IconBalanceScaleLeft = '\uf515',
        
        /// <summary>
        ///     Balance Scale Right ("fa-balance-scale-right", \uf516) icon.
        /// </summary>
        /// 
        [Display(Name = "Balance Scale Right", Description = "fa-balance-scale-right", GroupName = "duotone light regular solid")]
        IconBalanceScaleRight = '\uf516',
        
        /// <summary>
        ///     Ban ("fa-ban", \uf05e) icon.
        /// </summary>
        /// 
        [Display(Name = "Ban", Description = "fa-ban", GroupName = "duotone light regular solid")]
        IconBan = '\uf05e',
        
        /// <summary>
        ///     Band Aid ("fa-band-aid", \uf462) icon.
        /// </summary>
        /// 
        [Display(Name = "Band Aid", Description = "fa-band-aid", GroupName = "duotone light regular solid")]
        IconBandAid = '\uf462',
        
        /// <summary>
        ///     Bandcamp ("fa-bandcamp", \uf2d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Bandcamp", Description = "fa-bandcamp", GroupName = "brands")]
        IconBandcamp = '\uf2d5',
        
        /// <summary>
        ///     Barcode ("fa-barcode", \uf02a) icon.
        /// </summary>
        /// 
        [Display(Name = "Barcode", Description = "fa-barcode", GroupName = "duotone light regular solid")]
        IconBarcode = '\uf02a',
        
        /// <summary>
        ///     Bars ("fa-bars", \uf0c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Bars", Description = "fa-bars", GroupName = "duotone light regular solid")]
        IconBars = '\uf0c9',
        
        /// <summary>
        ///     Baseball Ball ("fa-baseball-ball", \uf433) icon.
        /// </summary>
        /// 
        [Display(Name = "Baseball Ball", Description = "fa-baseball-ball", GroupName = "duotone light regular solid")]
        IconBaseballBall = '\uf433',
        
        /// <summary>
        ///     Basketball Ball ("fa-basketball-ball", \uf434) icon.
        /// </summary>
        /// 
        [Display(Name = "Basketball Ball", Description = "fa-basketball-ball", GroupName = "duotone light regular solid")]
        IconBasketballBall = '\uf434',
        
        /// <summary>
        ///     Bath ("fa-bath", \uf2cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Bath", Description = "fa-bath", GroupName = "duotone light regular solid")]
        IconBath = '\uf2cd',
        
        /// <summary>
        ///     Battery Empty ("fa-battery-empty", \uf244) icon.
        /// </summary>
        /// 
        [Display(Name = "Battery Empty", Description = "fa-battery-empty", GroupName = "duotone light regular solid")]
        IconBatteryEmpty = '\uf244',
        
        /// <summary>
        ///     Battery Full ("fa-battery-full", \uf240) icon.
        /// </summary>
        /// 
        [Display(Name = "Battery Full", Description = "fa-battery-full", GroupName = "duotone light regular solid")]
        IconBatteryFull = '\uf240',
        
        /// <summary>
        ///     Battery Half ("fa-battery-half", \uf242) icon.
        /// </summary>
        /// 
        [Display(Name = "Battery Half", Description = "fa-battery-half", GroupName = "duotone light regular solid")]
        IconBatteryHalf = '\uf242',
        
        /// <summary>
        ///     Battery Quarter ("fa-battery-quarter", \uf243) icon.
        /// </summary>
        /// 
        [Display(Name = "Battery Quarter", Description = "fa-battery-quarter", GroupName = "duotone light regular solid")]
        IconBatteryQuarter = '\uf243',
        
        /// <summary>
        ///     Battery Three Quarters ("fa-battery-three-quarters", \uf241) icon.
        /// </summary>
        /// 
        [Display(Name = "Battery Three Quarters", Description = "fa-battery-three-quarters", GroupName = "duotone light regular solid")]
        IconBatteryThreeQuarters = '\uf241',
        
        /// <summary>
        ///     Battle Net ("fa-battle-net", \uf835) icon.
        /// </summary>
        /// 
        [Display(Name = "Battle Net", Description = "fa-battle-net", GroupName = "brands")]
        IconBattleNet = '\uf835',
        
        /// <summary>
        ///     Bed ("fa-bed", \uf236) icon.
        /// </summary>
        /// 
        [Display(Name = "Bed", Description = "fa-bed", GroupName = "duotone light regular solid")]
        IconBed = '\uf236',
        
        /// <summary>
        ///     Beer ("fa-beer", \uf0fc) icon.
        /// </summary>
        /// 
        [Display(Name = "Beer", Description = "fa-beer", GroupName = "duotone light regular solid")]
        IconBeer = '\uf0fc',
        
        /// <summary>
        ///     Behance ("fa-behance", \uf1b4) icon.
        /// </summary>
        /// 
        [Display(Name = "Behance", Description = "fa-behance", GroupName = "brands")]
        IconBehance = '\uf1b4',
        
        /// <summary>
        ///     Behance Square ("fa-behance-square", \uf1b5) icon.
        /// </summary>
        /// 
        [Display(Name = "Behance Square", Description = "fa-behance-square", GroupName = "brands")]
        IconBehanceSquare = '\uf1b5',
        
        /// <summary>
        ///     Bell ("fa-bell", \uf0f3) icon.
        /// </summary>
        /// 
        [Display(Name = "Bell", Description = "fa-bell", GroupName = "duotone light regular solid")]
        IconBell = '\uf0f3',
        
        /// <summary>
        ///     Bell Slash ("fa-bell-slash", \uf1f6) icon.
        /// </summary>
        /// 
        [Display(Name = "Bell Slash", Description = "fa-bell-slash", GroupName = "duotone light regular solid")]
        IconBellSlash = '\uf1f6',
        
        /// <summary>
        ///     Bezier Curve ("fa-bezier-curve", \uf55b) icon.
        /// </summary>
        /// 
        [Display(Name = "Bezier Curve", Description = "fa-bezier-curve", GroupName = "duotone light regular solid")]
        IconBezierCurve = '\uf55b',
        
        /// <summary>
        ///     Bible ("fa-bible", \uf647) icon.
        /// </summary>
        /// 
        [Display(Name = "Bible", Description = "fa-bible", GroupName = "duotone light regular solid")]
        IconBible = '\uf647',
        
        /// <summary>
        ///     Bicycle ("fa-bicycle", \uf206) icon.
        /// </summary>
        /// 
        [Display(Name = "Bicycle", Description = "fa-bicycle", GroupName = "duotone light regular solid")]
        IconBicycle = '\uf206',
        
        /// <summary>
        ///     Biking ("fa-biking", \uf84a) icon.
        /// </summary>
        /// 
        [Display(Name = "Biking", Description = "fa-biking", GroupName = "duotone light regular solid")]
        IconBiking = '\uf84a',
        
        /// <summary>
        ///     Bimobject ("fa-bimobject", \uf378) icon.
        /// </summary>
        /// 
        [Display(Name = "Bimobject", Description = "fa-bimobject", GroupName = "brands")]
        IconBimobject = '\uf378',
        
        /// <summary>
        ///     Binoculars ("fa-binoculars", \uf1e5) icon.
        /// </summary>
        /// 
        [Display(Name = "Binoculars", Description = "fa-binoculars", GroupName = "duotone light regular solid")]
        IconBinoculars = '\uf1e5',
        
        /// <summary>
        ///     Biohazard ("fa-biohazard", \uf780) icon.
        /// </summary>
        /// 
        [Display(Name = "Biohazard", Description = "fa-biohazard", GroupName = "duotone light regular solid")]
        IconBiohazard = '\uf780',
        
        /// <summary>
        ///     Birthday Cake ("fa-birthday-cake", \uf1fd) icon.
        /// </summary>
        /// 
        [Display(Name = "Birthday Cake", Description = "fa-birthday-cake", GroupName = "duotone light regular solid")]
        IconBirthdayCake = '\uf1fd',
        
        /// <summary>
        ///     Bitbucket ("fa-bitbucket", \uf171) icon.
        /// </summary>
        /// 
        [Display(Name = "Bitbucket", Description = "fa-bitbucket", GroupName = "brands")]
        IconBitbucket = '\uf171',
        
        /// <summary>
        ///     Bitcoin ("fa-bitcoin", \uf379) icon.
        /// </summary>
        /// 
        [Display(Name = "Bitcoin", Description = "fa-bitcoin", GroupName = "brands")]
        IconBitcoin = '\uf379',
        
        /// <summary>
        ///     Bity ("fa-bity", \uf37a) icon.
        /// </summary>
        /// 
        [Display(Name = "Bity", Description = "fa-bity", GroupName = "brands")]
        IconBity = '\uf37a',
        
        /// <summary>
        ///     Blackberry ("fa-blackberry", \uf37b) icon.
        /// </summary>
        /// 
        [Display(Name = "Blackberry", Description = "fa-blackberry", GroupName = "brands")]
        IconBlackberry = '\uf37b',
        
        /// <summary>
        ///     Black Tie ("fa-black-tie", \uf27e) icon.
        /// </summary>
        /// 
        [Display(Name = "Black Tie", Description = "fa-black-tie", GroupName = "brands")]
        IconBlackTie = '\uf27e',
        
        /// <summary>
        ///     Blender ("fa-blender", \uf517) icon.
        /// </summary>
        /// 
        [Display(Name = "Blender", Description = "fa-blender", GroupName = "duotone light regular solid")]
        IconBlender = '\uf517',
        
        /// <summary>
        ///     Blender Phone ("fa-blender-phone", \uf6b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Blender Phone", Description = "fa-blender-phone", GroupName = "duotone light regular solid")]
        IconBlenderPhone = '\uf6b6',
        
        /// <summary>
        ///     Blind ("fa-blind", \uf29d) icon.
        /// </summary>
        /// 
        [Display(Name = "Blind", Description = "fa-blind", GroupName = "duotone light regular solid")]
        IconBlind = '\uf29d',
        
        /// <summary>
        ///     Blog ("fa-blog", \uf781) icon.
        /// </summary>
        /// 
        [Display(Name = "Blog", Description = "fa-blog", GroupName = "duotone light regular solid")]
        IconBlog = '\uf781',
        
        /// <summary>
        ///     Blogger ("fa-blogger", \uf37c) icon.
        /// </summary>
        /// 
        [Display(Name = "Blogger", Description = "fa-blogger", GroupName = "brands")]
        IconBlogger = '\uf37c',
        
        /// <summary>
        ///     Blogger B ("fa-blogger-b", \uf37d) icon.
        /// </summary>
        /// 
        [Display(Name = "Blogger B", Description = "fa-blogger-b", GroupName = "brands")]
        IconBloggerB = '\uf37d',
        
        /// <summary>
        ///     Bluetooth ("fa-bluetooth", \uf293) icon.
        /// </summary>
        /// 
        [Display(Name = "Bluetooth", Description = "fa-bluetooth", GroupName = "brands")]
        IconBluetooth = '\uf293',
        
        /// <summary>
        ///     Bluetooth B ("fa-bluetooth-b", \uf294) icon.
        /// </summary>
        /// 
        [Display(Name = "Bluetooth B", Description = "fa-bluetooth-b", GroupName = "brands")]
        IconBluetoothB = '\uf294',
        
        /// <summary>
        ///     Bold ("fa-bold", \uf032) icon.
        /// </summary>
        /// 
        [Display(Name = "Bold", Description = "fa-bold", GroupName = "duotone light regular solid")]
        IconBold = '\uf032',
        
        /// <summary>
        ///     Bolt ("fa-bolt", \uf0e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Bolt", Description = "fa-bolt", GroupName = "duotone light regular solid")]
        IconBolt = '\uf0e7',
        
        /// <summary>
        ///     Bomb ("fa-bomb", \uf1e2) icon.
        /// </summary>
        /// 
        [Display(Name = "Bomb", Description = "fa-bomb", GroupName = "duotone light regular solid")]
        IconBomb = '\uf1e2',
        
        /// <summary>
        ///     Bone ("fa-bone", \uf5d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Bone", Description = "fa-bone", GroupName = "duotone light regular solid")]
        IconBone = '\uf5d7',
        
        /// <summary>
        ///     Bong ("fa-bong", \uf55c) icon.
        /// </summary>
        /// 
        [Display(Name = "Bong", Description = "fa-bong", GroupName = "duotone light regular solid")]
        IconBong = '\uf55c',
        
        /// <summary>
        ///     Book ("fa-book", \uf02d) icon.
        /// </summary>
        /// 
        [Display(Name = "Book", Description = "fa-book", GroupName = "duotone light regular solid")]
        IconBook = '\uf02d',
        
        /// <summary>
        ///     Book Dead ("fa-book-dead", \uf6b7) icon.
        /// </summary>
        /// 
        [Display(Name = "Book Dead", Description = "fa-book-dead", GroupName = "duotone light regular solid")]
        IconBookDead = '\uf6b7',
        
        /// <summary>
        ///     Bookmark ("fa-bookmark", \uf02e) icon.
        /// </summary>
        /// 
        [Display(Name = "Bookmark", Description = "fa-bookmark", GroupName = "duotone light regular solid")]
        IconBookmark = '\uf02e',
        
        /// <summary>
        ///     Book Medical ("fa-book-medical", \uf7e6) icon.
        /// </summary>
        /// 
        [Display(Name = "Book Medical", Description = "fa-book-medical", GroupName = "duotone light regular solid")]
        IconBookMedical = '\uf7e6',
        
        /// <summary>
        ///     Book Open ("fa-book-open", \uf518) icon.
        /// </summary>
        /// 
        [Display(Name = "Book Open", Description = "fa-book-open", GroupName = "duotone light regular solid")]
        IconBookOpen = '\uf518',
        
        /// <summary>
        ///     Book Reader ("fa-book-reader", \uf5da) icon.
        /// </summary>
        /// 
        [Display(Name = "Book Reader", Description = "fa-book-reader", GroupName = "duotone light regular solid")]
        IconBookReader = '\uf5da',
        
        /// <summary>
        ///     Bootstrap ("fa-bootstrap", \uf836) icon.
        /// </summary>
        /// 
        [Display(Name = "Bootstrap", Description = "fa-bootstrap", GroupName = "brands")]
        IconBootstrap = '\uf836',
        
        /// <summary>
        ///     Border All ("fa-border-all", \uf84c) icon.
        /// </summary>
        /// 
        [Display(Name = "Border All", Description = "fa-border-all", GroupName = "duotone light regular solid")]
        IconBorderAll = '\uf84c',
        
        /// <summary>
        ///     Border None ("fa-border-none", \uf850) icon.
        /// </summary>
        /// 
        [Display(Name = "Border None", Description = "fa-border-none", GroupName = "duotone light regular solid")]
        IconBorderNone = '\uf850',
        
        /// <summary>
        ///     Border Style ("fa-border-style", \uf853) icon.
        /// </summary>
        /// 
        [Display(Name = "Border Style", Description = "fa-border-style", GroupName = "duotone light regular solid")]
        IconBorderStyle = '\uf853',
        
        /// <summary>
        ///     Bowling Ball ("fa-bowling-ball", \uf436) icon.
        /// </summary>
        /// 
        [Display(Name = "Bowling Ball", Description = "fa-bowling-ball", GroupName = "duotone light regular solid")]
        IconBowlingBall = '\uf436',
        
        /// <summary>
        ///     Box ("fa-box", \uf466) icon.
        /// </summary>
        /// 
        [Display(Name = "Box", Description = "fa-box", GroupName = "duotone light regular solid")]
        IconBox = '\uf466',
        
        /// <summary>
        ///     Boxes ("fa-boxes", \uf468) icon.
        /// </summary>
        /// 
        [Display(Name = "Boxes", Description = "fa-boxes", GroupName = "duotone light regular solid")]
        IconBoxes = '\uf468',
        
        /// <summary>
        ///     Box Open ("fa-box-open", \uf49e) icon.
        /// </summary>
        /// 
        [Display(Name = "Box Open", Description = "fa-box-open", GroupName = "duotone light regular solid")]
        IconBoxOpen = '\uf49e',
        
        /// <summary>
        ///     Box Tissue ("fa-box-tissue", \uf95b) icon.
        /// </summary>
        /// 
        [Display(Name = "Box Tissue", Description = "fa-box-tissue", GroupName = "duotone light regular solid")]
        IconBoxTissue = '\uf95b',
        
        /// <summary>
        ///     Braille ("fa-braille", \uf2a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Braille", Description = "fa-braille", GroupName = "duotone light regular solid")]
        IconBraille = '\uf2a1',
        
        /// <summary>
        ///     Brain ("fa-brain", \uf5dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Brain", Description = "fa-brain", GroupName = "duotone light regular solid")]
        IconBrain = '\uf5dc',
        
        /// <summary>
        ///     Bread Slice ("fa-bread-slice", \uf7ec) icon.
        /// </summary>
        /// 
        [Display(Name = "Bread Slice", Description = "fa-bread-slice", GroupName = "duotone light regular solid")]
        IconBreadSlice = '\uf7ec',
        
        /// <summary>
        ///     Briefcase ("fa-briefcase", \uf0b1) icon.
        /// </summary>
        /// 
        [Display(Name = "Briefcase", Description = "fa-briefcase", GroupName = "duotone light regular solid")]
        IconBriefcase = '\uf0b1',
        
        /// <summary>
        ///     Briefcase Medical ("fa-briefcase-medical", \uf469) icon.
        /// </summary>
        /// 
        [Display(Name = "Briefcase Medical", Description = "fa-briefcase-medical", GroupName = "duotone light regular solid")]
        IconBriefcaseMedical = '\uf469',
        
        /// <summary>
        ///     Broadcast Tower ("fa-broadcast-tower", \uf519) icon.
        /// </summary>
        /// 
        [Display(Name = "Broadcast Tower", Description = "fa-broadcast-tower", GroupName = "duotone light regular solid")]
        IconBroadcastTower = '\uf519',
        
        /// <summary>
        ///     Broom ("fa-broom", \uf51a) icon.
        /// </summary>
        /// 
        [Display(Name = "Broom", Description = "fa-broom", GroupName = "duotone light regular solid")]
        IconBroom = '\uf51a',
        
        /// <summary>
        ///     Brush ("fa-brush", \uf55d) icon.
        /// </summary>
        /// 
        [Display(Name = "Brush", Description = "fa-brush", GroupName = "duotone light regular solid")]
        IconBrush = '\uf55d',
        
        /// <summary>
        ///     Btc ("fa-btc", \uf15a) icon.
        /// </summary>
        /// 
        [Display(Name = "Btc", Description = "fa-btc", GroupName = "brands")]
        IconBtc = '\uf15a',
        
        /// <summary>
        ///     Buffer ("fa-buffer", \uf837) icon.
        /// </summary>
        /// 
        [Display(Name = "Buffer", Description = "fa-buffer", GroupName = "brands")]
        IconBuffer = '\uf837',
        
        /// <summary>
        ///     Bug ("fa-bug", \uf188) icon.
        /// </summary>
        /// 
        [Display(Name = "Bug", Description = "fa-bug", GroupName = "duotone light regular solid")]
        IconBug = '\uf188',
        
        /// <summary>
        ///     Building ("fa-building", \uf1ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Building", Description = "fa-building", GroupName = "duotone light regular solid")]
        IconBuilding = '\uf1ad',
        
        /// <summary>
        ///     Bullhorn ("fa-bullhorn", \uf0a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Bullhorn", Description = "fa-bullhorn", GroupName = "duotone light regular solid")]
        IconBullhorn = '\uf0a1',
        
        /// <summary>
        ///     Bullseye ("fa-bullseye", \uf140) icon.
        /// </summary>
        /// 
        [Display(Name = "Bullseye", Description = "fa-bullseye", GroupName = "duotone light regular solid")]
        IconBullseye = '\uf140',
        
        /// <summary>
        ///     Burn ("fa-burn", \uf46a) icon.
        /// </summary>
        /// 
        [Display(Name = "Burn", Description = "fa-burn", GroupName = "duotone light regular solid")]
        IconBurn = '\uf46a',
        
        /// <summary>
        ///     Buromobelexperte ("fa-buromobelexperte", \uf37f) icon.
        /// </summary>
        /// 
        [Display(Name = "Buromobelexperte", Description = "fa-buromobelexperte", GroupName = "brands")]
        IconBuromobelexperte = '\uf37f',
        
        /// <summary>
        ///     Bus ("fa-bus", \uf207) icon.
        /// </summary>
        /// 
        [Display(Name = "Bus", Description = "fa-bus", GroupName = "duotone light regular solid")]
        IconBus = '\uf207',
        
        /// <summary>
        ///     Bus Alt ("fa-bus-alt", \uf55e) icon.
        /// </summary>
        /// 
        [Display(Name = "Bus Alt", Description = "fa-bus-alt", GroupName = "duotone light regular solid")]
        IconBusAlt = '\uf55e',
        
        /// <summary>
        ///     Business Time ("fa-business-time", \uf64a) icon.
        /// </summary>
        /// 
        [Display(Name = "Business Time", Description = "fa-business-time", GroupName = "duotone light regular solid")]
        IconBusinessTime = '\uf64a',
        
        /// <summary>
        ///     Buy N Large ("fa-buy-n-large", \uf8a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Buy N Large", Description = "fa-buy-n-large", GroupName = "brands")]
        IconBuyNLarge = '\uf8a6',
        
        /// <summary>
        ///     Buysellads ("fa-buysellads", \uf20d) icon.
        /// </summary>
        /// 
        [Display(Name = "Buysellads", Description = "fa-buysellads", GroupName = "brands")]
        IconBuysellads = '\uf20d',
        
        /// <summary>
        ///     Calculator ("fa-calculator", \uf1ec) icon.
        /// </summary>
        /// 
        [Display(Name = "Calculator", Description = "fa-calculator", GroupName = "duotone light regular solid")]
        IconCalculator = '\uf1ec',
        
        /// <summary>
        ///     Calendar ("fa-calendar", \uf133) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar", Description = "fa-calendar", GroupName = "duotone light regular solid")]
        IconCalendar = '\uf133',
        
        /// <summary>
        ///     Calendar Alt ("fa-calendar-alt", \uf073) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Alt", Description = "fa-calendar-alt", GroupName = "duotone light regular solid")]
        IconCalendarAlt = '\uf073',
        
        /// <summary>
        ///     Calendar Check ("fa-calendar-check", \uf274) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Check", Description = "fa-calendar-check", GroupName = "duotone light regular solid")]
        IconCalendarCheck = '\uf274',
        
        /// <summary>
        ///     Calendar Day ("fa-calendar-day", \uf783) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Day", Description = "fa-calendar-day", GroupName = "duotone light regular solid")]
        IconCalendarDay = '\uf783',
        
        /// <summary>
        ///     Calendar Minus ("fa-calendar-minus", \uf272) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Minus", Description = "fa-calendar-minus", GroupName = "duotone light regular solid")]
        IconCalendarMinus = '\uf272',
        
        /// <summary>
        ///     Calendar Plus ("fa-calendar-plus", \uf271) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Plus", Description = "fa-calendar-plus", GroupName = "duotone light regular solid")]
        IconCalendarPlus = '\uf271',
        
        /// <summary>
        ///     Calendar Times ("fa-calendar-times", \uf273) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Times", Description = "fa-calendar-times", GroupName = "duotone light regular solid")]
        IconCalendarTimes = '\uf273',
        
        /// <summary>
        ///     Calendar Week ("fa-calendar-week", \uf784) icon.
        /// </summary>
        /// 
        [Display(Name = "Calendar Week", Description = "fa-calendar-week", GroupName = "duotone light regular solid")]
        IconCalendarWeek = '\uf784',
        
        /// <summary>
        ///     Camera ("fa-camera", \uf030) icon.
        /// </summary>
        /// 
        [Display(Name = "Camera", Description = "fa-camera", GroupName = "duotone light regular solid")]
        IconCamera = '\uf030',
        
        /// <summary>
        ///     Camera Retro ("fa-camera-retro", \uf083) icon.
        /// </summary>
        /// 
        [Display(Name = "Camera Retro", Description = "fa-camera-retro", GroupName = "duotone light regular solid")]
        IconCameraRetro = '\uf083',
        
        /// <summary>
        ///     Campground ("fa-campground", \uf6bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Campground", Description = "fa-campground", GroupName = "duotone light regular solid")]
        IconCampground = '\uf6bb',
        
        /// <summary>
        ///     Canadian Maple Leaf ("fa-canadian-maple-leaf", \uf785) icon.
        /// </summary>
        /// 
        [Display(Name = "Canadian Maple Leaf", Description = "fa-canadian-maple-leaf", GroupName = "brands")]
        IconCanadianMapleLeaf = '\uf785',
        
        /// <summary>
        ///     Candy Cane ("fa-candy-cane", \uf786) icon.
        /// </summary>
        /// 
        [Display(Name = "Candy Cane", Description = "fa-candy-cane", GroupName = "duotone light regular solid")]
        IconCandyCane = '\uf786',
        
        /// <summary>
        ///     Cannabis ("fa-cannabis", \uf55f) icon.
        /// </summary>
        /// 
        [Display(Name = "Cannabis", Description = "fa-cannabis", GroupName = "duotone light regular solid")]
        IconCannabis = '\uf55f',
        
        /// <summary>
        ///     Capsules ("fa-capsules", \uf46b) icon.
        /// </summary>
        /// 
        [Display(Name = "Capsules", Description = "fa-capsules", GroupName = "duotone light regular solid")]
        IconCapsules = '\uf46b',
        
        /// <summary>
        ///     Car ("fa-car", \uf1b9) icon.
        /// </summary>
        /// 
        [Display(Name = "Car", Description = "fa-car", GroupName = "duotone light regular solid")]
        IconCar = '\uf1b9',
        
        /// <summary>
        ///     Car Alt ("fa-car-alt", \uf5de) icon.
        /// </summary>
        /// 
        [Display(Name = "Car Alt", Description = "fa-car-alt", GroupName = "duotone light regular solid")]
        IconCarAlt = '\uf5de',
        
        /// <summary>
        ///     Caravan ("fa-caravan", \uf8ff) icon.
        /// </summary>
        /// 
        [Display(Name = "Caravan", Description = "fa-caravan", GroupName = "duotone light regular solid")]
        IconCaravan = '\uf8ff',
        
        /// <summary>
        ///     Car Battery ("fa-car-battery", \uf5df) icon.
        /// </summary>
        /// 
        [Display(Name = "Car Battery", Description = "fa-car-battery", GroupName = "duotone light regular solid")]
        IconCarBattery = '\uf5df',
        
        /// <summary>
        ///     Car Crash ("fa-car-crash", \uf5e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Car Crash", Description = "fa-car-crash", GroupName = "duotone light regular solid")]
        IconCarCrash = '\uf5e1',
        
        /// <summary>
        ///     Caret Down ("fa-caret-down", \uf0d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Down", Description = "fa-caret-down", GroupName = "duotone light regular solid")]
        IconCaretDown = '\uf0d7',
        
        /// <summary>
        ///     Caret Left ("fa-caret-left", \uf0d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Left", Description = "fa-caret-left", GroupName = "duotone light regular solid")]
        IconCaretLeft = '\uf0d9',
        
        /// <summary>
        ///     Caret Right ("fa-caret-right", \uf0da) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Right", Description = "fa-caret-right", GroupName = "duotone light regular solid")]
        IconCaretRight = '\uf0da',
        
        /// <summary>
        ///     Caret Square Down ("fa-caret-square-down", \uf150) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Square Down", Description = "fa-caret-square-down", GroupName = "duotone light regular solid")]
        IconCaretSquareDown = '\uf150',
        
        /// <summary>
        ///     Caret Square Left ("fa-caret-square-left", \uf191) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Square Left", Description = "fa-caret-square-left", GroupName = "duotone light regular solid")]
        IconCaretSquareLeft = '\uf191',
        
        /// <summary>
        ///     Caret Square Right ("fa-caret-square-right", \uf152) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Square Right", Description = "fa-caret-square-right", GroupName = "duotone light regular solid")]
        IconCaretSquareRight = '\uf152',
        
        /// <summary>
        ///     Caret Square Up ("fa-caret-square-up", \uf151) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Square Up", Description = "fa-caret-square-up", GroupName = "duotone light regular solid")]
        IconCaretSquareUp = '\uf151',
        
        /// <summary>
        ///     Caret Up ("fa-caret-up", \uf0d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Caret Up", Description = "fa-caret-up", GroupName = "duotone light regular solid")]
        IconCaretUp = '\uf0d8',
        
        /// <summary>
        ///     Carrot ("fa-carrot", \uf787) icon.
        /// </summary>
        /// 
        [Display(Name = "Carrot", Description = "fa-carrot", GroupName = "duotone light regular solid")]
        IconCarrot = '\uf787',
        
        /// <summary>
        ///     Car Side ("fa-car-side", \uf5e4) icon.
        /// </summary>
        /// 
        [Display(Name = "Car Side", Description = "fa-car-side", GroupName = "duotone light regular solid")]
        IconCarSide = '\uf5e4',
        
        /// <summary>
        ///     Cart Arrow Down ("fa-cart-arrow-down", \uf218) icon.
        /// </summary>
        /// 
        [Display(Name = "Cart Arrow Down", Description = "fa-cart-arrow-down", GroupName = "duotone light regular solid")]
        IconCartArrowDown = '\uf218',
        
        /// <summary>
        ///     Cart Plus ("fa-cart-plus", \uf217) icon.
        /// </summary>
        /// 
        [Display(Name = "Cart Plus", Description = "fa-cart-plus", GroupName = "duotone light regular solid")]
        IconCartPlus = '\uf217',
        
        /// <summary>
        ///     Cash Register ("fa-cash-register", \uf788) icon.
        /// </summary>
        /// 
        [Display(Name = "Cash Register", Description = "fa-cash-register", GroupName = "duotone light regular solid")]
        IconCashRegister = '\uf788',
        
        /// <summary>
        ///     Cat ("fa-cat", \uf6be) icon.
        /// </summary>
        /// 
        [Display(Name = "Cat", Description = "fa-cat", GroupName = "duotone light regular solid")]
        IconCat = '\uf6be',
        
        /// <summary>
        ///     Cc Amazon Pay ("fa-cc-amazon-pay", \uf42d) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Amazon Pay", Description = "fa-cc-amazon-pay", GroupName = "brands")]
        IconCcAmazonPay = '\uf42d',
        
        /// <summary>
        ///     Cc Amex ("fa-cc-amex", \uf1f3) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Amex", Description = "fa-cc-amex", GroupName = "brands")]
        IconCcAmex = '\uf1f3',
        
        /// <summary>
        ///     Cc Apple Pay ("fa-cc-apple-pay", \uf416) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Apple Pay", Description = "fa-cc-apple-pay", GroupName = "brands")]
        IconCcApplePay = '\uf416',
        
        /// <summary>
        ///     Cc Diners Club ("fa-cc-diners-club", \uf24c) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Diners Club", Description = "fa-cc-diners-club", GroupName = "brands")]
        IconCcDinersClub = '\uf24c',
        
        /// <summary>
        ///     Cc Discover ("fa-cc-discover", \uf1f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Discover", Description = "fa-cc-discover", GroupName = "brands")]
        IconCcDiscover = '\uf1f2',
        
        /// <summary>
        ///     Cc Jcb ("fa-cc-jcb", \uf24b) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Jcb", Description = "fa-cc-jcb", GroupName = "brands")]
        IconCcJcb = '\uf24b',
        
        /// <summary>
        ///     Cc Mastercard ("fa-cc-mastercard", \uf1f1) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Mastercard", Description = "fa-cc-mastercard", GroupName = "brands")]
        IconCcMastercard = '\uf1f1',
        
        /// <summary>
        ///     Cc Paypal ("fa-cc-paypal", \uf1f4) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Paypal", Description = "fa-cc-paypal", GroupName = "brands")]
        IconCcPaypal = '\uf1f4',
        
        /// <summary>
        ///     Cc Stripe ("fa-cc-stripe", \uf1f5) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Stripe", Description = "fa-cc-stripe", GroupName = "brands")]
        IconCcStripe = '\uf1f5',
        
        /// <summary>
        ///     Cc Visa ("fa-cc-visa", \uf1f0) icon.
        /// </summary>
        /// 
        [Display(Name = "Cc Visa", Description = "fa-cc-visa", GroupName = "brands")]
        IconCcVisa = '\uf1f0',
        
        /// <summary>
        ///     Centercode ("fa-centercode", \uf380) icon.
        /// </summary>
        /// 
        [Display(Name = "Centercode", Description = "fa-centercode", GroupName = "brands")]
        IconCentercode = '\uf380',
        
        /// <summary>
        ///     Centos ("fa-centos", \uf789) icon.
        /// </summary>
        /// 
        [Display(Name = "Centos", Description = "fa-centos", GroupName = "brands")]
        IconCentos = '\uf789',
        
        /// <summary>
        ///     Certificate ("fa-certificate", \uf0a3) icon.
        /// </summary>
        /// 
        [Display(Name = "Certificate", Description = "fa-certificate", GroupName = "duotone light regular solid")]
        IconCertificate = '\uf0a3',
        
        /// <summary>
        ///     Chair ("fa-chair", \uf6c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Chair", Description = "fa-chair", GroupName = "duotone light regular solid")]
        IconChair = '\uf6c0',
        
        /// <summary>
        ///     Chalkboard ("fa-chalkboard", \uf51b) icon.
        /// </summary>
        /// 
        [Display(Name = "Chalkboard", Description = "fa-chalkboard", GroupName = "duotone light regular solid")]
        IconChalkboard = '\uf51b',
        
        /// <summary>
        ///     Chalkboard Teacher ("fa-chalkboard-teacher", \uf51c) icon.
        /// </summary>
        /// 
        [Display(Name = "Chalkboard Teacher", Description = "fa-chalkboard-teacher", GroupName = "duotone light regular solid")]
        IconChalkboardTeacher = '\uf51c',
        
        /// <summary>
        ///     Charging Station ("fa-charging-station", \uf5e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Charging Station", Description = "fa-charging-station", GroupName = "duotone light regular solid")]
        IconChargingStation = '\uf5e7',
        
        /// <summary>
        ///     Chart Area ("fa-chart-area", \uf1fe) icon.
        /// </summary>
        /// 
        [Display(Name = "Chart Area", Description = "fa-chart-area", GroupName = "duotone light regular solid")]
        IconChartArea = '\uf1fe',
        
        /// <summary>
        ///     Chart Bar ("fa-chart-bar", \uf080) icon.
        /// </summary>
        /// 
        [Display(Name = "Chart Bar", Description = "fa-chart-bar", GroupName = "duotone light regular solid")]
        IconChartBar = '\uf080',
        
        /// <summary>
        ///     Chart Line ("fa-chart-line", \uf201) icon.
        /// </summary>
        /// 
        [Display(Name = "Chart Line", Description = "fa-chart-line", GroupName = "duotone light regular solid")]
        IconChartLine = '\uf201',
        
        /// <summary>
        ///     Chart Pie ("fa-chart-pie", \uf200) icon.
        /// </summary>
        /// 
        [Display(Name = "Chart Pie", Description = "fa-chart-pie", GroupName = "duotone light regular solid")]
        IconChartPie = '\uf200',
        
        /// <summary>
        ///     Check ("fa-check", \uf00c) icon.
        /// </summary>
        /// 
        [Display(Name = "Check", Description = "fa-check", GroupName = "duotone light regular solid")]
        IconCheck = '\uf00c',
        
        /// <summary>
        ///     Check Circle ("fa-check-circle", \uf058) icon.
        /// </summary>
        /// 
        [Display(Name = "Check Circle", Description = "fa-check-circle", GroupName = "duotone light regular solid")]
        IconCheckCircle = '\uf058',
        
        /// <summary>
        ///     Check Double ("fa-check-double", \uf560) icon.
        /// </summary>
        /// 
        [Display(Name = "Check Double", Description = "fa-check-double", GroupName = "duotone light regular solid")]
        IconCheckDouble = '\uf560',
        
        /// <summary>
        ///     Check Square ("fa-check-square", \uf14a) icon.
        /// </summary>
        /// 
        [Display(Name = "Check Square", Description = "fa-check-square", GroupName = "duotone light regular solid")]
        IconCheckSquare = '\uf14a',
        
        /// <summary>
        ///     Cheese ("fa-cheese", \uf7ef) icon.
        /// </summary>
        /// 
        [Display(Name = "Cheese", Description = "fa-cheese", GroupName = "duotone light regular solid")]
        IconCheese = '\uf7ef',
        
        /// <summary>
        ///     Chess ("fa-chess", \uf439) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess", Description = "fa-chess", GroupName = "duotone light regular solid")]
        IconChess = '\uf439',
        
        /// <summary>
        ///     Chess Bishop ("fa-chess-bishop", \uf43a) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Bishop", Description = "fa-chess-bishop", GroupName = "duotone light regular solid")]
        IconChessBishop = '\uf43a',
        
        /// <summary>
        ///     Chess Board ("fa-chess-board", \uf43c) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Board", Description = "fa-chess-board", GroupName = "duotone light regular solid")]
        IconChessBoard = '\uf43c',
        
        /// <summary>
        ///     Chess King ("fa-chess-king", \uf43f) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess King", Description = "fa-chess-king", GroupName = "duotone light regular solid")]
        IconChessKing = '\uf43f',
        
        /// <summary>
        ///     Chess Knight ("fa-chess-knight", \uf441) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Knight", Description = "fa-chess-knight", GroupName = "duotone light regular solid")]
        IconChessKnight = '\uf441',
        
        /// <summary>
        ///     Chess Pawn ("fa-chess-pawn", \uf443) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Pawn", Description = "fa-chess-pawn", GroupName = "duotone light regular solid")]
        IconChessPawn = '\uf443',
        
        /// <summary>
        ///     Chess Queen ("fa-chess-queen", \uf445) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Queen", Description = "fa-chess-queen", GroupName = "duotone light regular solid")]
        IconChessQueen = '\uf445',
        
        /// <summary>
        ///     Chess Rook ("fa-chess-rook", \uf447) icon.
        /// </summary>
        /// 
        [Display(Name = "Chess Rook", Description = "fa-chess-rook", GroupName = "duotone light regular solid")]
        IconChessRook = '\uf447',
        
        /// <summary>
        ///     Chevron Circle Down ("fa-chevron-circle-down", \uf13a) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Circle Down", Description = "fa-chevron-circle-down", GroupName = "duotone light regular solid")]
        IconChevronCircleDown = '\uf13a',
        
        /// <summary>
        ///     Chevron Circle Left ("fa-chevron-circle-left", \uf137) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Circle Left", Description = "fa-chevron-circle-left", GroupName = "duotone light regular solid")]
        IconChevronCircleLeft = '\uf137',
        
        /// <summary>
        ///     Chevron Circle Right ("fa-chevron-circle-right", \uf138) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Circle Right", Description = "fa-chevron-circle-right", GroupName = "duotone light regular solid")]
        IconChevronCircleRight = '\uf138',
        
        /// <summary>
        ///     Chevron Circle Up ("fa-chevron-circle-up", \uf139) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Circle Up", Description = "fa-chevron-circle-up", GroupName = "duotone light regular solid")]
        IconChevronCircleUp = '\uf139',
        
        /// <summary>
        ///     Chevron Down ("fa-chevron-down", \uf078) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Down", Description = "fa-chevron-down", GroupName = "duotone light regular solid")]
        IconChevronDown = '\uf078',
        
        /// <summary>
        ///     Chevron Left ("fa-chevron-left", \uf053) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Left", Description = "fa-chevron-left", GroupName = "duotone light regular solid")]
        IconChevronLeft = '\uf053',
        
        /// <summary>
        ///     Chevron Right ("fa-chevron-right", \uf054) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Right", Description = "fa-chevron-right", GroupName = "duotone light regular solid")]
        IconChevronRight = '\uf054',
        
        /// <summary>
        ///     Chevron Up ("fa-chevron-up", \uf077) icon.
        /// </summary>
        /// 
        [Display(Name = "Chevron Up", Description = "fa-chevron-up", GroupName = "duotone light regular solid")]
        IconChevronUp = '\uf077',
        
        /// <summary>
        ///     Child ("fa-child", \uf1ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Child", Description = "fa-child", GroupName = "duotone light regular solid")]
        IconChild = '\uf1ae',
        
        /// <summary>
        ///     Chrome ("fa-chrome", \uf268) icon.
        /// </summary>
        /// 
        [Display(Name = "Chrome", Description = "fa-chrome", GroupName = "brands")]
        IconChrome = '\uf268',
        
        /// <summary>
        ///     Chromecast ("fa-chromecast", \uf838) icon.
        /// </summary>
        /// 
        [Display(Name = "Chromecast", Description = "fa-chromecast", GroupName = "brands")]
        IconChromecast = '\uf838',
        
        /// <summary>
        ///     Church ("fa-church", \uf51d) icon.
        /// </summary>
        /// 
        [Display(Name = "Church", Description = "fa-church", GroupName = "duotone light regular solid")]
        IconChurch = '\uf51d',
        
        /// <summary>
        ///     Circle ("fa-circle", \uf111) icon.
        /// </summary>
        /// 
        [Display(Name = "Circle", Description = "fa-circle", GroupName = "duotone light regular solid")]
        IconCircle = '\uf111',
        
        /// <summary>
        ///     Circle Notch ("fa-circle-notch", \uf1ce) icon.
        /// </summary>
        /// 
        [Display(Name = "Circle Notch", Description = "fa-circle-notch", GroupName = "duotone light regular solid")]
        IconCircleNotch = '\uf1ce',
        
        /// <summary>
        ///     City ("fa-city", \uf64f) icon.
        /// </summary>
        /// 
        [Display(Name = "City", Description = "fa-city", GroupName = "duotone light regular solid")]
        IconCity = '\uf64f',
        
        /// <summary>
        ///     Clinic Medical ("fa-clinic-medical", \uf7f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Clinic Medical", Description = "fa-clinic-medical", GroupName = "duotone light regular solid")]
        IconClinicMedical = '\uf7f2',
        
        /// <summary>
        ///     Clipboard ("fa-clipboard", \uf328) icon.
        /// </summary>
        /// 
        [Display(Name = "Clipboard", Description = "fa-clipboard", GroupName = "duotone light regular solid")]
        IconClipboard = '\uf328',
        
        /// <summary>
        ///     Clipboard Check ("fa-clipboard-check", \uf46c) icon.
        /// </summary>
        /// 
        [Display(Name = "Clipboard Check", Description = "fa-clipboard-check", GroupName = "duotone light regular solid")]
        IconClipboardCheck = '\uf46c',
        
        /// <summary>
        ///     Clipboard List ("fa-clipboard-list", \uf46d) icon.
        /// </summary>
        /// 
        [Display(Name = "Clipboard List", Description = "fa-clipboard-list", GroupName = "duotone light regular solid")]
        IconClipboardList = '\uf46d',
        
        /// <summary>
        ///     Clock ("fa-clock", \uf017) icon.
        /// </summary>
        /// 
        [Display(Name = "Clock", Description = "fa-clock", GroupName = "duotone light regular solid")]
        IconClock = '\uf017',
        
        /// <summary>
        ///     Clone ("fa-clone", \uf24d) icon.
        /// </summary>
        /// 
        [Display(Name = "Clone", Description = "fa-clone", GroupName = "duotone light regular solid")]
        IconClone = '\uf24d',
        
        /// <summary>
        ///     Closed Captioning ("fa-closed-captioning", \uf20a) icon.
        /// </summary>
        /// 
        [Display(Name = "Closed Captioning", Description = "fa-closed-captioning", GroupName = "duotone light regular solid")]
        IconClosedCaptioning = '\uf20a',
        
        /// <summary>
        ///     Cloud ("fa-cloud", \uf0c2) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud", Description = "fa-cloud", GroupName = "duotone light regular solid")]
        IconCloud = '\uf0c2',
        
        /// <summary>
        ///     Cloud Download Alt ("fa-cloud-download-alt", \uf381) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Download Alt", Description = "fa-cloud-download-alt", GroupName = "duotone light regular solid")]
        IconCloudDownloadAlt = '\uf381',
        
        /// <summary>
        ///     Cloud Meatball ("fa-cloud-meatball", \uf73b) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Meatball", Description = "fa-cloud-meatball", GroupName = "duotone light regular solid")]
        IconCloudMeatball = '\uf73b',
        
        /// <summary>
        ///     Cloud Moon ("fa-cloud-moon", \uf6c3) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Moon", Description = "fa-cloud-moon", GroupName = "duotone light regular solid")]
        IconCloudMoon = '\uf6c3',
        
        /// <summary>
        ///     Cloud Moon Rain ("fa-cloud-moon-rain", \uf73c) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Moon Rain", Description = "fa-cloud-moon-rain", GroupName = "duotone light regular solid")]
        IconCloudMoonRain = '\uf73c',
        
        /// <summary>
        ///     Cloud Rain ("fa-cloud-rain", \uf73d) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Rain", Description = "fa-cloud-rain", GroupName = "duotone light regular solid")]
        IconCloudRain = '\uf73d',
        
        /// <summary>
        ///     Cloudscale ("fa-cloudscale", \uf383) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloudscale", Description = "fa-cloudscale", GroupName = "brands")]
        IconCloudscale = '\uf383',
        
        /// <summary>
        ///     Cloud Showers Heavy ("fa-cloud-showers-heavy", \uf740) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Showers Heavy", Description = "fa-cloud-showers-heavy", GroupName = "duotone light regular solid")]
        IconCloudShowersHeavy = '\uf740',
        
        /// <summary>
        ///     Cloudsmith ("fa-cloudsmith", \uf384) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloudsmith", Description = "fa-cloudsmith", GroupName = "brands")]
        IconCloudsmith = '\uf384',
        
        /// <summary>
        ///     Cloud Sun ("fa-cloud-sun", \uf6c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Sun", Description = "fa-cloud-sun", GroupName = "duotone light regular solid")]
        IconCloudSun = '\uf6c4',
        
        /// <summary>
        ///     Cloud Sun Rain ("fa-cloud-sun-rain", \uf743) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Sun Rain", Description = "fa-cloud-sun-rain", GroupName = "duotone light regular solid")]
        IconCloudSunRain = '\uf743',
        
        /// <summary>
        ///     Cloud Upload Alt ("fa-cloud-upload-alt", \uf382) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloud Upload Alt", Description = "fa-cloud-upload-alt", GroupName = "duotone light regular solid")]
        IconCloudUploadAlt = '\uf382',
        
        /// <summary>
        ///     Cloudversify ("fa-cloudversify", \uf385) icon.
        /// </summary>
        /// 
        [Display(Name = "Cloudversify", Description = "fa-cloudversify", GroupName = "brands")]
        IconCloudversify = '\uf385',
        
        /// <summary>
        ///     Cocktail ("fa-cocktail", \uf561) icon.
        /// </summary>
        /// 
        [Display(Name = "Cocktail", Description = "fa-cocktail", GroupName = "duotone light regular solid")]
        IconCocktail = '\uf561',
        
        /// <summary>
        ///     Code ("fa-code", \uf121) icon.
        /// </summary>
        /// 
        [Display(Name = "Code", Description = "fa-code", GroupName = "duotone light regular solid")]
        IconCode = '\uf121',
        
        /// <summary>
        ///     Code Branch ("fa-code-branch", \uf126) icon.
        /// </summary>
        /// 
        [Display(Name = "Code Branch", Description = "fa-code-branch", GroupName = "duotone light regular solid")]
        IconCodeBranch = '\uf126',
        
        /// <summary>
        ///     Codepen ("fa-codepen", \uf1cb) icon.
        /// </summary>
        /// 
        [Display(Name = "Codepen", Description = "fa-codepen", GroupName = "brands")]
        IconCodepen = '\uf1cb',
        
        /// <summary>
        ///     Codiepie ("fa-codiepie", \uf284) icon.
        /// </summary>
        /// 
        [Display(Name = "Codiepie", Description = "fa-codiepie", GroupName = "brands")]
        IconCodiepie = '\uf284',
        
        /// <summary>
        ///     Coffee ("fa-coffee", \uf0f4) icon.
        /// </summary>
        /// 
        [Display(Name = "Coffee", Description = "fa-coffee", GroupName = "duotone light regular solid")]
        IconCoffee = '\uf0f4',
        
        /// <summary>
        ///     Cog ("fa-cog", \uf013) icon.
        /// </summary>
        /// 
        [Display(Name = "Cog", Description = "fa-cog", GroupName = "duotone light regular solid")]
        IconCog = '\uf013',
        
        /// <summary>
        ///     Cogs ("fa-cogs", \uf085) icon.
        /// </summary>
        /// 
        [Display(Name = "Cogs", Description = "fa-cogs", GroupName = "duotone light regular solid")]
        IconCogs = '\uf085',
        
        /// <summary>
        ///     Coins ("fa-coins", \uf51e) icon.
        /// </summary>
        /// 
        [Display(Name = "Coins", Description = "fa-coins", GroupName = "duotone light regular solid")]
        IconCoins = '\uf51e',
        
        /// <summary>
        ///     Columns ("fa-columns", \uf0db) icon.
        /// </summary>
        /// 
        [Display(Name = "Columns", Description = "fa-columns", GroupName = "duotone light regular solid")]
        IconColumns = '\uf0db',
        
        /// <summary>
        ///     Comment ("fa-comment", \uf075) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment", Description = "fa-comment", GroupName = "duotone light regular solid")]
        IconComment = '\uf075',
        
        /// <summary>
        ///     Comment Alt ("fa-comment-alt", \uf27a) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment Alt", Description = "fa-comment-alt", GroupName = "duotone light regular solid")]
        IconCommentAlt = '\uf27a',
        
        /// <summary>
        ///     Comment Dollar ("fa-comment-dollar", \uf651) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment Dollar", Description = "fa-comment-dollar", GroupName = "duotone light regular solid")]
        IconCommentDollar = '\uf651',
        
        /// <summary>
        ///     Comment Dots ("fa-comment-dots", \uf4ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment Dots", Description = "fa-comment-dots", GroupName = "duotone light regular solid")]
        IconCommentDots = '\uf4ad',
        
        /// <summary>
        ///     Comment Medical ("fa-comment-medical", \uf7f5) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment Medical", Description = "fa-comment-medical", GroupName = "duotone light regular solid")]
        IconCommentMedical = '\uf7f5',
        
        /// <summary>
        ///     Comments ("fa-comments", \uf086) icon.
        /// </summary>
        /// 
        [Display(Name = "Comments", Description = "fa-comments", GroupName = "duotone light regular solid")]
        IconComments = '\uf086',
        
        /// <summary>
        ///     Comments Dollar ("fa-comments-dollar", \uf653) icon.
        /// </summary>
        /// 
        [Display(Name = "Comments Dollar", Description = "fa-comments-dollar", GroupName = "duotone light regular solid")]
        IconCommentsDollar = '\uf653',
        
        /// <summary>
        ///     Comment Slash ("fa-comment-slash", \uf4b3) icon.
        /// </summary>
        /// 
        [Display(Name = "Comment Slash", Description = "fa-comment-slash", GroupName = "duotone light regular solid")]
        IconCommentSlash = '\uf4b3',
        
        /// <summary>
        ///     Compact Disc ("fa-compact-disc", \uf51f) icon.
        /// </summary>
        /// 
        [Display(Name = "Compact Disc", Description = "fa-compact-disc", GroupName = "duotone light regular solid")]
        IconCompactDisc = '\uf51f',
        
        /// <summary>
        ///     Compass ("fa-compass", \uf14e) icon.
        /// </summary>
        /// 
        [Display(Name = "Compass", Description = "fa-compass", GroupName = "duotone light regular solid")]
        IconCompass = '\uf14e',
        
        /// <summary>
        ///     Compress ("fa-compress", \uf066) icon.
        /// </summary>
        /// 
        [Display(Name = "Compress", Description = "fa-compress", GroupName = "duotone light regular solid")]
        IconCompress = '\uf066',
        
        /// <summary>
        ///     Compress Alt ("fa-compress-alt", \uf422) icon.
        /// </summary>
        /// 
        [Display(Name = "Compress Alt", Description = "fa-compress-alt", GroupName = "duotone light regular solid")]
        IconCompressAlt = '\uf422',
        
        /// <summary>
        ///     Compress Arrows Alt ("fa-compress-arrows-alt", \uf78c) icon.
        /// </summary>
        /// 
        [Display(Name = "Compress Arrows Alt", Description = "fa-compress-arrows-alt", GroupName = "duotone light regular solid")]
        IconCompressArrowsAlt = '\uf78c',
        
        /// <summary>
        ///     Concierge Bell ("fa-concierge-bell", \uf562) icon.
        /// </summary>
        /// 
        [Display(Name = "Concierge Bell", Description = "fa-concierge-bell", GroupName = "duotone light regular solid")]
        IconConciergeBell = '\uf562',
        
        /// <summary>
        ///     Confluence ("fa-confluence", \uf78d) icon.
        /// </summary>
        /// 
        [Display(Name = "Confluence", Description = "fa-confluence", GroupName = "brands")]
        IconConfluence = '\uf78d',
        
        /// <summary>
        ///     Connectdevelop ("fa-connectdevelop", \uf20e) icon.
        /// </summary>
        /// 
        [Display(Name = "Connectdevelop", Description = "fa-connectdevelop", GroupName = "brands")]
        IconConnectdevelop = '\uf20e',
        
        /// <summary>
        ///     Contao ("fa-contao", \uf26d) icon.
        /// </summary>
        /// 
        [Display(Name = "Contao", Description = "fa-contao", GroupName = "brands")]
        IconContao = '\uf26d',
        
        /// <summary>
        ///     Cookie ("fa-cookie", \uf563) icon.
        /// </summary>
        /// 
        [Display(Name = "Cookie", Description = "fa-cookie", GroupName = "duotone light regular solid")]
        IconCookie = '\uf563',
        
        /// <summary>
        ///     Cookie Bite ("fa-cookie-bite", \uf564) icon.
        /// </summary>
        /// 
        [Display(Name = "Cookie Bite", Description = "fa-cookie-bite", GroupName = "duotone light regular solid")]
        IconCookieBite = '\uf564',
        
        /// <summary>
        ///     Copy ("fa-copy", \uf0c5) icon.
        /// </summary>
        /// 
        [Display(Name = "Copy", Description = "fa-copy", GroupName = "duotone light regular solid")]
        IconCopy = '\uf0c5',
        
        /// <summary>
        ///     Copyright ("fa-copyright", \uf1f9) icon.
        /// </summary>
        /// 
        [Display(Name = "Copyright", Description = "fa-copyright", GroupName = "duotone light regular solid")]
        IconCopyright = '\uf1f9',
        
        /// <summary>
        ///     Cotton Bureau ("fa-cotton-bureau", \uf89e) icon.
        /// </summary>
        /// 
        [Display(Name = "Cotton Bureau", Description = "fa-cotton-bureau", GroupName = "brands")]
        IconCottonBureau = '\uf89e',
        
        /// <summary>
        ///     Couch ("fa-couch", \uf4b8) icon.
        /// </summary>
        /// 
        [Display(Name = "Couch", Description = "fa-couch", GroupName = "duotone light regular solid")]
        IconCouch = '\uf4b8',
        
        /// <summary>
        ///     Cpanel ("fa-cpanel", \uf388) icon.
        /// </summary>
        /// 
        [Display(Name = "Cpanel", Description = "fa-cpanel", GroupName = "brands")]
        IconCpanel = '\uf388',
        
        /// <summary>
        ///     Creative Commons ("fa-creative-commons", \uf25e) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons", Description = "fa-creative-commons", GroupName = "brands")]
        IconCreativeCommons = '\uf25e',
        
        /// <summary>
        ///     Creative Commons By ("fa-creative-commons-by", \uf4e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons By", Description = "fa-creative-commons-by", GroupName = "brands")]
        IconCreativeCommonsBy = '\uf4e7',
        
        /// <summary>
        ///     Creative Commons Nc ("fa-creative-commons-nc", \uf4e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Nc", Description = "fa-creative-commons-nc", GroupName = "brands")]
        IconCreativeCommonsNc = '\uf4e8',
        
        /// <summary>
        ///     Creative Commons Nc Eu ("fa-creative-commons-nc-eu", \uf4e9) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Nc Eu", Description = "fa-creative-commons-nc-eu", GroupName = "brands")]
        IconCreativeCommonsNcEu = '\uf4e9',
        
        /// <summary>
        ///     Creative Commons Nc Jp ("fa-creative-commons-nc-jp", \uf4ea) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Nc Jp", Description = "fa-creative-commons-nc-jp", GroupName = "brands")]
        IconCreativeCommonsNcJp = '\uf4ea',
        
        /// <summary>
        ///     Creative Commons Nd ("fa-creative-commons-nd", \uf4eb) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Nd", Description = "fa-creative-commons-nd", GroupName = "brands")]
        IconCreativeCommonsNd = '\uf4eb',
        
        /// <summary>
        ///     Creative Commons Pd ("fa-creative-commons-pd", \uf4ec) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Pd", Description = "fa-creative-commons-pd", GroupName = "brands")]
        IconCreativeCommonsPd = '\uf4ec',
        
        /// <summary>
        ///     Creative Commons Pd Alt ("fa-creative-commons-pd-alt", \uf4ed) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Pd Alt", Description = "fa-creative-commons-pd-alt", GroupName = "brands")]
        IconCreativeCommonsPdAlt = '\uf4ed',
        
        /// <summary>
        ///     Creative Commons Remix ("fa-creative-commons-remix", \uf4ee) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Remix", Description = "fa-creative-commons-remix", GroupName = "brands")]
        IconCreativeCommonsRemix = '\uf4ee',
        
        /// <summary>
        ///     Creative Commons Sa ("fa-creative-commons-sa", \uf4ef) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Sa", Description = "fa-creative-commons-sa", GroupName = "brands")]
        IconCreativeCommonsSa = '\uf4ef',
        
        /// <summary>
        ///     Creative Commons Sampling ("fa-creative-commons-sampling", \uf4f0) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Sampling", Description = "fa-creative-commons-sampling", GroupName = "brands")]
        IconCreativeCommonsSampling = '\uf4f0',
        
        /// <summary>
        ///     Creative Commons Sampling Plus ("fa-creative-commons-sampling-plus", \uf4f1) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Sampling Plus", Description = "fa-creative-commons-sampling-plus", GroupName = "brands")]
        IconCreativeCommonsSamplingPlus = '\uf4f1',
        
        /// <summary>
        ///     Creative Commons Share ("fa-creative-commons-share", \uf4f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Share", Description = "fa-creative-commons-share", GroupName = "brands")]
        IconCreativeCommonsShare = '\uf4f2',
        
        /// <summary>
        ///     Creative Commons Zero ("fa-creative-commons-zero", \uf4f3) icon.
        /// </summary>
        /// 
        [Display(Name = "Creative Commons Zero", Description = "fa-creative-commons-zero", GroupName = "brands")]
        IconCreativeCommonsZero = '\uf4f3',
        
        /// <summary>
        ///     Credit Card ("fa-credit-card", \uf09d) icon.
        /// </summary>
        /// 
        [Display(Name = "Credit Card", Description = "fa-credit-card", GroupName = "duotone light regular solid")]
        IconCreditCard = '\uf09d',
        
        /// <summary>
        ///     Critical Role ("fa-critical-role", \uf6c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Critical Role", Description = "fa-critical-role", GroupName = "brands")]
        IconCriticalRole = '\uf6c9',
        
        /// <summary>
        ///     Crop ("fa-crop", \uf125) icon.
        /// </summary>
        /// 
        [Display(Name = "Crop", Description = "fa-crop", GroupName = "duotone light regular solid")]
        IconCrop = '\uf125',
        
        /// <summary>
        ///     Crop Alt ("fa-crop-alt", \uf565) icon.
        /// </summary>
        /// 
        [Display(Name = "Crop Alt", Description = "fa-crop-alt", GroupName = "duotone light regular solid")]
        IconCropAlt = '\uf565',
        
        /// <summary>
        ///     Cross ("fa-cross", \uf654) icon.
        /// </summary>
        /// 
        [Display(Name = "Cross", Description = "fa-cross", GroupName = "duotone light regular solid")]
        IconCross = '\uf654',
        
        /// <summary>
        ///     Crosshairs ("fa-crosshairs", \uf05b) icon.
        /// </summary>
        /// 
        [Display(Name = "Crosshairs", Description = "fa-crosshairs", GroupName = "duotone light regular solid")]
        IconCrosshairs = '\uf05b',
        
        /// <summary>
        ///     Crow ("fa-crow", \uf520) icon.
        /// </summary>
        /// 
        [Display(Name = "Crow", Description = "fa-crow", GroupName = "duotone light regular solid")]
        IconCrow = '\uf520',
        
        /// <summary>
        ///     Crown ("fa-crown", \uf521) icon.
        /// </summary>
        /// 
        [Display(Name = "Crown", Description = "fa-crown", GroupName = "duotone light regular solid")]
        IconCrown = '\uf521',
        
        /// <summary>
        ///     Crutch ("fa-crutch", \uf7f7) icon.
        /// </summary>
        /// 
        [Display(Name = "Crutch", Description = "fa-crutch", GroupName = "duotone light regular solid")]
        IconCrutch = '\uf7f7',
        
        /// <summary>
        ///     Css3 ("fa-css3", \uf13c) icon.
        /// </summary>
        /// 
        [Display(Name = "Css3", Description = "fa-css3", GroupName = "brands")]
        IconCss3 = '\uf13c',
        
        /// <summary>
        ///     Css3 Alt ("fa-css3-alt", \uf38b) icon.
        /// </summary>
        /// 
        [Display(Name = "Css3 Alt", Description = "fa-css3-alt", GroupName = "brands")]
        IconCss3Alt = '\uf38b',
        
        /// <summary>
        ///     Cube ("fa-cube", \uf1b2) icon.
        /// </summary>
        /// 
        [Display(Name = "Cube", Description = "fa-cube", GroupName = "duotone light regular solid")]
        IconCube = '\uf1b2',
        
        /// <summary>
        ///     Cubes ("fa-cubes", \uf1b3) icon.
        /// </summary>
        /// 
        [Display(Name = "Cubes", Description = "fa-cubes", GroupName = "duotone light regular solid")]
        IconCubes = '\uf1b3',
        
        /// <summary>
        ///     Cut ("fa-cut", \uf0c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Cut", Description = "fa-cut", GroupName = "duotone light regular solid")]
        IconCut = '\uf0c4',
        
        /// <summary>
        ///     Cuttlefish ("fa-cuttlefish", \uf38c) icon.
        /// </summary>
        /// 
        [Display(Name = "Cuttlefish", Description = "fa-cuttlefish", GroupName = "brands")]
        IconCuttlefish = '\uf38c',
        
        /// <summary>
        ///     Dailymotion ("fa-dailymotion", \uf952) icon.
        /// </summary>
        /// 
        [Display(Name = "Dailymotion", Description = "fa-dailymotion", GroupName = "brands")]
        IconDailymotion = '\uf952',
        
        /// <summary>
        ///     D And D ("fa-d-and-d", \uf38d) icon.
        /// </summary>
        /// 
        [Display(Name = "D And D", Description = "fa-d-and-d", GroupName = "brands")]
        IconDAndD = '\uf38d',
        
        /// <summary>
        ///     D And D Beyond ("fa-d-and-d-beyond", \uf6ca) icon.
        /// </summary>
        /// 
        [Display(Name = "D And D Beyond", Description = "fa-d-and-d-beyond", GroupName = "brands")]
        IconDAndDBeyond = '\uf6ca',
        
        /// <summary>
        ///     Dashcube ("fa-dashcube", \uf210) icon.
        /// </summary>
        /// 
        [Display(Name = "Dashcube", Description = "fa-dashcube", GroupName = "brands")]
        IconDashcube = '\uf210',
        
        /// <summary>
        ///     Database ("fa-database", \uf1c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Database", Description = "fa-database", GroupName = "duotone light regular solid")]
        IconDatabase = '\uf1c0',
        
        /// <summary>
        ///     Deaf ("fa-deaf", \uf2a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Deaf", Description = "fa-deaf", GroupName = "duotone light regular solid")]
        IconDeaf = '\uf2a4',
        
        /// <summary>
        ///     Delicious ("fa-delicious", \uf1a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Delicious", Description = "fa-delicious", GroupName = "brands")]
        IconDelicious = '\uf1a5',
        
        /// <summary>
        ///     Democrat ("fa-democrat", \uf747) icon.
        /// </summary>
        /// 
        [Display(Name = "Democrat", Description = "fa-democrat", GroupName = "duotone light regular solid")]
        IconDemocrat = '\uf747',
        
        /// <summary>
        ///     Deploydog ("fa-deploydog", \uf38e) icon.
        /// </summary>
        /// 
        [Display(Name = "Deploydog", Description = "fa-deploydog", GroupName = "brands")]
        IconDeploydog = '\uf38e',
        
        /// <summary>
        ///     Deskpro ("fa-deskpro", \uf38f) icon.
        /// </summary>
        /// 
        [Display(Name = "Deskpro", Description = "fa-deskpro", GroupName = "brands")]
        IconDeskpro = '\uf38f',
        
        /// <summary>
        ///     Desktop ("fa-desktop", \uf108) icon.
        /// </summary>
        /// 
        [Display(Name = "Desktop", Description = "fa-desktop", GroupName = "duotone light regular solid")]
        IconDesktop = '\uf108',
        
        /// <summary>
        ///     Dev ("fa-dev", \uf6cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Dev", Description = "fa-dev", GroupName = "brands")]
        IconDev = '\uf6cc',
        
        /// <summary>
        ///     Deviantart ("fa-deviantart", \uf1bd) icon.
        /// </summary>
        /// 
        [Display(Name = "Deviantart", Description = "fa-deviantart", GroupName = "brands")]
        IconDeviantart = '\uf1bd',
        
        /// <summary>
        ///     Dharmachakra ("fa-dharmachakra", \uf655) icon.
        /// </summary>
        /// 
        [Display(Name = "Dharmachakra", Description = "fa-dharmachakra", GroupName = "duotone light regular solid")]
        IconDharmachakra = '\uf655',
        
        /// <summary>
        ///     Dhl ("fa-dhl", \uf790) icon.
        /// </summary>
        /// 
        [Display(Name = "Dhl", Description = "fa-dhl", GroupName = "brands")]
        IconDhl = '\uf790',
        
        /// <summary>
        ///     Diagnoses ("fa-diagnoses", \uf470) icon.
        /// </summary>
        /// 
        [Display(Name = "Diagnoses", Description = "fa-diagnoses", GroupName = "duotone light regular solid")]
        IconDiagnoses = '\uf470',
        
        /// <summary>
        ///     Diaspora ("fa-diaspora", \uf791) icon.
        /// </summary>
        /// 
        [Display(Name = "Diaspora", Description = "fa-diaspora", GroupName = "brands")]
        IconDiaspora = '\uf791',
        
        /// <summary>
        ///     Dice ("fa-dice", \uf522) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice", Description = "fa-dice", GroupName = "duotone light regular solid")]
        IconDice = '\uf522',
        
        /// <summary>
        ///     Dice D20 ("fa-dice-d20", \uf6cf) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice D20", Description = "fa-dice-d20", GroupName = "duotone light regular solid")]
        IconDiceD20 = '\uf6cf',
        
        /// <summary>
        ///     Dice D6 ("fa-dice-d6", \uf6d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice D6", Description = "fa-dice-d6", GroupName = "duotone light regular solid")]
        IconDiceD6 = '\uf6d1',
        
        /// <summary>
        ///     Dice Five ("fa-dice-five", \uf523) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice Five", Description = "fa-dice-five", GroupName = "duotone light regular solid")]
        IconDiceFive = '\uf523',
        
        /// <summary>
        ///     Dice Four ("fa-dice-four", \uf524) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice Four", Description = "fa-dice-four", GroupName = "duotone light regular solid")]
        IconDiceFour = '\uf524',
        
        /// <summary>
        ///     Dice One ("fa-dice-one", \uf525) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice One", Description = "fa-dice-one", GroupName = "duotone light regular solid")]
        IconDiceOne = '\uf525',
        
        /// <summary>
        ///     Dice Six ("fa-dice-six", \uf526) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice Six", Description = "fa-dice-six", GroupName = "duotone light regular solid")]
        IconDiceSix = '\uf526',
        
        /// <summary>
        ///     Dice Three ("fa-dice-three", \uf527) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice Three", Description = "fa-dice-three", GroupName = "duotone light regular solid")]
        IconDiceThree = '\uf527',
        
        /// <summary>
        ///     Dice Two ("fa-dice-two", \uf528) icon.
        /// </summary>
        /// 
        [Display(Name = "Dice Two", Description = "fa-dice-two", GroupName = "duotone light regular solid")]
        IconDiceTwo = '\uf528',
        
        /// <summary>
        ///     Digg ("fa-digg", \uf1a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Digg", Description = "fa-digg", GroupName = "brands")]
        IconDigg = '\uf1a6',
        
        /// <summary>
        ///     Digital Ocean ("fa-digital-ocean", \uf391) icon.
        /// </summary>
        /// 
        [Display(Name = "Digital Ocean", Description = "fa-digital-ocean", GroupName = "brands")]
        IconDigitalOcean = '\uf391',
        
        /// <summary>
        ///     Digital Tachograph ("fa-digital-tachograph", \uf566) icon.
        /// </summary>
        /// 
        [Display(Name = "Digital Tachograph", Description = "fa-digital-tachograph", GroupName = "duotone light regular solid")]
        IconDigitalTachograph = '\uf566',
        
        /// <summary>
        ///     Directions ("fa-directions", \uf5eb) icon.
        /// </summary>
        /// 
        [Display(Name = "Directions", Description = "fa-directions", GroupName = "duotone light regular solid")]
        IconDirections = '\uf5eb',
        
        /// <summary>
        ///     Discord ("fa-discord", \uf392) icon.
        /// </summary>
        /// 
        [Display(Name = "Discord", Description = "fa-discord", GroupName = "brands")]
        IconDiscord = '\uf392',
        
        /// <summary>
        ///     Discourse ("fa-discourse", \uf393) icon.
        /// </summary>
        /// 
        [Display(Name = "Discourse", Description = "fa-discourse", GroupName = "brands")]
        IconDiscourse = '\uf393',
        
        /// <summary>
        ///     Disease ("fa-disease", \uf7fa) icon.
        /// </summary>
        /// 
        [Display(Name = "Disease", Description = "fa-disease", GroupName = "duotone light regular solid")]
        IconDisease = '\uf7fa',
        
        /// <summary>
        ///     Divide ("fa-divide", \uf529) icon.
        /// </summary>
        /// 
        [Display(Name = "Divide", Description = "fa-divide", GroupName = "duotone light regular solid")]
        IconDivide = '\uf529',
        
        /// <summary>
        ///     Dizzy ("fa-dizzy", \uf567) icon.
        /// </summary>
        /// 
        [Display(Name = "Dizzy", Description = "fa-dizzy", GroupName = "duotone light regular solid")]
        IconDizzy = '\uf567',
        
        /// <summary>
        ///     Dna ("fa-dna", \uf471) icon.
        /// </summary>
        /// 
        [Display(Name = "Dna", Description = "fa-dna", GroupName = "duotone light regular solid")]
        IconDna = '\uf471',
        
        /// <summary>
        ///     Dochub ("fa-dochub", \uf394) icon.
        /// </summary>
        /// 
        [Display(Name = "Dochub", Description = "fa-dochub", GroupName = "brands")]
        IconDochub = '\uf394',
        
        /// <summary>
        ///     Docker ("fa-docker", \uf395) icon.
        /// </summary>
        /// 
        [Display(Name = "Docker", Description = "fa-docker", GroupName = "brands")]
        IconDocker = '\uf395',
        
        /// <summary>
        ///     Dog ("fa-dog", \uf6d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Dog", Description = "fa-dog", GroupName = "duotone light regular solid")]
        IconDog = '\uf6d3',
        
        /// <summary>
        ///     Dollar Sign ("fa-dollar-sign", \uf155) icon.
        /// </summary>
        /// 
        [Display(Name = "Dollar Sign", Description = "fa-dollar-sign", GroupName = "duotone light regular solid")]
        IconDollarSign = '\uf155',
        
        /// <summary>
        ///     Dolly ("fa-dolly", \uf472) icon.
        /// </summary>
        /// 
        [Display(Name = "Dolly", Description = "fa-dolly", GroupName = "duotone light regular solid")]
        IconDolly = '\uf472',
        
        /// <summary>
        ///     Dolly Flatbed ("fa-dolly-flatbed", \uf474) icon.
        /// </summary>
        /// 
        [Display(Name = "Dolly Flatbed", Description = "fa-dolly-flatbed", GroupName = "duotone light regular solid")]
        IconDollyFlatbed = '\uf474',
        
        /// <summary>
        ///     Donate ("fa-donate", \uf4b9) icon.
        /// </summary>
        /// 
        [Display(Name = "Donate", Description = "fa-donate", GroupName = "duotone light regular solid")]
        IconDonate = '\uf4b9',
        
        /// <summary>
        ///     Door Closed ("fa-door-closed", \uf52a) icon.
        /// </summary>
        /// 
        [Display(Name = "Door Closed", Description = "fa-door-closed", GroupName = "duotone light regular solid")]
        IconDoorClosed = '\uf52a',
        
        /// <summary>
        ///     Door Open ("fa-door-open", \uf52b) icon.
        /// </summary>
        /// 
        [Display(Name = "Door Open", Description = "fa-door-open", GroupName = "duotone light regular solid")]
        IconDoorOpen = '\uf52b',
        
        /// <summary>
        ///     Dot Circle ("fa-dot-circle", \uf192) icon.
        /// </summary>
        /// 
        [Display(Name = "Dot Circle", Description = "fa-dot-circle", GroupName = "duotone light regular solid")]
        IconDotCircle = '\uf192',
        
        /// <summary>
        ///     Dove ("fa-dove", \uf4ba) icon.
        /// </summary>
        /// 
        [Display(Name = "Dove", Description = "fa-dove", GroupName = "duotone light regular solid")]
        IconDove = '\uf4ba',
        
        /// <summary>
        ///     Download ("fa-download", \uf019) icon.
        /// </summary>
        /// 
        [Display(Name = "Download", Description = "fa-download", GroupName = "duotone light regular solid")]
        IconDownload = '\uf019',
        
        /// <summary>
        ///     Draft2digital ("fa-draft2digital", \uf396) icon.
        /// </summary>
        /// 
        [Display(Name = "Draft2digital", Description = "fa-draft2digital", GroupName = "brands")]
        IconDraft2digital = '\uf396',
        
        /// <summary>
        ///     Drafting Compass ("fa-drafting-compass", \uf568) icon.
        /// </summary>
        /// 
        [Display(Name = "Drafting Compass", Description = "fa-drafting-compass", GroupName = "duotone light regular solid")]
        IconDraftingCompass = '\uf568',
        
        /// <summary>
        ///     Dragon ("fa-dragon", \uf6d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Dragon", Description = "fa-dragon", GroupName = "duotone light regular solid")]
        IconDragon = '\uf6d5',
        
        /// <summary>
        ///     Draw Polygon ("fa-draw-polygon", \uf5ee) icon.
        /// </summary>
        /// 
        [Display(Name = "Draw Polygon", Description = "fa-draw-polygon", GroupName = "duotone light regular solid")]
        IconDrawPolygon = '\uf5ee',
        
        /// <summary>
        ///     Dribbble ("fa-dribbble", \uf17d) icon.
        /// </summary>
        /// 
        [Display(Name = "Dribbble", Description = "fa-dribbble", GroupName = "brands")]
        IconDribbble = '\uf17d',
        
        /// <summary>
        ///     Dribbble Square ("fa-dribbble-square", \uf397) icon.
        /// </summary>
        /// 
        [Display(Name = "Dribbble Square", Description = "fa-dribbble-square", GroupName = "brands")]
        IconDribbbleSquare = '\uf397',
        
        /// <summary>
        ///     Dropbox ("fa-dropbox", \uf16b) icon.
        /// </summary>
        /// 
        [Display(Name = "Dropbox", Description = "fa-dropbox", GroupName = "brands")]
        IconDropbox = '\uf16b',
        
        /// <summary>
        ///     Drum ("fa-drum", \uf569) icon.
        /// </summary>
        /// 
        [Display(Name = "Drum", Description = "fa-drum", GroupName = "duotone light regular solid")]
        IconDrum = '\uf569',
        
        /// <summary>
        ///     Drum Steelpan ("fa-drum-steelpan", \uf56a) icon.
        /// </summary>
        /// 
        [Display(Name = "Drum Steelpan", Description = "fa-drum-steelpan", GroupName = "duotone light regular solid")]
        IconDrumSteelpan = '\uf56a',
        
        /// <summary>
        ///     Drumstick Bite ("fa-drumstick-bite", \uf6d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Drumstick Bite", Description = "fa-drumstick-bite", GroupName = "duotone light regular solid")]
        IconDrumstickBite = '\uf6d7',
        
        /// <summary>
        ///     Drupal ("fa-drupal", \uf1a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Drupal", Description = "fa-drupal", GroupName = "brands")]
        IconDrupal = '\uf1a9',
        
        /// <summary>
        ///     Dumbbell ("fa-dumbbell", \uf44b) icon.
        /// </summary>
        /// 
        [Display(Name = "Dumbbell", Description = "fa-dumbbell", GroupName = "duotone light regular solid")]
        IconDumbbell = '\uf44b',
        
        /// <summary>
        ///     Dumpster ("fa-dumpster", \uf793) icon.
        /// </summary>
        /// 
        [Display(Name = "Dumpster", Description = "fa-dumpster", GroupName = "duotone light regular solid")]
        IconDumpster = '\uf793',
        
        /// <summary>
        ///     Dumpster Fire ("fa-dumpster-fire", \uf794) icon.
        /// </summary>
        /// 
        [Display(Name = "Dumpster Fire", Description = "fa-dumpster-fire", GroupName = "duotone light regular solid")]
        IconDumpsterFire = '\uf794',
        
        /// <summary>
        ///     Dungeon ("fa-dungeon", \uf6d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Dungeon", Description = "fa-dungeon", GroupName = "duotone light regular solid")]
        IconDungeon = '\uf6d9',
        
        /// <summary>
        ///     Dyalog ("fa-dyalog", \uf399) icon.
        /// </summary>
        /// 
        [Display(Name = "Dyalog", Description = "fa-dyalog", GroupName = "brands")]
        IconDyalog = '\uf399',
        
        /// <summary>
        ///     Earlybirds ("fa-earlybirds", \uf39a) icon.
        /// </summary>
        /// 
        [Display(Name = "Earlybirds", Description = "fa-earlybirds", GroupName = "brands")]
        IconEarlybirds = '\uf39a',
        
        /// <summary>
        ///     Ebay ("fa-ebay", \uf4f4) icon.
        /// </summary>
        /// 
        [Display(Name = "Ebay", Description = "fa-ebay", GroupName = "brands")]
        IconEbay = '\uf4f4',
        
        /// <summary>
        ///     Edge ("fa-edge", \uf282) icon.
        /// </summary>
        /// 
        [Display(Name = "Edge", Description = "fa-edge", GroupName = "brands")]
        IconEdge = '\uf282',
        
        /// <summary>
        ///     Edit ("fa-edit", \uf044) icon.
        /// </summary>
        /// 
        [Display(Name = "Edit", Description = "fa-edit", GroupName = "duotone light regular solid")]
        IconEdit = '\uf044',
        
        /// <summary>
        ///     Egg ("fa-egg", \uf7fb) icon.
        /// </summary>
        /// 
        [Display(Name = "Egg", Description = "fa-egg", GroupName = "duotone light regular solid")]
        IconEgg = '\uf7fb',
        
        /// <summary>
        ///     Eject ("fa-eject", \uf052) icon.
        /// </summary>
        /// 
        [Display(Name = "Eject", Description = "fa-eject", GroupName = "duotone light regular solid")]
        IconEject = '\uf052',
        
        /// <summary>
        ///     Elementor ("fa-elementor", \uf430) icon.
        /// </summary>
        /// 
        [Display(Name = "Elementor", Description = "fa-elementor", GroupName = "brands")]
        IconElementor = '\uf430',
        
        /// <summary>
        ///     Ellipsis H ("fa-ellipsis-h", \uf141) icon.
        /// </summary>
        /// 
        [Display(Name = "Ellipsis H", Description = "fa-ellipsis-h", GroupName = "duotone light regular solid")]
        IconEllipsisH = '\uf141',
        
        /// <summary>
        ///     Ellipsis V ("fa-ellipsis-v", \uf142) icon.
        /// </summary>
        /// 
        [Display(Name = "Ellipsis V", Description = "fa-ellipsis-v", GroupName = "duotone light regular solid")]
        IconEllipsisV = '\uf142',
        
        /// <summary>
        ///     Ello ("fa-ello", \uf5f1) icon.
        /// </summary>
        /// 
        [Display(Name = "Ello", Description = "fa-ello", GroupName = "brands")]
        IconEllo = '\uf5f1',
        
        /// <summary>
        ///     Ember ("fa-ember", \uf423) icon.
        /// </summary>
        /// 
        [Display(Name = "Ember", Description = "fa-ember", GroupName = "brands")]
        IconEmber = '\uf423',
        
        /// <summary>
        ///     Empire ("fa-empire", \uf1d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Empire", Description = "fa-empire", GroupName = "brands")]
        IconEmpire = '\uf1d1',
        
        /// <summary>
        ///     Envelope ("fa-envelope", \uf0e0) icon.
        /// </summary>
        /// 
        [Display(Name = "Envelope", Description = "fa-envelope", GroupName = "duotone light regular solid")]
        IconEnvelope = '\uf0e0',
        
        /// <summary>
        ///     Envelope Open ("fa-envelope-open", \uf2b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Envelope Open", Description = "fa-envelope-open", GroupName = "duotone light regular solid")]
        IconEnvelopeOpen = '\uf2b6',
        
        /// <summary>
        ///     Envelope Open Text ("fa-envelope-open-text", \uf658) icon.
        /// </summary>
        /// 
        [Display(Name = "Envelope Open Text", Description = "fa-envelope-open-text", GroupName = "duotone light regular solid")]
        IconEnvelopeOpenText = '\uf658',
        
        /// <summary>
        ///     Envelope Square ("fa-envelope-square", \uf199) icon.
        /// </summary>
        /// 
        [Display(Name = "Envelope Square", Description = "fa-envelope-square", GroupName = "duotone light regular solid")]
        IconEnvelopeSquare = '\uf199',
        
        /// <summary>
        ///     Envira ("fa-envira", \uf299) icon.
        /// </summary>
        /// 
        [Display(Name = "Envira", Description = "fa-envira", GroupName = "brands")]
        IconEnvira = '\uf299',
        
        /// <summary>
        ///     Equals ("fa-equals", \uf52c) icon.
        /// </summary>
        /// 
        [Display(Name = "Equals", Description = "fa-equals", GroupName = "duotone light regular solid")]
        IconEquals = '\uf52c',
        
        /// <summary>
        ///     Eraser ("fa-eraser", \uf12d) icon.
        /// </summary>
        /// 
        [Display(Name = "Eraser", Description = "fa-eraser", GroupName = "duotone light regular solid")]
        IconEraser = '\uf12d',
        
        /// <summary>
        ///     Erlang ("fa-erlang", \uf39d) icon.
        /// </summary>
        /// 
        [Display(Name = "Erlang", Description = "fa-erlang", GroupName = "brands")]
        IconErlang = '\uf39d',
        
        /// <summary>
        ///     Ethereum ("fa-ethereum", \uf42e) icon.
        /// </summary>
        /// 
        [Display(Name = "Ethereum", Description = "fa-ethereum", GroupName = "brands")]
        IconEthereum = '\uf42e',
        
        /// <summary>
        ///     Ethernet ("fa-ethernet", \uf796) icon.
        /// </summary>
        /// 
        [Display(Name = "Ethernet", Description = "fa-ethernet", GroupName = "duotone light regular solid")]
        IconEthernet = '\uf796',
        
        /// <summary>
        ///     Etsy ("fa-etsy", \uf2d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Etsy", Description = "fa-etsy", GroupName = "brands")]
        IconEtsy = '\uf2d7',
        
        /// <summary>
        ///     Euro Sign ("fa-euro-sign", \uf153) icon.
        /// </summary>
        /// 
        [Display(Name = "Euro Sign", Description = "fa-euro-sign", GroupName = "duotone light regular solid")]
        IconEuroSign = '\uf153',
        
        /// <summary>
        ///     Evernote ("fa-evernote", \uf839) icon.
        /// </summary>
        /// 
        [Display(Name = "Evernote", Description = "fa-evernote", GroupName = "brands")]
        IconEvernote = '\uf839',
        
        /// <summary>
        ///     Exchange Alt ("fa-exchange-alt", \uf362) icon.
        /// </summary>
        /// 
        [Display(Name = "Exchange Alt", Description = "fa-exchange-alt", GroupName = "duotone light regular solid")]
        IconExchangeAlt = '\uf362',
        
        /// <summary>
        ///     Exclamation ("fa-exclamation", \uf12a) icon.
        /// </summary>
        /// 
        [Display(Name = "Exclamation", Description = "fa-exclamation", GroupName = "duotone light regular solid")]
        IconExclamation = '\uf12a',
        
        /// <summary>
        ///     Exclamation Circle ("fa-exclamation-circle", \uf06a) icon.
        /// </summary>
        /// 
        [Display(Name = "Exclamation Circle", Description = "fa-exclamation-circle", GroupName = "duotone light regular solid")]
        IconExclamationCircle = '\uf06a',
        
        /// <summary>
        ///     Exclamation Triangle ("fa-exclamation-triangle", \uf071) icon.
        /// </summary>
        /// 
        [Display(Name = "Exclamation Triangle", Description = "fa-exclamation-triangle", GroupName = "duotone light regular solid")]
        IconExclamationTriangle = '\uf071',
        
        /// <summary>
        ///     Expand ("fa-expand", \uf065) icon.
        /// </summary>
        /// 
        [Display(Name = "Expand", Description = "fa-expand", GroupName = "duotone light regular solid")]
        IconExpand = '\uf065',
        
        /// <summary>
        ///     Expand Alt ("fa-expand-alt", \uf424) icon.
        /// </summary>
        /// 
        [Display(Name = "Expand Alt", Description = "fa-expand-alt", GroupName = "duotone light regular solid")]
        IconExpandAlt = '\uf424',
        
        /// <summary>
        ///     Expand Arrows Alt ("fa-expand-arrows-alt", \uf31e) icon.
        /// </summary>
        /// 
        [Display(Name = "Expand Arrows Alt", Description = "fa-expand-arrows-alt", GroupName = "duotone light regular solid")]
        IconExpandArrowsAlt = '\uf31e',
        
        /// <summary>
        ///     Expeditedssl ("fa-expeditedssl", \uf23e) icon.
        /// </summary>
        /// 
        [Display(Name = "Expeditedssl", Description = "fa-expeditedssl", GroupName = "brands")]
        IconExpeditedssl = '\uf23e',
        
        /// <summary>
        ///     External Link Alt ("fa-external-link-alt", \uf35d) icon.
        /// </summary>
        /// 
        [Display(Name = "External Link Alt", Description = "fa-external-link-alt", GroupName = "duotone light regular solid")]
        IconExternalLinkAlt = '\uf35d',
        
        /// <summary>
        ///     External Link Square Alt ("fa-external-link-square-alt", \uf360) icon.
        /// </summary>
        /// 
        [Display(Name = "External Link Square Alt", Description = "fa-external-link-square-alt", GroupName = "duotone light regular solid")]
        IconExternalLinkSquareAlt = '\uf360',
        
        /// <summary>
        ///     Eye ("fa-eye", \uf06e) icon.
        /// </summary>
        /// 
        [Display(Name = "Eye", Description = "fa-eye", GroupName = "duotone light regular solid")]
        IconEye = '\uf06e',
        
        /// <summary>
        ///     Eye Dropper ("fa-eye-dropper", \uf1fb) icon.
        /// </summary>
        /// 
        [Display(Name = "Eye Dropper", Description = "fa-eye-dropper", GroupName = "duotone light regular solid")]
        IconEyeDropper = '\uf1fb',
        
        /// <summary>
        ///     Eye Slash ("fa-eye-slash", \uf070) icon.
        /// </summary>
        /// 
        [Display(Name = "Eye Slash", Description = "fa-eye-slash", GroupName = "duotone light regular solid")]
        IconEyeSlash = '\uf070',
        
        /// <summary>
        ///     Facebook ("fa-facebook", \uf09a) icon.
        /// </summary>
        /// 
        [Display(Name = "Facebook", Description = "fa-facebook", GroupName = "brands")]
        IconFacebook = '\uf09a',
        
        /// <summary>
        ///     Facebook F ("fa-facebook-f", \uf39e) icon.
        /// </summary>
        /// 
        [Display(Name = "Facebook F", Description = "fa-facebook-f", GroupName = "brands")]
        IconFacebookF = '\uf39e',
        
        /// <summary>
        ///     Facebook Messenger ("fa-facebook-messenger", \uf39f) icon.
        /// </summary>
        /// 
        [Display(Name = "Facebook Messenger", Description = "fa-facebook-messenger", GroupName = "brands")]
        IconFacebookMessenger = '\uf39f',
        
        /// <summary>
        ///     Facebook Square ("fa-facebook-square", \uf082) icon.
        /// </summary>
        /// 
        [Display(Name = "Facebook Square", Description = "fa-facebook-square", GroupName = "brands")]
        IconFacebookSquare = '\uf082',
        
        /// <summary>
        ///     Fan ("fa-fan", \uf863) icon.
        /// </summary>
        /// 
        [Display(Name = "Fan", Description = "fa-fan", GroupName = "duotone light regular solid")]
        IconFan = '\uf863',
        
        /// <summary>
        ///     Fantasy Flight Games ("fa-fantasy-flight-games", \uf6dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Fantasy Flight Games", Description = "fa-fantasy-flight-games", GroupName = "brands")]
        IconFantasyFlightGames = '\uf6dc',
        
        /// <summary>
        ///     Fast Backward ("fa-fast-backward", \uf049) icon.
        /// </summary>
        /// 
        [Display(Name = "Fast Backward", Description = "fa-fast-backward", GroupName = "duotone light regular solid")]
        IconFastBackward = '\uf049',
        
        /// <summary>
        ///     Fast Forward ("fa-fast-forward", \uf050) icon.
        /// </summary>
        /// 
        [Display(Name = "Fast Forward", Description = "fa-fast-forward", GroupName = "duotone light regular solid")]
        IconFastForward = '\uf050',
        
        /// <summary>
        ///     Faucet ("fa-faucet", \uf905) icon.
        /// </summary>
        /// 
        [Display(Name = "Faucet", Description = "fa-faucet", GroupName = "duotone light regular solid")]
        IconFaucet = '\uf905',
        
        /// <summary>
        ///     Fax ("fa-fax", \uf1ac) icon.
        /// </summary>
        /// 
        [Display(Name = "Fax", Description = "fa-fax", GroupName = "duotone light regular solid")]
        IconFax = '\uf1ac',
        
        /// <summary>
        ///     Feather ("fa-feather", \uf52d) icon.
        /// </summary>
        /// 
        [Display(Name = "Feather", Description = "fa-feather", GroupName = "duotone light regular solid")]
        IconFeather = '\uf52d',
        
        /// <summary>
        ///     Feather Alt ("fa-feather-alt", \uf56b) icon.
        /// </summary>
        /// 
        [Display(Name = "Feather Alt", Description = "fa-feather-alt", GroupName = "duotone light regular solid")]
        IconFeatherAlt = '\uf56b',
        
        /// <summary>
        ///     Fedex ("fa-fedex", \uf797) icon.
        /// </summary>
        /// 
        [Display(Name = "Fedex", Description = "fa-fedex", GroupName = "brands")]
        IconFedex = '\uf797',
        
        /// <summary>
        ///     Fedora ("fa-fedora", \uf798) icon.
        /// </summary>
        /// 
        [Display(Name = "Fedora", Description = "fa-fedora", GroupName = "brands")]
        IconFedora = '\uf798',
        
        /// <summary>
        ///     Female ("fa-female", \uf182) icon.
        /// </summary>
        /// 
        [Display(Name = "Female", Description = "fa-female", GroupName = "duotone light regular solid")]
        IconFemale = '\uf182',
        
        /// <summary>
        ///     Fighter Jet ("fa-fighter-jet", \uf0fb) icon.
        /// </summary>
        /// 
        [Display(Name = "Fighter Jet", Description = "fa-fighter-jet", GroupName = "duotone light regular solid")]
        IconFighterJet = '\uf0fb',
        
        /// <summary>
        ///     Figma ("fa-figma", \uf799) icon.
        /// </summary>
        /// 
        [Display(Name = "Figma", Description = "fa-figma", GroupName = "brands")]
        IconFigma = '\uf799',
        
        /// <summary>
        ///     File ("fa-file", \uf15b) icon.
        /// </summary>
        /// 
        [Display(Name = "File", Description = "fa-file", GroupName = "duotone light regular solid")]
        IconFile = '\uf15b',
        
        /// <summary>
        ///     File Alt ("fa-file-alt", \uf15c) icon.
        /// </summary>
        /// 
        [Display(Name = "File Alt", Description = "fa-file-alt", GroupName = "duotone light regular solid")]
        IconFileAlt = '\uf15c',
        
        /// <summary>
        ///     File Archive ("fa-file-archive", \uf1c6) icon.
        /// </summary>
        /// 
        [Display(Name = "File Archive", Description = "fa-file-archive", GroupName = "duotone light regular solid")]
        IconFileArchive = '\uf1c6',
        
        /// <summary>
        ///     File Audio ("fa-file-audio", \uf1c7) icon.
        /// </summary>
        /// 
        [Display(Name = "File Audio", Description = "fa-file-audio", GroupName = "duotone light regular solid")]
        IconFileAudio = '\uf1c7',
        
        /// <summary>
        ///     File Code ("fa-file-code", \uf1c9) icon.
        /// </summary>
        /// 
        [Display(Name = "File Code", Description = "fa-file-code", GroupName = "duotone light regular solid")]
        IconFileCode = '\uf1c9',
        
        /// <summary>
        ///     File Contract ("fa-file-contract", \uf56c) icon.
        /// </summary>
        /// 
        [Display(Name = "File Contract", Description = "fa-file-contract", GroupName = "duotone light regular solid")]
        IconFileContract = '\uf56c',
        
        /// <summary>
        ///     File Csv ("fa-file-csv", \uf6dd) icon.
        /// </summary>
        /// 
        [Display(Name = "File Csv", Description = "fa-file-csv", GroupName = "duotone light regular solid")]
        IconFileCsv = '\uf6dd',
        
        /// <summary>
        ///     File Download ("fa-file-download", \uf56d) icon.
        /// </summary>
        /// 
        [Display(Name = "File Download", Description = "fa-file-download", GroupName = "duotone light regular solid")]
        IconFileDownload = '\uf56d',
        
        /// <summary>
        ///     File Excel ("fa-file-excel", \uf1c3) icon.
        /// </summary>
        /// 
        [Display(Name = "File Excel", Description = "fa-file-excel", GroupName = "duotone light regular solid")]
        IconFileExcel = '\uf1c3',
        
        /// <summary>
        ///     File Export ("fa-file-export", \uf56e) icon.
        /// </summary>
        /// 
        [Display(Name = "File Export", Description = "fa-file-export", GroupName = "duotone light regular solid")]
        IconFileExport = '\uf56e',
        
        /// <summary>
        ///     File Image ("fa-file-image", \uf1c5) icon.
        /// </summary>
        /// 
        [Display(Name = "File Image", Description = "fa-file-image", GroupName = "duotone light regular solid")]
        IconFileImage = '\uf1c5',
        
        /// <summary>
        ///     File Import ("fa-file-import", \uf56f) icon.
        /// </summary>
        /// 
        [Display(Name = "File Import", Description = "fa-file-import", GroupName = "duotone light regular solid")]
        IconFileImport = '\uf56f',
        
        /// <summary>
        ///     File Invoice ("fa-file-invoice", \uf570) icon.
        /// </summary>
        /// 
        [Display(Name = "File Invoice", Description = "fa-file-invoice", GroupName = "duotone light regular solid")]
        IconFileInvoice = '\uf570',
        
        /// <summary>
        ///     File Invoice Dollar ("fa-file-invoice-dollar", \uf571) icon.
        /// </summary>
        /// 
        [Display(Name = "File Invoice Dollar", Description = "fa-file-invoice-dollar", GroupName = "duotone light regular solid")]
        IconFileInvoiceDollar = '\uf571',
        
        /// <summary>
        ///     File Medical ("fa-file-medical", \uf477) icon.
        /// </summary>
        /// 
        [Display(Name = "File Medical", Description = "fa-file-medical", GroupName = "duotone light regular solid")]
        IconFileMedical = '\uf477',
        
        /// <summary>
        ///     File Medical Alt ("fa-file-medical-alt", \uf478) icon.
        /// </summary>
        /// 
        [Display(Name = "File Medical Alt", Description = "fa-file-medical-alt", GroupName = "duotone light regular solid")]
        IconFileMedicalAlt = '\uf478',
        
        /// <summary>
        ///     File Pdf ("fa-file-pdf", \uf1c1) icon.
        /// </summary>
        /// 
        [Display(Name = "File Pdf", Description = "fa-file-pdf", GroupName = "duotone light regular solid")]
        IconFilePdf = '\uf1c1',
        
        /// <summary>
        ///     File Powerpoint ("fa-file-powerpoint", \uf1c4) icon.
        /// </summary>
        /// 
        [Display(Name = "File Powerpoint", Description = "fa-file-powerpoint", GroupName = "duotone light regular solid")]
        IconFilePowerpoint = '\uf1c4',
        
        /// <summary>
        ///     File Prescription ("fa-file-prescription", \uf572) icon.
        /// </summary>
        /// 
        [Display(Name = "File Prescription", Description = "fa-file-prescription", GroupName = "duotone light regular solid")]
        IconFilePrescription = '\uf572',
        
        /// <summary>
        ///     File Signature ("fa-file-signature", \uf573) icon.
        /// </summary>
        /// 
        [Display(Name = "File Signature", Description = "fa-file-signature", GroupName = "duotone light regular solid")]
        IconFileSignature = '\uf573',
        
        /// <summary>
        ///     File Upload ("fa-file-upload", \uf574) icon.
        /// </summary>
        /// 
        [Display(Name = "File Upload", Description = "fa-file-upload", GroupName = "duotone light regular solid")]
        IconFileUpload = '\uf574',
        
        /// <summary>
        ///     File Video ("fa-file-video", \uf1c8) icon.
        /// </summary>
        /// 
        [Display(Name = "File Video", Description = "fa-file-video", GroupName = "duotone light regular solid")]
        IconFileVideo = '\uf1c8',
        
        /// <summary>
        ///     File Word ("fa-file-word", \uf1c2) icon.
        /// </summary>
        /// 
        [Display(Name = "File Word", Description = "fa-file-word", GroupName = "duotone light regular solid")]
        IconFileWord = '\uf1c2',
        
        /// <summary>
        ///     Fill ("fa-fill", \uf575) icon.
        /// </summary>
        /// 
        [Display(Name = "Fill", Description = "fa-fill", GroupName = "duotone light regular solid")]
        IconFill = '\uf575',
        
        /// <summary>
        ///     Fill Drip ("fa-fill-drip", \uf576) icon.
        /// </summary>
        /// 
        [Display(Name = "Fill Drip", Description = "fa-fill-drip", GroupName = "duotone light regular solid")]
        IconFillDrip = '\uf576',
        
        /// <summary>
        ///     Film ("fa-film", \uf008) icon.
        /// </summary>
        /// 
        [Display(Name = "Film", Description = "fa-film", GroupName = "duotone light regular solid")]
        IconFilm = '\uf008',
        
        /// <summary>
        ///     Filter ("fa-filter", \uf0b0) icon.
        /// </summary>
        /// 
        [Display(Name = "Filter", Description = "fa-filter", GroupName = "duotone light regular solid")]
        IconFilter = '\uf0b0',
        
        /// <summary>
        ///     Fingerprint ("fa-fingerprint", \uf577) icon.
        /// </summary>
        /// 
        [Display(Name = "Fingerprint", Description = "fa-fingerprint", GroupName = "duotone light regular solid")]
        IconFingerprint = '\uf577',
        
        /// <summary>
        ///     Fire ("fa-fire", \uf06d) icon.
        /// </summary>
        /// 
        [Display(Name = "Fire", Description = "fa-fire", GroupName = "duotone light regular solid")]
        IconFire = '\uf06d',
        
        /// <summary>
        ///     Fire Alt ("fa-fire-alt", \uf7e4) icon.
        /// </summary>
        /// 
        [Display(Name = "Fire Alt", Description = "fa-fire-alt", GroupName = "duotone light regular solid")]
        IconFireAlt = '\uf7e4',
        
        /// <summary>
        ///     Fire Extinguisher ("fa-fire-extinguisher", \uf134) icon.
        /// </summary>
        /// 
        [Display(Name = "Fire Extinguisher", Description = "fa-fire-extinguisher", GroupName = "duotone light regular solid")]
        IconFireExtinguisher = '\uf134',
        
        /// <summary>
        ///     Firefox ("fa-firefox", \uf269) icon.
        /// </summary>
        /// 
        [Display(Name = "Firefox", Description = "fa-firefox", GroupName = "brands")]
        IconFirefox = '\uf269',
        
        /// <summary>
        ///     Firefox Browser ("fa-firefox-browser", \uf907) icon.
        /// </summary>
        /// 
        [Display(Name = "Firefox Browser", Description = "fa-firefox-browser", GroupName = "brands")]
        IconFirefoxBrowser = '\uf907',
        
        /// <summary>
        ///     First Aid ("fa-first-aid", \uf479) icon.
        /// </summary>
        /// 
        [Display(Name = "First Aid", Description = "fa-first-aid", GroupName = "duotone light regular solid")]
        IconFirstAid = '\uf479',
        
        /// <summary>
        ///     Firstdraft ("fa-firstdraft", \uf3a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Firstdraft", Description = "fa-firstdraft", GroupName = "brands")]
        IconFirstdraft = '\uf3a1',
        
        /// <summary>
        ///     First Order ("fa-first-order", \uf2b0) icon.
        /// </summary>
        /// 
        [Display(Name = "First Order", Description = "fa-first-order", GroupName = "brands")]
        IconFirstOrder = '\uf2b0',
        
        /// <summary>
        ///     First Order Alt ("fa-first-order-alt", \uf50a) icon.
        /// </summary>
        /// 
        [Display(Name = "First Order Alt", Description = "fa-first-order-alt", GroupName = "brands")]
        IconFirstOrderAlt = '\uf50a',
        
        /// <summary>
        ///     Fish ("fa-fish", \uf578) icon.
        /// </summary>
        /// 
        [Display(Name = "Fish", Description = "fa-fish", GroupName = "duotone light regular solid")]
        IconFish = '\uf578',
        
        /// <summary>
        ///     Fist Raised ("fa-fist-raised", \uf6de) icon.
        /// </summary>
        /// 
        [Display(Name = "Fist Raised", Description = "fa-fist-raised", GroupName = "duotone light regular solid")]
        IconFistRaised = '\uf6de',
        
        /// <summary>
        ///     Flag ("fa-flag", \uf024) icon.
        /// </summary>
        /// 
        [Display(Name = "Flag", Description = "fa-flag", GroupName = "duotone light regular solid")]
        IconFlag = '\uf024',
        
        /// <summary>
        ///     Flag Checkered ("fa-flag-checkered", \uf11e) icon.
        /// </summary>
        /// 
        [Display(Name = "Flag Checkered", Description = "fa-flag-checkered", GroupName = "duotone light regular solid")]
        IconFlagCheckered = '\uf11e',
        
        /// <summary>
        ///     Flag Usa ("fa-flag-usa", \uf74d) icon.
        /// </summary>
        /// 
        [Display(Name = "Flag Usa", Description = "fa-flag-usa", GroupName = "duotone light regular solid")]
        IconFlagUsa = '\uf74d',
        
        /// <summary>
        ///     Flask ("fa-flask", \uf0c3) icon.
        /// </summary>
        /// 
        [Display(Name = "Flask", Description = "fa-flask", GroupName = "duotone light regular solid")]
        IconFlask = '\uf0c3',
        
        /// <summary>
        ///     Flickr ("fa-flickr", \uf16e) icon.
        /// </summary>
        /// 
        [Display(Name = "Flickr", Description = "fa-flickr", GroupName = "brands")]
        IconFlickr = '\uf16e',
        
        /// <summary>
        ///     Flipboard ("fa-flipboard", \uf44d) icon.
        /// </summary>
        /// 
        [Display(Name = "Flipboard", Description = "fa-flipboard", GroupName = "brands")]
        IconFlipboard = '\uf44d',
        
        /// <summary>
        ///     Flushed ("fa-flushed", \uf579) icon.
        /// </summary>
        /// 
        [Display(Name = "Flushed", Description = "fa-flushed", GroupName = "duotone light regular solid")]
        IconFlushed = '\uf579',
        
        /// <summary>
        ///     Fly ("fa-fly", \uf417) icon.
        /// </summary>
        /// 
        [Display(Name = "Fly", Description = "fa-fly", GroupName = "brands")]
        IconFly = '\uf417',
        
        /// <summary>
        ///     Folder ("fa-folder", \uf07b) icon.
        /// </summary>
        /// 
        [Display(Name = "Folder", Description = "fa-folder", GroupName = "duotone light regular solid")]
        IconFolder = '\uf07b',
        
        /// <summary>
        ///     Folder Minus ("fa-folder-minus", \uf65d) icon.
        /// </summary>
        /// 
        [Display(Name = "Folder Minus", Description = "fa-folder-minus", GroupName = "duotone light regular solid")]
        IconFolderMinus = '\uf65d',
        
        /// <summary>
        ///     Folder Open ("fa-folder-open", \uf07c) icon.
        /// </summary>
        /// 
        [Display(Name = "Folder Open", Description = "fa-folder-open", GroupName = "duotone light regular solid")]
        IconFolderOpen = '\uf07c',
        
        /// <summary>
        ///     Folder Plus ("fa-folder-plus", \uf65e) icon.
        /// </summary>
        /// 
        [Display(Name = "Folder Plus", Description = "fa-folder-plus", GroupName = "duotone light regular solid")]
        IconFolderPlus = '\uf65e',
        
        /// <summary>
        ///     Font ("fa-font", \uf031) icon.
        /// </summary>
        /// 
        [Display(Name = "Font", Description = "fa-font", GroupName = "duotone light regular solid")]
        IconFont = '\uf031',
        
        /// <summary>
        ///     Font Awesome ("fa-font-awesome", \uf2b4) icon.
        /// </summary>
        /// 
        [Display(Name = "Font Awesome", Description = "fa-font-awesome", GroupName = "brands")]
        IconFontAwesome = '\uf2b4',
        
        /// <summary>
        ///     Font Awesome Alt ("fa-font-awesome-alt", \uf35c) icon.
        /// </summary>
        /// 
        [Display(Name = "Font Awesome Alt", Description = "fa-font-awesome-alt", GroupName = "brands")]
        IconFontAwesomeAlt = '\uf35c',
        
        /// <summary>
        ///     Font Awesome Flag ("fa-font-awesome-flag", \uf425) icon.
        /// </summary>
        /// 
        [Display(Name = "Font Awesome Flag", Description = "fa-font-awesome-flag", GroupName = "brands")]
        IconFontAwesomeFlag = '\uf425',
        
        /// <summary>
        ///     Font Awesome Logo Full ("fa-font-awesome-logo-full", \uf4e6) icon.
        /// </summary>
        /// 
        [Display(Name = "Font Awesome Logo Full", Description = "fa-font-awesome-logo-full")]
        IconFontAwesomeLogoFull = '\uf4e6',
        
        /// <summary>
        ///     Fonticons ("fa-fonticons", \uf280) icon.
        /// </summary>
        /// 
        [Display(Name = "Fonticons", Description = "fa-fonticons", GroupName = "brands")]
        IconFonticons = '\uf280',
        
        /// <summary>
        ///     Fonticons Fi ("fa-fonticons-fi", \uf3a2) icon.
        /// </summary>
        /// 
        [Display(Name = "Fonticons Fi", Description = "fa-fonticons-fi", GroupName = "brands")]
        IconFonticonsFi = '\uf3a2',
        
        /// <summary>
        ///     Football Ball ("fa-football-ball", \uf44e) icon.
        /// </summary>
        /// 
        [Display(Name = "Football Ball", Description = "fa-football-ball", GroupName = "duotone light regular solid")]
        IconFootballBall = '\uf44e',
        
        /// <summary>
        ///     Fort Awesome ("fa-fort-awesome", \uf286) icon.
        /// </summary>
        /// 
        [Display(Name = "Fort Awesome", Description = "fa-fort-awesome", GroupName = "brands")]
        IconFortAwesome = '\uf286',
        
        /// <summary>
        ///     Fort Awesome Alt ("fa-fort-awesome-alt", \uf3a3) icon.
        /// </summary>
        /// 
        [Display(Name = "Fort Awesome Alt", Description = "fa-fort-awesome-alt", GroupName = "brands")]
        IconFortAwesomeAlt = '\uf3a3',
        
        /// <summary>
        ///     Forumbee ("fa-forumbee", \uf211) icon.
        /// </summary>
        /// 
        [Display(Name = "Forumbee", Description = "fa-forumbee", GroupName = "brands")]
        IconForumbee = '\uf211',
        
        /// <summary>
        ///     Forward ("fa-forward", \uf04e) icon.
        /// </summary>
        /// 
        [Display(Name = "Forward", Description = "fa-forward", GroupName = "duotone light regular solid")]
        IconForward = '\uf04e',
        
        /// <summary>
        ///     Foursquare ("fa-foursquare", \uf180) icon.
        /// </summary>
        /// 
        [Display(Name = "Foursquare", Description = "fa-foursquare", GroupName = "brands")]
        IconFoursquare = '\uf180',
        
        /// <summary>
        ///     Freebsd ("fa-freebsd", \uf3a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Freebsd", Description = "fa-freebsd", GroupName = "brands")]
        IconFreebsd = '\uf3a4',
        
        /// <summary>
        ///     Free Code Camp ("fa-free-code-camp", \uf2c5) icon.
        /// </summary>
        /// 
        [Display(Name = "Free Code Camp", Description = "fa-free-code-camp", GroupName = "brands")]
        IconFreeCodeCamp = '\uf2c5',
        
        /// <summary>
        ///     Frog ("fa-frog", \uf52e) icon.
        /// </summary>
        /// 
        [Display(Name = "Frog", Description = "fa-frog", GroupName = "duotone light regular solid")]
        IconFrog = '\uf52e',
        
        /// <summary>
        ///     Frown ("fa-frown", \uf119) icon.
        /// </summary>
        /// 
        [Display(Name = "Frown", Description = "fa-frown", GroupName = "duotone light regular solid")]
        IconFrown = '\uf119',
        
        /// <summary>
        ///     Frown Open ("fa-frown-open", \uf57a) icon.
        /// </summary>
        /// 
        [Display(Name = "Frown Open", Description = "fa-frown-open", GroupName = "duotone light regular solid")]
        IconFrownOpen = '\uf57a',
        
        /// <summary>
        ///     Fulcrum ("fa-fulcrum", \uf50b) icon.
        /// </summary>
        /// 
        [Display(Name = "Fulcrum", Description = "fa-fulcrum", GroupName = "brands")]
        IconFulcrum = '\uf50b',
        
        /// <summary>
        ///     Funnel Dollar ("fa-funnel-dollar", \uf662) icon.
        /// </summary>
        /// 
        [Display(Name = "Funnel Dollar", Description = "fa-funnel-dollar", GroupName = "duotone light regular solid")]
        IconFunnelDollar = '\uf662',
        
        /// <summary>
        ///     Futbol ("fa-futbol", \uf1e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Futbol", Description = "fa-futbol", GroupName = "duotone light regular solid")]
        IconFutbol = '\uf1e3',
        
        /// <summary>
        ///     Galactic Republic ("fa-galactic-republic", \uf50c) icon.
        /// </summary>
        /// 
        [Display(Name = "Galactic Republic", Description = "fa-galactic-republic", GroupName = "brands")]
        IconGalacticRepublic = '\uf50c',
        
        /// <summary>
        ///     Galactic Senate ("fa-galactic-senate", \uf50d) icon.
        /// </summary>
        /// 
        [Display(Name = "Galactic Senate", Description = "fa-galactic-senate", GroupName = "brands")]
        IconGalacticSenate = '\uf50d',
        
        /// <summary>
        ///     Gamepad ("fa-gamepad", \uf11b) icon.
        /// </summary>
        /// 
        [Display(Name = "Gamepad", Description = "fa-gamepad", GroupName = "duotone light regular solid")]
        IconGamepad = '\uf11b',
        
        /// <summary>
        ///     Gas Pump ("fa-gas-pump", \uf52f) icon.
        /// </summary>
        /// 
        [Display(Name = "Gas Pump", Description = "fa-gas-pump", GroupName = "duotone light regular solid")]
        IconGasPump = '\uf52f',
        
        /// <summary>
        ///     Gavel ("fa-gavel", \uf0e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Gavel", Description = "fa-gavel", GroupName = "duotone light regular solid")]
        IconGavel = '\uf0e3',
        
        /// <summary>
        ///     Gem ("fa-gem", \uf3a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Gem", Description = "fa-gem", GroupName = "duotone light regular solid")]
        IconGem = '\uf3a5',
        
        /// <summary>
        ///     Genderless ("fa-genderless", \uf22d) icon.
        /// </summary>
        /// 
        [Display(Name = "Genderless", Description = "fa-genderless", GroupName = "duotone light regular solid")]
        IconGenderless = '\uf22d',
        
        /// <summary>
        ///     Get Pocket ("fa-get-pocket", \uf265) icon.
        /// </summary>
        /// 
        [Display(Name = "Get Pocket", Description = "fa-get-pocket", GroupName = "brands")]
        IconGetPocket = '\uf265',
        
        /// <summary>
        ///     Gg ("fa-gg", \uf260) icon.
        /// </summary>
        /// 
        [Display(Name = "Gg", Description = "fa-gg", GroupName = "brands")]
        IconGg = '\uf260',
        
        /// <summary>
        ///     Gg Circle ("fa-gg-circle", \uf261) icon.
        /// </summary>
        /// 
        [Display(Name = "Gg Circle", Description = "fa-gg-circle", GroupName = "brands")]
        IconGgCircle = '\uf261',
        
        /// <summary>
        ///     Ghost ("fa-ghost", \uf6e2) icon.
        /// </summary>
        /// 
        [Display(Name = "Ghost", Description = "fa-ghost", GroupName = "duotone light regular solid")]
        IconGhost = '\uf6e2',
        
        /// <summary>
        ///     Gift ("fa-gift", \uf06b) icon.
        /// </summary>
        /// 
        [Display(Name = "Gift", Description = "fa-gift", GroupName = "duotone light regular solid")]
        IconGift = '\uf06b',
        
        /// <summary>
        ///     Gifts ("fa-gifts", \uf79c) icon.
        /// </summary>
        /// 
        [Display(Name = "Gifts", Description = "fa-gifts", GroupName = "duotone light regular solid")]
        IconGifts = '\uf79c',
        
        /// <summary>
        ///     Git ("fa-git", \uf1d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Git", Description = "fa-git", GroupName = "brands")]
        IconGit = '\uf1d3',
        
        /// <summary>
        ///     Git Alt ("fa-git-alt", \uf841) icon.
        /// </summary>
        /// 
        [Display(Name = "Git Alt", Description = "fa-git-alt", GroupName = "brands")]
        IconGitAlt = '\uf841',
        
        /// <summary>
        ///     Github ("fa-github", \uf09b) icon.
        /// </summary>
        /// 
        [Display(Name = "Github", Description = "fa-github", GroupName = "brands")]
        IconGithub = '\uf09b',
        
        /// <summary>
        ///     Github Alt ("fa-github-alt", \uf113) icon.
        /// </summary>
        /// 
        [Display(Name = "Github Alt", Description = "fa-github-alt", GroupName = "brands")]
        IconGithubAlt = '\uf113',
        
        /// <summary>
        ///     Github Square ("fa-github-square", \uf092) icon.
        /// </summary>
        /// 
        [Display(Name = "Github Square", Description = "fa-github-square", GroupName = "brands")]
        IconGithubSquare = '\uf092',
        
        /// <summary>
        ///     Gitkraken ("fa-gitkraken", \uf3a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Gitkraken", Description = "fa-gitkraken", GroupName = "brands")]
        IconGitkraken = '\uf3a6',
        
        /// <summary>
        ///     Gitlab ("fa-gitlab", \uf296) icon.
        /// </summary>
        /// 
        [Display(Name = "Gitlab", Description = "fa-gitlab", GroupName = "brands")]
        IconGitlab = '\uf296',
        
        /// <summary>
        ///     Git Square ("fa-git-square", \uf1d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Git Square", Description = "fa-git-square", GroupName = "brands")]
        IconGitSquare = '\uf1d2',
        
        /// <summary>
        ///     Gitter ("fa-gitter", \uf426) icon.
        /// </summary>
        /// 
        [Display(Name = "Gitter", Description = "fa-gitter", GroupName = "brands")]
        IconGitter = '\uf426',
        
        /// <summary>
        ///     Glass Cheers ("fa-glass-cheers", \uf79f) icon.
        /// </summary>
        /// 
        [Display(Name = "Glass Cheers", Description = "fa-glass-cheers", GroupName = "duotone light regular solid")]
        IconGlassCheers = '\uf79f',
        
        /// <summary>
        ///     Glasses ("fa-glasses", \uf530) icon.
        /// </summary>
        /// 
        [Display(Name = "Glasses", Description = "fa-glasses", GroupName = "duotone light regular solid")]
        IconGlasses = '\uf530',
        
        /// <summary>
        ///     Glass Martini ("fa-glass-martini", \uf000) icon.
        /// </summary>
        /// 
        [Display(Name = "Glass Martini", Description = "fa-glass-martini", GroupName = "duotone light regular solid")]
        IconGlassMartini = '\uf000',
        
        /// <summary>
        ///     Glass Martini Alt ("fa-glass-martini-alt", \uf57b) icon.
        /// </summary>
        /// 
        [Display(Name = "Glass Martini Alt", Description = "fa-glass-martini-alt", GroupName = "duotone light regular solid")]
        IconGlassMartiniAlt = '\uf57b',
        
        /// <summary>
        ///     Glass Whiskey ("fa-glass-whiskey", \uf7a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Glass Whiskey", Description = "fa-glass-whiskey", GroupName = "duotone light regular solid")]
        IconGlassWhiskey = '\uf7a0',
        
        /// <summary>
        ///     Glide ("fa-glide", \uf2a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Glide", Description = "fa-glide", GroupName = "brands")]
        IconGlide = '\uf2a5',
        
        /// <summary>
        ///     Glide G ("fa-glide-g", \uf2a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Glide G", Description = "fa-glide-g", GroupName = "brands")]
        IconGlideG = '\uf2a6',
        
        /// <summary>
        ///     Globe ("fa-globe", \uf0ac) icon.
        /// </summary>
        /// 
        [Display(Name = "Globe", Description = "fa-globe", GroupName = "duotone light regular solid")]
        IconGlobe = '\uf0ac',
        
        /// <summary>
        ///     Globe Africa ("fa-globe-africa", \uf57c) icon.
        /// </summary>
        /// 
        [Display(Name = "Globe Africa", Description = "fa-globe-africa", GroupName = "duotone light regular solid")]
        IconGlobeAfrica = '\uf57c',
        
        /// <summary>
        ///     Globe Americas ("fa-globe-americas", \uf57d) icon.
        /// </summary>
        /// 
        [Display(Name = "Globe Americas", Description = "fa-globe-americas", GroupName = "duotone light regular solid")]
        IconGlobeAmericas = '\uf57d',
        
        /// <summary>
        ///     Globe Asia ("fa-globe-asia", \uf57e) icon.
        /// </summary>
        /// 
        [Display(Name = "Globe Asia", Description = "fa-globe-asia", GroupName = "duotone light regular solid")]
        IconGlobeAsia = '\uf57e',
        
        /// <summary>
        ///     Globe Europe ("fa-globe-europe", \uf7a2) icon.
        /// </summary>
        /// 
        [Display(Name = "Globe Europe", Description = "fa-globe-europe", GroupName = "duotone light regular solid")]
        IconGlobeEurope = '\uf7a2',
        
        /// <summary>
        ///     Gofore ("fa-gofore", \uf3a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Gofore", Description = "fa-gofore", GroupName = "brands")]
        IconGofore = '\uf3a7',
        
        /// <summary>
        ///     Golf Ball ("fa-golf-ball", \uf450) icon.
        /// </summary>
        /// 
        [Display(Name = "Golf Ball", Description = "fa-golf-ball", GroupName = "duotone light regular solid")]
        IconGolfBall = '\uf450',
        
        /// <summary>
        ///     Goodreads ("fa-goodreads", \uf3a8) icon.
        /// </summary>
        /// 
        [Display(Name = "Goodreads", Description = "fa-goodreads", GroupName = "brands")]
        IconGoodreads = '\uf3a8',
        
        /// <summary>
        ///     Goodreads G ("fa-goodreads-g", \uf3a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Goodreads G", Description = "fa-goodreads-g", GroupName = "brands")]
        IconGoodreadsG = '\uf3a9',
        
        /// <summary>
        ///     Google ("fa-google", \uf1a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Google", Description = "fa-google", GroupName = "brands")]
        IconGoogle = '\uf1a0',
        
        /// <summary>
        ///     Google Drive ("fa-google-drive", \uf3aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Drive", Description = "fa-google-drive", GroupName = "brands")]
        IconGoogleDrive = '\uf3aa',
        
        /// <summary>
        ///     Google Play ("fa-google-play", \uf3ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Play", Description = "fa-google-play", GroupName = "brands")]
        IconGooglePlay = '\uf3ab',
        
        /// <summary>
        ///     Google Plus ("fa-google-plus", \uf2b3) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Plus", Description = "fa-google-plus", GroupName = "brands")]
        IconGooglePlus = '\uf2b3',
        
        /// <summary>
        ///     Google Plus G ("fa-google-plus-g", \uf0d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Plus G", Description = "fa-google-plus-g", GroupName = "brands")]
        IconGooglePlusG = '\uf0d5',
        
        /// <summary>
        ///     Google Plus Square ("fa-google-plus-square", \uf0d4) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Plus Square", Description = "fa-google-plus-square", GroupName = "brands")]
        IconGooglePlusSquare = '\uf0d4',
        
        /// <summary>
        ///     Google Wallet ("fa-google-wallet", \uf1ee) icon.
        /// </summary>
        /// 
        [Display(Name = "Google Wallet", Description = "fa-google-wallet", GroupName = "brands")]
        IconGoogleWallet = '\uf1ee',
        
        /// <summary>
        ///     Gopuram ("fa-gopuram", \uf664) icon.
        /// </summary>
        /// 
        [Display(Name = "Gopuram", Description = "fa-gopuram", GroupName = "duotone light regular solid")]
        IconGopuram = '\uf664',
        
        /// <summary>
        ///     Graduation Cap ("fa-graduation-cap", \uf19d) icon.
        /// </summary>
        /// 
        [Display(Name = "Graduation Cap", Description = "fa-graduation-cap", GroupName = "duotone light regular solid")]
        IconGraduationCap = '\uf19d',
        
        /// <summary>
        ///     Gratipay ("fa-gratipay", \uf184) icon.
        /// </summary>
        /// 
        [Display(Name = "Gratipay", Description = "fa-gratipay", GroupName = "brands")]
        IconGratipay = '\uf184',
        
        /// <summary>
        ///     Grav ("fa-grav", \uf2d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Grav", Description = "fa-grav", GroupName = "brands")]
        IconGrav = '\uf2d6',
        
        /// <summary>
        ///     Greater Than ("fa-greater-than", \uf531) icon.
        /// </summary>
        /// 
        [Display(Name = "Greater Than", Description = "fa-greater-than", GroupName = "duotone light regular solid")]
        IconGreaterThan = '\uf531',
        
        /// <summary>
        ///     Greater Than Equal ("fa-greater-than-equal", \uf532) icon.
        /// </summary>
        /// 
        [Display(Name = "Greater Than Equal", Description = "fa-greater-than-equal", GroupName = "duotone light regular solid")]
        IconGreaterThanEqual = '\uf532',
        
        /// <summary>
        ///     Grimace ("fa-grimace", \uf57f) icon.
        /// </summary>
        /// 
        [Display(Name = "Grimace", Description = "fa-grimace", GroupName = "duotone light regular solid")]
        IconGrimace = '\uf57f',
        
        /// <summary>
        ///     Grin ("fa-grin", \uf580) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin", Description = "fa-grin", GroupName = "duotone light regular solid")]
        IconGrin = '\uf580',
        
        /// <summary>
        ///     Grin Alt ("fa-grin-alt", \uf581) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Alt", Description = "fa-grin-alt", GroupName = "duotone light regular solid")]
        IconGrinAlt = '\uf581',
        
        /// <summary>
        ///     Grin Beam ("fa-grin-beam", \uf582) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Beam", Description = "fa-grin-beam", GroupName = "duotone light regular solid")]
        IconGrinBeam = '\uf582',
        
        /// <summary>
        ///     Grin Beam Sweat ("fa-grin-beam-sweat", \uf583) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Beam Sweat", Description = "fa-grin-beam-sweat", GroupName = "duotone light regular solid")]
        IconGrinBeamSweat = '\uf583',
        
        /// <summary>
        ///     Grin Hearts ("fa-grin-hearts", \uf584) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Hearts", Description = "fa-grin-hearts", GroupName = "duotone light regular solid")]
        IconGrinHearts = '\uf584',
        
        /// <summary>
        ///     Grin Squint ("fa-grin-squint", \uf585) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Squint", Description = "fa-grin-squint", GroupName = "duotone light regular solid")]
        IconGrinSquint = '\uf585',
        
        /// <summary>
        ///     Grin Squint Tears ("fa-grin-squint-tears", \uf586) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Squint Tears", Description = "fa-grin-squint-tears", GroupName = "duotone light regular solid")]
        IconGrinSquintTears = '\uf586',
        
        /// <summary>
        ///     Grin Stars ("fa-grin-stars", \uf587) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Stars", Description = "fa-grin-stars", GroupName = "duotone light regular solid")]
        IconGrinStars = '\uf587',
        
        /// <summary>
        ///     Grin Tears ("fa-grin-tears", \uf588) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Tears", Description = "fa-grin-tears", GroupName = "duotone light regular solid")]
        IconGrinTears = '\uf588',
        
        /// <summary>
        ///     Grin Tongue ("fa-grin-tongue", \uf589) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Tongue", Description = "fa-grin-tongue", GroupName = "duotone light regular solid")]
        IconGrinTongue = '\uf589',
        
        /// <summary>
        ///     Grin Tongue Squint ("fa-grin-tongue-squint", \uf58a) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Tongue Squint", Description = "fa-grin-tongue-squint", GroupName = "duotone light regular solid")]
        IconGrinTongueSquint = '\uf58a',
        
        /// <summary>
        ///     Grin Tongue Wink ("fa-grin-tongue-wink", \uf58b) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Tongue Wink", Description = "fa-grin-tongue-wink", GroupName = "duotone light regular solid")]
        IconGrinTongueWink = '\uf58b',
        
        /// <summary>
        ///     Grin Wink ("fa-grin-wink", \uf58c) icon.
        /// </summary>
        /// 
        [Display(Name = "Grin Wink", Description = "fa-grin-wink", GroupName = "duotone light regular solid")]
        IconGrinWink = '\uf58c',
        
        /// <summary>
        ///     Gripfire ("fa-gripfire", \uf3ac) icon.
        /// </summary>
        /// 
        [Display(Name = "Gripfire", Description = "fa-gripfire", GroupName = "brands")]
        IconGripfire = '\uf3ac',
        
        /// <summary>
        ///     Grip Horizontal ("fa-grip-horizontal", \uf58d) icon.
        /// </summary>
        /// 
        [Display(Name = "Grip Horizontal", Description = "fa-grip-horizontal", GroupName = "duotone light regular solid")]
        IconGripHorizontal = '\uf58d',
        
        /// <summary>
        ///     Grip Lines ("fa-grip-lines", \uf7a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Grip Lines", Description = "fa-grip-lines", GroupName = "duotone light regular solid")]
        IconGripLines = '\uf7a4',
        
        /// <summary>
        ///     Grip Lines Vertical ("fa-grip-lines-vertical", \uf7a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Grip Lines Vertical", Description = "fa-grip-lines-vertical", GroupName = "duotone light regular solid")]
        IconGripLinesVertical = '\uf7a5',
        
        /// <summary>
        ///     Grip Vertical ("fa-grip-vertical", \uf58e) icon.
        /// </summary>
        /// 
        [Display(Name = "Grip Vertical", Description = "fa-grip-vertical", GroupName = "duotone light regular solid")]
        IconGripVertical = '\uf58e',
        
        /// <summary>
        ///     Grunt ("fa-grunt", \uf3ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Grunt", Description = "fa-grunt", GroupName = "brands")]
        IconGrunt = '\uf3ad',
        
        /// <summary>
        ///     Guitar ("fa-guitar", \uf7a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Guitar", Description = "fa-guitar", GroupName = "duotone light regular solid")]
        IconGuitar = '\uf7a6',
        
        /// <summary>
        ///     Gulp ("fa-gulp", \uf3ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Gulp", Description = "fa-gulp", GroupName = "brands")]
        IconGulp = '\uf3ae',
        
        /// <summary>
        ///     Hacker News ("fa-hacker-news", \uf1d4) icon.
        /// </summary>
        /// 
        [Display(Name = "Hacker News", Description = "fa-hacker-news", GroupName = "brands")]
        IconHackerNews = '\uf1d4',
        
        /// <summary>
        ///     Hacker News Square ("fa-hacker-news-square", \uf3af) icon.
        /// </summary>
        /// 
        [Display(Name = "Hacker News Square", Description = "fa-hacker-news-square", GroupName = "brands")]
        IconHackerNewsSquare = '\uf3af',
        
        /// <summary>
        ///     Hackerrank ("fa-hackerrank", \uf5f7) icon.
        /// </summary>
        /// 
        [Display(Name = "Hackerrank", Description = "fa-hackerrank", GroupName = "brands")]
        IconHackerrank = '\uf5f7',
        
        /// <summary>
        ///     Hamburger ("fa-hamburger", \uf805) icon.
        /// </summary>
        /// 
        [Display(Name = "Hamburger", Description = "fa-hamburger", GroupName = "duotone light regular solid")]
        IconHamburger = '\uf805',
        
        /// <summary>
        ///     Hammer ("fa-hammer", \uf6e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Hammer", Description = "fa-hammer", GroupName = "duotone light regular solid")]
        IconHammer = '\uf6e3',
        
        /// <summary>
        ///     Hamsa ("fa-hamsa", \uf665) icon.
        /// </summary>
        /// 
        [Display(Name = "Hamsa", Description = "fa-hamsa", GroupName = "duotone light regular solid")]
        IconHamsa = '\uf665',
        
        /// <summary>
        ///     Hand Holding ("fa-hand-holding", \uf4bd) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Holding", Description = "fa-hand-holding", GroupName = "duotone light regular solid")]
        IconHandHolding = '\uf4bd',
        
        /// <summary>
        ///     Hand Holding Heart ("fa-hand-holding-heart", \uf4be) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Holding Heart", Description = "fa-hand-holding-heart", GroupName = "duotone light regular solid")]
        IconHandHoldingHeart = '\uf4be',
        
        /// <summary>
        ///     Hand Holding Medical ("fa-hand-holding-medical", \uf95c) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Holding Medical", Description = "fa-hand-holding-medical", GroupName = "duotone light regular solid")]
        IconHandHoldingMedical = '\uf95c',
        
        /// <summary>
        ///     Hand Holding Usd ("fa-hand-holding-usd", \uf4c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Holding Usd", Description = "fa-hand-holding-usd", GroupName = "duotone light regular solid")]
        IconHandHoldingUsd = '\uf4c0',
        
        /// <summary>
        ///     Hand Holding Water ("fa-hand-holding-water", \uf4c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Holding Water", Description = "fa-hand-holding-water", GroupName = "duotone light regular solid")]
        IconHandHoldingWater = '\uf4c1',
        
        /// <summary>
        ///     Hand Lizard ("fa-hand-lizard", \uf258) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Lizard", Description = "fa-hand-lizard", GroupName = "duotone light regular solid")]
        IconHandLizard = '\uf258',
        
        /// <summary>
        ///     Hand Middle Finger ("fa-hand-middle-finger", \uf806) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Middle Finger", Description = "fa-hand-middle-finger", GroupName = "duotone light regular solid")]
        IconHandMiddleFinger = '\uf806',
        
        /// <summary>
        ///     Hand Paper ("fa-hand-paper", \uf256) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Paper", Description = "fa-hand-paper", GroupName = "duotone light regular solid")]
        IconHandPaper = '\uf256',
        
        /// <summary>
        ///     Hand Peace ("fa-hand-peace", \uf25b) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Peace", Description = "fa-hand-peace", GroupName = "duotone light regular solid")]
        IconHandPeace = '\uf25b',
        
        /// <summary>
        ///     Hand Point Down ("fa-hand-point-down", \uf0a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Point Down", Description = "fa-hand-point-down", GroupName = "duotone light regular solid")]
        IconHandPointDown = '\uf0a7',
        
        /// <summary>
        ///     Hand Pointer ("fa-hand-pointer", \uf25a) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Pointer", Description = "fa-hand-pointer", GroupName = "duotone light regular solid")]
        IconHandPointer = '\uf25a',
        
        /// <summary>
        ///     Hand Point Left ("fa-hand-point-left", \uf0a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Point Left", Description = "fa-hand-point-left", GroupName = "duotone light regular solid")]
        IconHandPointLeft = '\uf0a5',
        
        /// <summary>
        ///     Hand Point Right ("fa-hand-point-right", \uf0a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Point Right", Description = "fa-hand-point-right", GroupName = "duotone light regular solid")]
        IconHandPointRight = '\uf0a4',
        
        /// <summary>
        ///     Hand Point Up ("fa-hand-point-up", \uf0a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Point Up", Description = "fa-hand-point-up", GroupName = "duotone light regular solid")]
        IconHandPointUp = '\uf0a6',
        
        /// <summary>
        ///     Hand Rock ("fa-hand-rock", \uf255) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Rock", Description = "fa-hand-rock", GroupName = "duotone light regular solid")]
        IconHandRock = '\uf255',
        
        /// <summary>
        ///     Hands ("fa-hands", \uf4c2) icon.
        /// </summary>
        /// 
        [Display(Name = "Hands", Description = "fa-hands", GroupName = "duotone light regular solid")]
        IconHands = '\uf4c2',
        
        /// <summary>
        ///     Hand Scissors ("fa-hand-scissors", \uf257) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Scissors", Description = "fa-hand-scissors", GroupName = "duotone light regular solid")]
        IconHandScissors = '\uf257',
        
        /// <summary>
        ///     Handshake ("fa-handshake", \uf2b5) icon.
        /// </summary>
        /// 
        [Display(Name = "Handshake", Description = "fa-handshake", GroupName = "duotone light regular solid")]
        IconHandshake = '\uf2b5',
        
        /// <summary>
        ///     Handshake Alt Slash ("fa-handshake-alt-slash", \uf95f) icon.
        /// </summary>
        /// 
        [Display(Name = "Handshake Alt Slash", Description = "fa-handshake-alt-slash", GroupName = "duotone light regular solid")]
        IconHandshakeAltSlash = '\uf95f',
        
        /// <summary>
        ///     Handshake Slash ("fa-handshake-slash", \uf960) icon.
        /// </summary>
        /// 
        [Display(Name = "Handshake Slash", Description = "fa-handshake-slash", GroupName = "duotone light regular solid")]
        IconHandshakeSlash = '\uf960',
        
        /// <summary>
        ///     Hands Helping ("fa-hands-helping", \uf4c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Hands Helping", Description = "fa-hands-helping", GroupName = "duotone light regular solid")]
        IconHandsHelping = '\uf4c4',
        
        /// <summary>
        ///     Hand Sparkles ("fa-hand-sparkles", \uf95d) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Sparkles", Description = "fa-hand-sparkles", GroupName = "duotone light regular solid")]
        IconHandSparkles = '\uf95d',
        
        /// <summary>
        ///     Hand Spock ("fa-hand-spock", \uf259) icon.
        /// </summary>
        /// 
        [Display(Name = "Hand Spock", Description = "fa-hand-spock", GroupName = "duotone light regular solid")]
        IconHandSpock = '\uf259',
        
        /// <summary>
        ///     Hands Wash ("fa-hands-wash", \uf95e) icon.
        /// </summary>
        /// 
        [Display(Name = "Hands Wash", Description = "fa-hands-wash", GroupName = "duotone light regular solid")]
        IconHandsWash = '\uf95e',
        
        /// <summary>
        ///     Hanukiah ("fa-hanukiah", \uf6e6) icon.
        /// </summary>
        /// 
        [Display(Name = "Hanukiah", Description = "fa-hanukiah", GroupName = "duotone light regular solid")]
        IconHanukiah = '\uf6e6',
        
        /// <summary>
        ///     Hard Hat ("fa-hard-hat", \uf807) icon.
        /// </summary>
        /// 
        [Display(Name = "Hard Hat", Description = "fa-hard-hat", GroupName = "duotone light regular solid")]
        IconHardHat = '\uf807',
        
        /// <summary>
        ///     Hashtag ("fa-hashtag", \uf292) icon.
        /// </summary>
        /// 
        [Display(Name = "Hashtag", Description = "fa-hashtag", GroupName = "duotone light regular solid")]
        IconHashtag = '\uf292',
        
        /// <summary>
        ///     Hat Cowboy ("fa-hat-cowboy", \uf8c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Hat Cowboy", Description = "fa-hat-cowboy", GroupName = "duotone light regular solid")]
        IconHatCowboy = '\uf8c0',
        
        /// <summary>
        ///     Hat Cowboy Side ("fa-hat-cowboy-side", \uf8c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Hat Cowboy Side", Description = "fa-hat-cowboy-side", GroupName = "duotone light regular solid")]
        IconHatCowboySide = '\uf8c1',
        
        /// <summary>
        ///     Hat Wizard ("fa-hat-wizard", \uf6e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Hat Wizard", Description = "fa-hat-wizard", GroupName = "duotone light regular solid")]
        IconHatWizard = '\uf6e8',
        
        /// <summary>
        ///     Hdd ("fa-hdd", \uf0a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Hdd", Description = "fa-hdd", GroupName = "duotone light regular solid")]
        IconHdd = '\uf0a0',
        
        /// <summary>
        ///     Heading ("fa-heading", \uf1dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Heading", Description = "fa-heading", GroupName = "duotone light regular solid")]
        IconHeading = '\uf1dc',
        
        /// <summary>
        ///     Headphones ("fa-headphones", \uf025) icon.
        /// </summary>
        /// 
        [Display(Name = "Headphones", Description = "fa-headphones", GroupName = "duotone light regular solid")]
        IconHeadphones = '\uf025',
        
        /// <summary>
        ///     Headphones Alt ("fa-headphones-alt", \uf58f) icon.
        /// </summary>
        /// 
        [Display(Name = "Headphones Alt", Description = "fa-headphones-alt", GroupName = "duotone light regular solid")]
        IconHeadphonesAlt = '\uf58f',
        
        /// <summary>
        ///     Headset ("fa-headset", \uf590) icon.
        /// </summary>
        /// 
        [Display(Name = "Headset", Description = "fa-headset", GroupName = "duotone light regular solid")]
        IconHeadset = '\uf590',
        
        /// <summary>
        ///     Head Side Cough ("fa-head-side-cough", \uf961) icon.
        /// </summary>
        /// 
        [Display(Name = "Head Side Cough", Description = "fa-head-side-cough", GroupName = "duotone light regular solid")]
        IconHeadSideCough = '\uf961',
        
        /// <summary>
        ///     Head Side Cough Slash ("fa-head-side-cough-slash", \uf962) icon.
        /// </summary>
        /// 
        [Display(Name = "Head Side Cough Slash", Description = "fa-head-side-cough-slash", GroupName = "duotone light regular solid")]
        IconHeadSideCoughSlash = '\uf962',
        
        /// <summary>
        ///     Head Side Mask ("fa-head-side-mask", \uf963) icon.
        /// </summary>
        /// 
        [Display(Name = "Head Side Mask", Description = "fa-head-side-mask", GroupName = "duotone light regular solid")]
        IconHeadSideMask = '\uf963',
        
        /// <summary>
        ///     Head Side Virus ("fa-head-side-virus", \uf964) icon.
        /// </summary>
        /// 
        [Display(Name = "Head Side Virus", Description = "fa-head-side-virus", GroupName = "duotone light regular solid")]
        IconHeadSideVirus = '\uf964',
        
        /// <summary>
        ///     Heart ("fa-heart", \uf004) icon.
        /// </summary>
        /// 
        [Display(Name = "Heart", Description = "fa-heart", GroupName = "duotone light regular solid")]
        IconHeart = '\uf004',
        
        /// <summary>
        ///     Heartbeat ("fa-heartbeat", \uf21e) icon.
        /// </summary>
        /// 
        [Display(Name = "Heartbeat", Description = "fa-heartbeat", GroupName = "duotone light regular solid")]
        IconHeartbeat = '\uf21e',
        
        /// <summary>
        ///     Heart Broken ("fa-heart-broken", \uf7a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Heart Broken", Description = "fa-heart-broken", GroupName = "duotone light regular solid")]
        IconHeartBroken = '\uf7a9',
        
        /// <summary>
        ///     Helicopter ("fa-helicopter", \uf533) icon.
        /// </summary>
        /// 
        [Display(Name = "Helicopter", Description = "fa-helicopter", GroupName = "duotone light regular solid")]
        IconHelicopter = '\uf533',
        
        /// <summary>
        ///     Highlighter ("fa-highlighter", \uf591) icon.
        /// </summary>
        /// 
        [Display(Name = "Highlighter", Description = "fa-highlighter", GroupName = "duotone light regular solid")]
        IconHighlighter = '\uf591',
        
        /// <summary>
        ///     Hiking ("fa-hiking", \uf6ec) icon.
        /// </summary>
        /// 
        [Display(Name = "Hiking", Description = "fa-hiking", GroupName = "duotone light regular solid")]
        IconHiking = '\uf6ec',
        
        /// <summary>
        ///     Hippo ("fa-hippo", \uf6ed) icon.
        /// </summary>
        /// 
        [Display(Name = "Hippo", Description = "fa-hippo", GroupName = "duotone light regular solid")]
        IconHippo = '\uf6ed',
        
        /// <summary>
        ///     Hips ("fa-hips", \uf452) icon.
        /// </summary>
        /// 
        [Display(Name = "Hips", Description = "fa-hips", GroupName = "brands")]
        IconHips = '\uf452',
        
        /// <summary>
        ///     Hire A Helper ("fa-hire-a-helper", \uf3b0) icon.
        /// </summary>
        /// 
        [Display(Name = "Hire A Helper", Description = "fa-hire-a-helper", GroupName = "brands")]
        IconHireAHelper = '\uf3b0',
        
        /// <summary>
        ///     History ("fa-history", \uf1da) icon.
        /// </summary>
        /// 
        [Display(Name = "History", Description = "fa-history", GroupName = "duotone light regular solid")]
        IconHistory = '\uf1da',
        
        /// <summary>
        ///     Hockey Puck ("fa-hockey-puck", \uf453) icon.
        /// </summary>
        /// 
        [Display(Name = "Hockey Puck", Description = "fa-hockey-puck", GroupName = "duotone light regular solid")]
        IconHockeyPuck = '\uf453',
        
        /// <summary>
        ///     Holly Berry ("fa-holly-berry", \uf7aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Holly Berry", Description = "fa-holly-berry", GroupName = "duotone light regular solid")]
        IconHollyBerry = '\uf7aa',
        
        /// <summary>
        ///     Home ("fa-home", \uf015) icon.
        /// </summary>
        /// 
        [Display(Name = "Home", Description = "fa-home", GroupName = "duotone light regular solid")]
        IconHome = '\uf015',
        
        /// <summary>
        ///     Hooli ("fa-hooli", \uf427) icon.
        /// </summary>
        /// 
        [Display(Name = "Hooli", Description = "fa-hooli", GroupName = "brands")]
        IconHooli = '\uf427',
        
        /// <summary>
        ///     Hornbill ("fa-hornbill", \uf592) icon.
        /// </summary>
        /// 
        [Display(Name = "Hornbill", Description = "fa-hornbill", GroupName = "brands")]
        IconHornbill = '\uf592',
        
        /// <summary>
        ///     Horse ("fa-horse", \uf6f0) icon.
        /// </summary>
        /// 
        [Display(Name = "Horse", Description = "fa-horse", GroupName = "duotone light regular solid")]
        IconHorse = '\uf6f0',
        
        /// <summary>
        ///     Horse Head ("fa-horse-head", \uf7ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Horse Head", Description = "fa-horse-head", GroupName = "duotone light regular solid")]
        IconHorseHead = '\uf7ab',
        
        /// <summary>
        ///     Hospital ("fa-hospital", \uf0f8) icon.
        /// </summary>
        /// 
        [Display(Name = "Hospital", Description = "fa-hospital", GroupName = "duotone light regular solid")]
        IconHospital = '\uf0f8',
        
        /// <summary>
        ///     Hospital Alt ("fa-hospital-alt", \uf47d) icon.
        /// </summary>
        /// 
        [Display(Name = "Hospital Alt", Description = "fa-hospital-alt", GroupName = "duotone light regular solid")]
        IconHospitalAlt = '\uf47d',
        
        /// <summary>
        ///     Hospital Symbol ("fa-hospital-symbol", \uf47e) icon.
        /// </summary>
        /// 
        [Display(Name = "Hospital Symbol", Description = "fa-hospital-symbol", GroupName = "duotone light regular solid")]
        IconHospitalSymbol = '\uf47e',
        
        /// <summary>
        ///     Hospital User ("fa-hospital-user", \uf80d) icon.
        /// </summary>
        /// 
        [Display(Name = "Hospital User", Description = "fa-hospital-user", GroupName = "duotone light regular solid")]
        IconHospitalUser = '\uf80d',
        
        /// <summary>
        ///     Hotdog ("fa-hotdog", \uf80f) icon.
        /// </summary>
        /// 
        [Display(Name = "Hotdog", Description = "fa-hotdog", GroupName = "duotone light regular solid")]
        IconHotdog = '\uf80f',
        
        /// <summary>
        ///     Hotel ("fa-hotel", \uf594) icon.
        /// </summary>
        /// 
        [Display(Name = "Hotel", Description = "fa-hotel", GroupName = "duotone light regular solid")]
        IconHotel = '\uf594',
        
        /// <summary>
        ///     Hotjar ("fa-hotjar", \uf3b1) icon.
        /// </summary>
        /// 
        [Display(Name = "Hotjar", Description = "fa-hotjar", GroupName = "brands")]
        IconHotjar = '\uf3b1',
        
        /// <summary>
        ///     Hot Tub ("fa-hot-tub", \uf593) icon.
        /// </summary>
        /// 
        [Display(Name = "Hot Tub", Description = "fa-hot-tub", GroupName = "duotone light regular solid")]
        IconHotTub = '\uf593',
        
        /// <summary>
        ///     Hourglass ("fa-hourglass", \uf254) icon.
        /// </summary>
        /// 
        [Display(Name = "Hourglass", Description = "fa-hourglass", GroupName = "duotone light regular solid")]
        IconHourglass = '\uf254',
        
        /// <summary>
        ///     Hourglass End ("fa-hourglass-end", \uf253) icon.
        /// </summary>
        /// 
        [Display(Name = "Hourglass End", Description = "fa-hourglass-end", GroupName = "duotone light regular solid")]
        IconHourglassEnd = '\uf253',
        
        /// <summary>
        ///     Hourglass Half ("fa-hourglass-half", \uf252) icon.
        /// </summary>
        /// 
        [Display(Name = "Hourglass Half", Description = "fa-hourglass-half", GroupName = "duotone light regular solid")]
        IconHourglassHalf = '\uf252',
        
        /// <summary>
        ///     Hourglass Start ("fa-hourglass-start", \uf251) icon.
        /// </summary>
        /// 
        [Display(Name = "Hourglass Start", Description = "fa-hourglass-start", GroupName = "duotone light regular solid")]
        IconHourglassStart = '\uf251',
        
        /// <summary>
        ///     House Damage ("fa-house-damage", \uf6f1) icon.
        /// </summary>
        /// 
        [Display(Name = "House Damage", Description = "fa-house-damage", GroupName = "duotone light regular solid")]
        IconHouseDamage = '\uf6f1',
        
        /// <summary>
        ///     House User ("fa-house-user", \uf965) icon.
        /// </summary>
        /// 
        [Display(Name = "House User", Description = "fa-house-user", GroupName = "duotone light regular solid")]
        IconHouseUser = '\uf965',
        
        /// <summary>
        ///     Houzz ("fa-houzz", \uf27c) icon.
        /// </summary>
        /// 
        [Display(Name = "Houzz", Description = "fa-houzz", GroupName = "brands")]
        IconHouzz = '\uf27c',
        
        /// <summary>
        ///     Hryvnia ("fa-hryvnia", \uf6f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Hryvnia", Description = "fa-hryvnia", GroupName = "duotone light regular solid")]
        IconHryvnia = '\uf6f2',
        
        /// <summary>
        ///     H Square ("fa-h-square", \uf0fd) icon.
        /// </summary>
        /// 
        [Display(Name = "H Square", Description = "fa-h-square", GroupName = "duotone light regular solid")]
        IconHSquare = '\uf0fd',
        
        /// <summary>
        ///     Html5 ("fa-html5", \uf13b) icon.
        /// </summary>
        /// 
        [Display(Name = "Html5", Description = "fa-html5", GroupName = "brands")]
        IconHtml5 = '\uf13b',
        
        /// <summary>
        ///     Hubspot ("fa-hubspot", \uf3b2) icon.
        /// </summary>
        /// 
        [Display(Name = "Hubspot", Description = "fa-hubspot", GroupName = "brands")]
        IconHubspot = '\uf3b2',
        
        /// <summary>
        ///     Ice Cream ("fa-ice-cream", \uf810) icon.
        /// </summary>
        /// 
        [Display(Name = "Ice Cream", Description = "fa-ice-cream", GroupName = "duotone light regular solid")]
        IconIceCream = '\uf810',
        
        /// <summary>
        ///     Icicles ("fa-icicles", \uf7ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Icicles", Description = "fa-icicles", GroupName = "duotone light regular solid")]
        IconIcicles = '\uf7ad',
        
        /// <summary>
        ///     Icons ("fa-icons", \uf86d) icon.
        /// </summary>
        /// 
        [Display(Name = "Icons", Description = "fa-icons", GroupName = "duotone light regular solid")]
        IconIcons = '\uf86d',
        
        /// <summary>
        ///     I Cursor ("fa-i-cursor", \uf246) icon.
        /// </summary>
        /// 
        [Display(Name = "I Cursor", Description = "fa-i-cursor", GroupName = "duotone light regular solid")]
        IconICursor = '\uf246',
        
        /// <summary>
        ///     Id Badge ("fa-id-badge", \uf2c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Id Badge", Description = "fa-id-badge", GroupName = "duotone light regular solid")]
        IconIdBadge = '\uf2c1',
        
        /// <summary>
        ///     Id Card ("fa-id-card", \uf2c2) icon.
        /// </summary>
        /// 
        [Display(Name = "Id Card", Description = "fa-id-card", GroupName = "duotone light regular solid")]
        IconIdCard = '\uf2c2',
        
        /// <summary>
        ///     Id Card Alt ("fa-id-card-alt", \uf47f) icon.
        /// </summary>
        /// 
        [Display(Name = "Id Card Alt", Description = "fa-id-card-alt", GroupName = "duotone light regular solid")]
        IconIdCardAlt = '\uf47f',
        
        /// <summary>
        ///     Ideal ("fa-ideal", \uf913) icon.
        /// </summary>
        /// 
        [Display(Name = "Ideal", Description = "fa-ideal", GroupName = "brands")]
        IconIdeal = '\uf913',
        
        /// <summary>
        ///     Igloo ("fa-igloo", \uf7ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Igloo", Description = "fa-igloo", GroupName = "duotone light regular solid")]
        IconIgloo = '\uf7ae',
        
        /// <summary>
        ///     Image ("fa-image", \uf03e) icon.
        /// </summary>
        /// 
        [Display(Name = "Image", Description = "fa-image", GroupName = "duotone light regular solid")]
        IconImage = '\uf03e',
        
        /// <summary>
        ///     Images ("fa-images", \uf302) icon.
        /// </summary>
        /// 
        [Display(Name = "Images", Description = "fa-images", GroupName = "duotone light regular solid")]
        IconImages = '\uf302',
        
        /// <summary>
        ///     Imdb ("fa-imdb", \uf2d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Imdb", Description = "fa-imdb", GroupName = "brands")]
        IconImdb = '\uf2d8',
        
        /// <summary>
        ///     Inbox ("fa-inbox", \uf01c) icon.
        /// </summary>
        /// 
        [Display(Name = "Inbox", Description = "fa-inbox", GroupName = "duotone light regular solid")]
        IconInbox = '\uf01c',
        
        /// <summary>
        ///     Indent ("fa-indent", \uf03c) icon.
        /// </summary>
        /// 
        [Display(Name = "Indent", Description = "fa-indent", GroupName = "duotone light regular solid")]
        IconIndent = '\uf03c',
        
        /// <summary>
        ///     Industry ("fa-industry", \uf275) icon.
        /// </summary>
        /// 
        [Display(Name = "Industry", Description = "fa-industry", GroupName = "duotone light regular solid")]
        IconIndustry = '\uf275',
        
        /// <summary>
        ///     Infinity ("fa-infinity", \uf534) icon.
        /// </summary>
        /// 
        [Display(Name = "Infinity", Description = "fa-infinity", GroupName = "duotone light regular solid")]
        IconInfinity = '\uf534',
        
        /// <summary>
        ///     Info ("fa-info", \uf129) icon.
        /// </summary>
        /// 
        [Display(Name = "Info", Description = "fa-info", GroupName = "duotone light regular solid")]
        IconInfo = '\uf129',
        
        /// <summary>
        ///     Info Circle ("fa-info-circle", \uf05a) icon.
        /// </summary>
        /// 
        [Display(Name = "Info Circle", Description = "fa-info-circle", GroupName = "duotone light regular solid")]
        IconInfoCircle = '\uf05a',
        
        /// <summary>
        ///     Instagram ("fa-instagram", \uf16d) icon.
        /// </summary>
        /// 
        [Display(Name = "Instagram", Description = "fa-instagram", GroupName = "brands")]
        IconInstagram = '\uf16d',
        
        /// <summary>
        ///     Instagram Square ("fa-instagram-square", \uf955) icon.
        /// </summary>
        /// 
        [Display(Name = "Instagram Square", Description = "fa-instagram-square", GroupName = "brands")]
        IconInstagramSquare = '\uf955',
        
        /// <summary>
        ///     Intercom ("fa-intercom", \uf7af) icon.
        /// </summary>
        /// 
        [Display(Name = "Intercom", Description = "fa-intercom", GroupName = "brands")]
        IconIntercom = '\uf7af',
        
        /// <summary>
        ///     Internet Explorer ("fa-internet-explorer", \uf26b) icon.
        /// </summary>
        /// 
        [Display(Name = "Internet Explorer", Description = "fa-internet-explorer", GroupName = "brands")]
        IconInternetExplorer = '\uf26b',
        
        /// <summary>
        ///     Invision ("fa-invision", \uf7b0) icon.
        /// </summary>
        /// 
        [Display(Name = "Invision", Description = "fa-invision", GroupName = "brands")]
        IconInvision = '\uf7b0',
        
        /// <summary>
        ///     Ioxhost ("fa-ioxhost", \uf208) icon.
        /// </summary>
        /// 
        [Display(Name = "Ioxhost", Description = "fa-ioxhost", GroupName = "brands")]
        IconIoxhost = '\uf208',
        
        /// <summary>
        ///     Italic ("fa-italic", \uf033) icon.
        /// </summary>
        /// 
        [Display(Name = "Italic", Description = "fa-italic", GroupName = "duotone light regular solid")]
        IconItalic = '\uf033',
        
        /// <summary>
        ///     Itch Io ("fa-itch-io", \uf83a) icon.
        /// </summary>
        /// 
        [Display(Name = "Itch Io", Description = "fa-itch-io", GroupName = "brands")]
        IconItchIo = '\uf83a',
        
        /// <summary>
        ///     Itunes ("fa-itunes", \uf3b4) icon.
        /// </summary>
        /// 
        [Display(Name = "Itunes", Description = "fa-itunes", GroupName = "brands")]
        IconItunes = '\uf3b4',
        
        /// <summary>
        ///     Itunes Note ("fa-itunes-note", \uf3b5) icon.
        /// </summary>
        /// 
        [Display(Name = "Itunes Note", Description = "fa-itunes-note", GroupName = "brands")]
        IconItunesNote = '\uf3b5',
        
        /// <summary>
        ///     Java ("fa-java", \uf4e4) icon.
        /// </summary>
        /// 
        [Display(Name = "Java", Description = "fa-java", GroupName = "brands")]
        IconJava = '\uf4e4',
        
        /// <summary>
        ///     Jedi ("fa-jedi", \uf669) icon.
        /// </summary>
        /// 
        [Display(Name = "Jedi", Description = "fa-jedi", GroupName = "duotone light regular solid")]
        IconJedi = '\uf669',
        
        /// <summary>
        ///     Jedi Order ("fa-jedi-order", \uf50e) icon.
        /// </summary>
        /// 
        [Display(Name = "Jedi Order", Description = "fa-jedi-order", GroupName = "brands")]
        IconJediOrder = '\uf50e',
        
        /// <summary>
        ///     Jenkins ("fa-jenkins", \uf3b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Jenkins", Description = "fa-jenkins", GroupName = "brands")]
        IconJenkins = '\uf3b6',
        
        /// <summary>
        ///     Jira ("fa-jira", \uf7b1) icon.
        /// </summary>
        /// 
        [Display(Name = "Jira", Description = "fa-jira", GroupName = "brands")]
        IconJira = '\uf7b1',
        
        /// <summary>
        ///     Joget ("fa-joget", \uf3b7) icon.
        /// </summary>
        /// 
        [Display(Name = "Joget", Description = "fa-joget", GroupName = "brands")]
        IconJoget = '\uf3b7',
        
        /// <summary>
        ///     Joint ("fa-joint", \uf595) icon.
        /// </summary>
        /// 
        [Display(Name = "Joint", Description = "fa-joint", GroupName = "duotone light regular solid")]
        IconJoint = '\uf595',
        
        /// <summary>
        ///     Joomla ("fa-joomla", \uf1aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Joomla", Description = "fa-joomla", GroupName = "brands")]
        IconJoomla = '\uf1aa',
        
        /// <summary>
        ///     Journal Whills ("fa-journal-whills", \uf66a) icon.
        /// </summary>
        /// 
        [Display(Name = "Journal Whills", Description = "fa-journal-whills", GroupName = "duotone light regular solid")]
        IconJournalWhills = '\uf66a',
        
        /// <summary>
        ///     Js ("fa-js", \uf3b8) icon.
        /// </summary>
        /// 
        [Display(Name = "Js", Description = "fa-js", GroupName = "brands")]
        IconJs = '\uf3b8',
        
        /// <summary>
        ///     Jsfiddle ("fa-jsfiddle", \uf1cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Jsfiddle", Description = "fa-jsfiddle", GroupName = "brands")]
        IconJsfiddle = '\uf1cc',
        
        /// <summary>
        ///     Js Square ("fa-js-square", \uf3b9) icon.
        /// </summary>
        /// 
        [Display(Name = "Js Square", Description = "fa-js-square", GroupName = "brands")]
        IconJsSquare = '\uf3b9',
        
        /// <summary>
        ///     Kaaba ("fa-kaaba", \uf66b) icon.
        /// </summary>
        /// 
        [Display(Name = "Kaaba", Description = "fa-kaaba", GroupName = "duotone light regular solid")]
        IconKaaba = '\uf66b',
        
        /// <summary>
        ///     Kaggle ("fa-kaggle", \uf5fa) icon.
        /// </summary>
        /// 
        [Display(Name = "Kaggle", Description = "fa-kaggle", GroupName = "brands")]
        IconKaggle = '\uf5fa',
        
        /// <summary>
        ///     Key ("fa-key", \uf084) icon.
        /// </summary>
        /// 
        [Display(Name = "Key", Description = "fa-key", GroupName = "duotone light regular solid")]
        IconKey = '\uf084',
        
        /// <summary>
        ///     Keybase ("fa-keybase", \uf4f5) icon.
        /// </summary>
        /// 
        [Display(Name = "Keybase", Description = "fa-keybase", GroupName = "brands")]
        IconKeybase = '\uf4f5',
        
        /// <summary>
        ///     Keyboard ("fa-keyboard", \uf11c) icon.
        /// </summary>
        /// 
        [Display(Name = "Keyboard", Description = "fa-keyboard", GroupName = "duotone light regular solid")]
        IconKeyboard = '\uf11c',
        
        /// <summary>
        ///     Keycdn ("fa-keycdn", \uf3ba) icon.
        /// </summary>
        /// 
        [Display(Name = "Keycdn", Description = "fa-keycdn", GroupName = "brands")]
        IconKeycdn = '\uf3ba',
        
        /// <summary>
        ///     Khanda ("fa-khanda", \uf66d) icon.
        /// </summary>
        /// 
        [Display(Name = "Khanda", Description = "fa-khanda", GroupName = "duotone light regular solid")]
        IconKhanda = '\uf66d',
        
        /// <summary>
        ///     Kickstarter ("fa-kickstarter", \uf3bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Kickstarter", Description = "fa-kickstarter", GroupName = "brands")]
        IconKickstarter = '\uf3bb',
        
        /// <summary>
        ///     Kickstarter K ("fa-kickstarter-k", \uf3bc) icon.
        /// </summary>
        /// 
        [Display(Name = "Kickstarter K", Description = "fa-kickstarter-k", GroupName = "brands")]
        IconKickstarterK = '\uf3bc',
        
        /// <summary>
        ///     Kiss ("fa-kiss", \uf596) icon.
        /// </summary>
        /// 
        [Display(Name = "Kiss", Description = "fa-kiss", GroupName = "duotone light regular solid")]
        IconKiss = '\uf596',
        
        /// <summary>
        ///     Kiss Beam ("fa-kiss-beam", \uf597) icon.
        /// </summary>
        /// 
        [Display(Name = "Kiss Beam", Description = "fa-kiss-beam", GroupName = "duotone light regular solid")]
        IconKissBeam = '\uf597',
        
        /// <summary>
        ///     Kiss Wink Heart ("fa-kiss-wink-heart", \uf598) icon.
        /// </summary>
        /// 
        [Display(Name = "Kiss Wink Heart", Description = "fa-kiss-wink-heart", GroupName = "duotone light regular solid")]
        IconKissWinkHeart = '\uf598',
        
        /// <summary>
        ///     Kiwi Bird ("fa-kiwi-bird", \uf535) icon.
        /// </summary>
        /// 
        [Display(Name = "Kiwi Bird", Description = "fa-kiwi-bird", GroupName = "duotone light regular solid")]
        IconKiwiBird = '\uf535',
        
        /// <summary>
        ///     Korvue ("fa-korvue", \uf42f) icon.
        /// </summary>
        /// 
        [Display(Name = "Korvue", Description = "fa-korvue", GroupName = "brands")]
        IconKorvue = '\uf42f',
        
        /// <summary>
        ///     Landmark ("fa-landmark", \uf66f) icon.
        /// </summary>
        /// 
        [Display(Name = "Landmark", Description = "fa-landmark", GroupName = "duotone light regular solid")]
        IconLandmark = '\uf66f',
        
        /// <summary>
        ///     Language ("fa-language", \uf1ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Language", Description = "fa-language", GroupName = "duotone light regular solid")]
        IconLanguage = '\uf1ab',
        
        /// <summary>
        ///     Laptop ("fa-laptop", \uf109) icon.
        /// </summary>
        /// 
        [Display(Name = "Laptop", Description = "fa-laptop", GroupName = "duotone light regular solid")]
        IconLaptop = '\uf109',
        
        /// <summary>
        ///     Laptop Code ("fa-laptop-code", \uf5fc) icon.
        /// </summary>
        /// 
        [Display(Name = "Laptop Code", Description = "fa-laptop-code", GroupName = "duotone light regular solid")]
        IconLaptopCode = '\uf5fc',
        
        /// <summary>
        ///     Laptop House ("fa-laptop-house", \uf966) icon.
        /// </summary>
        /// 
        [Display(Name = "Laptop House", Description = "fa-laptop-house", GroupName = "duotone light regular solid")]
        IconLaptopHouse = '\uf966',
        
        /// <summary>
        ///     Laptop Medical ("fa-laptop-medical", \uf812) icon.
        /// </summary>
        /// 
        [Display(Name = "Laptop Medical", Description = "fa-laptop-medical", GroupName = "duotone light regular solid")]
        IconLaptopMedical = '\uf812',
        
        /// <summary>
        ///     Laravel ("fa-laravel", \uf3bd) icon.
        /// </summary>
        /// 
        [Display(Name = "Laravel", Description = "fa-laravel", GroupName = "brands")]
        IconLaravel = '\uf3bd',
        
        /// <summary>
        ///     Lastfm ("fa-lastfm", \uf202) icon.
        /// </summary>
        /// 
        [Display(Name = "Lastfm", Description = "fa-lastfm", GroupName = "brands")]
        IconLastfm = '\uf202',
        
        /// <summary>
        ///     Lastfm Square ("fa-lastfm-square", \uf203) icon.
        /// </summary>
        /// 
        [Display(Name = "Lastfm Square", Description = "fa-lastfm-square", GroupName = "brands")]
        IconLastfmSquare = '\uf203',
        
        /// <summary>
        ///     Laugh ("fa-laugh", \uf599) icon.
        /// </summary>
        /// 
        [Display(Name = "Laugh", Description = "fa-laugh", GroupName = "duotone light regular solid")]
        IconLaugh = '\uf599',
        
        /// <summary>
        ///     Laugh Beam ("fa-laugh-beam", \uf59a) icon.
        /// </summary>
        /// 
        [Display(Name = "Laugh Beam", Description = "fa-laugh-beam", GroupName = "duotone light regular solid")]
        IconLaughBeam = '\uf59a',
        
        /// <summary>
        ///     Laugh Squint ("fa-laugh-squint", \uf59b) icon.
        /// </summary>
        /// 
        [Display(Name = "Laugh Squint", Description = "fa-laugh-squint", GroupName = "duotone light regular solid")]
        IconLaughSquint = '\uf59b',
        
        /// <summary>
        ///     Laugh Wink ("fa-laugh-wink", \uf59c) icon.
        /// </summary>
        /// 
        [Display(Name = "Laugh Wink", Description = "fa-laugh-wink", GroupName = "duotone light regular solid")]
        IconLaughWink = '\uf59c',
        
        /// <summary>
        ///     Layer Group ("fa-layer-group", \uf5fd) icon.
        /// </summary>
        /// 
        [Display(Name = "Layer Group", Description = "fa-layer-group", GroupName = "duotone light regular solid")]
        IconLayerGroup = '\uf5fd',
        
        /// <summary>
        ///     Leaf ("fa-leaf", \uf06c) icon.
        /// </summary>
        /// 
        [Display(Name = "Leaf", Description = "fa-leaf", GroupName = "duotone light regular solid")]
        IconLeaf = '\uf06c',
        
        /// <summary>
        ///     Leanpub ("fa-leanpub", \uf212) icon.
        /// </summary>
        /// 
        [Display(Name = "Leanpub", Description = "fa-leanpub", GroupName = "brands")]
        IconLeanpub = '\uf212',
        
        /// <summary>
        ///     Lemon ("fa-lemon", \uf094) icon.
        /// </summary>
        /// 
        [Display(Name = "Lemon", Description = "fa-lemon", GroupName = "duotone light regular solid")]
        IconLemon = '\uf094',
        
        /// <summary>
        ///     Less ("fa-less", \uf41d) icon.
        /// </summary>
        /// 
        [Display(Name = "Less", Description = "fa-less", GroupName = "brands")]
        IconLess = '\uf41d',
        
        /// <summary>
        ///     Less Than ("fa-less-than", \uf536) icon.
        /// </summary>
        /// 
        [Display(Name = "Less Than", Description = "fa-less-than", GroupName = "duotone light regular solid")]
        IconLessThan = '\uf536',
        
        /// <summary>
        ///     Less Than Equal ("fa-less-than-equal", \uf537) icon.
        /// </summary>
        /// 
        [Display(Name = "Less Than Equal", Description = "fa-less-than-equal", GroupName = "duotone light regular solid")]
        IconLessThanEqual = '\uf537',
        
        /// <summary>
        ///     Level Down Alt ("fa-level-down-alt", \uf3be) icon.
        /// </summary>
        /// 
        [Display(Name = "Level Down Alt", Description = "fa-level-down-alt", GroupName = "duotone light regular solid")]
        IconLevelDownAlt = '\uf3be',
        
        /// <summary>
        ///     Level Up Alt ("fa-level-up-alt", \uf3bf) icon.
        /// </summary>
        /// 
        [Display(Name = "Level Up Alt", Description = "fa-level-up-alt", GroupName = "duotone light regular solid")]
        IconLevelUpAlt = '\uf3bf',
        
        /// <summary>
        ///     Life Ring ("fa-life-ring", \uf1cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Life Ring", Description = "fa-life-ring", GroupName = "duotone light regular solid")]
        IconLifeRing = '\uf1cd',
        
        /// <summary>
        ///     Lightbulb ("fa-lightbulb", \uf0eb) icon.
        /// </summary>
        /// 
        [Display(Name = "Lightbulb", Description = "fa-lightbulb", GroupName = "duotone light regular solid")]
        IconLightbulb = '\uf0eb',
        
        /// <summary>
        ///     Line ("fa-line", \uf3c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Line", Description = "fa-line", GroupName = "brands")]
        IconLine = '\uf3c0',
        
        /// <summary>
        ///     Link ("fa-link", \uf0c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Link", Description = "fa-link", GroupName = "duotone light regular solid")]
        IconLink = '\uf0c1',
        
        /// <summary>
        ///     Linkedin ("fa-linkedin", \uf08c) icon.
        /// </summary>
        /// 
        [Display(Name = "Linkedin", Description = "fa-linkedin", GroupName = "brands")]
        IconLinkedin = '\uf08c',
        
        /// <summary>
        ///     Linkedin In ("fa-linkedin-in", \uf0e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Linkedin In", Description = "fa-linkedin-in", GroupName = "brands")]
        IconLinkedinIn = '\uf0e1',
        
        /// <summary>
        ///     Linode ("fa-linode", \uf2b8) icon.
        /// </summary>
        /// 
        [Display(Name = "Linode", Description = "fa-linode", GroupName = "brands")]
        IconLinode = '\uf2b8',
        
        /// <summary>
        ///     Linux ("fa-linux", \uf17c) icon.
        /// </summary>
        /// 
        [Display(Name = "Linux", Description = "fa-linux", GroupName = "brands")]
        IconLinux = '\uf17c',
        
        /// <summary>
        ///     Lira Sign ("fa-lira-sign", \uf195) icon.
        /// </summary>
        /// 
        [Display(Name = "Lira Sign", Description = "fa-lira-sign", GroupName = "duotone light regular solid")]
        IconLiraSign = '\uf195',
        
        /// <summary>
        ///     List ("fa-list", \uf03a) icon.
        /// </summary>
        /// 
        [Display(Name = "List", Description = "fa-list", GroupName = "duotone light regular solid")]
        IconList = '\uf03a',
        
        /// <summary>
        ///     List Alt ("fa-list-alt", \uf022) icon.
        /// </summary>
        /// 
        [Display(Name = "List Alt", Description = "fa-list-alt", GroupName = "duotone light regular solid")]
        IconListAlt = '\uf022',
        
        /// <summary>
        ///     List Ol ("fa-list-ol", \uf0cb) icon.
        /// </summary>
        /// 
        [Display(Name = "List Ol", Description = "fa-list-ol", GroupName = "duotone light regular solid")]
        IconListOl = '\uf0cb',
        
        /// <summary>
        ///     List Ul ("fa-list-ul", \uf0ca) icon.
        /// </summary>
        /// 
        [Display(Name = "List Ul", Description = "fa-list-ul", GroupName = "duotone light regular solid")]
        IconListUl = '\uf0ca',
        
        /// <summary>
        ///     Location Arrow ("fa-location-arrow", \uf124) icon.
        /// </summary>
        /// 
        [Display(Name = "Location Arrow", Description = "fa-location-arrow", GroupName = "duotone light regular solid")]
        IconLocationArrow = '\uf124',
        
        /// <summary>
        ///     Lock ("fa-lock", \uf023) icon.
        /// </summary>
        /// 
        [Display(Name = "Lock", Description = "fa-lock", GroupName = "duotone light regular solid")]
        IconLock = '\uf023',
        
        /// <summary>
        ///     Lock Open ("fa-lock-open", \uf3c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Lock Open", Description = "fa-lock-open", GroupName = "duotone light regular solid")]
        IconLockOpen = '\uf3c1',
        
        /// <summary>
        ///     Long Arrow Alt Down ("fa-long-arrow-alt-down", \uf309) icon.
        /// </summary>
        /// 
        [Display(Name = "Long Arrow Alt Down", Description = "fa-long-arrow-alt-down", GroupName = "duotone light regular solid")]
        IconLongArrowAltDown = '\uf309',
        
        /// <summary>
        ///     Long Arrow Alt Left ("fa-long-arrow-alt-left", \uf30a) icon.
        /// </summary>
        /// 
        [Display(Name = "Long Arrow Alt Left", Description = "fa-long-arrow-alt-left", GroupName = "duotone light regular solid")]
        IconLongArrowAltLeft = '\uf30a',
        
        /// <summary>
        ///     Long Arrow Alt Right ("fa-long-arrow-alt-right", \uf30b) icon.
        /// </summary>
        /// 
        [Display(Name = "Long Arrow Alt Right", Description = "fa-long-arrow-alt-right", GroupName = "duotone light regular solid")]
        IconLongArrowAltRight = '\uf30b',
        
        /// <summary>
        ///     Long Arrow Alt Up ("fa-long-arrow-alt-up", \uf30c) icon.
        /// </summary>
        /// 
        [Display(Name = "Long Arrow Alt Up", Description = "fa-long-arrow-alt-up", GroupName = "duotone light regular solid")]
        IconLongArrowAltUp = '\uf30c',
        
        /// <summary>
        ///     Low Vision ("fa-low-vision", \uf2a8) icon.
        /// </summary>
        /// 
        [Display(Name = "Low Vision", Description = "fa-low-vision", GroupName = "duotone light regular solid")]
        IconLowVision = '\uf2a8',
        
        /// <summary>
        ///     Luggage Cart ("fa-luggage-cart", \uf59d) icon.
        /// </summary>
        /// 
        [Display(Name = "Luggage Cart", Description = "fa-luggage-cart", GroupName = "duotone light regular solid")]
        IconLuggageCart = '\uf59d',
        
        /// <summary>
        ///     Lungs ("fa-lungs", \uf604) icon.
        /// </summary>
        /// 
        [Display(Name = "Lungs", Description = "fa-lungs", GroupName = "duotone light regular solid")]
        IconLungs = '\uf604',
        
        /// <summary>
        ///     Lungs Virus ("fa-lungs-virus", \uf967) icon.
        /// </summary>
        /// 
        [Display(Name = "Lungs Virus", Description = "fa-lungs-virus", GroupName = "duotone light regular solid")]
        IconLungsVirus = '\uf967',
        
        /// <summary>
        ///     Lyft ("fa-lyft", \uf3c3) icon.
        /// </summary>
        /// 
        [Display(Name = "Lyft", Description = "fa-lyft", GroupName = "brands")]
        IconLyft = '\uf3c3',
        
        /// <summary>
        ///     Magento ("fa-magento", \uf3c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Magento", Description = "fa-magento", GroupName = "brands")]
        IconMagento = '\uf3c4',
        
        /// <summary>
        ///     Magic ("fa-magic", \uf0d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Magic", Description = "fa-magic", GroupName = "duotone light regular solid")]
        IconMagic = '\uf0d0',
        
        /// <summary>
        ///     Magnet ("fa-magnet", \uf076) icon.
        /// </summary>
        /// 
        [Display(Name = "Magnet", Description = "fa-magnet", GroupName = "duotone light regular solid")]
        IconMagnet = '\uf076',
        
        /// <summary>
        ///     Mail Bulk ("fa-mail-bulk", \uf674) icon.
        /// </summary>
        /// 
        [Display(Name = "Mail Bulk", Description = "fa-mail-bulk", GroupName = "duotone light regular solid")]
        IconMailBulk = '\uf674',
        
        /// <summary>
        ///     Mailchimp ("fa-mailchimp", \uf59e) icon.
        /// </summary>
        /// 
        [Display(Name = "Mailchimp", Description = "fa-mailchimp", GroupName = "brands")]
        IconMailchimp = '\uf59e',
        
        /// <summary>
        ///     Male ("fa-male", \uf183) icon.
        /// </summary>
        /// 
        [Display(Name = "Male", Description = "fa-male", GroupName = "duotone light regular solid")]
        IconMale = '\uf183',
        
        /// <summary>
        ///     Mandalorian ("fa-mandalorian", \uf50f) icon.
        /// </summary>
        /// 
        [Display(Name = "Mandalorian", Description = "fa-mandalorian", GroupName = "brands")]
        IconMandalorian = '\uf50f',
        
        /// <summary>
        ///     Map ("fa-map", \uf279) icon.
        /// </summary>
        /// 
        [Display(Name = "Map", Description = "fa-map", GroupName = "duotone light regular solid")]
        IconMap = '\uf279',
        
        /// <summary>
        ///     Map Marked ("fa-map-marked", \uf59f) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Marked", Description = "fa-map-marked", GroupName = "duotone light regular solid")]
        IconMapMarked = '\uf59f',
        
        /// <summary>
        ///     Map Marked Alt ("fa-map-marked-alt", \uf5a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Marked Alt", Description = "fa-map-marked-alt", GroupName = "duotone light regular solid")]
        IconMapMarkedAlt = '\uf5a0',
        
        /// <summary>
        ///     Map Marker ("fa-map-marker", \uf041) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Marker", Description = "fa-map-marker", GroupName = "duotone light regular solid")]
        IconMapMarker = '\uf041',
        
        /// <summary>
        ///     Map Marker Alt ("fa-map-marker-alt", \uf3c5) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Marker Alt", Description = "fa-map-marker-alt", GroupName = "duotone light regular solid")]
        IconMapMarkerAlt = '\uf3c5',
        
        /// <summary>
        ///     Map Pin ("fa-map-pin", \uf276) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Pin", Description = "fa-map-pin", GroupName = "duotone light regular solid")]
        IconMapPin = '\uf276',
        
        /// <summary>
        ///     Map Signs ("fa-map-signs", \uf277) icon.
        /// </summary>
        /// 
        [Display(Name = "Map Signs", Description = "fa-map-signs", GroupName = "duotone light regular solid")]
        IconMapSigns = '\uf277',
        
        /// <summary>
        ///     Markdown ("fa-markdown", \uf60f) icon.
        /// </summary>
        /// 
        [Display(Name = "Markdown", Description = "fa-markdown", GroupName = "brands")]
        IconMarkdown = '\uf60f',
        
        /// <summary>
        ///     Marker ("fa-marker", \uf5a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Marker", Description = "fa-marker", GroupName = "duotone light regular solid")]
        IconMarker = '\uf5a1',
        
        /// <summary>
        ///     Mars ("fa-mars", \uf222) icon.
        /// </summary>
        /// 
        [Display(Name = "Mars", Description = "fa-mars", GroupName = "duotone light regular solid")]
        IconMars = '\uf222',
        
        /// <summary>
        ///     Mars Double ("fa-mars-double", \uf227) icon.
        /// </summary>
        /// 
        [Display(Name = "Mars Double", Description = "fa-mars-double", GroupName = "duotone light regular solid")]
        IconMarsDouble = '\uf227',
        
        /// <summary>
        ///     Mars Stroke ("fa-mars-stroke", \uf229) icon.
        /// </summary>
        /// 
        [Display(Name = "Mars Stroke", Description = "fa-mars-stroke", GroupName = "duotone light regular solid")]
        IconMarsStroke = '\uf229',
        
        /// <summary>
        ///     Mars Stroke H ("fa-mars-stroke-h", \uf22b) icon.
        /// </summary>
        /// 
        [Display(Name = "Mars Stroke H", Description = "fa-mars-stroke-h", GroupName = "duotone light regular solid")]
        IconMarsStrokeH = '\uf22b',
        
        /// <summary>
        ///     Mars Stroke V ("fa-mars-stroke-v", \uf22a) icon.
        /// </summary>
        /// 
        [Display(Name = "Mars Stroke V", Description = "fa-mars-stroke-v", GroupName = "duotone light regular solid")]
        IconMarsStrokeV = '\uf22a',
        
        /// <summary>
        ///     Mask ("fa-mask", \uf6fa) icon.
        /// </summary>
        /// 
        [Display(Name = "Mask", Description = "fa-mask", GroupName = "duotone light regular solid")]
        IconMask = '\uf6fa',
        
        /// <summary>
        ///     Mastodon ("fa-mastodon", \uf4f6) icon.
        /// </summary>
        /// 
        [Display(Name = "Mastodon", Description = "fa-mastodon", GroupName = "brands")]
        IconMastodon = '\uf4f6',
        
        /// <summary>
        ///     Maxcdn ("fa-maxcdn", \uf136) icon.
        /// </summary>
        /// 
        [Display(Name = "Maxcdn", Description = "fa-maxcdn", GroupName = "brands")]
        IconMaxcdn = '\uf136',
        
        /// <summary>
        ///     Mdb ("fa-mdb", \uf8ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Mdb", Description = "fa-mdb", GroupName = "brands")]
        IconMdb = '\uf8ca',
        
        /// <summary>
        ///     Medal ("fa-medal", \uf5a2) icon.
        /// </summary>
        /// 
        [Display(Name = "Medal", Description = "fa-medal", GroupName = "duotone light regular solid")]
        IconMedal = '\uf5a2',
        
        /// <summary>
        ///     Medapps ("fa-medapps", \uf3c6) icon.
        /// </summary>
        /// 
        [Display(Name = "Medapps", Description = "fa-medapps", GroupName = "brands")]
        IconMedapps = '\uf3c6',
        
        /// <summary>
        ///     Medium ("fa-medium", \uf23a) icon.
        /// </summary>
        /// 
        [Display(Name = "Medium", Description = "fa-medium", GroupName = "brands")]
        IconMedium = '\uf23a',
        
        /// <summary>
        ///     Medium M ("fa-medium-m", \uf3c7) icon.
        /// </summary>
        /// 
        [Display(Name = "Medium M", Description = "fa-medium-m", GroupName = "brands")]
        IconMediumM = '\uf3c7',
        
        /// <summary>
        ///     Medkit ("fa-medkit", \uf0fa) icon.
        /// </summary>
        /// 
        [Display(Name = "Medkit", Description = "fa-medkit", GroupName = "duotone light regular solid")]
        IconMedkit = '\uf0fa',
        
        /// <summary>
        ///     Medrt ("fa-medrt", \uf3c8) icon.
        /// </summary>
        /// 
        [Display(Name = "Medrt", Description = "fa-medrt", GroupName = "brands")]
        IconMedrt = '\uf3c8',
        
        /// <summary>
        ///     Meetup ("fa-meetup", \uf2e0) icon.
        /// </summary>
        /// 
        [Display(Name = "Meetup", Description = "fa-meetup", GroupName = "brands")]
        IconMeetup = '\uf2e0',
        
        /// <summary>
        ///     Megaport ("fa-megaport", \uf5a3) icon.
        /// </summary>
        /// 
        [Display(Name = "Megaport", Description = "fa-megaport", GroupName = "brands")]
        IconMegaport = '\uf5a3',
        
        /// <summary>
        ///     Meh ("fa-meh", \uf11a) icon.
        /// </summary>
        /// 
        [Display(Name = "Meh", Description = "fa-meh", GroupName = "duotone light regular solid")]
        IconMeh = '\uf11a',
        
        /// <summary>
        ///     Meh Blank ("fa-meh-blank", \uf5a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Meh Blank", Description = "fa-meh-blank", GroupName = "duotone light regular solid")]
        IconMehBlank = '\uf5a4',
        
        /// <summary>
        ///     Meh Rolling Eyes ("fa-meh-rolling-eyes", \uf5a5) icon.
        /// </summary>
        /// 
        [Display(Name = "Meh Rolling Eyes", Description = "fa-meh-rolling-eyes", GroupName = "duotone light regular solid")]
        IconMehRollingEyes = '\uf5a5',
        
        /// <summary>
        ///     Memory ("fa-memory", \uf538) icon.
        /// </summary>
        /// 
        [Display(Name = "Memory", Description = "fa-memory", GroupName = "duotone light regular solid")]
        IconMemory = '\uf538',
        
        /// <summary>
        ///     Mendeley ("fa-mendeley", \uf7b3) icon.
        /// </summary>
        /// 
        [Display(Name = "Mendeley", Description = "fa-mendeley", GroupName = "brands")]
        IconMendeley = '\uf7b3',
        
        /// <summary>
        ///     Menorah ("fa-menorah", \uf676) icon.
        /// </summary>
        /// 
        [Display(Name = "Menorah", Description = "fa-menorah", GroupName = "duotone light regular solid")]
        IconMenorah = '\uf676',
        
        /// <summary>
        ///     Mercury ("fa-mercury", \uf223) icon.
        /// </summary>
        /// 
        [Display(Name = "Mercury", Description = "fa-mercury", GroupName = "duotone light regular solid")]
        IconMercury = '\uf223',
        
        /// <summary>
        ///     Meteor ("fa-meteor", \uf753) icon.
        /// </summary>
        /// 
        [Display(Name = "Meteor", Description = "fa-meteor", GroupName = "duotone light regular solid")]
        IconMeteor = '\uf753',
        
        /// <summary>
        ///     Microblog ("fa-microblog", \uf91a) icon.
        /// </summary>
        /// 
        [Display(Name = "Microblog", Description = "fa-microblog", GroupName = "brands")]
        IconMicroblog = '\uf91a',
        
        /// <summary>
        ///     Microchip ("fa-microchip", \uf2db) icon.
        /// </summary>
        /// 
        [Display(Name = "Microchip", Description = "fa-microchip", GroupName = "duotone light regular solid")]
        IconMicrochip = '\uf2db',
        
        /// <summary>
        ///     Microphone ("fa-microphone", \uf130) icon.
        /// </summary>
        /// 
        [Display(Name = "Microphone", Description = "fa-microphone", GroupName = "duotone light regular solid")]
        IconMicrophone = '\uf130',
        
        /// <summary>
        ///     Microphone Alt ("fa-microphone-alt", \uf3c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Microphone Alt", Description = "fa-microphone-alt", GroupName = "duotone light regular solid")]
        IconMicrophoneAlt = '\uf3c9',
        
        /// <summary>
        ///     Microphone Alt Slash ("fa-microphone-alt-slash", \uf539) icon.
        /// </summary>
        /// 
        [Display(Name = "Microphone Alt Slash", Description = "fa-microphone-alt-slash", GroupName = "duotone light regular solid")]
        IconMicrophoneAltSlash = '\uf539',
        
        /// <summary>
        ///     Microphone Slash ("fa-microphone-slash", \uf131) icon.
        /// </summary>
        /// 
        [Display(Name = "Microphone Slash", Description = "fa-microphone-slash", GroupName = "duotone light regular solid")]
        IconMicrophoneSlash = '\uf131',
        
        /// <summary>
        ///     Microscope ("fa-microscope", \uf610) icon.
        /// </summary>
        /// 
        [Display(Name = "Microscope", Description = "fa-microscope", GroupName = "duotone light regular solid")]
        IconMicroscope = '\uf610',
        
        /// <summary>
        ///     Microsoft ("fa-microsoft", \uf3ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Microsoft", Description = "fa-microsoft", GroupName = "brands")]
        IconMicrosoft = '\uf3ca',
        
        /// <summary>
        ///     Minus ("fa-minus", \uf068) icon.
        /// </summary>
        /// 
        [Display(Name = "Minus", Description = "fa-minus", GroupName = "duotone light regular solid")]
        IconMinus = '\uf068',
        
        /// <summary>
        ///     Minus Circle ("fa-minus-circle", \uf056) icon.
        /// </summary>
        /// 
        [Display(Name = "Minus Circle", Description = "fa-minus-circle", GroupName = "duotone light regular solid")]
        IconMinusCircle = '\uf056',
        
        /// <summary>
        ///     Minus Square ("fa-minus-square", \uf146) icon.
        /// </summary>
        /// 
        [Display(Name = "Minus Square", Description = "fa-minus-square", GroupName = "duotone light regular solid")]
        IconMinusSquare = '\uf146',
        
        /// <summary>
        ///     Mitten ("fa-mitten", \uf7b5) icon.
        /// </summary>
        /// 
        [Display(Name = "Mitten", Description = "fa-mitten", GroupName = "duotone light regular solid")]
        IconMitten = '\uf7b5',
        
        /// <summary>
        ///     Mix ("fa-mix", \uf3cb) icon.
        /// </summary>
        /// 
        [Display(Name = "Mix", Description = "fa-mix", GroupName = "brands")]
        IconMix = '\uf3cb',
        
        /// <summary>
        ///     Mixcloud ("fa-mixcloud", \uf289) icon.
        /// </summary>
        /// 
        [Display(Name = "Mixcloud", Description = "fa-mixcloud", GroupName = "brands")]
        IconMixcloud = '\uf289',
        
        /// <summary>
        ///     Mixer ("fa-mixer", \uf956) icon.
        /// </summary>
        /// 
        [Display(Name = "Mixer", Description = "fa-mixer", GroupName = "brands")]
        IconMixer = '\uf956',
        
        /// <summary>
        ///     Mizuni ("fa-mizuni", \uf3cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Mizuni", Description = "fa-mizuni", GroupName = "brands")]
        IconMizuni = '\uf3cc',
        
        /// <summary>
        ///     Mobile ("fa-mobile", \uf10b) icon.
        /// </summary>
        /// 
        [Display(Name = "Mobile", Description = "fa-mobile", GroupName = "duotone light regular solid")]
        IconMobile = '\uf10b',
        
        /// <summary>
        ///     Mobile Alt ("fa-mobile-alt", \uf3cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Mobile Alt", Description = "fa-mobile-alt", GroupName = "duotone light regular solid")]
        IconMobileAlt = '\uf3cd',
        
        /// <summary>
        ///     Modx ("fa-modx", \uf285) icon.
        /// </summary>
        /// 
        [Display(Name = "Modx", Description = "fa-modx", GroupName = "brands")]
        IconModx = '\uf285',
        
        /// <summary>
        ///     Monero ("fa-monero", \uf3d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Monero", Description = "fa-monero", GroupName = "brands")]
        IconMonero = '\uf3d0',
        
        /// <summary>
        ///     Money Bill ("fa-money-bill", \uf0d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Bill", Description = "fa-money-bill", GroupName = "duotone light regular solid")]
        IconMoneyBill = '\uf0d6',
        
        /// <summary>
        ///     Money Bill Alt ("fa-money-bill-alt", \uf3d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Bill Alt", Description = "fa-money-bill-alt", GroupName = "duotone light regular solid")]
        IconMoneyBillAlt = '\uf3d1',
        
        /// <summary>
        ///     Money Bill Wave ("fa-money-bill-wave", \uf53a) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Bill Wave", Description = "fa-money-bill-wave", GroupName = "duotone light regular solid")]
        IconMoneyBillWave = '\uf53a',
        
        /// <summary>
        ///     Money Bill Wave Alt ("fa-money-bill-wave-alt", \uf53b) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Bill Wave Alt", Description = "fa-money-bill-wave-alt", GroupName = "duotone light regular solid")]
        IconMoneyBillWaveAlt = '\uf53b',
        
        /// <summary>
        ///     Money Check ("fa-money-check", \uf53c) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Check", Description = "fa-money-check", GroupName = "duotone light regular solid")]
        IconMoneyCheck = '\uf53c',
        
        /// <summary>
        ///     Money Check Alt ("fa-money-check-alt", \uf53d) icon.
        /// </summary>
        /// 
        [Display(Name = "Money Check Alt", Description = "fa-money-check-alt", GroupName = "duotone light regular solid")]
        IconMoneyCheckAlt = '\uf53d',
        
        /// <summary>
        ///     Monument ("fa-monument", \uf5a6) icon.
        /// </summary>
        /// 
        [Display(Name = "Monument", Description = "fa-monument", GroupName = "duotone light regular solid")]
        IconMonument = '\uf5a6',
        
        /// <summary>
        ///     Moon ("fa-moon", \uf186) icon.
        /// </summary>
        /// 
        [Display(Name = "Moon", Description = "fa-moon", GroupName = "duotone light regular solid")]
        IconMoon = '\uf186',
        
        /// <summary>
        ///     Mortar Pestle ("fa-mortar-pestle", \uf5a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Mortar Pestle", Description = "fa-mortar-pestle", GroupName = "duotone light regular solid")]
        IconMortarPestle = '\uf5a7',
        
        /// <summary>
        ///     Mosque ("fa-mosque", \uf678) icon.
        /// </summary>
        /// 
        [Display(Name = "Mosque", Description = "fa-mosque", GroupName = "duotone light regular solid")]
        IconMosque = '\uf678',
        
        /// <summary>
        ///     Motorcycle ("fa-motorcycle", \uf21c) icon.
        /// </summary>
        /// 
        [Display(Name = "Motorcycle", Description = "fa-motorcycle", GroupName = "duotone light regular solid")]
        IconMotorcycle = '\uf21c',
        
        /// <summary>
        ///     Mountain ("fa-mountain", \uf6fc) icon.
        /// </summary>
        /// 
        [Display(Name = "Mountain", Description = "fa-mountain", GroupName = "duotone light regular solid")]
        IconMountain = '\uf6fc',
        
        /// <summary>
        ///     Mouse ("fa-mouse", \uf8cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Mouse", Description = "fa-mouse", GroupName = "duotone light regular solid")]
        IconMouse = '\uf8cc',
        
        /// <summary>
        ///     Mouse Pointer ("fa-mouse-pointer", \uf245) icon.
        /// </summary>
        /// 
        [Display(Name = "Mouse Pointer", Description = "fa-mouse-pointer", GroupName = "duotone light regular solid")]
        IconMousePointer = '\uf245',
        
        /// <summary>
        ///     Mug Hot ("fa-mug-hot", \uf7b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Mug Hot", Description = "fa-mug-hot", GroupName = "duotone light regular solid")]
        IconMugHot = '\uf7b6',
        
        /// <summary>
        ///     Music ("fa-music", \uf001) icon.
        /// </summary>
        /// 
        [Display(Name = "Music", Description = "fa-music", GroupName = "duotone light regular solid")]
        IconMusic = '\uf001',
        
        /// <summary>
        ///     Napster ("fa-napster", \uf3d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Napster", Description = "fa-napster", GroupName = "brands")]
        IconNapster = '\uf3d2',
        
        /// <summary>
        ///     Neos ("fa-neos", \uf612) icon.
        /// </summary>
        /// 
        [Display(Name = "Neos", Description = "fa-neos", GroupName = "brands")]
        IconNeos = '\uf612',
        
        /// <summary>
        ///     Network Wired ("fa-network-wired", \uf6ff) icon.
        /// </summary>
        /// 
        [Display(Name = "Network Wired", Description = "fa-network-wired", GroupName = "duotone light regular solid")]
        IconNetworkWired = '\uf6ff',
        
        /// <summary>
        ///     Neuter ("fa-neuter", \uf22c) icon.
        /// </summary>
        /// 
        [Display(Name = "Neuter", Description = "fa-neuter", GroupName = "duotone light regular solid")]
        IconNeuter = '\uf22c',
        
        /// <summary>
        ///     Newspaper ("fa-newspaper", \uf1ea) icon.
        /// </summary>
        /// 
        [Display(Name = "Newspaper", Description = "fa-newspaper", GroupName = "duotone light regular solid")]
        IconNewspaper = '\uf1ea',
        
        /// <summary>
        ///     Nimblr ("fa-nimblr", \uf5a8) icon.
        /// </summary>
        /// 
        [Display(Name = "Nimblr", Description = "fa-nimblr", GroupName = "brands")]
        IconNimblr = '\uf5a8',
        
        /// <summary>
        ///     Node ("fa-node", \uf419) icon.
        /// </summary>
        /// 
        [Display(Name = "Node", Description = "fa-node", GroupName = "brands")]
        IconNode = '\uf419',
        
        /// <summary>
        ///     Node Js ("fa-node-js", \uf3d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Node Js", Description = "fa-node-js", GroupName = "brands")]
        IconNodeJs = '\uf3d3',
        
        /// <summary>
        ///     Not Equal ("fa-not-equal", \uf53e) icon.
        /// </summary>
        /// 
        [Display(Name = "Not Equal", Description = "fa-not-equal", GroupName = "duotone light regular solid")]
        IconNotEqual = '\uf53e',
        
        /// <summary>
        ///     Notes Medical ("fa-notes-medical", \uf481) icon.
        /// </summary>
        /// 
        [Display(Name = "Notes Medical", Description = "fa-notes-medical", GroupName = "duotone light regular solid")]
        IconNotesMedical = '\uf481',
        
        /// <summary>
        ///     Npm ("fa-npm", \uf3d4) icon.
        /// </summary>
        /// 
        [Display(Name = "Npm", Description = "fa-npm", GroupName = "brands")]
        IconNpm = '\uf3d4',
        
        /// <summary>
        ///     Ns8 ("fa-ns8", \uf3d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Ns8", Description = "fa-ns8", GroupName = "brands")]
        IconNs8 = '\uf3d5',
        
        /// <summary>
        ///     Nutritionix ("fa-nutritionix", \uf3d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Nutritionix", Description = "fa-nutritionix", GroupName = "brands")]
        IconNutritionix = '\uf3d6',
        
        /// <summary>
        ///     Object Group ("fa-object-group", \uf247) icon.
        /// </summary>
        /// 
        [Display(Name = "Object Group", Description = "fa-object-group", GroupName = "duotone light regular solid")]
        IconObjectGroup = '\uf247',
        
        /// <summary>
        ///     Object Ungroup ("fa-object-ungroup", \uf248) icon.
        /// </summary>
        /// 
        [Display(Name = "Object Ungroup", Description = "fa-object-ungroup", GroupName = "duotone light regular solid")]
        IconObjectUngroup = '\uf248',
        
        /// <summary>
        ///     Odnoklassniki ("fa-odnoklassniki", \uf263) icon.
        /// </summary>
        /// 
        [Display(Name = "Odnoklassniki", Description = "fa-odnoklassniki", GroupName = "brands")]
        IconOdnoklassniki = '\uf263',
        
        /// <summary>
        ///     Odnoklassniki Square ("fa-odnoklassniki-square", \uf264) icon.
        /// </summary>
        /// 
        [Display(Name = "Odnoklassniki Square", Description = "fa-odnoklassniki-square", GroupName = "brands")]
        IconOdnoklassnikiSquare = '\uf264',
        
        /// <summary>
        ///     Oil Can ("fa-oil-can", \uf613) icon.
        /// </summary>
        /// 
        [Display(Name = "Oil Can", Description = "fa-oil-can", GroupName = "duotone light regular solid")]
        IconOilCan = '\uf613',
        
        /// <summary>
        ///     Old Republic ("fa-old-republic", \uf510) icon.
        /// </summary>
        /// 
        [Display(Name = "Old Republic", Description = "fa-old-republic", GroupName = "brands")]
        IconOldRepublic = '\uf510',
        
        /// <summary>
        ///     Om ("fa-om", \uf679) icon.
        /// </summary>
        /// 
        [Display(Name = "Om", Description = "fa-om", GroupName = "duotone light regular solid")]
        IconOm = '\uf679',
        
        /// <summary>
        ///     Opencart ("fa-opencart", \uf23d) icon.
        /// </summary>
        /// 
        [Display(Name = "Opencart", Description = "fa-opencart", GroupName = "brands")]
        IconOpencart = '\uf23d',
        
        /// <summary>
        ///     Openid ("fa-openid", \uf19b) icon.
        /// </summary>
        /// 
        [Display(Name = "Openid", Description = "fa-openid", GroupName = "brands")]
        IconOpenid = '\uf19b',
        
        /// <summary>
        ///     Opera ("fa-opera", \uf26a) icon.
        /// </summary>
        /// 
        [Display(Name = "Opera", Description = "fa-opera", GroupName = "brands")]
        IconOpera = '\uf26a',
        
        /// <summary>
        ///     Optin Monster ("fa-optin-monster", \uf23c) icon.
        /// </summary>
        /// 
        [Display(Name = "Optin Monster", Description = "fa-optin-monster", GroupName = "brands")]
        IconOptinMonster = '\uf23c',
        
        /// <summary>
        ///     Orcid ("fa-orcid", \uf8d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Orcid", Description = "fa-orcid", GroupName = "brands")]
        IconOrcid = '\uf8d2',
        
        /// <summary>
        ///     Osi ("fa-osi", \uf41a) icon.
        /// </summary>
        /// 
        [Display(Name = "Osi", Description = "fa-osi", GroupName = "brands")]
        IconOsi = '\uf41a',
        
        /// <summary>
        ///     Otter ("fa-otter", \uf700) icon.
        /// </summary>
        /// 
        [Display(Name = "Otter", Description = "fa-otter", GroupName = "duotone light regular solid")]
        IconOtter = '\uf700',
        
        /// <summary>
        ///     Outdent ("fa-outdent", \uf03b) icon.
        /// </summary>
        /// 
        [Display(Name = "Outdent", Description = "fa-outdent", GroupName = "duotone light regular solid")]
        IconOutdent = '\uf03b',
        
        /// <summary>
        ///     Page4 ("fa-page4", \uf3d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Page4", Description = "fa-page4", GroupName = "brands")]
        IconPage4 = '\uf3d7',
        
        /// <summary>
        ///     Pagelines ("fa-pagelines", \uf18c) icon.
        /// </summary>
        /// 
        [Display(Name = "Pagelines", Description = "fa-pagelines", GroupName = "brands")]
        IconPagelines = '\uf18c',
        
        /// <summary>
        ///     Pager ("fa-pager", \uf815) icon.
        /// </summary>
        /// 
        [Display(Name = "Pager", Description = "fa-pager", GroupName = "duotone light regular solid")]
        IconPager = '\uf815',
        
        /// <summary>
        ///     Paint Brush ("fa-paint-brush", \uf1fc) icon.
        /// </summary>
        /// 
        [Display(Name = "Paint Brush", Description = "fa-paint-brush", GroupName = "duotone light regular solid")]
        IconPaintBrush = '\uf1fc',
        
        /// <summary>
        ///     Paint Roller ("fa-paint-roller", \uf5aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Paint Roller", Description = "fa-paint-roller", GroupName = "duotone light regular solid")]
        IconPaintRoller = '\uf5aa',
        
        /// <summary>
        ///     Palette ("fa-palette", \uf53f) icon.
        /// </summary>
        /// 
        [Display(Name = "Palette", Description = "fa-palette", GroupName = "duotone light regular solid")]
        IconPalette = '\uf53f',
        
        /// <summary>
        ///     Palfed ("fa-palfed", \uf3d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Palfed", Description = "fa-palfed", GroupName = "brands")]
        IconPalfed = '\uf3d8',
        
        /// <summary>
        ///     Pallet ("fa-pallet", \uf482) icon.
        /// </summary>
        /// 
        [Display(Name = "Pallet", Description = "fa-pallet", GroupName = "duotone light regular solid")]
        IconPallet = '\uf482',
        
        /// <summary>
        ///     Paperclip ("fa-paperclip", \uf0c6) icon.
        /// </summary>
        /// 
        [Display(Name = "Paperclip", Description = "fa-paperclip", GroupName = "duotone light regular solid")]
        IconPaperclip = '\uf0c6',
        
        /// <summary>
        ///     Paper Plane ("fa-paper-plane", \uf1d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Paper Plane", Description = "fa-paper-plane", GroupName = "duotone light regular solid")]
        IconPaperPlane = '\uf1d8',
        
        /// <summary>
        ///     Parachute Box ("fa-parachute-box", \uf4cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Parachute Box", Description = "fa-parachute-box", GroupName = "duotone light regular solid")]
        IconParachuteBox = '\uf4cd',
        
        /// <summary>
        ///     Paragraph ("fa-paragraph", \uf1dd) icon.
        /// </summary>
        /// 
        [Display(Name = "Paragraph", Description = "fa-paragraph", GroupName = "duotone light regular solid")]
        IconParagraph = '\uf1dd',
        
        /// <summary>
        ///     Parking ("fa-parking", \uf540) icon.
        /// </summary>
        /// 
        [Display(Name = "Parking", Description = "fa-parking", GroupName = "duotone light regular solid")]
        IconParking = '\uf540',
        
        /// <summary>
        ///     Passport ("fa-passport", \uf5ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Passport", Description = "fa-passport", GroupName = "duotone light regular solid")]
        IconPassport = '\uf5ab',
        
        /// <summary>
        ///     Pastafarianism ("fa-pastafarianism", \uf67b) icon.
        /// </summary>
        /// 
        [Display(Name = "Pastafarianism", Description = "fa-pastafarianism", GroupName = "duotone light regular solid")]
        IconPastafarianism = '\uf67b',
        
        /// <summary>
        ///     Paste ("fa-paste", \uf0ea) icon.
        /// </summary>
        /// 
        [Display(Name = "Paste", Description = "fa-paste", GroupName = "duotone light regular solid")]
        IconPaste = '\uf0ea',
        
        /// <summary>
        ///     Patreon ("fa-patreon", \uf3d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Patreon", Description = "fa-patreon", GroupName = "brands")]
        IconPatreon = '\uf3d9',
        
        /// <summary>
        ///     Pause ("fa-pause", \uf04c) icon.
        /// </summary>
        /// 
        [Display(Name = "Pause", Description = "fa-pause", GroupName = "duotone light regular solid")]
        IconPause = '\uf04c',
        
        /// <summary>
        ///     Pause Circle ("fa-pause-circle", \uf28b) icon.
        /// </summary>
        /// 
        [Display(Name = "Pause Circle", Description = "fa-pause-circle", GroupName = "duotone light regular solid")]
        IconPauseCircle = '\uf28b',
        
        /// <summary>
        ///     Paw ("fa-paw", \uf1b0) icon.
        /// </summary>
        /// 
        [Display(Name = "Paw", Description = "fa-paw", GroupName = "duotone light regular solid")]
        IconPaw = '\uf1b0',
        
        /// <summary>
        ///     Paypal ("fa-paypal", \uf1ed) icon.
        /// </summary>
        /// 
        [Display(Name = "Paypal", Description = "fa-paypal", GroupName = "brands")]
        IconPaypal = '\uf1ed',
        
        /// <summary>
        ///     Peace ("fa-peace", \uf67c) icon.
        /// </summary>
        /// 
        [Display(Name = "Peace", Description = "fa-peace", GroupName = "duotone light regular solid")]
        IconPeace = '\uf67c',
        
        /// <summary>
        ///     Pen ("fa-pen", \uf304) icon.
        /// </summary>
        /// 
        [Display(Name = "Pen", Description = "fa-pen", GroupName = "duotone light regular solid")]
        IconPen = '\uf304',
        
        /// <summary>
        ///     Pen Alt ("fa-pen-alt", \uf305) icon.
        /// </summary>
        /// 
        [Display(Name = "Pen Alt", Description = "fa-pen-alt", GroupName = "duotone light regular solid")]
        IconPenAlt = '\uf305',
        
        /// <summary>
        ///     Pencil Alt ("fa-pencil-alt", \uf303) icon.
        /// </summary>
        /// 
        [Display(Name = "Pencil Alt", Description = "fa-pencil-alt", GroupName = "duotone light regular solid")]
        IconPencilAlt = '\uf303',
        
        /// <summary>
        ///     Pencil Ruler ("fa-pencil-ruler", \uf5ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Pencil Ruler", Description = "fa-pencil-ruler", GroupName = "duotone light regular solid")]
        IconPencilRuler = '\uf5ae',
        
        /// <summary>
        ///     Pen Fancy ("fa-pen-fancy", \uf5ac) icon.
        /// </summary>
        /// 
        [Display(Name = "Pen Fancy", Description = "fa-pen-fancy", GroupName = "duotone light regular solid")]
        IconPenFancy = '\uf5ac',
        
        /// <summary>
        ///     Pen Nib ("fa-pen-nib", \uf5ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Pen Nib", Description = "fa-pen-nib", GroupName = "duotone light regular solid")]
        IconPenNib = '\uf5ad',
        
        /// <summary>
        ///     Penny Arcade ("fa-penny-arcade", \uf704) icon.
        /// </summary>
        /// 
        [Display(Name = "Penny Arcade", Description = "fa-penny-arcade", GroupName = "brands")]
        IconPennyArcade = '\uf704',
        
        /// <summary>
        ///     Pen Square ("fa-pen-square", \uf14b) icon.
        /// </summary>
        /// 
        [Display(Name = "Pen Square", Description = "fa-pen-square", GroupName = "duotone light regular solid")]
        IconPenSquare = '\uf14b',
        
        /// <summary>
        ///     People Arrows ("fa-people-arrows", \uf968) icon.
        /// </summary>
        /// 
        [Display(Name = "People Arrows", Description = "fa-people-arrows", GroupName = "duotone light regular solid")]
        IconPeopleArrows = '\uf968',
        
        /// <summary>
        ///     People Carry ("fa-people-carry", \uf4ce) icon.
        /// </summary>
        /// 
        [Display(Name = "People Carry", Description = "fa-people-carry", GroupName = "duotone light regular solid")]
        IconPeopleCarry = '\uf4ce',
        
        /// <summary>
        ///     Pepper Hot ("fa-pepper-hot", \uf816) icon.
        /// </summary>
        /// 
        [Display(Name = "Pepper Hot", Description = "fa-pepper-hot", GroupName = "duotone light regular solid")]
        IconPepperHot = '\uf816',
        
        /// <summary>
        ///     Percent ("fa-percent", \uf295) icon.
        /// </summary>
        /// 
        [Display(Name = "Percent", Description = "fa-percent", GroupName = "duotone light regular solid")]
        IconPercent = '\uf295',
        
        /// <summary>
        ///     Percentage ("fa-percentage", \uf541) icon.
        /// </summary>
        /// 
        [Display(Name = "Percentage", Description = "fa-percentage", GroupName = "duotone light regular solid")]
        IconPercentage = '\uf541',
        
        /// <summary>
        ///     Periscope ("fa-periscope", \uf3da) icon.
        /// </summary>
        /// 
        [Display(Name = "Periscope", Description = "fa-periscope", GroupName = "brands")]
        IconPeriscope = '\uf3da',
        
        /// <summary>
        ///     Person Booth ("fa-person-booth", \uf756) icon.
        /// </summary>
        /// 
        [Display(Name = "Person Booth", Description = "fa-person-booth", GroupName = "duotone light regular solid")]
        IconPersonBooth = '\uf756',
        
        /// <summary>
        ///     Phabricator ("fa-phabricator", \uf3db) icon.
        /// </summary>
        /// 
        [Display(Name = "Phabricator", Description = "fa-phabricator", GroupName = "brands")]
        IconPhabricator = '\uf3db',
        
        /// <summary>
        ///     Phoenix Framework ("fa-phoenix-framework", \uf3dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Phoenix Framework", Description = "fa-phoenix-framework", GroupName = "brands")]
        IconPhoenixFramework = '\uf3dc',
        
        /// <summary>
        ///     Phoenix Squadron ("fa-phoenix-squadron", \uf511) icon.
        /// </summary>
        /// 
        [Display(Name = "Phoenix Squadron", Description = "fa-phoenix-squadron", GroupName = "brands")]
        IconPhoenixSquadron = '\uf511',
        
        /// <summary>
        ///     Phone ("fa-phone", \uf095) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone", Description = "fa-phone", GroupName = "duotone light regular solid")]
        IconPhone = '\uf095',
        
        /// <summary>
        ///     Phone Alt ("fa-phone-alt", \uf879) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone Alt", Description = "fa-phone-alt", GroupName = "duotone light regular solid")]
        IconPhoneAlt = '\uf879',
        
        /// <summary>
        ///     Phone Slash ("fa-phone-slash", \uf3dd) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone Slash", Description = "fa-phone-slash", GroupName = "duotone light regular solid")]
        IconPhoneSlash = '\uf3dd',
        
        /// <summary>
        ///     Phone Square ("fa-phone-square", \uf098) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone Square", Description = "fa-phone-square", GroupName = "duotone light regular solid")]
        IconPhoneSquare = '\uf098',
        
        /// <summary>
        ///     Phone Square Alt ("fa-phone-square-alt", \uf87b) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone Square Alt", Description = "fa-phone-square-alt", GroupName = "duotone light regular solid")]
        IconPhoneSquareAlt = '\uf87b',
        
        /// <summary>
        ///     Phone Volume ("fa-phone-volume", \uf2a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Phone Volume", Description = "fa-phone-volume", GroupName = "duotone light regular solid")]
        IconPhoneVolume = '\uf2a0',
        
        /// <summary>
        ///     Photo Video ("fa-photo-video", \uf87c) icon.
        /// </summary>
        /// 
        [Display(Name = "Photo Video", Description = "fa-photo-video", GroupName = "duotone light regular solid")]
        IconPhotoVideo = '\uf87c',
        
        /// <summary>
        ///     Php ("fa-php", \uf457) icon.
        /// </summary>
        /// 
        [Display(Name = "Php", Description = "fa-php", GroupName = "brands")]
        IconPhp = '\uf457',
        
        /// <summary>
        ///     Pied Piper ("fa-pied-piper", \uf2ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Pied Piper", Description = "fa-pied-piper", GroupName = "brands")]
        IconPiedPiper = '\uf2ae',
        
        /// <summary>
        ///     Pied Piper Alt ("fa-pied-piper-alt", \uf1a8) icon.
        /// </summary>
        /// 
        [Display(Name = "Pied Piper Alt", Description = "fa-pied-piper-alt", GroupName = "brands")]
        IconPiedPiperAlt = '\uf1a8',
        
        /// <summary>
        ///     Pied Piper Hat ("fa-pied-piper-hat", \uf4e5) icon.
        /// </summary>
        /// 
        [Display(Name = "Pied Piper Hat", Description = "fa-pied-piper-hat", GroupName = "brands")]
        IconPiedPiperHat = '\uf4e5',
        
        /// <summary>
        ///     Pied Piper Pp ("fa-pied-piper-pp", \uf1a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Pied Piper Pp", Description = "fa-pied-piper-pp", GroupName = "brands")]
        IconPiedPiperPp = '\uf1a7',
        
        /// <summary>
        ///     Pied Piper Square ("fa-pied-piper-square", \uf91e) icon.
        /// </summary>
        /// 
        [Display(Name = "Pied Piper Square", Description = "fa-pied-piper-square", GroupName = "brands")]
        IconPiedPiperSquare = '\uf91e',
        
        /// <summary>
        ///     Piggy Bank ("fa-piggy-bank", \uf4d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Piggy Bank", Description = "fa-piggy-bank", GroupName = "duotone light regular solid")]
        IconPiggyBank = '\uf4d3',
        
        /// <summary>
        ///     Pills ("fa-pills", \uf484) icon.
        /// </summary>
        /// 
        [Display(Name = "Pills", Description = "fa-pills", GroupName = "duotone light regular solid")]
        IconPills = '\uf484',
        
        /// <summary>
        ///     Pinterest ("fa-pinterest", \uf0d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Pinterest", Description = "fa-pinterest", GroupName = "brands")]
        IconPinterest = '\uf0d2',
        
        /// <summary>
        ///     Pinterest P ("fa-pinterest-p", \uf231) icon.
        /// </summary>
        /// 
        [Display(Name = "Pinterest P", Description = "fa-pinterest-p", GroupName = "brands")]
        IconPinterestP = '\uf231',
        
        /// <summary>
        ///     Pinterest Square ("fa-pinterest-square", \uf0d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Pinterest Square", Description = "fa-pinterest-square", GroupName = "brands")]
        IconPinterestSquare = '\uf0d3',
        
        /// <summary>
        ///     Pizza Slice ("fa-pizza-slice", \uf818) icon.
        /// </summary>
        /// 
        [Display(Name = "Pizza Slice", Description = "fa-pizza-slice", GroupName = "duotone light regular solid")]
        IconPizzaSlice = '\uf818',
        
        /// <summary>
        ///     Place Of Worship ("fa-place-of-worship", \uf67f) icon.
        /// </summary>
        /// 
        [Display(Name = "Place Of Worship", Description = "fa-place-of-worship", GroupName = "duotone light regular solid")]
        IconPlaceOfWorship = '\uf67f',
        
        /// <summary>
        ///     Plane ("fa-plane", \uf072) icon.
        /// </summary>
        /// 
        [Display(Name = "Plane", Description = "fa-plane", GroupName = "duotone light regular solid")]
        IconPlane = '\uf072',
        
        /// <summary>
        ///     Plane Arrival ("fa-plane-arrival", \uf5af) icon.
        /// </summary>
        /// 
        [Display(Name = "Plane Arrival", Description = "fa-plane-arrival", GroupName = "duotone light regular solid")]
        IconPlaneArrival = '\uf5af',
        
        /// <summary>
        ///     Plane Departure ("fa-plane-departure", \uf5b0) icon.
        /// </summary>
        /// 
        [Display(Name = "Plane Departure", Description = "fa-plane-departure", GroupName = "duotone light regular solid")]
        IconPlaneDeparture = '\uf5b0',
        
        /// <summary>
        ///     Plane Slash ("fa-plane-slash", \uf969) icon.
        /// </summary>
        /// 
        [Display(Name = "Plane Slash", Description = "fa-plane-slash", GroupName = "duotone light regular solid")]
        IconPlaneSlash = '\uf969',
        
        /// <summary>
        ///     Play ("fa-play", \uf04b) icon.
        /// </summary>
        /// 
        [Display(Name = "Play", Description = "fa-play", GroupName = "duotone light regular solid")]
        IconPlay = '\uf04b',
        
        /// <summary>
        ///     Play Circle ("fa-play-circle", \uf144) icon.
        /// </summary>
        /// 
        [Display(Name = "Play Circle", Description = "fa-play-circle", GroupName = "duotone light regular solid")]
        IconPlayCircle = '\uf144',
        
        /// <summary>
        ///     Playstation ("fa-playstation", \uf3df) icon.
        /// </summary>
        /// 
        [Display(Name = "Playstation", Description = "fa-playstation", GroupName = "brands")]
        IconPlaystation = '\uf3df',
        
        /// <summary>
        ///     Plug ("fa-plug", \uf1e6) icon.
        /// </summary>
        /// 
        [Display(Name = "Plug", Description = "fa-plug", GroupName = "duotone light regular solid")]
        IconPlug = '\uf1e6',
        
        /// <summary>
        ///     Plus ("fa-plus", \uf067) icon.
        /// </summary>
        /// 
        [Display(Name = "Plus", Description = "fa-plus", GroupName = "duotone light regular solid")]
        IconPlus = '\uf067',
        
        /// <summary>
        ///     Plus Circle ("fa-plus-circle", \uf055) icon.
        /// </summary>
        /// 
        [Display(Name = "Plus Circle", Description = "fa-plus-circle", GroupName = "duotone light regular solid")]
        IconPlusCircle = '\uf055',
        
        /// <summary>
        ///     Plus Square ("fa-plus-square", \uf0fe) icon.
        /// </summary>
        /// 
        [Display(Name = "Plus Square", Description = "fa-plus-square", GroupName = "duotone light regular solid")]
        IconPlusSquare = '\uf0fe',
        
        /// <summary>
        ///     Podcast ("fa-podcast", \uf2ce) icon.
        /// </summary>
        /// 
        [Display(Name = "Podcast", Description = "fa-podcast", GroupName = "duotone light regular solid")]
        IconPodcast = '\uf2ce',
        
        /// <summary>
        ///     Poll ("fa-poll", \uf681) icon.
        /// </summary>
        /// 
        [Display(Name = "Poll", Description = "fa-poll", GroupName = "duotone light regular solid")]
        IconPoll = '\uf681',
        
        /// <summary>
        ///     Poll H ("fa-poll-h", \uf682) icon.
        /// </summary>
        /// 
        [Display(Name = "Poll H", Description = "fa-poll-h", GroupName = "duotone light regular solid")]
        IconPollH = '\uf682',
        
        /// <summary>
        ///     Poo ("fa-poo", \uf2fe) icon.
        /// </summary>
        /// 
        [Display(Name = "Poo", Description = "fa-poo", GroupName = "duotone light regular solid")]
        IconPoo = '\uf2fe',
        
        /// <summary>
        ///     Poop ("fa-poop", \uf619) icon.
        /// </summary>
        /// 
        [Display(Name = "Poop", Description = "fa-poop", GroupName = "duotone light regular solid")]
        IconPoop = '\uf619',
        
        /// <summary>
        ///     Poo Storm ("fa-poo-storm", \uf75a) icon.
        /// </summary>
        /// 
        [Display(Name = "Poo Storm", Description = "fa-poo-storm", GroupName = "duotone light regular solid")]
        IconPooStorm = '\uf75a',
        
        /// <summary>
        ///     Portrait ("fa-portrait", \uf3e0) icon.
        /// </summary>
        /// 
        [Display(Name = "Portrait", Description = "fa-portrait", GroupName = "duotone light regular solid")]
        IconPortrait = '\uf3e0',
        
        /// <summary>
        ///     Pound Sign ("fa-pound-sign", \uf154) icon.
        /// </summary>
        /// 
        [Display(Name = "Pound Sign", Description = "fa-pound-sign", GroupName = "duotone light regular solid")]
        IconPoundSign = '\uf154',
        
        /// <summary>
        ///     Power Off ("fa-power-off", \uf011) icon.
        /// </summary>
        /// 
        [Display(Name = "Power Off", Description = "fa-power-off", GroupName = "duotone light regular solid")]
        IconPowerOff = '\uf011',
        
        /// <summary>
        ///     Pray ("fa-pray", \uf683) icon.
        /// </summary>
        /// 
        [Display(Name = "Pray", Description = "fa-pray", GroupName = "duotone light regular solid")]
        IconPray = '\uf683',
        
        /// <summary>
        ///     Praying Hands ("fa-praying-hands", \uf684) icon.
        /// </summary>
        /// 
        [Display(Name = "Praying Hands", Description = "fa-praying-hands", GroupName = "duotone light regular solid")]
        IconPrayingHands = '\uf684',
        
        /// <summary>
        ///     Prescription ("fa-prescription", \uf5b1) icon.
        /// </summary>
        /// 
        [Display(Name = "Prescription", Description = "fa-prescription", GroupName = "duotone light regular solid")]
        IconPrescription = '\uf5b1',
        
        /// <summary>
        ///     Prescription Bottle ("fa-prescription-bottle", \uf485) icon.
        /// </summary>
        /// 
        [Display(Name = "Prescription Bottle", Description = "fa-prescription-bottle", GroupName = "duotone light regular solid")]
        IconPrescriptionBottle = '\uf485',
        
        /// <summary>
        ///     Prescription Bottle Alt ("fa-prescription-bottle-alt", \uf486) icon.
        /// </summary>
        /// 
        [Display(Name = "Prescription Bottle Alt", Description = "fa-prescription-bottle-alt", GroupName = "duotone light regular solid")]
        IconPrescriptionBottleAlt = '\uf486',
        
        /// <summary>
        ///     Print ("fa-print", \uf02f) icon.
        /// </summary>
        /// 
        [Display(Name = "Print", Description = "fa-print", GroupName = "duotone light regular solid")]
        IconPrint = '\uf02f',
        
        /// <summary>
        ///     Procedures ("fa-procedures", \uf487) icon.
        /// </summary>
        /// 
        [Display(Name = "Procedures", Description = "fa-procedures", GroupName = "duotone light regular solid")]
        IconProcedures = '\uf487',
        
        /// <summary>
        ///     Product Hunt ("fa-product-hunt", \uf288) icon.
        /// </summary>
        /// 
        [Display(Name = "Product Hunt", Description = "fa-product-hunt", GroupName = "brands")]
        IconProductHunt = '\uf288',
        
        /// <summary>
        ///     Project Diagram ("fa-project-diagram", \uf542) icon.
        /// </summary>
        /// 
        [Display(Name = "Project Diagram", Description = "fa-project-diagram", GroupName = "duotone light regular solid")]
        IconProjectDiagram = '\uf542',
        
        /// <summary>
        ///     Pump Medical ("fa-pump-medical", \uf96a) icon.
        /// </summary>
        /// 
        [Display(Name = "Pump Medical", Description = "fa-pump-medical", GroupName = "duotone light regular solid")]
        IconPumpMedical = '\uf96a',
        
        /// <summary>
        ///     Pump Soap ("fa-pump-soap", \uf96b) icon.
        /// </summary>
        /// 
        [Display(Name = "Pump Soap", Description = "fa-pump-soap", GroupName = "duotone light regular solid")]
        IconPumpSoap = '\uf96b',
        
        /// <summary>
        ///     Pushed ("fa-pushed", \uf3e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Pushed", Description = "fa-pushed", GroupName = "brands")]
        IconPushed = '\uf3e1',
        
        /// <summary>
        ///     Puzzle Piece ("fa-puzzle-piece", \uf12e) icon.
        /// </summary>
        /// 
        [Display(Name = "Puzzle Piece", Description = "fa-puzzle-piece", GroupName = "duotone light regular solid")]
        IconPuzzlePiece = '\uf12e',
        
        /// <summary>
        ///     Python ("fa-python", \uf3e2) icon.
        /// </summary>
        /// 
        [Display(Name = "Python", Description = "fa-python", GroupName = "brands")]
        IconPython = '\uf3e2',
        
        /// <summary>
        ///     Qq ("fa-qq", \uf1d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Qq", Description = "fa-qq", GroupName = "brands")]
        IconQq = '\uf1d6',
        
        /// <summary>
        ///     Qrcode ("fa-qrcode", \uf029) icon.
        /// </summary>
        /// 
        [Display(Name = "Qrcode", Description = "fa-qrcode", GroupName = "duotone light regular solid")]
        IconQrcode = '\uf029',
        
        /// <summary>
        ///     Question ("fa-question", \uf128) icon.
        /// </summary>
        /// 
        [Display(Name = "Question", Description = "fa-question", GroupName = "duotone light regular solid")]
        IconQuestion = '\uf128',
        
        /// <summary>
        ///     Question Circle ("fa-question-circle", \uf059) icon.
        /// </summary>
        /// 
        [Display(Name = "Question Circle", Description = "fa-question-circle", GroupName = "duotone light regular solid")]
        IconQuestionCircle = '\uf059',
        
        /// <summary>
        ///     Quidditch ("fa-quidditch", \uf458) icon.
        /// </summary>
        /// 
        [Display(Name = "Quidditch", Description = "fa-quidditch", GroupName = "duotone light regular solid")]
        IconQuidditch = '\uf458',
        
        /// <summary>
        ///     Quinscape ("fa-quinscape", \uf459) icon.
        /// </summary>
        /// 
        [Display(Name = "Quinscape", Description = "fa-quinscape", GroupName = "brands")]
        IconQuinscape = '\uf459',
        
        /// <summary>
        ///     Quora ("fa-quora", \uf2c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Quora", Description = "fa-quora", GroupName = "brands")]
        IconQuora = '\uf2c4',
        
        /// <summary>
        ///     Quote Left ("fa-quote-left", \uf10d) icon.
        /// </summary>
        /// 
        [Display(Name = "Quote Left", Description = "fa-quote-left", GroupName = "duotone light regular solid")]
        IconQuoteLeft = '\uf10d',
        
        /// <summary>
        ///     Quote Right ("fa-quote-right", \uf10e) icon.
        /// </summary>
        /// 
        [Display(Name = "Quote Right", Description = "fa-quote-right", GroupName = "duotone light regular solid")]
        IconQuoteRight = '\uf10e',
        
        /// <summary>
        ///     Quran ("fa-quran", \uf687) icon.
        /// </summary>
        /// 
        [Display(Name = "Quran", Description = "fa-quran", GroupName = "duotone light regular solid")]
        IconQuran = '\uf687',
        
        /// <summary>
        ///     Radiation ("fa-radiation", \uf7b9) icon.
        /// </summary>
        /// 
        [Display(Name = "Radiation", Description = "fa-radiation", GroupName = "duotone light regular solid")]
        IconRadiation = '\uf7b9',
        
        /// <summary>
        ///     Radiation Alt ("fa-radiation-alt", \uf7ba) icon.
        /// </summary>
        /// 
        [Display(Name = "Radiation Alt", Description = "fa-radiation-alt", GroupName = "duotone light regular solid")]
        IconRadiationAlt = '\uf7ba',
        
        /// <summary>
        ///     Rainbow ("fa-rainbow", \uf75b) icon.
        /// </summary>
        /// 
        [Display(Name = "Rainbow", Description = "fa-rainbow", GroupName = "duotone light regular solid")]
        IconRainbow = '\uf75b',
        
        /// <summary>
        ///     Random ("fa-random", \uf074) icon.
        /// </summary>
        /// 
        [Display(Name = "Random", Description = "fa-random", GroupName = "duotone light regular solid")]
        IconRandom = '\uf074',
        
        /// <summary>
        ///     Raspberry Pi ("fa-raspberry-pi", \uf7bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Raspberry Pi", Description = "fa-raspberry-pi", GroupName = "brands")]
        IconRaspberryPi = '\uf7bb',
        
        /// <summary>
        ///     Ravelry ("fa-ravelry", \uf2d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Ravelry", Description = "fa-ravelry", GroupName = "brands")]
        IconRavelry = '\uf2d9',
        
        /// <summary>
        ///     React ("fa-react", \uf41b) icon.
        /// </summary>
        /// 
        [Display(Name = "React", Description = "fa-react", GroupName = "brands")]
        IconReact = '\uf41b',
        
        /// <summary>
        ///     Reacteurope ("fa-reacteurope", \uf75d) icon.
        /// </summary>
        /// 
        [Display(Name = "Reacteurope", Description = "fa-reacteurope", GroupName = "brands")]
        IconReacteurope = '\uf75d',
        
        /// <summary>
        ///     Readme ("fa-readme", \uf4d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Readme", Description = "fa-readme", GroupName = "brands")]
        IconReadme = '\uf4d5',
        
        /// <summary>
        ///     Rebel ("fa-rebel", \uf1d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Rebel", Description = "fa-rebel", GroupName = "brands")]
        IconRebel = '\uf1d0',
        
        /// <summary>
        ///     Receipt ("fa-receipt", \uf543) icon.
        /// </summary>
        /// 
        [Display(Name = "Receipt", Description = "fa-receipt", GroupName = "duotone light regular solid")]
        IconReceipt = '\uf543',
        
        /// <summary>
        ///     Record Vinyl ("fa-record-vinyl", \uf8d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Record Vinyl", Description = "fa-record-vinyl", GroupName = "duotone light regular solid")]
        IconRecordVinyl = '\uf8d9',
        
        /// <summary>
        ///     Recycle ("fa-recycle", \uf1b8) icon.
        /// </summary>
        /// 
        [Display(Name = "Recycle", Description = "fa-recycle", GroupName = "duotone light regular solid")]
        IconRecycle = '\uf1b8',
        
        /// <summary>
        ///     Reddit ("fa-reddit", \uf1a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Reddit", Description = "fa-reddit", GroupName = "brands")]
        IconReddit = '\uf1a1',
        
        /// <summary>
        ///     Reddit Alien ("fa-reddit-alien", \uf281) icon.
        /// </summary>
        /// 
        [Display(Name = "Reddit Alien", Description = "fa-reddit-alien", GroupName = "brands")]
        IconRedditAlien = '\uf281',
        
        /// <summary>
        ///     Reddit Square ("fa-reddit-square", \uf1a2) icon.
        /// </summary>
        /// 
        [Display(Name = "Reddit Square", Description = "fa-reddit-square", GroupName = "brands")]
        IconRedditSquare = '\uf1a2',
        
        /// <summary>
        ///     Redhat ("fa-redhat", \uf7bc) icon.
        /// </summary>
        /// 
        [Display(Name = "Redhat", Description = "fa-redhat", GroupName = "brands")]
        IconRedhat = '\uf7bc',
        
        /// <summary>
        ///     Redo ("fa-redo", \uf01e) icon.
        /// </summary>
        /// 
        [Display(Name = "Redo", Description = "fa-redo", GroupName = "duotone light regular solid")]
        IconRedo = '\uf01e',
        
        /// <summary>
        ///     Redo Alt ("fa-redo-alt", \uf2f9) icon.
        /// </summary>
        /// 
        [Display(Name = "Redo Alt", Description = "fa-redo-alt", GroupName = "duotone light regular solid")]
        IconRedoAlt = '\uf2f9',
        
        /// <summary>
        ///     Red River ("fa-red-river", \uf3e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Red River", Description = "fa-red-river", GroupName = "brands")]
        IconRedRiver = '\uf3e3',
        
        /// <summary>
        ///     Registered ("fa-registered", \uf25d) icon.
        /// </summary>
        /// 
        [Display(Name = "Registered", Description = "fa-registered", GroupName = "duotone light regular solid")]
        IconRegistered = '\uf25d',
        
        /// <summary>
        ///     Remove Format ("fa-remove-format", \uf87d) icon.
        /// </summary>
        /// 
        [Display(Name = "Remove Format", Description = "fa-remove-format", GroupName = "duotone light regular solid")]
        IconRemoveFormat = '\uf87d',
        
        /// <summary>
        ///     Renren ("fa-renren", \uf18b) icon.
        /// </summary>
        /// 
        [Display(Name = "Renren", Description = "fa-renren", GroupName = "brands")]
        IconRenren = '\uf18b',
        
        /// <summary>
        ///     Reply ("fa-reply", \uf3e5) icon.
        /// </summary>
        /// 
        [Display(Name = "Reply", Description = "fa-reply", GroupName = "duotone light regular solid")]
        IconReply = '\uf3e5',
        
        /// <summary>
        ///     Reply All ("fa-reply-all", \uf122) icon.
        /// </summary>
        /// 
        [Display(Name = "Reply All", Description = "fa-reply-all", GroupName = "duotone light regular solid")]
        IconReplyAll = '\uf122',
        
        /// <summary>
        ///     Replyd ("fa-replyd", \uf3e6) icon.
        /// </summary>
        /// 
        [Display(Name = "Replyd", Description = "fa-replyd", GroupName = "brands")]
        IconReplyd = '\uf3e6',
        
        /// <summary>
        ///     Republican ("fa-republican", \uf75e) icon.
        /// </summary>
        /// 
        [Display(Name = "Republican", Description = "fa-republican", GroupName = "duotone light regular solid")]
        IconRepublican = '\uf75e',
        
        /// <summary>
        ///     Researchgate ("fa-researchgate", \uf4f8) icon.
        /// </summary>
        /// 
        [Display(Name = "Researchgate", Description = "fa-researchgate", GroupName = "brands")]
        IconResearchgate = '\uf4f8',
        
        /// <summary>
        ///     Resolving ("fa-resolving", \uf3e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Resolving", Description = "fa-resolving", GroupName = "brands")]
        IconResolving = '\uf3e7',
        
        /// <summary>
        ///     Restroom ("fa-restroom", \uf7bd) icon.
        /// </summary>
        /// 
        [Display(Name = "Restroom", Description = "fa-restroom", GroupName = "duotone light regular solid")]
        IconRestroom = '\uf7bd',
        
        /// <summary>
        ///     Retweet ("fa-retweet", \uf079) icon.
        /// </summary>
        /// 
        [Display(Name = "Retweet", Description = "fa-retweet", GroupName = "duotone light regular solid")]
        IconRetweet = '\uf079',
        
        /// <summary>
        ///     Rev ("fa-rev", \uf5b2) icon.
        /// </summary>
        /// 
        [Display(Name = "Rev", Description = "fa-rev", GroupName = "brands")]
        IconRev = '\uf5b2',
        
        /// <summary>
        ///     Ribbon ("fa-ribbon", \uf4d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Ribbon", Description = "fa-ribbon", GroupName = "duotone light regular solid")]
        IconRibbon = '\uf4d6',
        
        /// <summary>
        ///     Ring ("fa-ring", \uf70b) icon.
        /// </summary>
        /// 
        [Display(Name = "Ring", Description = "fa-ring", GroupName = "duotone light regular solid")]
        IconRing = '\uf70b',
        
        /// <summary>
        ///     Road ("fa-road", \uf018) icon.
        /// </summary>
        /// 
        [Display(Name = "Road", Description = "fa-road", GroupName = "duotone light regular solid")]
        IconRoad = '\uf018',
        
        /// <summary>
        ///     Robot ("fa-robot", \uf544) icon.
        /// </summary>
        /// 
        [Display(Name = "Robot", Description = "fa-robot", GroupName = "duotone light regular solid")]
        IconRobot = '\uf544',
        
        /// <summary>
        ///     Rocket ("fa-rocket", \uf135) icon.
        /// </summary>
        /// 
        [Display(Name = "Rocket", Description = "fa-rocket", GroupName = "duotone light regular solid")]
        IconRocket = '\uf135',
        
        /// <summary>
        ///     Rocketchat ("fa-rocketchat", \uf3e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Rocketchat", Description = "fa-rocketchat", GroupName = "brands")]
        IconRocketchat = '\uf3e8',
        
        /// <summary>
        ///     Rockrms ("fa-rockrms", \uf3e9) icon.
        /// </summary>
        /// 
        [Display(Name = "Rockrms", Description = "fa-rockrms", GroupName = "brands")]
        IconRockrms = '\uf3e9',
        
        /// <summary>
        ///     Route ("fa-route", \uf4d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Route", Description = "fa-route", GroupName = "duotone light regular solid")]
        IconRoute = '\uf4d7',
        
        /// <summary>
        ///     R Project ("fa-r-project", \uf4f7) icon.
        /// </summary>
        /// 
        [Display(Name = "R Project", Description = "fa-r-project", GroupName = "brands")]
        IconRProject = '\uf4f7',
        
        /// <summary>
        ///     Rss ("fa-rss", \uf09e) icon.
        /// </summary>
        /// 
        [Display(Name = "Rss", Description = "fa-rss", GroupName = "duotone light regular solid")]
        IconRss = '\uf09e',
        
        /// <summary>
        ///     Rss Square ("fa-rss-square", \uf143) icon.
        /// </summary>
        /// 
        [Display(Name = "Rss Square", Description = "fa-rss-square", GroupName = "duotone light regular solid")]
        IconRssSquare = '\uf143',
        
        /// <summary>
        ///     Ruble Sign ("fa-ruble-sign", \uf158) icon.
        /// </summary>
        /// 
        [Display(Name = "Ruble Sign", Description = "fa-ruble-sign", GroupName = "duotone light regular solid")]
        IconRubleSign = '\uf158',
        
        /// <summary>
        ///     Ruler ("fa-ruler", \uf545) icon.
        /// </summary>
        /// 
        [Display(Name = "Ruler", Description = "fa-ruler", GroupName = "duotone light regular solid")]
        IconRuler = '\uf545',
        
        /// <summary>
        ///     Ruler Combined ("fa-ruler-combined", \uf546) icon.
        /// </summary>
        /// 
        [Display(Name = "Ruler Combined", Description = "fa-ruler-combined", GroupName = "duotone light regular solid")]
        IconRulerCombined = '\uf546',
        
        /// <summary>
        ///     Ruler Horizontal ("fa-ruler-horizontal", \uf547) icon.
        /// </summary>
        /// 
        [Display(Name = "Ruler Horizontal", Description = "fa-ruler-horizontal", GroupName = "duotone light regular solid")]
        IconRulerHorizontal = '\uf547',
        
        /// <summary>
        ///     Ruler Vertical ("fa-ruler-vertical", \uf548) icon.
        /// </summary>
        /// 
        [Display(Name = "Ruler Vertical", Description = "fa-ruler-vertical", GroupName = "duotone light regular solid")]
        IconRulerVertical = '\uf548',
        
        /// <summary>
        ///     Running ("fa-running", \uf70c) icon.
        /// </summary>
        /// 
        [Display(Name = "Running", Description = "fa-running", GroupName = "duotone light regular solid")]
        IconRunning = '\uf70c',
        
        /// <summary>
        ///     Rupee Sign ("fa-rupee-sign", \uf156) icon.
        /// </summary>
        /// 
        [Display(Name = "Rupee Sign", Description = "fa-rupee-sign", GroupName = "duotone light regular solid")]
        IconRupeeSign = '\uf156',
        
        /// <summary>
        ///     Sad Cry ("fa-sad-cry", \uf5b3) icon.
        /// </summary>
        /// 
        [Display(Name = "Sad Cry", Description = "fa-sad-cry", GroupName = "duotone light regular solid")]
        IconSadCry = '\uf5b3',
        
        /// <summary>
        ///     Sad Tear ("fa-sad-tear", \uf5b4) icon.
        /// </summary>
        /// 
        [Display(Name = "Sad Tear", Description = "fa-sad-tear", GroupName = "duotone light regular solid")]
        IconSadTear = '\uf5b4',
        
        /// <summary>
        ///     Safari ("fa-safari", \uf267) icon.
        /// </summary>
        /// 
        [Display(Name = "Safari", Description = "fa-safari", GroupName = "brands")]
        IconSafari = '\uf267',
        
        /// <summary>
        ///     Salesforce ("fa-salesforce", \uf83b) icon.
        /// </summary>
        /// 
        [Display(Name = "Salesforce", Description = "fa-salesforce", GroupName = "brands")]
        IconSalesforce = '\uf83b',
        
        /// <summary>
        ///     Sass ("fa-sass", \uf41e) icon.
        /// </summary>
        /// 
        [Display(Name = "Sass", Description = "fa-sass", GroupName = "brands")]
        IconSass = '\uf41e',
        
        /// <summary>
        ///     Satellite ("fa-satellite", \uf7bf) icon.
        /// </summary>
        /// 
        [Display(Name = "Satellite", Description = "fa-satellite", GroupName = "duotone light regular solid")]
        IconSatellite = '\uf7bf',
        
        /// <summary>
        ///     Satellite Dish ("fa-satellite-dish", \uf7c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Satellite Dish", Description = "fa-satellite-dish", GroupName = "duotone light regular solid")]
        IconSatelliteDish = '\uf7c0',
        
        /// <summary>
        ///     Save ("fa-save", \uf0c7) icon.
        /// </summary>
        /// 
        [Display(Name = "Save", Description = "fa-save", GroupName = "duotone light regular solid")]
        IconSave = '\uf0c7',
        
        /// <summary>
        ///     Schlix ("fa-schlix", \uf3ea) icon.
        /// </summary>
        /// 
        [Display(Name = "Schlix", Description = "fa-schlix", GroupName = "brands")]
        IconSchlix = '\uf3ea',
        
        /// <summary>
        ///     School ("fa-school", \uf549) icon.
        /// </summary>
        /// 
        [Display(Name = "School", Description = "fa-school", GroupName = "duotone light regular solid")]
        IconSchool = '\uf549',
        
        /// <summary>
        ///     Screwdriver ("fa-screwdriver", \uf54a) icon.
        /// </summary>
        /// 
        [Display(Name = "Screwdriver", Description = "fa-screwdriver", GroupName = "duotone light regular solid")]
        IconScrewdriver = '\uf54a',
        
        /// <summary>
        ///     Scribd ("fa-scribd", \uf28a) icon.
        /// </summary>
        /// 
        [Display(Name = "Scribd", Description = "fa-scribd", GroupName = "brands")]
        IconScribd = '\uf28a',
        
        /// <summary>
        ///     Scroll ("fa-scroll", \uf70e) icon.
        /// </summary>
        /// 
        [Display(Name = "Scroll", Description = "fa-scroll", GroupName = "duotone light regular solid")]
        IconScroll = '\uf70e',
        
        /// <summary>
        ///     Sd Card ("fa-sd-card", \uf7c2) icon.
        /// </summary>
        /// 
        [Display(Name = "Sd Card", Description = "fa-sd-card", GroupName = "duotone light regular solid")]
        IconSdCard = '\uf7c2',
        
        /// <summary>
        ///     Search ("fa-search", \uf002) icon.
        /// </summary>
        /// 
        [Display(Name = "Search", Description = "fa-search", GroupName = "duotone light regular solid")]
        IconSearch = '\uf002',
        
        /// <summary>
        ///     Search Dollar ("fa-search-dollar", \uf688) icon.
        /// </summary>
        /// 
        [Display(Name = "Search Dollar", Description = "fa-search-dollar", GroupName = "duotone light regular solid")]
        IconSearchDollar = '\uf688',
        
        /// <summary>
        ///     Searchengin ("fa-searchengin", \uf3eb) icon.
        /// </summary>
        /// 
        [Display(Name = "Searchengin", Description = "fa-searchengin", GroupName = "brands")]
        IconSearchengin = '\uf3eb',
        
        /// <summary>
        ///     Search Location ("fa-search-location", \uf689) icon.
        /// </summary>
        /// 
        [Display(Name = "Search Location", Description = "fa-search-location", GroupName = "duotone light regular solid")]
        IconSearchLocation = '\uf689',
        
        /// <summary>
        ///     Search Minus ("fa-search-minus", \uf010) icon.
        /// </summary>
        /// 
        [Display(Name = "Search Minus", Description = "fa-search-minus", GroupName = "duotone light regular solid")]
        IconSearchMinus = '\uf010',
        
        /// <summary>
        ///     Search Plus ("fa-search-plus", \uf00e) icon.
        /// </summary>
        /// 
        [Display(Name = "Search Plus", Description = "fa-search-plus", GroupName = "duotone light regular solid")]
        IconSearchPlus = '\uf00e',
        
        /// <summary>
        ///     Seedling ("fa-seedling", \uf4d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Seedling", Description = "fa-seedling", GroupName = "duotone light regular solid")]
        IconSeedling = '\uf4d8',
        
        /// <summary>
        ///     Sellcast ("fa-sellcast", \uf2da) icon.
        /// </summary>
        /// 
        [Display(Name = "Sellcast", Description = "fa-sellcast", GroupName = "brands")]
        IconSellcast = '\uf2da',
        
        /// <summary>
        ///     Sellsy ("fa-sellsy", \uf213) icon.
        /// </summary>
        /// 
        [Display(Name = "Sellsy", Description = "fa-sellsy", GroupName = "brands")]
        IconSellsy = '\uf213',
        
        /// <summary>
        ///     Server ("fa-server", \uf233) icon.
        /// </summary>
        /// 
        [Display(Name = "Server", Description = "fa-server", GroupName = "duotone light regular solid")]
        IconServer = '\uf233',
        
        /// <summary>
        ///     Servicestack ("fa-servicestack", \uf3ec) icon.
        /// </summary>
        /// 
        [Display(Name = "Servicestack", Description = "fa-servicestack", GroupName = "brands")]
        IconServicestack = '\uf3ec',
        
        /// <summary>
        ///     Shapes ("fa-shapes", \uf61f) icon.
        /// </summary>
        /// 
        [Display(Name = "Shapes", Description = "fa-shapes", GroupName = "duotone light regular solid")]
        IconShapes = '\uf61f',
        
        /// <summary>
        ///     Share ("fa-share", \uf064) icon.
        /// </summary>
        /// 
        [Display(Name = "Share", Description = "fa-share", GroupName = "duotone light regular solid")]
        IconShare = '\uf064',
        
        /// <summary>
        ///     Share Alt ("fa-share-alt", \uf1e0) icon.
        /// </summary>
        /// 
        [Display(Name = "Share Alt", Description = "fa-share-alt", GroupName = "duotone light regular solid")]
        IconShareAlt = '\uf1e0',
        
        /// <summary>
        ///     Share Alt Square ("fa-share-alt-square", \uf1e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Share Alt Square", Description = "fa-share-alt-square", GroupName = "duotone light regular solid")]
        IconShareAltSquare = '\uf1e1',
        
        /// <summary>
        ///     Share Square ("fa-share-square", \uf14d) icon.
        /// </summary>
        /// 
        [Display(Name = "Share Square", Description = "fa-share-square", GroupName = "duotone light regular solid")]
        IconShareSquare = '\uf14d',
        
        /// <summary>
        ///     Shekel Sign ("fa-shekel-sign", \uf20b) icon.
        /// </summary>
        /// 
        [Display(Name = "Shekel Sign", Description = "fa-shekel-sign", GroupName = "duotone light regular solid")]
        IconShekelSign = '\uf20b',
        
        /// <summary>
        ///     Shield Alt ("fa-shield-alt", \uf3ed) icon.
        /// </summary>
        /// 
        [Display(Name = "Shield Alt", Description = "fa-shield-alt", GroupName = "duotone light regular solid")]
        IconShieldAlt = '\uf3ed',
        
        /// <summary>
        ///     Shield Virus ("fa-shield-virus", \uf96c) icon.
        /// </summary>
        /// 
        [Display(Name = "Shield Virus", Description = "fa-shield-virus", GroupName = "duotone light regular solid")]
        IconShieldVirus = '\uf96c',
        
        /// <summary>
        ///     Ship ("fa-ship", \uf21a) icon.
        /// </summary>
        /// 
        [Display(Name = "Ship", Description = "fa-ship", GroupName = "duotone light regular solid")]
        IconShip = '\uf21a',
        
        /// <summary>
        ///     Shipping Fast ("fa-shipping-fast", \uf48b) icon.
        /// </summary>
        /// 
        [Display(Name = "Shipping Fast", Description = "fa-shipping-fast", GroupName = "duotone light regular solid")]
        IconShippingFast = '\uf48b',
        
        /// <summary>
        ///     Shirtsinbulk ("fa-shirtsinbulk", \uf214) icon.
        /// </summary>
        /// 
        [Display(Name = "Shirtsinbulk", Description = "fa-shirtsinbulk", GroupName = "brands")]
        IconShirtsinbulk = '\uf214',
        
        /// <summary>
        ///     Shoe Prints ("fa-shoe-prints", \uf54b) icon.
        /// </summary>
        /// 
        [Display(Name = "Shoe Prints", Description = "fa-shoe-prints", GroupName = "duotone light regular solid")]
        IconShoePrints = '\uf54b',
        
        /// <summary>
        ///     Shopify ("fa-shopify", \uf957) icon.
        /// </summary>
        /// 
        [Display(Name = "Shopify", Description = "fa-shopify", GroupName = "brands")]
        IconShopify = '\uf957',
        
        /// <summary>
        ///     Shopping Bag ("fa-shopping-bag", \uf290) icon.
        /// </summary>
        /// 
        [Display(Name = "Shopping Bag", Description = "fa-shopping-bag", GroupName = "duotone light regular solid")]
        IconShoppingBag = '\uf290',
        
        /// <summary>
        ///     Shopping Basket ("fa-shopping-basket", \uf291) icon.
        /// </summary>
        /// 
        [Display(Name = "Shopping Basket", Description = "fa-shopping-basket", GroupName = "duotone light regular solid")]
        IconShoppingBasket = '\uf291',
        
        /// <summary>
        ///     Shopping Cart ("fa-shopping-cart", \uf07a) icon.
        /// </summary>
        /// 
        [Display(Name = "Shopping Cart", Description = "fa-shopping-cart", GroupName = "duotone light regular solid")]
        IconShoppingCart = '\uf07a',
        
        /// <summary>
        ///     Shopware ("fa-shopware", \uf5b5) icon.
        /// </summary>
        /// 
        [Display(Name = "Shopware", Description = "fa-shopware", GroupName = "brands")]
        IconShopware = '\uf5b5',
        
        /// <summary>
        ///     Shower ("fa-shower", \uf2cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Shower", Description = "fa-shower", GroupName = "duotone light regular solid")]
        IconShower = '\uf2cc',
        
        /// <summary>
        ///     Shuttle Van ("fa-shuttle-van", \uf5b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Shuttle Van", Description = "fa-shuttle-van", GroupName = "duotone light regular solid")]
        IconShuttleVan = '\uf5b6',
        
        /// <summary>
        ///     Sign ("fa-sign", \uf4d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Sign", Description = "fa-sign", GroupName = "duotone light regular solid")]
        IconSign = '\uf4d9',
        
        /// <summary>
        ///     Signal ("fa-signal", \uf012) icon.
        /// </summary>
        /// 
        [Display(Name = "Signal", Description = "fa-signal", GroupName = "duotone light regular solid")]
        IconSignal = '\uf012',
        
        /// <summary>
        ///     Signature ("fa-signature", \uf5b7) icon.
        /// </summary>
        /// 
        [Display(Name = "Signature", Description = "fa-signature", GroupName = "duotone light regular solid")]
        IconSignature = '\uf5b7',
        
        /// <summary>
        ///     Sign In Alt ("fa-sign-in-alt", \uf2f6) icon.
        /// </summary>
        /// 
        [Display(Name = "Sign In Alt", Description = "fa-sign-in-alt", GroupName = "duotone light regular solid")]
        IconSignInAlt = '\uf2f6',
        
        /// <summary>
        ///     Sign Language ("fa-sign-language", \uf2a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Sign Language", Description = "fa-sign-language", GroupName = "duotone light regular solid")]
        IconSignLanguage = '\uf2a7',
        
        /// <summary>
        ///     Sign Out Alt ("fa-sign-out-alt", \uf2f5) icon.
        /// </summary>
        /// 
        [Display(Name = "Sign Out Alt", Description = "fa-sign-out-alt", GroupName = "duotone light regular solid")]
        IconSignOutAlt = '\uf2f5',
        
        /// <summary>
        ///     Sim Card ("fa-sim-card", \uf7c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Sim Card", Description = "fa-sim-card", GroupName = "duotone light regular solid")]
        IconSimCard = '\uf7c4',
        
        /// <summary>
        ///     Simplybuilt ("fa-simplybuilt", \uf215) icon.
        /// </summary>
        /// 
        [Display(Name = "Simplybuilt", Description = "fa-simplybuilt", GroupName = "brands")]
        IconSimplybuilt = '\uf215',
        
        /// <summary>
        ///     Sistrix ("fa-sistrix", \uf3ee) icon.
        /// </summary>
        /// 
        [Display(Name = "Sistrix", Description = "fa-sistrix", GroupName = "brands")]
        IconSistrix = '\uf3ee',
        
        /// <summary>
        ///     Sitemap ("fa-sitemap", \uf0e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Sitemap", Description = "fa-sitemap", GroupName = "duotone light regular solid")]
        IconSitemap = '\uf0e8',
        
        /// <summary>
        ///     Sith ("fa-sith", \uf512) icon.
        /// </summary>
        /// 
        [Display(Name = "Sith", Description = "fa-sith", GroupName = "brands")]
        IconSith = '\uf512',
        
        /// <summary>
        ///     Skating ("fa-skating", \uf7c5) icon.
        /// </summary>
        /// 
        [Display(Name = "Skating", Description = "fa-skating", GroupName = "duotone light regular solid")]
        IconSkating = '\uf7c5',
        
        /// <summary>
        ///     Sketch ("fa-sketch", \uf7c6) icon.
        /// </summary>
        /// 
        [Display(Name = "Sketch", Description = "fa-sketch", GroupName = "brands")]
        IconSketch = '\uf7c6',
        
        /// <summary>
        ///     Skiing ("fa-skiing", \uf7c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Skiing", Description = "fa-skiing", GroupName = "duotone light regular solid")]
        IconSkiing = '\uf7c9',
        
        /// <summary>
        ///     Skiing Nordic ("fa-skiing-nordic", \uf7ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Skiing Nordic", Description = "fa-skiing-nordic", GroupName = "duotone light regular solid")]
        IconSkiingNordic = '\uf7ca',
        
        /// <summary>
        ///     Skull ("fa-skull", \uf54c) icon.
        /// </summary>
        /// 
        [Display(Name = "Skull", Description = "fa-skull", GroupName = "duotone light regular solid")]
        IconSkull = '\uf54c',
        
        /// <summary>
        ///     Skull Crossbones ("fa-skull-crossbones", \uf714) icon.
        /// </summary>
        /// 
        [Display(Name = "Skull Crossbones", Description = "fa-skull-crossbones", GroupName = "duotone light regular solid")]
        IconSkullCrossbones = '\uf714',
        
        /// <summary>
        ///     Skyatlas ("fa-skyatlas", \uf216) icon.
        /// </summary>
        /// 
        [Display(Name = "Skyatlas", Description = "fa-skyatlas", GroupName = "brands")]
        IconSkyatlas = '\uf216',
        
        /// <summary>
        ///     Skype ("fa-skype", \uf17e) icon.
        /// </summary>
        /// 
        [Display(Name = "Skype", Description = "fa-skype", GroupName = "brands")]
        IconSkype = '\uf17e',
        
        /// <summary>
        ///     Slack ("fa-slack", \uf198) icon.
        /// </summary>
        /// 
        [Display(Name = "Slack", Description = "fa-slack", GroupName = "brands")]
        IconSlack = '\uf198',
        
        /// <summary>
        ///     Slack Hash ("fa-slack-hash", \uf3ef) icon.
        /// </summary>
        /// 
        [Display(Name = "Slack Hash", Description = "fa-slack-hash", GroupName = "brands")]
        IconSlackHash = '\uf3ef',
        
        /// <summary>
        ///     Slash ("fa-slash", \uf715) icon.
        /// </summary>
        /// 
        [Display(Name = "Slash", Description = "fa-slash", GroupName = "duotone light regular solid")]
        IconSlash = '\uf715',
        
        /// <summary>
        ///     Sleigh ("fa-sleigh", \uf7cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Sleigh", Description = "fa-sleigh", GroupName = "duotone light regular solid")]
        IconSleigh = '\uf7cc',
        
        /// <summary>
        ///     Sliders H ("fa-sliders-h", \uf1de) icon.
        /// </summary>
        /// 
        [Display(Name = "Sliders H", Description = "fa-sliders-h", GroupName = "duotone light regular solid")]
        IconSlidersH = '\uf1de',
        
        /// <summary>
        ///     Slideshare ("fa-slideshare", \uf1e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Slideshare", Description = "fa-slideshare", GroupName = "brands")]
        IconSlideshare = '\uf1e7',
        
        /// <summary>
        ///     Smile ("fa-smile", \uf118) icon.
        /// </summary>
        /// 
        [Display(Name = "Smile", Description = "fa-smile", GroupName = "duotone light regular solid")]
        IconSmile = '\uf118',
        
        /// <summary>
        ///     Smile Beam ("fa-smile-beam", \uf5b8) icon.
        /// </summary>
        /// 
        [Display(Name = "Smile Beam", Description = "fa-smile-beam", GroupName = "duotone light regular solid")]
        IconSmileBeam = '\uf5b8',
        
        /// <summary>
        ///     Smile Wink ("fa-smile-wink", \uf4da) icon.
        /// </summary>
        /// 
        [Display(Name = "Smile Wink", Description = "fa-smile-wink", GroupName = "duotone light regular solid")]
        IconSmileWink = '\uf4da',
        
        /// <summary>
        ///     Smog ("fa-smog", \uf75f) icon.
        /// </summary>
        /// 
        [Display(Name = "Smog", Description = "fa-smog", GroupName = "duotone light regular solid")]
        IconSmog = '\uf75f',
        
        /// <summary>
        ///     Smoking ("fa-smoking", \uf48d) icon.
        /// </summary>
        /// 
        [Display(Name = "Smoking", Description = "fa-smoking", GroupName = "duotone light regular solid")]
        IconSmoking = '\uf48d',
        
        /// <summary>
        ///     Smoking Ban ("fa-smoking-ban", \uf54d) icon.
        /// </summary>
        /// 
        [Display(Name = "Smoking Ban", Description = "fa-smoking-ban", GroupName = "duotone light regular solid")]
        IconSmokingBan = '\uf54d',
        
        /// <summary>
        ///     Sms ("fa-sms", \uf7cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Sms", Description = "fa-sms", GroupName = "duotone light regular solid")]
        IconSms = '\uf7cd',
        
        /// <summary>
        ///     Snapchat ("fa-snapchat", \uf2ab) icon.
        /// </summary>
        /// 
        [Display(Name = "Snapchat", Description = "fa-snapchat", GroupName = "brands")]
        IconSnapchat = '\uf2ab',
        
        /// <summary>
        ///     Snapchat Ghost ("fa-snapchat-ghost", \uf2ac) icon.
        /// </summary>
        /// 
        [Display(Name = "Snapchat Ghost", Description = "fa-snapchat-ghost", GroupName = "brands")]
        IconSnapchatGhost = '\uf2ac',
        
        /// <summary>
        ///     Snapchat Square ("fa-snapchat-square", \uf2ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Snapchat Square", Description = "fa-snapchat-square", GroupName = "brands")]
        IconSnapchatSquare = '\uf2ad',
        
        /// <summary>
        ///     Snowboarding ("fa-snowboarding", \uf7ce) icon.
        /// </summary>
        /// 
        [Display(Name = "Snowboarding", Description = "fa-snowboarding", GroupName = "duotone light regular solid")]
        IconSnowboarding = '\uf7ce',
        
        /// <summary>
        ///     Snowflake ("fa-snowflake", \uf2dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Snowflake", Description = "fa-snowflake", GroupName = "duotone light regular solid")]
        IconSnowflake = '\uf2dc',
        
        /// <summary>
        ///     Snowman ("fa-snowman", \uf7d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Snowman", Description = "fa-snowman", GroupName = "duotone light regular solid")]
        IconSnowman = '\uf7d0',
        
        /// <summary>
        ///     Snowplow ("fa-snowplow", \uf7d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Snowplow", Description = "fa-snowplow", GroupName = "duotone light regular solid")]
        IconSnowplow = '\uf7d2',
        
        /// <summary>
        ///     Soap ("fa-soap", \uf96e) icon.
        /// </summary>
        /// 
        [Display(Name = "Soap", Description = "fa-soap", GroupName = "duotone light regular solid")]
        IconSoap = '\uf96e',
        
        /// <summary>
        ///     Socks ("fa-socks", \uf696) icon.
        /// </summary>
        /// 
        [Display(Name = "Socks", Description = "fa-socks", GroupName = "duotone light regular solid")]
        IconSocks = '\uf696',
        
        /// <summary>
        ///     Solar Panel ("fa-solar-panel", \uf5ba) icon.
        /// </summary>
        /// 
        [Display(Name = "Solar Panel", Description = "fa-solar-panel", GroupName = "duotone light regular solid")]
        IconSolarPanel = '\uf5ba',
        
        /// <summary>
        ///     Sort ("fa-sort", \uf0dc) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort", Description = "fa-sort", GroupName = "duotone light regular solid")]
        IconSort = '\uf0dc',
        
        /// <summary>
        ///     Sort Alpha Down ("fa-sort-alpha-down", \uf15d) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Alpha Down", Description = "fa-sort-alpha-down", GroupName = "duotone light regular solid")]
        IconSortAlphaDown = '\uf15d',
        
        /// <summary>
        ///     Sort Alpha Down Alt ("fa-sort-alpha-down-alt", \uf881) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Alpha Down Alt", Description = "fa-sort-alpha-down-alt", GroupName = "duotone light regular solid")]
        IconSortAlphaDownAlt = '\uf881',
        
        /// <summary>
        ///     Sort Alpha Up ("fa-sort-alpha-up", \uf15e) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Alpha Up", Description = "fa-sort-alpha-up", GroupName = "duotone light regular solid")]
        IconSortAlphaUp = '\uf15e',
        
        /// <summary>
        ///     Sort Alpha Up Alt ("fa-sort-alpha-up-alt", \uf882) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Alpha Up Alt", Description = "fa-sort-alpha-up-alt", GroupName = "duotone light regular solid")]
        IconSortAlphaUpAlt = '\uf882',
        
        /// <summary>
        ///     Sort Amount Down ("fa-sort-amount-down", \uf160) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Amount Down", Description = "fa-sort-amount-down", GroupName = "duotone light regular solid")]
        IconSortAmountDown = '\uf160',
        
        /// <summary>
        ///     Sort Amount Down Alt ("fa-sort-amount-down-alt", \uf884) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Amount Down Alt", Description = "fa-sort-amount-down-alt", GroupName = "duotone light regular solid")]
        IconSortAmountDownAlt = '\uf884',
        
        /// <summary>
        ///     Sort Amount Up ("fa-sort-amount-up", \uf161) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Amount Up", Description = "fa-sort-amount-up", GroupName = "duotone light regular solid")]
        IconSortAmountUp = '\uf161',
        
        /// <summary>
        ///     Sort Amount Up Alt ("fa-sort-amount-up-alt", \uf885) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Amount Up Alt", Description = "fa-sort-amount-up-alt", GroupName = "duotone light regular solid")]
        IconSortAmountUpAlt = '\uf885',
        
        /// <summary>
        ///     Sort Down ("fa-sort-down", \uf0dd) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Down", Description = "fa-sort-down", GroupName = "duotone light regular solid")]
        IconSortDown = '\uf0dd',
        
        /// <summary>
        ///     Sort Numeric Down ("fa-sort-numeric-down", \uf162) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Numeric Down", Description = "fa-sort-numeric-down", GroupName = "duotone light regular solid")]
        IconSortNumericDown = '\uf162',
        
        /// <summary>
        ///     Sort Numeric Down Alt ("fa-sort-numeric-down-alt", \uf886) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Numeric Down Alt", Description = "fa-sort-numeric-down-alt", GroupName = "duotone light regular solid")]
        IconSortNumericDownAlt = '\uf886',
        
        /// <summary>
        ///     Sort Numeric Up ("fa-sort-numeric-up", \uf163) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Numeric Up", Description = "fa-sort-numeric-up", GroupName = "duotone light regular solid")]
        IconSortNumericUp = '\uf163',
        
        /// <summary>
        ///     Sort Numeric Up Alt ("fa-sort-numeric-up-alt", \uf887) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Numeric Up Alt", Description = "fa-sort-numeric-up-alt", GroupName = "duotone light regular solid")]
        IconSortNumericUpAlt = '\uf887',
        
        /// <summary>
        ///     Sort Up ("fa-sort-up", \uf0de) icon.
        /// </summary>
        /// 
        [Display(Name = "Sort Up", Description = "fa-sort-up", GroupName = "duotone light regular solid")]
        IconSortUp = '\uf0de',
        
        /// <summary>
        ///     Soundcloud ("fa-soundcloud", \uf1be) icon.
        /// </summary>
        /// 
        [Display(Name = "Soundcloud", Description = "fa-soundcloud", GroupName = "brands")]
        IconSoundcloud = '\uf1be',
        
        /// <summary>
        ///     Sourcetree ("fa-sourcetree", \uf7d3) icon.
        /// </summary>
        /// 
        [Display(Name = "Sourcetree", Description = "fa-sourcetree", GroupName = "brands")]
        IconSourcetree = '\uf7d3',
        
        /// <summary>
        ///     Spa ("fa-spa", \uf5bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Spa", Description = "fa-spa", GroupName = "duotone light regular solid")]
        IconSpa = '\uf5bb',
        
        /// <summary>
        ///     Space Shuttle ("fa-space-shuttle", \uf197) icon.
        /// </summary>
        /// 
        [Display(Name = "Space Shuttle", Description = "fa-space-shuttle", GroupName = "duotone light regular solid")]
        IconSpaceShuttle = '\uf197',
        
        /// <summary>
        ///     Speakap ("fa-speakap", \uf3f3) icon.
        /// </summary>
        /// 
        [Display(Name = "Speakap", Description = "fa-speakap", GroupName = "brands")]
        IconSpeakap = '\uf3f3',
        
        /// <summary>
        ///     Speaker Deck ("fa-speaker-deck", \uf83c) icon.
        /// </summary>
        /// 
        [Display(Name = "Speaker Deck", Description = "fa-speaker-deck", GroupName = "brands")]
        IconSpeakerDeck = '\uf83c',
        
        /// <summary>
        ///     Spell Check ("fa-spell-check", \uf891) icon.
        /// </summary>
        /// 
        [Display(Name = "Spell Check", Description = "fa-spell-check", GroupName = "duotone light regular solid")]
        IconSpellCheck = '\uf891',
        
        /// <summary>
        ///     Spider ("fa-spider", \uf717) icon.
        /// </summary>
        /// 
        [Display(Name = "Spider", Description = "fa-spider", GroupName = "duotone light regular solid")]
        IconSpider = '\uf717',
        
        /// <summary>
        ///     Spinner ("fa-spinner", \uf110) icon.
        /// </summary>
        /// 
        [Display(Name = "Spinner", Description = "fa-spinner", GroupName = "duotone light regular solid")]
        IconSpinner = '\uf110',
        
        /// <summary>
        ///     Splotch ("fa-splotch", \uf5bc) icon.
        /// </summary>
        /// 
        [Display(Name = "Splotch", Description = "fa-splotch", GroupName = "duotone light regular solid")]
        IconSplotch = '\uf5bc',
        
        /// <summary>
        ///     Spotify ("fa-spotify", \uf1bc) icon.
        /// </summary>
        /// 
        [Display(Name = "Spotify", Description = "fa-spotify", GroupName = "brands")]
        IconSpotify = '\uf1bc',
        
        /// <summary>
        ///     Spray Can ("fa-spray-can", \uf5bd) icon.
        /// </summary>
        /// 
        [Display(Name = "Spray Can", Description = "fa-spray-can", GroupName = "duotone light regular solid")]
        IconSprayCan = '\uf5bd',
        
        /// <summary>
        ///     Square ("fa-square", \uf0c8) icon.
        /// </summary>
        /// 
        [Display(Name = "Square", Description = "fa-square", GroupName = "duotone light regular solid")]
        IconSquare = '\uf0c8',
        
        /// <summary>
        ///     Square Full ("fa-square-full", \uf45c) icon.
        /// </summary>
        /// 
        [Display(Name = "Square Full", Description = "fa-square-full", GroupName = "duotone light regular solid")]
        IconSquareFull = '\uf45c',
        
        /// <summary>
        ///     Square Root Alt ("fa-square-root-alt", \uf698) icon.
        /// </summary>
        /// 
        [Display(Name = "Square Root Alt", Description = "fa-square-root-alt", GroupName = "duotone light regular solid")]
        IconSquareRootAlt = '\uf698',
        
        /// <summary>
        ///     Squarespace ("fa-squarespace", \uf5be) icon.
        /// </summary>
        /// 
        [Display(Name = "Squarespace", Description = "fa-squarespace", GroupName = "brands")]
        IconSquarespace = '\uf5be',
        
        /// <summary>
        ///     Stack Exchange ("fa-stack-exchange", \uf18d) icon.
        /// </summary>
        /// 
        [Display(Name = "Stack Exchange", Description = "fa-stack-exchange", GroupName = "brands")]
        IconStackExchange = '\uf18d',
        
        /// <summary>
        ///     Stack Overflow ("fa-stack-overflow", \uf16c) icon.
        /// </summary>
        /// 
        [Display(Name = "Stack Overflow", Description = "fa-stack-overflow", GroupName = "brands")]
        IconStackOverflow = '\uf16c',
        
        /// <summary>
        ///     Stackpath ("fa-stackpath", \uf842) icon.
        /// </summary>
        /// 
        [Display(Name = "Stackpath", Description = "fa-stackpath", GroupName = "brands")]
        IconStackpath = '\uf842',
        
        /// <summary>
        ///     Stamp ("fa-stamp", \uf5bf) icon.
        /// </summary>
        /// 
        [Display(Name = "Stamp", Description = "fa-stamp", GroupName = "duotone light regular solid")]
        IconStamp = '\uf5bf',
        
        /// <summary>
        ///     Star ("fa-star", \uf005) icon.
        /// </summary>
        /// 
        [Display(Name = "Star", Description = "fa-star", GroupName = "duotone light regular solid")]
        IconStar = '\uf005',
        
        /// <summary>
        ///     Star And Crescent ("fa-star-and-crescent", \uf699) icon.
        /// </summary>
        /// 
        [Display(Name = "Star And Crescent", Description = "fa-star-and-crescent", GroupName = "duotone light regular solid")]
        IconStarAndCrescent = '\uf699',
        
        /// <summary>
        ///     Star Half ("fa-star-half", \uf089) icon.
        /// </summary>
        /// 
        [Display(Name = "Star Half", Description = "fa-star-half", GroupName = "duotone light regular solid")]
        IconStarHalf = '\uf089',
        
        /// <summary>
        ///     Star Half Alt ("fa-star-half-alt", \uf5c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Star Half Alt", Description = "fa-star-half-alt", GroupName = "duotone light regular solid")]
        IconStarHalfAlt = '\uf5c0',
        
        /// <summary>
        ///     Star Of David ("fa-star-of-david", \uf69a) icon.
        /// </summary>
        /// 
        [Display(Name = "Star Of David", Description = "fa-star-of-david", GroupName = "duotone light regular solid")]
        IconStarOfDavid = '\uf69a',
        
        /// <summary>
        ///     Star Of Life ("fa-star-of-life", \uf621) icon.
        /// </summary>
        /// 
        [Display(Name = "Star Of Life", Description = "fa-star-of-life", GroupName = "duotone light regular solid")]
        IconStarOfLife = '\uf621',
        
        /// <summary>
        ///     Staylinked ("fa-staylinked", \uf3f5) icon.
        /// </summary>
        /// 
        [Display(Name = "Staylinked", Description = "fa-staylinked", GroupName = "brands")]
        IconStaylinked = '\uf3f5',
        
        /// <summary>
        ///     Steam ("fa-steam", \uf1b6) icon.
        /// </summary>
        /// 
        [Display(Name = "Steam", Description = "fa-steam", GroupName = "brands")]
        IconSteam = '\uf1b6',
        
        /// <summary>
        ///     Steam Square ("fa-steam-square", \uf1b7) icon.
        /// </summary>
        /// 
        [Display(Name = "Steam Square", Description = "fa-steam-square", GroupName = "brands")]
        IconSteamSquare = '\uf1b7',
        
        /// <summary>
        ///     Steam Symbol ("fa-steam-symbol", \uf3f6) icon.
        /// </summary>
        /// 
        [Display(Name = "Steam Symbol", Description = "fa-steam-symbol", GroupName = "brands")]
        IconSteamSymbol = '\uf3f6',
        
        /// <summary>
        ///     Step Backward ("fa-step-backward", \uf048) icon.
        /// </summary>
        /// 
        [Display(Name = "Step Backward", Description = "fa-step-backward", GroupName = "duotone light regular solid")]
        IconStepBackward = '\uf048',
        
        /// <summary>
        ///     Step Forward ("fa-step-forward", \uf051) icon.
        /// </summary>
        /// 
        [Display(Name = "Step Forward", Description = "fa-step-forward", GroupName = "duotone light regular solid")]
        IconStepForward = '\uf051',
        
        /// <summary>
        ///     Stethoscope ("fa-stethoscope", \uf0f1) icon.
        /// </summary>
        /// 
        [Display(Name = "Stethoscope", Description = "fa-stethoscope", GroupName = "duotone light regular solid")]
        IconStethoscope = '\uf0f1',
        
        /// <summary>
        ///     Sticker Mule ("fa-sticker-mule", \uf3f7) icon.
        /// </summary>
        /// 
        [Display(Name = "Sticker Mule", Description = "fa-sticker-mule", GroupName = "brands")]
        IconStickerMule = '\uf3f7',
        
        /// <summary>
        ///     Sticky Note ("fa-sticky-note", \uf249) icon.
        /// </summary>
        /// 
        [Display(Name = "Sticky Note", Description = "fa-sticky-note", GroupName = "duotone light regular solid")]
        IconStickyNote = '\uf249',
        
        /// <summary>
        ///     Stop ("fa-stop", \uf04d) icon.
        /// </summary>
        /// 
        [Display(Name = "Stop", Description = "fa-stop", GroupName = "duotone light regular solid")]
        IconStop = '\uf04d',
        
        /// <summary>
        ///     Stop Circle ("fa-stop-circle", \uf28d) icon.
        /// </summary>
        /// 
        [Display(Name = "Stop Circle", Description = "fa-stop-circle", GroupName = "duotone light regular solid")]
        IconStopCircle = '\uf28d',
        
        /// <summary>
        ///     Stopwatch ("fa-stopwatch", \uf2f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Stopwatch", Description = "fa-stopwatch", GroupName = "duotone light regular solid")]
        IconStopwatch = '\uf2f2',
        
        /// <summary>
        ///     Stopwatch 20 ("fa-stopwatch-20", \uf96f) icon.
        /// </summary>
        /// 
        [Display(Name = "Stopwatch 20", Description = "fa-stopwatch-20", GroupName = "duotone light regular solid")]
        IconStopwatch20 = '\uf96f',
        
        /// <summary>
        ///     Store ("fa-store", \uf54e) icon.
        /// </summary>
        /// 
        [Display(Name = "Store", Description = "fa-store", GroupName = "duotone light regular solid")]
        IconStore = '\uf54e',
        
        /// <summary>
        ///     Store Alt ("fa-store-alt", \uf54f) icon.
        /// </summary>
        /// 
        [Display(Name = "Store Alt", Description = "fa-store-alt", GroupName = "duotone light regular solid")]
        IconStoreAlt = '\uf54f',
        
        /// <summary>
        ///     Store Alt Slash ("fa-store-alt-slash", \uf970) icon.
        /// </summary>
        /// 
        [Display(Name = "Store Alt Slash", Description = "fa-store-alt-slash", GroupName = "duotone light regular solid")]
        IconStoreAltSlash = '\uf970',
        
        /// <summary>
        ///     Store Slash ("fa-store-slash", \uf971) icon.
        /// </summary>
        /// 
        [Display(Name = "Store Slash", Description = "fa-store-slash", GroupName = "duotone light regular solid")]
        IconStoreSlash = '\uf971',
        
        /// <summary>
        ///     Strava ("fa-strava", \uf428) icon.
        /// </summary>
        /// 
        [Display(Name = "Strava", Description = "fa-strava", GroupName = "brands")]
        IconStrava = '\uf428',
        
        /// <summary>
        ///     Stream ("fa-stream", \uf550) icon.
        /// </summary>
        /// 
        [Display(Name = "Stream", Description = "fa-stream", GroupName = "duotone light regular solid")]
        IconStream = '\uf550',
        
        /// <summary>
        ///     Street View ("fa-street-view", \uf21d) icon.
        /// </summary>
        /// 
        [Display(Name = "Street View", Description = "fa-street-view", GroupName = "duotone light regular solid")]
        IconStreetView = '\uf21d',
        
        /// <summary>
        ///     Strikethrough ("fa-strikethrough", \uf0cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Strikethrough", Description = "fa-strikethrough", GroupName = "duotone light regular solid")]
        IconStrikethrough = '\uf0cc',
        
        /// <summary>
        ///     Stripe ("fa-stripe", \uf429) icon.
        /// </summary>
        /// 
        [Display(Name = "Stripe", Description = "fa-stripe", GroupName = "brands")]
        IconStripe = '\uf429',
        
        /// <summary>
        ///     Stripe S ("fa-stripe-s", \uf42a) icon.
        /// </summary>
        /// 
        [Display(Name = "Stripe S", Description = "fa-stripe-s", GroupName = "brands")]
        IconStripeS = '\uf42a',
        
        /// <summary>
        ///     Stroopwafel ("fa-stroopwafel", \uf551) icon.
        /// </summary>
        /// 
        [Display(Name = "Stroopwafel", Description = "fa-stroopwafel", GroupName = "duotone light regular solid")]
        IconStroopwafel = '\uf551',
        
        /// <summary>
        ///     Studiovinari ("fa-studiovinari", \uf3f8) icon.
        /// </summary>
        /// 
        [Display(Name = "Studiovinari", Description = "fa-studiovinari", GroupName = "brands")]
        IconStudiovinari = '\uf3f8',
        
        /// <summary>
        ///     Stumbleupon ("fa-stumbleupon", \uf1a4) icon.
        /// </summary>
        /// 
        [Display(Name = "Stumbleupon", Description = "fa-stumbleupon", GroupName = "brands")]
        IconStumbleupon = '\uf1a4',
        
        /// <summary>
        ///     Stumbleupon Circle ("fa-stumbleupon-circle", \uf1a3) icon.
        /// </summary>
        /// 
        [Display(Name = "Stumbleupon Circle", Description = "fa-stumbleupon-circle", GroupName = "brands")]
        IconStumbleuponCircle = '\uf1a3',
        
        /// <summary>
        ///     Subscript ("fa-subscript", \uf12c) icon.
        /// </summary>
        /// 
        [Display(Name = "Subscript", Description = "fa-subscript", GroupName = "duotone light regular solid")]
        IconSubscript = '\uf12c',
        
        /// <summary>
        ///     Subway ("fa-subway", \uf239) icon.
        /// </summary>
        /// 
        [Display(Name = "Subway", Description = "fa-subway", GroupName = "duotone light regular solid")]
        IconSubway = '\uf239',
        
        /// <summary>
        ///     Suitcase ("fa-suitcase", \uf0f2) icon.
        /// </summary>
        /// 
        [Display(Name = "Suitcase", Description = "fa-suitcase", GroupName = "duotone light regular solid")]
        IconSuitcase = '\uf0f2',
        
        /// <summary>
        ///     Suitcase Rolling ("fa-suitcase-rolling", \uf5c1) icon.
        /// </summary>
        /// 
        [Display(Name = "Suitcase Rolling", Description = "fa-suitcase-rolling", GroupName = "duotone light regular solid")]
        IconSuitcaseRolling = '\uf5c1',
        
        /// <summary>
        ///     Sun ("fa-sun", \uf185) icon.
        /// </summary>
        /// 
        [Display(Name = "Sun", Description = "fa-sun", GroupName = "duotone light regular solid")]
        IconSun = '\uf185',
        
        /// <summary>
        ///     Superpowers ("fa-superpowers", \uf2dd) icon.
        /// </summary>
        /// 
        [Display(Name = "Superpowers", Description = "fa-superpowers", GroupName = "brands")]
        IconSuperpowers = '\uf2dd',
        
        /// <summary>
        ///     Superscript ("fa-superscript", \uf12b) icon.
        /// </summary>
        /// 
        [Display(Name = "Superscript", Description = "fa-superscript", GroupName = "duotone light regular solid")]
        IconSuperscript = '\uf12b',
        
        /// <summary>
        ///     Supple ("fa-supple", \uf3f9) icon.
        /// </summary>
        /// 
        [Display(Name = "Supple", Description = "fa-supple", GroupName = "brands")]
        IconSupple = '\uf3f9',
        
        /// <summary>
        ///     Surprise ("fa-surprise", \uf5c2) icon.
        /// </summary>
        /// 
        [Display(Name = "Surprise", Description = "fa-surprise", GroupName = "duotone light regular solid")]
        IconSurprise = '\uf5c2',
        
        /// <summary>
        ///     Suse ("fa-suse", \uf7d6) icon.
        /// </summary>
        /// 
        [Display(Name = "Suse", Description = "fa-suse", GroupName = "brands")]
        IconSuse = '\uf7d6',
        
        /// <summary>
        ///     Swatchbook ("fa-swatchbook", \uf5c3) icon.
        /// </summary>
        /// 
        [Display(Name = "Swatchbook", Description = "fa-swatchbook", GroupName = "duotone light regular solid")]
        IconSwatchbook = '\uf5c3',
        
        /// <summary>
        ///     Swift ("fa-swift", \uf8e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Swift", Description = "fa-swift", GroupName = "brands")]
        IconSwift = '\uf8e1',
        
        /// <summary>
        ///     Swimmer ("fa-swimmer", \uf5c4) icon.
        /// </summary>
        /// 
        [Display(Name = "Swimmer", Description = "fa-swimmer", GroupName = "duotone light regular solid")]
        IconSwimmer = '\uf5c4',
        
        /// <summary>
        ///     Swimming Pool ("fa-swimming-pool", \uf5c5) icon.
        /// </summary>
        /// 
        [Display(Name = "Swimming Pool", Description = "fa-swimming-pool", GroupName = "duotone light regular solid")]
        IconSwimmingPool = '\uf5c5',
        
        /// <summary>
        ///     Symfony ("fa-symfony", \uf83d) icon.
        /// </summary>
        /// 
        [Display(Name = "Symfony", Description = "fa-symfony", GroupName = "brands")]
        IconSymfony = '\uf83d',
        
        /// <summary>
        ///     Synagogue ("fa-synagogue", \uf69b) icon.
        /// </summary>
        /// 
        [Display(Name = "Synagogue", Description = "fa-synagogue", GroupName = "duotone light regular solid")]
        IconSynagogue = '\uf69b',
        
        /// <summary>
        ///     Sync ("fa-sync", \uf021) icon.
        /// </summary>
        /// 
        [Display(Name = "Sync", Description = "fa-sync", GroupName = "duotone light regular solid")]
        IconSync = '\uf021',
        
        /// <summary>
        ///     Sync Alt ("fa-sync-alt", \uf2f1) icon.
        /// </summary>
        /// 
        [Display(Name = "Sync Alt", Description = "fa-sync-alt", GroupName = "duotone light regular solid")]
        IconSyncAlt = '\uf2f1',
        
        /// <summary>
        ///     Syringe ("fa-syringe", \uf48e) icon.
        /// </summary>
        /// 
        [Display(Name = "Syringe", Description = "fa-syringe", GroupName = "duotone light regular solid")]
        IconSyringe = '\uf48e',
        
        /// <summary>
        ///     Table ("fa-table", \uf0ce) icon.
        /// </summary>
        /// 
        [Display(Name = "Table", Description = "fa-table", GroupName = "duotone light regular solid")]
        IconTable = '\uf0ce',
        
        /// <summary>
        ///     Tablet ("fa-tablet", \uf10a) icon.
        /// </summary>
        /// 
        [Display(Name = "Tablet", Description = "fa-tablet", GroupName = "duotone light regular solid")]
        IconTablet = '\uf10a',
        
        /// <summary>
        ///     Tablet Alt ("fa-tablet-alt", \uf3fa) icon.
        /// </summary>
        /// 
        [Display(Name = "Tablet Alt", Description = "fa-tablet-alt", GroupName = "duotone light regular solid")]
        IconTabletAlt = '\uf3fa',
        
        /// <summary>
        ///     Table Tennis ("fa-table-tennis", \uf45d) icon.
        /// </summary>
        /// 
        [Display(Name = "Table Tennis", Description = "fa-table-tennis", GroupName = "duotone light regular solid")]
        IconTableTennis = '\uf45d',
        
        /// <summary>
        ///     Tablets ("fa-tablets", \uf490) icon.
        /// </summary>
        /// 
        [Display(Name = "Tablets", Description = "fa-tablets", GroupName = "duotone light regular solid")]
        IconTablets = '\uf490',
        
        /// <summary>
        ///     Tachometer Alt ("fa-tachometer-alt", \uf3fd) icon.
        /// </summary>
        /// 
        [Display(Name = "Tachometer Alt", Description = "fa-tachometer-alt", GroupName = "duotone light regular solid")]
        IconTachometerAlt = '\uf3fd',
        
        /// <summary>
        ///     Tag ("fa-tag", \uf02b) icon.
        /// </summary>
        /// 
        [Display(Name = "Tag", Description = "fa-tag", GroupName = "duotone light regular solid")]
        IconTag = '\uf02b',
        
        /// <summary>
        ///     Tags ("fa-tags", \uf02c) icon.
        /// </summary>
        /// 
        [Display(Name = "Tags", Description = "fa-tags", GroupName = "duotone light regular solid")]
        IconTags = '\uf02c',
        
        /// <summary>
        ///     Tape ("fa-tape", \uf4db) icon.
        /// </summary>
        /// 
        [Display(Name = "Tape", Description = "fa-tape", GroupName = "duotone light regular solid")]
        IconTape = '\uf4db',
        
        /// <summary>
        ///     Tasks ("fa-tasks", \uf0ae) icon.
        /// </summary>
        /// 
        [Display(Name = "Tasks", Description = "fa-tasks", GroupName = "duotone light regular solid")]
        IconTasks = '\uf0ae',
        
        /// <summary>
        ///     Taxi ("fa-taxi", \uf1ba) icon.
        /// </summary>
        /// 
        [Display(Name = "Taxi", Description = "fa-taxi", GroupName = "duotone light regular solid")]
        IconTaxi = '\uf1ba',
        
        /// <summary>
        ///     Teamspeak ("fa-teamspeak", \uf4f9) icon.
        /// </summary>
        /// 
        [Display(Name = "Teamspeak", Description = "fa-teamspeak", GroupName = "brands")]
        IconTeamspeak = '\uf4f9',
        
        /// <summary>
        ///     Teeth ("fa-teeth", \uf62e) icon.
        /// </summary>
        /// 
        [Display(Name = "Teeth", Description = "fa-teeth", GroupName = "duotone light regular solid")]
        IconTeeth = '\uf62e',
        
        /// <summary>
        ///     Teeth Open ("fa-teeth-open", \uf62f) icon.
        /// </summary>
        /// 
        [Display(Name = "Teeth Open", Description = "fa-teeth-open", GroupName = "duotone light regular solid")]
        IconTeethOpen = '\uf62f',
        
        /// <summary>
        ///     Telegram ("fa-telegram", \uf2c6) icon.
        /// </summary>
        /// 
        [Display(Name = "Telegram", Description = "fa-telegram", GroupName = "brands")]
        IconTelegram = '\uf2c6',
        
        /// <summary>
        ///     Telegram Plane ("fa-telegram-plane", \uf3fe) icon.
        /// </summary>
        /// 
        [Display(Name = "Telegram Plane", Description = "fa-telegram-plane", GroupName = "brands")]
        IconTelegramPlane = '\uf3fe',
        
        /// <summary>
        ///     Temperature High ("fa-temperature-high", \uf769) icon.
        /// </summary>
        /// 
        [Display(Name = "Temperature High", Description = "fa-temperature-high", GroupName = "duotone light regular solid")]
        IconTemperatureHigh = '\uf769',
        
        /// <summary>
        ///     Temperature Low ("fa-temperature-low", \uf76b) icon.
        /// </summary>
        /// 
        [Display(Name = "Temperature Low", Description = "fa-temperature-low", GroupName = "duotone light regular solid")]
        IconTemperatureLow = '\uf76b',
        
        /// <summary>
        ///     Tencent Weibo ("fa-tencent-weibo", \uf1d5) icon.
        /// </summary>
        /// 
        [Display(Name = "Tencent Weibo", Description = "fa-tencent-weibo", GroupName = "brands")]
        IconTencentWeibo = '\uf1d5',
        
        /// <summary>
        ///     Tenge ("fa-tenge", \uf7d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Tenge", Description = "fa-tenge", GroupName = "duotone light regular solid")]
        IconTenge = '\uf7d7',
        
        /// <summary>
        ///     Terminal ("fa-terminal", \uf120) icon.
        /// </summary>
        /// 
        [Display(Name = "Terminal", Description = "fa-terminal", GroupName = "duotone light regular solid")]
        IconTerminal = '\uf120',
        
        /// <summary>
        ///     Text Height ("fa-text-height", \uf034) icon.
        /// </summary>
        /// 
        [Display(Name = "Text Height", Description = "fa-text-height", GroupName = "duotone light regular solid")]
        IconTextHeight = '\uf034',
        
        /// <summary>
        ///     Text Width ("fa-text-width", \uf035) icon.
        /// </summary>
        /// 
        [Display(Name = "Text Width", Description = "fa-text-width", GroupName = "duotone light regular solid")]
        IconTextWidth = '\uf035',
        
        /// <summary>
        ///     Th ("fa-th", \uf00a) icon.
        /// </summary>
        /// 
        [Display(Name = "Th", Description = "fa-th", GroupName = "duotone light regular solid")]
        IconTh = '\uf00a',
        
        /// <summary>
        ///     Theater Masks ("fa-theater-masks", \uf630) icon.
        /// </summary>
        /// 
        [Display(Name = "Theater Masks", Description = "fa-theater-masks", GroupName = "duotone light regular solid")]
        IconTheaterMasks = '\uf630',
        
        /// <summary>
        ///     Themeco ("fa-themeco", \uf5c6) icon.
        /// </summary>
        /// 
        [Display(Name = "Themeco", Description = "fa-themeco", GroupName = "brands")]
        IconThemeco = '\uf5c6',
        
        /// <summary>
        ///     Themeisle ("fa-themeisle", \uf2b2) icon.
        /// </summary>
        /// 
        [Display(Name = "Themeisle", Description = "fa-themeisle", GroupName = "brands")]
        IconThemeisle = '\uf2b2',
        
        /// <summary>
        ///     The Red Yeti ("fa-the-red-yeti", \uf69d) icon.
        /// </summary>
        /// 
        [Display(Name = "The Red Yeti", Description = "fa-the-red-yeti", GroupName = "brands")]
        IconTheRedYeti = '\uf69d',
        
        /// <summary>
        ///     Thermometer ("fa-thermometer", \uf491) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer", Description = "fa-thermometer", GroupName = "duotone light regular solid")]
        IconThermometer = '\uf491',
        
        /// <summary>
        ///     Thermometer Empty ("fa-thermometer-empty", \uf2cb) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer Empty", Description = "fa-thermometer-empty", GroupName = "duotone light regular solid")]
        IconThermometerEmpty = '\uf2cb',
        
        /// <summary>
        ///     Thermometer Full ("fa-thermometer-full", \uf2c7) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer Full", Description = "fa-thermometer-full", GroupName = "duotone light regular solid")]
        IconThermometerFull = '\uf2c7',
        
        /// <summary>
        ///     Thermometer Half ("fa-thermometer-half", \uf2c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer Half", Description = "fa-thermometer-half", GroupName = "duotone light regular solid")]
        IconThermometerHalf = '\uf2c9',
        
        /// <summary>
        ///     Thermometer Quarter ("fa-thermometer-quarter", \uf2ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer Quarter", Description = "fa-thermometer-quarter", GroupName = "duotone light regular solid")]
        IconThermometerQuarter = '\uf2ca',
        
        /// <summary>
        ///     Thermometer Three Quarters ("fa-thermometer-three-quarters", \uf2c8) icon.
        /// </summary>
        /// 
        [Display(Name = "Thermometer Three Quarters", Description = "fa-thermometer-three-quarters", GroupName = "duotone light regular solid")]
        IconThermometerThreeQuarters = '\uf2c8',
        
        /// <summary>
        ///     Think Peaks ("fa-think-peaks", \uf731) icon.
        /// </summary>
        /// 
        [Display(Name = "Think Peaks", Description = "fa-think-peaks", GroupName = "brands")]
        IconThinkPeaks = '\uf731',
        
        /// <summary>
        ///     Th Large ("fa-th-large", \uf009) icon.
        /// </summary>
        /// 
        [Display(Name = "Th Large", Description = "fa-th-large", GroupName = "duotone light regular solid")]
        IconThLarge = '\uf009',
        
        /// <summary>
        ///     Th List ("fa-th-list", \uf00b) icon.
        /// </summary>
        /// 
        [Display(Name = "Th List", Description = "fa-th-list", GroupName = "duotone light regular solid")]
        IconThList = '\uf00b',
        
        /// <summary>
        ///     Thumbs Down ("fa-thumbs-down", \uf165) icon.
        /// </summary>
        /// 
        [Display(Name = "Thumbs Down", Description = "fa-thumbs-down", GroupName = "duotone light regular solid")]
        IconThumbsDown = '\uf165',
        
        /// <summary>
        ///     Thumbs Up ("fa-thumbs-up", \uf164) icon.
        /// </summary>
        /// 
        [Display(Name = "Thumbs Up", Description = "fa-thumbs-up", GroupName = "duotone light regular solid")]
        IconThumbsUp = '\uf164',
        
        /// <summary>
        ///     Thumbtack ("fa-thumbtack", \uf08d) icon.
        /// </summary>
        /// 
        [Display(Name = "Thumbtack", Description = "fa-thumbtack", GroupName = "duotone light regular solid")]
        IconThumbtack = '\uf08d',
        
        /// <summary>
        ///     Ticket Alt ("fa-ticket-alt", \uf3ff) icon.
        /// </summary>
        /// 
        [Display(Name = "Ticket Alt", Description = "fa-ticket-alt", GroupName = "duotone light regular solid")]
        IconTicketAlt = '\uf3ff',
        
        /// <summary>
        ///     Times ("fa-times", \uf00d) icon.
        /// </summary>
        /// 
        [Display(Name = "Times", Description = "fa-times", GroupName = "duotone light regular solid")]
        IconTimes = '\uf00d',
        
        /// <summary>
        ///     Times Circle ("fa-times-circle", \uf057) icon.
        /// </summary>
        /// 
        [Display(Name = "Times Circle", Description = "fa-times-circle", GroupName = "duotone light regular solid")]
        IconTimesCircle = '\uf057',
        
        /// <summary>
        ///     Tint ("fa-tint", \uf043) icon.
        /// </summary>
        /// 
        [Display(Name = "Tint", Description = "fa-tint", GroupName = "duotone light regular solid")]
        IconTint = '\uf043',
        
        /// <summary>
        ///     Tint Slash ("fa-tint-slash", \uf5c7) icon.
        /// </summary>
        /// 
        [Display(Name = "Tint Slash", Description = "fa-tint-slash", GroupName = "duotone light regular solid")]
        IconTintSlash = '\uf5c7',
        
        /// <summary>
        ///     Tired ("fa-tired", \uf5c8) icon.
        /// </summary>
        /// 
        [Display(Name = "Tired", Description = "fa-tired", GroupName = "duotone light regular solid")]
        IconTired = '\uf5c8',
        
        /// <summary>
        ///     Toggle Off ("fa-toggle-off", \uf204) icon.
        /// </summary>
        /// 
        [Display(Name = "Toggle Off", Description = "fa-toggle-off", GroupName = "duotone light regular solid")]
        IconToggleOff = '\uf204',
        
        /// <summary>
        ///     Toggle On ("fa-toggle-on", \uf205) icon.
        /// </summary>
        /// 
        [Display(Name = "Toggle On", Description = "fa-toggle-on", GroupName = "duotone light regular solid")]
        IconToggleOn = '\uf205',
        
        /// <summary>
        ///     Toilet ("fa-toilet", \uf7d8) icon.
        /// </summary>
        /// 
        [Display(Name = "Toilet", Description = "fa-toilet", GroupName = "duotone light regular solid")]
        IconToilet = '\uf7d8',
        
        /// <summary>
        ///     Toilet Paper ("fa-toilet-paper", \uf71e) icon.
        /// </summary>
        /// 
        [Display(Name = "Toilet Paper", Description = "fa-toilet-paper", GroupName = "duotone light regular solid")]
        IconToiletPaper = '\uf71e',
        
        /// <summary>
        ///     Toilet Paper Slash ("fa-toilet-paper-slash", \uf972) icon.
        /// </summary>
        /// 
        [Display(Name = "Toilet Paper Slash", Description = "fa-toilet-paper-slash", GroupName = "duotone light regular solid")]
        IconToiletPaperSlash = '\uf972',
        
        /// <summary>
        ///     Toolbox ("fa-toolbox", \uf552) icon.
        /// </summary>
        /// 
        [Display(Name = "Toolbox", Description = "fa-toolbox", GroupName = "duotone light regular solid")]
        IconToolbox = '\uf552',
        
        /// <summary>
        ///     Tools ("fa-tools", \uf7d9) icon.
        /// </summary>
        /// 
        [Display(Name = "Tools", Description = "fa-tools", GroupName = "duotone light regular solid")]
        IconTools = '\uf7d9',
        
        /// <summary>
        ///     Tooth ("fa-tooth", \uf5c9) icon.
        /// </summary>
        /// 
        [Display(Name = "Tooth", Description = "fa-tooth", GroupName = "duotone light regular solid")]
        IconTooth = '\uf5c9',
        
        /// <summary>
        ///     Torah ("fa-torah", \uf6a0) icon.
        /// </summary>
        /// 
        [Display(Name = "Torah", Description = "fa-torah", GroupName = "duotone light regular solid")]
        IconTorah = '\uf6a0',
        
        /// <summary>
        ///     Torii Gate ("fa-torii-gate", \uf6a1) icon.
        /// </summary>
        /// 
        [Display(Name = "Torii Gate", Description = "fa-torii-gate", GroupName = "duotone light regular solid")]
        IconToriiGate = '\uf6a1',
        
        /// <summary>
        ///     Tractor ("fa-tractor", \uf722) icon.
        /// </summary>
        /// 
        [Display(Name = "Tractor", Description = "fa-tractor", GroupName = "duotone light regular solid")]
        IconTractor = '\uf722',
        
        /// <summary>
        ///     Trade Federation ("fa-trade-federation", \uf513) icon.
        /// </summary>
        /// 
        [Display(Name = "Trade Federation", Description = "fa-trade-federation", GroupName = "brands")]
        IconTradeFederation = '\uf513',
        
        /// <summary>
        ///     Trademark ("fa-trademark", \uf25c) icon.
        /// </summary>
        /// 
        [Display(Name = "Trademark", Description = "fa-trademark", GroupName = "duotone light regular solid")]
        IconTrademark = '\uf25c',
        
        /// <summary>
        ///     Traffic Light ("fa-traffic-light", \uf637) icon.
        /// </summary>
        /// 
        [Display(Name = "Traffic Light", Description = "fa-traffic-light", GroupName = "duotone light regular solid")]
        IconTrafficLight = '\uf637',
        
        /// <summary>
        ///     Trailer ("fa-trailer", \uf941) icon.
        /// </summary>
        /// 
        [Display(Name = "Trailer", Description = "fa-trailer", GroupName = "duotone light regular solid")]
        IconTrailer = '\uf941',
        
        /// <summary>
        ///     Train ("fa-train", \uf238) icon.
        /// </summary>
        /// 
        [Display(Name = "Train", Description = "fa-train", GroupName = "duotone light regular solid")]
        IconTrain = '\uf238',
        
        /// <summary>
        ///     Tram ("fa-tram", \uf7da) icon.
        /// </summary>
        /// 
        [Display(Name = "Tram", Description = "fa-tram", GroupName = "duotone light regular solid")]
        IconTram = '\uf7da',
        
        /// <summary>
        ///     Transgender ("fa-transgender", \uf224) icon.
        /// </summary>
        /// 
        [Display(Name = "Transgender", Description = "fa-transgender", GroupName = "duotone light regular solid")]
        IconTransgender = '\uf224',
        
        /// <summary>
        ///     Transgender Alt ("fa-transgender-alt", \uf225) icon.
        /// </summary>
        /// 
        [Display(Name = "Transgender Alt", Description = "fa-transgender-alt", GroupName = "duotone light regular solid")]
        IconTransgenderAlt = '\uf225',
        
        /// <summary>
        ///     Trash ("fa-trash", \uf1f8) icon.
        /// </summary>
        /// 
        [Display(Name = "Trash", Description = "fa-trash", GroupName = "duotone light regular solid")]
        IconTrash = '\uf1f8',
        
        /// <summary>
        ///     Trash Alt ("fa-trash-alt", \uf2ed) icon.
        /// </summary>
        /// 
        [Display(Name = "Trash Alt", Description = "fa-trash-alt", GroupName = "duotone light regular solid")]
        IconTrashAlt = '\uf2ed',
        
        /// <summary>
        ///     Trash Restore ("fa-trash-restore", \uf829) icon.
        /// </summary>
        /// 
        [Display(Name = "Trash Restore", Description = "fa-trash-restore", GroupName = "duotone light regular solid")]
        IconTrashRestore = '\uf829',
        
        /// <summary>
        ///     Trash Restore Alt ("fa-trash-restore-alt", \uf82a) icon.
        /// </summary>
        /// 
        [Display(Name = "Trash Restore Alt", Description = "fa-trash-restore-alt", GroupName = "duotone light regular solid")]
        IconTrashRestoreAlt = '\uf82a',
        
        /// <summary>
        ///     Tree ("fa-tree", \uf1bb) icon.
        /// </summary>
        /// 
        [Display(Name = "Tree", Description = "fa-tree", GroupName = "duotone light regular solid")]
        IconTree = '\uf1bb',
        
        /// <summary>
        ///     Trello ("fa-trello", \uf181) icon.
        /// </summary>
        /// 
        [Display(Name = "Trello", Description = "fa-trello", GroupName = "brands")]
        IconTrello = '\uf181',
        
        /// <summary>
        ///     Tripadvisor ("fa-tripadvisor", \uf262) icon.
        /// </summary>
        /// 
        [Display(Name = "Tripadvisor", Description = "fa-tripadvisor", GroupName = "brands")]
        IconTripadvisor = '\uf262',
        
        /// <summary>
        ///     Trophy ("fa-trophy", \uf091) icon.
        /// </summary>
        /// 
        [Display(Name = "Trophy", Description = "fa-trophy", GroupName = "duotone light regular solid")]
        IconTrophy = '\uf091',
        
        /// <summary>
        ///     Truck ("fa-truck", \uf0d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Truck", Description = "fa-truck", GroupName = "duotone light regular solid")]
        IconTruck = '\uf0d1',
        
        /// <summary>
        ///     Truck Loading ("fa-truck-loading", \uf4de) icon.
        /// </summary>
        /// 
        [Display(Name = "Truck Loading", Description = "fa-truck-loading", GroupName = "duotone light regular solid")]
        IconTruckLoading = '\uf4de',
        
        /// <summary>
        ///     Truck Monster ("fa-truck-monster", \uf63b) icon.
        /// </summary>
        /// 
        [Display(Name = "Truck Monster", Description = "fa-truck-monster", GroupName = "duotone light regular solid")]
        IconTruckMonster = '\uf63b',
        
        /// <summary>
        ///     Truck Moving ("fa-truck-moving", \uf4df) icon.
        /// </summary>
        /// 
        [Display(Name = "Truck Moving", Description = "fa-truck-moving", GroupName = "duotone light regular solid")]
        IconTruckMoving = '\uf4df',
        
        /// <summary>
        ///     Truck Pickup ("fa-truck-pickup", \uf63c) icon.
        /// </summary>
        /// 
        [Display(Name = "Truck Pickup", Description = "fa-truck-pickup", GroupName = "duotone light regular solid")]
        IconTruckPickup = '\uf63c',
        
        /// <summary>
        ///     Tshirt ("fa-tshirt", \uf553) icon.
        /// </summary>
        /// 
        [Display(Name = "Tshirt", Description = "fa-tshirt", GroupName = "duotone light regular solid")]
        IconTshirt = '\uf553',
        
        /// <summary>
        ///     Tty ("fa-tty", \uf1e4) icon.
        /// </summary>
        /// 
        [Display(Name = "Tty", Description = "fa-tty", GroupName = "duotone light regular solid")]
        IconTty = '\uf1e4',
        
        /// <summary>
        ///     Tumblr ("fa-tumblr", \uf173) icon.
        /// </summary>
        /// 
        [Display(Name = "Tumblr", Description = "fa-tumblr", GroupName = "brands")]
        IconTumblr = '\uf173',
        
        /// <summary>
        ///     Tumblr Square ("fa-tumblr-square", \uf174) icon.
        /// </summary>
        /// 
        [Display(Name = "Tumblr Square", Description = "fa-tumblr-square", GroupName = "brands")]
        IconTumblrSquare = '\uf174',
        
        /// <summary>
        ///     Tv ("fa-tv", \uf26c) icon.
        /// </summary>
        /// 
        [Display(Name = "Tv", Description = "fa-tv", GroupName = "duotone light regular solid")]
        IconTv = '\uf26c',
        
        /// <summary>
        ///     Twitch ("fa-twitch", \uf1e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Twitch", Description = "fa-twitch", GroupName = "brands")]
        IconTwitch = '\uf1e8',
        
        /// <summary>
        ///     Twitter ("fa-twitter", \uf099) icon.
        /// </summary>
        /// 
        [Display(Name = "Twitter", Description = "fa-twitter", GroupName = "brands")]
        IconTwitter = '\uf099',
        
        /// <summary>
        ///     Twitter Square ("fa-twitter-square", \uf081) icon.
        /// </summary>
        /// 
        [Display(Name = "Twitter Square", Description = "fa-twitter-square", GroupName = "brands")]
        IconTwitterSquare = '\uf081',
        
        /// <summary>
        ///     Typo3 ("fa-typo3", \uf42b) icon.
        /// </summary>
        /// 
        [Display(Name = "Typo3", Description = "fa-typo3", GroupName = "brands")]
        IconTypo3 = '\uf42b',
        
        /// <summary>
        ///     Uber ("fa-uber", \uf402) icon.
        /// </summary>
        /// 
        [Display(Name = "Uber", Description = "fa-uber", GroupName = "brands")]
        IconUber = '\uf402',
        
        /// <summary>
        ///     Ubuntu ("fa-ubuntu", \uf7df) icon.
        /// </summary>
        /// 
        [Display(Name = "Ubuntu", Description = "fa-ubuntu", GroupName = "brands")]
        IconUbuntu = '\uf7df',
        
        /// <summary>
        ///     Uikit ("fa-uikit", \uf403) icon.
        /// </summary>
        /// 
        [Display(Name = "Uikit", Description = "fa-uikit", GroupName = "brands")]
        IconUikit = '\uf403',
        
        /// <summary>
        ///     Umbraco ("fa-umbraco", \uf8e8) icon.
        /// </summary>
        /// 
        [Display(Name = "Umbraco", Description = "fa-umbraco", GroupName = "brands")]
        IconUmbraco = '\uf8e8',
        
        /// <summary>
        ///     Umbrella ("fa-umbrella", \uf0e9) icon.
        /// </summary>
        /// 
        [Display(Name = "Umbrella", Description = "fa-umbrella", GroupName = "duotone light regular solid")]
        IconUmbrella = '\uf0e9',
        
        /// <summary>
        ///     Umbrella Beach ("fa-umbrella-beach", \uf5ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Umbrella Beach", Description = "fa-umbrella-beach", GroupName = "duotone light regular solid")]
        IconUmbrellaBeach = '\uf5ca',
        
        /// <summary>
        ///     Underline ("fa-underline", \uf0cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Underline", Description = "fa-underline", GroupName = "duotone light regular solid")]
        IconUnderline = '\uf0cd',
        
        /// <summary>
        ///     Undo ("fa-undo", \uf0e2) icon.
        /// </summary>
        /// 
        [Display(Name = "Undo", Description = "fa-undo", GroupName = "duotone light regular solid")]
        IconUndo = '\uf0e2',
        
        /// <summary>
        ///     Undo Alt ("fa-undo-alt", \uf2ea) icon.
        /// </summary>
        /// 
        [Display(Name = "Undo Alt", Description = "fa-undo-alt", GroupName = "duotone light regular solid")]
        IconUndoAlt = '\uf2ea',
        
        /// <summary>
        ///     Uniregistry ("fa-uniregistry", \uf404) icon.
        /// </summary>
        /// 
        [Display(Name = "Uniregistry", Description = "fa-uniregistry", GroupName = "brands")]
        IconUniregistry = '\uf404',
        
        /// <summary>
        ///     Unity ("fa-unity", \uf949) icon.
        /// </summary>
        /// 
        [Display(Name = "Unity", Description = "fa-unity", GroupName = "brands")]
        IconUnity = '\uf949',
        
        /// <summary>
        ///     Universal Access ("fa-universal-access", \uf29a) icon.
        /// </summary>
        /// 
        [Display(Name = "Universal Access", Description = "fa-universal-access", GroupName = "duotone light regular solid")]
        IconUniversalAccess = '\uf29a',
        
        /// <summary>
        ///     University ("fa-university", \uf19c) icon.
        /// </summary>
        /// 
        [Display(Name = "University", Description = "fa-university", GroupName = "duotone light regular solid")]
        IconUniversity = '\uf19c',
        
        /// <summary>
        ///     Unlink ("fa-unlink", \uf127) icon.
        /// </summary>
        /// 
        [Display(Name = "Unlink", Description = "fa-unlink", GroupName = "duotone light regular solid")]
        IconUnlink = '\uf127',
        
        /// <summary>
        ///     Unlock ("fa-unlock", \uf09c) icon.
        /// </summary>
        /// 
        [Display(Name = "Unlock", Description = "fa-unlock", GroupName = "duotone light regular solid")]
        IconUnlock = '\uf09c',
        
        /// <summary>
        ///     Unlock Alt ("fa-unlock-alt", \uf13e) icon.
        /// </summary>
        /// 
        [Display(Name = "Unlock Alt", Description = "fa-unlock-alt", GroupName = "duotone light regular solid")]
        IconUnlockAlt = '\uf13e',
        
        /// <summary>
        ///     Untappd ("fa-untappd", \uf405) icon.
        /// </summary>
        /// 
        [Display(Name = "Untappd", Description = "fa-untappd", GroupName = "brands")]
        IconUntappd = '\uf405',
        
        /// <summary>
        ///     Upload ("fa-upload", \uf093) icon.
        /// </summary>
        /// 
        [Display(Name = "Upload", Description = "fa-upload", GroupName = "duotone light regular solid")]
        IconUpload = '\uf093',
        
        /// <summary>
        ///     Ups ("fa-ups", \uf7e0) icon.
        /// </summary>
        /// 
        [Display(Name = "Ups", Description = "fa-ups", GroupName = "brands")]
        IconUps = '\uf7e0',
        
        /// <summary>
        ///     Usb ("fa-usb", \uf287) icon.
        /// </summary>
        /// 
        [Display(Name = "Usb", Description = "fa-usb", GroupName = "brands")]
        IconUsb = '\uf287',
        
        /// <summary>
        ///     User ("fa-user", \uf007) icon.
        /// </summary>
        /// 
        [Display(Name = "User", Description = "fa-user", GroupName = "duotone light regular solid")]
        IconUser = '\uf007',
        
        /// <summary>
        ///     User Alt ("fa-user-alt", \uf406) icon.
        /// </summary>
        /// 
        [Display(Name = "User Alt", Description = "fa-user-alt", GroupName = "duotone light regular solid")]
        IconUserAlt = '\uf406',
        
        /// <summary>
        ///     User Alt Slash ("fa-user-alt-slash", \uf4fa) icon.
        /// </summary>
        /// 
        [Display(Name = "User Alt Slash", Description = "fa-user-alt-slash", GroupName = "duotone light regular solid")]
        IconUserAltSlash = '\uf4fa',
        
        /// <summary>
        ///     User Astronaut ("fa-user-astronaut", \uf4fb) icon.
        /// </summary>
        /// 
        [Display(Name = "User Astronaut", Description = "fa-user-astronaut", GroupName = "duotone light regular solid")]
        IconUserAstronaut = '\uf4fb',
        
        /// <summary>
        ///     User Check ("fa-user-check", \uf4fc) icon.
        /// </summary>
        /// 
        [Display(Name = "User Check", Description = "fa-user-check", GroupName = "duotone light regular solid")]
        IconUserCheck = '\uf4fc',
        
        /// <summary>
        ///     User Circle ("fa-user-circle", \uf2bd) icon.
        /// </summary>
        /// 
        [Display(Name = "User Circle", Description = "fa-user-circle", GroupName = "duotone light regular solid")]
        IconUserCircle = '\uf2bd',
        
        /// <summary>
        ///     User Clock ("fa-user-clock", \uf4fd) icon.
        /// </summary>
        /// 
        [Display(Name = "User Clock", Description = "fa-user-clock", GroupName = "duotone light regular solid")]
        IconUserClock = '\uf4fd',
        
        /// <summary>
        ///     User Cog ("fa-user-cog", \uf4fe) icon.
        /// </summary>
        /// 
        [Display(Name = "User Cog", Description = "fa-user-cog", GroupName = "duotone light regular solid")]
        IconUserCog = '\uf4fe',
        
        /// <summary>
        ///     User Edit ("fa-user-edit", \uf4ff) icon.
        /// </summary>
        /// 
        [Display(Name = "User Edit", Description = "fa-user-edit", GroupName = "duotone light regular solid")]
        IconUserEdit = '\uf4ff',
        
        /// <summary>
        ///     User Friends ("fa-user-friends", \uf500) icon.
        /// </summary>
        /// 
        [Display(Name = "User Friends", Description = "fa-user-friends", GroupName = "duotone light regular solid")]
        IconUserFriends = '\uf500',
        
        /// <summary>
        ///     User Graduate ("fa-user-graduate", \uf501) icon.
        /// </summary>
        /// 
        [Display(Name = "User Graduate", Description = "fa-user-graduate", GroupName = "duotone light regular solid")]
        IconUserGraduate = '\uf501',
        
        /// <summary>
        ///     User Injured ("fa-user-injured", \uf728) icon.
        /// </summary>
        /// 
        [Display(Name = "User Injured", Description = "fa-user-injured", GroupName = "duotone light regular solid")]
        IconUserInjured = '\uf728',
        
        /// <summary>
        ///     User Lock ("fa-user-lock", \uf502) icon.
        /// </summary>
        /// 
        [Display(Name = "User Lock", Description = "fa-user-lock", GroupName = "duotone light regular solid")]
        IconUserLock = '\uf502',
        
        /// <summary>
        ///     User Md ("fa-user-md", \uf0f0) icon.
        /// </summary>
        /// 
        [Display(Name = "User Md", Description = "fa-user-md", GroupName = "duotone light regular solid")]
        IconUserMd = '\uf0f0',
        
        /// <summary>
        ///     User Minus ("fa-user-minus", \uf503) icon.
        /// </summary>
        /// 
        [Display(Name = "User Minus", Description = "fa-user-minus", GroupName = "duotone light regular solid")]
        IconUserMinus = '\uf503',
        
        /// <summary>
        ///     User Ninja ("fa-user-ninja", \uf504) icon.
        /// </summary>
        /// 
        [Display(Name = "User Ninja", Description = "fa-user-ninja", GroupName = "duotone light regular solid")]
        IconUserNinja = '\uf504',
        
        /// <summary>
        ///     User Nurse ("fa-user-nurse", \uf82f) icon.
        /// </summary>
        /// 
        [Display(Name = "User Nurse", Description = "fa-user-nurse", GroupName = "duotone light regular solid")]
        IconUserNurse = '\uf82f',
        
        /// <summary>
        ///     User Plus ("fa-user-plus", \uf234) icon.
        /// </summary>
        /// 
        [Display(Name = "User Plus", Description = "fa-user-plus", GroupName = "duotone light regular solid")]
        IconUserPlus = '\uf234',
        
        /// <summary>
        ///     Users ("fa-users", \uf0c0) icon.
        /// </summary>
        /// 
        [Display(Name = "Users", Description = "fa-users", GroupName = "duotone light regular solid")]
        IconUsers = '\uf0c0',
        
        /// <summary>
        ///     Users Cog ("fa-users-cog", \uf509) icon.
        /// </summary>
        /// 
        [Display(Name = "Users Cog", Description = "fa-users-cog", GroupName = "duotone light regular solid")]
        IconUsersCog = '\uf509',
        
        /// <summary>
        ///     User Secret ("fa-user-secret", \uf21b) icon.
        /// </summary>
        /// 
        [Display(Name = "User Secret", Description = "fa-user-secret", GroupName = "duotone light regular solid")]
        IconUserSecret = '\uf21b',
        
        /// <summary>
        ///     User Shield ("fa-user-shield", \uf505) icon.
        /// </summary>
        /// 
        [Display(Name = "User Shield", Description = "fa-user-shield", GroupName = "duotone light regular solid")]
        IconUserShield = '\uf505',
        
        /// <summary>
        ///     User Slash ("fa-user-slash", \uf506) icon.
        /// </summary>
        /// 
        [Display(Name = "User Slash", Description = "fa-user-slash", GroupName = "duotone light regular solid")]
        IconUserSlash = '\uf506',
        
        /// <summary>
        ///     User Tag ("fa-user-tag", \uf507) icon.
        /// </summary>
        /// 
        [Display(Name = "User Tag", Description = "fa-user-tag", GroupName = "duotone light regular solid")]
        IconUserTag = '\uf507',
        
        /// <summary>
        ///     User Tie ("fa-user-tie", \uf508) icon.
        /// </summary>
        /// 
        [Display(Name = "User Tie", Description = "fa-user-tie", GroupName = "duotone light regular solid")]
        IconUserTie = '\uf508',
        
        /// <summary>
        ///     User Times ("fa-user-times", \uf235) icon.
        /// </summary>
        /// 
        [Display(Name = "User Times", Description = "fa-user-times", GroupName = "duotone light regular solid")]
        IconUserTimes = '\uf235',
        
        /// <summary>
        ///     Usps ("fa-usps", \uf7e1) icon.
        /// </summary>
        /// 
        [Display(Name = "Usps", Description = "fa-usps", GroupName = "brands")]
        IconUsps = '\uf7e1',
        
        /// <summary>
        ///     Ussunnah ("fa-ussunnah", \uf407) icon.
        /// </summary>
        /// 
        [Display(Name = "Ussunnah", Description = "fa-ussunnah", GroupName = "brands")]
        IconUssunnah = '\uf407',
        
        /// <summary>
        ///     Utensils ("fa-utensils", \uf2e7) icon.
        /// </summary>
        /// 
        [Display(Name = "Utensils", Description = "fa-utensils", GroupName = "duotone light regular solid")]
        IconUtensils = '\uf2e7',
        
        /// <summary>
        ///     Utensil Spoon ("fa-utensil-spoon", \uf2e5) icon.
        /// </summary>
        /// 
        [Display(Name = "Utensil Spoon", Description = "fa-utensil-spoon", GroupName = "duotone light regular solid")]
        IconUtensilSpoon = '\uf2e5',
        
        /// <summary>
        ///     Vaadin ("fa-vaadin", \uf408) icon.
        /// </summary>
        /// 
        [Display(Name = "Vaadin", Description = "fa-vaadin", GroupName = "brands")]
        IconVaadin = '\uf408',
        
        /// <summary>
        ///     Vector Square ("fa-vector-square", \uf5cb) icon.
        /// </summary>
        /// 
        [Display(Name = "Vector Square", Description = "fa-vector-square", GroupName = "duotone light regular solid")]
        IconVectorSquare = '\uf5cb',
        
        /// <summary>
        ///     Venus ("fa-venus", \uf221) icon.
        /// </summary>
        /// 
        [Display(Name = "Venus", Description = "fa-venus", GroupName = "duotone light regular solid")]
        IconVenus = '\uf221',
        
        /// <summary>
        ///     Venus Double ("fa-venus-double", \uf226) icon.
        /// </summary>
        /// 
        [Display(Name = "Venus Double", Description = "fa-venus-double", GroupName = "duotone light regular solid")]
        IconVenusDouble = '\uf226',
        
        /// <summary>
        ///     Venus Mars ("fa-venus-mars", \uf228) icon.
        /// </summary>
        /// 
        [Display(Name = "Venus Mars", Description = "fa-venus-mars", GroupName = "duotone light regular solid")]
        IconVenusMars = '\uf228',
        
        /// <summary>
        ///     Viacoin ("fa-viacoin", \uf237) icon.
        /// </summary>
        /// 
        [Display(Name = "Viacoin", Description = "fa-viacoin", GroupName = "brands")]
        IconViacoin = '\uf237',
        
        /// <summary>
        ///     Viadeo ("fa-viadeo", \uf2a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Viadeo", Description = "fa-viadeo", GroupName = "brands")]
        IconViadeo = '\uf2a9',
        
        /// <summary>
        ///     Viadeo Square ("fa-viadeo-square", \uf2aa) icon.
        /// </summary>
        /// 
        [Display(Name = "Viadeo Square", Description = "fa-viadeo-square", GroupName = "brands")]
        IconViadeoSquare = '\uf2aa',
        
        /// <summary>
        ///     Vial ("fa-vial", \uf492) icon.
        /// </summary>
        /// 
        [Display(Name = "Vial", Description = "fa-vial", GroupName = "duotone light regular solid")]
        IconVial = '\uf492',
        
        /// <summary>
        ///     Vials ("fa-vials", \uf493) icon.
        /// </summary>
        /// 
        [Display(Name = "Vials", Description = "fa-vials", GroupName = "duotone light regular solid")]
        IconVials = '\uf493',
        
        /// <summary>
        ///     Viber ("fa-viber", \uf409) icon.
        /// </summary>
        /// 
        [Display(Name = "Viber", Description = "fa-viber", GroupName = "brands")]
        IconViber = '\uf409',
        
        /// <summary>
        ///     Video ("fa-video", \uf03d) icon.
        /// </summary>
        /// 
        [Display(Name = "Video", Description = "fa-video", GroupName = "duotone light regular solid")]
        IconVideo = '\uf03d',
        
        /// <summary>
        ///     Video Slash ("fa-video-slash", \uf4e2) icon.
        /// </summary>
        /// 
        [Display(Name = "Video Slash", Description = "fa-video-slash", GroupName = "duotone light regular solid")]
        IconVideoSlash = '\uf4e2',
        
        /// <summary>
        ///     Vihara ("fa-vihara", \uf6a7) icon.
        /// </summary>
        /// 
        [Display(Name = "Vihara", Description = "fa-vihara", GroupName = "duotone light regular solid")]
        IconVihara = '\uf6a7',
        
        /// <summary>
        ///     Vimeo ("fa-vimeo", \uf40a) icon.
        /// </summary>
        /// 
        [Display(Name = "Vimeo", Description = "fa-vimeo", GroupName = "brands")]
        IconVimeo = '\uf40a',
        
        /// <summary>
        ///     Vimeo Square ("fa-vimeo-square", \uf194) icon.
        /// </summary>
        /// 
        [Display(Name = "Vimeo Square", Description = "fa-vimeo-square", GroupName = "brands")]
        IconVimeoSquare = '\uf194',
        
        /// <summary>
        ///     Vimeo V ("fa-vimeo-v", \uf27d) icon.
        /// </summary>
        /// 
        [Display(Name = "Vimeo V", Description = "fa-vimeo-v", GroupName = "brands")]
        IconVimeoV = '\uf27d',
        
        /// <summary>
        ///     Vine ("fa-vine", \uf1ca) icon.
        /// </summary>
        /// 
        [Display(Name = "Vine", Description = "fa-vine", GroupName = "brands")]
        IconVine = '\uf1ca',
        
        /// <summary>
        ///     Virus ("fa-virus", \uf974) icon.
        /// </summary>
        /// 
        [Display(Name = "Virus", Description = "fa-virus", GroupName = "duotone light regular solid")]
        IconVirus = '\uf974',
        
        /// <summary>
        ///     Viruses ("fa-viruses", \uf976) icon.
        /// </summary>
        /// 
        [Display(Name = "Viruses", Description = "fa-viruses", GroupName = "duotone light regular solid")]
        IconViruses = '\uf976',
        
        /// <summary>
        ///     Virus Slash ("fa-virus-slash", \uf975) icon.
        /// </summary>
        /// 
        [Display(Name = "Virus Slash", Description = "fa-virus-slash", GroupName = "duotone light regular solid")]
        IconVirusSlash = '\uf975',
        
        /// <summary>
        ///     Vk ("fa-vk", \uf189) icon.
        /// </summary>
        /// 
        [Display(Name = "Vk", Description = "fa-vk", GroupName = "brands")]
        IconVk = '\uf189',
        
        /// <summary>
        ///     Vnv ("fa-vnv", \uf40b) icon.
        /// </summary>
        /// 
        [Display(Name = "Vnv", Description = "fa-vnv", GroupName = "brands")]
        IconVnv = '\uf40b',
        
        /// <summary>
        ///     Voicemail ("fa-voicemail", \uf897) icon.
        /// </summary>
        /// 
        [Display(Name = "Voicemail", Description = "fa-voicemail", GroupName = "duotone light regular solid")]
        IconVoicemail = '\uf897',
        
        /// <summary>
        ///     Volleyball Ball ("fa-volleyball-ball", \uf45f) icon.
        /// </summary>
        /// 
        [Display(Name = "Volleyball Ball", Description = "fa-volleyball-ball", GroupName = "duotone light regular solid")]
        IconVolleyballBall = '\uf45f',
        
        /// <summary>
        ///     Volume Down ("fa-volume-down", \uf027) icon.
        /// </summary>
        /// 
        [Display(Name = "Volume Down", Description = "fa-volume-down", GroupName = "duotone light regular solid")]
        IconVolumeDown = '\uf027',
        
        /// <summary>
        ///     Volume Mute ("fa-volume-mute", \uf6a9) icon.
        /// </summary>
        /// 
        [Display(Name = "Volume Mute", Description = "fa-volume-mute", GroupName = "duotone light regular solid")]
        IconVolumeMute = '\uf6a9',
        
        /// <summary>
        ///     Volume Off ("fa-volume-off", \uf026) icon.
        /// </summary>
        /// 
        [Display(Name = "Volume Off", Description = "fa-volume-off", GroupName = "duotone light regular solid")]
        IconVolumeOff = '\uf026',
        
        /// <summary>
        ///     Volume Up ("fa-volume-up", \uf028) icon.
        /// </summary>
        /// 
        [Display(Name = "Volume Up", Description = "fa-volume-up", GroupName = "duotone light regular solid")]
        IconVolumeUp = '\uf028',
        
        /// <summary>
        ///     Vote Yea ("fa-vote-yea", \uf772) icon.
        /// </summary>
        /// 
        [Display(Name = "Vote Yea", Description = "fa-vote-yea", GroupName = "duotone light regular solid")]
        IconVoteYea = '\uf772',
        
        /// <summary>
        ///     Vr Cardboard ("fa-vr-cardboard", \uf729) icon.
        /// </summary>
        /// 
        [Display(Name = "Vr Cardboard", Description = "fa-vr-cardboard", GroupName = "duotone light regular solid")]
        IconVrCardboard = '\uf729',
        
        /// <summary>
        ///     Vuejs ("fa-vuejs", \uf41f) icon.
        /// </summary>
        /// 
        [Display(Name = "Vuejs", Description = "fa-vuejs", GroupName = "brands")]
        IconVuejs = '\uf41f',
        
        /// <summary>
        ///     Walking ("fa-walking", \uf554) icon.
        /// </summary>
        /// 
        [Display(Name = "Walking", Description = "fa-walking", GroupName = "duotone light regular solid")]
        IconWalking = '\uf554',
        
        /// <summary>
        ///     Wallet ("fa-wallet", \uf555) icon.
        /// </summary>
        /// 
        [Display(Name = "Wallet", Description = "fa-wallet", GroupName = "duotone light regular solid")]
        IconWallet = '\uf555',
        
        /// <summary>
        ///     Warehouse ("fa-warehouse", \uf494) icon.
        /// </summary>
        /// 
        [Display(Name = "Warehouse", Description = "fa-warehouse", GroupName = "duotone light regular solid")]
        IconWarehouse = '\uf494',
        
        /// <summary>
        ///     Water ("fa-water", \uf773) icon.
        /// </summary>
        /// 
        [Display(Name = "Water", Description = "fa-water", GroupName = "duotone light regular solid")]
        IconWater = '\uf773',
        
        /// <summary>
        ///     Wave Square ("fa-wave-square", \uf83e) icon.
        /// </summary>
        /// 
        [Display(Name = "Wave Square", Description = "fa-wave-square", GroupName = "duotone light regular solid")]
        IconWaveSquare = '\uf83e',
        
        /// <summary>
        ///     Waze ("fa-waze", \uf83f) icon.
        /// </summary>
        /// 
        [Display(Name = "Waze", Description = "fa-waze", GroupName = "brands")]
        IconWaze = '\uf83f',
        
        /// <summary>
        ///     Weebly ("fa-weebly", \uf5cc) icon.
        /// </summary>
        /// 
        [Display(Name = "Weebly", Description = "fa-weebly", GroupName = "brands")]
        IconWeebly = '\uf5cc',
        
        /// <summary>
        ///     Weibo ("fa-weibo", \uf18a) icon.
        /// </summary>
        /// 
        [Display(Name = "Weibo", Description = "fa-weibo", GroupName = "brands")]
        IconWeibo = '\uf18a',
        
        /// <summary>
        ///     Weight ("fa-weight", \uf496) icon.
        /// </summary>
        /// 
        [Display(Name = "Weight", Description = "fa-weight", GroupName = "duotone light regular solid")]
        IconWeight = '\uf496',
        
        /// <summary>
        ///     Weight Hanging ("fa-weight-hanging", \uf5cd) icon.
        /// </summary>
        /// 
        [Display(Name = "Weight Hanging", Description = "fa-weight-hanging", GroupName = "duotone light regular solid")]
        IconWeightHanging = '\uf5cd',
        
        /// <summary>
        ///     Weixin ("fa-weixin", \uf1d7) icon.
        /// </summary>
        /// 
        [Display(Name = "Weixin", Description = "fa-weixin", GroupName = "brands")]
        IconWeixin = '\uf1d7',
        
        /// <summary>
        ///     Whatsapp ("fa-whatsapp", \uf232) icon.
        /// </summary>
        /// 
        [Display(Name = "Whatsapp", Description = "fa-whatsapp", GroupName = "brands")]
        IconWhatsapp = '\uf232',
        
        /// <summary>
        ///     Whatsapp Square ("fa-whatsapp-square", \uf40c) icon.
        /// </summary>
        /// 
        [Display(Name = "Whatsapp Square", Description = "fa-whatsapp-square", GroupName = "brands")]
        IconWhatsappSquare = '\uf40c',
        
        /// <summary>
        ///     Wheelchair ("fa-wheelchair", \uf193) icon.
        /// </summary>
        /// 
        [Display(Name = "Wheelchair", Description = "fa-wheelchair", GroupName = "duotone light regular solid")]
        IconWheelchair = '\uf193',
        
        /// <summary>
        ///     Whmcs ("fa-whmcs", \uf40d) icon.
        /// </summary>
        /// 
        [Display(Name = "Whmcs", Description = "fa-whmcs", GroupName = "brands")]
        IconWhmcs = '\uf40d',
        
        /// <summary>
        ///     Wifi ("fa-wifi", \uf1eb) icon.
        /// </summary>
        /// 
        [Display(Name = "Wifi", Description = "fa-wifi", GroupName = "duotone light regular solid")]
        IconWifi = '\uf1eb',
        
        /// <summary>
        ///     Wikipedia W ("fa-wikipedia-w", \uf266) icon.
        /// </summary>
        /// 
        [Display(Name = "Wikipedia W", Description = "fa-wikipedia-w", GroupName = "brands")]
        IconWikipediaW = '\uf266',
        
        /// <summary>
        ///     Wind ("fa-wind", \uf72e) icon.
        /// </summary>
        /// 
        [Display(Name = "Wind", Description = "fa-wind", GroupName = "duotone light regular solid")]
        IconWind = '\uf72e',
        
        /// <summary>
        ///     Window Close ("fa-window-close", \uf410) icon.
        /// </summary>
        /// 
        [Display(Name = "Window Close", Description = "fa-window-close", GroupName = "duotone light regular solid")]
        IconWindowClose = '\uf410',
        
        /// <summary>
        ///     Window Maximize ("fa-window-maximize", \uf2d0) icon.
        /// </summary>
        /// 
        [Display(Name = "Window Maximize", Description = "fa-window-maximize", GroupName = "duotone light regular solid")]
        IconWindowMaximize = '\uf2d0',
        
        /// <summary>
        ///     Window Minimize ("fa-window-minimize", \uf2d1) icon.
        /// </summary>
        /// 
        [Display(Name = "Window Minimize", Description = "fa-window-minimize", GroupName = "duotone light regular solid")]
        IconWindowMinimize = '\uf2d1',
        
        /// <summary>
        ///     Window Restore ("fa-window-restore", \uf2d2) icon.
        /// </summary>
        /// 
        [Display(Name = "Window Restore", Description = "fa-window-restore", GroupName = "duotone light regular solid")]
        IconWindowRestore = '\uf2d2',
        
        /// <summary>
        ///     Windows ("fa-windows", \uf17a) icon.
        /// </summary>
        /// 
        [Display(Name = "Windows", Description = "fa-windows", GroupName = "brands")]
        IconWindows = '\uf17a',
        
        /// <summary>
        ///     Wine Bottle ("fa-wine-bottle", \uf72f) icon.
        /// </summary>
        /// 
        [Display(Name = "Wine Bottle", Description = "fa-wine-bottle", GroupName = "duotone light regular solid")]
        IconWineBottle = '\uf72f',
        
        /// <summary>
        ///     Wine Glass ("fa-wine-glass", \uf4e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Wine Glass", Description = "fa-wine-glass", GroupName = "duotone light regular solid")]
        IconWineGlass = '\uf4e3',
        
        /// <summary>
        ///     Wine Glass Alt ("fa-wine-glass-alt", \uf5ce) icon.
        /// </summary>
        /// 
        [Display(Name = "Wine Glass Alt", Description = "fa-wine-glass-alt", GroupName = "duotone light regular solid")]
        IconWineGlassAlt = '\uf5ce',
        
        /// <summary>
        ///     Wix ("fa-wix", \uf5cf) icon.
        /// </summary>
        /// 
        [Display(Name = "Wix", Description = "fa-wix", GroupName = "brands")]
        IconWix = '\uf5cf',
        
        /// <summary>
        ///     Wizards Of The Coast ("fa-wizards-of-the-coast", \uf730) icon.
        /// </summary>
        /// 
        [Display(Name = "Wizards Of The Coast", Description = "fa-wizards-of-the-coast", GroupName = "brands")]
        IconWizardsOfTheCoast = '\uf730',
        
        /// <summary>
        ///     Wolf Pack Battalion ("fa-wolf-pack-battalion", \uf514) icon.
        /// </summary>
        /// 
        [Display(Name = "Wolf Pack Battalion", Description = "fa-wolf-pack-battalion", GroupName = "brands")]
        IconWolfPackBattalion = '\uf514',
        
        /// <summary>
        ///     Won Sign ("fa-won-sign", \uf159) icon.
        /// </summary>
        /// 
        [Display(Name = "Won Sign", Description = "fa-won-sign", GroupName = "duotone light regular solid")]
        IconWonSign = '\uf159',
        
        /// <summary>
        ///     Wordpress ("fa-wordpress", \uf19a) icon.
        /// </summary>
        /// 
        [Display(Name = "Wordpress", Description = "fa-wordpress", GroupName = "brands")]
        IconWordpress = '\uf19a',
        
        /// <summary>
        ///     Wordpress Simple ("fa-wordpress-simple", \uf411) icon.
        /// </summary>
        /// 
        [Display(Name = "Wordpress Simple", Description = "fa-wordpress-simple", GroupName = "brands")]
        IconWordpressSimple = '\uf411',
        
        /// <summary>
        ///     Wpbeginner ("fa-wpbeginner", \uf297) icon.
        /// </summary>
        /// 
        [Display(Name = "Wpbeginner", Description = "fa-wpbeginner", GroupName = "brands")]
        IconWpbeginner = '\uf297',
        
        /// <summary>
        ///     Wpexplorer ("fa-wpexplorer", \uf2de) icon.
        /// </summary>
        /// 
        [Display(Name = "Wpexplorer", Description = "fa-wpexplorer", GroupName = "brands")]
        IconWpexplorer = '\uf2de',
        
        /// <summary>
        ///     Wpforms ("fa-wpforms", \uf298) icon.
        /// </summary>
        /// 
        [Display(Name = "Wpforms", Description = "fa-wpforms", GroupName = "brands")]
        IconWpforms = '\uf298',
        
        /// <summary>
        ///     Wpressr ("fa-wpressr", \uf3e4) icon.
        /// </summary>
        /// 
        [Display(Name = "Wpressr", Description = "fa-wpressr", GroupName = "brands")]
        IconWpressr = '\uf3e4',
        
        /// <summary>
        ///     Wrench ("fa-wrench", \uf0ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Wrench", Description = "fa-wrench", GroupName = "duotone light regular solid")]
        IconWrench = '\uf0ad',
        
        /// <summary>
        ///     Xbox ("fa-xbox", \uf412) icon.
        /// </summary>
        /// 
        [Display(Name = "Xbox", Description = "fa-xbox", GroupName = "brands")]
        IconXbox = '\uf412',
        
        /// <summary>
        ///     Xing ("fa-xing", \uf168) icon.
        /// </summary>
        /// 
        [Display(Name = "Xing", Description = "fa-xing", GroupName = "brands")]
        IconXing = '\uf168',
        
        /// <summary>
        ///     Xing Square ("fa-xing-square", \uf169) icon.
        /// </summary>
        /// 
        [Display(Name = "Xing Square", Description = "fa-xing-square", GroupName = "brands")]
        IconXingSquare = '\uf169',
        
        /// <summary>
        ///     X Ray ("fa-x-ray", \uf497) icon.
        /// </summary>
        /// 
        [Display(Name = "X Ray", Description = "fa-x-ray", GroupName = "duotone light regular solid")]
        IconXRay = '\uf497',
        
        /// <summary>
        ///     Yahoo ("fa-yahoo", \uf19e) icon.
        /// </summary>
        /// 
        [Display(Name = "Yahoo", Description = "fa-yahoo", GroupName = "brands")]
        IconYahoo = '\uf19e',
        
        /// <summary>
        ///     Yammer ("fa-yammer", \uf840) icon.
        /// </summary>
        /// 
        [Display(Name = "Yammer", Description = "fa-yammer", GroupName = "brands")]
        IconYammer = '\uf840',
        
        /// <summary>
        ///     Yandex ("fa-yandex", \uf413) icon.
        /// </summary>
        /// 
        [Display(Name = "Yandex", Description = "fa-yandex", GroupName = "brands")]
        IconYandex = '\uf413',
        
        /// <summary>
        ///     Yandex International ("fa-yandex-international", \uf414) icon.
        /// </summary>
        /// 
        [Display(Name = "Yandex International", Description = "fa-yandex-international", GroupName = "brands")]
        IconYandexInternational = '\uf414',
        
        /// <summary>
        ///     Yarn ("fa-yarn", \uf7e3) icon.
        /// </summary>
        /// 
        [Display(Name = "Yarn", Description = "fa-yarn", GroupName = "brands")]
        IconYarn = '\uf7e3',
        
        /// <summary>
        ///     Y Combinator ("fa-y-combinator", \uf23b) icon.
        /// </summary>
        /// 
        [Display(Name = "Y Combinator", Description = "fa-y-combinator", GroupName = "brands")]
        IconYCombinator = '\uf23b',
        
        /// <summary>
        ///     Yelp ("fa-yelp", \uf1e9) icon.
        /// </summary>
        /// 
        [Display(Name = "Yelp", Description = "fa-yelp", GroupName = "brands")]
        IconYelp = '\uf1e9',
        
        /// <summary>
        ///     Yen Sign ("fa-yen-sign", \uf157) icon.
        /// </summary>
        /// 
        [Display(Name = "Yen Sign", Description = "fa-yen-sign", GroupName = "duotone light regular solid")]
        IconYenSign = '\uf157',
        
        /// <summary>
        ///     Yin Yang ("fa-yin-yang", \uf6ad) icon.
        /// </summary>
        /// 
        [Display(Name = "Yin Yang", Description = "fa-yin-yang", GroupName = "duotone light regular solid")]
        IconYinYang = '\uf6ad',
        
        /// <summary>
        ///     Yoast ("fa-yoast", \uf2b1) icon.
        /// </summary>
        /// 
        [Display(Name = "Yoast", Description = "fa-yoast", GroupName = "brands")]
        IconYoast = '\uf2b1',
        
        /// <summary>
        ///     Youtube ("fa-youtube", \uf167) icon.
        /// </summary>
        /// 
        [Display(Name = "Youtube", Description = "fa-youtube", GroupName = "brands")]
        IconYoutube = '\uf167',
        
        /// <summary>
        ///     Youtube Square ("fa-youtube-square", \uf431) icon.
        /// </summary>
        /// 
        [Display(Name = "Youtube Square", Description = "fa-youtube-square", GroupName = "brands")]
        IconYoutubeSquare = '\uf431',
        
        /// <summary>
        ///     Zhihu ("fa-zhihu", \uf63f) icon.
        /// </summary>
        /// 
        [Display(Name = "Zhihu", Description = "fa-zhihu", GroupName = "brands")]
        IconZhihu = '\uf63f',
        
    }
    
    public static partial class Extensions
    {
        /// <summary>
        ///   Gets the CSS class associated with a <see cref="FontAwesome"/> icon.
        /// </summary>
        /// 
        public static string GetCss(this FontAwesome icon) => icon switch
        {
            FontAwesome.Icon500Px => "fa-500px",
            FontAwesome.IconAccessibleIcon => "fa-accessible-icon",
            FontAwesome.IconAccusoft => "fa-accusoft",
            FontAwesome.IconAcquisitionsIncorporated => "fa-acquisitions-incorporated",
            FontAwesome.IconAd => "fa-ad",
            FontAwesome.IconAddressBook => "fa-address-book",
            FontAwesome.IconAddressCard => "fa-address-card",
            FontAwesome.IconAdjust => "fa-adjust",
            FontAwesome.IconAdn => "fa-adn",
            FontAwesome.IconAdobe => "fa-adobe",
            FontAwesome.IconAdversal => "fa-adversal",
            FontAwesome.IconAffiliatetheme => "fa-affiliatetheme",
            FontAwesome.IconAirbnb => "fa-airbnb",
            FontAwesome.IconAirFreshener => "fa-air-freshener",
            FontAwesome.IconAlgolia => "fa-algolia",
            FontAwesome.IconAlignCenter => "fa-align-center",
            FontAwesome.IconAlignJustify => "fa-align-justify",
            FontAwesome.IconAlignLeft => "fa-align-left",
            FontAwesome.IconAlignRight => "fa-align-right",
            FontAwesome.IconAlipay => "fa-alipay",
            FontAwesome.IconAllergies => "fa-allergies",
            FontAwesome.IconAmazon => "fa-amazon",
            FontAwesome.IconAmazonPay => "fa-amazon-pay",
            FontAwesome.IconAmbulance => "fa-ambulance",
            FontAwesome.IconAmericanSignLanguageInterpreting => "fa-american-sign-language-interpreting",
            FontAwesome.IconAmilia => "fa-amilia",
            FontAwesome.IconAnchor => "fa-anchor",
            FontAwesome.IconAndroid => "fa-android",
            FontAwesome.IconAngellist => "fa-angellist",
            FontAwesome.IconAngleDoubleDown => "fa-angle-double-down",
            FontAwesome.IconAngleDoubleLeft => "fa-angle-double-left",
            FontAwesome.IconAngleDoubleRight => "fa-angle-double-right",
            FontAwesome.IconAngleDoubleUp => "fa-angle-double-up",
            FontAwesome.IconAngleDown => "fa-angle-down",
            FontAwesome.IconAngleLeft => "fa-angle-left",
            FontAwesome.IconAngleRight => "fa-angle-right",
            FontAwesome.IconAngleUp => "fa-angle-up",
            FontAwesome.IconAngry => "fa-angry",
            FontAwesome.IconAngrycreative => "fa-angrycreative",
            FontAwesome.IconAngular => "fa-angular",
            FontAwesome.IconAnkh => "fa-ankh",
            FontAwesome.IconApper => "fa-apper",
            FontAwesome.IconApple => "fa-apple",
            FontAwesome.IconAppleAlt => "fa-apple-alt",
            FontAwesome.IconApplePay => "fa-apple-pay",
            FontAwesome.IconAppStore => "fa-app-store",
            FontAwesome.IconAppStoreIos => "fa-app-store-ios",
            FontAwesome.IconArchive => "fa-archive",
            FontAwesome.IconArchway => "fa-archway",
            FontAwesome.IconArrowAltCircleDown => "fa-arrow-alt-circle-down",
            FontAwesome.IconArrowAltCircleLeft => "fa-arrow-alt-circle-left",
            FontAwesome.IconArrowAltCircleRight => "fa-arrow-alt-circle-right",
            FontAwesome.IconArrowAltCircleUp => "fa-arrow-alt-circle-up",
            FontAwesome.IconArrowCircleDown => "fa-arrow-circle-down",
            FontAwesome.IconArrowCircleLeft => "fa-arrow-circle-left",
            FontAwesome.IconArrowCircleRight => "fa-arrow-circle-right",
            FontAwesome.IconArrowCircleUp => "fa-arrow-circle-up",
            FontAwesome.IconArrowDown => "fa-arrow-down",
            FontAwesome.IconArrowLeft => "fa-arrow-left",
            FontAwesome.IconArrowRight => "fa-arrow-right",
            FontAwesome.IconArrowsAlt => "fa-arrows-alt",
            FontAwesome.IconArrowsAltH => "fa-arrows-alt-h",
            FontAwesome.IconArrowsAltV => "fa-arrows-alt-v",
            FontAwesome.IconArrowUp => "fa-arrow-up",
            FontAwesome.IconArtstation => "fa-artstation",
            FontAwesome.IconAssistiveListeningSystems => "fa-assistive-listening-systems",
            FontAwesome.IconAsterisk => "fa-asterisk",
            FontAwesome.IconAsymmetrik => "fa-asymmetrik",
            FontAwesome.IconAt => "fa-at",
            FontAwesome.IconAtlas => "fa-atlas",
            FontAwesome.IconAtlassian => "fa-atlassian",
            FontAwesome.IconAtom => "fa-atom",
            FontAwesome.IconAudible => "fa-audible",
            FontAwesome.IconAudioDescription => "fa-audio-description",
            FontAwesome.IconAutoprefixer => "fa-autoprefixer",
            FontAwesome.IconAvianex => "fa-avianex",
            FontAwesome.IconAviato => "fa-aviato",
            FontAwesome.IconAward => "fa-award",
            FontAwesome.IconAws => "fa-aws",
            FontAwesome.IconBaby => "fa-baby",
            FontAwesome.IconBabyCarriage => "fa-baby-carriage",
            FontAwesome.IconBackspace => "fa-backspace",
            FontAwesome.IconBackward => "fa-backward",
            FontAwesome.IconBacon => "fa-bacon",
            FontAwesome.IconBahai => "fa-bahai",
            FontAwesome.IconBalanceScale => "fa-balance-scale",
            FontAwesome.IconBalanceScaleLeft => "fa-balance-scale-left",
            FontAwesome.IconBalanceScaleRight => "fa-balance-scale-right",
            FontAwesome.IconBan => "fa-ban",
            FontAwesome.IconBandAid => "fa-band-aid",
            FontAwesome.IconBandcamp => "fa-bandcamp",
            FontAwesome.IconBarcode => "fa-barcode",
            FontAwesome.IconBars => "fa-bars",
            FontAwesome.IconBaseballBall => "fa-baseball-ball",
            FontAwesome.IconBasketballBall => "fa-basketball-ball",
            FontAwesome.IconBath => "fa-bath",
            FontAwesome.IconBatteryEmpty => "fa-battery-empty",
            FontAwesome.IconBatteryFull => "fa-battery-full",
            FontAwesome.IconBatteryHalf => "fa-battery-half",
            FontAwesome.IconBatteryQuarter => "fa-battery-quarter",
            FontAwesome.IconBatteryThreeQuarters => "fa-battery-three-quarters",
            FontAwesome.IconBattleNet => "fa-battle-net",
            FontAwesome.IconBed => "fa-bed",
            FontAwesome.IconBeer => "fa-beer",
            FontAwesome.IconBehance => "fa-behance",
            FontAwesome.IconBehanceSquare => "fa-behance-square",
            FontAwesome.IconBell => "fa-bell",
            FontAwesome.IconBellSlash => "fa-bell-slash",
            FontAwesome.IconBezierCurve => "fa-bezier-curve",
            FontAwesome.IconBible => "fa-bible",
            FontAwesome.IconBicycle => "fa-bicycle",
            FontAwesome.IconBiking => "fa-biking",
            FontAwesome.IconBimobject => "fa-bimobject",
            FontAwesome.IconBinoculars => "fa-binoculars",
            FontAwesome.IconBiohazard => "fa-biohazard",
            FontAwesome.IconBirthdayCake => "fa-birthday-cake",
            FontAwesome.IconBitbucket => "fa-bitbucket",
            FontAwesome.IconBitcoin => "fa-bitcoin",
            FontAwesome.IconBity => "fa-bity",
            FontAwesome.IconBlackberry => "fa-blackberry",
            FontAwesome.IconBlackTie => "fa-black-tie",
            FontAwesome.IconBlender => "fa-blender",
            FontAwesome.IconBlenderPhone => "fa-blender-phone",
            FontAwesome.IconBlind => "fa-blind",
            FontAwesome.IconBlog => "fa-blog",
            FontAwesome.IconBlogger => "fa-blogger",
            FontAwesome.IconBloggerB => "fa-blogger-b",
            FontAwesome.IconBluetooth => "fa-bluetooth",
            FontAwesome.IconBluetoothB => "fa-bluetooth-b",
            FontAwesome.IconBold => "fa-bold",
            FontAwesome.IconBolt => "fa-bolt",
            FontAwesome.IconBomb => "fa-bomb",
            FontAwesome.IconBone => "fa-bone",
            FontAwesome.IconBong => "fa-bong",
            FontAwesome.IconBook => "fa-book",
            FontAwesome.IconBookDead => "fa-book-dead",
            FontAwesome.IconBookmark => "fa-bookmark",
            FontAwesome.IconBookMedical => "fa-book-medical",
            FontAwesome.IconBookOpen => "fa-book-open",
            FontAwesome.IconBookReader => "fa-book-reader",
            FontAwesome.IconBootstrap => "fa-bootstrap",
            FontAwesome.IconBorderAll => "fa-border-all",
            FontAwesome.IconBorderNone => "fa-border-none",
            FontAwesome.IconBorderStyle => "fa-border-style",
            FontAwesome.IconBowlingBall => "fa-bowling-ball",
            FontAwesome.IconBox => "fa-box",
            FontAwesome.IconBoxes => "fa-boxes",
            FontAwesome.IconBoxOpen => "fa-box-open",
            FontAwesome.IconBoxTissue => "fa-box-tissue",
            FontAwesome.IconBraille => "fa-braille",
            FontAwesome.IconBrain => "fa-brain",
            FontAwesome.IconBreadSlice => "fa-bread-slice",
            FontAwesome.IconBriefcase => "fa-briefcase",
            FontAwesome.IconBriefcaseMedical => "fa-briefcase-medical",
            FontAwesome.IconBroadcastTower => "fa-broadcast-tower",
            FontAwesome.IconBroom => "fa-broom",
            FontAwesome.IconBrush => "fa-brush",
            FontAwesome.IconBtc => "fa-btc",
            FontAwesome.IconBuffer => "fa-buffer",
            FontAwesome.IconBug => "fa-bug",
            FontAwesome.IconBuilding => "fa-building",
            FontAwesome.IconBullhorn => "fa-bullhorn",
            FontAwesome.IconBullseye => "fa-bullseye",
            FontAwesome.IconBurn => "fa-burn",
            FontAwesome.IconBuromobelexperte => "fa-buromobelexperte",
            FontAwesome.IconBus => "fa-bus",
            FontAwesome.IconBusAlt => "fa-bus-alt",
            FontAwesome.IconBusinessTime => "fa-business-time",
            FontAwesome.IconBuyNLarge => "fa-buy-n-large",
            FontAwesome.IconBuysellads => "fa-buysellads",
            FontAwesome.IconCalculator => "fa-calculator",
            FontAwesome.IconCalendar => "fa-calendar",
            FontAwesome.IconCalendarAlt => "fa-calendar-alt",
            FontAwesome.IconCalendarCheck => "fa-calendar-check",
            FontAwesome.IconCalendarDay => "fa-calendar-day",
            FontAwesome.IconCalendarMinus => "fa-calendar-minus",
            FontAwesome.IconCalendarPlus => "fa-calendar-plus",
            FontAwesome.IconCalendarTimes => "fa-calendar-times",
            FontAwesome.IconCalendarWeek => "fa-calendar-week",
            FontAwesome.IconCamera => "fa-camera",
            FontAwesome.IconCameraRetro => "fa-camera-retro",
            FontAwesome.IconCampground => "fa-campground",
            FontAwesome.IconCanadianMapleLeaf => "fa-canadian-maple-leaf",
            FontAwesome.IconCandyCane => "fa-candy-cane",
            FontAwesome.IconCannabis => "fa-cannabis",
            FontAwesome.IconCapsules => "fa-capsules",
            FontAwesome.IconCar => "fa-car",
            FontAwesome.IconCarAlt => "fa-car-alt",
            FontAwesome.IconCaravan => "fa-caravan",
            FontAwesome.IconCarBattery => "fa-car-battery",
            FontAwesome.IconCarCrash => "fa-car-crash",
            FontAwesome.IconCaretDown => "fa-caret-down",
            FontAwesome.IconCaretLeft => "fa-caret-left",
            FontAwesome.IconCaretRight => "fa-caret-right",
            FontAwesome.IconCaretSquareDown => "fa-caret-square-down",
            FontAwesome.IconCaretSquareLeft => "fa-caret-square-left",
            FontAwesome.IconCaretSquareRight => "fa-caret-square-right",
            FontAwesome.IconCaretSquareUp => "fa-caret-square-up",
            FontAwesome.IconCaretUp => "fa-caret-up",
            FontAwesome.IconCarrot => "fa-carrot",
            FontAwesome.IconCarSide => "fa-car-side",
            FontAwesome.IconCartArrowDown => "fa-cart-arrow-down",
            FontAwesome.IconCartPlus => "fa-cart-plus",
            FontAwesome.IconCashRegister => "fa-cash-register",
            FontAwesome.IconCat => "fa-cat",
            FontAwesome.IconCcAmazonPay => "fa-cc-amazon-pay",
            FontAwesome.IconCcAmex => "fa-cc-amex",
            FontAwesome.IconCcApplePay => "fa-cc-apple-pay",
            FontAwesome.IconCcDinersClub => "fa-cc-diners-club",
            FontAwesome.IconCcDiscover => "fa-cc-discover",
            FontAwesome.IconCcJcb => "fa-cc-jcb",
            FontAwesome.IconCcMastercard => "fa-cc-mastercard",
            FontAwesome.IconCcPaypal => "fa-cc-paypal",
            FontAwesome.IconCcStripe => "fa-cc-stripe",
            FontAwesome.IconCcVisa => "fa-cc-visa",
            FontAwesome.IconCentercode => "fa-centercode",
            FontAwesome.IconCentos => "fa-centos",
            FontAwesome.IconCertificate => "fa-certificate",
            FontAwesome.IconChair => "fa-chair",
            FontAwesome.IconChalkboard => "fa-chalkboard",
            FontAwesome.IconChalkboardTeacher => "fa-chalkboard-teacher",
            FontAwesome.IconChargingStation => "fa-charging-station",
            FontAwesome.IconChartArea => "fa-chart-area",
            FontAwesome.IconChartBar => "fa-chart-bar",
            FontAwesome.IconChartLine => "fa-chart-line",
            FontAwesome.IconChartPie => "fa-chart-pie",
            FontAwesome.IconCheck => "fa-check",
            FontAwesome.IconCheckCircle => "fa-check-circle",
            FontAwesome.IconCheckDouble => "fa-check-double",
            FontAwesome.IconCheckSquare => "fa-check-square",
            FontAwesome.IconCheese => "fa-cheese",
            FontAwesome.IconChess => "fa-chess",
            FontAwesome.IconChessBishop => "fa-chess-bishop",
            FontAwesome.IconChessBoard => "fa-chess-board",
            FontAwesome.IconChessKing => "fa-chess-king",
            FontAwesome.IconChessKnight => "fa-chess-knight",
            FontAwesome.IconChessPawn => "fa-chess-pawn",
            FontAwesome.IconChessQueen => "fa-chess-queen",
            FontAwesome.IconChessRook => "fa-chess-rook",
            FontAwesome.IconChevronCircleDown => "fa-chevron-circle-down",
            FontAwesome.IconChevronCircleLeft => "fa-chevron-circle-left",
            FontAwesome.IconChevronCircleRight => "fa-chevron-circle-right",
            FontAwesome.IconChevronCircleUp => "fa-chevron-circle-up",
            FontAwesome.IconChevronDown => "fa-chevron-down",
            FontAwesome.IconChevronLeft => "fa-chevron-left",
            FontAwesome.IconChevronRight => "fa-chevron-right",
            FontAwesome.IconChevronUp => "fa-chevron-up",
            FontAwesome.IconChild => "fa-child",
            FontAwesome.IconChrome => "fa-chrome",
            FontAwesome.IconChromecast => "fa-chromecast",
            FontAwesome.IconChurch => "fa-church",
            FontAwesome.IconCircle => "fa-circle",
            FontAwesome.IconCircleNotch => "fa-circle-notch",
            FontAwesome.IconCity => "fa-city",
            FontAwesome.IconClinicMedical => "fa-clinic-medical",
            FontAwesome.IconClipboard => "fa-clipboard",
            FontAwesome.IconClipboardCheck => "fa-clipboard-check",
            FontAwesome.IconClipboardList => "fa-clipboard-list",
            FontAwesome.IconClock => "fa-clock",
            FontAwesome.IconClone => "fa-clone",
            FontAwesome.IconClosedCaptioning => "fa-closed-captioning",
            FontAwesome.IconCloud => "fa-cloud",
            FontAwesome.IconCloudDownloadAlt => "fa-cloud-download-alt",
            FontAwesome.IconCloudMeatball => "fa-cloud-meatball",
            FontAwesome.IconCloudMoon => "fa-cloud-moon",
            FontAwesome.IconCloudMoonRain => "fa-cloud-moon-rain",
            FontAwesome.IconCloudRain => "fa-cloud-rain",
            FontAwesome.IconCloudscale => "fa-cloudscale",
            FontAwesome.IconCloudShowersHeavy => "fa-cloud-showers-heavy",
            FontAwesome.IconCloudsmith => "fa-cloudsmith",
            FontAwesome.IconCloudSun => "fa-cloud-sun",
            FontAwesome.IconCloudSunRain => "fa-cloud-sun-rain",
            FontAwesome.IconCloudUploadAlt => "fa-cloud-upload-alt",
            FontAwesome.IconCloudversify => "fa-cloudversify",
            FontAwesome.IconCocktail => "fa-cocktail",
            FontAwesome.IconCode => "fa-code",
            FontAwesome.IconCodeBranch => "fa-code-branch",
            FontAwesome.IconCodepen => "fa-codepen",
            FontAwesome.IconCodiepie => "fa-codiepie",
            FontAwesome.IconCoffee => "fa-coffee",
            FontAwesome.IconCog => "fa-cog",
            FontAwesome.IconCogs => "fa-cogs",
            FontAwesome.IconCoins => "fa-coins",
            FontAwesome.IconColumns => "fa-columns",
            FontAwesome.IconComment => "fa-comment",
            FontAwesome.IconCommentAlt => "fa-comment-alt",
            FontAwesome.IconCommentDollar => "fa-comment-dollar",
            FontAwesome.IconCommentDots => "fa-comment-dots",
            FontAwesome.IconCommentMedical => "fa-comment-medical",
            FontAwesome.IconComments => "fa-comments",
            FontAwesome.IconCommentsDollar => "fa-comments-dollar",
            FontAwesome.IconCommentSlash => "fa-comment-slash",
            FontAwesome.IconCompactDisc => "fa-compact-disc",
            FontAwesome.IconCompass => "fa-compass",
            FontAwesome.IconCompress => "fa-compress",
            FontAwesome.IconCompressAlt => "fa-compress-alt",
            FontAwesome.IconCompressArrowsAlt => "fa-compress-arrows-alt",
            FontAwesome.IconConciergeBell => "fa-concierge-bell",
            FontAwesome.IconConfluence => "fa-confluence",
            FontAwesome.IconConnectdevelop => "fa-connectdevelop",
            FontAwesome.IconContao => "fa-contao",
            FontAwesome.IconCookie => "fa-cookie",
            FontAwesome.IconCookieBite => "fa-cookie-bite",
            FontAwesome.IconCopy => "fa-copy",
            FontAwesome.IconCopyright => "fa-copyright",
            FontAwesome.IconCottonBureau => "fa-cotton-bureau",
            FontAwesome.IconCouch => "fa-couch",
            FontAwesome.IconCpanel => "fa-cpanel",
            FontAwesome.IconCreativeCommons => "fa-creative-commons",
            FontAwesome.IconCreativeCommonsBy => "fa-creative-commons-by",
            FontAwesome.IconCreativeCommonsNc => "fa-creative-commons-nc",
            FontAwesome.IconCreativeCommonsNcEu => "fa-creative-commons-nc-eu",
            FontAwesome.IconCreativeCommonsNcJp => "fa-creative-commons-nc-jp",
            FontAwesome.IconCreativeCommonsNd => "fa-creative-commons-nd",
            FontAwesome.IconCreativeCommonsPd => "fa-creative-commons-pd",
            FontAwesome.IconCreativeCommonsPdAlt => "fa-creative-commons-pd-alt",
            FontAwesome.IconCreativeCommonsRemix => "fa-creative-commons-remix",
            FontAwesome.IconCreativeCommonsSa => "fa-creative-commons-sa",
            FontAwesome.IconCreativeCommonsSampling => "fa-creative-commons-sampling",
            FontAwesome.IconCreativeCommonsSamplingPlus => "fa-creative-commons-sampling-plus",
            FontAwesome.IconCreativeCommonsShare => "fa-creative-commons-share",
            FontAwesome.IconCreativeCommonsZero => "fa-creative-commons-zero",
            FontAwesome.IconCreditCard => "fa-credit-card",
            FontAwesome.IconCriticalRole => "fa-critical-role",
            FontAwesome.IconCrop => "fa-crop",
            FontAwesome.IconCropAlt => "fa-crop-alt",
            FontAwesome.IconCross => "fa-cross",
            FontAwesome.IconCrosshairs => "fa-crosshairs",
            FontAwesome.IconCrow => "fa-crow",
            FontAwesome.IconCrown => "fa-crown",
            FontAwesome.IconCrutch => "fa-crutch",
            FontAwesome.IconCss3 => "fa-css3",
            FontAwesome.IconCss3Alt => "fa-css3-alt",
            FontAwesome.IconCube => "fa-cube",
            FontAwesome.IconCubes => "fa-cubes",
            FontAwesome.IconCut => "fa-cut",
            FontAwesome.IconCuttlefish => "fa-cuttlefish",
            FontAwesome.IconDailymotion => "fa-dailymotion",
            FontAwesome.IconDAndD => "fa-d-and-d",
            FontAwesome.IconDAndDBeyond => "fa-d-and-d-beyond",
            FontAwesome.IconDashcube => "fa-dashcube",
            FontAwesome.IconDatabase => "fa-database",
            FontAwesome.IconDeaf => "fa-deaf",
            FontAwesome.IconDelicious => "fa-delicious",
            FontAwesome.IconDemocrat => "fa-democrat",
            FontAwesome.IconDeploydog => "fa-deploydog",
            FontAwesome.IconDeskpro => "fa-deskpro",
            FontAwesome.IconDesktop => "fa-desktop",
            FontAwesome.IconDev => "fa-dev",
            FontAwesome.IconDeviantart => "fa-deviantart",
            FontAwesome.IconDharmachakra => "fa-dharmachakra",
            FontAwesome.IconDhl => "fa-dhl",
            FontAwesome.IconDiagnoses => "fa-diagnoses",
            FontAwesome.IconDiaspora => "fa-diaspora",
            FontAwesome.IconDice => "fa-dice",
            FontAwesome.IconDiceD20 => "fa-dice-d20",
            FontAwesome.IconDiceD6 => "fa-dice-d6",
            FontAwesome.IconDiceFive => "fa-dice-five",
            FontAwesome.IconDiceFour => "fa-dice-four",
            FontAwesome.IconDiceOne => "fa-dice-one",
            FontAwesome.IconDiceSix => "fa-dice-six",
            FontAwesome.IconDiceThree => "fa-dice-three",
            FontAwesome.IconDiceTwo => "fa-dice-two",
            FontAwesome.IconDigg => "fa-digg",
            FontAwesome.IconDigitalOcean => "fa-digital-ocean",
            FontAwesome.IconDigitalTachograph => "fa-digital-tachograph",
            FontAwesome.IconDirections => "fa-directions",
            FontAwesome.IconDiscord => "fa-discord",
            FontAwesome.IconDiscourse => "fa-discourse",
            FontAwesome.IconDisease => "fa-disease",
            FontAwesome.IconDivide => "fa-divide",
            FontAwesome.IconDizzy => "fa-dizzy",
            FontAwesome.IconDna => "fa-dna",
            FontAwesome.IconDochub => "fa-dochub",
            FontAwesome.IconDocker => "fa-docker",
            FontAwesome.IconDog => "fa-dog",
            FontAwesome.IconDollarSign => "fa-dollar-sign",
            FontAwesome.IconDolly => "fa-dolly",
            FontAwesome.IconDollyFlatbed => "fa-dolly-flatbed",
            FontAwesome.IconDonate => "fa-donate",
            FontAwesome.IconDoorClosed => "fa-door-closed",
            FontAwesome.IconDoorOpen => "fa-door-open",
            FontAwesome.IconDotCircle => "fa-dot-circle",
            FontAwesome.IconDove => "fa-dove",
            FontAwesome.IconDownload => "fa-download",
            FontAwesome.IconDraft2digital => "fa-draft2digital",
            FontAwesome.IconDraftingCompass => "fa-drafting-compass",
            FontAwesome.IconDragon => "fa-dragon",
            FontAwesome.IconDrawPolygon => "fa-draw-polygon",
            FontAwesome.IconDribbble => "fa-dribbble",
            FontAwesome.IconDribbbleSquare => "fa-dribbble-square",
            FontAwesome.IconDropbox => "fa-dropbox",
            FontAwesome.IconDrum => "fa-drum",
            FontAwesome.IconDrumSteelpan => "fa-drum-steelpan",
            FontAwesome.IconDrumstickBite => "fa-drumstick-bite",
            FontAwesome.IconDrupal => "fa-drupal",
            FontAwesome.IconDumbbell => "fa-dumbbell",
            FontAwesome.IconDumpster => "fa-dumpster",
            FontAwesome.IconDumpsterFire => "fa-dumpster-fire",
            FontAwesome.IconDungeon => "fa-dungeon",
            FontAwesome.IconDyalog => "fa-dyalog",
            FontAwesome.IconEarlybirds => "fa-earlybirds",
            FontAwesome.IconEbay => "fa-ebay",
            FontAwesome.IconEdge => "fa-edge",
            FontAwesome.IconEdit => "fa-edit",
            FontAwesome.IconEgg => "fa-egg",
            FontAwesome.IconEject => "fa-eject",
            FontAwesome.IconElementor => "fa-elementor",
            FontAwesome.IconEllipsisH => "fa-ellipsis-h",
            FontAwesome.IconEllipsisV => "fa-ellipsis-v",
            FontAwesome.IconEllo => "fa-ello",
            FontAwesome.IconEmber => "fa-ember",
            FontAwesome.IconEmpire => "fa-empire",
            FontAwesome.IconEnvelope => "fa-envelope",
            FontAwesome.IconEnvelopeOpen => "fa-envelope-open",
            FontAwesome.IconEnvelopeOpenText => "fa-envelope-open-text",
            FontAwesome.IconEnvelopeSquare => "fa-envelope-square",
            FontAwesome.IconEnvira => "fa-envira",
            FontAwesome.IconEquals => "fa-equals",
            FontAwesome.IconEraser => "fa-eraser",
            FontAwesome.IconErlang => "fa-erlang",
            FontAwesome.IconEthereum => "fa-ethereum",
            FontAwesome.IconEthernet => "fa-ethernet",
            FontAwesome.IconEtsy => "fa-etsy",
            FontAwesome.IconEuroSign => "fa-euro-sign",
            FontAwesome.IconEvernote => "fa-evernote",
            FontAwesome.IconExchangeAlt => "fa-exchange-alt",
            FontAwesome.IconExclamation => "fa-exclamation",
            FontAwesome.IconExclamationCircle => "fa-exclamation-circle",
            FontAwesome.IconExclamationTriangle => "fa-exclamation-triangle",
            FontAwesome.IconExpand => "fa-expand",
            FontAwesome.IconExpandAlt => "fa-expand-alt",
            FontAwesome.IconExpandArrowsAlt => "fa-expand-arrows-alt",
            FontAwesome.IconExpeditedssl => "fa-expeditedssl",
            FontAwesome.IconExternalLinkAlt => "fa-external-link-alt",
            FontAwesome.IconExternalLinkSquareAlt => "fa-external-link-square-alt",
            FontAwesome.IconEye => "fa-eye",
            FontAwesome.IconEyeDropper => "fa-eye-dropper",
            FontAwesome.IconEyeSlash => "fa-eye-slash",
            FontAwesome.IconFacebook => "fa-facebook",
            FontAwesome.IconFacebookF => "fa-facebook-f",
            FontAwesome.IconFacebookMessenger => "fa-facebook-messenger",
            FontAwesome.IconFacebookSquare => "fa-facebook-square",
            FontAwesome.IconFan => "fa-fan",
            FontAwesome.IconFantasyFlightGames => "fa-fantasy-flight-games",
            FontAwesome.IconFastBackward => "fa-fast-backward",
            FontAwesome.IconFastForward => "fa-fast-forward",
            FontAwesome.IconFaucet => "fa-faucet",
            FontAwesome.IconFax => "fa-fax",
            FontAwesome.IconFeather => "fa-feather",
            FontAwesome.IconFeatherAlt => "fa-feather-alt",
            FontAwesome.IconFedex => "fa-fedex",
            FontAwesome.IconFedora => "fa-fedora",
            FontAwesome.IconFemale => "fa-female",
            FontAwesome.IconFighterJet => "fa-fighter-jet",
            FontAwesome.IconFigma => "fa-figma",
            FontAwesome.IconFile => "fa-file",
            FontAwesome.IconFileAlt => "fa-file-alt",
            FontAwesome.IconFileArchive => "fa-file-archive",
            FontAwesome.IconFileAudio => "fa-file-audio",
            FontAwesome.IconFileCode => "fa-file-code",
            FontAwesome.IconFileContract => "fa-file-contract",
            FontAwesome.IconFileCsv => "fa-file-csv",
            FontAwesome.IconFileDownload => "fa-file-download",
            FontAwesome.IconFileExcel => "fa-file-excel",
            FontAwesome.IconFileExport => "fa-file-export",
            FontAwesome.IconFileImage => "fa-file-image",
            FontAwesome.IconFileImport => "fa-file-import",
            FontAwesome.IconFileInvoice => "fa-file-invoice",
            FontAwesome.IconFileInvoiceDollar => "fa-file-invoice-dollar",
            FontAwesome.IconFileMedical => "fa-file-medical",
            FontAwesome.IconFileMedicalAlt => "fa-file-medical-alt",
            FontAwesome.IconFilePdf => "fa-file-pdf",
            FontAwesome.IconFilePowerpoint => "fa-file-powerpoint",
            FontAwesome.IconFilePrescription => "fa-file-prescription",
            FontAwesome.IconFileSignature => "fa-file-signature",
            FontAwesome.IconFileUpload => "fa-file-upload",
            FontAwesome.IconFileVideo => "fa-file-video",
            FontAwesome.IconFileWord => "fa-file-word",
            FontAwesome.IconFill => "fa-fill",
            FontAwesome.IconFillDrip => "fa-fill-drip",
            FontAwesome.IconFilm => "fa-film",
            FontAwesome.IconFilter => "fa-filter",
            FontAwesome.IconFingerprint => "fa-fingerprint",
            FontAwesome.IconFire => "fa-fire",
            FontAwesome.IconFireAlt => "fa-fire-alt",
            FontAwesome.IconFireExtinguisher => "fa-fire-extinguisher",
            FontAwesome.IconFirefox => "fa-firefox",
            FontAwesome.IconFirefoxBrowser => "fa-firefox-browser",
            FontAwesome.IconFirstAid => "fa-first-aid",
            FontAwesome.IconFirstdraft => "fa-firstdraft",
            FontAwesome.IconFirstOrder => "fa-first-order",
            FontAwesome.IconFirstOrderAlt => "fa-first-order-alt",
            FontAwesome.IconFish => "fa-fish",
            FontAwesome.IconFistRaised => "fa-fist-raised",
            FontAwesome.IconFlag => "fa-flag",
            FontAwesome.IconFlagCheckered => "fa-flag-checkered",
            FontAwesome.IconFlagUsa => "fa-flag-usa",
            FontAwesome.IconFlask => "fa-flask",
            FontAwesome.IconFlickr => "fa-flickr",
            FontAwesome.IconFlipboard => "fa-flipboard",
            FontAwesome.IconFlushed => "fa-flushed",
            FontAwesome.IconFly => "fa-fly",
            FontAwesome.IconFolder => "fa-folder",
            FontAwesome.IconFolderMinus => "fa-folder-minus",
            FontAwesome.IconFolderOpen => "fa-folder-open",
            FontAwesome.IconFolderPlus => "fa-folder-plus",
            FontAwesome.IconFont => "fa-font",
            FontAwesome.IconFontAwesome => "fa-font-awesome",
            FontAwesome.IconFontAwesomeAlt => "fa-font-awesome-alt",
            FontAwesome.IconFontAwesomeFlag => "fa-font-awesome-flag",
            FontAwesome.IconFontAwesomeLogoFull => "fa-font-awesome-logo-full",
            FontAwesome.IconFonticons => "fa-fonticons",
            FontAwesome.IconFonticonsFi => "fa-fonticons-fi",
            FontAwesome.IconFootballBall => "fa-football-ball",
            FontAwesome.IconFortAwesome => "fa-fort-awesome",
            FontAwesome.IconFortAwesomeAlt => "fa-fort-awesome-alt",
            FontAwesome.IconForumbee => "fa-forumbee",
            FontAwesome.IconForward => "fa-forward",
            FontAwesome.IconFoursquare => "fa-foursquare",
            FontAwesome.IconFreebsd => "fa-freebsd",
            FontAwesome.IconFreeCodeCamp => "fa-free-code-camp",
            FontAwesome.IconFrog => "fa-frog",
            FontAwesome.IconFrown => "fa-frown",
            FontAwesome.IconFrownOpen => "fa-frown-open",
            FontAwesome.IconFulcrum => "fa-fulcrum",
            FontAwesome.IconFunnelDollar => "fa-funnel-dollar",
            FontAwesome.IconFutbol => "fa-futbol",
            FontAwesome.IconGalacticRepublic => "fa-galactic-republic",
            FontAwesome.IconGalacticSenate => "fa-galactic-senate",
            FontAwesome.IconGamepad => "fa-gamepad",
            FontAwesome.IconGasPump => "fa-gas-pump",
            FontAwesome.IconGavel => "fa-gavel",
            FontAwesome.IconGem => "fa-gem",
            FontAwesome.IconGenderless => "fa-genderless",
            FontAwesome.IconGetPocket => "fa-get-pocket",
            FontAwesome.IconGg => "fa-gg",
            FontAwesome.IconGgCircle => "fa-gg-circle",
            FontAwesome.IconGhost => "fa-ghost",
            FontAwesome.IconGift => "fa-gift",
            FontAwesome.IconGifts => "fa-gifts",
            FontAwesome.IconGit => "fa-git",
            FontAwesome.IconGitAlt => "fa-git-alt",
            FontAwesome.IconGithub => "fa-github",
            FontAwesome.IconGithubAlt => "fa-github-alt",
            FontAwesome.IconGithubSquare => "fa-github-square",
            FontAwesome.IconGitkraken => "fa-gitkraken",
            FontAwesome.IconGitlab => "fa-gitlab",
            FontAwesome.IconGitSquare => "fa-git-square",
            FontAwesome.IconGitter => "fa-gitter",
            FontAwesome.IconGlassCheers => "fa-glass-cheers",
            FontAwesome.IconGlasses => "fa-glasses",
            FontAwesome.IconGlassMartini => "fa-glass-martini",
            FontAwesome.IconGlassMartiniAlt => "fa-glass-martini-alt",
            FontAwesome.IconGlassWhiskey => "fa-glass-whiskey",
            FontAwesome.IconGlide => "fa-glide",
            FontAwesome.IconGlideG => "fa-glide-g",
            FontAwesome.IconGlobe => "fa-globe",
            FontAwesome.IconGlobeAfrica => "fa-globe-africa",
            FontAwesome.IconGlobeAmericas => "fa-globe-americas",
            FontAwesome.IconGlobeAsia => "fa-globe-asia",
            FontAwesome.IconGlobeEurope => "fa-globe-europe",
            FontAwesome.IconGofore => "fa-gofore",
            FontAwesome.IconGolfBall => "fa-golf-ball",
            FontAwesome.IconGoodreads => "fa-goodreads",
            FontAwesome.IconGoodreadsG => "fa-goodreads-g",
            FontAwesome.IconGoogle => "fa-google",
            FontAwesome.IconGoogleDrive => "fa-google-drive",
            FontAwesome.IconGooglePlay => "fa-google-play",
            FontAwesome.IconGooglePlus => "fa-google-plus",
            FontAwesome.IconGooglePlusG => "fa-google-plus-g",
            FontAwesome.IconGooglePlusSquare => "fa-google-plus-square",
            FontAwesome.IconGoogleWallet => "fa-google-wallet",
            FontAwesome.IconGopuram => "fa-gopuram",
            FontAwesome.IconGraduationCap => "fa-graduation-cap",
            FontAwesome.IconGratipay => "fa-gratipay",
            FontAwesome.IconGrav => "fa-grav",
            FontAwesome.IconGreaterThan => "fa-greater-than",
            FontAwesome.IconGreaterThanEqual => "fa-greater-than-equal",
            FontAwesome.IconGrimace => "fa-grimace",
            FontAwesome.IconGrin => "fa-grin",
            FontAwesome.IconGrinAlt => "fa-grin-alt",
            FontAwesome.IconGrinBeam => "fa-grin-beam",
            FontAwesome.IconGrinBeamSweat => "fa-grin-beam-sweat",
            FontAwesome.IconGrinHearts => "fa-grin-hearts",
            FontAwesome.IconGrinSquint => "fa-grin-squint",
            FontAwesome.IconGrinSquintTears => "fa-grin-squint-tears",
            FontAwesome.IconGrinStars => "fa-grin-stars",
            FontAwesome.IconGrinTears => "fa-grin-tears",
            FontAwesome.IconGrinTongue => "fa-grin-tongue",
            FontAwesome.IconGrinTongueSquint => "fa-grin-tongue-squint",
            FontAwesome.IconGrinTongueWink => "fa-grin-tongue-wink",
            FontAwesome.IconGrinWink => "fa-grin-wink",
            FontAwesome.IconGripfire => "fa-gripfire",
            FontAwesome.IconGripHorizontal => "fa-grip-horizontal",
            FontAwesome.IconGripLines => "fa-grip-lines",
            FontAwesome.IconGripLinesVertical => "fa-grip-lines-vertical",
            FontAwesome.IconGripVertical => "fa-grip-vertical",
            FontAwesome.IconGrunt => "fa-grunt",
            FontAwesome.IconGuitar => "fa-guitar",
            FontAwesome.IconGulp => "fa-gulp",
            FontAwesome.IconHackerNews => "fa-hacker-news",
            FontAwesome.IconHackerNewsSquare => "fa-hacker-news-square",
            FontAwesome.IconHackerrank => "fa-hackerrank",
            FontAwesome.IconHamburger => "fa-hamburger",
            FontAwesome.IconHammer => "fa-hammer",
            FontAwesome.IconHamsa => "fa-hamsa",
            FontAwesome.IconHandHolding => "fa-hand-holding",
            FontAwesome.IconHandHoldingHeart => "fa-hand-holding-heart",
            FontAwesome.IconHandHoldingMedical => "fa-hand-holding-medical",
            FontAwesome.IconHandHoldingUsd => "fa-hand-holding-usd",
            FontAwesome.IconHandHoldingWater => "fa-hand-holding-water",
            FontAwesome.IconHandLizard => "fa-hand-lizard",
            FontAwesome.IconHandMiddleFinger => "fa-hand-middle-finger",
            FontAwesome.IconHandPaper => "fa-hand-paper",
            FontAwesome.IconHandPeace => "fa-hand-peace",
            FontAwesome.IconHandPointDown => "fa-hand-point-down",
            FontAwesome.IconHandPointer => "fa-hand-pointer",
            FontAwesome.IconHandPointLeft => "fa-hand-point-left",
            FontAwesome.IconHandPointRight => "fa-hand-point-right",
            FontAwesome.IconHandPointUp => "fa-hand-point-up",
            FontAwesome.IconHandRock => "fa-hand-rock",
            FontAwesome.IconHands => "fa-hands",
            FontAwesome.IconHandScissors => "fa-hand-scissors",
            FontAwesome.IconHandshake => "fa-handshake",
            FontAwesome.IconHandshakeAltSlash => "fa-handshake-alt-slash",
            FontAwesome.IconHandshakeSlash => "fa-handshake-slash",
            FontAwesome.IconHandsHelping => "fa-hands-helping",
            FontAwesome.IconHandSparkles => "fa-hand-sparkles",
            FontAwesome.IconHandSpock => "fa-hand-spock",
            FontAwesome.IconHandsWash => "fa-hands-wash",
            FontAwesome.IconHanukiah => "fa-hanukiah",
            FontAwesome.IconHardHat => "fa-hard-hat",
            FontAwesome.IconHashtag => "fa-hashtag",
            FontAwesome.IconHatCowboy => "fa-hat-cowboy",
            FontAwesome.IconHatCowboySide => "fa-hat-cowboy-side",
            FontAwesome.IconHatWizard => "fa-hat-wizard",
            FontAwesome.IconHdd => "fa-hdd",
            FontAwesome.IconHeading => "fa-heading",
            FontAwesome.IconHeadphones => "fa-headphones",
            FontAwesome.IconHeadphonesAlt => "fa-headphones-alt",
            FontAwesome.IconHeadset => "fa-headset",
            FontAwesome.IconHeadSideCough => "fa-head-side-cough",
            FontAwesome.IconHeadSideCoughSlash => "fa-head-side-cough-slash",
            FontAwesome.IconHeadSideMask => "fa-head-side-mask",
            FontAwesome.IconHeadSideVirus => "fa-head-side-virus",
            FontAwesome.IconHeart => "fa-heart",
            FontAwesome.IconHeartbeat => "fa-heartbeat",
            FontAwesome.IconHeartBroken => "fa-heart-broken",
            FontAwesome.IconHelicopter => "fa-helicopter",
            FontAwesome.IconHighlighter => "fa-highlighter",
            FontAwesome.IconHiking => "fa-hiking",
            FontAwesome.IconHippo => "fa-hippo",
            FontAwesome.IconHips => "fa-hips",
            FontAwesome.IconHireAHelper => "fa-hire-a-helper",
            FontAwesome.IconHistory => "fa-history",
            FontAwesome.IconHockeyPuck => "fa-hockey-puck",
            FontAwesome.IconHollyBerry => "fa-holly-berry",
            FontAwesome.IconHome => "fa-home",
            FontAwesome.IconHooli => "fa-hooli",
            FontAwesome.IconHornbill => "fa-hornbill",
            FontAwesome.IconHorse => "fa-horse",
            FontAwesome.IconHorseHead => "fa-horse-head",
            FontAwesome.IconHospital => "fa-hospital",
            FontAwesome.IconHospitalAlt => "fa-hospital-alt",
            FontAwesome.IconHospitalSymbol => "fa-hospital-symbol",
            FontAwesome.IconHospitalUser => "fa-hospital-user",
            FontAwesome.IconHotdog => "fa-hotdog",
            FontAwesome.IconHotel => "fa-hotel",
            FontAwesome.IconHotjar => "fa-hotjar",
            FontAwesome.IconHotTub => "fa-hot-tub",
            FontAwesome.IconHourglass => "fa-hourglass",
            FontAwesome.IconHourglassEnd => "fa-hourglass-end",
            FontAwesome.IconHourglassHalf => "fa-hourglass-half",
            FontAwesome.IconHourglassStart => "fa-hourglass-start",
            FontAwesome.IconHouseDamage => "fa-house-damage",
            FontAwesome.IconHouseUser => "fa-house-user",
            FontAwesome.IconHouzz => "fa-houzz",
            FontAwesome.IconHryvnia => "fa-hryvnia",
            FontAwesome.IconHSquare => "fa-h-square",
            FontAwesome.IconHtml5 => "fa-html5",
            FontAwesome.IconHubspot => "fa-hubspot",
            FontAwesome.IconIceCream => "fa-ice-cream",
            FontAwesome.IconIcicles => "fa-icicles",
            FontAwesome.IconIcons => "fa-icons",
            FontAwesome.IconICursor => "fa-i-cursor",
            FontAwesome.IconIdBadge => "fa-id-badge",
            FontAwesome.IconIdCard => "fa-id-card",
            FontAwesome.IconIdCardAlt => "fa-id-card-alt",
            FontAwesome.IconIdeal => "fa-ideal",
            FontAwesome.IconIgloo => "fa-igloo",
            FontAwesome.IconImage => "fa-image",
            FontAwesome.IconImages => "fa-images",
            FontAwesome.IconImdb => "fa-imdb",
            FontAwesome.IconInbox => "fa-inbox",
            FontAwesome.IconIndent => "fa-indent",
            FontAwesome.IconIndustry => "fa-industry",
            FontAwesome.IconInfinity => "fa-infinity",
            FontAwesome.IconInfo => "fa-info",
            FontAwesome.IconInfoCircle => "fa-info-circle",
            FontAwesome.IconInstagram => "fa-instagram",
            FontAwesome.IconInstagramSquare => "fa-instagram-square",
            FontAwesome.IconIntercom => "fa-intercom",
            FontAwesome.IconInternetExplorer => "fa-internet-explorer",
            FontAwesome.IconInvision => "fa-invision",
            FontAwesome.IconIoxhost => "fa-ioxhost",
            FontAwesome.IconItalic => "fa-italic",
            FontAwesome.IconItchIo => "fa-itch-io",
            FontAwesome.IconItunes => "fa-itunes",
            FontAwesome.IconItunesNote => "fa-itunes-note",
            FontAwesome.IconJava => "fa-java",
            FontAwesome.IconJedi => "fa-jedi",
            FontAwesome.IconJediOrder => "fa-jedi-order",
            FontAwesome.IconJenkins => "fa-jenkins",
            FontAwesome.IconJira => "fa-jira",
            FontAwesome.IconJoget => "fa-joget",
            FontAwesome.IconJoint => "fa-joint",
            FontAwesome.IconJoomla => "fa-joomla",
            FontAwesome.IconJournalWhills => "fa-journal-whills",
            FontAwesome.IconJs => "fa-js",
            FontAwesome.IconJsfiddle => "fa-jsfiddle",
            FontAwesome.IconJsSquare => "fa-js-square",
            FontAwesome.IconKaaba => "fa-kaaba",
            FontAwesome.IconKaggle => "fa-kaggle",
            FontAwesome.IconKey => "fa-key",
            FontAwesome.IconKeybase => "fa-keybase",
            FontAwesome.IconKeyboard => "fa-keyboard",
            FontAwesome.IconKeycdn => "fa-keycdn",
            FontAwesome.IconKhanda => "fa-khanda",
            FontAwesome.IconKickstarter => "fa-kickstarter",
            FontAwesome.IconKickstarterK => "fa-kickstarter-k",
            FontAwesome.IconKiss => "fa-kiss",
            FontAwesome.IconKissBeam => "fa-kiss-beam",
            FontAwesome.IconKissWinkHeart => "fa-kiss-wink-heart",
            FontAwesome.IconKiwiBird => "fa-kiwi-bird",
            FontAwesome.IconKorvue => "fa-korvue",
            FontAwesome.IconLandmark => "fa-landmark",
            FontAwesome.IconLanguage => "fa-language",
            FontAwesome.IconLaptop => "fa-laptop",
            FontAwesome.IconLaptopCode => "fa-laptop-code",
            FontAwesome.IconLaptopHouse => "fa-laptop-house",
            FontAwesome.IconLaptopMedical => "fa-laptop-medical",
            FontAwesome.IconLaravel => "fa-laravel",
            FontAwesome.IconLastfm => "fa-lastfm",
            FontAwesome.IconLastfmSquare => "fa-lastfm-square",
            FontAwesome.IconLaugh => "fa-laugh",
            FontAwesome.IconLaughBeam => "fa-laugh-beam",
            FontAwesome.IconLaughSquint => "fa-laugh-squint",
            FontAwesome.IconLaughWink => "fa-laugh-wink",
            FontAwesome.IconLayerGroup => "fa-layer-group",
            FontAwesome.IconLeaf => "fa-leaf",
            FontAwesome.IconLeanpub => "fa-leanpub",
            FontAwesome.IconLemon => "fa-lemon",
            FontAwesome.IconLess => "fa-less",
            FontAwesome.IconLessThan => "fa-less-than",
            FontAwesome.IconLessThanEqual => "fa-less-than-equal",
            FontAwesome.IconLevelDownAlt => "fa-level-down-alt",
            FontAwesome.IconLevelUpAlt => "fa-level-up-alt",
            FontAwesome.IconLifeRing => "fa-life-ring",
            FontAwesome.IconLightbulb => "fa-lightbulb",
            FontAwesome.IconLine => "fa-line",
            FontAwesome.IconLink => "fa-link",
            FontAwesome.IconLinkedin => "fa-linkedin",
            FontAwesome.IconLinkedinIn => "fa-linkedin-in",
            FontAwesome.IconLinode => "fa-linode",
            FontAwesome.IconLinux => "fa-linux",
            FontAwesome.IconLiraSign => "fa-lira-sign",
            FontAwesome.IconList => "fa-list",
            FontAwesome.IconListAlt => "fa-list-alt",
            FontAwesome.IconListOl => "fa-list-ol",
            FontAwesome.IconListUl => "fa-list-ul",
            FontAwesome.IconLocationArrow => "fa-location-arrow",
            FontAwesome.IconLock => "fa-lock",
            FontAwesome.IconLockOpen => "fa-lock-open",
            FontAwesome.IconLongArrowAltDown => "fa-long-arrow-alt-down",
            FontAwesome.IconLongArrowAltLeft => "fa-long-arrow-alt-left",
            FontAwesome.IconLongArrowAltRight => "fa-long-arrow-alt-right",
            FontAwesome.IconLongArrowAltUp => "fa-long-arrow-alt-up",
            FontAwesome.IconLowVision => "fa-low-vision",
            FontAwesome.IconLuggageCart => "fa-luggage-cart",
            FontAwesome.IconLungs => "fa-lungs",
            FontAwesome.IconLungsVirus => "fa-lungs-virus",
            FontAwesome.IconLyft => "fa-lyft",
            FontAwesome.IconMagento => "fa-magento",
            FontAwesome.IconMagic => "fa-magic",
            FontAwesome.IconMagnet => "fa-magnet",
            FontAwesome.IconMailBulk => "fa-mail-bulk",
            FontAwesome.IconMailchimp => "fa-mailchimp",
            FontAwesome.IconMale => "fa-male",
            FontAwesome.IconMandalorian => "fa-mandalorian",
            FontAwesome.IconMap => "fa-map",
            FontAwesome.IconMapMarked => "fa-map-marked",
            FontAwesome.IconMapMarkedAlt => "fa-map-marked-alt",
            FontAwesome.IconMapMarker => "fa-map-marker",
            FontAwesome.IconMapMarkerAlt => "fa-map-marker-alt",
            FontAwesome.IconMapPin => "fa-map-pin",
            FontAwesome.IconMapSigns => "fa-map-signs",
            FontAwesome.IconMarkdown => "fa-markdown",
            FontAwesome.IconMarker => "fa-marker",
            FontAwesome.IconMars => "fa-mars",
            FontAwesome.IconMarsDouble => "fa-mars-double",
            FontAwesome.IconMarsStroke => "fa-mars-stroke",
            FontAwesome.IconMarsStrokeH => "fa-mars-stroke-h",
            FontAwesome.IconMarsStrokeV => "fa-mars-stroke-v",
            FontAwesome.IconMask => "fa-mask",
            FontAwesome.IconMastodon => "fa-mastodon",
            FontAwesome.IconMaxcdn => "fa-maxcdn",
            FontAwesome.IconMdb => "fa-mdb",
            FontAwesome.IconMedal => "fa-medal",
            FontAwesome.IconMedapps => "fa-medapps",
            FontAwesome.IconMedium => "fa-medium",
            FontAwesome.IconMediumM => "fa-medium-m",
            FontAwesome.IconMedkit => "fa-medkit",
            FontAwesome.IconMedrt => "fa-medrt",
            FontAwesome.IconMeetup => "fa-meetup",
            FontAwesome.IconMegaport => "fa-megaport",
            FontAwesome.IconMeh => "fa-meh",
            FontAwesome.IconMehBlank => "fa-meh-blank",
            FontAwesome.IconMehRollingEyes => "fa-meh-rolling-eyes",
            FontAwesome.IconMemory => "fa-memory",
            FontAwesome.IconMendeley => "fa-mendeley",
            FontAwesome.IconMenorah => "fa-menorah",
            FontAwesome.IconMercury => "fa-mercury",
            FontAwesome.IconMeteor => "fa-meteor",
            FontAwesome.IconMicroblog => "fa-microblog",
            FontAwesome.IconMicrochip => "fa-microchip",
            FontAwesome.IconMicrophone => "fa-microphone",
            FontAwesome.IconMicrophoneAlt => "fa-microphone-alt",
            FontAwesome.IconMicrophoneAltSlash => "fa-microphone-alt-slash",
            FontAwesome.IconMicrophoneSlash => "fa-microphone-slash",
            FontAwesome.IconMicroscope => "fa-microscope",
            FontAwesome.IconMicrosoft => "fa-microsoft",
            FontAwesome.IconMinus => "fa-minus",
            FontAwesome.IconMinusCircle => "fa-minus-circle",
            FontAwesome.IconMinusSquare => "fa-minus-square",
            FontAwesome.IconMitten => "fa-mitten",
            FontAwesome.IconMix => "fa-mix",
            FontAwesome.IconMixcloud => "fa-mixcloud",
            FontAwesome.IconMixer => "fa-mixer",
            FontAwesome.IconMizuni => "fa-mizuni",
            FontAwesome.IconMobile => "fa-mobile",
            FontAwesome.IconMobileAlt => "fa-mobile-alt",
            FontAwesome.IconModx => "fa-modx",
            FontAwesome.IconMonero => "fa-monero",
            FontAwesome.IconMoneyBill => "fa-money-bill",
            FontAwesome.IconMoneyBillAlt => "fa-money-bill-alt",
            FontAwesome.IconMoneyBillWave => "fa-money-bill-wave",
            FontAwesome.IconMoneyBillWaveAlt => "fa-money-bill-wave-alt",
            FontAwesome.IconMoneyCheck => "fa-money-check",
            FontAwesome.IconMoneyCheckAlt => "fa-money-check-alt",
            FontAwesome.IconMonument => "fa-monument",
            FontAwesome.IconMoon => "fa-moon",
            FontAwesome.IconMortarPestle => "fa-mortar-pestle",
            FontAwesome.IconMosque => "fa-mosque",
            FontAwesome.IconMotorcycle => "fa-motorcycle",
            FontAwesome.IconMountain => "fa-mountain",
            FontAwesome.IconMouse => "fa-mouse",
            FontAwesome.IconMousePointer => "fa-mouse-pointer",
            FontAwesome.IconMugHot => "fa-mug-hot",
            FontAwesome.IconMusic => "fa-music",
            FontAwesome.IconNapster => "fa-napster",
            FontAwesome.IconNeos => "fa-neos",
            FontAwesome.IconNetworkWired => "fa-network-wired",
            FontAwesome.IconNeuter => "fa-neuter",
            FontAwesome.IconNewspaper => "fa-newspaper",
            FontAwesome.IconNimblr => "fa-nimblr",
            FontAwesome.IconNode => "fa-node",
            FontAwesome.IconNodeJs => "fa-node-js",
            FontAwesome.IconNotEqual => "fa-not-equal",
            FontAwesome.IconNotesMedical => "fa-notes-medical",
            FontAwesome.IconNpm => "fa-npm",
            FontAwesome.IconNs8 => "fa-ns8",
            FontAwesome.IconNutritionix => "fa-nutritionix",
            FontAwesome.IconObjectGroup => "fa-object-group",
            FontAwesome.IconObjectUngroup => "fa-object-ungroup",
            FontAwesome.IconOdnoklassniki => "fa-odnoklassniki",
            FontAwesome.IconOdnoklassnikiSquare => "fa-odnoklassniki-square",
            FontAwesome.IconOilCan => "fa-oil-can",
            FontAwesome.IconOldRepublic => "fa-old-republic",
            FontAwesome.IconOm => "fa-om",
            FontAwesome.IconOpencart => "fa-opencart",
            FontAwesome.IconOpenid => "fa-openid",
            FontAwesome.IconOpera => "fa-opera",
            FontAwesome.IconOptinMonster => "fa-optin-monster",
            FontAwesome.IconOrcid => "fa-orcid",
            FontAwesome.IconOsi => "fa-osi",
            FontAwesome.IconOtter => "fa-otter",
            FontAwesome.IconOutdent => "fa-outdent",
            FontAwesome.IconPage4 => "fa-page4",
            FontAwesome.IconPagelines => "fa-pagelines",
            FontAwesome.IconPager => "fa-pager",
            FontAwesome.IconPaintBrush => "fa-paint-brush",
            FontAwesome.IconPaintRoller => "fa-paint-roller",
            FontAwesome.IconPalette => "fa-palette",
            FontAwesome.IconPalfed => "fa-palfed",
            FontAwesome.IconPallet => "fa-pallet",
            FontAwesome.IconPaperclip => "fa-paperclip",
            FontAwesome.IconPaperPlane => "fa-paper-plane",
            FontAwesome.IconParachuteBox => "fa-parachute-box",
            FontAwesome.IconParagraph => "fa-paragraph",
            FontAwesome.IconParking => "fa-parking",
            FontAwesome.IconPassport => "fa-passport",
            FontAwesome.IconPastafarianism => "fa-pastafarianism",
            FontAwesome.IconPaste => "fa-paste",
            FontAwesome.IconPatreon => "fa-patreon",
            FontAwesome.IconPause => "fa-pause",
            FontAwesome.IconPauseCircle => "fa-pause-circle",
            FontAwesome.IconPaw => "fa-paw",
            FontAwesome.IconPaypal => "fa-paypal",
            FontAwesome.IconPeace => "fa-peace",
            FontAwesome.IconPen => "fa-pen",
            FontAwesome.IconPenAlt => "fa-pen-alt",
            FontAwesome.IconPencilAlt => "fa-pencil-alt",
            FontAwesome.IconPencilRuler => "fa-pencil-ruler",
            FontAwesome.IconPenFancy => "fa-pen-fancy",
            FontAwesome.IconPenNib => "fa-pen-nib",
            FontAwesome.IconPennyArcade => "fa-penny-arcade",
            FontAwesome.IconPenSquare => "fa-pen-square",
            FontAwesome.IconPeopleArrows => "fa-people-arrows",
            FontAwesome.IconPeopleCarry => "fa-people-carry",
            FontAwesome.IconPepperHot => "fa-pepper-hot",
            FontAwesome.IconPercent => "fa-percent",
            FontAwesome.IconPercentage => "fa-percentage",
            FontAwesome.IconPeriscope => "fa-periscope",
            FontAwesome.IconPersonBooth => "fa-person-booth",
            FontAwesome.IconPhabricator => "fa-phabricator",
            FontAwesome.IconPhoenixFramework => "fa-phoenix-framework",
            FontAwesome.IconPhoenixSquadron => "fa-phoenix-squadron",
            FontAwesome.IconPhone => "fa-phone",
            FontAwesome.IconPhoneAlt => "fa-phone-alt",
            FontAwesome.IconPhoneSlash => "fa-phone-slash",
            FontAwesome.IconPhoneSquare => "fa-phone-square",
            FontAwesome.IconPhoneSquareAlt => "fa-phone-square-alt",
            FontAwesome.IconPhoneVolume => "fa-phone-volume",
            FontAwesome.IconPhotoVideo => "fa-photo-video",
            FontAwesome.IconPhp => "fa-php",
            FontAwesome.IconPiedPiper => "fa-pied-piper",
            FontAwesome.IconPiedPiperAlt => "fa-pied-piper-alt",
            FontAwesome.IconPiedPiperHat => "fa-pied-piper-hat",
            FontAwesome.IconPiedPiperPp => "fa-pied-piper-pp",
            FontAwesome.IconPiedPiperSquare => "fa-pied-piper-square",
            FontAwesome.IconPiggyBank => "fa-piggy-bank",
            FontAwesome.IconPills => "fa-pills",
            FontAwesome.IconPinterest => "fa-pinterest",
            FontAwesome.IconPinterestP => "fa-pinterest-p",
            FontAwesome.IconPinterestSquare => "fa-pinterest-square",
            FontAwesome.IconPizzaSlice => "fa-pizza-slice",
            FontAwesome.IconPlaceOfWorship => "fa-place-of-worship",
            FontAwesome.IconPlane => "fa-plane",
            FontAwesome.IconPlaneArrival => "fa-plane-arrival",
            FontAwesome.IconPlaneDeparture => "fa-plane-departure",
            FontAwesome.IconPlaneSlash => "fa-plane-slash",
            FontAwesome.IconPlay => "fa-play",
            FontAwesome.IconPlayCircle => "fa-play-circle",
            FontAwesome.IconPlaystation => "fa-playstation",
            FontAwesome.IconPlug => "fa-plug",
            FontAwesome.IconPlus => "fa-plus",
            FontAwesome.IconPlusCircle => "fa-plus-circle",
            FontAwesome.IconPlusSquare => "fa-plus-square",
            FontAwesome.IconPodcast => "fa-podcast",
            FontAwesome.IconPoll => "fa-poll",
            FontAwesome.IconPollH => "fa-poll-h",
            FontAwesome.IconPoo => "fa-poo",
            FontAwesome.IconPoop => "fa-poop",
            FontAwesome.IconPooStorm => "fa-poo-storm",
            FontAwesome.IconPortrait => "fa-portrait",
            FontAwesome.IconPoundSign => "fa-pound-sign",
            FontAwesome.IconPowerOff => "fa-power-off",
            FontAwesome.IconPray => "fa-pray",
            FontAwesome.IconPrayingHands => "fa-praying-hands",
            FontAwesome.IconPrescription => "fa-prescription",
            FontAwesome.IconPrescriptionBottle => "fa-prescription-bottle",
            FontAwesome.IconPrescriptionBottleAlt => "fa-prescription-bottle-alt",
            FontAwesome.IconPrint => "fa-print",
            FontAwesome.IconProcedures => "fa-procedures",
            FontAwesome.IconProductHunt => "fa-product-hunt",
            FontAwesome.IconProjectDiagram => "fa-project-diagram",
            FontAwesome.IconPumpMedical => "fa-pump-medical",
            FontAwesome.IconPumpSoap => "fa-pump-soap",
            FontAwesome.IconPushed => "fa-pushed",
            FontAwesome.IconPuzzlePiece => "fa-puzzle-piece",
            FontAwesome.IconPython => "fa-python",
            FontAwesome.IconQq => "fa-qq",
            FontAwesome.IconQrcode => "fa-qrcode",
            FontAwesome.IconQuestion => "fa-question",
            FontAwesome.IconQuestionCircle => "fa-question-circle",
            FontAwesome.IconQuidditch => "fa-quidditch",
            FontAwesome.IconQuinscape => "fa-quinscape",
            FontAwesome.IconQuora => "fa-quora",
            FontAwesome.IconQuoteLeft => "fa-quote-left",
            FontAwesome.IconQuoteRight => "fa-quote-right",
            FontAwesome.IconQuran => "fa-quran",
            FontAwesome.IconRadiation => "fa-radiation",
            FontAwesome.IconRadiationAlt => "fa-radiation-alt",
            FontAwesome.IconRainbow => "fa-rainbow",
            FontAwesome.IconRandom => "fa-random",
            FontAwesome.IconRaspberryPi => "fa-raspberry-pi",
            FontAwesome.IconRavelry => "fa-ravelry",
            FontAwesome.IconReact => "fa-react",
            FontAwesome.IconReacteurope => "fa-reacteurope",
            FontAwesome.IconReadme => "fa-readme",
            FontAwesome.IconRebel => "fa-rebel",
            FontAwesome.IconReceipt => "fa-receipt",
            FontAwesome.IconRecordVinyl => "fa-record-vinyl",
            FontAwesome.IconRecycle => "fa-recycle",
            FontAwesome.IconReddit => "fa-reddit",
            FontAwesome.IconRedditAlien => "fa-reddit-alien",
            FontAwesome.IconRedditSquare => "fa-reddit-square",
            FontAwesome.IconRedhat => "fa-redhat",
            FontAwesome.IconRedo => "fa-redo",
            FontAwesome.IconRedoAlt => "fa-redo-alt",
            FontAwesome.IconRedRiver => "fa-red-river",
            FontAwesome.IconRegistered => "fa-registered",
            FontAwesome.IconRemoveFormat => "fa-remove-format",
            FontAwesome.IconRenren => "fa-renren",
            FontAwesome.IconReply => "fa-reply",
            FontAwesome.IconReplyAll => "fa-reply-all",
            FontAwesome.IconReplyd => "fa-replyd",
            FontAwesome.IconRepublican => "fa-republican",
            FontAwesome.IconResearchgate => "fa-researchgate",
            FontAwesome.IconResolving => "fa-resolving",
            FontAwesome.IconRestroom => "fa-restroom",
            FontAwesome.IconRetweet => "fa-retweet",
            FontAwesome.IconRev => "fa-rev",
            FontAwesome.IconRibbon => "fa-ribbon",
            FontAwesome.IconRing => "fa-ring",
            FontAwesome.IconRoad => "fa-road",
            FontAwesome.IconRobot => "fa-robot",
            FontAwesome.IconRocket => "fa-rocket",
            FontAwesome.IconRocketchat => "fa-rocketchat",
            FontAwesome.IconRockrms => "fa-rockrms",
            FontAwesome.IconRoute => "fa-route",
            FontAwesome.IconRProject => "fa-r-project",
            FontAwesome.IconRss => "fa-rss",
            FontAwesome.IconRssSquare => "fa-rss-square",
            FontAwesome.IconRubleSign => "fa-ruble-sign",
            FontAwesome.IconRuler => "fa-ruler",
            FontAwesome.IconRulerCombined => "fa-ruler-combined",
            FontAwesome.IconRulerHorizontal => "fa-ruler-horizontal",
            FontAwesome.IconRulerVertical => "fa-ruler-vertical",
            FontAwesome.IconRunning => "fa-running",
            FontAwesome.IconRupeeSign => "fa-rupee-sign",
            FontAwesome.IconSadCry => "fa-sad-cry",
            FontAwesome.IconSadTear => "fa-sad-tear",
            FontAwesome.IconSafari => "fa-safari",
            FontAwesome.IconSalesforce => "fa-salesforce",
            FontAwesome.IconSass => "fa-sass",
            FontAwesome.IconSatellite => "fa-satellite",
            FontAwesome.IconSatelliteDish => "fa-satellite-dish",
            FontAwesome.IconSave => "fa-save",
            FontAwesome.IconSchlix => "fa-schlix",
            FontAwesome.IconSchool => "fa-school",
            FontAwesome.IconScrewdriver => "fa-screwdriver",
            FontAwesome.IconScribd => "fa-scribd",
            FontAwesome.IconScroll => "fa-scroll",
            FontAwesome.IconSdCard => "fa-sd-card",
            FontAwesome.IconSearch => "fa-search",
            FontAwesome.IconSearchDollar => "fa-search-dollar",
            FontAwesome.IconSearchengin => "fa-searchengin",
            FontAwesome.IconSearchLocation => "fa-search-location",
            FontAwesome.IconSearchMinus => "fa-search-minus",
            FontAwesome.IconSearchPlus => "fa-search-plus",
            FontAwesome.IconSeedling => "fa-seedling",
            FontAwesome.IconSellcast => "fa-sellcast",
            FontAwesome.IconSellsy => "fa-sellsy",
            FontAwesome.IconServer => "fa-server",
            FontAwesome.IconServicestack => "fa-servicestack",
            FontAwesome.IconShapes => "fa-shapes",
            FontAwesome.IconShare => "fa-share",
            FontAwesome.IconShareAlt => "fa-share-alt",
            FontAwesome.IconShareAltSquare => "fa-share-alt-square",
            FontAwesome.IconShareSquare => "fa-share-square",
            FontAwesome.IconShekelSign => "fa-shekel-sign",
            FontAwesome.IconShieldAlt => "fa-shield-alt",
            FontAwesome.IconShieldVirus => "fa-shield-virus",
            FontAwesome.IconShip => "fa-ship",
            FontAwesome.IconShippingFast => "fa-shipping-fast",
            FontAwesome.IconShirtsinbulk => "fa-shirtsinbulk",
            FontAwesome.IconShoePrints => "fa-shoe-prints",
            FontAwesome.IconShopify => "fa-shopify",
            FontAwesome.IconShoppingBag => "fa-shopping-bag",
            FontAwesome.IconShoppingBasket => "fa-shopping-basket",
            FontAwesome.IconShoppingCart => "fa-shopping-cart",
            FontAwesome.IconShopware => "fa-shopware",
            FontAwesome.IconShower => "fa-shower",
            FontAwesome.IconShuttleVan => "fa-shuttle-van",
            FontAwesome.IconSign => "fa-sign",
            FontAwesome.IconSignal => "fa-signal",
            FontAwesome.IconSignature => "fa-signature",
            FontAwesome.IconSignInAlt => "fa-sign-in-alt",
            FontAwesome.IconSignLanguage => "fa-sign-language",
            FontAwesome.IconSignOutAlt => "fa-sign-out-alt",
            FontAwesome.IconSimCard => "fa-sim-card",
            FontAwesome.IconSimplybuilt => "fa-simplybuilt",
            FontAwesome.IconSistrix => "fa-sistrix",
            FontAwesome.IconSitemap => "fa-sitemap",
            FontAwesome.IconSith => "fa-sith",
            FontAwesome.IconSkating => "fa-skating",
            FontAwesome.IconSketch => "fa-sketch",
            FontAwesome.IconSkiing => "fa-skiing",
            FontAwesome.IconSkiingNordic => "fa-skiing-nordic",
            FontAwesome.IconSkull => "fa-skull",
            FontAwesome.IconSkullCrossbones => "fa-skull-crossbones",
            FontAwesome.IconSkyatlas => "fa-skyatlas",
            FontAwesome.IconSkype => "fa-skype",
            FontAwesome.IconSlack => "fa-slack",
            FontAwesome.IconSlackHash => "fa-slack-hash",
            FontAwesome.IconSlash => "fa-slash",
            FontAwesome.IconSleigh => "fa-sleigh",
            FontAwesome.IconSlidersH => "fa-sliders-h",
            FontAwesome.IconSlideshare => "fa-slideshare",
            FontAwesome.IconSmile => "fa-smile",
            FontAwesome.IconSmileBeam => "fa-smile-beam",
            FontAwesome.IconSmileWink => "fa-smile-wink",
            FontAwesome.IconSmog => "fa-smog",
            FontAwesome.IconSmoking => "fa-smoking",
            FontAwesome.IconSmokingBan => "fa-smoking-ban",
            FontAwesome.IconSms => "fa-sms",
            FontAwesome.IconSnapchat => "fa-snapchat",
            FontAwesome.IconSnapchatGhost => "fa-snapchat-ghost",
            FontAwesome.IconSnapchatSquare => "fa-snapchat-square",
            FontAwesome.IconSnowboarding => "fa-snowboarding",
            FontAwesome.IconSnowflake => "fa-snowflake",
            FontAwesome.IconSnowman => "fa-snowman",
            FontAwesome.IconSnowplow => "fa-snowplow",
            FontAwesome.IconSoap => "fa-soap",
            FontAwesome.IconSocks => "fa-socks",
            FontAwesome.IconSolarPanel => "fa-solar-panel",
            FontAwesome.IconSort => "fa-sort",
            FontAwesome.IconSortAlphaDown => "fa-sort-alpha-down",
            FontAwesome.IconSortAlphaDownAlt => "fa-sort-alpha-down-alt",
            FontAwesome.IconSortAlphaUp => "fa-sort-alpha-up",
            FontAwesome.IconSortAlphaUpAlt => "fa-sort-alpha-up-alt",
            FontAwesome.IconSortAmountDown => "fa-sort-amount-down",
            FontAwesome.IconSortAmountDownAlt => "fa-sort-amount-down-alt",
            FontAwesome.IconSortAmountUp => "fa-sort-amount-up",
            FontAwesome.IconSortAmountUpAlt => "fa-sort-amount-up-alt",
            FontAwesome.IconSortDown => "fa-sort-down",
            FontAwesome.IconSortNumericDown => "fa-sort-numeric-down",
            FontAwesome.IconSortNumericDownAlt => "fa-sort-numeric-down-alt",
            FontAwesome.IconSortNumericUp => "fa-sort-numeric-up",
            FontAwesome.IconSortNumericUpAlt => "fa-sort-numeric-up-alt",
            FontAwesome.IconSortUp => "fa-sort-up",
            FontAwesome.IconSoundcloud => "fa-soundcloud",
            FontAwesome.IconSourcetree => "fa-sourcetree",
            FontAwesome.IconSpa => "fa-spa",
            FontAwesome.IconSpaceShuttle => "fa-space-shuttle",
            FontAwesome.IconSpeakap => "fa-speakap",
            FontAwesome.IconSpeakerDeck => "fa-speaker-deck",
            FontAwesome.IconSpellCheck => "fa-spell-check",
            FontAwesome.IconSpider => "fa-spider",
            FontAwesome.IconSpinner => "fa-spinner",
            FontAwesome.IconSplotch => "fa-splotch",
            FontAwesome.IconSpotify => "fa-spotify",
            FontAwesome.IconSprayCan => "fa-spray-can",
            FontAwesome.IconSquare => "fa-square",
            FontAwesome.IconSquareFull => "fa-square-full",
            FontAwesome.IconSquareRootAlt => "fa-square-root-alt",
            FontAwesome.IconSquarespace => "fa-squarespace",
            FontAwesome.IconStackExchange => "fa-stack-exchange",
            FontAwesome.IconStackOverflow => "fa-stack-overflow",
            FontAwesome.IconStackpath => "fa-stackpath",
            FontAwesome.IconStamp => "fa-stamp",
            FontAwesome.IconStar => "fa-star",
            FontAwesome.IconStarAndCrescent => "fa-star-and-crescent",
            FontAwesome.IconStarHalf => "fa-star-half",
            FontAwesome.IconStarHalfAlt => "fa-star-half-alt",
            FontAwesome.IconStarOfDavid => "fa-star-of-david",
            FontAwesome.IconStarOfLife => "fa-star-of-life",
            FontAwesome.IconStaylinked => "fa-staylinked",
            FontAwesome.IconSteam => "fa-steam",
            FontAwesome.IconSteamSquare => "fa-steam-square",
            FontAwesome.IconSteamSymbol => "fa-steam-symbol",
            FontAwesome.IconStepBackward => "fa-step-backward",
            FontAwesome.IconStepForward => "fa-step-forward",
            FontAwesome.IconStethoscope => "fa-stethoscope",
            FontAwesome.IconStickerMule => "fa-sticker-mule",
            FontAwesome.IconStickyNote => "fa-sticky-note",
            FontAwesome.IconStop => "fa-stop",
            FontAwesome.IconStopCircle => "fa-stop-circle",
            FontAwesome.IconStopwatch => "fa-stopwatch",
            FontAwesome.IconStopwatch20 => "fa-stopwatch-20",
            FontAwesome.IconStore => "fa-store",
            FontAwesome.IconStoreAlt => "fa-store-alt",
            FontAwesome.IconStoreAltSlash => "fa-store-alt-slash",
            FontAwesome.IconStoreSlash => "fa-store-slash",
            FontAwesome.IconStrava => "fa-strava",
            FontAwesome.IconStream => "fa-stream",
            FontAwesome.IconStreetView => "fa-street-view",
            FontAwesome.IconStrikethrough => "fa-strikethrough",
            FontAwesome.IconStripe => "fa-stripe",
            FontAwesome.IconStripeS => "fa-stripe-s",
            FontAwesome.IconStroopwafel => "fa-stroopwafel",
            FontAwesome.IconStudiovinari => "fa-studiovinari",
            FontAwesome.IconStumbleupon => "fa-stumbleupon",
            FontAwesome.IconStumbleuponCircle => "fa-stumbleupon-circle",
            FontAwesome.IconSubscript => "fa-subscript",
            FontAwesome.IconSubway => "fa-subway",
            FontAwesome.IconSuitcase => "fa-suitcase",
            FontAwesome.IconSuitcaseRolling => "fa-suitcase-rolling",
            FontAwesome.IconSun => "fa-sun",
            FontAwesome.IconSuperpowers => "fa-superpowers",
            FontAwesome.IconSuperscript => "fa-superscript",
            FontAwesome.IconSupple => "fa-supple",
            FontAwesome.IconSurprise => "fa-surprise",
            FontAwesome.IconSuse => "fa-suse",
            FontAwesome.IconSwatchbook => "fa-swatchbook",
            FontAwesome.IconSwift => "fa-swift",
            FontAwesome.IconSwimmer => "fa-swimmer",
            FontAwesome.IconSwimmingPool => "fa-swimming-pool",
            FontAwesome.IconSymfony => "fa-symfony",
            FontAwesome.IconSynagogue => "fa-synagogue",
            FontAwesome.IconSync => "fa-sync",
            FontAwesome.IconSyncAlt => "fa-sync-alt",
            FontAwesome.IconSyringe => "fa-syringe",
            FontAwesome.IconTable => "fa-table",
            FontAwesome.IconTablet => "fa-tablet",
            FontAwesome.IconTabletAlt => "fa-tablet-alt",
            FontAwesome.IconTableTennis => "fa-table-tennis",
            FontAwesome.IconTablets => "fa-tablets",
            FontAwesome.IconTachometerAlt => "fa-tachometer-alt",
            FontAwesome.IconTag => "fa-tag",
            FontAwesome.IconTags => "fa-tags",
            FontAwesome.IconTape => "fa-tape",
            FontAwesome.IconTasks => "fa-tasks",
            FontAwesome.IconTaxi => "fa-taxi",
            FontAwesome.IconTeamspeak => "fa-teamspeak",
            FontAwesome.IconTeeth => "fa-teeth",
            FontAwesome.IconTeethOpen => "fa-teeth-open",
            FontAwesome.IconTelegram => "fa-telegram",
            FontAwesome.IconTelegramPlane => "fa-telegram-plane",
            FontAwesome.IconTemperatureHigh => "fa-temperature-high",
            FontAwesome.IconTemperatureLow => "fa-temperature-low",
            FontAwesome.IconTencentWeibo => "fa-tencent-weibo",
            FontAwesome.IconTenge => "fa-tenge",
            FontAwesome.IconTerminal => "fa-terminal",
            FontAwesome.IconTextHeight => "fa-text-height",
            FontAwesome.IconTextWidth => "fa-text-width",
            FontAwesome.IconTh => "fa-th",
            FontAwesome.IconTheaterMasks => "fa-theater-masks",
            FontAwesome.IconThemeco => "fa-themeco",
            FontAwesome.IconThemeisle => "fa-themeisle",
            FontAwesome.IconTheRedYeti => "fa-the-red-yeti",
            FontAwesome.IconThermometer => "fa-thermometer",
            FontAwesome.IconThermometerEmpty => "fa-thermometer-empty",
            FontAwesome.IconThermometerFull => "fa-thermometer-full",
            FontAwesome.IconThermometerHalf => "fa-thermometer-half",
            FontAwesome.IconThermometerQuarter => "fa-thermometer-quarter",
            FontAwesome.IconThermometerThreeQuarters => "fa-thermometer-three-quarters",
            FontAwesome.IconThinkPeaks => "fa-think-peaks",
            FontAwesome.IconThLarge => "fa-th-large",
            FontAwesome.IconThList => "fa-th-list",
            FontAwesome.IconThumbsDown => "fa-thumbs-down",
            FontAwesome.IconThumbsUp => "fa-thumbs-up",
            FontAwesome.IconThumbtack => "fa-thumbtack",
            FontAwesome.IconTicketAlt => "fa-ticket-alt",
            FontAwesome.IconTimes => "fa-times",
            FontAwesome.IconTimesCircle => "fa-times-circle",
            FontAwesome.IconTint => "fa-tint",
            FontAwesome.IconTintSlash => "fa-tint-slash",
            FontAwesome.IconTired => "fa-tired",
            FontAwesome.IconToggleOff => "fa-toggle-off",
            FontAwesome.IconToggleOn => "fa-toggle-on",
            FontAwesome.IconToilet => "fa-toilet",
            FontAwesome.IconToiletPaper => "fa-toilet-paper",
            FontAwesome.IconToiletPaperSlash => "fa-toilet-paper-slash",
            FontAwesome.IconToolbox => "fa-toolbox",
            FontAwesome.IconTools => "fa-tools",
            FontAwesome.IconTooth => "fa-tooth",
            FontAwesome.IconTorah => "fa-torah",
            FontAwesome.IconToriiGate => "fa-torii-gate",
            FontAwesome.IconTractor => "fa-tractor",
            FontAwesome.IconTradeFederation => "fa-trade-federation",
            FontAwesome.IconTrademark => "fa-trademark",
            FontAwesome.IconTrafficLight => "fa-traffic-light",
            FontAwesome.IconTrailer => "fa-trailer",
            FontAwesome.IconTrain => "fa-train",
            FontAwesome.IconTram => "fa-tram",
            FontAwesome.IconTransgender => "fa-transgender",
            FontAwesome.IconTransgenderAlt => "fa-transgender-alt",
            FontAwesome.IconTrash => "fa-trash",
            FontAwesome.IconTrashAlt => "fa-trash-alt",
            FontAwesome.IconTrashRestore => "fa-trash-restore",
            FontAwesome.IconTrashRestoreAlt => "fa-trash-restore-alt",
            FontAwesome.IconTree => "fa-tree",
            FontAwesome.IconTrello => "fa-trello",
            FontAwesome.IconTripadvisor => "fa-tripadvisor",
            FontAwesome.IconTrophy => "fa-trophy",
            FontAwesome.IconTruck => "fa-truck",
            FontAwesome.IconTruckLoading => "fa-truck-loading",
            FontAwesome.IconTruckMonster => "fa-truck-monster",
            FontAwesome.IconTruckMoving => "fa-truck-moving",
            FontAwesome.IconTruckPickup => "fa-truck-pickup",
            FontAwesome.IconTshirt => "fa-tshirt",
            FontAwesome.IconTty => "fa-tty",
            FontAwesome.IconTumblr => "fa-tumblr",
            FontAwesome.IconTumblrSquare => "fa-tumblr-square",
            FontAwesome.IconTv => "fa-tv",
            FontAwesome.IconTwitch => "fa-twitch",
            FontAwesome.IconTwitter => "fa-twitter",
            FontAwesome.IconTwitterSquare => "fa-twitter-square",
            FontAwesome.IconTypo3 => "fa-typo3",
            FontAwesome.IconUber => "fa-uber",
            FontAwesome.IconUbuntu => "fa-ubuntu",
            FontAwesome.IconUikit => "fa-uikit",
            FontAwesome.IconUmbraco => "fa-umbraco",
            FontAwesome.IconUmbrella => "fa-umbrella",
            FontAwesome.IconUmbrellaBeach => "fa-umbrella-beach",
            FontAwesome.IconUnderline => "fa-underline",
            FontAwesome.IconUndo => "fa-undo",
            FontAwesome.IconUndoAlt => "fa-undo-alt",
            FontAwesome.IconUniregistry => "fa-uniregistry",
            FontAwesome.IconUnity => "fa-unity",
            FontAwesome.IconUniversalAccess => "fa-universal-access",
            FontAwesome.IconUniversity => "fa-university",
            FontAwesome.IconUnlink => "fa-unlink",
            FontAwesome.IconUnlock => "fa-unlock",
            FontAwesome.IconUnlockAlt => "fa-unlock-alt",
            FontAwesome.IconUntappd => "fa-untappd",
            FontAwesome.IconUpload => "fa-upload",
            FontAwesome.IconUps => "fa-ups",
            FontAwesome.IconUsb => "fa-usb",
            FontAwesome.IconUser => "fa-user",
            FontAwesome.IconUserAlt => "fa-user-alt",
            FontAwesome.IconUserAltSlash => "fa-user-alt-slash",
            FontAwesome.IconUserAstronaut => "fa-user-astronaut",
            FontAwesome.IconUserCheck => "fa-user-check",
            FontAwesome.IconUserCircle => "fa-user-circle",
            FontAwesome.IconUserClock => "fa-user-clock",
            FontAwesome.IconUserCog => "fa-user-cog",
            FontAwesome.IconUserEdit => "fa-user-edit",
            FontAwesome.IconUserFriends => "fa-user-friends",
            FontAwesome.IconUserGraduate => "fa-user-graduate",
            FontAwesome.IconUserInjured => "fa-user-injured",
            FontAwesome.IconUserLock => "fa-user-lock",
            FontAwesome.IconUserMd => "fa-user-md",
            FontAwesome.IconUserMinus => "fa-user-minus",
            FontAwesome.IconUserNinja => "fa-user-ninja",
            FontAwesome.IconUserNurse => "fa-user-nurse",
            FontAwesome.IconUserPlus => "fa-user-plus",
            FontAwesome.IconUsers => "fa-users",
            FontAwesome.IconUsersCog => "fa-users-cog",
            FontAwesome.IconUserSecret => "fa-user-secret",
            FontAwesome.IconUserShield => "fa-user-shield",
            FontAwesome.IconUserSlash => "fa-user-slash",
            FontAwesome.IconUserTag => "fa-user-tag",
            FontAwesome.IconUserTie => "fa-user-tie",
            FontAwesome.IconUserTimes => "fa-user-times",
            FontAwesome.IconUsps => "fa-usps",
            FontAwesome.IconUssunnah => "fa-ussunnah",
            FontAwesome.IconUtensils => "fa-utensils",
            FontAwesome.IconUtensilSpoon => "fa-utensil-spoon",
            FontAwesome.IconVaadin => "fa-vaadin",
            FontAwesome.IconVectorSquare => "fa-vector-square",
            FontAwesome.IconVenus => "fa-venus",
            FontAwesome.IconVenusDouble => "fa-venus-double",
            FontAwesome.IconVenusMars => "fa-venus-mars",
            FontAwesome.IconViacoin => "fa-viacoin",
            FontAwesome.IconViadeo => "fa-viadeo",
            FontAwesome.IconViadeoSquare => "fa-viadeo-square",
            FontAwesome.IconVial => "fa-vial",
            FontAwesome.IconVials => "fa-vials",
            FontAwesome.IconViber => "fa-viber",
            FontAwesome.IconVideo => "fa-video",
            FontAwesome.IconVideoSlash => "fa-video-slash",
            FontAwesome.IconVihara => "fa-vihara",
            FontAwesome.IconVimeo => "fa-vimeo",
            FontAwesome.IconVimeoSquare => "fa-vimeo-square",
            FontAwesome.IconVimeoV => "fa-vimeo-v",
            FontAwesome.IconVine => "fa-vine",
            FontAwesome.IconVirus => "fa-virus",
            FontAwesome.IconViruses => "fa-viruses",
            FontAwesome.IconVirusSlash => "fa-virus-slash",
            FontAwesome.IconVk => "fa-vk",
            FontAwesome.IconVnv => "fa-vnv",
            FontAwesome.IconVoicemail => "fa-voicemail",
            FontAwesome.IconVolleyballBall => "fa-volleyball-ball",
            FontAwesome.IconVolumeDown => "fa-volume-down",
            FontAwesome.IconVolumeMute => "fa-volume-mute",
            FontAwesome.IconVolumeOff => "fa-volume-off",
            FontAwesome.IconVolumeUp => "fa-volume-up",
            FontAwesome.IconVoteYea => "fa-vote-yea",
            FontAwesome.IconVrCardboard => "fa-vr-cardboard",
            FontAwesome.IconVuejs => "fa-vuejs",
            FontAwesome.IconWalking => "fa-walking",
            FontAwesome.IconWallet => "fa-wallet",
            FontAwesome.IconWarehouse => "fa-warehouse",
            FontAwesome.IconWater => "fa-water",
            FontAwesome.IconWaveSquare => "fa-wave-square",
            FontAwesome.IconWaze => "fa-waze",
            FontAwesome.IconWeebly => "fa-weebly",
            FontAwesome.IconWeibo => "fa-weibo",
            FontAwesome.IconWeight => "fa-weight",
            FontAwesome.IconWeightHanging => "fa-weight-hanging",
            FontAwesome.IconWeixin => "fa-weixin",
            FontAwesome.IconWhatsapp => "fa-whatsapp",
            FontAwesome.IconWhatsappSquare => "fa-whatsapp-square",
            FontAwesome.IconWheelchair => "fa-wheelchair",
            FontAwesome.IconWhmcs => "fa-whmcs",
            FontAwesome.IconWifi => "fa-wifi",
            FontAwesome.IconWikipediaW => "fa-wikipedia-w",
            FontAwesome.IconWind => "fa-wind",
            FontAwesome.IconWindowClose => "fa-window-close",
            FontAwesome.IconWindowMaximize => "fa-window-maximize",
            FontAwesome.IconWindowMinimize => "fa-window-minimize",
            FontAwesome.IconWindowRestore => "fa-window-restore",
            FontAwesome.IconWindows => "fa-windows",
            FontAwesome.IconWineBottle => "fa-wine-bottle",
            FontAwesome.IconWineGlass => "fa-wine-glass",
            FontAwesome.IconWineGlassAlt => "fa-wine-glass-alt",
            FontAwesome.IconWix => "fa-wix",
            FontAwesome.IconWizardsOfTheCoast => "fa-wizards-of-the-coast",
            FontAwesome.IconWolfPackBattalion => "fa-wolf-pack-battalion",
            FontAwesome.IconWonSign => "fa-won-sign",
            FontAwesome.IconWordpress => "fa-wordpress",
            FontAwesome.IconWordpressSimple => "fa-wordpress-simple",
            FontAwesome.IconWpbeginner => "fa-wpbeginner",
            FontAwesome.IconWpexplorer => "fa-wpexplorer",
            FontAwesome.IconWpforms => "fa-wpforms",
            FontAwesome.IconWpressr => "fa-wpressr",
            FontAwesome.IconWrench => "fa-wrench",
            FontAwesome.IconXbox => "fa-xbox",
            FontAwesome.IconXing => "fa-xing",
            FontAwesome.IconXingSquare => "fa-xing-square",
            FontAwesome.IconXRay => "fa-x-ray",
            FontAwesome.IconYahoo => "fa-yahoo",
            FontAwesome.IconYammer => "fa-yammer",
            FontAwesome.IconYandex => "fa-yandex",
            FontAwesome.IconYandexInternational => "fa-yandex-international",
            FontAwesome.IconYarn => "fa-yarn",
            FontAwesome.IconYCombinator => "fa-y-combinator",
            FontAwesome.IconYelp => "fa-yelp",
            FontAwesome.IconYenSign => "fa-yen-sign",
            FontAwesome.IconYinYang => "fa-yin-yang",
            FontAwesome.IconYoast => "fa-yoast",
            FontAwesome.IconYoutube => "fa-youtube",
            FontAwesome.IconYoutubeSquare => "fa-youtube-square",
            FontAwesome.IconZhihu => "fa-zhihu",
            _ => throw new ArgumentOutOfRangeException(nameof(icon))
        };

        /// <summary>
        ///   Gets the UTF-8 char associated with a <see cref="FontAwesome"/> icon.
        /// </summary>
        /// 
        public static char GetUnicode(this FontAwesome icon) => (char)icon;
    }
}
