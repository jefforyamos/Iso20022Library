﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalanceInformation5.  ISO2002 ID# _QZqbNNp-Ed-ak6NoX_4Aeg_1800003201.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
public partial record AggregateBalanceInformation5
     : IIsoXmlSerilizable<AggregateBalanceInformation5>
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; } 
    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? HoldingValue { get; init; } 
    /// <summary>
    /// Previous total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? PreviousHoldingValue { get; init; } 
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    /// <summary>
    /// Investment fund class held on the account for which the balance is calculated.
    /// </summary>
    public required FinancialInstrument18 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
    /// </summary>
    public AdditionalBalanceInformation3? BalanceBreakdownDetails { get; init; } 
    /// <summary>
    /// Information relating to a sub balance of the investment fund.
    /// </summary>
    public SubBalanceInformation3? SubBalanceInformation { get; init; } 
    /// <summary>
    /// Price of the financial instrument.
    /// </summary>
    public PriceInformation3? PriceDetails { get; init; } 
    /// <summary>
    /// Part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    public Equalisation2? EqualisationBalance { get; init; } 
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "AggtQty", xmlNamespace );
        AggregateQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (HoldingValue is IsoActiveOrHistoricCurrencyAndAmount HoldingValueValue)
        {
            writer.WriteStartElement(null, "HldgVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(HoldingValueValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (PreviousHoldingValue is IsoActiveOrHistoricCurrencyAndAmount PreviousHoldingValueValue)
        {
            writer.WriteStartElement(null, "PrvsHldgVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(PreviousHoldingValueValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (BookValue is IsoActiveOrHistoricCurrencyAndAmount BookValueValue)
        {
            writer.WriteStartElement(null, "BookVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(BookValueValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (BalanceBreakdownDetails is AdditionalBalanceInformation3 BalanceBreakdownDetailsValue)
        {
            writer.WriteStartElement(null, "BalBrkdwnDtls", xmlNamespace );
            BalanceBreakdownDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubBalanceInformation is SubBalanceInformation3 SubBalanceInformationValue)
        {
            writer.WriteStartElement(null, "SubBalInf", xmlNamespace );
            SubBalanceInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceDetails is PriceInformation3 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EqualisationBalance is Equalisation2 EqualisationBalanceValue)
        {
            writer.WriteStartElement(null, "EqulstnBal", xmlNamespace );
            EqualisationBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ForeignExchangeDetails is ForeignExchangeTerms6 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FrgnXchgDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AggregateBalanceInformation5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
