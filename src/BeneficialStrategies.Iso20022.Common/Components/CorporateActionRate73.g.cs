﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate73.  ISO2002 ID# _cheNB5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates related to a corporate action option.
/// </summary>
public partial record CorporateActionRate73
     : IIsoXmlSerilizable<CorporateActionRate73>
{
    #nullable enable
    
    /// <summary>
    /// Rate proposed in a remarketing of variable rate notes.
    /// </summary>
    public IsoPercentageRate? ProposedRate { get; init; } 
    /// <summary>
    /// Rate of allowed over-subscription.
    /// </summary>
    public RateAndAmountFormat43Choice_? OversubscriptionRate { get; init; } 
    /// <summary>
    /// Requested tax rate that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public RateAndAmountFormat45Choice_? RequestedWithholdingTaxRate { get; init; } 
    /// <summary>
    /// Requested rate at which the income will be withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public RateAndAmountFormat45Choice_? RequestedSecondLevelTaxRate { get; init; } 
    
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
        if (ProposedRate is IsoPercentageRate ProposedRateValue)
        {
            writer.WriteStartElement(null, "PropsdRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(ProposedRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (OversubscriptionRate is RateAndAmountFormat43Choice_ OversubscriptionRateValue)
        {
            writer.WriteStartElement(null, "OvrsbcptRate", xmlNamespace );
            OversubscriptionRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedWithholdingTaxRate is RateAndAmountFormat45Choice_ RequestedWithholdingTaxRateValue)
        {
            writer.WriteStartElement(null, "ReqdWhldgTaxRate", xmlNamespace );
            RequestedWithholdingTaxRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedSecondLevelTaxRate is RateAndAmountFormat45Choice_ RequestedSecondLevelTaxRateValue)
        {
            writer.WriteStartElement(null, "ReqdScndLvlTaxRate", xmlNamespace );
            RequestedSecondLevelTaxRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionRate73 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
