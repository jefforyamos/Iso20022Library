﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentPlan13.  ISO2002 ID# _yDN21yC6EeWPMvNwVtiMsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
/// </summary>
public partial record InvestmentPlan13
     : IIsoXmlSerilizable<InvestmentPlan13>
{
    #nullable enable
    
    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    public required Frequency20Choice_ Frequency { get; init; } 
    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// Date the investment plan stops.
    /// </summary>
    public IsoISODate? EndDate { get; init; } 
    /// <summary>
    /// Amount of the periodical payments.
    /// </summary>
    public required UnitsOrAmount1Choice_ Quantity { get; init; } 
    /// <summary>
    /// Indicates whether an ordered amount is a gross amount (including all charges, commissions, tax). If it is not a gross amount, the ordered amount is a net amount (amount to be invested or redeemed from the fund to which other elements will be added).
    /// </summary>
    public IsoYesNoIndicator? GrossAmountIndicator { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference2Code? IncomePreference { get; init; } 
    /// <summary>
    /// Initial amount or number of initial instalments.
    /// </summary>
    public InitialAmount1Choice_? InitialAmount { get; init; } 
    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    public IsoNumber? TotalNumberOfInstalments { get; init; } 
    /// <summary>
    /// Indicates the rounding direction when an amount is to be spread over several funds.
    /// </summary>
    public RoundingDirection1Code? RoundingDirection { get; init; } 
    /// <summary>
    /// Security that an investment plan invests in, or from which the investment plan divests.
    /// </summary>
    public ValueList<Repartition4> SecurityDetails { get; init; } = [];
    /// <summary>
    /// Cash settlement standing instruction associated to the investment plan and to be either inserted or deleted.
    /// </summary>
    public ValueList<CashSettlement2> ModifiedCashSettlement { get; init; } = [];
    /// <summary>
    /// Reference of the underlying investment contract. In some markets, such as Italy, this might be required to segregate holdings between the same investment account.
    /// </summary>
    public IsoMax35Text? ContractReference { get; init; } 
    /// <summary>
    /// Reference of the previous contract to which this savings or withdrawal plan is related.
    /// </summary>
    public IsoMax35Text? RelatedContractReference { get; init; } 
    /// <summary>
    /// Identification of the product as designated by the fund manager. In some markets, such as Italy, the financial product or service related to a savings plan or withdrawal plan are identified by a product identification or number.
    /// </summary>
    public IsoMax35Text? ProductIdentification { get; init; } 
    /// <summary>
    /// Reference of the underlying service level agreement (SLA) governing charges and commission.
    /// </summary>
    public IsoMax35Text? SLAChargeAndCommissionReference { get; init; } 
    /// <summary>
    /// Specifies the type of insurance contract to which the savings investment plan is linked.
    /// </summary>
    public InsuranceType2Choice_? InsuranceCover { get; init; } 
    /// <summary>
    /// Status of the savings or withdrawal investment plan.
    /// </summary>
    public PlanStatus2Choice_? PlanStatus { get; init; } 
    /// <summary>
    /// Role or function of the instalment manager.
    /// </summary>
    public PartyRole4Choice_? InstalmentManagerRole { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Frqcy", xmlNamespace );
        Frequency.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (StartDate is IsoISODate StartDateValue)
        {
            writer.WriteStartElement(null, "StartDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(StartDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (EndDate is IsoISODate EndDateValue)
        {
            writer.WriteStartElement(null, "EndDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(EndDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        Quantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (GrossAmountIndicator is IsoYesNoIndicator GrossAmountIndicatorValue)
        {
            writer.WriteStartElement(null, "GrssAmtInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(GrossAmountIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (IncomePreference is IncomePreference2Code IncomePreferenceValue)
        {
            writer.WriteStartElement(null, "IncmPref", xmlNamespace );
            writer.WriteValue(IncomePreferenceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (InitialAmount is InitialAmount1Choice_ InitialAmountValue)
        {
            writer.WriteStartElement(null, "InitlAmt", xmlNamespace );
            InitialAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalNumberOfInstalments is IsoNumber TotalNumberOfInstalmentsValue)
        {
            writer.WriteStartElement(null, "TtlNbOfInstlmts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(TotalNumberOfInstalmentsValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (RoundingDirection is RoundingDirection1Code RoundingDirectionValue)
        {
            writer.WriteStartElement(null, "RndgDrctn", xmlNamespace );
            writer.WriteValue(RoundingDirectionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctyDtls", xmlNamespace );
        SecurityDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ModfdCshSttlm", xmlNamespace );
        ModifiedCashSettlement.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ContractReference is IsoMax35Text ContractReferenceValue)
        {
            writer.WriteStartElement(null, "CtrctRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ContractReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RelatedContractReference is IsoMax35Text RelatedContractReferenceValue)
        {
            writer.WriteStartElement(null, "RltdCtrctRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RelatedContractReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProductIdentification is IsoMax35Text ProductIdentificationValue)
        {
            writer.WriteStartElement(null, "PdctId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProductIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SLAChargeAndCommissionReference is IsoMax35Text SLAChargeAndCommissionReferenceValue)
        {
            writer.WriteStartElement(null, "SLAChrgAndComssnRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SLAChargeAndCommissionReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (InsuranceCover is InsuranceType2Choice_ InsuranceCoverValue)
        {
            writer.WriteStartElement(null, "InsrncCover", xmlNamespace );
            InsuranceCoverValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlanStatus is PlanStatus2Choice_ PlanStatusValue)
        {
            writer.WriteStartElement(null, "PlanSts", xmlNamespace );
            PlanStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstalmentManagerRole is PartyRole4Choice_ InstalmentManagerRoleValue)
        {
            writer.WriteStartElement(null, "InstlmtMgrRole", xmlNamespace );
            InstalmentManagerRoleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InvestmentPlan13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
