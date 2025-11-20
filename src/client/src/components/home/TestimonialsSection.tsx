interface TestimonialCardProps {
  customerNumber: number;
}

const TestimonialCard = ({ customerNumber }: TestimonialCardProps) => {
  return (
    <div className="bg-white p-6 rounded-xl shadow-md">
      <div className="flex items-center mb-4">
        <div className="w-12 h-12 bg-slate-300 rounded-full mr-4"></div>
        <div>
          <div className="font-bold text-slate-900">Customer {customerNumber}</div>
          <div className="text-sm text-slate-500">Verified Guest</div>
        </div>
      </div>
      <p className="text-slate-600 italic">
        "Amazing experience! The booking process was smooth and the hotel exceeded my expectations. Highly recommended!"
      </p>
      <div className="mt-4 text-amber-400">★★★★★</div>
    </div>
  );
};

const TestimonialsSection = () => {
  return (
    <section className="py-16 px-4 bg-slate-100">
      <div className="max-w-7xl mx-auto">
        <h2 className="text-3xl font-bold text-slate-900 text-center mb-12">What Our Customers Say</h2>
        <div className="grid md:grid-cols-3 gap-8">
          {[1, 2, 3].map((i) => (
            <TestimonialCard key={i} customerNumber={i} />
          ))}
        </div>
      </div>
    </section>
  );
};

export default TestimonialsSection;
