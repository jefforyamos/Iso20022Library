﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction158.  ISO2002 ID# _DabH0YgqEeu8-LhY4KPfWg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of transaction for a file action.
/// </summary>
public partial record Transaction158
     : IIsoXmlSerilizable<Transaction158>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    public AdditionalFee2? AdditionalFee { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init; } 
    /// <summary>
    /// Details pertaining to the file action.
    /// </summary>
    public required FileActionDetails2 FileActionDetails { get; init; } 
    
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
        if (TransactionIdentification is TransactionIdentification12 TransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TxId", xmlNamespace );
            TransactionIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalFee is AdditionalFee2 AdditionalFeeValue)
        {
            writer.WriteStartElement(null, "AddtlFee", xmlNamespace );
            AdditionalFeeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalData is AdditionalData1 AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            AdditionalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FileActnDtls", xmlNamespace );
        FileActionDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static Transaction158 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
