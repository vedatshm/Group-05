using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace VIICGroup5Copy
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace VIICGroup5Copy.ObjectRepository
{
    public static class Descriptors
    {
        public static class Edge__HM_KI
        {
            public static _Implementation._Edge__HM_KI.__Edge__HM_KI Edge__HM_KI { get; private set; } = new _Implementation._Edge__HM_KI.__Edge__HM_KI();
        }

        public static class Edge__Instagram_Hashtag_Generator___SISTRIX
        {
            public static _Implementation._Edge__Instagram_Hashtag_Generator___SISTRIX.__Edge__Instagram_Hashtag_Generator___SISTRIX Edge__Instagram_Hashtag_Generator___SISTRIX { get; private set; } = new _Implementation._Edge__Instagram_Hashtag_Generator___SISTRIX.__Edge__Instagram_Hashtag_Generator___SISTRIX();
        }
    }
}

namespace VIICGroup5Copy._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _Edge__HM_KI._Edge__HM_KI
    {
        public class __System_Prompt_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __System_Prompt_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PxXJJuDVtEyKTjAMlPTo5w/1kG8RIDUP0yCOQ4_I_3bHw", DisplayName = "System Prompt:", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Edge__HM_KI
    {
        public class __Edge__HM_KI : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Edge__HM_KI()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "PxXJJuDVtEyKTjAMlPTo5w/vM2HtSrgmUmI2vL_sW1Z5g", DisplayName = "Edge: HM-KI", Screen = this};
                System_Prompt_ = new _Implementation._Edge__HM_KI._Edge__HM_KI.__System_Prompt_(this, null);
            }

            public _Implementation._Edge__HM_KI._Edge__HM_KI.__System_Prompt_ System_Prompt_ { get; private set; }
        }
    }

    namespace _Edge__Instagram_Hashtag_Generator___SISTRIX._Edge__Instagram_Hashtag_Generator___SISTRIX
    {
        public class __Instagram_Hashtag : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Instagram_Hashtag(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PxXJJuDVtEyKTjAMlPTo5w/gH52rrzfRUWf4j0XbwSgrg", DisplayName = "Instagram Hashtag", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Edge__Instagram_Hashtag_Generator___SISTRIX
    {
        public class __Edge__Instagram_Hashtag_Generator___SISTRIX : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Edge__Instagram_Hashtag_Generator___SISTRIX()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "PxXJJuDVtEyKTjAMlPTo5w/03IkPjn-0ESlWvOGZ3X_qg", DisplayName = "Edge: Instagram Hashtag Generator - SISTRIX", Screen = this};
                Instagram_Hashtag = new _Implementation._Edge__Instagram_Hashtag_Generator___SISTRIX._Edge__Instagram_Hashtag_Generator___SISTRIX.__Instagram_Hashtag(this, null);
            }

            public _Implementation._Edge__Instagram_Hashtag_Generator___SISTRIX._Edge__Instagram_Hashtag_Generator___SISTRIX.__Instagram_Hashtag Instagram_Hashtag { get; private set; }
        }
    }
}