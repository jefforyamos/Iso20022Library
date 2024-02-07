﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateLock1.  ISO2002 ID# _vL6cgIZ7EeuSbct6WWD-Ng.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicators about rate lock.
/// </summary>
public partial record RateLock1
     : IIsoXmlSerilizable<RateLock1>
{
    #nullable enable
    
    /// <summary>
    /// Indicates if a rate lock is or was requested.
    /// </summary>
    public IsoTrueFalseIndicator? RequestedIndicator { get; init; } 
    /// <summary>
    /// Indicates if the transaction is rate lock eligible.
    /// </summary>
    public IsoTrueFalseIndicator? EligibleIndicator { get; init; } 
    /// <summary>
    /// Indicates if a rate lock was applied.
    /// </summary>
    public IsoTrueFalseIndicator? AppliedIndicator { get; init; } 
    
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
        if (RequestedIndicator is IsoTrueFalseIndicator RequestedIndicatorValue)
        {
            writer.WriteStartElement(null, "ReqdInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(RequestedIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (EligibleIndicator is IsoTrueFalseIndicator EligibleIndicatorValue)
        {
            writer.WriteStartElement(null, "ElgblInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(EligibleIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (AppliedIndicator is IsoTrueFalseIndicator AppliedIndicatorValue)
        {
            writer.WriteStartElement(null, "ApldInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(AppliedIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static RateLock1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
