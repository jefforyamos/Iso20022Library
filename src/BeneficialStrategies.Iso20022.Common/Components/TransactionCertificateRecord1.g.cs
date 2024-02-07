﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionCertificateRecord1.  ISO2002 ID# _LUhDsNLiEeSdq5yU2aaSNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate record in which all currency control transactions are registered.
/// </summary>
public partial record TransactionCertificateRecord1
     : IIsoXmlSerilizable<TransactionCertificateRecord1>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the certificate record.
    /// </summary>
    public required IsoMax35Text CertificateRecordIdentification { get; init; } 
    /// <summary>
    /// Details of the transaction for which the record has been generated.
    /// </summary>
    public required TransactionCertificate2 Transaction { get; init; } 
    /// <summary>
    /// Contract registration details related to the certificate record.
    /// </summary>
    public TransactionCertificateContract1? Contract { get; init; } 
    /// <summary>
    /// Documents provided as attachments to the registered contract.
    /// </summary>
    public DocumentGeneralInformation3? Attachment { get; init; } 
    
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
        writer.WriteStartElement(null, "CertRcrdId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(CertificateRecordIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Contract is TransactionCertificateContract1 ContractValue)
        {
            writer.WriteStartElement(null, "Ctrct", xmlNamespace );
            ContractValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Attachment is DocumentGeneralInformation3 AttachmentValue)
        {
            writer.WriteStartElement(null, "Attchmnt", xmlNamespace );
            AttachmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionCertificateRecord1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
