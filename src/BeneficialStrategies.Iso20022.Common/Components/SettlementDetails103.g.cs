﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails103.  ISO2002 ID# _5TJ-V5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of settlement of a transaction.
/// </summary>
public partial record SettlementDetails103
     : IIsoXmlSerilizable<SettlementDetails103>
{
    #nullable enable
    
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    public SettlementTransactionCondition21Choice_? SettlementTransactionCondition { get; init; } 
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    public Registration11Choice_? Registration { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    public Restriction6Choice_? LegalRestrictions { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    public TaxCapacityParty5Choice_? TaxCapacity { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    public GenericIdentification47? StampDutyTaxBasis { get; init; } 
    
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
        if (SettlementTransactionCondition is SettlementTransactionCondition21Choice_ SettlementTransactionConditionValue)
        {
            writer.WriteStartElement(null, "SttlmTxCond", xmlNamespace );
            SettlementTransactionConditionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Registration is Registration11Choice_ RegistrationValue)
        {
            writer.WriteStartElement(null, "Regn", xmlNamespace );
            RegistrationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LegalRestrictions is Restriction6Choice_ LegalRestrictionsValue)
        {
            writer.WriteStartElement(null, "LglRstrctns", xmlNamespace );
            LegalRestrictionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesRTGS is SecuritiesRTGS5Choice_ SecuritiesRTGSValue)
        {
            writer.WriteStartElement(null, "SctiesRTGS", xmlNamespace );
            SecuritiesRTGSValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementSystemMethod is SettlementSystemMethod5Choice_ SettlementSystemMethodValue)
        {
            writer.WriteStartElement(null, "SttlmSysMtd", xmlNamespace );
            SettlementSystemMethodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxCapacity is TaxCapacityParty5Choice_ TaxCapacityValue)
        {
            writer.WriteStartElement(null, "TaxCpcty", xmlNamespace );
            TaxCapacityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StampDutyTaxBasis is GenericIdentification47 StampDutyTaxBasisValue)
        {
            writer.WriteStartElement(null, "StmpDtyTaxBsis", xmlNamespace );
            StampDutyTaxBasisValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementDetails103 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
