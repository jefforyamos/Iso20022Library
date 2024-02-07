﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalancePerSafekeepingPlace34.  ISO2002 ID# _sx-1hdLFEeiN28wlpBQScw.
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
public partial record AggregateBalancePerSafekeepingPlace34
     : IIsoXmlSerilizable<AggregateBalancePerSafekeepingPlace34>
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public required SafeKeepingPlace3 SafekeepingPlace { get; init; } 
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 
    /// <summary>
    /// Choice between formats for the entity to which the financial instruments are pledged.
    /// </summary>
    public Pledgee3? Pledgee { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    public required Balance6 AggregateBalance { get; init; } 
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    public PriceInformation20? PriceDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _tJL0IdLFEeiN28wlpBQScw
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms34? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoNumber? DaysAccrued { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    public required BalanceAmounts1 AccountBaseCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    public BalanceAmounts1? InstrumentCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts provided in a currency other than the base currency of the account.
    /// </summary>
    public BalanceAmounts1? AlternateReportingCurrencyAmounts { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    public QuantityBreakdown53? QuantityBreakdown { get; init; } 
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    public ExposureType16Choice_? ExposureType { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    public SubBalanceInformation14? BalanceBreakdown { get; init; } 
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    public AdditionalBalanceInformation14? AdditionalBalanceBreakdown { get; init; } 
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
        if (PlaceOfListing is MarketIdentification3Choice_ PlaceOfListingValue)
        {
            writer.WriteStartElement(null, "PlcOfListg", xmlNamespace );
            PlaceOfListingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Pledgee is Pledgee3 PledgeeValue)
        {
            writer.WriteStartElement(null, "Pldgee", xmlNamespace );
            PledgeeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AggtBal", xmlNamespace );
        AggregateBalance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize PriceDetails, multiplicity Unknown
        if (ForeignExchangeDetails is ForeignExchangeTerms34 ForeignExchangeDetailsValue)
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
        writer.WriteStartElement(null, "AcctBaseCcyAmts", xmlNamespace );
        AccountBaseCurrencyAmounts.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (InstrumentCurrencyAmounts is BalanceAmounts1 InstrumentCurrencyAmountsValue)
        {
            writer.WriteStartElement(null, "InstrmCcyAmts", xmlNamespace );
            InstrumentCurrencyAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AlternateReportingCurrencyAmounts is BalanceAmounts1 AlternateReportingCurrencyAmountsValue)
        {
            writer.WriteStartElement(null, "AltrnRptgCcyAmts", xmlNamespace );
            AlternateReportingCurrencyAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QuantityBreakdown is QuantityBreakdown53 QuantityBreakdownValue)
        {
            writer.WriteStartElement(null, "QtyBrkdwn", xmlNamespace );
            QuantityBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExposureType is ExposureType16Choice_ ExposureTypeValue)
        {
            writer.WriteStartElement(null, "XpsrTp", xmlNamespace );
            ExposureTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceBreakdown is SubBalanceInformation14 BalanceBreakdownValue)
        {
            writer.WriteStartElement(null, "BalBrkdwn", xmlNamespace );
            BalanceBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalBalanceBreakdown is AdditionalBalanceInformation14 AdditionalBalanceBreakdownValue)
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
    public static AggregateBalancePerSafekeepingPlace34 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
