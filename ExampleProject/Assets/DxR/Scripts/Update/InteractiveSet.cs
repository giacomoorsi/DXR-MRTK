// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DxR.HoloToolkit.InteractiveSet
{
    /*
    public enum SelectionType
    {
        single,
        multiple
    }

    /// <summary>
    /// A controller for managing multiple radial or tab type buttons
    /// </summary>
    public class InteractiveSet : MonoBehaviour
    {
        [Tooltip("Allow single or multiple selection")]
        public SelectionType Type = SelectionType.single;

        [Tooltip("Interactives that will be managed by this controller")]
        public List<InteractiveToggle> Interactives;

        [Tooltip("Currently selected indices or default starting indices")]
        public List<int> SelectedIndices = new List<int>();

        [Tooltip("exposed selection changed event")]
        public UnityEvent OnSelectionEvents;

        private bool mHasInit = true;

        private void Start()
        {
            UpdateInteractives();
        }

        public void UpdateInteractives()
        {
            for (int i = 0; i < Interactives.Count; ++i)
            {
                int itemIndex = i;
                // add selection event handler to each button
                Interactives[i].OnSelectEvents.AddListener(() => HandleOnSelection(itemIndex));
                if (Type == SelectionType.single)
                {
                    Interactives[i].AllowDeselect = false;
                }
                Interactives[i].HasSelection = SelectedIndices.Contains(i);
            }
            OnSelectionEvents.Invoke();
        }

        public void InitInteractives()
        {
            for (int i = 0; i < Interactives.Count; ++i)
            {
                int itemIndex = i;
                // add selection event handler to each button
                Interactives[i].OnSelectEvents.AddListener(() => HandleOnSelection(itemIndex));
                if (Type == SelectionType.single)
                {
                    Interactives[i].AllowDeselect = false;
                }
                Interactives[i].HasSelection = SelectedIndices.Contains(i);
            }
        }

        public void RemoveInteractive(int itemIndex)
        {
            Interactives[itemIndex].OnSelectEvents.RemoveListener(() => HandleOnSelection(itemIndex));
            Interactives.RemoveAt(itemIndex);
        }

        /// <summary>
        /// Sets the selected index and selected Interactive
        /// </summary>
        /// <param name="index"></param>
        public void SetSelection(int index)
        {
            if (!isActiveAndEnabled ||
                (index < 0 || Interactives.Count <= index))
            {
                return;
            }

            Interactives[index].OnInputClicked(null);
        }

        /// <summary>
        /// responds to selection events
        /// </summary>
        /// <param name="index"></param>
        private void HandleOnSelection(int index)
        {
            if (Type == SelectionType.single)
            {
                for (int i = 0; i < Interactives.Count; ++i)
                {
                    if (i != index)
                    {
                        Interactives[i].HasSelection = false;
                    }
                }

                if (!mHasInit)
                {
                    Interactives[index].HasSelection = true;
                    mHasInit = true;
                }

                SelectedIndices.Clear();
                SelectedIndices.Add(index);
            }
            else
            {
                Interactives[index].HasSelection = !Interactives[index].HasSelection;

                /*
                if (SelectedIndices.Contains(index))
                {
                    SelectedIndices.Remove(index);
                }
                else
                {
                    SelectedIndices.Add(index);
                }
                *//*
                SelectedIndices.Clear();
                for (int i = 0; i < Interactives.Count; ++i)
                {
                    if (Interactives[i].HasSelection)
                    {
                        SelectedIndices.Add(i);
                    }
                }
            }
            OnSelectionEvents.Invoke();
        }

        private void OnDestroy()
{
    for (int i = Interactives.Count - 1; i >= 0; i--)
    {
        RemoveInteractive(i);
    }
}
    }*/
}
