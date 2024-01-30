﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InputResultData4.  ISO2002 ID# _F-SBQVFEEeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an Input request.
/// </summary>
public partial record InputResultData4
{
    #nullable enable
    
    /// <summary>
    /// Type of processed input.
    /// </summary>
    public required InputCommand1Code InputCommand { get; init; } 
    /// <summary>
    /// Flag of notification of card to be entered in the POI card reader.
    /// </summary>
    public IsoTrueFalseIndicator? ConfirmedFlag { get; init; } 
    /// <summary>
    /// The number of the function key which is typed by the Customer on the POI system or the Cashier on the Sale System.
    /// </summary>
    public IsoNumber? FunctionKey { get; init; } 
    /// <summary>
    /// The input text and data given by the POI or the Sale System.
    /// </summary>
    public IsoMax20000Text? InputMessage { get; init; } 
    /// <summary>
    /// An enciphered password typed by the Customer on the POI system or the Cashier on the Sale system.
    /// </summary>
    public ContentInformationType30? Password { get; init; } 
    /// <summary>
    /// Numeric value of a handwritten signature.
    /// </summary>
    public CapturedSignature1? ImageCapturedSignature { get; init; } 
    
    #nullable disable
}
