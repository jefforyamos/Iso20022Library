﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarginCall2.  ISO2002 ID# _gfK1AILVEeWrrO9HojbPQA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the calculation and the resulting margin and independent amount needed to cover the risk exposure of one party versus another.
/// </summary>
public partial record MarginCall2
     : IIsoXmlSerilizable<MarginCall2>
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    public CollateralAccount2? CollateralAccountIdentification { get; init; } 
    /// <summary>
    /// Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.
    /// </summary>
    public required MarginCallResult3 MarginCallResult { get; init; } 
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    public MarginCall1? MarginDetailDueToA { get; init; } 
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    public MarginCall1? MarginDetailDueToB { get; init; } 
    /// <summary>
    /// Amount of expected margin that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    public MarginRequirement1Choice_? RequirementDetailsDueToA { get; init; } 
    /// <summary>
    /// Amount of expected margin that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    public MarginRequirement1Choice_? RequirementDetailsDueToB { get; init; } 
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToA { get; init; } 
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToB { get; init; } 
    
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
        if (CollateralAccountIdentification is CollateralAccount2 CollateralAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "CollAcctId", xmlNamespace );
            CollateralAccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MrgnCallRslt", xmlNamespace );
        MarginCallResult.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MarginDetailDueToA is MarginCall1 MarginDetailDueToAValue)
        {
            writer.WriteStartElement(null, "MrgnDtlDueToA", xmlNamespace );
            MarginDetailDueToAValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarginDetailDueToB is MarginCall1 MarginDetailDueToBValue)
        {
            writer.WriteStartElement(null, "MrgnDtlDueToB", xmlNamespace );
            MarginDetailDueToBValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequirementDetailsDueToA is MarginRequirement1Choice_ RequirementDetailsDueToAValue)
        {
            writer.WriteStartElement(null, "RqrmntDtlsDueToA", xmlNamespace );
            RequirementDetailsDueToAValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequirementDetailsDueToB is MarginRequirement1Choice_ RequirementDetailsDueToBValue)
        {
            writer.WriteStartElement(null, "RqrmntDtlsDueToB", xmlNamespace );
            RequirementDetailsDueToBValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExpectedCollateralDueToA is ExpectedCollateral2Choice_ ExpectedCollateralDueToAValue)
        {
            writer.WriteStartElement(null, "XpctdCollDueToA", xmlNamespace );
            ExpectedCollateralDueToAValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExpectedCollateralDueToB is ExpectedCollateral2Choice_ ExpectedCollateralDueToBValue)
        {
            writer.WriteStartElement(null, "XpctdCollDueToB", xmlNamespace );
            ExpectedCollateralDueToBValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MarginCall2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
