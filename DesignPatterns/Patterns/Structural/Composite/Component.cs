using System;
namespace DesignPatterns.Patterns.Structural.Composite
{
	public abstract class Component
	{
		protected readonly List<Component> _components;

		public Component()
		{
			_components = new List<Component>();
		}


		public abstract string Operation();

        /// <summary>
        /// can leave these empty or implement them... it depends on how you want leaf node to deal with these since leaf node doesn't use these
        /// </summary>
        /// <returns></returns>
        public virtual void Add(Component component)
		{
			_components.Add(component);
		}

		public virtual void Remove(Component component)
		{
			_components.Remove(component);
		}

		public abstract bool IsComposite { get; }
	}
}

