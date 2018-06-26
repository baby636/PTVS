﻿// Python Tools for Visual Studio
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using System;

namespace Microsoft.PythonTools.Analysis.LanguageServer {
    internal class LanguageServerSettings {
        public AutoCompleteSettings autoComplete;
        public DiagnosticsSettings diagnostics;

        [Serializable]
        internal class AutoCompleteSettings {
            public bool showAdvancedMembers;
        }

        [Serializable]
        internal class DiagnosticsSettings {
            public DiagnosticSeverity unresolvedImports;
        }
    }

    internal static class LanguageServerSettingsExtensions {
        public static bool Show(this DiagnosticSeverity severity) => severity != DiagnosticSeverity.Unspecified;
    }
}