﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ResponseType5.  ISO2002 ID# _jrKT0Y0xEeW1W6lLicSC4w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response of a requested service.
/// </summary>
public partial record ResponseType5
     : IIsoXmlSerilizable<ResponseType5>
{
    #nullable enable
    
    /// <summary>
    /// Result of the transaction.
    /// </summary>
    public required Response4Code Response { get; init; } 
    /// <summary>
    /// Detailed result of the transaction.
    /// </summary>
    public IsoMax35Text? ResponseReason { get; init; } 
    /// <summary>
    /// Additional information on the response for further examination.
    /// </summary>
    public IsoMax140Text? AdditionalResponseInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Rspn", xmlNamespace );
        writer.WriteValue(Response.ToString()); // Enum value
        writer.WriteEndElement();
        if (ResponseReason is IsoMax35Text ResponseReasonValue)
        {
            writer.WriteStartElement(null, "RspnRsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ResponseReasonValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalResponseInformation is IsoMax140Text AdditionalResponseInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRspnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(AdditionalResponseInformationValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static ResponseType5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
