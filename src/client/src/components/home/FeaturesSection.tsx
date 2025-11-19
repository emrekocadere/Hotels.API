import FeatureCard from './FeatureCard';

const features = [
  {
    title: 'Best Hotels',
    description: 'Handpicked selection of the finest hotels worldwide with verified reviews.'
  },
  {
    title: 'Best Prices',
    description: 'Get the most competitive rates with our price match guarantee.'
  },
  {
    title: 'Secure Booking',
    description: 'Safe and secure payment processing with instant confirmation.'
  }
];

const FeaturesSection = () => {
  return (
    <section className="py-16 px-4">
      <div className="max-w-7xl mx-auto">
        <h2 className="text-3xl font-bold text-slate-900 text-center mb-12">Why Choose Us?</h2>
        <div className="grid md:grid-cols-3 gap-8">
          {features.map((feature) => (
            <FeatureCard 
              key={feature.title}
              title={feature.title}
              description={feature.description}
            />
          ))}
        </div>
      </div>
    </section>
  );
};

export default FeaturesSection;
