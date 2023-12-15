using MaterialDesignThemes.Wpf;
using Science_Solver.AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Science_Solver.ViewModel
{
    public class PhysicalUnitsVM:BaseViewModel
    {
        private string _previousUnit = "";
        private string _selectedValidExchange = "";
        private string _conversedUnit = "";
        private List<string> _listChoiceExchange = PhysicalExchange.ListChoiceExchange;
        public ICommand ExchangeCommand { get; set; }
        public string PreviousUnit 
        { 
            get => _previousUnit;
            set { 
                _previousUnit = value;
                OnPropertyChanged(nameof(PreviousUnit));
            }
            
        }
        public string SelectedValidExchange 
        { 
            get => _selectedValidExchange;
            set { _selectedValidExchange = value;
                OnPropertyChanged(nameof(SelectedValidExchange));
            }
        }
        public string ConversedUnit 
        { 
            get => _conversedUnit;
            set { _conversedUnit = value;
                OnPropertyChanged(nameof(ConversedUnit));
            }
        }
        public List<string> ListChoiceExchange 
        { 
            get => _listChoiceExchange;
            set { _listChoiceExchange = value;
                OnPropertyChanged(nameof(ListChoiceExchange));
            }
        }
        public PhysicalUnitsVM()
        {
            if(PreviousUnit == "")
            {
                PreviousUnit = "100";
                double numPreviousUnit = Double.Parse(PreviousUnit);
                SelectedValidExchange = ListChoiceExchange[0];
            }
            ExchangeCommand = new RelayCommand<Action>(ExecuteExchangeCommand);
        }

        private void ExecuteExchangeCommand(Action action)
        {
            try
            {
                if (SelectedValidExchange == "" || PreviousUnit == "")
                {
                    SelectedValidExchange = ListChoiceExchange.FirstOrDefault();
                    PreviousUnit = "100";
                    double numPreviousUnit = Double.Parse(PreviousUnit);
                }
                else
                {
                    if (SelectedValidExchange == ListChoiceExchange[0])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.inch_exchange_cm(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[1])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.cm_exchange_inch(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[2])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.ft_exchange_meter(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[3])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.meter_exchange_ft(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[4])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.yard_exchange_meter(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[5])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.meter_exchange_yard(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[6])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.mile_exchange_km(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[7])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.km_exchange_mile(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[8])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.n_mile_exchange_meter(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[9])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.meter_exchange_n_mile(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[10])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.acre_exchange_square_meter(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[11])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.square_meter_exchange_acre(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[12])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.gallon_US_exchange_liter(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[13])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.liter_exchange_gallon_US(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[14])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.gallon_UK_exchange_liter(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[15])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.liter_exchange_gallon_UK(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[16])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.pc_exchange_km(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[17])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.km_exchange_pc(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[18])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.kmhour_exchange_metersecond(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[19])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.metersecond_exchange_kmhour(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }

                    if (SelectedValidExchange == ListChoiceExchange[20])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.oz_exchange_gram(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[21])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.gram_exchange_oz(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[22])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.lb_exchange_kilogram(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[23])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.kilogram_exchange_lb(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[24])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.atmosphere_exchange_Pascan(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[25])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Pascan_exchange_atmosphere(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[26])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Millimetre_of_mercury_exchange_Pascan(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[27])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Pascan_exchange_Millimetre_of_mercury(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[28])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.hp_exchange_KW(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[29])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.KW_exchange_hp(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[30])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.kilogramF_CetimeterSquare_exchange_Pascan(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[31])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Pascan_exchange_kilogramF_CetimeterSquare(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[32])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.KilogramF_Meter_exchange_Jun(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[33])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Jun_exchange_KilogramF_Meter(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[34])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.lbf_inch_square_exchange_kPa(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[35])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.kPa_exchange_square_lbf_inch_square(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[36])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Kelvin_exchange_Celsius(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[37])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Celsius_exchange_Kelvin(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[38])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Celsius_exchange_fahrenheit(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[39])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.fahrenheit_exchange_Celsius(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[40])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.fahrenheit_exchange_Kelvin(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[41])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Kelvin_exchange_fahrenheit(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[42])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Jun_exchange_Calo(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[43])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Calo_exchange_Jun(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[44])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Radian_to_C(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[45])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.C_to_Radian(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[46])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.tons_to_kg(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[47])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.kg_to_tons(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[48])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.neutralmiles_to_meter(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[49])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.meter_to_neutralmiles(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[50])
                    {
                        long numPreviousUnit = long.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.seconds_to_timeOfCasesium(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[51])
                    {
                        long numPreviousUnit = long.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.timeOfCasesium_to_second(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[52])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Ae_to_kilometer(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[53])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.kilometer_to_Ae(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[54])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.meter_to_Amstrong(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[55])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Amstrong_to_meter(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[56])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.yearLight_to_km(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[57])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Kg_to_Slug(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[58])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Slug_to_kg(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[59])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.Curie_to_GBq(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                    if (SelectedValidExchange == ListChoiceExchange[60])
                    {
                        double numPreviousUnit = Double.Parse(PreviousUnit);
                        double numConversedUnit = PhysicalExchange.GBq_to_Curie(numPreviousUnit);
                        ConversedUnit = numConversedUnit.ToString();
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
