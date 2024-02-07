﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate17.  ISO2002 ID# _l5a7ceGcEd-1Ktb5rVaajw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security rate details.
/// </summary>
public partial record CorporateActionRate17
     : IIsoXmlSerilizable<CorporateActionRate17>
{
    #nullable enable
    
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    public RatioFormat11Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    public RatioFormat11Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    public RatioFormat12Choice_? NewToOld { get; init; } 
    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions that are the result of a transformation of the parent transaction.
    /// </summary>
    public IsoPercentageRate? TransformationRate { get; init; } 
    
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
        if (AdditionalQuantityForSubscribedResultantSecurities is RatioFormat11Choice_ AdditionalQuantityForSubscribedResultantSecuritiesValue)
        {
            writer.WriteStartElement(null, "AddtlQtyForSbcbdRsltntScties", xmlNamespace );
            AdditionalQuantityForSubscribedResultantSecuritiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalQuantityForExistingSecurities is RatioFormat11Choice_ AdditionalQuantityForExistingSecuritiesValue)
        {
            writer.WriteStartElement(null, "AddtlQtyForExstgScties", xmlNamespace );
            AdditionalQuantityForExistingSecuritiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewToOld is RatioFormat12Choice_ NewToOldValue)
        {
            writer.WriteStartElement(null, "NewToOd", xmlNamespace );
            NewToOldValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransformationRate is IsoPercentageRate TransformationRateValue)
        {
            writer.WriteStartElement(null, "TrfrmatnRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(TransformationRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
    }
    public static CorporateActionRate17 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
