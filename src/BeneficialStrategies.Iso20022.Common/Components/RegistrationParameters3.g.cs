﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegistrationParameters3.  ISO2002 ID# _A0iQwNokEeC60axPepSq7g_-1847599416.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to registration of securities.
/// </summary>
public partial record RegistrationParameters3
     : IIsoXmlSerilizable<RegistrationParameters3>
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a deposit.
    /// </summary>
    public IsoMax35Text? CertificationIdentification { get; init; } 
    /// <summary>
    /// Date/time at which the certificates in the deposit were validated by the agent.
    /// </summary>
    public DateAndDateTime1Choice_? CertificationDateTime { get; init; } 
    /// <summary>
    /// Account at the registrar where financial instruments are registered.
    /// </summary>
    public IsoMax35Text? RegistrarAccount { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    public SecuritiesCertificate3? CertificateNumber { get; init; } 
    
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
        if (CertificationIdentification is IsoMax35Text CertificationIdentificationValue)
        {
            writer.WriteStartElement(null, "CertfctnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CertificationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CertificationDateTime is DateAndDateTime1Choice_ CertificationDateTimeValue)
        {
            writer.WriteStartElement(null, "CertfctnDtTm", xmlNamespace );
            CertificationDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegistrarAccount is IsoMax35Text RegistrarAccountValue)
        {
            writer.WriteStartElement(null, "RegarAcct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RegistrarAccountValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CertificateNumber is SecuritiesCertificate3 CertificateNumberValue)
        {
            writer.WriteStartElement(null, "CertNb", xmlNamespace );
            CertificateNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RegistrationParameters3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
