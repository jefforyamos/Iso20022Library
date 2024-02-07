﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RiskAssessment2.  ISO2002 ID# _hh16scSsEeuBjv5G5kw00g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates to the card issuer the level of risk associated with the transaction.
/// </summary>
public partial record RiskAssessment2
     : IIsoXmlSerilizable<RiskAssessment2>
{
    #nullable enable
    
    /// <summary>
    /// Entity providing an intermediate result of a risk assessment process.
    /// </summary>
    public PartyIdentification200? RiskAssessmentEntity { get; init; } 
    /// <summary>
    /// Type of risk assessment.
    /// </summary>
    public IsoMax35Text? RiskAssessmentType { get; init; } 
    /// <summary>
    /// Transaction is identified as high risk.
    /// </summary>
    public IsoTrueFalseIndicator? HighRiskTransaction { get; init; } 
    /// <summary>
    /// Reason for indicating a certain level of risk for the transaction.
    /// </summary>
    public IsoMax35Text? Reason { get; init; } 
    /// <summary>
    /// Risk assessment result.
    /// </summary>
    public IsoMax35Text? Result { get; init; } 
    /// <summary>
    /// Conditions noted for the risk assessment.
    /// </summary>
    public AdditionalData1? RiskCondition { get; init; } 
    /// <summary>
    /// Additional risk data associated with the transaction.
    /// </summary>
    public AdditionalRiskData1? AdditionalRiskData { get; init; } 
    /// <summary>
    /// Recommended action based on risk assessment.
    /// </summary>
    public ActionType8Code? RecommendedAction { get; init; } 
    /// <summary>
    /// Other recommended action based on risk assessment defined at national or private level.
    /// </summary>
    public IsoMax35Text? OtherRecommendedAction { get; init; } 
    /// <summary>
    /// Additional details of recommended action or other recommended action. 
    /// </summary>
    public IsoMax256Text? RecommendedActionDetails { get; init; } 
    
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
        if (RiskAssessmentEntity is PartyIdentification200 RiskAssessmentEntityValue)
        {
            writer.WriteStartElement(null, "RskAssmntNtty", xmlNamespace );
            RiskAssessmentEntityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RiskAssessmentType is IsoMax35Text RiskAssessmentTypeValue)
        {
            writer.WriteStartElement(null, "RskAssmntTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RiskAssessmentTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (HighRiskTransaction is IsoTrueFalseIndicator HighRiskTransactionValue)
        {
            writer.WriteStartElement(null, "HghRskTx", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(HighRiskTransactionValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (Reason is IsoMax35Text ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReasonValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Result is IsoMax35Text ResultValue)
        {
            writer.WriteStartElement(null, "Rslt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ResultValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RiskCondition is AdditionalData1 RiskConditionValue)
        {
            writer.WriteStartElement(null, "RskCond", xmlNamespace );
            RiskConditionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalRiskData is AdditionalRiskData1 AdditionalRiskDataValue)
        {
            writer.WriteStartElement(null, "AddtlRskData", xmlNamespace );
            AdditionalRiskDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RecommendedAction is ActionType8Code RecommendedActionValue)
        {
            writer.WriteStartElement(null, "RcmmnddActn", xmlNamespace );
            writer.WriteValue(RecommendedActionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherRecommendedAction is IsoMax35Text OtherRecommendedActionValue)
        {
            writer.WriteStartElement(null, "OthrRcmmnddActn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherRecommendedActionValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RecommendedActionDetails is IsoMax256Text RecommendedActionDetailsValue)
        {
            writer.WriteStartElement(null, "RcmmnddActnDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax256Text(RecommendedActionDetailsValue)); // data type Max256Text System.String
            writer.WriteEndElement();
        }
    }
    public static RiskAssessment2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
