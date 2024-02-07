﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate78.  ISO2002 ID# _c5SQE5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates of a corporate action.
/// </summary>
public partial record CorporateActionRate78
     : IIsoXmlSerilizable<CorporateActionRate78>
{
    #nullable enable
    
    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    public RateAndAmountFormat46Choice_? Interest { get; init; } 
    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event.
    /// </summary>
    public RateFormat7Choice_? PercentageSought { get; init; } 
    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    public RateFormat3Choice_? RelatedIndex { get; init; } 
    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    public RateFormat3Choice_? Spread { get; init; } 
    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    public RateAndAmountFormat50Choice_? BidInterval { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    public RateFormat12Choice_? PreviousFactor { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    public RateFormat12Choice_? NextFactor { get; init; } 
    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    public RateFormat3Choice_? ReinvestmentDiscountRateToMarket { get; init; } 
    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the interest payment and the expected or scheduled rate of the interest payment.
    /// </summary>
    public RateAndAmountFormat43Choice_? InterestShortfall { get; init; } 
    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the capital or principal repayment and the scheduled capital repayment.
    /// </summary>
    public RateAndAmountFormat43Choice_? RealisedLoss { get; init; } 
    /// <summary>
    /// Dividend or interest rate declared by the issuer.
    /// </summary>
    public RateAndAmountFormat43Choice_? DeclaredRate { get; init; } 
    
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
        if (Interest is RateAndAmountFormat46Choice_ InterestValue)
        {
            writer.WriteStartElement(null, "Intrst", xmlNamespace );
            InterestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PercentageSought is RateFormat7Choice_ PercentageSoughtValue)
        {
            writer.WriteStartElement(null, "PctgSght", xmlNamespace );
            PercentageSoughtValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RelatedIndex is RateFormat3Choice_ RelatedIndexValue)
        {
            writer.WriteStartElement(null, "RltdIndx", xmlNamespace );
            RelatedIndexValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Spread is RateFormat3Choice_ SpreadValue)
        {
            writer.WriteStartElement(null, "Sprd", xmlNamespace );
            SpreadValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BidInterval is RateAndAmountFormat50Choice_ BidIntervalValue)
        {
            writer.WriteStartElement(null, "BidIntrvl", xmlNamespace );
            BidIntervalValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousFactor is RateFormat12Choice_ PreviousFactorValue)
        {
            writer.WriteStartElement(null, "PrvsFctr", xmlNamespace );
            PreviousFactorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NextFactor is RateFormat12Choice_ NextFactorValue)
        {
            writer.WriteStartElement(null, "NxtFctr", xmlNamespace );
            NextFactorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReinvestmentDiscountRateToMarket is RateFormat3Choice_ ReinvestmentDiscountRateToMarketValue)
        {
            writer.WriteStartElement(null, "RinvstmtDscntRateToMkt", xmlNamespace );
            ReinvestmentDiscountRateToMarketValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InterestShortfall is RateAndAmountFormat43Choice_ InterestShortfallValue)
        {
            writer.WriteStartElement(null, "IntrstShrtfll", xmlNamespace );
            InterestShortfallValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RealisedLoss is RateAndAmountFormat43Choice_ RealisedLossValue)
        {
            writer.WriteStartElement(null, "RealsdLoss", xmlNamespace );
            RealisedLossValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeclaredRate is RateAndAmountFormat43Choice_ DeclaredRateValue)
        {
            writer.WriteStartElement(null, "DclrdRate", xmlNamespace );
            DeclaredRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionRate78 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
