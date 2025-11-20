import { Link } from 'react-router-dom';

const CTASection = () => {
  return (
    <section className="bg-blue-500 text-white py-16 px-4">
      <div className="max-w-7xl mx-auto text-center">
        <h2 className="text-3xl font-bold mb-4">Ready to Start Your Journey?</h2>
        <p className="text-xl text-blue-100 mb-8 max-w-2xl mx-auto">
          Join thousands of travelers who trust us for their hotel bookings.
        </p>
        <Link 
          to="/register" 
          className="inline-block bg-white text-blue-500 px-8 py-3 rounded-lg text-lg font-semibold hover:bg-slate-100 transition-all shadow-lg"
        >
          Sign Up Now
        </Link>
      </div>
    </section>
  );
};

export default CTASection;
