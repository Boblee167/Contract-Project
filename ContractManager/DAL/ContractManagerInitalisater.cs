using ContractManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContractManager.DAL
{
    public class ContractManagerInitalisater : DropCreateDatabaseIfModelChanges<ContractManagerContext>
    {
        protected override void Seed(ContractManagerContext context)
        {
            var property = new List<Property>
            {
                new Property{Address="Áras Mhic Dhiarmada, HQ Building, Store Street, Dublin 1", County="Dublin 1",Type = Property_Type.DEASP,Cost_Centre="V4000",OPW_Building_Code="B0034",Team=Property_Team.Team_North,SquareFootage=12119,StaffCapacity=450,music=Music.None},
                new Property{Address="Kilmainham West, Con Colbert House, Computer Centre HQ, 72-100 Inchicore Road, Kilmainham, Dublin 7", County="Dublin 8 ",Type = Property_Type.DEASP,Cost_Centre="V4033",OPW_Building_Code="B0857",Team=Property_Team.Team_South,SquareFootage=4285,StaffCapacity=280,music=Music.None},
                new Property{Address="Goldsmith House HQ,  7-13 Pearse Street, Dublin 2", County="Dublin 2",Type = Property_Type.DEASP,Cost_Centre="V4025",OPW_Building_Code="B1891",Team=Property_Team.Team_South,SquareFootage=3762,StaffCapacity=200,music=Music.None},
                new Property{Address="Longford Government Buildings, Ballinalee Road, Longford, Co. Longford", County="Co. Longford",Type = Property_Type.DEASP,Cost_Centre="V4054",OPW_Building_Code="B2460",Team=Property_Team.Team_North,SquareFootage=8441,StaffCapacity=458,music=Music.Radio},
                new Property{Address="Tallaght Intreo Centre, Social Services Centre, The Square, Tallaght, Dublin 24", County="Dublin 24",Type = Property_Type.DEASP,Cost_Centre="V3435",OPW_Building_Code="B3717",Team=Property_Team.Team_South,SquareFootage=3173,StaffCapacity=102,music=Music.CD},
                new Property{Address="Elizabeth O'Farrell House, 19-28 North Cumberland Street, Dublin 1,", County="Dublin 1,",Type = Property_Type.DEASP,Cost_Centre="V3365",OPW_Building_Code="B4005",Team=Property_Team.Team_North,SquareFootage=100,StaffCapacity=220,music=Music.None},
                new Property{Address="Parnell Street Intreo Centre, 20, King's Inn Street, Dublin 1", County="Dublin 1",Type = Property_Type.DEASP,Cost_Centre="V3370",OPW_Building_Code="BBBBB",Team=Property_Team.Team_North,SquareFootage=5452,StaffCapacity=280,music=Music.CD},
                new Property{Address="Waterford Intreo Centre/ Regional Headquarters, Government Buildings, Cork Road, Waterford, Co. Waterford", County="Co. Waterford",Type = Property_Type.DEASP,Cost_Centre="V4056",OPW_Building_Code="B5183",Team=Property_Team.Team_South,SquareFootage=3468,StaffCapacity=185,music=Music.Radio},
                new Property{Address="Ardee CWS, Health Centre, Market Street, Ardee, Co. Louth", County="Co. Louth",Type = Property_Type.HSE_Location,Cost_Centre="V2402",OPW_Building_Code="None",Team=Property_Team.Team_North,SquareFootage=100,StaffCapacity=15,music=Music.None},
                new Property{Address="Ardee (Social Welfare Branch Office), Moore Hall, Ardee, Co. Louth ", County="Co. Louth",Type = Property_Type.Branch_Office,Cost_Centre="V3315",OPW_Building_Code="None",Team=Property_Team.Team_North,SquareFootage=100,StaffCapacity=8,music=Music.None},
            };

            var Supplier = new List<Supplier>
            {
                new Supplier{SupplierName="SARS",SupplierAddress="A8 Centrepoint Business Park, Oak Road, Dublin 12",SupplierEMail="info@sargroup.ie",SupplierPhoneNo="01-4506789"},
                new Supplier{SupplierName="Country Clean Ltd",SupplierAddress="Ballygown,Mallow,Co Cork",SupplierEMail="sales@countryclean.ie",SupplierPhoneNo="022-46848"},
                new Supplier{SupplierName="Grosvenor",SupplierAddress="64c Heather Road,Sandyford Industrial Estate,Dublin 18",SupplierEMail="enquiriesireland@grosvenorservices.com",SupplierPhoneNo="01-2954866"},
                new Supplier{SupplierName="William Tracey & Sons",SupplierAddress="Unit 21 Churchtown Business Park, Beaumont Avenue, Churchtown, Dublin 14, D14 CC65",SupplierEMail="info@williamtraceyandsons.ie",SupplierPhoneNo="01-2983153"},
                new Supplier{SupplierName="MSC Fire",SupplierAddress="2 Stillorgan Industrial Pk,Birch Avenue,Co Dublin",SupplierEMail="info@mscfire.ie",SupplierPhoneNo="01-8465140"},
            };

            var Contract = new List<ContractDetails>
            {
                new ContractDetails{Supplier_ID=1,StartDate = new DateTime(01,01,2017),FinishDate= new DateTime(01,01,2021),services=ContractDetails.Service.Security,HourlyPrice = 18.50},
                new ContractDetails{Supplier_ID=2,StartDate = new DateTime(01,08,2018),FinishDate= new DateTime(01,08,2022),services=ContractDetails.Service.Waste,HourlyPrice =0,GoodsDesc="Wheelie Bins", GoodsPrice = 100.00},
                new ContractDetails{Supplier_ID=3,StartDate = new DateTime(01,11,2018),FinishDate= new DateTime(01,11,2020),services=ContractDetails.Service.Cleaning,HourlyPrice = 15.25,GoodsDesc="Toilet Rolls",GoodsPrice = 3.52 },
                new ContractDetails{Supplier_ID=4,StartDate = new DateTime(01,06,2016),FinishDate= new DateTime(01,06,2020),services=ContractDetails.Service.Transport,HourlyPrice = 12.85,GoodsDesc="Packing Boxes",GoodsPrice = 2.50},
                new ContractDetails{Supplier_ID=5,StartDate = new DateTime(01,02,2019),FinishDate= new DateTime(01,02,2019),services=ContractDetails.Service.Fire_Equipment,HourlyPrice = 0, GoodsDesc="Service Charge",GoodsPrice = 125.00},
            };

            var CleaningHours = new List<ContractHours>
            {
                new ContractHours{Contract_ID=1,Property_ID=1,weekDay=WeekDay.Mon, Hours = 12.00, HoursupDatedDate = new DateTime (01,15,2019),AnnualHours = 5000.00, AvgMonthlyHours = 150, },
                
            };


        }

    }
}