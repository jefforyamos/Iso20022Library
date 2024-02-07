﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributes17.  ISO2002 ID# _0Zq7QeEMEd-qUMZtd_eZuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the financial instrument.
/// </summary>
public partial record FinancialInstrumentAttributes17
     : IIsoXmlSerilizable<FinancialInstrumentAttributes17>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public required SecurityIdentification14 SecurityIdentification { get; init; } 
    /// <summary>
    /// Quantity of entitled intermediate securities based on the balance of underlying securities.
    /// </summary>
    public IsoDecimalNumber? Quantity { get; init; } 
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    public RenounceableEntitlementStatusTypeFormat1Choice_? RenounceableEntitlementStatusType { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public FractionDispositionType9Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Quantity of intermediate securities awarded for a given quantity of underlying security.
    /// </summary>
    public QuantityToQuantityRatio1? IntermediateSecuritiesToUnderlyingRatio { get; init; } 
    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    public AmountPrice2? MarketPrice { get; init; } 
    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    public required DateFormat16Choice_ ExpiryDate { get; init; } 
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    public required DateFormat16Choice_ PostingDate { get; init; } 
    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    public Period4? TradingPeriod { get; init; } 
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    public BalanceFormat1Choice_? UninstructedBalance { get; init; } 
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    public BalanceFormat1Choice_? InstructedBalance { get; init; } 
    
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
        writer.WriteStartElement(null, "SctyId", xmlNamespace );
        SecurityIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Quantity is IsoDecimalNumber QuantityValue)
        {
            writer.WriteStartElement(null, "Qty", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(QuantityValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (RenounceableEntitlementStatusType is RenounceableEntitlementStatusTypeFormat1Choice_ RenounceableEntitlementStatusTypeValue)
        {
            writer.WriteStartElement(null, "RnncblEntitlmntStsTp", xmlNamespace );
            RenounceableEntitlementStatusTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FractionDisposition is FractionDispositionType9Choice_ FractionDispositionValue)
        {
            writer.WriteStartElement(null, "FrctnDspstn", xmlNamespace );
            FractionDispositionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediateSecuritiesToUnderlyingRatio is QuantityToQuantityRatio1 IntermediateSecuritiesToUnderlyingRatioValue)
        {
            writer.WriteStartElement(null, "IntrmdtSctiesToUndrlygRatio", xmlNamespace );
            IntermediateSecuritiesToUnderlyingRatioValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketPrice is AmountPrice2 MarketPriceValue)
        {
            writer.WriteStartElement(null, "MktPric", xmlNamespace );
            MarketPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "XpryDt", xmlNamespace );
        ExpiryDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PstngDt", xmlNamespace );
        PostingDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TradingPeriod is Period4 TradingPeriodValue)
        {
            writer.WriteStartElement(null, "TradgPrd", xmlNamespace );
            TradingPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UninstructedBalance is BalanceFormat1Choice_ UninstructedBalanceValue)
        {
            writer.WriteStartElement(null, "UinstdBal", xmlNamespace );
            UninstructedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructedBalance is BalanceFormat1Choice_ InstructedBalanceValue)
        {
            writer.WriteStartElement(null, "InstdBal", xmlNamespace );
            InstructedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrumentAttributes17 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
