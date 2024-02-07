﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Correction.  ISO2002 ID# _38nfXf_qEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport10Choice;

/// <summary>
/// Indicates a modification to the terms or details of a previously reported position or correction the erroneous data fields of a previously submitted position.
/// </summary>
public partial record Correction : TradeReport10Choice_
     , IIsoXmlSerilizable<Correction>
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    public required CounterpartyData76 CounterpartyData { get; init; } 
    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    public TransactionLoanData20Choice_? LoanData { get; init; } 
    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    public TransactionCollateralData14Choice_? CollateralData { get; init; } 
    /// <summary>
    /// Information concerning the reported transaction level type.
    /// </summary>
    public required ModificationLevel1Code LevelType { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (TechnicalRecordIdentification is IsoMax140Text TechnicalRecordIdentificationValue)
        {
            writer.WriteStartElement(null, "TechRcrdId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(TechnicalRecordIdentificationValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CtrPtyData", xmlNamespace );
        CounterpartyData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LoanData is TransactionLoanData20Choice_ LoanDataValue)
        {
            writer.WriteStartElement(null, "LnData", xmlNamespace );
            LoanDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CollateralData is TransactionCollateralData14Choice_ CollateralDataValue)
        {
            writer.WriteStartElement(null, "CollData", xmlNamespace );
            CollateralDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "LvlTp", xmlNamespace );
        writer.WriteValue(LevelType.ToString()); // Enum value
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new Correction Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
