﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionReferences4.  ISO2002 ID# _PgZ3gaFrEeKHbozT2UhHKA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying transaction.
/// </summary>
public partial record TransactionReferences4
     : IIsoXmlSerilizable<TransactionReferences4>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    public IsoMax35Text? PaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.||Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    public IsoMax35Text? InstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.||Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.||Usage: In case there are technical limitations to pass on multiple references, the end-to-end identification must be passed on throughout the entire end-to-end chain.
    /// </summary>
    public required IsoMax35Text EndToEndIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain. 
    /// Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. 
    /// Usage: The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.
    /// </summary>
    public IsoMax35Text? TransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    public IsoMax35Text? MandateIdentification { get; init; } 
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    public PartyIdentification43? CreditorSchemeIdentification { get; init; } 
    
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
        if (PaymentInformationIdentification is IsoMax35Text PaymentInformationIdentificationValue)
        {
            writer.WriteStartElement(null, "PmtInfId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PaymentInformationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (InstructionIdentification is IsoMax35Text InstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "InstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(InstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "EndToEndId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(EndToEndIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (TransactionIdentification is IsoMax35Text TransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MandateIdentification is IsoMax35Text MandateIdentificationValue)
        {
            writer.WriteStartElement(null, "MndtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MandateIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CreditorSchemeIdentification is PartyIdentification43 CreditorSchemeIdentificationValue)
        {
            writer.WriteStartElement(null, "CdtrSchmeId", xmlNamespace );
            CreditorSchemeIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionReferences4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
