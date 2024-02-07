﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalancePerSafekeepingPlace11.  ISO2002 ID# _K14CmeaOEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
/// </summary>
public partial record AggregateBalancePerSafekeepingPlace11
     : IIsoXmlSerilizable<AggregateBalancePerSafekeepingPlace11>
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public required SafekeepingPlaceFormat3Choice_ SafekeepingPlace { get; init; } 
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    public MarketIdentification5? PlaceOfListing { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    public required Balance1 AggregateBalance { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    public BalanceQuantity5Choice_? AvailableBalance { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    public BalanceQuantity5Choice_? NotAvailableBalance { get; init; } 
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    public PriceInformation5? PriceDetails { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms14? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoNumber? DaysAccrued { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    public QuantityBreakdown3? QuantityBreakdown { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    public SubBalanceInformation5? BalanceBreakdown { get; init; } 
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    public AdditionalBalanceInformation5? AdditionalBalanceBreakdown { get; init; } 
    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    public IsoMax350Text? HoldingAdditionalDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
        SafekeepingPlace.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PlaceOfListing is MarketIdentification5 PlaceOfListingValue)
        {
            writer.WriteStartElement(null, "PlcOfListg", xmlNamespace );
            PlaceOfListingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AggtBal", xmlNamespace );
        AggregateBalance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AvailableBalance is BalanceQuantity5Choice_ AvailableBalanceValue)
        {
            writer.WriteStartElement(null, "AvlblBal", xmlNamespace );
            AvailableBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NotAvailableBalance is BalanceQuantity5Choice_ NotAvailableBalanceValue)
        {
            writer.WriteStartElement(null, "NotAvlblBal", xmlNamespace );
            NotAvailableBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceDetails is PriceInformation5 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ForeignExchangeDetails is ForeignExchangeTerms14 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DaysAccrued is IsoNumber DaysAccruedValue)
        {
            writer.WriteStartElement(null, "DaysAcrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(DaysAccruedValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (AccountBaseCurrencyAmounts is BalanceAmounts3 AccountBaseCurrencyAmountsValue)
        {
            writer.WriteStartElement(null, "AcctBaseCcyAmts", xmlNamespace );
            AccountBaseCurrencyAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstrumentCurrencyAmounts is BalanceAmounts3 InstrumentCurrencyAmountsValue)
        {
            writer.WriteStartElement(null, "InstrmCcyAmts", xmlNamespace );
            InstrumentCurrencyAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QuantityBreakdown is QuantityBreakdown3 QuantityBreakdownValue)
        {
            writer.WriteStartElement(null, "QtyBrkdwn", xmlNamespace );
            QuantityBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceBreakdown is SubBalanceInformation5 BalanceBreakdownValue)
        {
            writer.WriteStartElement(null, "BalBrkdwn", xmlNamespace );
            BalanceBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalBalanceBreakdown is AdditionalBalanceInformation5 AdditionalBalanceBreakdownValue)
        {
            writer.WriteStartElement(null, "AddtlBalBrkdwn", xmlNamespace );
            AdditionalBalanceBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (HoldingAdditionalDetails is IsoMax350Text HoldingAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "HldgAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(HoldingAdditionalDetailsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static AggregateBalancePerSafekeepingPlace11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
