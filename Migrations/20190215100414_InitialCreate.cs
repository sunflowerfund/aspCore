using Microsoft.EntityFrameworkCore.Migrations;

namespace SunflowerFund.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalsScreening",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    areYouHealthy = table.Column<bool>(nullable: false),
                    doesYourFamilyAgreeForyouToDonate = table.Column<bool>(nullable: false),
                    doesYourAnkleSwellEdnOfDay = table.Column<bool>(nullable: false),
                    areYouAHighRiskForhepatitisOrHiv = table.Column<bool>(nullable: false),
                    whatsYourWeight = table.Column<int>(nullable: false),
                    whatsYourHeight = table.Column<int>(nullable: false),
                    areYouARegularBloodDonor = table.Column<bool>(nullable: false),
                    doYouGetUpMorethanOnceAtNight = table.Column<bool>(nullable: false),
                    haveYouEverBeenTestedForHiv = table.Column<bool>(nullable: false),
                    areYouOrYourPartnerRiskOfSTI = table.Column<bool>(nullable: false),
                    areYouAPlateletDonor = table.Column<bool>(nullable: false),
                    areYouWillingToBeAproachedToBeAPlatelet = table.Column<bool>(nullable: false),
                    iConsentToMyPersonalInfoGiveToSANBS = table.Column<bool>(nullable: false),
                    iAgreeToBiengContactedBySANBSAndWPBTSToDonatePlatelet = table.Column<bool>(nullable: false),
                    haveYouEverBeenPregnant = table.Column<bool>(nullable: false),
                    ifSoNumberOfPregnancies = table.Column<bool>(nullable: false),
                    dateOfLastPregnancy = table.Column<bool>(nullable: false),
                    areYouWillingToBeApproachedToBeAPlateletDonor = table.Column<bool>(nullable: false),
                    iConsentToMyPersonalInformationBeingGivenSABSandWPBTS = table.Column<bool>(nullable: false),
                    iAgreeToBeContactedBySANBSandWPBTSToDonatePlatelets = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalsScreening", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalsScreening");
        }
    }
}
