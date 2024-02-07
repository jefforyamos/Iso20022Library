﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StressLiquidResourceRequirement1.  ISO2002 ID# _yh7egLJPEeaYqc4G3TTwhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Assumed obligations that are required to be met in cash under a hypothetical stress scenario.
/// </summary>
public partial record StressLiquidResourceRequirement1
     : IIsoXmlSerilizable<StressLiquidResourceRequirement1>
{
    #nullable enable
    
    /// <summary>
    /// Liquidity needs arising from ‘operational’ procedures over the stress horizon. This includes (but is not necessarily limited to) repayment of excess cash collateral to members, cash to non‐cash collateral substitutions by members, reductions in margin requirements and related cash collateral and provision of liquidity to facilitate settlement / delivery for non‐defaulting members.
    /// </summary>
    public required AmountAndDirection102 OperationalOutflow { get; init; } 
    /// <summary>
    /// Variation margin payment obligation of the CCP that is modelled to arise due to the default of CM1 and CM2 over the stress horizon.
    /// </summary>
    public required AmountAndDirection102 VariationMarginPaymentObligation { get; init; } 
    /// <summary>
    /// Liquidity needed by the CCP to fulfil the settlement/delivery obligations arising from the cleared trades of defaulting CM1 and CM2.
    /// </summary>
    public required AmountAndDirection102 SettlementOrDelivery { get; init; } 
    /// <summary>
    /// Other liquidity requirements not captured elsewhere. 
    /// </summary>
    public required AmountAndDirection102 Other { get; init; } 
    
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
        writer.WriteStartElement(null, "OprlOutflw", xmlNamespace );
        OperationalOutflow.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "VartnMrgnPmtOblgtn", xmlNamespace );
        VariationMarginPaymentObligation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmOrDlvry", xmlNamespace );
        SettlementOrDelivery.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Othr", xmlNamespace );
        Other.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static StressLiquidResourceRequirement1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
