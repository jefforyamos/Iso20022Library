﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UndertakingAmendmentResponseMessage1.  ISO2002 ID# _98n283ltEeG7BsjMvd1mEw_1014525589.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contents of an UndertakingAmendmentResponse message.
/// </summary>
public partial record UndertakingAmendmentResponseMessage1
     : IIsoXmlSerilizable<UndertakingAmendmentResponseMessage1>
{
    #nullable enable
    
    /// <summary>
    /// Details of the proposed amendment response.
    /// </summary>
    public required Amendment7 UndertakingAmendmentResponseDetails { get; init; } 
    /// <summary>
    /// Digital signature of the response.
    /// </summary>
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
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
        writer.WriteStartElement(null, "UdrtkgAmdmntRspnDtls", xmlNamespace );
        UndertakingAmendmentResponseDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DigitalSignature is PartyAndSignature2 DigitalSignatureValue)
        {
            writer.WriteStartElement(null, "DgtlSgntr", xmlNamespace );
            DigitalSignatureValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static UndertakingAmendmentResponseMessage1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
