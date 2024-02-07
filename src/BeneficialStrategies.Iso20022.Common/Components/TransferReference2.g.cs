﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferReference2.  ISO2002 ID# _SwKYhdp-Ed-ak6NoX_4Aeg_-1697995766.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of a transfer and of a transfer confirmation.
/// </summary>
public partial record TransferReference2
     : IIsoXmlSerilizable<TransferReference2>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
    /// </summary>
    public IsoMax35Text? TransferConfirmationReference { get; init; } 
    
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
        if (MasterReference is IsoMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MasterReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransferReference is IsoMax35Text TransferReferenceValue)
        {
            writer.WriteStartElement(null, "TrfRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransferReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClientReference is IsoMax35Text ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransferConfirmationReference is IsoMax35Text TransferConfirmationReferenceValue)
        {
            writer.WriteStartElement(null, "TrfConfRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransferConfirmationReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static TransferReference2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
