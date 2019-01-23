using System;

namespace play_with_simple_linq_queries
{
    public enum Zone
    {
        Costal,
        Bengaluru,
        North,
        Mysuru,
        Other
    }

    public enum Department
    {
        AppliedMechanicsandHydraulics,
        ChemicalEngineering,
        Chemistry,
        CivilEngineering,
        ComputerScienceandEngineering,
        ElectricalandElectronicsEngineering,
        ElectronicsAndCommunicationEngineering,
        InformationTechnology,
        MathematicalandComputationalSciences,
        MechanicalEngineering,
        MetallurgicalandMaterialsEngineering,
        MiningEngineering,
        Physics,
        PlacementandTraining,
        SchoolofManagement,
        CareerDevelopmentCentre,
        CentreforSystemDesign,
        TechnicalEducationQualityImprovementProgramme
    }
    public enum StateQuota
    {
        HomeState,
        OtherState
    }
    public class Student
    {
        public string RollNumber { get; set; }
        public string Name { get; set; }
        public Zone Zone { get; set; }
        public float CGPA { get; set; }
        public Department Department { get; set; }
        public StateQuota StateQuota { get; set; }
    }
}