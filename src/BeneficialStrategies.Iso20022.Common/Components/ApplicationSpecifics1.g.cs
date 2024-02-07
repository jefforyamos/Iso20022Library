﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ApplicationSpecifics1.  ISO2002 ID# _jLluUe5NEeCisYr99QEiWA_17771453.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Application specific information defined by the service provider.
/// </summary>
public partial record ApplicationSpecifics1
     : IIsoXmlSerilizable<ApplicationSpecifics1>
{
    #nullable enable
    
    /// <summary>
    /// A system user is a user account defined in the static data. It represents an individual or an application that interacts with the system administrator (e. g. T2S), triggering the available functions. The set of functions available to each system user stems from the set of privileges for which the system user is grantee. System administrator does not provide any attribute for distinguishing between individuals and applications. 
    /// </summary>
    public IsoMax140Text? SystemUser { get; init; } 
    /// <summary>
    /// Contains the digital signature of the Business Entity authorised to sign this Business File.
    /// </summary>
    public SignatureEnvelope? Signature { get; init; } 
    /// <summary>
    /// Gives the total number of instances (messages) within the file.
    /// </summary>
    public required IsoNumber TotalNumberOfDocuments { get; init; } 
    
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
        if (SystemUser is IsoMax140Text SystemUserValue)
        {
            writer.WriteStartElement(null, "SysUsr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(SystemUserValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (Signature is SignatureEnvelope SignatureValue)
        {
            writer.WriteStartElement(null, "Sgntr", xmlNamespace );
            SignatureValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TtlNbOfDocs", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNumber(TotalNumberOfDocuments)); // data type Number System.UInt64
        writer.WriteEndElement();
    }
    public static ApplicationSpecifics1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
