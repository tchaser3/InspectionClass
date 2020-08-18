/* Title:           Inspections Class
 * Date:            10-16-2016
 * Author:          Terry Holmes
 * 
 * Description:     This class file is used for all inspections*/

/* Changed on 6-21-17 - Moved to SQl */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace InspectionsDLL
{
    public class InspectionsClass
    {
        //setting up the class file
        EventLogClass TheEventLogClass = new EventLogClass();

        //setting up the data
        DailyVehicleInspectionsDataSet aDailyVehicleInspectionDataSet;
        DailyVehicleInspectionsDataSetTableAdapters.dailyvehicleinspectionTableAdapter aDailyVehicleInspectionTableAdapter;

        InsertDailyVehicleInspectionEntryTableAdapters.QueriesTableAdapter aInsertDailyVehicleInspectionEntryTableAdapter;

        VehicleInsepctionProblemsDataSet aVehicleInspectionProblemsDataSet;
        VehicleInsepctionProblemsDataSetTableAdapters.vehicleinspectionproblemsTableAdapter aVehicleInspectionProblemsTableAdapter;

        InsertVehicleInspectionProblemsEntryTableAdapters.QueriesTableAdapter aInsertVehicleInspectionProblemsEntryTableAdapter;

        FindDailyVehicleInspectionProblemByDateRangeDataSet aFindDailyVehicleInspectionProblemsByDateRangeDataSet;
        FindDailyVehicleInspectionProblemByDateRangeDataSetTableAdapters.FindDailyVehicleInspectionProblemsByDateRangeTableAdapter aFindDailyVehicleInspectionProblemsByDateRangeTableAdapter;

        FindDailyVehicleInspectionProblemByVehicleIDAndDateRangeDataSet aFindDailyVehicleInspectionProblemsByVehicleIDAndDateRangeDataSet;
        FindDailyVehicleInspectionProblemByVehicleIDAndDateRangeDataSetTableAdapters.FindDailyVehicleInspectionProblemsByVehicleIDAndDateRangeTableAdapter aFindDailyVehicleInspectionProblemsByVehicleIDAndDateRangeTableAdapter;

        FindDailyVehicleInspectionsByEmployeeIDAndDateRangeDataSet aFindDailyVehicleInspectionsByEmployeeIDAndDateRangeDataSet;
        FindDailyVehicleInspectionsByEmployeeIDAndDateRangeDataSetTableAdapters.FindDailyVehicleInspectionsByEmployeeIDAndDateRangeTableAdapter aFindDailyVehicleInspectionsByEmployeeIDAndDateRangeTableAdapter;

        FindDailyVehicleInspectionDateMatchDataSet aFindDailyVehicleInspectionDateMatchDataSet;
        FindDailyVehicleInspectionDateMatchDataSetTableAdapters.FindDailyVehicleInspectionByDateMatchTableAdapter aFindDailyVehicleInspectionDateMatchTableAdapter;

        FindInspectionIDForDailyInspectionDataSet aFindInspectionIDForDailyInspectionDataSet;
        FindInspectionIDForDailyInspectionDataSetTableAdapters.FindInspectionIDForDailyInspectionTableAdapter aFindInspectionIDForDailyInspectionTableAdapter;

        FindVehicleInspectionProblemsByInspectionIDDataSet aFindVehicleInspectionProblemsByInspectionIDDataSet;
        FindVehicleInspectionProblemsByInspectionIDDataSetTableAdapters.FindVehicleInspectionProblemsByInspectionIDTableAdapter aFindVehicleInspectionProblemsByInspectionIDTableAdapter;

        FindDailyVehicleInspectionByDateRangeDataSet aFindDailyVehicleInspectionByDateRangeDataSet;
        FindDailyVehicleInspectionByDateRangeDataSetTableAdapters.FindDailyVehicleInspectionByDateRangeTableAdapter aFindDailyVehicleInspectionByDateRangeTableAdapter;

        FindDailyVehicleInspectionByVehicleIDAndDateRangeDataSet aFindDailyVehicleInspectionbyVehicleIDAndDateRangeDataSet;
        FindDailyVehicleInspectionByVehicleIDAndDateRangeDataSetTableAdapters.FindDailyVehicleInspectionsByVehicleIDAndDateRangeTableAdapter aFindDailyVehicleInspectionByVehicleIDAndDateRangeTableAdapter;

        FindDailyVehicleMainInspectionByDateMatchDataSet aFindDailyVehicleMainInspectionByDateMatchDataSet;
        FindDailyVehicleMainInspectionByDateMatchDataSetTableAdapters.FindDailyVehicleMainInspectionByDateMatchTableAdapter aFindDailyVehicleMainInspectionByDateMatchTableAdapter;

        FindDailyVehicleInspectionForDashboardDataSet aFindDailyVehicleInspectionForDashboardDataSet;
        FindDailyVehicleInspectionForDashboardDataSetTableAdapters.FindDailyVehicleInspectionForDashboardTableAdapter aFindDailyVehicleInspectionForDashboardTableAdapter;

        FindVehicleInspectionProblemByProblemIDDataSet aFindVehicleInspectionProblemByProblemIDDataSet;
        FindVehicleInspectionProblemByProblemIDDataSetTableAdapters.FindVehicleInspectionProblemByProblemIDTableAdapter aFindVehicleInspectionProblemByProblemIDTableAdapter;

        DailyVehicleInspectionSummaryReportDataSet aDailyVehicleInspectionSummaryReportDataSet;
        DailyVehicleInspectionSummaryReportDataSetTableAdapters.DailyVehicleInspectionSummaryReportTableAdapter aDailyVehicleInspectionSummaryReportTableAdapter;

        FindDailyVehicleInspectionMaxOdometerDataSet aFindDailyVehicleInspectionMaxOdometerDataSet;
        FindDailyVehicleInspectionMaxOdometerDataSetTableAdapters.FindDailyVehicleInspectionMaxOdometerTableAdapter aFindDailyVehicleInspectionMaxOdometerTableAdapter;

        FindDailyVehicleInspectionForGPSDataSet aFindDailyVehicleInspectionForGPSDataSet;
        FindDailyVehicleInspectionForGPSDataSetTableAdapters.FindDailyVehicleInspectionForGPSTableAdapter aFindDailyVehicleInspectionForGPSTableAdapter;

        public FindDailyVehicleInspectionForGPSDataSet FindDailyVehicleInspectionForGPS(int intVehicleID, DateTime datInspectionDate, int intEmployeeID, string strInspectionStatus, int intOdometerReading)
        {
            try
            {
                aFindDailyVehicleInspectionForGPSDataSet = new FindDailyVehicleInspectionForGPSDataSet();
                aFindDailyVehicleInspectionForGPSTableAdapter = new FindDailyVehicleInspectionForGPSDataSetTableAdapters.FindDailyVehicleInspectionForGPSTableAdapter();
                aFindDailyVehicleInspectionForGPSTableAdapter.Fill(aFindDailyVehicleInspectionForGPSDataSet.FindDailyVehicleInspectionForGPS, intVehicleID, datInspectionDate, intEmployeeID, strInspectionStatus, intOdometerReading);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Find Daily Vehicle Inspection For GPS " + Ex.Message);
            }

            return aFindDailyVehicleInspectionForGPSDataSet;
        }
        public FindDailyVehicleInspectionMaxOdometerDataSet FindDailyVehicleInspectionMaxOdometer(int intVehicleID)
        {
            try
            {
                aFindDailyVehicleInspectionMaxOdometerDataSet = new FindDailyVehicleInspectionMaxOdometerDataSet();
                aFindDailyVehicleInspectionMaxOdometerTableAdapter = new FindDailyVehicleInspectionMaxOdometerDataSetTableAdapters.FindDailyVehicleInspectionMaxOdometerTableAdapter();
                aFindDailyVehicleInspectionMaxOdometerTableAdapter.Fill(aFindDailyVehicleInspectionMaxOdometerDataSet.FindDailyVehicleInspectionMaxOdometer, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspection Class // FindDaily Vehicle " + Ex.Message);
            }

            return aFindDailyVehicleInspectionMaxOdometerDataSet;
        }
        public DailyVehicleInspectionSummaryReportDataSet DailyVehicleInspectionSummaryReport(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aDailyVehicleInspectionSummaryReportDataSet = new DailyVehicleInspectionSummaryReportDataSet();
                aDailyVehicleInspectionSummaryReportTableAdapter = new DailyVehicleInspectionSummaryReportDataSetTableAdapters.DailyVehicleInspectionSummaryReportTableAdapter();
                aDailyVehicleInspectionSummaryReportTableAdapter.Fill(aDailyVehicleInspectionSummaryReportDataSet.DailyVehicleInspectionSummaryReport, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Daily Vehicle Inspection Summary Report " + Ex.Message);
            }

            return aDailyVehicleInspectionSummaryReportDataSet;
        }
        public FindVehicleInspectionProblemByProblemIDDataSet FindVehicleInspectionProblemByProblemID(int intProblemID)
        {
            try
            {
                aFindVehicleInspectionProblemByProblemIDDataSet = new FindVehicleInspectionProblemByProblemIDDataSet();
                aFindVehicleInspectionProblemByProblemIDTableAdapter = new FindVehicleInspectionProblemByProblemIDDataSetTableAdapters.FindVehicleInspectionProblemByProblemIDTableAdapter();
                aFindVehicleInspectionProblemByProblemIDTableAdapter.Fill(aFindVehicleInspectionProblemByProblemIDDataSet.FindVehicleInspectionProblemByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Find Vehicle Inspection Problem By Problem ID " + Ex.Message);
            }

            return aFindVehicleInspectionProblemByProblemIDDataSet;
        }
        public FindDailyVehicleInspectionForDashboardDataSet FindDailyVehicleInspectionForDashboard(int intVehicleID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDailyVehicleInspectionForDashboardDataSet = new FindDailyVehicleInspectionForDashboardDataSet();
                aFindDailyVehicleInspectionForDashboardTableAdapter = new FindDailyVehicleInspectionForDashboardDataSetTableAdapters.FindDailyVehicleInspectionForDashboardTableAdapter();
                aFindDailyVehicleInspectionForDashboardTableAdapter.Fill(aFindDailyVehicleInspectionForDashboardDataSet.FindDailyVehicleInspectionForDashboard, intVehicleID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Find Daily Vehicle Inspection For Dashboard " + Ex.Message);
            }

            return aFindDailyVehicleInspectionForDashboardDataSet;
        }
        public FindDailyVehicleMainInspectionByDateMatchDataSet FindDailyVehicleMainInspectionByDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindDailyVehicleMainInspectionByDateMatchDataSet = new FindDailyVehicleMainInspectionByDateMatchDataSet();
                aFindDailyVehicleMainInspectionByDateMatchTableAdapter = new FindDailyVehicleMainInspectionByDateMatchDataSetTableAdapters.FindDailyVehicleMainInspectionByDateMatchTableAdapter();
                aFindDailyVehicleMainInspectionByDateMatchTableAdapter.Fill(aFindDailyVehicleMainInspectionByDateMatchDataSet.FindDailyVehicleMainInspectionByDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Find Daily Vehicle Main Inspection By Date Match " + Ex.Message);
            }

            return aFindDailyVehicleMainInspectionByDateMatchDataSet;
        }
        public FindDailyVehicleInspectionByVehicleIDAndDateRangeDataSet FindDailyVehicleInspectionByVehicleIDAndDateRange(int intVehicleID, DateTime datStartDate, DateTime datEndDate)
        {

            try
            {
                aFindDailyVehicleInspectionbyVehicleIDAndDateRangeDataSet = new FindDailyVehicleInspectionByVehicleIDAndDateRangeDataSet();
                aFindDailyVehicleInspectionByVehicleIDAndDateRangeTableAdapter = new FindDailyVehicleInspectionByVehicleIDAndDateRangeDataSetTableAdapters.FindDailyVehicleInspectionsByVehicleIDAndDateRangeTableAdapter();
                aFindDailyVehicleInspectionByVehicleIDAndDateRangeTableAdapter.Fill(aFindDailyVehicleInspectionbyVehicleIDAndDateRangeDataSet.FindDailyVehicleInspectionsByVehicleIDAndDateRange, intVehicleID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspection Class // Find Daily Vehicle Inspection By Vehicle ID and Date Range " + Ex.Message);
            }

            return aFindDailyVehicleInspectionbyVehicleIDAndDateRangeDataSet;
        }
        public FindDailyVehicleInspectionByDateRangeDataSet FindDailyVehicleInspectionByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDailyVehicleInspectionByDateRangeDataSet = new FindDailyVehicleInspectionByDateRangeDataSet();
                aFindDailyVehicleInspectionByDateRangeTableAdapter = new FindDailyVehicleInspectionByDateRangeDataSetTableAdapters.FindDailyVehicleInspectionByDateRangeTableAdapter();
                aFindDailyVehicleInspectionByDateRangeTableAdapter.Fill(aFindDailyVehicleInspectionByDateRangeDataSet.FindDailyVehicleInspectionByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Find Daily Vehicle Inspection by Date Range " + Ex.Message);
            }

            return aFindDailyVehicleInspectionByDateRangeDataSet;
        }
        public FindVehicleInspectionProblemsByInspectionIDDataSet FindVehicleInspectionProblemsbyInspectionID(int intInspectionID)
        {
            try
            {
                aFindVehicleInspectionProblemsByInspectionIDDataSet = new FindVehicleInspectionProblemsByInspectionIDDataSet();
                aFindVehicleInspectionProblemsByInspectionIDTableAdapter = new FindVehicleInspectionProblemsByInspectionIDDataSetTableAdapters.FindVehicleInspectionProblemsByInspectionIDTableAdapter();
                aFindVehicleInspectionProblemsByInspectionIDTableAdapter.Fill(aFindVehicleInspectionProblemsByInspectionIDDataSet.FindVehicleInspectionProblemsByInspectionID, intInspectionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Find Vehicle Inspection Problems By Inspection ID " + Ex.Message);
            }

            return aFindVehicleInspectionProblemsByInspectionIDDataSet;
        }
        public FindInspectionIDForDailyInspectionDataSet FindInspectionIDForDailyInspections(int intVehicleID, DateTime datInspectionDate, int intEmployeeID, string strInspectionStatus, int intOdometerReading)
        {
            try
            {
                aFindInspectionIDForDailyInspectionDataSet = new FindInspectionIDForDailyInspectionDataSet();
                aFindInspectionIDForDailyInspectionTableAdapter = new FindInspectionIDForDailyInspectionDataSetTableAdapters.FindInspectionIDForDailyInspectionTableAdapter();
                aFindInspectionIDForDailyInspectionTableAdapter.Fill(aFindInspectionIDForDailyInspectionDataSet.FindInspectionIDForDailyInspection, intVehicleID, datInspectionDate, intEmployeeID, strInspectionStatus, intOdometerReading);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Find Inspection ID For Daily Inspections " + Ex.Message);
            }

            return aFindInspectionIDForDailyInspectionDataSet;
        }
        public FindDailyVehicleInspectionDateMatchDataSet FindDailyVehicleInspectionDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindDailyVehicleInspectionDateMatchDataSet = new FindDailyVehicleInspectionDateMatchDataSet();
                aFindDailyVehicleInspectionDateMatchTableAdapter = new FindDailyVehicleInspectionDateMatchDataSetTableAdapters.FindDailyVehicleInspectionByDateMatchTableAdapter();
                aFindDailyVehicleInspectionDateMatchTableAdapter.Fill(aFindDailyVehicleInspectionDateMatchDataSet.FindDailyVehicleInspectionByDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspection Class // Find Daily Vehicle Inspection Date Match " + Ex.Message);
            }

            return aFindDailyVehicleInspectionDateMatchDataSet;
        }
        public FindDailyVehicleInspectionsByEmployeeIDAndDateRangeDataSet FindDailyVehicleInspectionByEmployeeIDAndDateRange(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDailyVehicleInspectionsByEmployeeIDAndDateRangeDataSet = new FindDailyVehicleInspectionsByEmployeeIDAndDateRangeDataSet();
                aFindDailyVehicleInspectionsByEmployeeIDAndDateRangeTableAdapter = new FindDailyVehicleInspectionsByEmployeeIDAndDateRangeDataSetTableAdapters.FindDailyVehicleInspectionsByEmployeeIDAndDateRangeTableAdapter();
                aFindDailyVehicleInspectionsByEmployeeIDAndDateRangeTableAdapter.Fill(aFindDailyVehicleInspectionsByEmployeeIDAndDateRangeDataSet.FindDailyVehicleInspectionsByEmployeeIDAndDateRange, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspection Class // Find Daily Vehicle Inspectioon By Employee ID and Date Range " + Ex.Message);
            }

            return aFindDailyVehicleInspectionsByEmployeeIDAndDateRangeDataSet;
        }
        public FindDailyVehicleInspectionProblemByVehicleIDAndDateRangeDataSet FindDailyVehicleInspectionProblemByVehicleIDAndDateRange(int intVehicleID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDailyVehicleInspectionProblemsByVehicleIDAndDateRangeDataSet = new FindDailyVehicleInspectionProblemByVehicleIDAndDateRangeDataSet();
                aFindDailyVehicleInspectionProblemsByVehicleIDAndDateRangeTableAdapter = new FindDailyVehicleInspectionProblemByVehicleIDAndDateRangeDataSetTableAdapters.FindDailyVehicleInspectionProblemsByVehicleIDAndDateRangeTableAdapter();
                aFindDailyVehicleInspectionProblemsByVehicleIDAndDateRangeTableAdapter.Fill(aFindDailyVehicleInspectionProblemsByVehicleIDAndDateRangeDataSet.FindDailyVehicleInspectionProblemsByVehicleIDAndDateRange, intVehicleID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Find Daily Vehicle Inspection Problems By Vehicle ID and Date Range " + Ex.Message);
            }

            return aFindDailyVehicleInspectionProblemsByVehicleIDAndDateRangeDataSet;
        }
        public FindDailyVehicleInspectionProblemByDateRangeDataSet FindDailyVehicleInspectionProblemsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDailyVehicleInspectionProblemsByDateRangeDataSet = new FindDailyVehicleInspectionProblemByDateRangeDataSet();
                aFindDailyVehicleInspectionProblemsByDateRangeTableAdapter = new FindDailyVehicleInspectionProblemByDateRangeDataSetTableAdapters.FindDailyVehicleInspectionProblemsByDateRangeTableAdapter();
                aFindDailyVehicleInspectionProblemsByDateRangeTableAdapter.Fill(aFindDailyVehicleInspectionProblemsByDateRangeDataSet.FindDailyVehicleInspectionProblemsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Find Daily Vehicle Inspection Problems By Date Range " + Ex.Message);
            }

            return aFindDailyVehicleInspectionProblemsByDateRangeDataSet;
        }
        public bool InsertVehicleInspectionProblem(int intVehicleID, int intInspectionID, string strInspectionType, string strVehicleProblem, int intOdometerReading, bool blnVehicleServiceAbility, string strInspectionNotes, int intManagerID, int intFleetEmployeeID, string strManagerNotes, string strFleetNotes, int intProblemID)
        {
            //setting local variable
            bool blnFatalError = false;

            try
            {
                aInsertVehicleInspectionProblemsEntryTableAdapter = new InsertVehicleInspectionProblemsEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleInspectionProblemsEntryTableAdapter.InsertVehicleInspectionProblems(intVehicleID, intInspectionID, strInspectionType, strVehicleProblem, intOdometerReading, blnVehicleServiceAbility, strInspectionNotes, intManagerID, intFleetEmployeeID, strManagerNotes, strFleetNotes, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspection Class // Insert Vehicle Inspection Problem " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public VehicleInsepctionProblemsDataSet GetVehicleInspectionProblemsInfo()
        {
            try
            {
                aVehicleInspectionProblemsDataSet = new VehicleInsepctionProblemsDataSet();
                aVehicleInspectionProblemsTableAdapter = new VehicleInsepctionProblemsDataSetTableAdapters.vehicleinspectionproblemsTableAdapter();
                aVehicleInspectionProblemsTableAdapter.Fill(aVehicleInspectionProblemsDataSet.vehicleinspectionproblems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspection Class // Get Vehicle Inspection Problems " + Ex.Message);
            }

            return aVehicleInspectionProblemsDataSet;
        }
        public void UpdateVehicleInspectionProblemsDB(VehicleInsepctionProblemsDataSet aVehicleInspectionProblemsDataSet)
        {
            try
            {
                aVehicleInspectionProblemsTableAdapter = new VehicleInsepctionProblemsDataSetTableAdapters.vehicleinspectionproblemsTableAdapter();
                aVehicleInspectionProblemsTableAdapter.Update(aVehicleInspectionProblemsDataSet.vehicleinspectionproblems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspection Class // Get Vehicle Inspection Problems " + Ex.Message);
            }
        }
        public bool InsertDailyVehicleInspection(int intVehicleID, DateTime datTransactionDate, int intEmployeeID, string strInspectionStatus, int intOdometerReading)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDailyVehicleInspectionEntryTableAdapter = new InsertDailyVehicleInspectionEntryTableAdapters.QueriesTableAdapter();
                aInsertDailyVehicleInspectionEntryTableAdapter.InsertDailyVehicleInspection(intVehicleID, datTransactionDate, intEmployeeID, strInspectionStatus, intOdometerReading);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Insert Daily Vehicle Inspection " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DailyVehicleInspectionsDataSet GetDailyVehicleInspectionsInfo()
        {
            try
            {
                aDailyVehicleInspectionDataSet = new DailyVehicleInspectionsDataSet();
                aDailyVehicleInspectionTableAdapter = new DailyVehicleInspectionsDataSetTableAdapters.dailyvehicleinspectionTableAdapter();
                aDailyVehicleInspectionTableAdapter.Fill(aDailyVehicleInspectionDataSet.dailyvehicleinspection);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Get Daily Vehicle Inspections Info " + Ex.Message);
            }

            return aDailyVehicleInspectionDataSet;
        }
        public void UpdateDailyVehicleInspectionDB(DailyVehicleInspectionsDataSet aDailyVehicleInspectionDataSet)
        {
            try
            {
                aDailyVehicleInspectionTableAdapter = new DailyVehicleInspectionsDataSetTableAdapters.dailyvehicleinspectionTableAdapter();
                aDailyVehicleInspectionTableAdapter.Update(aDailyVehicleInspectionDataSet.dailyvehicleinspection);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inspections Class // Update Daily Vehicle Inspections DB " + Ex.Message);
            }
        }
        
    }
}
