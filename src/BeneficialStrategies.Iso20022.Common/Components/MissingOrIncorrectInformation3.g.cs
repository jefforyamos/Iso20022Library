﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MissingOrIncorrectInformation3.  ISO2002 ID# _d3zpQUgqEeaGKYpLDboHPQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further information on the reason for the unable to apply investigation.
/// </summary>
public partial record MissingOrIncorrectInformation3
     : IIsoXmlSerilizable<MissingOrIncorrectInformation3>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the request is related to an AML (Anti Money Laundering) investigation or not.
    /// </summary>
    public IsoAMLIndicator? AntiMoneyLaunderingRequest { get; init; } 
    /// <summary>
    /// Indicates the missing information.
    /// </summary>
    public ValueList<UnableToApplyMissing1> MissingInformation { get; init; } = [];
    /// <summary>
    /// Indicates, in a coded form, the incorrect information.
    /// </summary>
    public ValueList<UnableToApplyIncorrect1> IncorrectInformation { get; init; } = [];
    
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
        if (AntiMoneyLaunderingRequest is IsoAMLIndicator AntiMoneyLaunderingRequestValue)
        {
            writer.WriteStartElement(null, "AMLReq", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoAMLIndicator(AntiMoneyLaunderingRequestValue)); // data type AMLIndicator System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MssngInf", xmlNamespace );
        MissingInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IncrrctInf", xmlNamespace );
        IncorrectInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static MissingOrIncorrectInformation3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
