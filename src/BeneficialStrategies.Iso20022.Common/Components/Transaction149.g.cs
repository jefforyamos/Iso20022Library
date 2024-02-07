﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction149.  ISO2002 ID# _19BGYYdLEeuBS50MFjViNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
public partial record Transaction149
     : IIsoXmlSerilizable<Transaction149>
{
    #nullable enable
    
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    public IsoMax70Text? AssociatedDataReference { get; init; } 
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification20 TransactionIdentification { get; init; } 
    /// <summary>
    /// Contains additional fees for the addendum response message.
    /// </summary>
    public AdditionalFee2? AdditionalFee { get; init; } 
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    public IsoMax1000Text? TransactionDescription { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init; } 
    
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
        if (AssociatedDataReference is IsoMax70Text AssociatedDataReferenceValue)
        {
            writer.WriteStartElement(null, "AssoctdDataRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AssociatedDataReferenceValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalFee is AdditionalFee2 AdditionalFeeValue)
        {
            writer.WriteStartElement(null, "AddtlFee", xmlNamespace );
            AdditionalFeeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionDescription is IsoMax1000Text TransactionDescriptionValue)
        {
            writer.WriteStartElement(null, "TxDesc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax1000Text(TransactionDescriptionValue)); // data type Max1000Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalData is AdditionalData1 AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            AdditionalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Transaction149 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
