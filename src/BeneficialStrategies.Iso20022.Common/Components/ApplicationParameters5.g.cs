﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ApplicationParameters5.  ISO2002 ID# _AWZaEY3_EeWRwov1g9WL_A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to a payment application of the point of interaction.
/// </summary>
public partial record ApplicationParameters5
     : IIsoXmlSerilizable<ApplicationParameters5>
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    public required IsoMax35Text ApplicationIdentification { get; init; } 
    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    public required IsoMax256Text Version { get; init; } 
    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    public IsoMax100KBinary? Parameters { get; init; } 
    /// <summary>
    /// Sensitive parameters (sequence of parameters including the envelope) encrypted with a cryptographic key.
    /// </summary>
    public ContentInformationType10? EncryptedParameters { get; init; } 
    
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
        writer.WriteStartElement(null, "ActnTp", xmlNamespace );
        writer.WriteValue(ActionType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ApplId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(ApplicationIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Vrsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax256Text(Version)); // data type Max256Text System.String
        writer.WriteEndElement();
        if (Parameters is IsoMax100KBinary ParametersValue)
        {
            writer.WriteStartElement(null, "Params", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax100KBinary(ParametersValue)); // data type Max100KBinary System.Byte[]
            writer.WriteEndElement();
        }
        if (EncryptedParameters is ContentInformationType10 EncryptedParametersValue)
        {
            writer.WriteStartElement(null, "NcrptdParams", xmlNamespace );
            EncryptedParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ApplicationParameters5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
