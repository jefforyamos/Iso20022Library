﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SwitchRedemptionLegOrder6.  ISO2002 ID# _4kpxMzbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Redemption leg, or switch-out, of a switch transaction.
/// </summary>
public partial record SwitchRedemptionLegOrder6
     : IIsoXmlSerilizable<SwitchRedemptionLegOrder6>
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for the instance of the leg within a switch.
    /// </summary>
    public IsoMax35Text? LegIdentification { get; init; } 
    /// <summary>
    /// Investment fund class related to the redemption leg of the order.
    /// </summary>
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Amount of money, number of units or percentage for the subscription leg of the switch order.
    /// </summary>
    public FinancialInstrumentQuantity29Choice_? FinancialInstrumentQuantityChoice { get; init; } 
    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Fees (charges/commission) and tax to be applied to the gross amount.
    /// </summary>
    public FeeAndTax1? TransactionOverhead { get; init; } 
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    public FundSettlementParameters12? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Part of an investor's retained subscription amount that is returned by the fund in order to reimburse preliminary incentive/performance fees.
    /// </summary>
    public Equalisation1? Equalisation { get; init; } 
    
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
        if (LegIdentification is IsoMax35Text LegIdentificationValue)
        {
            writer.WriteStartElement(null, "LegId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(LegIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FinancialInstrumentQuantityChoice is FinancialInstrumentQuantity29Choice_ FinancialInstrumentQuantityChoiceValue)
        {
            writer.WriteStartElement(null, "FinInstrmQtyChc", xmlNamespace );
            FinancialInstrumentQuantityChoiceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestmentAccountDetails is InvestmentAccount58 InvestmentAccountDetailsValue)
        {
            writer.WriteStartElement(null, "InvstmtAcctDtls", xmlNamespace );
            InvestmentAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IncomePreference is IncomePreference1Code IncomePreferenceValue)
        {
            writer.WriteStartElement(null, "IncmPref", xmlNamespace );
            writer.WriteValue(IncomePreferenceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Group1Or2Units is UKTaxGroupUnit1Code Group1Or2UnitsValue)
        {
            writer.WriteStartElement(null, "Grp1Or2Units", xmlNamespace );
            writer.WriteValue(Group1Or2UnitsValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (RequestedSettlementCurrency is ActiveCurrencyCode RequestedSettlementCurrencyValue)
        {
            writer.WriteStartElement(null, "ReqdSttlmCcy", xmlNamespace );
            writer.WriteValue(RequestedSettlementCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (RequestedNAVCurrency is ActiveOrHistoricCurrencyCode RequestedNAVCurrencyValue)
        {
            writer.WriteStartElement(null, "ReqdNAVCcy", xmlNamespace );
            writer.WriteValue(RequestedNAVCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TransactionOverhead is FeeAndTax1 TransactionOverheadValue)
        {
            writer.WriteStartElement(null, "TxOvrhd", xmlNamespace );
            TransactionOverheadValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementAndCustodyDetails is FundSettlementParameters12 SettlementAndCustodyDetailsValue)
        {
            writer.WriteStartElement(null, "SttlmAndCtdyDtls", xmlNamespace );
            SettlementAndCustodyDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PhysDlvryInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PhysicalDeliveryIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (PhysicalDeliveryDetails is DeliveryParameters3 PhysicalDeliveryDetailsValue)
        {
            writer.WriteStartElement(null, "PhysDlvryDtls", xmlNamespace );
            PhysicalDeliveryDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NonStandardSettlementInformation is IsoMax350Text NonStandardSettlementInformationValue)
        {
            writer.WriteStartElement(null, "NonStdSttlmInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NonStandardSettlementInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (Equalisation is Equalisation1 EqualisationValue)
        {
            writer.WriteStartElement(null, "Equlstn", xmlNamespace );
            EqualisationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SwitchRedemptionLegOrder6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
