using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDBforJsonDataApp
{
    
    public class Rootobject
    {
        public int ID { get; set; }
        public Policy policy { get; set; }
    }

    public class Policy
    {
        public int ID { get; set; }
        public int policy_id { get; set; }
        public int record_id { get; set; }
        public string product_code { get; set; }
        public string reference { get; set; }
        public string status_code { get; set; }
        public string status_description { get; set; }
        public int product_version { get; set; }
        public bool converted { get; set; }
        public string created { get; set; }
        public string period_start { get; set; }
        public string effective_from { get; set; }
        public string period_end { get; set; }
        public string country_code { get; set; }
        public string lang { get; set; }
        public Client client { get; set; }
        public Agency agency { get; set; }
        public Binder binder { get; set; }
        public ICollection<Page> pages { get; set; }
        public ICollection<Section> sections { get; set; }
        public TotalAnnualPremium totalannualpremium { get; set; }
        public TotalTransactionPremium totaltransactionpremium { get; set; }
        public ICollection<Endorsement> endorsements { get; set; }
    }

    public class Client
    {
        public int id { get; set; }
        public string number { get; set; }
    }

    public class Agency
    {
        public int id { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string FCA_reference { get; set; }
    }

    public class Binder
    {
        public int id { get; set; }
        public string version { get; set; }
        public string description { get; set; }
    }

    public class TotalAnnualPremium
    {
        public int id { get; set; }
        public string ratingbasis { get; set; }
        public string netnetpremium { get; set; }
        public string mgacommission { get; set; }
        public string netpremium { get; set; }
        public string brokercommission { get; set; }
        public string grosspremium { get; set; }
        public string tax { get; set; }
        public string total { get; set; }
    }

    public class TotalTransactionPremium
    {
        public int id { get; set; }
        public string ratingbasis { get; set; }
        public string netnetpremium { get; set; }
        public string mgacommission { get; set; }
        public string netpremium { get; set; }
        public string brokercommission { get; set; }
        public string grosspremium { get; set; }
        public string tax { get; set; }
        public string total { get; set; }
    }

    public class Page
    {
        public string pageid { get; set; }
        public string name { get; set; }
        public Questions questions { get; set; }
    }

    public class Questions
    {
        public string id { get; set; }
        public string proposer { get; set; }
        public string trade_name { get; set; }
        public string bus_desc { get; set; }
        public string first_quote { get; set; }
        public string year_founded { get; set; }
        public string new_venture { get; set; }
        public string prospect { get; set; }
        public string presentation_received { get; set; }
        public string cross_sell { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string address_3 { get; set; }
        public string town { get; set; }
        public string county { get; set; }
        public string post_code { get; set; }
        public string due_date_2 { get; set; }
        public string required_date { get; set; }
        public string holding_broker { get; set; }
        public string holding_broker_info { get; set; }
        public string previous_premium { get; set; }
        public string target_premium { get; set; }
        public string tax_exempt { get; set; }
        public string lead_carrier_override { get; set; }
        public string lead_override_referred_to_HO { get; set; }
        public string pol_tradecode { get; set; }
        public string mta_date { get; set; }
        public string mta_reason { get; set; }
        public string sof_claim_1 { get; set; }
        public string sof_claim_2 { get; set; }
        public string md_selected_5 { get; set; }
        public string bi_selected { get; set; }
        public string li_selected { get; set; }
        public string sar_selected { get; set; }
        public string car_selected { get; set; }
        public string it_selected { get; set; }
        public string money_selected { get; set; }
        public string git_selected { get; set; }
        public string mar_selected { get; set; }
        public string cyb_selected { get; set; }
        public string do_selected { get; set; }
        public string ff_selected { get; set; }
        public string lol_selected { get; set; }
        public string fg_selected { get; set; }
        public string ter_selected { get; set; }
        public string leg_selected { get; set; }
        public string fire_selected { get; set; }
        public string light_selected { get; set; }
        public string expl_selected { get; set; }
        public string air_selected { get; set; }
        public string riot_selected_pcc { get; set; }
        public string mal_person_selected { get; set; }
        public string earth_selected { get; set; }
        public string sub_selected { get; set; }
        public string storm_selected { get; set; }
        public string flood_selected { get; set; }
        public string eow_selected { get; set; }
        public string impact_selected { get; set; }
        public string acc_water_selected { get; set; }
        public string acc_damage_selected { get; set; }
        public string heave_selected { get; set; }
        public string theft_selected_pcc { get; set; }
        public string oil_selected_pcc { get; set; }
        public string gq_survey_contact { get; set; }
        public string gq_survey_name { get; set; }
        public string gq_survey_phone { get; set; }
        public string gq_survey_email { get; set; }
        public string gq_survey_position { get; set; }
        public string gq_management { get; set; }
        public string gq_facts { get; set; }
        public string sof_gen_1 { get; set; }
        public string sof_gen_2 { get; set; }
        public string sof_gen_3 { get; set; }
        public string sof_gen_4 { get; set; }
        public string sof_gen_5 { get; set; }
        public string sof_gen_6 { get; set; }
        public string sof_gen_7 { get; set; }
        public string sof_gen_8 { get; set; }
    }

    public class Section
    {
        public string state { get; set; }
        public string sectionid { get; set; }
        public string name { get; set; }
        public ICollection<SectionPage> pages { get; set; }
        public AnnualPremium annualpremium { get; set; }
        public TransactionPremium transactionpremium { get; set; }
    }

    public class AnnualPremium
    {
        public int id { get; set; }
        public string sectionid { get; set; }
        public string ratingbasis { get; set; }
        public string netnetpremium { get; set; }
        public string mgacommission { get; set; }
        public string netpremium { get; set; }
        public string brokercommission { get; set; }
        public string grosspremium { get; set; }
        public string tax { get; set; }
        public string total { get; set; }
        public ICollection<Rate> rates { get; set; }
    }

    public class Rate
    {
        public int id { get; set; }
        public string description { get; set; }
        public string sum { get; set; }
        public string BookRate { get; set; }
        public string Cost { get; set; }
        public string TechAdjust { get; set; }
        public string CommAdjust { get; set; }
        public string AdjustedRate { get; set; }
        public string Premium { get; set; }
    }

    public class TransactionPremium
    {
        public int id { get; set; }
        public string sectionid { get; set; }
        public string ratingbasis { get; set; }
        public string netnetpremium { get; set; }
        public string mgacommission { get; set; }
        public string netpremium { get; set; }
        public string brokercommission { get; set; }
        public string grosspremium { get; set; }
        public string tax { get; set; }
        public string total { get; set; }
    }

    public class SectionPage
    {
        public string ID { get; set; }
        public string pageid { get; set; }
        public string name { get; set; }
        public SectionQuestions questions { get; set; }
        public ICollection<SectionSet> set { get; set; }
    }

    public class SectionQuestions
    {
        public string id { get; set; }
        public string p_excess_md7 { get; set; }
        public string p_excess_sub_md7 { get; set; }
        public string bi_unspec_supp { get; set; }
        public string bi_unspec_cust { get; set; }
        public string bi_denial { get; set; }
        public string bi_public_util { get; set; }
        public string bi_disease { get; set; }
        public string bi_book_debts { get; set; }
        public string bi_info { get; set; }
        public string bi_emlamount { get; set; }
        public string bi_emlpercent { get; set; }
        public string elto_pol_ern_exempt { get; set; }
        public string elto_pol_ern_number { get; set; }
        public string sof_li_1 { get; set; }
        public string sof_li_2 { get; set; }
        public string sof_li_3 { get; set; }
        public string sof_li_4 { get; set; }
        public string sof_li_5 { get; set; }
        public string sof_li_6 { get; set; }
        public string sof_li_7 { get; set; }
        public string sof_li_8 { get; set; }
        public string el_limit { get; set; }
        public string el_clerical2 { get; set; }
        public string el_excess { get; set; }
        public string el_deposit { get; set; }
        public string pl_public_limit { get; set; }
        public string pl_min_deposit { get; set; }
        public string pl_excess { get; set; }
        public string pr_excess { get; set; }
        public string pl_prem_turnover { get; set; }
        public string pl_work_away { get; set; }
        public string pl_pay_bfsc { get; set; }
        public string pl_product_limit { get; set; }
        public string pr_min_deposit { get; set; }
        public string pr_turnover_uk { get; set; }
        public string pr_turnover_na { get; set; }
        public string pr_turnover_world { get; set; }
        public string sar_info { get; set; }
        public string car_tradecode { get; set; }
        public string car_risk_type { get; set; }
        public string car_risk_max_period { get; set; }
        public string car_risk_maintenance { get; set; }
        public string car_risk_works_limit { get; set; }
        public string car_risk_tools_limit { get; set; }
        public string car_risk_tools_per_item { get; set; }
        public string car_risk_building_limit { get; set; }
        public string car_risk_hired_limit { get; set; }
        public string car_risk_employees_limit { get; set; }
        public string car_risk_employees_per_item { get; set; }
        public string car_theft_excess { get; set; }
        public string car_loss_excess { get; set; }
        public string car_risk_deposit { get; set; }
        public string car_turnover { get; set; }
        public string car_contr_val { get; set; }
        public string car_tools_equipment { get; set; }
        public string car_temp_build { get; set; }
        public string car_prop_charge { get; set; }
        public string car_empl_prop { get; set; }
        public string it_sum { get; set; }
        public string it_hack_limit { get; set; }
        public string it_sum_add { get; set; }
        public string it_max_period { get; set; }
        public string it_excess { get; set; }
        public string mn_transit_prem_limit { get; set; }
        public string mn_transit_prem { get; set; }
        public string mn_unspec_limit { get; set; }
        public string mn_unsecured { get; set; }
        public string mn_home { get; set; }
        public string mn_death { get; set; }
        public string mn_limbs { get; set; }
        public string mn_sight { get; set; }
        public string mn_perm_dis { get; set; }
        public string mn_temp_dis { get; set; }
        public string mn_info { get; set; }
        public string mn_excess { get; set; }
        public string git_max { get; set; }
        public string git_immobile { get; set; }
        public string git_locks { get; set; }
        public string git_alarm { get; set; }
        public string git_alarm_contract { get; set; }
        public string git_device_info { get; set; }
        public string git_unattended { get; set; }
        public string git_package_2 { get; set; }
        public string git_consignment_2 { get; set; }
        public string git_one_loss { get; set; }
        public string git_sending { get; set; }
        public string git_total_sum { get; set; }
        public string git_info { get; set; }
        public string git_excess_2 { get; set; }
        public string mar_goods { get; set; }
        public string mar_import_1 { get; set; }
        public string mar_import_2 { get; set; }
        public string mar_import_3 { get; set; }
        public string mar_import_4 { get; set; }
        public string mar_basis { get; set; }
        public string mar_deposit_per { get; set; }
        public string mar_air_max { get; set; }
        public string mar_air_excess { get; set; }
        public string mar_road_max { get; set; }
        public string mar_road_exces { get; set; }
        public string mar_veh_max { get; set; }
        public string mar_veh_excess { get; set; }
        public string mar_loc_max { get; set; }
        public string mar_loc_excess { get; set; }
        public string mar_zone_1 { get; set; }
        public string mar_zone_1_carrying { get; set; }
        public string mar_zone_2 { get; set; }
        public string mar_zone_2_carrying { get; set; }
        public string mar_zone_3 { get; set; }
        public string mar_zone_3_carrying { get; set; }
        public string mar_zone_4 { get; set; }
        public string mar_zone_4_carrying { get; set; }
        public string mar_zone_5 { get; set; }
        public string mar_zone_5_carrying { get; set; }
        public string mar_zone_6 { get; set; }
        public string mar_zone_6_carrying { get; set; }
        public string mar_zone_7 { get; set; }
        public string mar_zone_7_carrying { get; set; }
        public string mar_zone_8 { get; set; }
        public string mar_zone_8_carrying { get; set; }
        public string cyb_limit { get; set; }
        public string cyb_excess { get; set; }
        public string do_lit_date { get; set; }
        public string do_pcc_turnover { get; set; }
        public string do_pcc_limit { get; set; }
        public string do_pcc_excess { get; set; }
        public string do_pcc_corp_turnover { get; set; }
        public string do_pcc_corp_limit { get; set; }
        public string do_pcc_corp_excess { get; set; }
        public string do_pcc_ep_limit { get; set; }
        public string do_pcc_ep_excess { get; set; }
        public string sof_do_1 { get; set; }
        public string sof_do_2 { get; set; }
        public string sof_do_3 { get; set; }
        public string sof_do_4 { get; set; }
        public string sof_do_5 { get; set; }
        public string sof_do_6 { get; set; }
        public string sof_do_7 { get; set; }
        public string sof_do_8 { get; set; }
        public string sof_do_9 { get; set; }
        public string sof_do_10 { get; set; }
        public string sof_do_11 { get; set; }
        public string sof_do_12 { get; set; }
        public string ff_premises { get; set; }
        public string ff_premises_sum { get; set; }
        public string ff_contract { get; set; }
        public string ff_info { get; set; }
        public string ff_premises_excess { get; set; }
        public string lol_premises { get; set; }
        public string lol_premises_sup { get; set; }
        public string lol_premises_limit { get; set; }
        public string lol_held { get; set; }
        public string lol_renewal { get; set; }
        public string lol_conditions { get; set; }
        public string sof_lol_1 { get; set; }
        public string lol_info { get; set; }
        public string lol_premises_excess { get; set; }
        public string fg_all_emp { get; set; }
        public string fg_agr_limit { get; set; }
        public string fg_min_deposit { get; set; }
        public string fg_excess { get; set; }
        public string cede_terrorism_commission { get; set; }
        public string leg_pcc_limit { get; set; }
        public string leg_pcc_turnover { get; set; }
        public string leg_pcc_wages { get; set; }
        public string current_product_id { get; set; }
        public string leg_pcc_carrier_extra { get; set; }
        public string leg_pcc_carrier { get; set; }
        public string leg_pcc_premium { get; set; }
        public string sof_leg_1 { get; set; }
        public string sof_leg_2 { get; set; }
        public string sof_leg_3 { get; set; }
        public string sof_leg_4 { get; set; }
        public string sof_leg_5 { get; set; }
        public string sof_leg_6 { get; set; }
    }

    public class SectionSet
    {
        public int ID { get; set; }
        public int number { get; set; }
        public SetQuestions questions { get; set; }
        public SectionAnnualPremium sectionannualpremium { get; set; }
        public ICollection<SetData> set { get; set; }
        public string el_mis_desc { get; set; }
        public string el_mis_sum { get; set; }
        public string sar_desc { get; set; }
        public string sar_location { get; set; }
        public string sar_sum { get; set; }
        public string sar_excess { get; set; }
    }

    public class SetQuestions
    {
        public int ID { get; set; }
        public string p_address_1 { get; set; }
        public string p_address_2 { get; set; }
        public string p_address_3 { get; set; }
        public string p_town { get; set; }
        public string p_county { get; set; }
        public string p_post_code { get; set; }
        public string p_age { get; set; }
        public string terror_zone { get; set; }
        public string sof_md_1 { get; set; }
        public string sof_md_2 { get; set; }
        public string sof_md_3 { get; set; }
        public string sof_md_4 { get; set; }
        public string p_day_one { get; set; }
        public string stock_basis { get; set; }
        public string p_building { get; set; }
        public string p_building_period { get; set; }
        public string p_machinery { get; set; }
        public string p_machinery_period { get; set; }
        public string p_stock { get; set; }
        public string p_computer { get; set; }
        public string p_computer_period { get; set; }
        public string p_tradecode { get; set; }
        public string p_tradekey { get; set; }
        public string p_proximity_date { get; set; }
        public string p_proximity_checked { get; set; }
        public string p_proximity_ids { get; set; }
        public string p_proximity_key { get; set; }
        public string p_proximity_description { get; set; }
        public string bi_est_gross_sum { get; set; }
        public string bi_est_gross_period { get; set; }
        public string bi_est_rev_sum { get; set; }
        public string bi_est_rev_period { get; set; }
        public string bi_rent_rec_sum { get; set; }
        public string bi_rent_rec_period { get; set; }
        public string bi_rent_pay_sum { get; set; }
        public string bi_rent_pay_period { get; set; }
        public string bi_cow_sum { get; set; }
        public string bi_cow_period { get; set; }
        public string bi_icow_sum { get; set; }
        public string bi_icow_period { get; set; }
        public string p_emlamount { get; set; }
        public string p_emlpercent { get; set; }
        public string p_prem { get; set; }
        public string p_bi_prem { get; set; }
        public string p_number { get; set; }
    }

    public class SectionAnnualPremium
    {
        public int id { get; set; }
        public string sectionid { get; set; }
        public string ratingbasis { get; set; }
        public string netnetpremium { get; set; }
        public string mgacommission { get; set; }
        public string netpremium { get; set; }
        public string brokercommission { get; set; }
        public string grosspremium { get; set; }
        public string tax { get; set; }
        public string total { get; set; }
        public ICollection<SectionAnnualPremiumRate> rates { get; set; }
    }

    public class SectionAnnualPremiumRate
    {
        public int id { get; set; }
        public string description { get; set; }
        public string sum { get; set; }
        public string DayOne { get; set; }
        public string FireRate { get; set; }
        public string PerilsRate { get; set; }
        public string SprinkRate { get; set; }
        public string ADRate { get; set; }
        public string SubsRate { get; set; }
        public string TotalRate { get; set; }
        public string TechAdjust { get; set; }
        public string CommAdjust { get; set; }
        public string AdjustedRate { get; set; }
        public string Premium { get; set; }
    }

    public class SetData
    {
        public int ID { get; set; }
        public string p_mis_desc { get; set; }
        public string p_mis_sum { get; set; }
        public string p_mis_period { get; set; }
        public string bi_mis_desc { get; set; }
        public string bi_mis_sum { get; set; }
        public string bi_mis_period { get; set; }
    }

    public class Endorsement
    {
        public int id { get; set; }
        public string clause { get; set; }
        public string section { get; set; }
        public string code { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string type { get; set; }
        public bool complete { get; set; }
    }
}
