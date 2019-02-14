namespace SunflowerFund.API.models
{
    public class Medical
    {
        public string id { get; set; }
        public bool areYouHealthy { get; set; }
        public bool doesYourFamilyAgreeForyouToDonate { get; set; }
        public bool doesYourAnkleSwellEdnOfDay { get; set; }
        public bool areYouAHighRiskForhepatitisOrHiv { get; set; }
        public int whatsYourWeight { get; set; }
        public int whatsYourHeight { get; set; }
        public bool areYouARegularBloodDonor { get; set; }
        public bool doYouGetUpMorethanOnceAtNight { get; set; }
        public bool haveYouEverBeenTestedForHiv { get; set; }
        public bool areYouOrYourPartnerRiskOfSTI { get; set; }
        public bool areYouAPlateletDonor { get; set; }
        public bool areYouWillingToBeAproachedToBeAPlatelet { get; set; }
        public bool iConsentToMyPersonalInfoGiveToSANBS { get; set; }
        public bool iAgreeToBiengContactedBySANBSAndWPBTSToDonatePlatelet { get; set; }
        public bool haveYouEverBeenPregnant { get; set; }
        public bool ifSoNumberOfPregnancies { get; set; }
        public bool dateOfLastPregnancy { get; set; }
        public bool areYouWillingToBeApproachedToBeAPlateletDonor { get; set; }
        public bool iConsentToMyPersonalInformationBeingGivenSABSandWPBTS { get; set; }
        public bool iAgreeToBeContactedBySANBSandWPBTSToDonatePlatelets { get; set; }
    }
}