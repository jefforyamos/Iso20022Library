﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ExpectedCollateralDetails.  ISO2002 ID# _QmevM9p-Ed-ak6NoX_4Aeg_-1089909522.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ExpectedCollateral1Choice;

/// <summary>
/// Provides the expected collateral type and direction for the variation margin and optionaly the segregated independent amount.
/// </summary>
public partial record ExpectedCollateralDetails : ExpectedCollateral1Choice_
     , IIsoXmlSerilizable<ExpectedCollateralDetails>
{
    #nullable enable
    
    /// <summary>
    /// Provides the expected collateral type and direction for the variation margin.
    /// </summary>
    public required ExpectedCollateralMovement1 VariationMargin { get; init; } 
    /// <summary>
    /// Provides the expected collateral type and direction for the segregated independent amount.
    /// </summary>
    public ExpectedCollateralMovement1? SegregatedIndependentAmount { get; init; } 
    
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
        writer.WriteStartElement(null, "VartnMrgn", xmlNamespace );
        VariationMargin.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SegregatedIndependentAmount is ExpectedCollateralMovement1 SegregatedIndependentAmountValue)
        {
            writer.WriteStartElement(null, "SgrtdIndpdntAmt", xmlNamespace );
            SegregatedIndependentAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new ExpectedCollateralDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
