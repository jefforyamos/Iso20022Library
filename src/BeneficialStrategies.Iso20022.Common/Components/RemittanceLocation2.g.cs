﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RemittanceLocation2.  ISO2002 ID# _QF_4Udp-Ed-ak6NoX_4Aeg_-1849801133.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the remittance advice.
/// </summary>
public partial record RemittanceLocation2
     : IIsoXmlSerilizable<RemittanceLocation2>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    /// <summary>
    /// Method used to deliver the remittance advice information.
    /// </summary>
    public RemittanceLocationMethod2Code? RemittanceLocationMethod { get; init; } 
    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    public IsoMax2048Text? RemittanceLocationElectronicAddress { get; init; } 
    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    public NameAndAddress10? RemittanceLocationPostalAddress { get; init; } 
    
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
        if (RemittanceIdentification is IsoMax35Text RemittanceIdentificationValue)
        {
            writer.WriteStartElement(null, "RmtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RemittanceIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RemittanceLocationMethod is RemittanceLocationMethod2Code RemittanceLocationMethodValue)
        {
            writer.WriteStartElement(null, "RmtLctnMtd", xmlNamespace );
            writer.WriteValue(RemittanceLocationMethodValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (RemittanceLocationElectronicAddress is IsoMax2048Text RemittanceLocationElectronicAddressValue)
        {
            writer.WriteStartElement(null, "RmtLctnElctrncAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2048Text(RemittanceLocationElectronicAddressValue)); // data type Max2048Text System.String
            writer.WriteEndElement();
        }
        if (RemittanceLocationPostalAddress is NameAndAddress10 RemittanceLocationPostalAddressValue)
        {
            writer.WriteStartElement(null, "RmtLctnPstlAdr", xmlNamespace );
            RemittanceLocationPostalAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RemittanceLocation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
