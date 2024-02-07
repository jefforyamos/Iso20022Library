﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MissingOrIncorrectInformation.  ISO2002 ID# _S_E3FUgoEeaGKYpLDboHPQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification3Choice;

/// <summary>
/// Set of elements used to indicate which information is missing or incorrect.
/// </summary>
public partial record MissingOrIncorrectInformation : UnableToApplyJustification3Choice_
     , IIsoXmlSerilizable<MissingOrIncorrectInformation>
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
    public override void Serialize(XmlWriter writer, string xmlNamespace)
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
    public static new MissingOrIncorrectInformation Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
