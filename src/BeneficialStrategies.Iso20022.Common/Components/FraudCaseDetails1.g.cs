﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FraudCaseDetails1.  ISO2002 ID# _08BmYcZdEeiCDcGzDHI_9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of fraudulent case.
/// </summary>
public partial record FraudCaseDetails1
     : IIsoXmlSerilizable<FraudCaseDetails1>
{
    #nullable enable
    
    /// <summary>
    /// Type of market segment of confirmed fraud.
    /// </summary>
    public IsoMax35Text? MarketSegment { get; init; } 
    /// <summary>
    /// Locator reference.
    /// </summary>
    public IsoMax35Text? LocatorNumber { get; init; } 
    /// <summary>
    /// Reference to fraudulent case.
    /// </summary>
    public IsoMax35Text? CaseReference { get; init; } 
    /// <summary>
    /// Indicates whether the party that committed fraud was arrested or not.
    /// False: the party was not arrested
    /// True: the party was arrested
    /// Default: False
    /// </summary>
    public IsoTrueFalseIndicator? ArrestIndicator { get; init; } 
    
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
        if (MarketSegment is IsoMax35Text MarketSegmentValue)
        {
            writer.WriteStartElement(null, "MktSgmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MarketSegmentValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (LocatorNumber is IsoMax35Text LocatorNumberValue)
        {
            writer.WriteStartElement(null, "LctrNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(LocatorNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CaseReference is IsoMax35Text CaseReferenceValue)
        {
            writer.WriteStartElement(null, "CaseRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CaseReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ArrestIndicator is IsoTrueFalseIndicator ArrestIndicatorValue)
        {
            writer.WriteStartElement(null, "ArrstInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ArrestIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static FraudCaseDetails1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
